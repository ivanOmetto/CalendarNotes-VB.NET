<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateNote
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.DtpDate = New System.Windows.Forms.DateTimePicker()
        Me.RtbDes = New System.Windows.Forms.RichTextBox()
        Me.BtnCor = New FontAwesome.Sharp.IconButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnExi = New FontAwesome.Sharp.IconButton()
        Me.BtnDel = New FontAwesome.Sharp.IconButton()
        Me.BtnSav = New FontAwesome.Sharp.IconButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title"
        '
        'TxtTitle
        '
        Me.TxtTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TxtTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtTitle.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.TxtTitle.Location = New System.Drawing.Point(12, 42)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(204, 33)
        Me.TxtTitle.TabIndex = 1
        '
        'DtpDate
        '
        Me.DtpDate.CalendarFont = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DtpDate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDate.Location = New System.Drawing.Point(12, 81)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(284, 27)
        Me.DtpDate.TabIndex = 2
        '
        'RtbDes
        '
        Me.RtbDes.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RtbDes.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RtbDes.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.RtbDes.Location = New System.Drawing.Point(12, 144)
        Me.RtbDes.Name = "RtbDes"
        Me.RtbDes.Size = New System.Drawing.Size(285, 158)
        Me.RtbDes.TabIndex = 3
        Me.RtbDes.Text = ""
        '
        'BtnCor
        '
        Me.BtnCor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCor.IconChar = FontAwesome.Sharp.IconChar.Tint
        Me.BtnCor.IconColor = System.Drawing.Color.Silver
        Me.BtnCor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCor.Location = New System.Drawing.Point(222, 9)
        Me.BtnCor.Name = "BtnCor"
        Me.BtnCor.Size = New System.Drawing.Size(75, 66)
        Me.BtnCor.TabIndex = 4
        Me.BtnCor.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(12, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Description"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnExi)
        Me.Panel1.Controls.Add(Me.BtnDel)
        Me.Panel1.Controls.Add(Me.BtnSav)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 49)
        Me.Panel1.TabIndex = 6
        '
        'BtnExi
        '
        Me.BtnExi.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnExi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnExi.IconChar = FontAwesome.Sharp.IconChar.Ban
        Me.BtnExi.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnExi.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnExi.Location = New System.Drawing.Point(83, 0)
        Me.BtnExi.Name = "BtnExi"
        Me.BtnExi.Size = New System.Drawing.Size(75, 49)
        Me.BtnExi.TabIndex = 7
        Me.BtnExi.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnDel.IconChar = FontAwesome.Sharp.IconChar.TrashAlt
        Me.BtnDel.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnDel.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnDel.Location = New System.Drawing.Point(158, 0)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 49)
        Me.BtnDel.TabIndex = 6
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnSav
        '
        Me.BtnSav.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnSav.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSav.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnSav.IconChar = FontAwesome.Sharp.IconChar.Save
        Me.BtnSav.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnSav.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnSav.Location = New System.Drawing.Point(233, 0)
        Me.BtnSav.Name = "BtnSav"
        Me.BtnSav.Size = New System.Drawing.Size(75, 49)
        Me.BtnSav.TabIndex = 5
        Me.BtnSav.UseVisualStyleBackColor = True
        '
        'CreateNote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(308, 360)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCor)
        Me.Controls.Add(Me.RtbDes)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateNote"
        Me.Text = "CreateNote"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents DtpDate As DateTimePicker
    Friend WithEvents RtbDes As RichTextBox
    Friend WithEvents BtnCor As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnExi As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnDel As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnSav As FontAwesome.Sharp.IconButton
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
