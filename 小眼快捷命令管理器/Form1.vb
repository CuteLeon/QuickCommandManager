Imports Microsoft.Win32

Public Class Form1
    Dim HKLM As RegistryKey = Registry.LocalMachine
    Dim MainKey As RegistryKey
    Dim SubKey As RegistryKey

    Private Sub ListView1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.SizeChanged
        Command.Width = ListView1.Width \ 5
        EXEPath.Width = ListView1.Width * 2 \ 3
        State.Width = Command.Width * 2 \ 3
    End Sub

    Private Sub 全选SToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 全选SToolStripMenuItem.Click
        If ListView1.CheckedIndices.Count < ListView1.Items.Count Then
            For N As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items.Item(N).Checked = True
            Next
        Else
            For N As Integer = 0 To ListView1.Items.Count - 1
                ListView1.Items.Item(N).Checked = False
            Next
        End If
    End Sub

    Public Sub 刷新RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 刷新RToolStripMenuItem.Click
        Dim I As Integer, DataTemp As String
        MainKey = HKLM.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths")
        ListView1.Items.Clear()
        For I = 0 To UBound(MainKey.GetSubKeyNames)
            SubKey = MainKey.OpenSubKey(MainKey.GetSubKeyNames(I))
            DataTemp = GetEXEPath(CStr(SubKey.GetValue("")))
            With ListView1.Items
                .Add(MainKey.GetSubKeyNames(I))
                .Item(.Count - 1).SubItems.Add(DataTemp)
                If DataTemp <> "" And Dir(DataTemp, FileAttribute.Hidden Or FileAttribute.Normal Or FileAttribute.ReadOnly Or FileAttribute.System) <> "" Then .Item(.Count - 1).SubItems.Add("Available") Else .Item(.Count - 1).SubItems.Add("Invalid") : .Item(.Count - 1).BackColor = Color.Red
            End With
        Next
    End Sub

    Private Function GetEXEPath(ByVal DataStr As String) As String
        Dim DataTemp As String
        DataTemp = Trim(Replace(DataStr, Chr(34), ""))
        If InStr(DataTemp, "%") > 0 Then DataTemp = Environ(Strings.Mid(DataTemp, 2, InStrRev(DataTemp, "%") - 2)) & Strings.Right(DataTemp, Len(DataTemp) - InStrRev(DataTemp, "%"))
        Return DataTemp
    End Function

    Private Sub 反选NToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 反选NToolStripMenuItem.Click
        For N As Integer = 0 To ListView1.Items.Count - 1
            ListView1.Items.Item(N).Checked = Not ListView1.Items.Item(N).Checked
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        刷新RToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub 添加AToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 添加AToolStripMenuItem.Click
        If Form2.Visible = False Then Form2.Text = "Add A New Quick Command :" : Form2.TextBox1.Text() = "" : Form2.TextBox2.Text() = "" : Form2.Show(Me)
    End Sub

    Private Sub 编辑EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 编辑EToolStripMenuItem.Click
        If Form2.Visible = False And ListView1.SelectedItems.Count > 0 Then Form2.Text = "Edit The Quick Command :" : Form2.TextBox1.Text() = ListView1.FocusedItem.Text : Form2.LastCommand = ListView1.FocusedItem.Text : Form2.TextBox2.Text() = ListView1.SelectedItems(0).SubItems(1).Text : Form2.Show(Me)
    End Sub

    Private Sub 删除DToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 删除DToolStripMenuItem.Click
        If ListView1.CheckedItems.Count > 0 Then
            If MsgBox("Are You Sure To Delete This Quick Command ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Are You Sure:") = vbYes Then
                For N As Integer = 0 To ListView1.CheckedItems.Count - 1
                    MainKey = HKLM.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", True)
                    MainKey.DeleteSubKey(ListView1.CheckedItems(N).Text)
                Next
            End If
        End If
        刷新RToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub 清除无效CToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 清除无效CToolStripMenuItem.Click
        If MsgBox("Are You Sure To Clean All Invalid Project ?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Are You Sure :") = vbYes Then
            For N As Integer = 0 To ListView1.Items.Count - 1
                If ListView1.Items.Item(N).SubItems(2).Text = "Invalid" Then
                    MainKey = HKLM.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths", True)
                    MainKey.DeleteSubKey(ListView1.CheckedItems(N).Text)
                End If
            Next
            刷新RToolStripMenuItem_Click(sender, e)
        End If
    End Sub

End Class
