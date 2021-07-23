Public Class frmMain

    Private Sub mnuItmToolsConsole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItmToolsConsole.Click

        If g_Console Is Nothing Then
            g_Console = New frmMDIChldConsole
        End If

        g_Console.Show()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        g_objApp.init()

        g_MainWindow = Me

    End Sub

    'exit on the file menu was clicked, so exit this app. ###
    Private Sub mnuItmFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItmFileExit.Click

        g_objApp.close()    'tell the main object to shutdown

        Me.Close()

    End Sub

End Class
