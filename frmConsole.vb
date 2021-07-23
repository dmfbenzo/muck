Public Class frmMDIChldConsole

    Private Sub frmMDIChldConsole_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        g_Console = Nothing
    End Sub

    Private Sub frmMDIChldConsole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = g_MainWindow
    End Sub
End Class
