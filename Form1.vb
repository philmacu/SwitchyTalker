Imports System
Imports System.Threading        'threading is used for receiving data in
Imports System.IO.Ports
Imports System.ComponentModel

Public Class radioControlForm
    Dim myPorts As Array
    Dim portOpen As Boolean
    Delegate Sub subTextCallback(ByVal [text] As String) 'this is to prevent thrading errors

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPorts = IO.Ports.SerialPort.GetPortNames()
        portSelector.Items.AddRange(myPorts)
        portOpen = False
    End Sub

    Private Sub modeSelect0_Click(sender As Object, e As EventArgs) Handles modeSelect0.Click
        'operator wants mode 0 send string
        radioPort.Write(Chr(2) & "SET 0" & Chr(3))
    End Sub

    Private Sub openPort_Click(sender As Object, e As EventArgs) Handles openPort.Click
        'try open port
        If portSelector.Text <> "Select Port" Then
            radioPort.PortName = portSelector.Text
            radioPort.BaudRate = 9600
            radioPort.Open()
            portOpen = True
            modeSelect0.Visible = portOpen
            modeSelect1.Visible = portOpen
            modeSelect2.Visible = portOpen
            modeSelect3.Visible = portOpen
        End If
    End Sub

    Private Sub modeSelect1_Click(sender As Object, e As EventArgs) Handles modeSelect1.Click
        radioPort.Write(Chr(2) & "SET 1" & Chr(3))
    End Sub

    Private Sub modeSelect2_Click(sender As Object, e As EventArgs) Handles modeSelect2.Click
        radioPort.Write(Chr(2) & "SET 2" & Chr(3))
    End Sub

    Private Sub modeSelect3_Click(sender As Object, e As EventArgs) Handles modeSelect3.Click
        radioPort.Write(Chr(2) & "SET 3" & Chr(3))
    End Sub
End Class
