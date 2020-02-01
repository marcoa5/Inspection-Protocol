<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Macchine = New System.Windows.Forms.ComboBox()
        Me.Tech = New System.Windows.Forms.ComboBox()
        Me.Interval = New System.Windows.Forms.ComboBox()
        Me.PN = New System.Windows.Forms.TextBox()
        Me.SN = New System.Windows.Forms.TextBox()
        Me.RIG = New System.Windows.Forms.TextBox()
        Me.CUSNR = New System.Windows.Forms.TextBox()
        Me.CUSNAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RigToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RigToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TechnicianToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FBD1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Macchine
        '
        Me.Macchine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Macchine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Macchine.FormattingEnabled = True
        Me.Macchine.Location = New System.Drawing.Point(118, 31)
        Me.Macchine.Name = "Macchine"
        Me.Macchine.Size = New System.Drawing.Size(527, 21)
        Me.Macchine.TabIndex = 0
        '
        'Tech
        '
        Me.Tech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Tech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Tech.FormattingEnabled = True
        Me.Tech.Location = New System.Drawing.Point(118, 114)
        Me.Tech.Name = "Tech"
        Me.Tech.Size = New System.Drawing.Size(209, 21)
        Me.Tech.TabIndex = 1
        '
        'Interval
        '
        Me.Interval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Interval.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Interval.FormattingEnabled = True
        Me.Interval.Location = New System.Drawing.Point(118, 141)
        Me.Interval.Name = "Interval"
        Me.Interval.Size = New System.Drawing.Size(209, 21)
        Me.Interval.TabIndex = 2
        '
        'PN
        '
        Me.PN.Enabled = False
        Me.PN.Location = New System.Drawing.Point(118, 58)
        Me.PN.Name = "PN"
        Me.PN.Size = New System.Drawing.Size(120, 20)
        Me.PN.TabIndex = 3
        '
        'SN
        '
        Me.SN.Enabled = False
        Me.SN.Location = New System.Drawing.Point(335, 58)
        Me.SN.Name = "SN"
        Me.SN.Size = New System.Drawing.Size(120, 20)
        Me.SN.TabIndex = 4
        '
        'RIG
        '
        Me.RIG.Enabled = False
        Me.RIG.Location = New System.Drawing.Point(526, 58)
        Me.RIG.Name = "RIG"
        Me.RIG.Size = New System.Drawing.Size(120, 20)
        Me.RIG.TabIndex = 5
        '
        'CUSNR
        '
        Me.CUSNR.Enabled = False
        Me.CUSNR.Location = New System.Drawing.Point(118, 88)
        Me.CUSNR.Name = "CUSNR"
        Me.CUSNR.Size = New System.Drawing.Size(120, 20)
        Me.CUSNR.TabIndex = 6
        '
        'CUSNAME
        '
        Me.CUSNAME.Enabled = False
        Me.CUSNAME.Location = New System.Drawing.Point(335, 85)
        Me.CUSNAME.Name = "CUSNAME"
        Me.CUSNAME.Size = New System.Drawing.Size(311, 20)
        Me.CUSNAME.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Selezione:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Part Nr:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(244, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Serial nr:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(494, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Rig:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Customer Nr:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(244, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Customer Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Technician:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Service Interval:"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(570, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(489, 162)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(658, 33)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RigToolStripMenuItem, Me.TechnicianToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'RigToolStripMenuItem
        '
        Me.RigToolStripMenuItem.Name = "RigToolStripMenuItem"
        Me.RigToolStripMenuItem.Size = New System.Drawing.Size(193, 34)
        Me.RigToolStripMenuItem.Text = "Rig"
        '
        'TechnicianToolStripMenuItem
        '
        Me.TechnicianToolStripMenuItem.Name = "TechnicianToolStripMenuItem"
        Me.TechnicianToolStripMenuItem.Size = New System.Drawing.Size(193, 34)
        Me.TechnicianToolStripMenuItem.Text = "Technician"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RigToolStripMenuItem1})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(164, 34)
        Me.ToolStripMenuItem2.Text = "Edit"
        '
        'RigToolStripMenuItem1
        '
        Me.RigToolStripMenuItem1.Name = "RigToolStripMenuItem1"
        Me.RigToolStripMenuItem1.Size = New System.Drawing.Size(140, 34)
        Me.RigToolStripMenuItem1.Text = "Rig"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RigToolStripMenuItem2, Me.TechnicianToolStripMenuItem2})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(164, 34)
        Me.ToolStripMenuItem3.Text = "Delete"
        '
        'RigToolStripMenuItem2
        '
        Me.RigToolStripMenuItem2.Name = "RigToolStripMenuItem2"
        Me.RigToolStripMenuItem2.Size = New System.Drawing.Size(193, 34)
        Me.RigToolStripMenuItem2.Text = "Rig"
        '
        'TechnicianToolStripMenuItem2
        '
        Me.TechnicianToolStripMenuItem2.Enabled = False
        Me.TechnicianToolStripMenuItem2.Name = "TechnicianToolStripMenuItem2"
        Me.TechnicianToolStripMenuItem2.Size = New System.Drawing.Size(193, 34)
        Me.TechnicianToolStripMenuItem2.Text = "Technician"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(161, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 194)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CUSNAME)
        Me.Controls.Add(Me.CUSNR)
        Me.Controls.Add(Me.RIG)
        Me.Controls.Add(Me.SN)
        Me.Controls.Add(Me.PN)
        Me.Controls.Add(Me.Interval)
        Me.Controls.Add(Me.Tech)
        Me.Controls.Add(Me.Macchine)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Macchine As ComboBox
    Friend WithEvents Tech As ComboBox
    Friend WithEvents Interval As ComboBox
    Friend WithEvents PN As TextBox
    Friend WithEvents SN As TextBox
    Friend WithEvents RIG As TextBox
    Friend WithEvents CUSNR As TextBox
    Friend WithEvents CUSNAME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TechnicianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RigToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents RigToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TechnicianToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FBD1 As FolderBrowserDialog
End Class
