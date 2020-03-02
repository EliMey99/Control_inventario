<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_user
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbox_tipos = New System.Windows.Forms.ComboBox()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.password2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.valida = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(91, 92)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(222, 25)
        Me.txtnombre.TabIndex = 13
        Me.txtnombre.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(109, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 28)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Añadir usuario"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(110, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre de usuario"
        Me.Label2.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(135, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Contraseña"
        Me.Label3.UseWaitCursor = True
        '
        'passwordtxt
        '
        Me.passwordtxt.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.Location = New System.Drawing.Point(91, 174)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(222, 25)
        Me.passwordtxt.TabIndex = 16
        Me.passwordtxt.UseSystemPasswordChar = True
        Me.passwordtxt.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(126, 317)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Tipo de usuario"
        Me.Label4.UseWaitCursor = True
        '
        'cmbox_tipos
        '
        Me.cmbox_tipos.FormattingEnabled = True
        Me.cmbox_tipos.Location = New System.Drawing.Point(114, 342)
        Me.cmbox_tipos.Name = "cmbox_tipos"
        Me.cmbox_tipos.Size = New System.Drawing.Size(158, 21)
        Me.cmbox_tipos.TabIndex = 18
        Me.cmbox_tipos.UseWaitCursor = True
        '
        'IconButton1
        '
        Me.IconButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.IconButton1.BackColor = System.Drawing.Color.SteelBlue
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(84, 414)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0R
        Me.IconButton1.Size = New System.Drawing.Size(222, 37)
        Me.IconButton1.TabIndex = 14
        Me.IconButton1.Text = "Añadir"
        Me.IconButton1.UseVisualStyleBackColor = False
        Me.IconButton1.UseWaitCursor = True
        '
        'password2
        '
        Me.password2.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password2.Location = New System.Drawing.Point(91, 255)
        Me.password2.Margin = New System.Windows.Forms.Padding(2)
        Me.password2.Name = "password2"
        Me.password2.Size = New System.Drawing.Size(222, 25)
        Me.password2.TabIndex = 20
        Me.password2.UseSystemPasswordChar = True
        Me.password2.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(95, 220)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(211, 22)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Confirmar contraseña"
        Me.Label5.UseWaitCursor = True
        '
        'valida
        '
        Me.valida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valida.AutoSize = True
        Me.valida.BackColor = System.Drawing.Color.Transparent
        Me.valida.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.valida.Location = New System.Drawing.Point(103, 284)
        Me.valida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.valida.Name = "valida"
        Me.valida.Size = New System.Drawing.Size(201, 16)
        Me.valida.TabIndex = 21
        Me.valida.Text = "Las contraseñas no coinciden"
        Me.valida.UseWaitCursor = True
        Me.valida.Visible = False
        '
        'Add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 500)
        Me.Controls.Add(Me.valida)
        Me.Controls.Add(Me.password2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbox_tipos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passwordtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IconButton1)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(500, 1000)
        Me.Name = "Add_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_user"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbox_tipos As ComboBox
    Friend WithEvents password2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents valida As Label
End Class
