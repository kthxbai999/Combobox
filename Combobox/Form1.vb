Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim mvar_myarray() As String = {"Mr.", "Mrs.", "Sir", "Lord", "King"}
        cboNames.DataSource = mvar_myarray
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnClickme.Click
        lblDisplay.text = "you chose: " + cbonames.text
    End Sub
End Class
