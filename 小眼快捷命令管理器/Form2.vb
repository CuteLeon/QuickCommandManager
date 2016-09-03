Imports Microsoft.Win32

Public Class Form2
    Dim HKLM As RegistryKey = Registry.LocalMachine
    Dim MainKey As RegistryKey
    Dim SubKey As RegistryKey
    Public LastCommand As String

    Private Sub Form2_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox2.Text = "" : LastCommand = ""
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AcceptButton = Button2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        File1.ShowDialog()
        TextBox2.Text = File1.FileName
        '从快捷方式读取真正的程序路径
        If UCase(Strings.Right(TextBox2.Text, 4)) = ".LNK" Then
            Dim Shell As New IWshRuntimeLibrary.WshShell()
            Dim ShortCut As IWshRuntimeLibrary.IWshShortcut = DirectCast(Shell.CreateShortcut(TextBox2.Text), IWshRuntimeLibrary.IWshShortcut)
            TextBox2.Text = ShortCut.TargetPath
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'On Error GoTo MyERR
        If InStr(TextBox1.Text, " ") > 0 Then MsgBox("Commands Are Not Allowed To Contain Spaces.", MsgBoxStyle.Exclamation, "ERROR:") : TextBox1.Focus() : TextBox1.SelectAll() : Exit Sub
        If TextBox1.Text = "" Then MsgBox("The Command Is Empty.", MsgBoxStyle.Exclamation, "ERROR:") : TextBox1.Focus() : Exit Sub
        If LCase(Strings.Right(TextBox1.Text, 4)) <> ".exe" Then TextBox1.Text += ".exe"
        'If Trim(TextBox3.Text) <> "" And Dir(Trim(TextBox3.Text), FileAttribute.Hidden + FileAttribute.Normal + FileAttribute.ReadOnly + FileAttribute.System) <> "" Then TextBox3.Text = "" : TextBox3.Focus() : MsgBox("Program File Does Not Exist.", MsgBoxStyle.Exclamation, "ERROR:")

        MainKey = HKLM.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", True)
        '编辑模式下先删除原键
        If Me.Text = "Edit The Quick Command :" Then MainKey.DeleteSubKey(Trim(LastCommand))

        SubKey = MainKey.CreateSubKey(TextBox1.Text)
        SubKey.SetValue("", TextBox2.Text)
        SubKey.SetValue("Path", Strings.Left(Trim(TextBox2.Text), InStrRev(Trim(TextBox2.Text), "\")))

        MsgBox("Quick Command Added successfully.", MsgBoxStyle.Information, "Task Finish:")
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox2.Text = "" : LastCommand = ""
        Me.Hide()
        Form1.刷新RToolStripMenuItem_Click(sender, e)

        Exit Sub
MyERR:
        MsgBox("Error Number:" & Err.Number & vbCrLf & "Error Description " & Err.Description, MsgBoxStyle.Exclamation, "ERROR:")
        Form1.刷新RToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox2.Text = "" : LastCommand = ""
        Me.Hide()
        Form1.Focus()
    End Sub
End Class