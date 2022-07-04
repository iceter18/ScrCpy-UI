<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scrcpy_Controls
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
        Me.title = New System.Windows.Forms.Label()
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.GunaGradient2Panel2 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.recent = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.home_button = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.menu_button = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.back_button = New Guna.UI.WinForms.GunaGradientTileButton()
        Me.GunaGradient2Panel1.SuspendLayout()
        Me.GunaGradient2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.ForeColor = System.Drawing.Color.White
        Me.title.Location = New System.Drawing.Point(6, -1)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(167, 25)
        Me.title.TabIndex = 0
        Me.title.Text = "title"
        Me.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.title)
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Black
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Gray
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(3, 2)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Radius = 8
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(156, 25)
        Me.GunaGradient2Panel1.TabIndex = 1
        '
        'GunaGradient2Panel2
        '
        Me.GunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel2.Controls.Add(Me.recent)
        Me.GunaGradient2Panel2.Controls.Add(Me.home_button)
        Me.GunaGradient2Panel2.Controls.Add(Me.menu_button)
        Me.GunaGradient2Panel2.Controls.Add(Me.back_button)
        Me.GunaGradient2Panel2.GradientColor1 = System.Drawing.Color.Black
        Me.GunaGradient2Panel2.GradientColor2 = System.Drawing.Color.Gray
        Me.GunaGradient2Panel2.Location = New System.Drawing.Point(3, 29)
        Me.GunaGradient2Panel2.Name = "GunaGradient2Panel2"
        Me.GunaGradient2Panel2.Radius = 8
        Me.GunaGradient2Panel2.Size = New System.Drawing.Size(214, 54)
        Me.GunaGradient2Panel2.TabIndex = 2
        '
        'recent
        '
        Me.recent.AnimationHoverSpeed = 0.07!
        Me.recent.AnimationSpeed = 0.03!
        Me.recent.BackColor = System.Drawing.Color.Transparent
        Me.recent.BaseColor1 = System.Drawing.Color.Black
        Me.recent.BaseColor2 = System.Drawing.Color.DarkOrchid
        Me.recent.BorderColor = System.Drawing.Color.Black
        Me.recent.DialogResult = System.Windows.Forms.DialogResult.None
        Me.recent.FocusedColor = System.Drawing.Color.Empty
        Me.recent.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.recent.ForeColor = System.Drawing.Color.White
        Me.recent.Image = Nothing
        Me.recent.ImageSize = New System.Drawing.Size(52, 52)
        Me.recent.Location = New System.Drawing.Point(111, 8)
        Me.recent.Name = "recent"
        Me.recent.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.recent.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.recent.OnHoverBorderColor = System.Drawing.Color.Black
        Me.recent.OnHoverForeColor = System.Drawing.Color.White
        Me.recent.OnHoverImage = Nothing
        Me.recent.OnPressedColor = System.Drawing.Color.Black
        Me.recent.Radius = 10
        Me.recent.Size = New System.Drawing.Size(45, 38)
        Me.recent.TabIndex = 3
        Me.recent.Text = "Recent"
        '
        'home_button
        '
        Me.home_button.AnimationHoverSpeed = 0.07!
        Me.home_button.AnimationSpeed = 0.03!
        Me.home_button.BackColor = System.Drawing.Color.Transparent
        Me.home_button.BaseColor1 = System.Drawing.Color.Black
        Me.home_button.BaseColor2 = System.Drawing.Color.DarkOrchid
        Me.home_button.BorderColor = System.Drawing.Color.Black
        Me.home_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.home_button.FocusedColor = System.Drawing.Color.Empty
        Me.home_button.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.home_button.ForeColor = System.Drawing.Color.White
        Me.home_button.Image = Nothing
        Me.home_button.ImageSize = New System.Drawing.Size(52, 52)
        Me.home_button.Location = New System.Drawing.Point(60, 8)
        Me.home_button.Name = "home_button"
        Me.home_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.home_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.home_button.OnHoverBorderColor = System.Drawing.Color.Black
        Me.home_button.OnHoverForeColor = System.Drawing.Color.White
        Me.home_button.OnHoverImage = Nothing
        Me.home_button.OnPressedColor = System.Drawing.Color.Black
        Me.home_button.Radius = 10
        Me.home_button.Size = New System.Drawing.Size(45, 38)
        Me.home_button.TabIndex = 2
        Me.home_button.Text = "Home"
        '
        'menu_button
        '
        Me.menu_button.AnimationHoverSpeed = 0.07!
        Me.menu_button.AnimationSpeed = 0.03!
        Me.menu_button.BackColor = System.Drawing.Color.Transparent
        Me.menu_button.BaseColor1 = System.Drawing.Color.Black
        Me.menu_button.BaseColor2 = System.Drawing.Color.DarkOrchid
        Me.menu_button.BorderColor = System.Drawing.Color.Black
        Me.menu_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.menu_button.FocusedColor = System.Drawing.Color.Empty
        Me.menu_button.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.menu_button.ForeColor = System.Drawing.Color.White
        Me.menu_button.Image = Nothing
        Me.menu_button.ImageSize = New System.Drawing.Size(52, 52)
        Me.menu_button.Location = New System.Drawing.Point(162, 8)
        Me.menu_button.Name = "menu_button"
        Me.menu_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.menu_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.menu_button.OnHoverBorderColor = System.Drawing.Color.Black
        Me.menu_button.OnHoverForeColor = System.Drawing.Color.White
        Me.menu_button.OnHoverImage = Nothing
        Me.menu_button.OnPressedColor = System.Drawing.Color.Black
        Me.menu_button.Radius = 10
        Me.menu_button.Size = New System.Drawing.Size(45, 38)
        Me.menu_button.TabIndex = 1
        Me.menu_button.Text = "Menu"
        '
        'back_button
        '
        Me.back_button.AnimationHoverSpeed = 0.07!
        Me.back_button.AnimationSpeed = 0.03!
        Me.back_button.BackColor = System.Drawing.Color.Transparent
        Me.back_button.BaseColor1 = System.Drawing.Color.Black
        Me.back_button.BaseColor2 = System.Drawing.Color.DarkOrchid
        Me.back_button.BorderColor = System.Drawing.Color.Black
        Me.back_button.DialogResult = System.Windows.Forms.DialogResult.None
        Me.back_button.FocusedColor = System.Drawing.Color.Empty
        Me.back_button.Font = New System.Drawing.Font("Segoe UI Light", 10.0!)
        Me.back_button.ForeColor = System.Drawing.Color.White
        Me.back_button.Image = Nothing
        Me.back_button.ImageSize = New System.Drawing.Size(52, 52)
        Me.back_button.Location = New System.Drawing.Point(9, 8)
        Me.back_button.Name = "back_button"
        Me.back_button.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.back_button.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.back_button.OnHoverBorderColor = System.Drawing.Color.Black
        Me.back_button.OnHoverForeColor = System.Drawing.Color.White
        Me.back_button.OnHoverImage = Nothing
        Me.back_button.OnPressedColor = System.Drawing.Color.Black
        Me.back_button.Radius = 10
        Me.back_button.Size = New System.Drawing.Size(45, 38)
        Me.back_button.TabIndex = 0
        Me.back_button.Text = "Back"
        '
        'Scrcpy_Controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(225, 87)
        Me.Controls.Add(Me.GunaGradient2Panel2)
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Scrcpy_Controls"
        Me.ShowInTaskbar = False
        Me.Text = "Scrcpy_Controls"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        Me.GunaGradient2Panel1.ResumeLayout(False)
        Me.GunaGradient2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents GunaGradient2Panel2 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents home_button As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents menu_button As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents back_button As Guna.UI.WinForms.GunaGradientTileButton
    Friend WithEvents recent As Guna.UI.WinForms.GunaGradientTileButton
End Class
