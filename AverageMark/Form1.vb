Public Class Form1

    Private Sub btnComputeGrade_Click(sender As Object, e As EventArgs) Handles btnComputeGrade.Click
        Dim num1, num2, num3, num4, total, average As Integer

        If Integer.TryParse(txtCalculus.Text, num1) And Integer.TryParse(txtObjectO.Text, num2) And Integer.TryParse(txtDiscrete.Text, num3) And Integer.TryParse(txtC.Text, num4) Then
            If num1 > 100 Or num2 > 100 Or num3 > 100 Or num4 > 100 Then
                MessageBox.Show("Marks per subject cannot exceed 100!")

            Else
                total = num1 + num2 + num3 + num4
                average = total / 4

                If average <= 49 Then
                    MessageBox.Show("You get a Fail")

                ElseIf average <= 64 Then
                    MessageBox.Show("Mean Grade = C")

                ElseIf average <= 74 Then
                    MessageBox.Show("Mean Grade = B")

                ElseIf average >= 75 And average <= 100 Then
                    MessageBox.Show("Mean Grade = A")

                End If

            End If
        Else
            MessageBox.Show("Invalid data input! Please enter correct values.")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Quit the program
        Application.Exit()
    End Sub

End Class