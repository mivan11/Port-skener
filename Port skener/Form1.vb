Imports System.Net.Sockets
Public Class Form1
    Dim ip As String
    Dim port As Integer
    Dim i As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        stani.Enabled = False
        'tekst2.Text = "0"

        i = 0
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stani.Click
        Timer1.Stop()
        Timer1.Enabled = False
        start.Enabled = True
        stani.Enabled = False
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        i += 1
        tekst2.Text = i
        ip = tekst1.Text
        port = tekst2.Text
        Dim hostadd As System.Net.IPAddress = System.Net.Dns.GetHostEntry(ip).AddressList(0)
        Dim EPhost As New System.Net.IPEndPoint(hostadd, port)
        Dim s As New System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp)
        Try
            s.Connect(EPhost)
        Catch
        End Try
        If Not s.Connected Then
            Lista.Items.Add("Alive: " + port.ToString)
        Else
            Lista.Items.Add("Live: " + port.ToString)
            Lista2.Items.Add(port.ToString)
        End If
        Label3.Text = "Otvoreni portovi: " + Lista2.Items.Count.ToString
    End Sub
    Private Sub osvjezi_Click(sender As Object, e As EventArgs) Handles osvjezi.Click
        Timer1.Stop()
        Timer1.Enabled = False
        start.Enabled = True
        stani.Enabled = False
        tekst1.Text = ""
        tekst2.Text = ""
        i = 0
        Lista.Items.Clear()
        Lista2.Items.Clear()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        Lista.Items.Add("Pričekajte: " + tekst1.Text)
        Lista.Items.Add("****************************")
        stani.Enabled = True
        start.Enabled = False
        Timer1.Enabled = True
        Timer1.Start()
    End Sub
    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    i += 1
    '    tekst2.Text = i
    '    ip = tekst1.Text
    '    port = tekst2.Text

    '    Try
    '        tekst1.Text = tekst1.Text + 1
    '        Dim Range As TcpClient = New TcpClient(tekst1.Text, tekst2.Text)

    '        If Range.Connected = True Then
    '            Lista.Items.Add(tekst2.Text & " Is Open")
    '            Lista.SelectedIndex = Lista.SelectedIndex + 1
    '        End If
    '    Catch ex As Exception
    '        Lista.Items.Add(tekst2.Text & " Is Closed")
    '        Lista.SelectedIndex = Lista.SelectedIndex + 1
    '    End Try
    'End Sub



    'Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
    '    Timer1.Enabled = True
    'End Sub

    'Private Sub stani_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stani.Click
    '    Timer1.Enabled = False
    'End Sub
End Class
