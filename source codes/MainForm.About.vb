Imports System.Runtime.InteropServices
Partial Class MainForm
    Private Const PFM_ALIGNMENT As Integer = &H8
    Private Const PFA_JUSTIFY As Integer = 4
    Private Const EM_SETPARAFORMAT As Integer = &H447

    <StructLayout(LayoutKind.Sequential)>
    Private Structure PARAFORMAT
        Public cbSize As Integer
        Public dwMask As UInteger
        Public wAlignment As Short
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)>
        Public rgxTabs() As Integer
        ' remaining fields are omitted because they're not needed for alignment
    End Structure

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As Integer, ByRef lParam As PARAFORMAT) As IntPtr
    End Function

    Private Sub JustifyRichText(rtb As RichTextBox)
        Dim pf As New PARAFORMAT
        pf.cbSize = Marshal.SizeOf(pf)
        pf.dwMask = PFM_ALIGNMENT
        pf.wAlignment = PFA_JUSTIFY

        SendMessage(rtb.Handle, EM_SETPARAFORMAT, 0, pf)
    End Sub
End Class
