Public Class terceiroFormulario
    Private Sub terceiroFormulario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        Dim name As String
        Dim name2 As String
        Dim prof As String
        Dim MyString

        MyString = Space(1)
        name = segundoFormulado.TextName.Text
        name2 = segundoFormulado.TextName2.Text
        prof = segundoFormulado.TextName3.Text

        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click


        ListBox1.Items.Add("Nome: " & Space(1) & segundoFormulado.TextName.Text & "  " & segundoFormulado.TextName2.Text & Space(1) & "Profissão: " & Space(1) & segundoFormulado.TextName3.Text)



    End Sub


End Class