Public Class frmSenhas

    Dim senha As Single
    Dim senhaHackeada As Single

    Private Sub frmSenhas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        senha = 123456
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Primeiro você cria uma nova instância da classe
        Dim cronometro As New Stopwatch
        'Em seguida você inicia a contagem do tempo
        cronometro.Start()
        senhaHackeada = Int(Rnd() * 100000) + 100000
        If senhaHackeada = senha Then
            Timer1.Enabled = False
            'Após o encerramento da tarefa você para a contagem do tempo
            cronometro.Stop()
            txtSenhaHackeada.Text = senhaHackeada
            lblMsg.Visible = True
            lblMsg.Text = "A senha foi craqueada com sucesso em ..." + cronometro.Elapsed.ToString() + " milisegundos"
        Else
            txtSenhaHackeada.Text = senhaHackeada
            lblMsg.Visible = True
            lblMsg.Text = "Aguarde......"
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        senha = txtSenha.Text
        Timer1.Enabled = True
        lblMsg.Visible = True
        txtSenhaHackeada.Visible = True
    End Sub
End Class
