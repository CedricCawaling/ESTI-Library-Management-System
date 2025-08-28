Imports System.IO

Partial Class MainForm
    ' ========== NAVIGATION & UI ==========
    ' Includes: Navigation button handlers, panel switching, clock, SetActiveButton



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("hh:mm tt")
        lblDate.Text = DateTime.Now.ToString("MMMM d, yyyy")
    End Sub

    Private Sub SetActiveButton(activeButton As Button, activeImage As Bitmap)
        Dim defaultColor As Color = Color.FromArgb(18, 58, 4)
        Dim activeColor As Color = Color.FromArgb(54, 115, 13)

        Dim buttons As Button() = {btnHome, btnSettings, btnNotif, btnStatistics, btnLogout}
        Dim images As Bitmap() = {My.Resources.homepageS, My.Resources.Ssettings, My.Resources.Snotif, My.Resources.StatsA, My.Resources.Slogout}

        ' Reset all side buttons to default
        For i = 0 To buttons.Length - 1
            buttons(i).BackColor = defaultColor
            buttons(i).ForeColor = Color.White
            buttons(i).Image = images(i)
        Next

        ' Apply highlight only if a valid non-About button is clicked
        If activeButton IsNot Nothing AndAlso activeButton IsNot btnAbout Then
            activeButton.BackColor = activeColor
            activeButton.ForeColor = Color.White
            activeButton.Image = activeImage
            activeButton.Refresh()
        End If
    End Sub



    Private Sub NavigationButton1_Click(sender As Object, e As EventArgs) _
        Handles btnHome.Click, btnSettings.Click, btnNotif.Click, btnStatistics.Click, btnTransactions.Click, btnEntryLogs.Click, btnOPAC.Click, btnLogout.Click, btnAbout.Click


        Dim clickedButton = DirectCast(sender, Button)
        Dim activeImage As Bitmap = Nothing

        Select Case clickedButton.Name
            Case "btnHome" : ShowPanel(Homepage) : activeImage = My.Resources.actHomepage
            Case "btnSettings" : ShowPanel(Settings) : activeImage = My.Resources.actSettings
            Case "btnNotif" : ShowPanel(Notifications) : activeImage = My.Resources.actNotif
            Case "btnStatistics" : ShowPanel(Statistics) : activeImage = My.Resources.statsB
            Case "btnTransactions" : OpenAndCloseForm("Transactions")
            Case "btnEntryLogs" : OpenAndCloseForm("LogEntry")
            Case "btnOPAC" : OpenAndCloseForm("OPAC")
            Case "btnLogout"
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    IsLoggingOut = True
                    Dim loginForm As New Login()
                    loginForm.Show()
                    Me.Close()
                End If
                Exit Sub


            Case "btnAbout"
                SetActiveButton(Nothing, Nothing) ' Reset highlights from all other buttons
                ShowPanel(AboutPanel)
                Exit Sub

        End Select


        If activeImage IsNot Nothing Then SetActiveButton(clickedButton, activeImage)
    End Sub

    Private Sub ShowPanel(selectedPanel As Panel)
        Homepage.Visible = False
        Settings.Visible = False
        Notifications.Visible = False
        Statistics.Visible = False
        AboutPanel.Visible = False
        selectedPanel.Visible = True
        selectedPanel.BringToFront()
    End Sub


    Private Sub OpenAndCloseForm(formName As String)
        Select Case formName
            Case "BookManagement"
                If bookManagementInstance Is Nothing OrElse bookManagementInstance.IsDisposed Then
                    bookManagementInstance = New BookManagement()
                End If
                bookManagementInstance.Show()
            Case "Transactions"
                If transactionsInstance Is Nothing OrElse transactionsInstance.IsDisposed Then
                    transactionsInstance = New Transactions()
                End If
                transactionsInstance.Show()
            Case "LogEntry"
                If logEntryInstance Is Nothing OrElse logEntryInstance.IsDisposed Then
                    logEntryInstance = New LogEntry()
                End If
                logEntryInstance.Show()
            Case "OPAC"
                If opacInstance Is Nothing OrElse opacInstance.IsDisposed Then
                    opacInstance = New OPAC()
                End If
                opacInstance.Show()
        End Select

        Me.Hide()
    End Sub
    Private Sub btnQuickBookAdd_Click(sender As Object, e As EventArgs) Handles btnQuickBookAdd.Click
        ' Open EditAccession in "add" mode
        Dim editForm As New EditAccession
        editForm.StartPosition = FormStartPosition.CenterParent
        editForm.ShowDialog()

        ' Optional: Reload any main form data if needed after adding
        ' LoadStatistics() or RefreshBookList()
    End Sub
    Private Sub btnQuickReport_Click(sender As Object, e As EventArgs) Handles btnQuickReport.Click
        selectedMaterialTypes.Clear()
        selectedMaterialTypes.AddRange(New String() {
        "General Circulation Books",
        "Reference Books",
        "Non-Fiction Books",
        "Magazine",
        "Filipiniana Books",
        "Computer Science Books",
        "Criminology Books",
        "Tourism Books",
        "High School Books"
    })

        ExportBooksToPDF_ByMaterialType()
    End Sub

    Private Sub btnQuickLog_Click(sender As Object, e As EventArgs) Handles btnQuickLog.Click
        Dim quickLogForm As New QuickLogEntry()
        quickLogForm.ShowDialog()
    End Sub
End Class