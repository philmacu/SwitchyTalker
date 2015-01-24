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

    Private Sub radioPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles radioPort.DataReceived
        'this is created by clicking on the SerialPort1 obect and selecting EVENT data received
        'now we want to create our own function to handle the data in the buffer
        receiveData(radioPort.ReadExisting())
    End Sub
    Private Sub receiveData(p1 As String)
        'create the thread
        'place it into a string
        Dim tempString As String
        Dim loopCount As Integer
        'me is the address of this form
        If Me.radioModeRichTextBox.InvokeRequired Then
            'creae an obect x based on the thread type we defined at the start
            Dim x As New subTextCallback(AddressOf receiveData)
            Me.Invoke(x, New Object() {[p1]})
        Else
            tempString = radioModeRichTextBox.Text
            Me.radioModeRichTextBox.Text &= [p1]
            Dim FirstCharacter As Integer = radioModeRichTextBox.Text.IndexOf(Chr(3))
            If FirstCharacter <> -1 Then

            End If
        End If

    End Sub
End Class
