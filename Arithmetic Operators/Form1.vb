Public Class Form1
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iNumber3 As Decimal

        iNumber1 = txtFirstNumber.Text
        iNumber2 = txtSecondNumber.Text
        'Addition
        iNumber3 = iNumber1 + iNumber2
        MessageBox.Show(iNumber1 & " " & "+" & " " & iNumber2 & " " & "=" & " " & iNumber3)

        'Subtraction
        iNumber3 = iNumber1 - iNumber2
        MessageBox.Show(iNumber1 & " " & "-" & " " & iNumber2 & " " & "=" & " " & iNumber3)

        'Multiplication
        iNumber3 = iNumber1 * iNumber2
        MessageBox.Show(iNumber1 & " " & "*" & " " & iNumber2 & " " & "=" & " " & iNumber3)

        'Division
        iNumber3 = iNumber1 / iNumber2
        MessageBox.Show(iNumber1 & " " & "/" & " " & iNumber2 & " " & "=" & " " & iNumber3)

        'The following are not popular
        'The power of
        'For powers use Shift + 6(^)
        iNumber3 = iNumber1 ^ iNumber2
        MessageBox.Show(iNumber1 & " " & "the power of" & " " & iNumber2 & " " & "=" & " " & iNumber3)

        'DIV(Integer didvision) use the back slash(\)
        iNumber3 = iNumber1 \ iNumber2
        MessageBox.Show(iNumber1 & " " & "\" & " " & iNumber2 & " " & "=" & " " & iNumber3)
    End Sub
End Class
