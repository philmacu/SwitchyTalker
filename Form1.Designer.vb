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
        Me.SuspendLayout()
        '
        'portSelector
        '
        Me.portSelector.FormattingEnabled = True
        Me.portSelector.Location = New System.Drawing.Point(414, 28)
        Me.portSelector.Name = "portSelector"
        Me.portSelector.Size = New System.Drawing.Size(125, 21)
        Me.portSelector.TabIndex = 0
        Me.portSelector.Text = "Select Port"
        '
        'radioControlForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 242)
        Me.Controls.Add(Me.portSelector)
        Me.Name = "radioControlForm"
        Me.Text = "Radio Control"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents radioPort As System.IO.Ports.SerialPort
    Friend WithEvents portSelector As System.Windows.Forms.ComboBox

End Class
