﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrar_sedes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvsedes = New System.Windows.Forms.DataGridView()
        Me.btn_eliminar = New FontAwesome.Sharp.IconButton()
        Me.btn_crear = New FontAwesome.Sharp.IconButton()
        CType(Me.dgvsedes, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 37)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Administrar sedes"
        '
        'dgvsedes
        '
        Me.dgvsedes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvsedes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvsedes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvsedes.BackgroundColor = System.Drawing.Color.White
        Me.dgvsedes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvsedes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowFrame
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvsedes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvsedes.ColumnHeadersHeight = 33
        Me.dgvsedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvsedes.EnableHeadersVisualStyles = False
        Me.dgvsedes.GridColor = System.Drawing.Color.White
        Me.dgvsedes.Location = New System.Drawing.Point(34, 84)
        Me.dgvsedes.Name = "dgvsedes"
        Me.dgvsedes.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SaddleBrown
        Me.dgvsedes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvsedes.RowTemplate.Height = 24
        Me.dgvsedes.Size = New System.Drawing.Size(1014, 628)
        Me.dgvsedes.TabIndex = 28
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_eliminar.IconColor = System.Drawing.Color.Black
        Me.btn_eliminar.IconSize = 16
        Me.btn_eliminar.Location = New System.Drawing.Point(795, 753)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Rotation = 0R
        Me.btn_eliminar.Size = New System.Drawing.Size(253, 50)
        Me.btn_eliminar.TabIndex = 29
        Me.btn_eliminar.Text = "Eliminar producto"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_crear
        '
        Me.btn_crear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_crear.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btn_crear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_crear.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_crear.IconColor = System.Drawing.Color.Black
        Me.btn_crear.IconSize = 16
        Me.btn_crear.Location = New System.Drawing.Point(34, 753)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Rotation = 0R
        Me.btn_crear.Size = New System.Drawing.Size(253, 50)
        Me.btn_crear.TabIndex = 27
        Me.btn_crear.Text = "Crear producto"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'Administrar_sedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1485, 840)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.dgvsedes)
        Me.Controls.Add(Me.btn_crear)
        Me.Name = "Administrar_sedes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrar_sedes"
        CType(Me.dgvsedes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_eliminar As FontAwesome.Sharp.IconButton
    Friend WithEvents dgvsedes As DataGridView
    Friend WithEvents btn_crear As FontAwesome.Sharp.IconButton
End Class
