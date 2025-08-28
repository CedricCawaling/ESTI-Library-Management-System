Partial Class MainForm
    ' ========== ADMIN MANAGEMENT ==========
    ' Includes: AddAdminColumns, Add/Update/Delete logic, field filters, dgv click handlers
    Private Sub AddAdminColumns()
        dgvAdmins.Columns.AddRange({
            New DataGridViewTextBoxColumn With {.Name = "AdminUsername", .HeaderText = "Username", .DataPropertyName = "AdminUsername", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
            New DataGridViewTextBoxColumn With {.Name = "AdminFullname", .HeaderText = "Full Name", .DataPropertyName = "AdminFullname", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
            New DataGridViewTextBoxColumn With {.Name = "ContactInfo", .HeaderText = "Contact", .DataPropertyName = "ContactInfo", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
            New DataGridViewTextBoxColumn With {.Name = "Role", .HeaderText = "Role", .DataPropertyName = "Role", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
            New DataGridViewTextBoxColumn With {.Name = "AdminID", .DataPropertyName = "AdminID", .Visible = False},
            New DataGridViewTextBoxColumn With {.Name = "Password", .DataPropertyName = "Password", .Visible = False},
            New DataGridViewButtonColumn With {.Name = "btnEdit", .HeaderText = "", .Text = "Edit", .UseColumnTextForButtonValue = True},
            New DataGridViewButtonColumn With {.Name = "btnDelete", .HeaderText = "", .Text = "Delete", .UseColumnTextForButtonValue = True}
        })
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        If Not ValidateAdminInputs() Then
            MessageBox.Show("Fields can't be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If btnAddAdmin.Text = "Add" Then
            If adminManager.IsUsernameExists(txtAddAdminUsername.Text.Trim()) Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim hashedPassword As String = (New AdminManager()).HashPassword(DefaultPasswordText)

            If adminManager.AddAdmin(txtAddAdminUsername.Text.Trim(), txtAddAdminFullname.Text.Trim(), txtAddContact.Text.Trim(), cmbChooseRole.Text.Trim(), hashedPassword) Then
                MessageBox.Show("Admin added successfully with default password: " & DefaultPasswordText)
                RefreshAdminGrid()
                ClearAdminFields()
            End If

        ElseIf btnAddAdmin.Text = "Update" Then
            If selectedAdminID <> -1 AndAlso adminManager.IsUsernameExists(txtAddAdminUsername.Text.Trim(), selectedAdminID) Then
                MessageBox.Show("Username already exists. Please choose a different username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If selectedAdminID <> -1 AndAlso adminManager.UpdateAdmin(selectedAdminID, txtAddAdminUsername.Text.Trim(), txtAddAdminFullname.Text.Trim(), txtAddContact.Text.Trim(), cmbChooseRole.Text.Trim()) Then
                MessageBox.Show("Admin updated successfully!")
                RefreshAdminGrid()
                ClearAdminFields()
                btnAddAdmin.Text = "Add"
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If btnAddAdmin.Text = "Update" Then
            Dim confirm = MessageBox.Show("You are editing an account. Do you want to cancel editing?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.No Then Exit Sub
        End If

        ClearAdminFields()
        btnAddAdmin.Text = "Add"
    End Sub

    Private Sub ClearAdminFields()
        txtAddAdminUsername.Clear()
        txtAddAdminFullname.Clear()
        txtAddContact.Clear()
        cmbChooseRole.SelectedIndex = -1
        selectedAdminID = -1
        If dgvAdmins.SelectedRows.Count > 0 Then
            dgvAdmins.ClearSelection()
        End If
    End Sub

    Private Sub txtAddAdminUsername_TextChanged(sender As Object, e As EventArgs) Handles txtAddAdminUsername.TextChanged
        Dim filtered = FormUtils.FilterUsername(txtAddAdminUsername.Text)
        If txtAddAdminUsername.Text <> filtered Then
            Dim cursor = txtAddAdminUsername.SelectionStart - 1
            txtAddAdminUsername.Text = filtered
            txtAddAdminUsername.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Spaces are not allowed in the username.", txtAddAdminUsername, 2000)
        End If
    End Sub

    Private Sub txtAddAdminFullname_TextChanged(sender As Object, e As EventArgs) Handles txtAddAdminFullname.TextChanged
        Dim original = txtAddAdminFullname.Text
        Dim filtered = System.Text.RegularExpressions.Regex.Replace(original, "[^a-zA-Z\s]", "")
        If original <> filtered Then
            Dim cursor = txtAddAdminFullname.SelectionStart - 1
            txtAddAdminFullname.Text = filtered
            txtAddAdminFullname.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Only letters and spaces are allowed.", txtAddAdminFullname, 2000)
        End If
    End Sub

    Private Sub txtAddContact_TextChanged(sender As Object, e As EventArgs) Handles txtAddContact.TextChanged
        Dim filtered = FormUtils.FilterContact(txtAddContact.Text)
        If txtAddContact.Text <> filtered Then
            Dim cursor = txtAddContact.SelectionStart - 1
            txtAddContact.Text = filtered
            txtAddContact.SelectionStart = Math.Max(cursor, 0)
            ToolTip1.Show("Only numbers are allowed in the contact field.", txtAddContact, 2000)
        End If
    End Sub

    Private Function ValidateAdminInputs() As Boolean
        Return Not String.IsNullOrWhiteSpace(txtAddAdminUsername.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtAddAdminFullname.Text) AndAlso
               Not String.IsNullOrWhiteSpace(txtAddContact.Text) AndAlso
               cmbChooseRole.SelectedIndex <> -1
    End Function

    Private Sub RefreshAdminGrid()
        Dim originalTable As New LMSDataSet.AdminDataTable()
        Me.AdminTableAdapter.Fill(originalTable)
        Dim view As New DataView(originalTable)
        view.RowFilter = $"AdminUsername <> '{LoggedInUsername.Replace("'", "''")}'"
        dgvAdmins.DataSource = view
    End Sub

    Private Sub dgvAdmins_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdmins.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvAdmins.Rows(e.RowIndex)
            Dim drv As DataRowView = CType(row.DataBoundItem, DataRowView)

            If dgvAdmins.Columns(e.ColumnIndex).Name = "btnEdit" Then
                selectedAdminID = Convert.ToInt32(drv("AdminID"))
                txtAddAdminUsername.Text = drv("AdminUsername").ToString()
                txtAddAdminFullname.Text = drv("AdminFullname").ToString()
                txtAddContact.Text = drv("ContactInfo").ToString()
                cmbChooseRole.Text = drv("Role").ToString()
                btnAddAdmin.Text = "Update"

            ElseIf dgvAdmins.Columns(e.ColumnIndex).Name = "btnDelete" Then
                Dim confirmDelete = MessageBox.Show(
                    $"Are you sure you want to delete admin '{drv("AdminUsername")}'?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                )

                If confirmDelete = DialogResult.Yes Then
                    Dim id As Integer = Convert.ToInt32(drv("AdminID"))
                    If adminManager.DeleteAdmin(id) Then
                        MessageBox.Show("Admin deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        RefreshAdminGrid()
                        ClearAdminFields()
                        btnAddAdmin.Text = "Add"
                    Else
                        MessageBox.Show("Failed to delete admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txtAddAdminUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddAdminUsername.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtAddAdminFullname)
    End Sub
    Private Sub txtAddAdminFullname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddAdminFullname.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, txtAddContact)
    End Sub

    Private Sub txtAddContact_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddContact.KeyDown
        FormUtils.HandleEnterKeyMoveFocus(e, cmbChooseRole)
    End Sub
    Private Sub cmbChooseRole_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbChooseRole.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAddAdmin.PerformClick()
            e.SuppressKeyPress = True
        End If
    End Sub
End Class