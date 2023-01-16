<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class terceiroFormulario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn4.Location = New System.Drawing.Point(246, 291)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(148, 23)
        Me.btn4.TabIndex = 0
        Me.btn4.Text = "Adicionar a Lista"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(166, 38)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(481, 225)
        Me.ListBox1.TabIndex = 1
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn5.Location = New System.Drawing.Point(412, 291)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(146, 23)
        Me.btn5.TabIndex = 2
        Me.btn5.Text = "Remover da lista"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'terceiroFormulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn4)
        Me.Name = "terceiroFormulario"
        Me.Text = "terceiroFormulario"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn5 As Button
End Class
