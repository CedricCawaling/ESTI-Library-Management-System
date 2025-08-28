Imports System.IO

Public Module FileHelper

    Public Function GetAppDataFolder() As String
        Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyLMSApp")
    End Function

    Public Function GetThumbnailFolder() As String
        Return Path.Combine(GetAppDataFolder(), "BookThumbnails")
    End Function

    Public Function GetLogsFolder() As String
        Return Path.Combine(GetAppDataFolder(), "Logs")
    End Function

    Public Function GetProfileFolder() As String
        Return Path.Combine(GetAppDataFolder(), "ProfilePhotos")
    End Function

    Public Sub EnsureDirectories()
        Dim folders = {GetAppDataFolder(), GetThumbnailFolder(), GetLogsFolder(), GetProfileFolder()}
        For Each folder In folders
            If Not Directory.Exists(folder) Then
                Directory.CreateDirectory(folder)
            End If
        Next
    End Sub

    Public Function GetThumbnailPath(fileName As String) As String
        Return Path.Combine(GetThumbnailFolder(), fileName)
    End Function

    Public Function GetProfileImagePath(fileName As String) As String
        Return Path.Combine(GetProfileFolder(), fileName)
    End Function

    Public Function GetSafeThumbnailImage(fileName As String) As Image
        Dim fullPath As String = GetThumbnailPath(fileName)
        If File.Exists(fullPath) Then
            Return Image.FromFile(fullPath)
        Else
            Return My.Resources.DefaultBookThumb
        End If
    End Function
    Public Function GetProfilePhotoFolderPath() As String
        Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyLMSApp", "ProfilePhotos")
    End Function
End Module
