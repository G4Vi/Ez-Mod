Imports System
Imports System.IO
Imports System.Text
Public Class frmDirs
    Dim dldir, commondir, usernamedir, winzip As String
    Public Shared nodl As Boolean = False
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDownloads.Click
        FolderBrowserDialog1.ShowDialog()
        txtdl.Text = FolderBrowserDialog1.SelectedPath & "\"
    End Sub

    Private Sub btnCommon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommon.Click
        FolderBrowserDialog2.ShowDialog()
        TextBox2.Text = FolderBrowserDialog2.SelectedPath & "\"
    End Sub

    Private Sub btnUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsername.Click
        FolderBrowserDialog3.ShowDialog()
        TextBox3.Text = FolderBrowserDialog3.SelectedPath & "\"
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click, btnSaveOnly.Click
        Dim sw As StreamWriter
        Dim dlstr As String = Form1.TextBox1.Text
        Dim dlindex1 As String
        dldir = txtdl.Text
        commondir = TextBox2.Text
        usernamedir = TextBox3.Text
        If IO.File.Exists("settings.cfg") Then
            IO.File.Delete("settings.cfg")
        End If
        If dldir = "" Or commondir = "" Or usernamedir = "" Then
            MessageBox.Show("Please select a directory for each")
        Else
            sw = File.CreateText("settings.cfg")
            sw.WriteLine(dldir)
            sw.WriteLine(commondir)
            sw.WriteLine(usernamedir)
            sw.Close()
            dlindex1 = dlstr.Substring(dlstr.Length - 3, 2)
            If nodl = False Then
                Form1.Button6.Enabled = False
                Form1.dl2()
            End If
            If Form1.Visible = False Then
                Form1.Visible = True
            End If
            Me.Close()
        End If
    End Sub


    Private Sub frmDirs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IO.File.Exists("settings.cfg") Then
            Dim sr As IO.StreamReader = IO.File.OpenText("settings.cfg")
            txtdl.Text = sr.ReadLine
            TextBox2.Text = sr.ReadLine
            TextBox3.Text = sr.ReadLine
            sr.Close()
        End If
    End Sub

End Class