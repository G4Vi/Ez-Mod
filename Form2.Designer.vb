<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDirs
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnDownloads = New System.Windows.Forms.Button
        Me.btnCommon = New System.Windows.Forms.Button
        Me.txtdl = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.btnUsername = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.FolderBrowserDialog3 = New System.Windows.Forms.FolderBrowserDialog
        Me.btnSaveOnly = New System.Windows.Forms.Button
        Me.FolderBrowserDialog4 = New System.Windows.Forms.FolderBrowserDialog
        Me.SuspendLayout()
        '
        'btnDownloads
        '
        Me.btnDownloads.Location = New System.Drawing.Point(29, 64)
        Me.btnDownloads.Name = "btnDownloads"
        Me.btnDownloads.Size = New System.Drawing.Size(75, 23)
        Me.btnDownloads.TabIndex = 0
        Me.btnDownloads.Text = "Open"
        Me.btnDownloads.UseVisualStyleBackColor = True
        '
        'btnCommon
        '
        Me.btnCommon.Location = New System.Drawing.Point(29, 134)
        Me.btnCommon.Name = "btnCommon"
        Me.btnCommon.Size = New System.Drawing.Size(75, 23)
        Me.btnCommon.TabIndex = 1
        Me.btnCommon.Text = "Open"
        Me.btnCommon.UseVisualStyleBackColor = True
        '
        'txtdl
        '
        Me.txtdl.Location = New System.Drawing.Point(162, 64)
        Me.txtdl.Name = "txtdl"
        Me.txtdl.Size = New System.Drawing.Size(449, 20)
        Me.txtdl.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(162, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(449, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select where you want to download mods before installing"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select your steamapps\common directory:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Select your steamapps\username directory"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(162, 211)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(449, 20)
        Me.TextBox3.TabIndex = 7
        '
        'btnUsername
        '
        Me.btnUsername.Location = New System.Drawing.Point(29, 208)
        Me.btnUsername.Name = "btnUsername"
        Me.btnUsername.Size = New System.Drawing.Size(75, 23)
        Me.btnUsername.TabIndex = 6
        Me.btnUsername.Text = "Open"
        Me.btnUsername.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(194, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save and Download"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSaveOnly
        '
        Me.btnSaveOnly.Location = New System.Drawing.Point(341, 299)
        Me.btnSaveOnly.Name = "btnSaveOnly"
        Me.btnSaveOnly.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveOnly.TabIndex = 10
        Me.btnSaveOnly.Text = "Save"
        Me.btnSaveOnly.UseVisualStyleBackColor = True
        '
        'frmDirs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(623, 334)
        Me.Controls.Add(Me.btnSaveOnly)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtdl)
        Me.Controls.Add(Me.btnCommon)
        Me.Controls.Add(Me.btnDownloads)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmDirs"
        Me.Text = "Select your download and install directories"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnDownloads As System.Windows.Forms.Button
    Friend WithEvents btnCommon As System.Windows.Forms.Button
    Friend WithEvents txtdl As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents btnUsername As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog3 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSaveOnly As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog4 As System.Windows.Forms.FolderBrowserDialog
End Class
