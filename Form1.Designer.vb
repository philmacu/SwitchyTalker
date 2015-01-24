<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class radioControlForm
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
        Me.components = New System.ComponentModel.Container()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.radioPort = New System.IO.Ports.SerialPort(Me.components)
        Me.portSelector = New System.Windows.Forms.ComboBox()
        Me.radioModeRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.modeSelect0 = New System.Windows.Forms.Button()
        Me.modeSelect1 = New System.Windows.Forms.Button()
        Me.openPort = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.modeSelect2 = New System.Windows.Forms.Button()
        Me.modeSelect3 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'portSelector
        '
        Me.portSelector.FormattingEnabled = True
        Me.portSelector.Location = New System.Drawing.Point(273, 15)
        Me.portSelector.Name = "portSelector"
        Me.portSelector.Size = New System.Drawing.Size(125, 21)
        Me.portSelector.TabIndex = 0
        Me.portSelector.Text = "Select Port"
        '
        'radioModeRichTextBox
        '
        Me.radioModeRichTextBox.Location = New System.Drawing.Point(44, 15)
        Me.radioModeRichTextBox.Name = "radioModeRichTextBox"
        Me.radioModeRichTextBox.Size = New System.Drawing.Size(192, 59)
        Me.radioModeRichTextBox.TabIndex = 3
        Me.radioModeRichTextBox.Text = ""
        '
        'modeSelect0
        '
        Me.modeSelect0.Location = New System.Drawing.Point(44, 80)
        Me.modeSelect0.Name = "modeSelect0"
        Me.modeSelect0.Size = New System.Drawing.Size(93, 54)
        Me.modeSelect0.TabIndex = 2
        Me.modeSelect0.Text = "Sunair -> Harris" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sailor -> N/C"
        Me.modeSelect0.UseVisualStyleBackColor = True
        Me.modeSelect0.Visible = False
        '
        'modeSelect1
        '
        Me.modeSelect1.Location = New System.Drawing.Point(143, 80)
        Me.modeSelect1.Name = "modeSelect1"
        Me.modeSelect1.Size = New System.Drawing.Size(93, 54)
        Me.modeSelect1.TabIndex = 4
        Me.modeSelect1.Text = "Sunair -> Crypto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sailor -> Harris"
        Me.modeSelect1.UseVisualStyleBackColor = True
        Me.modeSelect1.Visible = False
        '
        'openPort
        '
        Me.openPort.Location = New System.Drawing.Point(401, 15)
        Me.openPort.Name = "openPort"
        Me.openPort.Size = New System.Drawing.Size(74, 20)
        Me.openPort.TabIndex = 5
        Me.openPort.Text = "Open Port"
        Me.openPort.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(273, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(193, 75)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'modeSelect2
        '
        Me.modeSelect2.Location = New System.Drawing.Point(44, 140)
        Me.modeSelect2.Name = "modeSelect2"
        Me.modeSelect2.Size = New System.Drawing.Size(93, 54)
        Me.modeSelect2.TabIndex = 7
        Me.modeSelect2.Text = "Sunair -> Crypto" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sailor -> N/C"
        Me.modeSelect2.UseVisualStyleBackColor = True
        Me.modeSelect2.Visible = False
        '
        'modeSelect3
        '
        Me.modeSelect3.Location = New System.Drawing.Point(143, 140)
        Me.modeSelect3.Name = "modeSelect3"
        Me.modeSelect3.Size = New System.Drawing.Size(93, 54)
        Me.modeSelect3.TabIndex = 8
        Me.modeSelect3.Text = "Sunair -> N/C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sailor -> Harris"
        Me.modeSelect3.UseVisualStyleBackColor = True
        Me.modeSelect3.Visible = False
        '
        'radioControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 242)
        Me.Controls.Add(Me.modeSelect3)
        Me.Controls.Add(Me.modeSelect2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.openPort)
        Me.Controls.Add(Me.modeSelect1)
        Me.Controls.Add(Me.radioModeRichTextBox)
        Me.Controls.Add(Me.modeSelect0)
        Me.Controls.Add(Me.portSelector)
        Me.Name = "radioControlForm"
        Me.Text = "Radio Control"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents radioPort As System.IO.Ports.SerialPort
    Friend WithEvents portSelector As System.Windows.Forms.ComboBox
    Friend WithEvents radioModeRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents modeSelect0 As System.Windows.Forms.Button
    Friend WithEvents modeSelect1 As System.Windows.Forms.Button
    Friend WithEvents openPort As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents modeSelect2 As System.Windows.Forms.Button
    Friend WithEvents modeSelect3 As System.Windows.Forms.Button

End Class
