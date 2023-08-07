<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSenhas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSenhas))
        Me.lblText = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtSenhaHackeada = New System.Windows.Forms.TextBox()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.Location = New System.Drawing.Point(125, 157)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(145, 24)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Informe a senha"
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(90, 184)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(203, 29)
        Me.txtSenha.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(148, 219)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(92, 37)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtSenhaHackeada
        '
        Me.txtSenhaHackeada.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenhaHackeada.Location = New System.Drawing.Point(90, 261)
        Me.txtSenhaHackeada.Name = "txtSenhaHackeada"
        Me.txtSenhaHackeada.Size = New System.Drawing.Size(203, 29)
        Me.txtSenhaHackeada.TabIndex = 3
        '
        'lblMsg
        '
        Me.lblMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.Location = New System.Drawing.Point(54, 13)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(281, 79)
        Me.lblMsg.TabIndex = 4
        '
        'Timer1
        '
        '
        'frmSenhas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(385, 328)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.txtSenhaHackeada)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.lblText)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSenhas"
        Me.Text = "Quebrando Senhas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtSenhaHackeada As System.Windows.Forms.TextBox
    Friend WithEvents lblMsg As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
