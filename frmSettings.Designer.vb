<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lblFontInfo = New System.Windows.Forms.Label()
        Me.btnSetFont = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSetBackColor = New System.Windows.Forms.Button()
        Me.lblBackColor = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSetDirectory = New System.Windows.Forms.Button()
        Me.lblDirectory = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'lblFontInfo
        '
        Me.lblFontInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFontInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblFontInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFontInfo.Location = New System.Drawing.Point(12, 51)
        Me.lblFontInfo.Name = "lblFontInfo"
        Me.lblFontInfo.Size = New System.Drawing.Size(382, 23)
        Me.lblFontInfo.TabIndex = 1
        '
        'btnSetFont
        '
        Me.btnSetFont.Location = New System.Drawing.Point(412, 51)
        Me.btnSetFont.Name = "btnSetFont"
        Me.btnSetFont.Size = New System.Drawing.Size(75, 23)
        Me.btnSetFont.TabIndex = 2
        Me.btnSetFont.Text = "Set..."
        Me.btnSetFont.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Default Font"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Default BackColor"
        '
        'btnSetBackColor
        '
        Me.btnSetBackColor.Location = New System.Drawing.Point(412, 113)
        Me.btnSetBackColor.Name = "btnSetBackColor"
        Me.btnSetBackColor.Size = New System.Drawing.Size(75, 23)
        Me.btnSetBackColor.TabIndex = 5
        Me.btnSetBackColor.Text = "Set..."
        Me.btnSetBackColor.UseVisualStyleBackColor = True
        '
        'lblBackColor
        '
        Me.lblBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackColor.Location = New System.Drawing.Point(12, 113)
        Me.lblBackColor.Name = "lblBackColor"
        Me.lblBackColor.Size = New System.Drawing.Size(382, 23)
        Me.lblBackColor.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Default Directory"
        '
        'btnSetDirectory
        '
        Me.btnSetDirectory.Location = New System.Drawing.Point(412, 173)
        Me.btnSetDirectory.Name = "btnSetDirectory"
        Me.btnSetDirectory.Size = New System.Drawing.Size(75, 23)
        Me.btnSetDirectory.TabIndex = 8
        Me.btnSetDirectory.Text = "Set..."
        Me.btnSetDirectory.UseVisualStyleBackColor = True
        '
        'lblDirectory
        '
        Me.lblDirectory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirectory.Location = New System.Drawing.Point(12, 173)
        Me.lblDirectory.Name = "lblDirectory"
        Me.lblDirectory.Size = New System.Drawing.Size(382, 23)
        Me.lblDirectory.TabIndex = 7
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 222)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSetDirectory)
        Me.Controls.Add(Me.lblDirectory)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSetBackColor)
        Me.Controls.Add(Me.lblBackColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSetFont)
        Me.Controls.Add(Me.lblFontInfo)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents lblFontInfo As Label
    Friend WithEvents btnSetFont As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSetBackColor As Button
    Friend WithEvents lblBackColor As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSetDirectory As Button
    Friend WithEvents lblDirectory As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
