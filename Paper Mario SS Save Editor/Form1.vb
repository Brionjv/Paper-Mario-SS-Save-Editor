Public Class Form1
    Dim filepath As String
    Dim fdialog As New Form2
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog
        open.Title = "Open your save pm4_0,1 or 2"
        open.ShowDialog()
        filepath = open.FileName
        Readfile()
    End Sub
    Private Sub Readfile()
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            Reader.Position = &H1E0
            NumericUpDown3.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + &HA
            NumericUpDown4.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 2)
            NumericUpDown10.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 3)
            NumericUpDown7.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 4)
            NumericUpDown13.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 5)
            NumericUpDown28.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 6)
            NumericUpDown25.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 7)
            NumericUpDown22.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 8)
            NumericUpDown19.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 9)
            NumericUpDown16.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 10)
            NumericUpDown43.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 11)
            NumericUpDown40.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 12)
            NumericUpDown37.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 13)
            NumericUpDown34.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 14)
            NumericUpDown31.Value = Reader.ReadUInt16
            fdialog.Label1.Text = "Don't exceed limit of album" & vbNewLine & "Exceeding this limit will give you an error " & vbNewLine & "when your save will load"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "Paper Mario : Sticker Star save not load successfully" & vbNewLine & "He may be corrupted or not a valid save file"
            fdialog.ShowDialog()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Writefile()
    End Sub
    Private Sub Writefile()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = &H1E0
            Writer.WriteUInt16(NumericUpDown3.Value)
            MsgBox("file save")
        Catch ex As Exception
            MsgBox("erreur")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox32.SelectedItem = ComboBox32.Items.Item(0)
    End Sub
End Class
