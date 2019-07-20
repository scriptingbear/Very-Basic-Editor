Imports System.Drawing.Printing
Imports System.IO

Public Class frmEditor
    Dim filePath As String
    Private Sub CustomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomizeToolStripMenuItem.Click
        If Me.FontDialog1.ShowDialog() = DialogResult.OK Then
            Me.txtData.SelectionFont = New Font(Me.FontDialog1.Font, Me.FontDialog1.Font.Style)

        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        If Me.ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.txtData.BackColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                filePath = OpenFileDialog1.FileName
                'Using sr As StreamReader = New StreamReader(filePath)
                '    txtData.Text = sr.ReadToEnd()
                '    Me.Text = Path.GetFileName(filePath)
                'End Using
                If OpenFileDialog1.FilterIndex = 0 Then
                    txtData.LoadFile(filePath, RichTextBoxStreamType.PlainText)
                Else
                    txtData.LoadFile(filePath, RichTextBoxStreamType.RichText)
                End If

                Me.Text = Path.GetFileName(filePath)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        'If filePath variable has been assigned a value, save contents of
        'txtData to that value. If filePath variable has not been assigned
        'a value invoke the SaveAs button's Click() event procedure
        Try
            If filePath <> String.Empty Then
                'Using sw As StreamWriter = New StreamWriter(filePath, False)
                '    sw.Write(txtData.Text)
                'End Using
                If Microsoft.VisualBasic.Strings.Right(filePath, 3).ToLower() = "txt" Then
                    txtData.SaveFile(filePath, RichTextBoxStreamType.PlainText)
                Else
                    txtData.SaveFile(filePath, RichTextBoxStreamType.RichText)
                End If

            Else
                    SaveAsToolStripMenuItem.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                filePath = SaveFileDialog1.FileName
                Me.Text = Path.GetFileName(filePath)
                'Using sw As StreamWriter = New StreamWriter(filePath, False)
                '    sw.Write(txtData.Text)
                'End Using
                If SaveFileDialog1.FilterIndex = 0 Then
                    txtData.SaveFile(filePath, RichTextBoxStreamType.PlainText)
                Else
                    txtData.SaveFile(filePath, RichTextBoxStreamType.RichText)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Access the Graphics object and configure its text, font, font color, brush type
        '(solid brush) and the x,y coordinates of the upper left corner of the printing region
        e.Graphics.DrawString(txtData.Text, FontDialog1.Font, New SolidBrush(ColorDialog1.Color), 10, 10)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        txtData.Paste()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Clipboard.SetText(txtData.SelectedText)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Clipboard.SetText(txtData.SelectedText)
        txtData.SelectedText = ""
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        txtData.SelectAll()
    End Sub
End Class