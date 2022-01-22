Public Class Form1

    '' Combox Lists: FormatCB, TextColorCB, BackColorCB

    Private Sub CopyCodeBtn_Click(sender As Object, e As EventArgs) Handles CopyCodeBtn.Click
        '' From FormatCB we want the number before the ":" same with TextColorCB and BackColorCB
        '' With those we will form a string i nthe format of "[<number>m" with ansi
        '' Then we will copy the string to the clipboard
        Dim ansi As String = ""
        Dim format As String = FormatCB.Text
        Dim textColor As String = TextColorCB.Text
        Dim backColor As String = BackColorCB.Text
        Dim formatNumber As String = format.Substring(0, format.IndexOf(":"))
        Dim textColorNumber As String = textColor.Substring(0, textColor.IndexOf(":"))
        '' if BackColorCB is "Clear Back Ground" then we will not add it to the ansi string"
        If backColor <> "Clear Back Ground" Then
            Dim backColorNumber As String = backColor.Substring(0, backColor.IndexOf(":"))
            ansi = "[" & formatNumber & ";" & textColorNumber & ";" & backColorNumber & "m"
        Else
            ansi = "[" & formatNumber & ";" & textColorNumber & "m"
        End If


        '' now we add the text "Change Me" after the ansi code then after that add "[0m" to reset the color
        ansi = ansi + "Change Me" + "[0m"

        TextToCopy.Text = ansi

        '' now we copy the ansi string to the clipboard
        ' Clipboard.SetText(ansi)



    End Sub
End Class
