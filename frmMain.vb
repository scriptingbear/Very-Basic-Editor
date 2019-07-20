Public Class frmMain
    Dim findString As String
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NewEditorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewEditorToolStripMenuItem.Click


        Dim frmNew As New frmEditor
        frmNew.MdiParent = Me

        frmNew.txtData.SelectionFont = New Font(My.Settings.DefaultFontInfo.Name,
                                                My.Settings.DefaultFontInfo.Size,
                                                My.Settings.DefaultFontInfo.Style)

        frmNew.txtData.BackColor = My.Settings.DefaultEditorBackColor
        frmNew.Show()
        'MessageBox.Show(frmNew.txtData.Font.FontFamily.Name)
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        Dim frm As New frmSettings

        frm.ShowDialog()

    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        Dim formNames As New List(Of String)

        If My.Application.OpenForms.Count > 1 Then

            For Each frm As Form In My.Application.OpenForms
                If frm.Name <> Me.Name Then
                    formNames.Add(frm.Name)
                End If
            Next

            For Each formName As String In formNames
                My.Application.OpenForms(formName).Close()
            Next
        Else
            MessageBox.Show("No open forms", "Very Basic Editor", MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        If My.Application.OpenForms.Count > 1 Then
            Me.LayoutMdi(MdiLayout.Cascade)
        End If
    End Sub

    Private Sub TileVerticalllyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalllyToolStripMenuItem.Click
        If My.Application.OpenForms.Count > 1 Then
            Me.LayoutMdi(MdiLayout.TileVertical)
        End If
    End Sub

    Private Sub TileHorizontallyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontallyToolStripMenuItem.Click
        If My.Application.OpenForms.Count > 1 Then
            Me.LayoutMdi(MdiLayout.TileHorizontal)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        Dim foundCount As Integer = 0
        findString = String.Empty
        If My.Application.OpenForms.Count > 1 Then
            'Hide the replace controls on the form
            frmFind.lblReplace.Visible = False
            frmFind.txtReplaceText.Visible = False

            If frmFind.ShowDialog() = DialogResult.OK Then
                findString = frmFind.txtFindText.Text
            End If
            frmFind.Close()
            If findString <> String.Empty Then
                For Each frm As Form In My.Application.OpenForms
                    If frm.Name <> Me.Name Then
                        If frm.Controls.ContainsKey("txtData") Then
                            Dim ctrl As RichTextBox = frm.Controls("txtData")
                            If ctrl.Find(findString) > -1 Then
                                foundCount += 1
                            End If 'ctrl.Find(findString) > -1
                        End If 'frm.Controls.ContainsKey("txtData")
                    End If 'frm.Name <> Me.Name
                Next frm
                MessageBox.Show(foundCount & " ocurrences found", "Very Basic Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If 'findString <> String.Empty
        End If 'My.Application.OpenForms.Count > 1
    End Sub

    Private Sub FindNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindNextToolStripMenuItem.Click
        Dim foundCount As Integer = 0

        If My.Application.OpenForms.Count > 1 Then
            If findString <> String.Empty Then
                Try
                    For Each frm As Form In My.Application.OpenForms
                        If frm.Name <> Me.Name Then
                            If frm.Controls.ContainsKey("txtData") Then
                                Dim ctrl As RichTextBox = frm.Controls("txtData")
                                If ctrl.Text <> String.Empty Then
                                    Dim startPosition As Integer = ctrl.SelectionStart + 1
                                    If ctrl.Find(findString, startPosition, RichTextBoxFinds.None) > -1 Then
                                        foundCount += 1
                                    End If 'ctrl.Find(findString) > -1
                                End If 'ctrl.Text <> String.Empty
                            End If 'frm.Controls.ContainsKey("txtData")
                        End If 'frm.Name <> Me.Name
                    Next frm
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Very Basic Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If 'findString <> String.Empty
        End If 'My.Application.OpenForms.Count > 1
    End Sub

    Private Sub ReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReplaceToolStripMenuItem.Click
        Dim dataString As String = String.Empty
        Dim replaceString As String = String.Empty
        Dim lengthBeforeReplace As Integer = 0
        Dim lengthAfterReplace As Integer = 0
        Dim replacementCount As Integer = 0
        Dim lengthReplaceString As Integer = 0

        If My.Application.OpenForms.Count > 1 Then
            frmFind.txtFindText.Text = findString
            If frmFind.ShowDialog() = DialogResult.OK Then
                findString = frmFind.txtFindText.Text
                replaceString = frmFind.txtReplaceText.Text
            End If
            frmFind.Close()

            If findString <> String.Empty Then
                Try
                    For Each frm As Form In My.Application.OpenForms
                        If frm.Name <> Me.Name Then
                            If frm.Controls.ContainsKey("txtData") Then
                                Dim ctrl As RichTextBox = frm.Controls("txtData")
                                If ctrl.Text <> String.Empty Then
                                    dataString = ctrl.Text
                                    'Calculate number of replacements
                                    lengthBeforeReplace = Len(dataString)
                                    lengthAfterReplace = Len(dataString.Replace(findString, ""))
                                    lengthReplaceString = Len(replaceString)
                                    If lengthReplaceString > 0 Then
                                        replacementCount += (lengthBeforeReplace - lengthAfterReplace) / lengthReplaceString
                                    Else
                                        replacementCount += (lengthBeforeReplace - lengthAfterReplace)
                                    End If
                                    ctrl.Text = dataString.Replace(findString, replaceString)
                                End If 'ctrl.Text <> String.Empty
                            End If 'frm.Controls.ContainsKey("txtData")
                        End If 'frm.Name <> Me.Name
                    Next frm
                    MessageBox.Show(replacementCount & " replacements made", "Very Basic Editor", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Very Basic Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
            End If 'findString <> String.Empty
        End If 'My.Application.OpenForms.Count > 1
    End Sub
End Class
