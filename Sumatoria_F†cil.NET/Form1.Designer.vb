<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Picture2 As System.Windows.Forms.PictureBox
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents imageS As System.Windows.Forms.ImageList
	Public WithEvents icons As System.Windows.Forms.ListView
	Public WithEvents cmdCalcular As System.Windows.Forms.Button
	Public WithEvents List As System.Windows.Forms.ListView
	Public WithEvents txtNum As System.Windows.Forms.TextBox
	Public WithEvents cmdAgregar As System.Windows.Forms.Button
	Public WithEvents txtTemp As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Picture2 = New System.Windows.Forms.PictureBox
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me.imageS = New System.Windows.Forms.ImageList(Me.components)
        Me.icons = New System.Windows.Forms.ListView
        Me.cmdCalcular = New System.Windows.Forms.Button
        Me.List = New System.Windows.Forms.ListView
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.cmdAgregar = New System.Windows.Forms.Button
        Me.txtTemp = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture2
        '
        Me.Picture2.BackColor = System.Drawing.SystemColors.Window
        Me.Picture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture2.Location = New System.Drawing.Point(72, 216)
        Me.Picture2.Name = "Picture2"
        Me.Picture2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture2.Size = New System.Drawing.Size(41, 17)
        Me.Picture2.TabIndex = 8
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Window
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Picture1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Picture1.Location = New System.Drawing.Point(88, 184)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(89, 1)
        Me.Picture1.TabIndex = 7
        '
        'imageS
        '
        Me.imageS.ImageStream = CType(resources.GetObject("imageS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imageS.TransparentColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.imageS.Images.SetKeyName(0, "")
        Me.imageS.Images.SetKeyName(1, "")
        Me.imageS.Images.SetKeyName(2, "")
        '
        'icons
        '
        Me.icons.BackColor = System.Drawing.SystemColors.Window
        Me.icons.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.icons.ForeColor = System.Drawing.SystemColors.WindowText
        Me.icons.Location = New System.Drawing.Point(8, 8)
        Me.icons.Name = "icons"
        Me.icons.Size = New System.Drawing.Size(345, 81)
        Me.icons.TabIndex = 5
        Me.icons.UseCompatibleStateImageBehavior = False
        '
        'cmdCalcular
        '
        Me.cmdCalcular.BackColor = System.Drawing.SystemColors.Control
        Me.cmdCalcular.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalcular.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdCalcular.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalcular.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalcular.Location = New System.Drawing.Point(280, 96)
        Me.cmdCalcular.Name = "cmdCalcular"
        Me.cmdCalcular.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalcular.Size = New System.Drawing.Size(73, 25)
        Me.cmdCalcular.TabIndex = 4
        Me.cmdCalcular.Text = "Calcular"
        Me.cmdCalcular.UseVisualStyleBackColor = False
        '
        'List
        '
        Me.List.BackColor = System.Drawing.SystemColors.Window
        Me.List.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List.FullRowSelect = True
        Me.List.Location = New System.Drawing.Point(8, 128)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(345, 353)
        Me.List.TabIndex = 3
        Me.List.UseCompatibleStateImageBehavior = False
        Me.List.View = System.Windows.Forms.View.Details
        '
        'txtNum
        '
        Me.txtNum.AcceptsReturn = True
        Me.txtNum.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum.Location = New System.Drawing.Point(72, 96)
        Me.txtNum.MaxLength = 10
        Me.txtNum.Name = "txtNum"
        Me.txtNum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum.Size = New System.Drawing.Size(121, 25)
        Me.txtNum.TabIndex = 0
        '
        'cmdAgregar
        '
        Me.cmdAgregar.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAgregar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAgregar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAgregar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAgregar.Location = New System.Drawing.Point(200, 96)
        Me.cmdAgregar.Name = "cmdAgregar"
        Me.cmdAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAgregar.Size = New System.Drawing.Size(73, 25)
        Me.cmdAgregar.TabIndex = 2
        Me.cmdAgregar.Text = "Agregar"
        Me.cmdAgregar.UseVisualStyleBackColor = False
        '
        'txtTemp
        '
        Me.txtTemp.AcceptsReturn = True
        Me.txtTemp.BackColor = System.Drawing.SystemColors.Window
        Me.txtTemp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTemp.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTemp.Location = New System.Drawing.Point(0, 0)
        Me.txtTemp.MaxLength = 0
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTemp.Size = New System.Drawing.Size(81, 21)
        Me.txtTemp.TabIndex = 6
        Me.txtTemp.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(8, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(361, 490)
        Me.Controls.Add(Me.Picture2)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me.icons)
        Me.Controls.Add(Me.cmdCalcular)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.cmdAgregar)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 30)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sumatoria Fácil"
        CType(Me.Picture2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class