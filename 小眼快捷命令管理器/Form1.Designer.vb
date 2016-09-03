<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Command = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EXEPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.State = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.添加AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.编辑EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除DToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.刷新RToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.全选SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.反选NToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除无效CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Command, Me.EXEPath, Me.State})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.Black
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 25)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(754, 449)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Command
        '
        Me.Command.Text = "Command"
        Me.Command.Width = 150
        '
        'EXEPath
        '
        Me.EXEPath.Text = "EXE Path"
        Me.EXEPath.Width = 500
        '
        'State
        '
        Me.State.Text = "State"
        Me.State.Width = 100
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.添加AToolStripMenuItem, Me.编辑EToolStripMenuItem, Me.删除DToolStripMenuItem, Me.刷新RToolStripMenuItem, Me.全选SToolStripMenuItem, Me.反选NToolStripMenuItem, Me.清除无效CToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(754, 25)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '添加AToolStripMenuItem
        '
        Me.添加AToolStripMenuItem.Name = "添加AToolStripMenuItem"
        Me.添加AToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.添加AToolStripMenuItem.Text = "&Add"
        '
        '编辑EToolStripMenuItem
        '
        Me.编辑EToolStripMenuItem.Name = "编辑EToolStripMenuItem"
        Me.编辑EToolStripMenuItem.Size = New System.Drawing.Size(42, 21)
        Me.编辑EToolStripMenuItem.Text = "&Edit"
        '
        '删除DToolStripMenuItem
        '
        Me.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem"
        Me.删除DToolStripMenuItem.Size = New System.Drawing.Size(57, 21)
        Me.删除DToolStripMenuItem.Text = "&Delete"
        '
        '刷新RToolStripMenuItem
        '
        Me.刷新RToolStripMenuItem.Name = "刷新RToolStripMenuItem"
        Me.刷新RToolStripMenuItem.Size = New System.Drawing.Size(64, 21)
        Me.刷新RToolStripMenuItem.Text = "&Refresh"
        '
        '全选SToolStripMenuItem
        '
        Me.全选SToolStripMenuItem.Name = "全选SToolStripMenuItem"
        Me.全选SToolStripMenuItem.Size = New System.Drawing.Size(72, 21)
        Me.全选SToolStripMenuItem.Text = "&Select All"
        '
        '反选NToolStripMenuItem
        '
        Me.反选NToolStripMenuItem.Name = "反选NToolStripMenuItem"
        Me.反选NToolStripMenuItem.Size = New System.Drawing.Size(91, 21)
        Me.反选NToolStripMenuItem.Text = "&Select Invert"
        '
        '清除无效CToolStripMenuItem
        '
        Me.清除无效CToolStripMenuItem.Name = "清除无效CToolStripMenuItem"
        Me.清除无效CToolStripMenuItem.Size = New System.Drawing.Size(94, 21)
        Me.清除无效CToolStripMenuItem.Text = "&Clean Invalid"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 474)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XiaoYan Quick Command Manager" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Command As System.Windows.Forms.ColumnHeader
    Friend WithEvents EXEPath As System.Windows.Forms.ColumnHeader
    Friend WithEvents State As System.Windows.Forms.ColumnHeader
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 添加AToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除DToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 刷新RToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全选SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 反选NToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清除无效CToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
