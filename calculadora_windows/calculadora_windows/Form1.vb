Public Class Form1
    Dim operacao As String
    Dim valor As Single


    Function fazerconta(ByVal valor As Single, ByVal operacao As String, ByVal novaoperacao As String) As Single
        If operacao = "+" Then
            valor = valor + box_introducao.Text
        ElseIf operacao = "-" Then
            valor = valor - box_introducao.Text
        ElseIf operacao = "/" Then
            valor = valor / box_introducao.Text
        ElseIf operacao = "*" Then
            valor = valor * box_introducao.Text
        Else
            valor = box_introducao.Text
        End If
        operacao = novaoperacao
        If novaoperacao = "" Then
            lbl_anterior.Text += " " + box_introducao.Text
            box_introducao.Text = valor
            valor = 0
        Else
            lbl_anterior.Text = Str(valor) + novaoperacao
            box_introducao.Text = ""
        End If
        Return valor
    End Function

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        operacao = ""
        valor = 0
    End Sub
    Private Sub box_introducao_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles box_introducao.KeyPress

        '48 - 57  = Códigos ASCII para numeros

        If Asc(e.KeyChar) <> 8 Then 'Se o utilizador pressionar "+"
            If Asc(e.KeyChar) = 43 Then
                valor = fazerconta(valor, operacao, "+")
                operacao = "+"
                e.Handled = True
            ElseIf Asc(e.KeyChar) = 45 Then 'Se o utilizador pressionar "-"
                valor = fazerconta(valor, operacao, "-")
                operacao = "-"
                e.Handled = True
            ElseIf Asc(e.KeyChar) = 42 Then 'Se o utilizador pressionar "*"
                valor = fazerconta(valor, operacao, "*")
                operacao = "*"
                e.Handled = True
            ElseIf Asc(e.KeyChar) = 47 Then 'Se o utilizador pressionar "/"
                valor = fazerconta(valor, operacao, "/")
                operacao = "/"
                e.Handled = True
            ElseIf Asc(e.KeyChar) = 10 Then 'Se o utilizador pressionar enter
                fazerconta(valor, operacao, "")
                e.Handled = True
            ElseIf Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then 'Se o utilizador pressionar um numer
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub btn_0_Click(sender As System.Object, e As System.EventArgs) Handles btn_0.Click
        box_introducao.Text += "0"
    End Sub

    Private Sub btn_1_Click(sender As System.Object, e As System.EventArgs) Handles btn_1.Click
        box_introducao.Text += "1"
    End Sub

    Private Sub btn_2_Click(sender As System.Object, e As System.EventArgs) Handles btn_2.Click
        box_introducao.Text += "2"
    End Sub

    Private Sub btn_3_Click(sender As System.Object, e As System.EventArgs) Handles btn_3.Click
        box_introducao.Text += "3"
    End Sub

    Private Sub btn_4_Click(sender As System.Object, e As System.EventArgs) Handles btn_4.Click
        box_introducao.Text += "4"
    End Sub

    Private Sub btn_5_Click(sender As System.Object, e As System.EventArgs) Handles btn_5.Click
        box_introducao.Text += "5"
    End Sub

    Private Sub btn_6_Click(sender As System.Object, e As System.EventArgs) Handles btn_6.Click
        box_introducao.Text += "6"
    End Sub

    Private Sub btn_7_Click(sender As System.Object, e As System.EventArgs) Handles btn_7.Click
        box_introducao.Text += "7"
    End Sub

    Private Sub btn_8_Click(sender As System.Object, e As System.EventArgs) Handles btn_8.Click
        box_introducao.Text += "8"
    End Sub

    Private Sub btn_9_Click(sender As System.Object, e As System.EventArgs) Handles btn_9.Click
        box_introducao.Text += "9"
    End Sub

    Private Sub btn_virgula_Click(sender As System.Object, e As System.EventArgs) Handles btn_virgula.Click
        box_introducao.Text += "."
    End Sub


    Private Sub btn_somar_Click(sender As System.Object, e As System.EventArgs) Handles btn_somar.Click
        valor = fazerconta(valor, operacao, "+")
        operacao = "+"
    End Sub

    Private Sub btn_subtrair_Click(sender As System.Object, e As System.EventArgs) Handles btn_subtrair.Click
        valor = fazerconta(valor, operacao, "-")
        operacao = "-"
    End Sub

    Private Sub btn_multiplicar_Click(sender As System.Object, e As System.EventArgs) Handles btn_multiplicar.Click
        valor = fazerconta(valor, operacao, "*")
        operacao = "*"
    End Sub

    Private Sub btn_divisao_Click(sender As System.Object, e As System.EventArgs) Handles btn_divisao.Click
        valor = fazerconta(valor, operacao, "/")
        operacao = "/"
    End Sub

    Private Sub btn_igual_Click(sender As System.Object, e As System.EventArgs) Handles btn_igual.Click
        fazerconta(valor, operacao, "")
    End Sub

    Private Sub btn_cancelar_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelar.Click
        box_introducao.Text = ""
        lbl_anterior.Text = ""
        valor = 0
        operacao = ""
    End Sub
End Class
