Imports System
Imports System.Threading        'threading is used for receiving data in
Imports System.IO.Ports
Imports System.ComponentModel

Public Class radioControlForm
    Dim myPorts As Array
    Delegate Sub subTextCallback(ByVal [text] As String) 'this is to prevent thrading errors

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myPorts = IO.Ports.SerialPort.GetPortNames()
        portSelector.Items.AddRange(myPorts)
    End Sub
End Class
