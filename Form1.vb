'Name
'Details
Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim a As Integer 'Declaring integer value a
        a = Val(txtA.Text) 'Assigning integer value a to txtboxA
        For a = 0 To a 'For loop to check on integer values in the txt
            If a Mod 2 <> 0 Then
                ListBox1.Items.Add(a) 'Listbox displaying  integers 

            End If

        Next a 'Proceedingto the next value

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
