Public Class FInicio
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        'Dim ruta As String = "http://www.uniminuto.edu/"
        'Call Shell(ruta, vbMaximizedFocus)
        'ruta.show()
        System.Diagnostics.Process.Start("http://www.uniminuto.edu/")
    End Sub
End Class