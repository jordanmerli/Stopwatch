Public Class Form1
    Private anni As Integer = 0
    Private giorni As Integer = 0
    Private ore As Integer = 0
    Private minuti As Integer = 0
    Private secondi As Integer = 0
    Private millisecondi As Integer = 0
    Dim OraCorrente As String = Format(DateTime.Now, "hh:mm:ss")
    Sub MostraTempo()
        Label1.Text = anni.tostring.padleft(2, "0") & ":"
        Label1.Text &= giorni.ToString.PadLeft(3, "0") & ":"
        Label1.Text &= ore.ToString.PadLeft(2, "0") & ":"
        Label1.Text &= minuti.ToString.PadLeft(2, "0") & ":"
        Label1.Text &= secondi.ToString.PadLeft(2, "0") & ":"
        Label1.Text &= millisecondi.ToString.PadLeft(1, "0")
        Label1.Refresh()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        millisecondi += 1
        If millisecondi = 9 Then
            millisecondi = 0
            secondi += 1
            If secondi = 59 Then
                secondi = 0
                minuti += 1
                If minuti = 59 Then
                    minuti = 0
                    ore += 1
                    If ore = 23 Then
                        ore = 0
                        giorni += 1
                        If giorni = 365 Then
                            giorni = 0
                            anni += 1
                        End If
                    End If
                End If
            End If
        End If
        MostraTempo()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        Timer2.Interval = 1
        Timer3.Start()
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label2.Text = TimeOfDay
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Me.Text = "Jordan Merli   " & DateAndTime.Now
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            DataGridView1.Visible = True
        Else
            DataGridView1.Visible = False
        End If
        DataGridView1.RowsDefaultCellStyle.BackColor() = Color.Khaki
    End Sub
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Timer1.Enabled = True
        PictureBox3.Visible = True
    End Sub
    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Timer1.Enabled = False
    End Sub
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        DataGridView1.Rows.Add(DataGridView1.Rows.Count(), Label1.Text, DateTime.Now)
        giorni = 0
        ore = 0
        minuti = 0
        secondi = 0
        millisecondi = 0
        MostraTempo()
        Timer1.Stop()
        PictureBox3.Visible = False
    End Sub
    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        DataGridView1.Rows.Add(DataGridView1.Rows.Count(), Label1.Text, DateTime.Now)
        MostraTempo()
        DataGridView1.RowsDefaultCellStyle.BackColor() = Color.Khaki
    End Sub
    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("mailto:joe@nanoteck@hotmail.it")
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://nanoteck.altervista.org")
    End Sub
End Class
