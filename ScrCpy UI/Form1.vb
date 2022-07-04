Imports System.IO
Imports System.Net.NetworkInformation
Imports ScrCpy_UI.RunCMD


Public Class Form1

    Dim appPath As String = "cd " & Path.GetDirectoryName(Application.ExecutablePath) & "\SCRCPY\"
    Public Shared single_ip_title As String

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        Dim scr = Screen.FromPoint(Me.Location)
        Me.Location = New Point(scr.WorkingArea.Right - Me.Width, scr.WorkingArea.Top)
        MyBase.OnLoad(e)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RunCommandCom(appPath, "", False)

        Dim myNetworkAdapters() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim myAdapterProps As IPInterfaceProperties = Nothing
        Dim myGateways As GatewayIPAddressInformationCollection = Nothing

        For Each adapter As NetworkInterface In myNetworkAdapters
            myAdapterProps = adapter.GetIPProperties
            myGateways = myAdapterProps.GatewayAddresses

            For Each Gateway As GatewayIPAddressInformation In myGateways
                If Not Gateway.Address.ToString = "0.0.0.0" Then
                    single_IP.Text = Gateway.Address.ToString
                End If
            Next

        Next

        max_size.Text = My.Settings.MaxSize
        bit_rate.Text = My.Settings.BitRate
        max_frame.Text = My.Settings.MaxFrame
        lock_orientation.SelectedIndex = My.Settings.LockOrientation
        borderless.Checked = My.Settings.Borderless
        always_top.Checked = My.Settings.AlwaysTop
        fullscreen.Checked = My.Settings.Fullscreen
        read_only.Checked = My.Settings.NoControl
        screen_off.Checked = My.Settings.ScreenOff
        render_expired_frames.Checked = My.Settings.ExpiredFrames
        show_touches.Checked = My.Settings.ShowTouches
        SoftKboard.Checked = My.Settings.OpenGL
        keep_awake.Checked = My.Settings.Awake
        nav_box.Text = My.Settings.Nav_Box
        crop_box.Checked = My.Settings.Crop_check
        crop_length.Text = My.Settings.Crop_length
        crop_width.Text = My.Settings.Crop_width
        offsetLength.Text = My.Settings.OffsetLength
        offsetWidth.Text = My.Settings.OffsetWidth
    End Sub

    Dim soft As String = ""
    Dim nav As String = ""

    Private Sub connect_Click(sender As Object, e As EventArgs) Handles connect.Click

        If SoftKboard.Checked = True Then
            soft = String.Format(" & adb -s {0}:5555 shell ime set com.wparam.nullkeyboard/.NullKeyboard", single_IP.Text)
        End If

        If navibar.Checked = True Then
            nav = String.Format(" & adb shell wm overscan 0,0,0, -{0}", nav_box.Text)
        End If

        Dim comm As String = String.Format("cd C://SCRCPY & adb connect {0}:5555 {5} {6} & scrcpy -m{1} -b{2}M --max-fps {3} --lock-video-orientation {4}",
                                           single_IP.Text, max_size.Text, bit_rate.Text, max_frame.Text, lock_orientation.SelectedIndex.ToString, soft, nav)

        Dim command As New System.Text.StringBuilder(comm)

        If borderless.Checked = True Then
            command.Append(" --window-borderless")
        End If

        If fullscreen.Checked = True Then
            command.Append(" -f")
        End If

        If always_top.Checked = True Then
            command.Append(" --always-on-top")
        End If

        If read_only.Checked = True Then
            command.Append(" -n")
        End If

        If screen_off.Checked = True Then
            command.Append(" -S")
        End If

        If render_expired_frames.Checked = True Then
            command.Append(" --render-expired-frames")
        End If

        If show_touches.Checked = True Then
            command.Append(" -t")
        End If

        If keep_awake.Checked = True Then
            command.Append(" -w")
        End If

        If crop_box.Checked Then
            command.Append(String.Format(" --crop {0}:{1}:{2}:{3}", crop_length.Text, crop_width.Text, offsetLength.Text, offsetWidth.Text))
        End If

        RunCommandCom(command.ToString, "", False)

        single_ip_title = single_IP.Text
        Dim cont As New Scrcpy_Controls
        'cont.Show()

    End Sub

    Private Sub add_multi_IP_Click(sender As Object, e As EventArgs) Handles add_multi_IP.Click

        If SoftKboard.Checked = True Then
            soft = String.Format(" & adb -s {0}:5555 shell ime set com.wparam.nullkeyboard/.NullKeyboard", multi_IP.Text)
        End If

        If navibar.Checked = True Then
            nav = String.Format(" & adb shell wm overscan 0,0,0, -{0}", nav_box.Text)
        End If

        Dim comm As String = String.Format("cd C://SCRCPY {5} {6} & scrcpy -s {0}:5555 -m{1} -b{2}M --max-fps {3} --lock-video-orientation {4}",
                                           multi_IP.Text, max_size.Text, bit_rate.Text, max_frame.Text, lock_orientation.SelectedIndex.ToString, soft, nav)

        Dim command As New System.Text.StringBuilder(comm)

        If borderless.Checked = True Then
            command.Append(" --window-borderless")
        End If

        If fullscreen.Checked = True Then
            command.Append(" -f")
        End If

        If always_top.Checked = True Then
            command.Append(" --always-on-top")
        End If

        If read_only.Checked = True Then
            command.Append(" -n")
        End If

        If screen_off.Checked = True Then
            command.Append(" -S")
        End If

        If render_expired_frames.Checked = True Then
            command.Append(" --render-expired-frames")
        End If

        If show_touches.Checked = True Then
            command.Append(" -t")
        End If

        If keep_awake.Checked = True Then
            command.Append(" -w")
        End If

        If crop_box.Checked Then
            command.Append(String.Format(" --crop {0}:{1}:{2}:{3}", crop_length.Text, crop_width.Text, offsetLength.Text, offsetWidth.Text))
        End If

        RunCommandCom(command.ToString, "", False)

        single_ip_title = multi_IP.Text
        Dim cont As New Scrcpy_Controls
        'cont.Show()
    End Sub

    Private Sub add_multi_serial_Click(sender As Object, e As EventArgs) Handles add_multi_serial.Click
        If SoftKboard.Checked = True Then
            soft = String.Format(" & adb -s {0} shell ime set com.wparam.nullkeyboard/.NullKeyboard", multi_serial.Text)
        End If

        If navibar.Checked = True Then
            nav = String.Format(" & adb shell wm overscan 0,0,0, -{0}", nav_box.Text)
        End If

        Dim comm As String = String.Format("cd C://SCRCPY {5} {6} & scrcpy -s {0} -m{1} -b{2}M --max-fps {3} --lock-video-orientation {4}",
                                           single_IP.Text, max_size.Text, bit_rate.Text, max_frame.Text, lock_orientation.SelectedIndex.ToString, soft, nav)

        Dim command As New System.Text.StringBuilder(comm)

        If borderless.Checked = True Then
            command.Append(" --window-borderless")
        End If

        If fullscreen.Checked = True Then
            command.Append(" -f")
        End If

        If always_top.Checked = True Then
            command.Append(" --always-on-top")
        End If

        If read_only.Checked = True Then
            command.Append(" -n")
        End If

        If screen_off.Checked = True Then
            command.Append(" -S")
        End If

        If render_expired_frames.Checked = True Then
            command.Append(" --render-expired-frames")
        End If

        If show_touches.Checked = True Then
            command.Append(" -t")
        End If

        If keep_awake.Checked = True Then
            command.Append(" -w")
        End If

        If crop_box.Checked Then
            command.Append(String.Format(" --crop {0}:{1}:{2}:{3}", crop_length.Text, crop_width.Text, offsetLength.Text, offsetWidth.Text))
        End If

        RunCommandCom(command.ToString, "", False)

        single_ip_title = multi_serial.Text
        Dim cont As New Scrcpy_Controls
        'cont.Show()
    End Sub

    Private Sub record_screen_Click(sender As Object, e As EventArgs) Handles record_screen.Click
        Dim now As String = DateTime.Now.ToString("MMM-dd-yyyy-HHmmss")
        Dim filename As String = "RECORDS\" + now & ".mp4"
        RunCommandCom("cd C://SCRCPY & scrcpy --window-title=RECORDING... --record " & filename, "", True)
    End Sub

    Private Sub view_records_Click(sender As Object, e As EventArgs) Handles view_records.Click
        Process.Start("C://SCRCPY/RECORDS")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        RunCommandCom("cd C://SCRCPY & adb shell ime set com.google.android.inputmethod.latin/com.android.inputmethod.latin.LatinIME & adb shell wm overscan 0,0,0,0", "", False)

        My.Settings.MaxSize = max_size.Text
        My.Settings.BitRate = bit_rate.Text
        My.Settings.MaxFrame = max_frame.Text
        My.Settings.LockOrientation = lock_orientation.SelectedIndex
        My.Settings.Borderless = borderless.Checked.ToString
        My.Settings.AlwaysTop = always_top.Checked.ToString
        My.Settings.Fullscreen = fullscreen.Checked.ToString
        My.Settings.NoControl = read_only.Checked.ToString
        My.Settings.ScreenOff = screen_off.Checked.ToString
        My.Settings.ExpiredFrames = render_expired_frames.Checked.ToString
        My.Settings.ShowTouches = show_touches.Checked.ToString
        My.Settings.OpenGL = SoftKboard.Checked.ToString
        My.Settings.Navi = navibar.Checked.ToString
        My.Settings.Awake = keep_awake.Checked.ToString
        My.Settings.Crop_check = crop_box.Checked
        My.Settings.Crop_length = crop_length.Text
        My.Settings.Crop_width = crop_width.Text
        My.Settings.OffsetLength = offsetLength.Text
        My.Settings.OffsetWidth = offsetWidth.Text
    End Sub
End Class
