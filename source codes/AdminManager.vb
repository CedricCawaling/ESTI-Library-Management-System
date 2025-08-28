Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class AdminManager


    ' ✅ Hash password using SHA256 (Hex format for consistency)
    Public Function HashPassword(password As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes = Encoding.UTF8.GetBytes(password)
            Dim hash = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function

    ' ✅ Add new admin with default password
    Public Function AddAdmin(username As String, fullname As String, contact As String, role As String, password As String) As Boolean
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("INSERT INTO Admin (AdminUsername, AdminFullname, ContactInfo, Role, Password) VALUES (@username, @fullname, @contact, @role, @password)", con)
            cmd.Parameters.AddWithValue("@username", username)
            cmd.Parameters.AddWithValue("@fullname", fullname)
            cmd.Parameters.AddWithValue("@contact", contact)
            cmd.Parameters.AddWithValue("@role", role)
            cmd.Parameters.AddWithValue("@password", password)


            con.Open()
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function


    ' ✅ Update admin details
    Public Function UpdateAdmin(adminID As Integer, username As String, fullname As String, contact As String, role As String) As Boolean
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE Admin SET AdminUsername=@Username, AdminFullname=@Fullname, ContactInfo=@Contact, Role=@Role WHERE AdminID=@AdminID", con)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Fullname", fullname)
            cmd.Parameters.AddWithValue("@Contact", contact)
            cmd.Parameters.AddWithValue("@Role", role)
            cmd.Parameters.AddWithValue("@AdminID", adminID)

            con.Open()
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    ' ✅ Delete admin by ID
    Public Function DeleteAdmin(adminID As Integer) As Boolean
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("DELETE FROM Admin WHERE AdminID=@AdminID", con)
            cmd.Parameters.AddWithValue("@AdminID", adminID)

            con.Open()
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

    ' ✅ Check if username exists (case-sensitive)
    Public Function IsUsernameExists(username As String, Optional excludeID As Integer = -1) As Boolean
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim query As String = "SELECT COUNT(*) FROM Admin WHERE AdminUsername COLLATE SQL_Latin1_General_CP1_CS_AS = @username"
            If excludeID <> -1 Then
                query &= " AND AdminID <> @excludeID"
            End If

            Dim cmd As New SqlCommand(query, con)
            cmd.Parameters.AddWithValue("@username", username)
            If excludeID <> -1 Then
                cmd.Parameters.AddWithValue("@excludeID", excludeID)
            End If

            con.Open()
            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    ' ✅ Count all Librarian accounts
    Public Function CountLibrarians() As Integer
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Admin WHERE Role = 'Librarian'", con)
            con.Open()
            Return CInt(cmd.ExecuteScalar())
        End Using
    End Function

    ' ✅ Validate password for the currently logged-in user
    Public Function ValidatePassword(username As String, plainPassword As String) As Boolean
        Dim hashedInput = HashPassword(plainPassword)
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Admin WHERE AdminUsername = @u AND Password = @p", con)
            cmd.Parameters.AddWithValue("@u", username)
            cmd.Parameters.AddWithValue("@p", hashedInput)
            con.Open()
            Return CInt(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    ' ✅ Update password by username
    Public Function UpdatePassword(username As String, newPassword As String) As Boolean
        Dim hashed = HashPassword(newPassword)
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE Admin SET Password = @p WHERE AdminUsername = @u", con)
            cmd.Parameters.AddWithValue("@p", hashed)
            cmd.Parameters.AddWithValue("@u", username)
            con.Open()
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function
    Public Function GetOTPSecret(username As String) As String
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("SELECT OTPSecret FROM Admin WHERE AdminUsername = @u", con)
            cmd.Parameters.AddWithValue("@u", username)
            con.Open()
            Dim result = cmd.ExecuteScalar()
            Return If(result IsNot Nothing AndAlso Not DBNull.Value.Equals(result), result.ToString(), "")
        End Using
    End Function
    Public Function SetOTPSecret(username As String, secret As String) As Boolean
        Dim connectionString As String = FormUtils.GetConnectionString()
        Using con As New SqlConnection(connectionString)
            Dim cmd As New SqlCommand("UPDATE Admin SET OTPSecret = @secret WHERE AdminUsername = @u", con)
            cmd.Parameters.AddWithValue("@secret", secret)
            cmd.Parameters.AddWithValue("@u", username)
            con.Open()
            Return cmd.ExecuteNonQuery() > 0
        End Using
    End Function

End Class
