' there will only be one instance of this class.
' that instance will be the backbone of the app
' handling most of the work.

Public Class clsMainApp


    'initialize this instance
    Public Sub init()
    End Sub

    Public Sub close()

        If g_Console IsNot Nothing Then
            g_Console.Close()
        End If


    End Sub

End Class
