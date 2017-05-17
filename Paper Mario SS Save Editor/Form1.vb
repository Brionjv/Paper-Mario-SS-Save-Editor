Public Class Form1
    Dim filepath As String
    Dim fdialog As New Form2
    Dim sticker1 As String
    Dim sticker2 As String
    Dim sticker3 As String
    Dim sticker4 As String
    Dim sticker5 As String
    Dim sticker6 As String
    Dim sticker7 As String
    Dim sticker8 As String
    Dim sticker9 As String
    Dim sticker10 As String
    Dim sticker11 As String
    Dim sticker12 As String
    Dim sticker13 As String
    Dim sticker14 As String
    Dim sticker15 As String
    Dim sticker1x As String
    Dim sticker2x As String
    Dim sticker3x As String
    Dim sticker4x As String
    Dim sticker5x As String
    Dim sticker6x As String
    Dim sticker7x As String
    Dim sticker8x As String
    Dim sticker9x As String
    Dim sticker10x As String
    Dim sticker11x As String
    Dim sticker12x As String
    Dim sticker13x As String
    Dim sticker14x As String
    Dim sticker15x As String
    Dim sticker1y As String
    Dim sticker2y As String
    Dim sticker3y As String
    Dim sticker4y As String
    Dim sticker5y As String
    Dim sticker6y As String
    Dim sticker7y As String
    Dim sticker8y As String
    Dim sticker9y As String
    Dim sticker10y As String
    Dim sticker11y As String
    Dim sticker12y As String
    Dim sticker13y As String
    Dim sticker14y As String
    Dim sticker15y As String

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
            Reader.Position = &H148 'money
            NumericUpDown46.Value = Reader.ReadUInt16
            Reader.Position = &H14C 'hp1
            NumericUpDown47.Value = Reader.ReadUInt16
            Reader.Position = &H150 'hp2
            NumericUpDown48.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 'sticker 1
            sticker1 = Reader.Position
            NumericUpDown3.Value = Reader.ReadUInt16
            Reader.Position = &H1E6 'sticker 1x
            sticker1x = Reader.Position
            NumericUpDown1.Value = Reader.ReadUInt16
            Reader.Position = &H1E8 'sticker 1y
            sticker1y = Reader.Position
            NumericUpDown2.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + &HA 'sticker 2
            sticker2 = Reader.Position
            NumericUpDown4.Value = Reader.ReadUInt16
            Reader.Position = &H1E6 + &HA 'sticker 2x
            sticker2x = Reader.Position
            NumericUpDown6.Value = Reader.ReadUInt16
            Reader.Position = &H1E8 + &HA 'sticker 2y
            sticker2y = Reader.Position
            NumericUpDown5.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 2) 'sticker 3
            sticker3 = Reader.Position
            NumericUpDown10.Value = Reader.ReadUInt16
            Reader.Position = &H1E6 + (&HA * 2) 'sticker 3x
            sticker3x = Reader.Position
            NumericUpDown12.Value = Reader.ReadUInt16
            Reader.Position = &H1E8 + (&HA * 2) 'sticker 3y
            sticker3y = Reader.Position
            NumericUpDown11.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 3) 'sticker 4
            sticker4 = Reader.Position
            NumericUpDown7.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 4) 'sticker 5
            sticker5 = Reader.Position
            NumericUpDown13.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 5) 'sticker 6
            sticker6 = Reader.Position
            NumericUpDown28.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 6) 'sticker 7
            sticker7 = Reader.Position
            NumericUpDown25.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 7) 'sticker 8
            sticker8 = Reader.Position
            NumericUpDown22.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 8) 'sticker 9
            sticker9 = Reader.Position
            NumericUpDown19.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 9) 'sticker 10
            sticker10 = Reader.Position
            NumericUpDown16.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 10) 'sticker 11
            sticker11 = Reader.Position
            NumericUpDown43.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 11) 'sticker 12
            sticker12 = Reader.Position
            NumericUpDown40.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 12) 'sticker 13
            sticker13 = Reader.Position
            NumericUpDown37.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 13) 'sticker 14
            sticker14 = Reader.Position
            NumericUpDown34.Value = Reader.ReadUInt16
            Reader.Position = &H1E0 + (&HA * 14) 'sticker 15
            sticker15 = Reader.Position
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
            Writer.Position = &H148
            Writer.WriteUInt16(NumericUpDown46.Value)
            Writer.Position = &H14C
            Writer.WriteUInt16(NumericUpDown47.Value)
            Writer.Position = &H150
            Writer.WriteUInt16(NumericUpDown48.Value)
            Writer.Position = &H1E0
            Writer.WriteUInt16(NumericUpDown3.Value)
            fdialog.Label1.Text = "File save"
            fdialog.ShowDialog()
        Catch ex As Exception
            fdialog.Label1.Text = "An error has ocurred, load a save file first"
            fdialog.ShowDialog()
        End Try

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = ComboBox2.Items.Item(0) Then
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(1) Then
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(2) Then
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(3) Then
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(4) Then
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(5) Then
            NumericUpDown1.Value = 0
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(6) Then
            NumericUpDown1.Value = 1
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(7) Then
            NumericUpDown1.Value = 1
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(8) Then
            NumericUpDown1.Value = 1
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(9) Then
            NumericUpDown1.Value = 1
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(10) Then
            NumericUpDown1.Value = 1
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(11) Then
            NumericUpDown1.Value = 2
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(12) Then
            NumericUpDown1.Value = 2
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(13) Then
            NumericUpDown1.Value = 2
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(14) Then
            NumericUpDown1.Value = 2
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(15) Then
            NumericUpDown1.Value = 2
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(16) Then
            NumericUpDown1.Value = 3
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(17) Then
            NumericUpDown1.Value = 3
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(18) Then
            NumericUpDown1.Value = 3
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(19) Then
            NumericUpDown1.Value = 3
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(20) Then
            NumericUpDown1.Value = 3
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(21) Then
            NumericUpDown1.Value = 4
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(22) Then
            NumericUpDown1.Value = 4
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(23) Then
            NumericUpDown1.Value = 4
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(24) Then
            NumericUpDown1.Value = 4
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(25) Then
            NumericUpDown1.Value = 4
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(26) Then
            NumericUpDown1.Value = 5
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(27) Then
            NumericUpDown1.Value = 5
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(28) Then
            NumericUpDown1.Value = 5
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(29) Then
            NumericUpDown1.Value = 5
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(30) Then
            NumericUpDown1.Value = 5
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(31) Then
            NumericUpDown1.Value = 6
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(32) Then
            NumericUpDown1.Value = 6
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(33) Then
            NumericUpDown1.Value = 6
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(34) Then
            NumericUpDown1.Value = 6
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(35) Then
            NumericUpDown1.Value = 6
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(36) Then
            NumericUpDown1.Value = 7
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(37) Then
            NumericUpDown1.Value = 7
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(38) Then
            NumericUpDown1.Value = 7
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(39) Then
            NumericUpDown1.Value = 7
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(40) Then
            NumericUpDown1.Value = 7
            NumericUpDown2.Value = 4
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(41) Then
            NumericUpDown1.Value = 8
            NumericUpDown2.Value = 0
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(42) Then
            NumericUpDown1.Value = 8
            NumericUpDown2.Value = 1
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(43) Then
            NumericUpDown1.Value = 8
            NumericUpDown2.Value = 2
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(44) Then
            NumericUpDown1.Value = 8
            NumericUpDown2.Value = 3
        ElseIf ComboBox2.SelectedItem = ComboBox2.Items.Item(45) Then
            NumericUpDown1.Value = 8
            NumericUpDown2.Value = 4
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If NumericUpDown3.Value < 15 Then
            NumericUpDown49.Value = 1073676288  'sticker nonexistent
            PictureBox1.Visible = False
        ElseIf NumericUpDown3.Value = 15 Then
            NumericUpDown49.Value = 65534  'sticker existent
            PictureBox1.Visible = True
        ElseIf NumericUpDown3.Value > 15 Then
            NumericUpDown49.Value = 65534  'sticker existent
            PictureBox1.Visible = True
        End If
        PictureBox1.Image = PictureBox17.BackgroundImage
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged, NumericUpDown2.ValueChanged
        If NumericUpDown1.Value = 0 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(88, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(1)
        ElseIf NumericUpDown1.Value = 0 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(88, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(2)
        ElseIf NumericUpDown1.Value = 0 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(88, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(3)
        ElseIf NumericUpDown1.Value = 0 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(88, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(4)
        ElseIf NumericUpDown1.Value = 0 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(88, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(5)
        ElseIf NumericUpDown1.Value = 1 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(112, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(6)
        ElseIf NumericUpDown1.Value = 1 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(112, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(7)
        ElseIf NumericUpDown1.Value = 1 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(112, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(8)
        ElseIf NumericUpDown1.Value = 1 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(112, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(9)
        ElseIf NumericUpDown1.Value = 1 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(112, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(10)
        ElseIf NumericUpDown1.Value = 2 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(136, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(11)
        ElseIf NumericUpDown1.Value = 2 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(136, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(12)
        ElseIf NumericUpDown1.Value = 2 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(136, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(13)
        ElseIf NumericUpDown1.Value = 2 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(136, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(14)
        ElseIf NumericUpDown1.Value = 2 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(136, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(15)
        ElseIf NumericUpDown1.Value = 3 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(160, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(16)
        ElseIf NumericUpDown1.Value = 3 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(160, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(17)
        ElseIf NumericUpDown1.Value = 3 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(160, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(18)
        ElseIf NumericUpDown1.Value = 3 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(160, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(19)
        ElseIf NumericUpDown1.Value = 3 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(160, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(20)
        ElseIf NumericUpDown1.Value = 4 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(184, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(21)
        ElseIf NumericUpDown1.Value = 4 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(184, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(22)
        ElseIf NumericUpDown1.Value = 4 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(184, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(23)
        ElseIf NumericUpDown1.Value = 4 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(184, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(24)
        ElseIf NumericUpDown1.Value = 4 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(184, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(25)
        ElseIf NumericUpDown1.Value = 5 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(208, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(26)
        ElseIf NumericUpDown1.Value = 5 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(208, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(27)
        ElseIf NumericUpDown1.Value = 5 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(208, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(28)
        ElseIf NumericUpDown1.Value = 5 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(208, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(29)
        ElseIf NumericUpDown1.Value = 5 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(208, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(30)
        ElseIf NumericUpDown1.Value = 6 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(232, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(31)
        ElseIf NumericUpDown1.Value = 6 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(232, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(32)
        ElseIf NumericUpDown1.Value = 6 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(232, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(33)
        ElseIf NumericUpDown1.Value = 6 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(232, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(34)
        ElseIf NumericUpDown1.Value = 6 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(232, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(35)
        ElseIf NumericUpDown1.Value = 7 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(256, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(36)
        ElseIf NumericUpDown1.Value = 7 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(256, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(37)
        ElseIf NumericUpDown1.Value = 7 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(256, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(38)
        ElseIf NumericUpDown1.Value = 7 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(256, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(39)
        ElseIf NumericUpDown1.Value = 7 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(256, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(40)
        ElseIf NumericUpDown1.Value = 8 And NumericUpDown2.Value = 0 Then
            PictureBox1.Location = New Point(280, 158)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(41)
        ElseIf NumericUpDown1.Value = 8 And NumericUpDown2.Value = 1 Then
            PictureBox1.Location = New Point(280, 182)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(42)
        ElseIf NumericUpDown1.Value = 8 And NumericUpDown2.Value = 2 Then
            PictureBox1.Location = New Point(280, 206)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(43)
        ElseIf NumericUpDown1.Value = 8 And NumericUpDown2.Value = 3 Then
            PictureBox1.Location = New Point(280, 230)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(44)
        ElseIf NumericUpDown1.Value = 8 And NumericUpDown2.Value = 4 Then
            PictureBox1.Location = New Point(280, 254)
            ComboBox2.SelectedItem = ComboBox2.Items.Item(45)
        End If
    End Sub
End Class
