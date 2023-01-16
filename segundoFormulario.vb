Imports System.Drawing.Text

Public Class segundoFormulado

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mskDataAtual.Text = Date.Now.Date

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim nascimento As Date
        Dim atual As Date = mskDataAtual.Text
        Dim resultado_dias As Double
        Dim ano As Double
        Dim resto As Double
        Dim mes As Double
        Dim resto_mes As Double
        Dim name As String
        Dim name2 As String
        Dim prof As String
        Dim MyString
        Dim desc_mes As String = ""
        Dim desc_dia As String = ""
        Dim dias_vida As Integer = 0






        name = TextName.Text


        name2 = TextName2.Text
        MessageBox.Show("Bem vindo:  " & name & Space(1) & name2)

        prof = TextName3.Text


        MyString = Space(1)


        nascimento = mskDataNascimento.Text



        resultado_dias = DateDiff(DateInterval.Day, nascimento, atual)


        ano = resultado_dias / 365



        If ano >= 18 Then
            MessageBox.Show("É maior de 18 anos")
        Else
            MessageBox.Show("É menor de 18 anos")
        End If



        resto = (resultado_dias Mod 365)


        If resto = 0 Then
            mes = 0
            desc_mes = "mês"

            dias_vida = 0
            desc_dia = "dia"

        ElseIf resto > 0 And resto < 30 Then
            mes = 0
            desc_mes = "mês"

            dias_vida = resto
            desc_dia = "dia"

            If dias_vida > 1 Then
                desc_dia = "dias"
            End If
        ElseIf resto > 30 Then




            mes = resto / 30

            If Int(mes) > 1 Then
                desc_mes = "meses"
            Else
                desc_mes = "mês"
            End If


            resto_mes = (resto Mod 30)




            Dim ano1, mes1, dia1 As Integer
            Dim dr As Date


            dr = mskDataAtual.Text
            dia1 = dr.Day
            mes1 = dr.Month
            ano1 = dr.Year




            Dim ano2, mes2, dia2 As Integer
            Dim dr2 As Date

            Dim dnascimento As String

            dr2 = mskDataNascimento.Text
            dia2 = dr2.Day
            mes2 = dr2.Month
            ano2 = dr2.Year

            dnascimento = dia2 & "/" & mes1 & "/" & ano1


            Dim bissexto As Integer = 0



            If dnascimento = "31/11/" & ano1 Then
                dnascimento = "30/11/" & ano1
            ElseIf dnascimento = "31/9/" & ano1 Then
                dnascimento = "30/09/" & ano1
            ElseIf dnascimento = "31/6/" & ano1 Then
                dnascimento = "30/06/" & ano1
            ElseIf dnascimento = "31/4/" & ano1 Then
                dnascimento = "30/04/" & ano1
            ElseIf (dnascimento = "31/2/" & ano1) Or (dnascimento = "30/2/" & ano1) Or (dnascimento = "29/2/" & ano1) Then


                If (dnascimento = "31/2/" & ano1) Then
                    bissexto = 31
                ElseIf (dnascimento = "30/2/" & ano1) Then
                    bissexto = 30
                End If




                If (ano1 Mod 4 = 0) Then


                    dnascimento = "29/02/" & ano1
                Else
                    dnascimento = "28/02/" & ano1
                End If

            End If



            If dia2 = dia1 Then

                dias_vida = 0

            Else


                If dia1 > dia2 Then
                    dias_vida = dia1 - dia2


                Else
                    mes = mes - 1

                    Dim mes_anterior As Date = dnascimento


                    If dnascimento = "30/11/" & ano1 Then
                        mes_anterior = dnascimento
                        mes_anterior = mes_anterior.AddMonths(-1)
                        mes_anterior = mes_anterior.AddDays(1)
                    ElseIf dnascimento = "30/09/" & ano1 Then
                        mes_anterior = dnascimento
                        mes_anterior = mes_anterior.AddMonths(-1)
                        mes_anterior = mes_anterior.AddDays(1)
                    ElseIf dnascimento = "30/06/" & ano1 Then
                        mes_anterior = dnascimento
                        mes_anterior = mes_anterior.AddMonths(-1)
                        mes_anterior = mes_anterior.AddDays(1)
                    ElseIf dnascimento = "30/04/" & ano1 Then
                        mes_anterior = dnascimento
                        mes_anterior = mes_anterior.AddMonths(-1)
                        mes_anterior = mes_anterior.AddDays(1)
                    ElseIf dnascimento = "29/02/" & ano1 Then

                        If bissexto = 30 Then
                            mes_anterior = dnascimento
                            mes_anterior = mes_anterior.AddMonths(-1)
                            mes_anterior = mes_anterior.AddDays(1)

                        ElseIf bissexto = 31 Then
                            mes_anterior = dnascimento
                            mes_anterior = mes_anterior.AddMonths(-1)
                            mes_anterior = mes_anterior.AddDays(2)

                        End If




                    ElseIf dnascimento = "28/02/" & ano1 Then
                        mes_anterior = dnascimento
                        mes_anterior = mes_anterior.AddMonths(-1)
                        mes_anterior = mes_anterior.AddDays(3)
                    Else



                        mes_anterior = dnascimento
                        mes_anterior = mes_anterior.AddMonths(-1)
                    End If



                    dias_vida = DateDiff(DateInterval.Day, mes_anterior, atual)

                End If



            End If


        End If

        If dias_vida > 1 Then
            desc_dia = "dias"
        Else
            desc_dia = "dia"
        End If


        lblIdade.Text = Int(ano) & " anos " & Int(mes) & " " & desc_mes & " e " & dias_vida & " " & desc_dia

        lblDias.Text = resultado_dias


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(ListBox1.SelectedItem)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        ListBox1.Items.Add("Nome: " & Space(1) & TextName.Text & "  " & TextName2.Text & Space(1) & "Profissão: " & Space(1) & TextName3.Text)


    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim terceiroFormulario As New terceiroFormulario()
        terceiroFormulario.ShowDialog()
    End Sub


End Class
