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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.max_frame = New System.Windows.Forms.TextBox()
        Me.bit_rate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.max_size = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.connect = New System.Windows.Forms.Button()
        Me.view_records = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.add_multi_serial = New System.Windows.Forms.Button()
        Me.add_multi_IP = New System.Windows.Forms.Button()
        Me.multi_serial = New System.Windows.Forms.TextBox()
        Me.multi_IP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.single_IP = New System.Windows.Forms.TextBox()
        Me.record_screen = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.nav_box = New System.Windows.Forms.TextBox()
        Me.navibar = New System.Windows.Forms.CheckBox()
        Me.show_touches = New System.Windows.Forms.CheckBox()
        Me.render_expired_frames = New System.Windows.Forms.CheckBox()
        Me.screen_off = New System.Windows.Forms.CheckBox()
        Me.read_only = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.keep_awake = New System.Windows.Forms.CheckBox()
        Me.SoftKboard = New System.Windows.Forms.CheckBox()
        Me.fullscreen = New System.Windows.Forms.CheckBox()
        Me.always_top = New System.Windows.Forms.CheckBox()
        Me.borderless = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.offsetWidth = New System.Windows.Forms.TextBox()
        Me.offsetLength = New System.Windows.Forms.TextBox()
        Me.crop_box = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.crop_width = New System.Windows.Forms.TextBox()
        Me.crop_length = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lock_orientation = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.02262!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.97738!))
        Me.TableLayoutPanel1.Controls.Add(Me.max_frame, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.bit_rate, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.max_size, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 23)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(293, 82)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'max_frame
        '
        Me.max_frame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.max_frame.Location = New System.Drawing.Point(102, 57)
        Me.max_frame.Name = "max_frame"
        Me.max_frame.Size = New System.Drawing.Size(188, 20)
        Me.max_frame.TabIndex = 9
        '
        'bit_rate
        '
        Me.bit_rate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bit_rate.Location = New System.Drawing.Point(102, 30)
        Me.bit_rate.Name = "bit_rate"
        Me.bit_rate.Size = New System.Drawing.Size(188, 20)
        Me.bit_rate.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Max Frame Rate:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bit-Rate (Mbps):"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Max Size:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'max_size
        '
        Me.max_size.Dock = System.Windows.Forms.DockStyle.Fill
        Me.max_size.Location = New System.Drawing.Point(102, 3)
        Me.max_size.Name = "max_size"
        Me.max_size.Size = New System.Drawing.Size(188, 20)
        Me.max_size.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.connect)
        Me.Panel1.Controls.Add(Me.view_records)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.record_screen)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.MaximumSize = New System.Drawing.Size(334, 600)
        Me.Panel1.MinimumSize = New System.Drawing.Size(334, 538)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 562)
        Me.Panel1.TabIndex = 1
        '
        'connect
        '
        Me.connect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect.Location = New System.Drawing.Point(73, 513)
        Me.connect.Name = "connect"
        Me.connect.Size = New System.Drawing.Size(188, 30)
        Me.connect.TabIndex = 11
        Me.connect.Text = "CONNECT"
        Me.connect.UseVisualStyleBackColor = True
        '
        'view_records
        '
        Me.view_records.Location = New System.Drawing.Point(172, 483)
        Me.view_records.Name = "view_records"
        Me.view_records.Size = New System.Drawing.Size(149, 23)
        Me.view_records.TabIndex = 10
        Me.view_records.Text = "View Records"
        Me.view_records.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.add_multi_serial)
        Me.GroupBox4.Controls.Add(Me.add_multi_IP)
        Me.GroupBox4.Controls.Add(Me.multi_serial)
        Me.GroupBox4.Controls.Add(Me.multi_IP)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.single_IP)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 373)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(310, 104)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Connection"
        '
        'add_multi_serial
        '
        Me.add_multi_serial.Location = New System.Drawing.Point(252, 69)
        Me.add_multi_serial.Name = "add_multi_serial"
        Me.add_multi_serial.Size = New System.Drawing.Size(47, 23)
        Me.add_multi_serial.TabIndex = 7
        Me.add_multi_serial.Text = "Add"
        Me.add_multi_serial.UseVisualStyleBackColor = True
        '
        'add_multi_IP
        '
        Me.add_multi_IP.Location = New System.Drawing.Point(252, 43)
        Me.add_multi_IP.Name = "add_multi_IP"
        Me.add_multi_IP.Size = New System.Drawing.Size(47, 23)
        Me.add_multi_IP.TabIndex = 6
        Me.add_multi_IP.Text = "Add"
        Me.add_multi_IP.UseVisualStyleBackColor = True
        '
        'multi_serial
        '
        Me.multi_serial.Location = New System.Drawing.Point(110, 71)
        Me.multi_serial.Name = "multi_serial"
        Me.multi_serial.Size = New System.Drawing.Size(136, 20)
        Me.multi_serial.TabIndex = 5
        '
        'multi_IP
        '
        Me.multi_IP.Location = New System.Drawing.Point(110, 45)
        Me.multi_IP.Name = "multi_IP"
        Me.multi_IP.Size = New System.Drawing.Size(136, 20)
        Me.multi_IP.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Serial:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Device IP adress:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Device IP adress:"
        '
        'single_IP
        '
        Me.single_IP.Location = New System.Drawing.Point(110, 19)
        Me.single_IP.Name = "single_IP"
        Me.single_IP.Size = New System.Drawing.Size(189, 20)
        Me.single_IP.TabIndex = 0
        '
        'record_screen
        '
        Me.record_screen.Location = New System.Drawing.Point(12, 483)
        Me.record_screen.Name = "record_screen"
        Me.record_screen.Size = New System.Drawing.Size(154, 23)
        Me.record_screen.TabIndex = 8
        Me.record_screen.Text = "Record Screen"
        Me.record_screen.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.nav_box)
        Me.GroupBox3.Controls.Add(Me.navibar)
        Me.GroupBox3.Controls.Add(Me.show_touches)
        Me.GroupBox3.Controls.Add(Me.render_expired_frames)
        Me.GroupBox3.Controls.Add(Me.screen_off)
        Me.GroupBox3.Controls.Add(Me.read_only)
        Me.GroupBox3.Location = New System.Drawing.Point(171, 218)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 149)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Other Configuration"
        '
        'nav_box
        '
        Me.nav_box.Location = New System.Drawing.Point(108, 118)
        Me.nav_box.Name = "nav_box"
        Me.nav_box.Size = New System.Drawing.Size(36, 20)
        Me.nav_box.TabIndex = 9
        '
        'navibar
        '
        Me.navibar.AutoSize = True
        Me.navibar.Location = New System.Drawing.Point(12, 120)
        Me.navibar.Name = "navibar"
        Me.navibar.Size = New System.Drawing.Size(90, 17)
        Me.navibar.TabIndex = 7
        Me.navibar.Text = "Hide Nav Bar"
        Me.navibar.UseVisualStyleBackColor = True
        '
        'show_touches
        '
        Me.show_touches.AutoSize = True
        Me.show_touches.Location = New System.Drawing.Point(12, 97)
        Me.show_touches.Name = "show_touches"
        Me.show_touches.Size = New System.Drawing.Size(94, 17)
        Me.show_touches.TabIndex = 6
        Me.show_touches.Text = "Show touches"
        Me.show_touches.UseVisualStyleBackColor = True
        '
        'render_expired_frames
        '
        Me.render_expired_frames.AutoSize = True
        Me.render_expired_frames.Location = New System.Drawing.Point(12, 74)
        Me.render_expired_frames.Name = "render_expired_frames"
        Me.render_expired_frames.Size = New System.Drawing.Size(132, 17)
        Me.render_expired_frames.TabIndex = 5
        Me.render_expired_frames.Text = "Render expired frames"
        Me.render_expired_frames.UseVisualStyleBackColor = True
        '
        'screen_off
        '
        Me.screen_off.AutoSize = True
        Me.screen_off.Location = New System.Drawing.Point(12, 51)
        Me.screen_off.Name = "screen_off"
        Me.screen_off.Size = New System.Drawing.Size(98, 17)
        Me.screen_off.TabIndex = 4
        Me.screen_off.Text = "Turn screen off"
        Me.screen_off.UseVisualStyleBackColor = True
        '
        'read_only
        '
        Me.read_only.AutoSize = True
        Me.read_only.Location = New System.Drawing.Point(12, 28)
        Me.read_only.Name = "read_only"
        Me.read_only.Size = New System.Drawing.Size(74, 17)
        Me.read_only.TabIndex = 3
        Me.read_only.Text = "Read only"
        Me.read_only.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.keep_awake)
        Me.GroupBox2.Controls.Add(Me.SoftKboard)
        Me.GroupBox2.Controls.Add(Me.fullscreen)
        Me.GroupBox2.Controls.Add(Me.always_top)
        Me.GroupBox2.Controls.Add(Me.borderless)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(154, 149)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Window Configuration"
        '
        'keep_awake
        '
        Me.keep_awake.AutoSize = True
        Me.keep_awake.Location = New System.Drawing.Point(12, 120)
        Me.keep_awake.Name = "keep_awake"
        Me.keep_awake.Size = New System.Drawing.Size(87, 17)
        Me.keep_awake.TabIndex = 7
        Me.keep_awake.Text = "Keep Awake"
        Me.keep_awake.UseVisualStyleBackColor = True
        '
        'SoftKboard
        '
        Me.SoftKboard.AutoSize = True
        Me.SoftKboard.Location = New System.Drawing.Point(12, 97)
        Me.SoftKboard.Name = "SoftKboard"
        Me.SoftKboard.Size = New System.Drawing.Size(131, 17)
        Me.SoftKboard.TabIndex = 6
        Me.SoftKboard.Text = "Disable Soft Keyboard"
        Me.SoftKboard.UseVisualStyleBackColor = True
        '
        'fullscreen
        '
        Me.fullscreen.AutoSize = True
        Me.fullscreen.Location = New System.Drawing.Point(12, 74)
        Me.fullscreen.Name = "fullscreen"
        Me.fullscreen.Size = New System.Drawing.Size(74, 17)
        Me.fullscreen.TabIndex = 5
        Me.fullscreen.Text = "Fullscreen"
        Me.fullscreen.UseVisualStyleBackColor = True
        '
        'always_top
        '
        Me.always_top.AutoSize = True
        Me.always_top.Location = New System.Drawing.Point(12, 51)
        Me.always_top.Name = "always_top"
        Me.always_top.Size = New System.Drawing.Size(92, 17)
        Me.always_top.TabIndex = 4
        Me.always_top.Text = "Always on top"
        Me.always_top.UseVisualStyleBackColor = True
        '
        'borderless
        '
        Me.borderless.AutoSize = True
        Me.borderless.Location = New System.Drawing.Point(12, 28)
        Me.borderless.Name = "borderless"
        Me.borderless.Size = New System.Drawing.Size(75, 17)
        Me.borderless.TabIndex = 3
        Me.borderless.Text = "Borderless"
        Me.borderless.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.offsetWidth)
        Me.GroupBox1.Controls.Add(Me.offsetLength)
        Me.GroupBox1.Controls.Add(Me.crop_box)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.crop_width)
        Me.GroupBox1.Controls.Add(Me.crop_length)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lock_orientation)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 200)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Capture Configuration"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(209, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "X"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(9, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Offset:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'offsetWidth
        '
        Me.offsetWidth.Location = New System.Drawing.Point(229, 131)
        Me.offsetWidth.Name = "offsetWidth"
        Me.offsetWidth.Size = New System.Drawing.Size(67, 20)
        Me.offsetWidth.TabIndex = 13
        '
        'offsetLength
        '
        Me.offsetLength.Location = New System.Drawing.Point(135, 131)
        Me.offsetLength.Name = "offsetLength"
        Me.offsetLength.Size = New System.Drawing.Size(67, 20)
        Me.offsetLength.TabIndex = 12
        '
        'crop_box
        '
        Me.crop_box.AutoSize = True
        Me.crop_box.Location = New System.Drawing.Point(114, 111)
        Me.crop_box.Name = "crop_box"
        Me.crop_box.Size = New System.Drawing.Size(15, 14)
        Me.crop_box.TabIndex = 11
        Me.crop_box.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(209, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "X"
        '
        'crop_width
        '
        Me.crop_width.Location = New System.Drawing.Point(229, 105)
        Me.crop_width.Name = "crop_width"
        Me.crop_width.Size = New System.Drawing.Size(67, 20)
        Me.crop_width.TabIndex = 9
        '
        'crop_length
        '
        Me.crop_length.Location = New System.Drawing.Point(135, 105)
        Me.crop_length.Name = "crop_length"
        Me.crop_length.Size = New System.Drawing.Size(67, 20)
        Me.crop_length.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(9, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Crop:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Lock Video Orientation (degree):"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lock_orientation
        '
        Me.lock_orientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lock_orientation.FormattingEnabled = True
        Me.lock_orientation.Items.AddRange(New Object() {"natural", "90 counterclockwise", "180", "90 clockwise"})
        Me.lock_orientation.Location = New System.Drawing.Point(175, 161)
        Me.lock_orientation.Name = "lock_orientation"
        Me.lock_orientation.Size = New System.Drawing.Size(124, 21)
        Me.lock_orientation.TabIndex = 2
        '
        'Form1
        '
        Me.AcceptButton = Me.connect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 562)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(350, 600)
        Me.MinimumSize = New System.Drawing.Size(350, 576)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScrCpy UI by ICETER"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents max_size As TextBox
    Friend WithEvents max_frame As TextBox
    Friend WithEvents bit_rate As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents fullscreen As CheckBox
    Friend WithEvents always_top As CheckBox
    Friend WithEvents borderless As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lock_orientation As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents show_touches As CheckBox
    Friend WithEvents render_expired_frames As CheckBox
    Friend WithEvents screen_off As CheckBox
    Friend WithEvents read_only As CheckBox
    Friend WithEvents record_screen As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents multi_serial As TextBox
    Friend WithEvents multi_IP As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents single_IP As TextBox
    Friend WithEvents add_multi_serial As Button
    Friend WithEvents add_multi_IP As Button
    Friend WithEvents connect As Button
    Friend WithEvents view_records As Button
    Friend WithEvents SoftKboard As CheckBox
    Friend WithEvents keep_awake As CheckBox
    Friend WithEvents navibar As CheckBox
    Friend WithEvents crop_width As TextBox
    Friend WithEvents crop_length As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents nav_box As TextBox
    Friend WithEvents crop_box As CheckBox
    Friend WithEvents offsetWidth As TextBox
    Friend WithEvents offsetLength As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
End Class
