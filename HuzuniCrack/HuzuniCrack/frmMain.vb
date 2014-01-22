Imports System.IO

Public Class frmMain

    Private Sub btnAdduser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdduser.Click
        WebBrowser.Navigate("199.175.51.112/adduser.php?user=" + txtUsername.Text)
        MsgBox("User now VIP on Huzuni Client")
    End Sub

    Private Sub btnHosts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHosts.Click
        Dim systempath As String = Environment.GetFolderPath(Environment.SpecialFolder.System)

        Dim hosts As String = systempath & "\" & "drivers" & "\" & "etc" & "\\" & "hosts"

        Dim writer As New StreamWriter(hosts)

        writer.Write("##HuzuniCrack Patch")
        writer.Write(Environment.NewLine)

        writer.Write("199.175.51.112 halalaboos.net")

        writer.Dispose()

        MsgBox("Hosts File Patched, You may have to restart your PC for changes to take effect")
    End Sub

    Private Sub llblHackforums_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblHackforums.LinkClicked
        Process.Start("http://www.hackforums.net/member.php?action=profile&uid=1444479")
    End Sub
End Class
