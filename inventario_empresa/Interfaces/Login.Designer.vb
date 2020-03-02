<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.valida = New System.Windows.Forms.Label()
        Me.passwordtxt = New System.Windows.Forms.TextBox()
        Me.name_usertxt = New System.Windows.Forms.TextBox()
        Me.ingreso_btn = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Label1.Location = New System.Drawing.Point(21, 268)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Iniciar sesión"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.valida)
        Me.Panel2.Controls.Add(Me.passwordtxt)
        Me.Panel2.Controls.Add(Me.name_usertxt)
        Me.Panel2.Controls.Add(Me.ingreso_btn)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(650, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 566)
        Me.Panel2.TabIndex = 2
        '
        'valida
        '
        Me.valida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valida.AutoSize = True
        Me.valida.BackColor = System.Drawing.Color.Transparent
        Me.valida.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.valida.Location = New System.Drawing.Point(33, 479)
        Me.valida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.valida.Name = "valida"
        Me.valida.Size = New System.Drawing.Size(188, 15)
        Me.valida.TabIndex = 22
        Me.valida.Text = "Nombre o contraseña incorrectos"
        Me.valida.UseWaitCursor = True
        Me.valida.Visible = False
        '
        'passwordtxt
        '
        Me.passwordtxt.BackColor = System.Drawing.Color.White
        Me.passwordtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passwordtxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passwordtxt.ForeColor = System.Drawing.Color.SteelBlue
        Me.passwordtxt.Location = New System.Drawing.Point(27, 448)
        Me.passwordtxt.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordtxt.Name = "passwordtxt"
        Me.passwordtxt.Size = New System.Drawing.Size(199, 20)
        Me.passwordtxt.TabIndex = 7
        Me.passwordtxt.UseSystemPasswordChar = True
        '
        'name_usertxt
        '
        Me.name_usertxt.BackColor = System.Drawing.Color.White
        Me.name_usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.name_usertxt.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.name_usertxt.ForeColor = System.Drawing.Color.SteelBlue
        Me.name_usertxt.Location = New System.Drawing.Point(27, 364)
        Me.name_usertxt.Margin = New System.Windows.Forms.Padding(2)
        Me.name_usertxt.Name = "name_usertxt"
        Me.name_usertxt.Size = New System.Drawing.Size(199, 20)
        Me.name_usertxt.TabIndex = 6
        '
        'ingreso_btn
        '
        Me.ingreso_btn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ingreso_btn.BackColor = System.Drawing.Color.SteelBlue
        Me.ingreso_btn.FlatAppearance.BorderSize = 0
        Me.ingreso_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ingreso_btn.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.ingreso_btn.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ingreso_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ingreso_btn.IconChar = FontAwesome.Sharp.IconChar.None
        Me.ingreso_btn.IconColor = System.Drawing.Color.Black
        Me.ingreso_btn.IconSize = 16
        Me.ingreso_btn.Location = New System.Drawing.Point(26, 513)
        Me.ingreso_btn.Margin = New System.Windows.Forms.Padding(2)
        Me.ingreso_btn.Name = "ingreso_btn"
        Me.ingreso_btn.Rotation = 0R
        Me.ingreso_btn.Size = New System.Drawing.Size(199, 27)
        Me.ingreso_btn.TabIndex = 5
        Me.ingreso_btn.Text = "Ingresar"
        Me.ingreso_btn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Location = New System.Drawing.Point(27, 470)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(199, 1)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.DimGray
        Me.Panel3.Location = New System.Drawing.Point(27, 386)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(199, 1)
        Me.Panel3.TabIndex = 3
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
        Me.Label3.Location = New System.Drawing.Point(23, 409)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
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
        Me.Label2.Location = New System.Drawing.Point(23, 325)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.BackgroundImage = Global.inventario_empresa.My.Resources.Resources.Logo_ceant_2
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(650, 566)
        Me.Panel1.TabIndex = 1
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(897, 573)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Brown
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(913, 612)
        Me.MinimumSize = New System.Drawing.Size(913, 612)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ingreso_btn As FontAwesome.Sharp.IconButton
    Friend WithEvents passwordtxt As TextBox
    Friend WithEvents name_usertxt As TextBox
    Friend WithEvents valida As Label
End Class
