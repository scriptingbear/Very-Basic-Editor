Public Class frmSettings
#Disable Warning IDE1006 ' Naming Styles
    Private Sub PropertyGrid1_Click(sender As Object, e As EventArgs)
#Enable Warning IDE1006 ' Naming Styles

    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load
#Enable Warning IDE1006 ' Naming Styles
        Dim fontInfo As String = String.Empty


        'Display current default font info
        fontInfo += My.Settings.DefaultFontInfo.Name
        fontInfo += "," & My.Settings.DefaultFontInfo.Size.ToString()
        fontInfo += "," & My.Settings.DefaultFontInfo.Style.ToString()
        lblFontInfo.Text = fontInfo

        'Display current default BackColor
        lblBackColor.Text = My.Settings.DefaultEditorBackColor.Name
        lblBackColor.BackColor = My.Settings.DefaultEditorBackColor

        'Display current default directory
        lblDirectory.Text = My.Settings.DefaultDirectory


    End Sub

#Disable Warning IDE1006 ' Naming Styles
    Private Sub PropertyGrid1_SelectedGridItemChanged(sender As Object, e As SelectedGridItemChangedEventArgs)
#Enable Warning IDE1006 ' Naming Styles

    End Sub

    Private Sub PropertyGrid1_MouseClick(sender As Object, e As MouseEventArgs)


    End Sub

    Private Sub PropertyGrid1_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub BtnSetFont_Click(sender As Object, e As EventArgs) Handles btnSetFont.Click
        Dim fontInfo As String = String.Empty


        If Me.FontDialog1.ShowDialog() = DialogResult.OK Then
            fontInfo += Me.FontDialog1.Font.Name
            fontInfo += "," & Me.FontDialog1.Font.Size.ToString()
            fontInfo += "," & Me.FontDialog1.Font.Style.ToString()
            Me.lblFontInfo.Text = fontInfo

            My.Settings.DefaultFontInfo = New Font(Me.FontDialog1.Font.Name,
                                                   Me.FontDialog1.Font.Size,
                                                   Me.FontDialog1.Font.Style)
            My.Settings.Save()

        End If
    End Sub

    Private Sub BtnSetBackColor_Click(sender As Object, e As EventArgs) Handles btnSetBackColor.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            lblBackColor.Text = ColorDialog1.Color.Name
            lblBackColor.BackColor = ColorDialog1.Color
            My.Settings.DefaultEditorBackColor = ColorDialog1.Color
            My.Settings.Save()
        End If
    End Sub

    Private Sub BtnSetDirectory_Click(sender As Object, e As EventArgs) Handles btnSetDirectory.Click
        Dim defaultDirectory As String = String.Empty

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            defaultDirectory = FolderBrowserDialog1.SelectedPath
            lblDirectory.Text = defaultDirectory
            My.Settings.DefaultDirectory = defaultDirectory
            My.Settings.Save()
        End If
    End Sub
End Class