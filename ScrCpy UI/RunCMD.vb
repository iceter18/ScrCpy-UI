Public Class RunCMD
    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As New Process
        Dim pi As New ProcessStartInfo

        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub
End Class
