Imports Microsoft.SharePoint.Client

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If System.Diagnostics.Debugger.IsAttached Then
            Me.Text = "Inspection Protocol in Debug Mode"
        Else
            Me.Text = "Inspection Protocol Ver. " & My.Application.Deployment.CurrentVersion.ToString
        End If
        Main()
    End Sub

    Private Sub Macchine_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Macchine.SelectedIndexChanged
        Compila()
        Abilita()
        If Me.Macchine.SelectedIndex > 0 Then
            RigToolStripMenuItem2.Enabled = True
        Else
            RigToolStripMenuItem2.Enabled = False
        End If
    End Sub

    Private Sub Tech_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tech.SelectedIndexChanged
        Abilita()
        If Me.Macchine.SelectedIndex > -1 Then
            TechnicianToolStripMenuItem2.Enabled = True
        Else
            TechnicianToolStripMenuItem2.Enabled = False
        End If
    End Sub

    Private Sub Interval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Interval.SelectedIndexChanged
        Abilita()
    End Sub

    Private Sub Macchine_TextChanged(sender As Object, e As EventArgs) Handles Macchine.TextChanged
        Abilita()
    End Sub

    Private Sub Tech_TextChanged(sender As Object, e As EventArgs) Handles Tech.TextChanged
        Abilita()
    End Sub

    Private Sub Interval_TextChanged(sender As Object, e As EventArgs) Handles Interval.TextChanged
        Abilita()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RigToolStripMenuItem.Click
        Me.Enabled = False
        With Form2
            .Show()
            .Text = "New Rig"
            .TextBox1.Enabled = True
            .TextBox2.Enabled = True
            .TextBox3.Enabled = True
            .TextBox4.Enabled = True
            .TextBox5.Enabled = True
            .TextBox1.Select()
        End With
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

    End Sub

    Private Sub RigToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RigToolStripMenuItem1.Click
        If Me.Macchine.SelectedIndex > 0 Then
            Dim Scelta = MsgBox("Are you sure to edit the following item?" & vbCrLf & vbCrLf & Me.Macchine.Text, vbYesNo, "Edit")
            If Scelta = vbYes Then LoadRig(Me.PN.Text, Me.SN.Text, Me.RIG.Text, Me.CUSNR.Text, Me.CUSNAME.Text)
        End If
    End Sub

    Private Sub RigToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RigToolStripMenuItem2.Click
        If Me.Macchine.SelectedIndex > 0 Then
            Dim Scelta = MsgBox("Are you sure to delete the following item?" & vbCrLf & vbCrLf & Me.Macchine.Text, vbYesNo, "Delete")
            If Scelta = vbYes Then DelRig(Me.SN.Text)
        End If
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

    End Sub

    Private Sub TechnicianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TechnicianToolStripMenuItem.Click
        AddTech()
    End Sub

    Private Sub TechnicianToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles TechnicianToolStripMenuItem2.Click
        Dim Scelta = MsgBox("Are you sure to delete the following item?" & vbCrLf & vbCrLf & Me.Tech.Text, vbYesNo, "Delete")
        If Scelta = vbYes Then
            DelTec(Me.Tech.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Me.FBD1

            If .ShowDialog = DialogResult.OK Then
                Dim Nome As String = .SelectedPath & "\Epiroc_modulo_S25_1_Inspection protocol TH"
                Dim zk As Integer
                If System.IO.File.Exists(Nome & ".xlsx") Then
                    zk = 1
                    Do While System.IO.File.Exists(Nome & "(" & zk & ").xlsx")
                        zk += 1
                    Loop
                    Nome = Nome & "(" & zk & ")" & ".xlsx"
                Else
                    Nome &= ".xlsx"
                End If
                Form3.Show()
                OKTH(Nome, Me.SN.Text, Me.PN.Text, Me.CUSNAME.Text, Me.RIG.Text, Me.Interval.Text, Me.Tech.Text)
            End If
        End With

    End Sub
End Class
