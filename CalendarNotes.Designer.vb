<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalendarNotes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblMonthAndYear = New System.Windows.Forms.Label()
        Me.btnNextMonth = New FontAwesome.Sharp.IconButton()
        Me.btnPrevMonth = New FontAwesome.Sharp.IconButton()
        Me.BtnToday = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flDays = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblMonthAndYear)
        Me.Panel1.Controls.Add(Me.btnNextMonth)
        Me.Panel1.Controls.Add(Me.btnPrevMonth)
        Me.Panel1.Controls.Add(Me.BtnToday)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(6)
        Me.Panel1.Size = New System.Drawing.Size(943, 50)
        Me.Panel1.TabIndex = 0
        '
        'lblMonthAndYear
        '
        Me.lblMonthAndYear.AutoSize = True
        Me.lblMonthAndYear.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblMonthAndYear.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMonthAndYear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblMonthAndYear.Location = New System.Drawing.Point(231, 6)
        Me.lblMonthAndYear.Name = "lblMonthAndYear"
        Me.lblMonthAndYear.Size = New System.Drawing.Size(83, 40)
        Me.lblMonthAndYear.TabIndex = 3
        Me.lblMonthAndYear.Text = "TEXT"
        '
        'btnNextMonth
        '
        Me.btnNextMonth.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnNextMonth.IconChar = FontAwesome.Sharp.IconChar.ChevronRight
        Me.btnNextMonth.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnNextMonth.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnNextMonth.IconSize = 34
        Me.btnNextMonth.Location = New System.Drawing.Point(156, 6)
        Me.btnNextMonth.Name = "btnNextMonth"
        Me.btnNextMonth.Size = New System.Drawing.Size(75, 38)
        Me.btnNextMonth.TabIndex = 2
        Me.btnNextMonth.UseVisualStyleBackColor = True
        '
        'btnPrevMonth
        '
        Me.btnPrevMonth.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnPrevMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnPrevMonth.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft
        Me.btnPrevMonth.IconColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrevMonth.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPrevMonth.IconSize = 34
        Me.btnPrevMonth.Location = New System.Drawing.Point(81, 6)
        Me.btnPrevMonth.Name = "btnPrevMonth"
        Me.btnPrevMonth.Size = New System.Drawing.Size(75, 38)
        Me.btnPrevMonth.TabIndex = 1
        Me.btnPrevMonth.UseVisualStyleBackColor = True
        '
        'BtnToday
        '
        Me.BtnToday.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnToday.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnToday.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnToday.Location = New System.Drawing.Point(6, 6)
        Me.BtnToday.Name = "BtnToday"
        Me.BtnToday.Size = New System.Drawing.Size(75, 38)
        Me.BtnToday.TabIndex = 0
        Me.BtnToday.Text = "Today"
        Me.BtnToday.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel9)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(943, 33)
        Me.Panel2.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label7)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(803, 5)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(133, 23)
        Me.Panel9.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "SAT"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(670, 5)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(133, 23)
        Me.Panel8.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "FRI"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(537, 5)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(133, 23)
        Me.Panel7.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "THU"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(404, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(133, 23)
        Me.Panel6.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "WED"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(271, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(133, 23)
        Me.Panel5.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "TUE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(138, 5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(133, 23)
        Me.Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MON"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(5, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(133, 23)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SUN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'flDays
        '
        Me.flDays.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.flDays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flDays.Location = New System.Drawing.Point(0, 83)
        Me.flDays.Name = "flDays"
        Me.flDays.Size = New System.Drawing.Size(943, 638)
        Me.flDays.TabIndex = 2
        '
        'CalendarNotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 721)
        Me.Controls.Add(Me.flDays)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CalendarNotes"
        Me.Text = "CalendarNotes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblMonthAndYear As Label
    Friend WithEvents btnNextMonth As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPrevMonth As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnToday As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents flDays As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
