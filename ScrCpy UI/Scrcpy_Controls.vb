Imports System.Runtime.InteropServices
Imports ScrCpy_UI.Form1
Imports ScrCpy_UI.RunCMD
Public Class Scrcpy_Controls

    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2


    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean
    End Function

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, GunaGradient2Panel1.MouseDown, title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub

    Dim main As New Form1
    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        Dim scr = Screen.FromPoint(Me.Location)
        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Top + main.Height + 10)
        MyBase.OnLoad(e)
    End Sub

    Private Sub Scrcpy_Controls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        title.Text = single_ip_title
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back_button.Click
        RunCommandCom(String.Format("cd C://SCRCPY & adb -s {0} shell input keyevent 4", title.Text), "", False)
    End Sub

    Private Sub home_button_Click(sender As Object, e As EventArgs) Handles home_button.Click
        RunCommandCom(String.Format("cd C://SCRCPY & adb -s {0} shell am start -c android.intent.category.HOME -a android.intent.action.MAIN", title.Text), "", False)
    End Sub

    Private Sub menu_button_Click(sender As Object, e As EventArgs) Handles menu_button.Click
        RunCommandCom(String.Format("cd C://SCRCPY & adb -s {0} shell input keyevent 82", title.Text), "", False)
    End Sub

    Private Sub recent_Click(sender As Object, e As EventArgs) Handles recent.Click
        RunCommandCom(String.Format("cd C://SCRCPY & adb -s {0} shell input keyevent KEYCODE_APP_SWITCH", title.Text), "", False)
    End Sub
End Class