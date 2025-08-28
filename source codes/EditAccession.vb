Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO

Public Class EditAccession
    Public IsEditMode As Boolean = False
    Public BookID As Integer
    Private selectedPhotoPath As String = ""
    Private photoFolderPath As String = FileHelper.GetThumbnailFolder()


    Private Sub EditAccession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileHelper.EnsureDirectories()
        FormUtils.ApplyFontToAllControls(Me, FormUtils.SafeFont)
        updownVolume.Maximum = 9999
        updownPages.Maximum = 9999

        AddHandler txtTitle.TextChanged, AddressOf FieldContentChanged
        AddHandler txtAuthor.TextChanged, AddressOf FieldContentChanged
        AddHandler txtEdition.TextChanged, AddressOf FieldContentChanged
        AddHandler txtPublisher.TextChanged, AddressOf FieldContentChanged
        AddHandler txtRemarks.TextChanged, AddressOf FieldContentChanged
        AddHandler cmbMaterial.TextChanged, AddressOf FieldContentChanged
        AddHandler cmbYear.TextChanged, AddressOf FieldContentChanged
        AddHandler txtCostPrice.TextChanged, AddressOf FieldContentChanged
        AddHandler updownVolume.ValueChanged, AddressOf FieldContentChanged
        AddHandler updownPages.ValueChanged, AddressOf FieldContentChanged
        cmbMaterial.Items.AddRange(New String() {"General Circulation Books", "Reference Books", "Non-Fiction Books", "Magazine", "Filipiniana Books", "Computer Science Books", "Criminology Books", "Tourism Books", "High School Books"})
        cmbMaterial.SelectedItem = "General Circulation Books"
        txtBookID.ReadOnly = True


        Dim currentYear As Integer = DateTime.Now.Year
        cmbYear.Items.Clear()
        For year As Integer = currentYear To currentYear - 30 Step -1
            cmbYear.Items.Add(year.ToString())
        Next

        If Not IsEditMode Then
            GenerateNextBookID()
        End If
        ToolTip1.SetToolTip(txtCostPrice, "Numbers only (e.g., 100 or 99.99)")
        Me.FormBorderStyle = FormBorderStyle.None
        Me.BackColor = Color.Magenta
        Me.TransparencyKey = Color.Magenta
        Me.AllowTransparency = True
        UpdateCancelButtonText()

        If Not Directory.Exists(photoFolderPath) Then
            Directory.CreateDirectory(photoFolderPath)
        End If

    End Sub

    Private Sub GenerateNextBookID()
        Try
            Dim query As String = "SELECT ISNULL(MAX(BookID), 0) + 1 FROM dbo.Accession"
            Dim connectionString As String = FormUtils.GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    conn.Open()
                    Dim nextID As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    txtBookID.Text = "B" & nextID.ToString("D4")
                    BookID = nextID
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating next Book ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub LoadBookData(row As DataGridViewRow)
        Dim bookIDStr As String = row.Cells("BookID").Value.ToString().Replace("B", "").Trim()
        BookID = Convert.ToInt32(bookIDStr)
        txtBookID.Text = "B" & BookID.ToString("D4")

        txtTitle.Text = If(IsDBNull(row.Cells("BookTitle").Value), "", row.Cells("BookTitle").Value.ToString())
        pickDateRecieved.Value = If(IsDBNull(row.Cells("DateReceived").Value), DateTime.Today, Convert.ToDateTime(row.Cells("DateReceived").Value))
        txtAuthor.Text = If(IsDBNull(row.Cells("Author").Value), "", row.Cells("Author").Value.ToString())
        cmbMaterial.Text = If(IsDBNull(row.Cells("MaterialType").Value), "", row.Cells("MaterialType").Value.ToString())
        txtEdition.Text = If(IsDBNull(row.Cells("Edition").Value), "", row.Cells("Edition").Value.ToString())

        ' Safe decimal parsing for Volume
        Dim volumeValue As Decimal = 0
        If Not IsDBNull(row.Cells("Volume").Value) AndAlso Decimal.TryParse(row.Cells("Volume").Value.ToString(), volumeValue) Then
            updownVolume.Value = Math.Min(volumeValue, updownVolume.Maximum)
        Else
            updownVolume.Value = 0
        End If

        ' Safe integer parsing for Pages
        Dim pagesValue As Integer = 0
        If Not IsDBNull(row.Cells("Pages").Value) AndAlso Integer.TryParse(row.Cells("Pages").Value.ToString(), pagesValue) Then
            updownPages.Value = Math.Min(pagesValue, updownPages.Maximum)
        Else
            updownPages.Value = 0
        End If



        ' Safe currency formatting for CostPrice
        If Not IsDBNull(row.Cells("CostPrice").Value) AndAlso Decimal.TryParse(row.Cells("CostPrice").Value.ToString(), volumeValue) Then
            txtCostPrice.Text = "₱" & volumeValue.ToString("N2")
        Else
            txtCostPrice.Text = ""
        End If

        txtPublisher.Text = If(IsDBNull(row.Cells("Publisher").Value), "", row.Cells("Publisher").Value.ToString())
        txtRemarks.Text = If(IsDBNull(row.Cells("Remarks").Value), "", row.Cells("Remarks").Value.ToString())

        ' Load photo
        ' Load photo
        Dim photoFile As String = If(IsDBNull(row.Cells("PhotoPath").Value), "", row.Cells("PhotoPath").Value.ToString())
        lblFilePath.Text = photoFile

        Try
            picThumbnail.Image = FileHelper.GetSafeThumbnailImage(photoFile)
        Catch ex As Exception
            MessageBox.Show("Failed to load book thumbnail: " & ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            picThumbnail.Image = My.Resources.DefaultBookThumb
        End Try



        IsEditMode = True
    End Sub



    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        Try
            If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse String.IsNullOrWhiteSpace(txtAuthor.Text) OrElse String.IsNullOrWhiteSpace(txtPublisher.Text) Then
                MessageBox.Show("Please fill in all required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim photoFileName As String = lblFilePath.Text
            If Not String.IsNullOrEmpty(selectedPhotoPath) AndAlso File.Exists(selectedPhotoPath) Then
                photoFileName = Path.GetFileName(selectedPhotoPath)
                Dim destPath = Path.Combine(photoFolderPath, photoFileName)
                File.Copy(selectedPhotoPath, destPath, True)
            End If
            Dim connectionString As String = FormUtils.GetConnectionString()
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim cmd As SqlCommand

                If IsEditMode Then
                    cmd = New SqlCommand("UPDATE dbo.Accession SET BookTitle=@Title, DateReceived=@DateReceived, Author=@Author, MaterialType=@MaterialType, Edition=@Edition, Volume=@Volume, Year=@Year, Pages=@Pages, CostPrice=@CostPrice, Publisher=@Publisher, Remarks=@Remarks, PhotoPath=@Photo WHERE BookID=@BookID", conn)
                    cmd.Parameters.AddWithValue("@BookID", BookID)
                Else
                    cmd = New SqlCommand("INSERT INTO dbo.Accession (BookTitle, DateReceived, Author, MaterialType, Edition, Volume, Year, Pages, CostPrice, Publisher, Remarks, PhotoPath) VALUES (@Title, @DateReceived, @Author, @MaterialType, @Edition, @Volume, @Year, @Pages, @CostPrice, @Publisher, @Remarks, @Photo)", conn)
                End If

                cmd.Parameters.AddWithValue("@Title", txtTitle.Text.Trim())
                cmd.Parameters.AddWithValue("@DateReceived", pickDateRecieved.Value)
                cmd.Parameters.AddWithValue("@Author", txtAuthor.Text.Trim())
                cmd.Parameters.AddWithValue("@MaterialType", cmbMaterial.Text.Trim())
                cmd.Parameters.AddWithValue("@Edition", txtEdition.Text.Trim())
                cmd.Parameters.AddWithValue("@Volume", updownVolume.Value)
                cmd.Parameters.AddWithValue("@Year", cmbYear.Text.Trim())
                cmd.Parameters.AddWithValue("@Pages", updownPages.Value)

                Dim rawCost As Decimal = 0
                Decimal.TryParse(txtCostPrice.Text.Replace("₱", "").Replace(",", "").Trim(), rawCost)
                cmd.Parameters.AddWithValue("@CostPrice", rawCost)

                cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text.Trim())
                cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim())
                cmd.Parameters.AddWithValue("@Photo", photoFileName)

                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("An error occurred while saving the book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub InsertBook()
        Dim query As String = "INSERT INTO dbo.Accession (BookTitle, DateReceived, Author, MaterialType, Edition, Volume, Year, Pages, Publisher, Remarks) " &
                              "VALUES (@BookTitle, @DateReceived, @Author, @MaterialType, @Edition, @Volume, @Year, @Pages, @Publisher, @Remarks)"
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                AddParameters(cmd)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub UpdateBook()
        Dim query As String = "UPDATE dbo.Accession SET BookTitle=@BookTitle, DateReceived=@DateReceived, Author=@Author, MaterialType=@MaterialType, " &
                              "Edition=@Edition, Volume=@Volume, Year=@Year, Pages=@Pages, Publisher=@Publisher, Remarks=@Remarks WHERE BookID=@BookID"
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                AddParameters(cmd)
                cmd.Parameters.AddWithValue("@BookID", BookID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        If Not String.IsNullOrEmpty(selectedPhotoPath) AndAlso File.Exists(selectedPhotoPath) Then
            If Not Directory.Exists(photoFolderPath) Then
                Directory.CreateDirectory(photoFolderPath)
            End If

            Dim fileName = Path.GetFileName(selectedPhotoPath)
            Dim destinationPath = Path.Combine(photoFolderPath, fileName)

            ' Optionally overwrite or rename
            File.Copy(selectedPhotoPath, destinationPath, True)

            ' Save destinationPath to DB if needed
        End If

    End Sub

    Private Sub AddParameters(cmd As SqlCommand)
        cmd.Parameters.AddWithValue("@BookTitle", txtTitle.Text.Trim())
        cmd.Parameters.AddWithValue("@DateReceived", pickDateRecieved.Value)
        cmd.Parameters.AddWithValue("@Author", txtAuthor.Text.Trim())
        cmd.Parameters.AddWithValue("@MaterialType", cmbMaterial.Text.Trim())
        cmd.Parameters.AddWithValue("@Edition", txtEdition.Text.Trim())
        cmd.Parameters.AddWithValue("@Volume", updownVolume.Value)
        cmd.Parameters.AddWithValue("@Year", cmbYear.Text.Trim())
        cmd.Parameters.AddWithValue("@Pages", updownPages.Value)
        cmd.Parameters.AddWithValue("@Publisher", txtPublisher.Text.Trim())
        cmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text.Trim())
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnCancel.Text = "Clear" Then
            txtTitle.Clear()
            pickDateRecieved.Value = DateTime.Today
            txtAuthor.Clear()
            cmbMaterial.SelectedIndex = -1
            txtEdition.Clear()
            updownVolume.Value = 0
            cmbYear.SelectedIndex = -1
            updownPages.Value = 0
            txtPublisher.Clear()
            txtRemarks.Clear()
            UpdateCancelButtonText()
        Else
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub FieldContentChanged(sender As Object, e As EventArgs)
        UpdateCancelButtonText()
    End Sub

    Private Sub UpdateCancelButtonText()
        Dim hasContent As Boolean =
        Not String.IsNullOrWhiteSpace(txtTitle.Text) OrElse
        Not String.IsNullOrWhiteSpace(txtAuthor.Text) OrElse
        Not String.IsNullOrWhiteSpace(txtPublisher.Text) OrElse
        Not String.IsNullOrWhiteSpace(txtEdition.Text) OrElse
        Not String.IsNullOrWhiteSpace(txtRemarks.Text) OrElse
        (Not String.IsNullOrWhiteSpace(cmbMaterial.Text) AndAlso cmbMaterial.Text <> "General Circulation Books") OrElse
        Not String.IsNullOrWhiteSpace(cmbYear.Text) OrElse
        updownVolume.Value > 0 OrElse
        updownPages.Value > 0

        btnCancel.Text = If(hasContent, "Clear", "Cancel")
    End Sub

    Private Sub btnChoosePhoto_Click(sender As Object, e As EventArgs) Handles btnChoosePhoto.Click
        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                Dim selectedPath As String = ofd.FileName
                Dim newFileName As String = $"Book_{BookID}_{Path.GetFileName(selectedPath)}"
                FileHelper.EnsureDirectories()
                Dim destinationPath As String = FileHelper.GetThumbnailPath(newFileName)


                ' Copy selected photo to BookThumbnails folder
                Try
                    File.Copy(selectedPath, destinationPath, True)
                    picThumbnail.Image = Image.FromFile(destinationPath)
                    lblFilePath.Text = newFileName ' Store only the filename (not full path)
                Catch ex As Exception
                    MessageBox.Show("Failed to copy and load photo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End Using
    End Sub
    Private Sub txtCostPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostPrice.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        ' Only allow one decimal point
        If e.KeyChar = "." AndAlso txtCostPrice.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCostPrice_Leave(sender As Object, e As EventArgs) Handles txtCostPrice.Leave
        Dim costValue As Decimal
        If Decimal.TryParse(txtCostPrice.Text, costValue) Then
            txtCostPrice.Text = "₱" & costValue.ToString("N2") ' Format as ₱1,234.56
        End If
    End Sub



End Class