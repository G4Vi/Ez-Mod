Imports System
Imports System.IO
Imports System.Text
Imports System.Collections
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.Threading
Imports System.Windows.Forms
Imports ICSharpCode.SharpZipLib.Core
Imports ICSharpCode.SharpZipLib.Zip

Public Class Form1
    Dim counter As Integer
    Dim Dirall As String
    Dim dlocation As String
    Dim namea As String
    Private Sub webBrowser1_Navigated(ByVal sender As Object, _
    ByVal e As WebBrowserNavigatedEventArgs) _
    Handles WebBrowser1.Navigated

        TextBox1.Text = WebBrowser1.Url.ToString()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LastSize = Me.Size
        'I recommend this so the controls do not
        'get a width or height of zero whenever
        'the form is decreased to much
        Me.MinimumSize = Me.Size
        Me.Text = "EzMod Game Content Downloader"
        WebBrowser1.Navigate("http://computoid.com/ezmod/")
        Button6.Enabled = False
        TabPage1.Text = "Browser"
        TabPage3.Text = "Downloads"
        ProgressBar1.Visible = False
        Dim _WebClient As New System.Net.WebClient
        Dim textfile, apath As String
        Dim objUTF8 As New UTF8Encoding()
        Dim index As Integer
        textfile = objUTF8.GetString(_WebClient.DownloadData("http://computoid.com/programupdate/"))
        index = textfile.IndexOf("http://computoid.com/files/ezmodV3.exe")
        apath = My.Application.Info.DirectoryPath
        If index <> -1 Then
            _WebClient.DownloadFile(New Uri(textfile), apath & "\" & "ezmodV3.exe")
            WebBrowser1.Visible = False
            MessageBox.Show("Updated version has been downloaded, run the newer version.")
            Me.Close()
        Else
        End If
        

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WebBrowser1.GoHome()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If IO.File.Exists("settings.cfg") Then
            If frmDirs.Visible Then
                frmDirs.Close()
            End If
            Button6.Enabled = False
            dl2()
        Else
            frmDirs.btnSaveOnly.Visible = False
            frmDirs.nodl = False
            frmDirs.Show()
        End If
    End Sub
    Function heredl(ByRef Dirall As String) As String
        Dim sr As IO.StreamReader
        sr = IO.File.OpenText("settings.cfg")
        Dirall = sr.ReadLine
        sr.Close()
        Return Dirall
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmDirs.Show()
        frmDirs.btnSave.Hide()
        frmDirs.btnSaveOnly.Visible = True
        frmDirs.nodl = True

    End Sub
    Public Sub dl()
        Dim _WebClient As New System.Net.WebClient
        Dim dlocation, namea, Dirall, weburl As String
        Dim filebool As Boolean = False
        'find where to store file
        weburl = TextBox9.Text
        dlinfo(dlocation, Dirall, namea, weburl, filebool)
        If filebool = True Then
            Exit Sub
        End If
        If IO.File.Exists(Dirall & namea) Then
            IO.File.Delete(Dirall & namea)
        End If
        'download it finally
        writefileinfo(Dirall, namea)
        AddHandler _WebClient.DownloadFileCompleted, AddressOf _DownloadFileCompleted

        AddHandler _WebClient.DownloadProgressChanged, AddressOf _DownloadProgressChanged1

        _WebClient.DownloadFileAsync(New Uri(dlocation), Dirall & namea)

    End Sub
    Sub install(ByVal weburl As String, ByVal namea As String)
        Dim installdir, commonlc, usernamelc, text2 As String
        Dim index1, index2, index3, index4, index5, index6, index7, index8, index9, index10, index11, index12, index13, index14, index15, index16, index17, index18, index19, index20, index21, index22 As Integer
        Dim sr As IO.StreamReader
        Dim objUTF8 As New UTF8Encoding()
        Dim _WebClient As New System.Net.WebClient
        sr = IO.File.OpenText("settings.cfg")
        Dirall = sr.ReadLine
        commonlc = sr.ReadLine
        usernamelc = sr.ReadLine
        sr.Close()
        text2 = objUTF8.GetString(_WebClient.DownloadData(weburl))
        index18 = text2.IndexOf("[extractlc]")
        index19 = text2.IndexOf("[/extractlc]")
        index21 = text2.IndexOf("n\")
        index22 = text2.IndexOf("r\")
        index15 = namea.IndexOf(".bsp")
        index16 = namea.IndexOf(".vpk")
        index17 = namea.IndexOf(".cfg")
        index1 = weburl.IndexOf("f=21&")
        index2 = weburl.IndexOf("f=12&")
        index4 = weburl.IndexOf("f=13&")
        index5 = weburl.IndexOf("f=14&")
        index6 = weburl.IndexOf("f=15&")
        index7 = weburl.IndexOf("f=18&")
        index8 = weburl.IndexOf("f=19&")
        index9 = weburl.IndexOf("f=20&")
        index3 = weburl.IndexOf("f=22&")
        index10 = weburl.IndexOf("f=23&")
        index11 = weburl.IndexOf("f=24&")
        index12 = weburl.IndexOf("f=25&")
        index13 = weburl.IndexOf("f=27")
        index14 = weburl.IndexOf("f=28")
        'unzipping
        Dim fastZip As FastZip = New FastZip()
        Dim fileFilter As String = Nothing
        'install dirs
        If index1 <> -1 Or index7 <> -1 Or index8 <> -1 Or index9 <> -1 And index15 = -1 And index17 = -1 Then
            installdir = usernamelc & "counter-strike source\cstrike\"
            GoTo finish
        Else
            If index1 <> -1 Or index7 <> -1 Or index8 <> -1 Or index9 <> -1 Then
                If index15 <> -1 Then
                    installdir = usernamelc & "counter-strike source\cstrike\maps\"
                    GoTo finish
                Else
                    installdir = usernamelc & "counter-strike source\cstrike\cfg\"
                    GoTo finish
                End If
            Else

            End If
        End If
        If index2 <> -1 Or index4 <> -1 Or index5 <> -1 Or index6 <> -1 And index15 = -1 And index17 = -1 Then
            installdir = usernamelc & "team fortress 2\tf\"
            GoTo finish
        Else
            If index2 <> -1 Or index4 <> -1 Or index5 <> -1 Or index6 <> -1 Then
                If index15 <> -1 Then
                    installdir = usernamelc & "team fortress 2\tf\maps\"
                    GoTo finish
                Else
                    installdir = usernamelc & "team fortress 2\tf\cfg\"
                    GoTo finish
                End If
            Else

            End If

        End If
        If index3 <> -1 Or index10 <> -1 Or index11 <> -1 Or index12 <> -1 And index15 = -1 And index17 = -1 Then
            installdir = usernamelc & "portal\portal\"
            GoTo finish
        Else
            If index3 <> -1 Or index10 <> -1 Or index11 <> -1 Or index12 <> -1 Then
                If index15 <> -1 Then
                    installdir = usernamelc & "portal\portal\maps\"
                    GoTo finish
                Else
                    installdir = usernamelc & "portal\portal\cfg\"
                    GoTo finish
                End If
            Else

            End If
        End If
        If index13 <> -1 And index16 = -1 And index17 = -1 Then
            installdir = commonlc & "left 4 dead\left4dead"
            GoTo finish
        Else
            If index13 <> -1 Then
                If index16 <> -1 Then
                    installdir = commonlc & "left 4 dead\left4dead\addons\"
                    GoTo finish
                Else
                    installdir = commonlc & "left 4 dead\left4dead\cfg\"
                    GoTo finish
                End If
            Else

            End If
        End If
        If index14 <> -1 And index16 = -1 And index17 = -1 Then
            installdir = commonlc & "left 4 dead2\left4dead2"
            GoTo finish
        Else
            If index14 <> -1 Then
                If index16 <> -1 Then
                    installdir = commonlc & "left 4 dead2\left4dead2\addons\"
                    GoTo finish
                Else
                    installdir = commonlc & "left 4 dead2\left4dead2\cfg\"
                    GoTo finish
                End If
            Else

            End If
        End If

finish:
        If index18 <> -1 Then
            If index21 <> -1 Then
                index20 = index19 - index21
                installdir = commonlc & text2.Substring(index21 + 2, index20 - 2)
            Else
                index20 = index19 - index22
                installdir = usernamelc & text2.Substring(index22 + 2, index20 - 2)
            End If
        End If
        If index15 = -1 And index16 = -1 And index17 = -1 Then
            fastZip.ExtractZip(Dirall & namea, installdir, fileFilter)
        Else
            If File.Exists(installdir & namea) Then
                File.Delete(installdir & namea)
            End If
            File.Copy(Dirall & namea, installdir & namea)
        End If
        MessageBox.Show(namea & " has been installed to " & installdir)
        If TextBox2.Text = "" Then
        Else
            dl()
        End If

    End Sub
 
    Public Sub _DownloadFileCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        Dim weburl As String
        Dim index1 As Integer
        Dim filebool As Boolean
        weburl = TextBox9.Text
        dlinfo(dlocation, Dirall, namea, weburl, filebool)
        index1 = weburl.IndexOf("f=26&")
        ListBox2.Items.Add(dlocation)
        TextBox2.Text = TextBox3.Text
        TextBox3.Text = TextBox4.Text
        TextBox4.Text = TextBox5.Text
        TextBox5.Text = TextBox6.Text
        TextBox6.Text = TextBox7.Text
        TextBox7.Text = TextBox8.Text
        TextBox8.Text = ""
        TextBox9.Text = TextBox10.Text
        TextBox10.Text = TextBox11.Text
        TextBox11.Text = TextBox12.Text
        TextBox12.Text = TextBox13.Text
        TextBox13.Text = TextBox14.Text
        TextBox14.Text = TextBox15.Text
        TextBox15.Text = ""

        If index1 = -1 Then
            MessageBox.Show(namea & " downloaded to " & Dirall & ". Click ok to install.")
            install(weburl, namea)
        Else
            MessageBox.Show(namea & " downloaded to " & Dirall)
            If TextBox2.Text = "" Then
            Else
                dl()
            End If

        End If

    End Sub



    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim _WebClient As New System.Net.WebClient
        Dim objUTF8 As New UTF8Encoding()
        'finding dlocation and name of file
        Dim weburl, Textfile As String
        weburl = TextBox1.Text
        Textfile = objUTF8.GetString(_WebClient.DownloadData(weburl))
        If Textfile.IndexOf("[link1]") > -1 Then
            Button6.Enabled = True
        End If
        _WebClient.Dispose()
    End Sub

    Sub writefileinfo(ByVal Dirall As String, ByVal namea As String)
        Label75.Visible = True
        Label75.Text = namea
        Label76.Visible = True
        Label76.Text = Dirall
    End Sub
    Private Sub _DownloadProgressChanged1(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
        ProgressBar1.Visible = True
        ProgressBar1.Value = e.ProgressPercentage
    End Sub
    Sub dl2()
        Dim _WebClient As New System.Net.WebClient
        Dim dlocation, namea, Dirall, T2, weburl As String
        Dim filebool As Boolean = False
        'find where to store file
        If TextBox1.Text = weburl Then
            MessageBox.Show("You are already (downloaded/are downloading) this file. Go to a different page to download another one.")
            Exit Sub
        End If
        weburl = TextBox1.Text
        dlinfo(dlocation, Dirall, namea, weburl, filebool)
        If TextBox2.Text = "" Then
            TextBox2.Text = dlocation
            TextBox9.Text = weburl
        Else
            If TextBox3.Text = "" Then
                TextBox3.Text = dlocation
                TextBox10.Text = weburl
            Else
                If TextBox4.Text = "" Then
                    TextBox4.Text = dlocation
                    TextBox11.Text = weburl
                Else
                    If TextBox5.Text = "" Then
                        TextBox5.Text = dlocation
                        TextBox12.Text = weburl
                    Else
                        If TextBox6.Text = "" Then
                            TextBox6.Text = dlocation
                            TextBox13.Text = weburl
                        Else
                            If TextBox7.Text = "" Then
                                TextBox7.Text = dlocation
                                TextBox14.Text = weburl
                            Else
                                If TextBox8.Text = "" Then
                                    TextBox8.Text = dlocation
                                    TextBox15.Text = weburl
                                Else
                                    MessageBox.Show("Wait for some downloads to finish before trying to add to queue.")
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If ProgressBar1.Value = 100 Or ProgressBar1.Value = 0 Then


            dl()
        Else


        End If



    End Sub
    Sub dlinfo(ByRef dlocation As String, ByRef dirall As String, ByRef namea As String, ByRef weburl As String, ByRef filebool As Boolean)
        Dim objUTF8 As New UTF8Encoding()
        Dim dlindex, dlindex2, dlindex3, nameindex1, nameindex2 As Integer
        Dim _WebClient As New System.Net.WebClient
        Dim Text As String
        heredl(dirall)
       
        'finding dlocation and name of file
        Text = objUTF8.GetString(_WebClient.DownloadData(weburl))
        _WebClient.Dispose()
       
        Try
            dlindex = Text.IndexOf("[link1]")
            dlindex2 = Text.IndexOf("[/link1]")
            dlindex3 = dlindex2 - dlindex
            dlocation = Text.Substring(dlindex + 7, dlindex3 - 7)
            Dim MyRequest As System.Net.HttpWebRequest = DirectCast(System.Net.HttpWebRequest.Create(dlocation), System.Net.HttpWebRequest)
            Dim MyResponse As System.Net.HttpWebResponse = DirectCast(MyRequest.GetResponse(), System.Net.HttpWebResponse)
            MyRequest.Abort()
            MyResponse.Close()
        Catch
            Try
                dlindex = Text.IndexOf("[link2]")
                dlindex2 = Text.IndexOf("[/link2]")
                dlindex3 = dlindex2 - dlindex
                dlocation = Text.Substring(dlindex + 7, dlindex3 - 7)
                Dim MyRequest As System.Net.HttpWebRequest = DirectCast(System.Net.HttpWebRequest.Create(dlocation), System.Net.HttpWebRequest)
                Dim MyResponse As System.Net.HttpWebResponse = DirectCast(MyRequest.GetResponse(), System.Net.HttpWebResponse)
                MyRequest.Abort()
                MyResponse.Close()
            Catch
                Try
                    dlindex = Text.IndexOf("[link3]")
                    dlindex2 = Text.IndexOf("[/link3]")
                    dlindex3 = dlindex2 - dlindex
                    dlocation = Text.Substring(dlindex + 7, dlindex3 - 7)
                    Dim MyRequest As System.Net.HttpWebRequest = DirectCast(System.Net.HttpWebRequest.Create(dlocation), System.Net.HttpWebRequest)
                    Dim MyResponse As System.Net.HttpWebResponse = DirectCast(MyRequest.GetResponse(), System.Net.HttpWebResponse)
                    MyRequest.Abort()
                    MyResponse.Close()
                Catch
                    MessageBox.Show("File Down")
                    filebool = True
                End Try
            End Try
        End Try
        nameindex1 = dlocation.LastIndexOf("/")
        nameindex2 = dlocation.Length - nameindex1
        namea = dlocation.Substring(nameindex1 + 1, nameindex2 - 1)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
    'First declare a Size object
    Dim LastSize As Size

    Private Sub Form1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.Width > LastSize.Width Then
            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is Button Or TypeOf Ctrl Is TextBox Then
                Else
                    Ctrl.Width += (Me.Width - LastSize.Width)
                End If
            Next
        End If
        If Me.Width < LastSize.Width Then
            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is Button Or TypeOf Ctrl Is TextBox Then
                Else
                    Ctrl.Width -= (LastSize.Width - Me.Width)
                End If
            Next
        End If
        If Me.Height > LastSize.Height Then
            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is Button Or TypeOf Ctrl Is TextBox Then
                Else
                    Ctrl.Height += (Me.Height - LastSize.Height)
                End If
            Next
        End If
        If Me.Height < LastSize.Height Then
            For Each Ctrl As Control In Me.Controls
                If TypeOf Ctrl Is Button Or TypeOf Ctrl Is TextBox Then
                Else
                    Ctrl.Height -= (LastSize.Height - Me.Height)
                End If
            Next
        End If
        LastSize = Me.Size
    End Sub


End Class
