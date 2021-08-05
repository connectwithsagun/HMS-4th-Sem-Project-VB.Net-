<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Help
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Form1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest Registration")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest Record Manupulation")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest Checkout")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest Detail", New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Total Room")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Available Room")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Occupied Room")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Room Detail", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Employee")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("update employee")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("delete employee")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saalary Setup")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Detail", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest Billing Report")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Guest Report")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Record")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Employee Salary Report")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Backup and Recovery")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logout")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add User")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Setting", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("mdi form", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode9, TreeNode14, TreeNode19, TreeNode20, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Hotel Management System", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode24})
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(299, 509)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeView1.ForeColor = System.Drawing.Color.Black
        Me.TreeView1.LineColor = System.Drawing.Color.Gray
        Me.TreeView1.Location = New System.Drawing.Point(9, 34)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "Form1"
        TreeNode2.Name = "Node10"
        TreeNode2.Text = "Guest Registration"
        TreeNode3.Name = "Node11"
        TreeNode3.Text = "Guest Record Manupulation"
        TreeNode4.Name = "Node12"
        TreeNode4.Text = "Guest Checkout"
        TreeNode5.Name = "Node4"
        TreeNode5.Text = "Guest Detail"
        TreeNode6.Name = "Node13"
        TreeNode6.Text = "Total Room"
        TreeNode7.Name = "Node14"
        TreeNode7.Text = "Available Room"
        TreeNode8.Name = "Node15"
        TreeNode8.Text = "Occupied Room"
        TreeNode9.Name = "Node5"
        TreeNode9.Text = "Room Detail"
        TreeNode10.Name = "Node16"
        TreeNode10.Text = "Add Employee"
        TreeNode11.Name = "Node17"
        TreeNode11.Text = "update employee"
        TreeNode12.Name = "Node18"
        TreeNode12.Text = "delete employee"
        TreeNode13.Name = "Node19"
        TreeNode13.Text = "Saalary Setup"
        TreeNode14.Name = "Node6"
        TreeNode14.Text = "Employee Detail"
        TreeNode15.Name = "Node20"
        TreeNode15.Text = "Guest Billing Report"
        TreeNode16.Name = "Node21"
        TreeNode16.Text = "Guest Report"
        TreeNode17.Name = "Node22"
        TreeNode17.Text = "Employee Record"
        TreeNode18.Name = "Node23"
        TreeNode18.Text = "Employee Salary Report"
        TreeNode19.Name = "Node7"
        TreeNode19.Text = "Report"
        TreeNode20.Name = "Node24"
        TreeNode20.Text = "Backup and Recovery"
        TreeNode21.Name = "Node25"
        TreeNode21.Text = "Logout"
        TreeNode22.Name = "Node26"
        TreeNode22.Text = "Add User"
        TreeNode23.Name = "Node9"
        TreeNode23.Text = "Setting"
        TreeNode24.Name = "Node3"
        TreeNode24.Text = "mdi form"
        TreeNode25.Name = "Node1"
        TreeNode25.Text = "Hotel Management System"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode25})
        Me.TreeView1.Size = New System.Drawing.Size(276, 432)
        Me.TreeView1.TabIndex = 1
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RichTextBox1.Location = New System.Drawing.Point(372, 34)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(299, 432)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 509)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Splitter1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Help"
        Me.Text = "Help"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
