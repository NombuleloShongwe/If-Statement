Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim firstNumber As Double
        Dim secondNumber As Double

        firstNumber = Val(TextBox1.Text)
        secondNumber = Val(TextBox2.Text)

        If firstNumber > secondNumber Then
            TextBox3.Text = firstNumber
        Else
            TextBox3.Text = secondNumber
        End If
    End Sub
End Class
