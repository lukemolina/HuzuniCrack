<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnHosts = New System.Windows.Forms.Button()
        Me.btnAdduser = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblHosts = New System.Windows.Forms.Label()
        Me.llblHackforums = New System.Windows.Forms.LinkLabel()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'btnHosts
        '
        Me.btnHosts.Location = New System.Drawing.Point(14, 55)
        Me.btnHosts.Name = "btnHosts"
        Me.btnHosts.Size = New System.Drawing.Size(120, 23)
        Me.btnHosts.TabIndex = 0
        Me.btnHosts.Text = "Patch The Hosts File"
        Me.btnHosts.UseVisualStyleBackColor = True
        '
        'btnAdduser
        '
        Me.btnAdduser.Location = New System.Drawing.Point(140, 55)
        Me.btnAdduser.Name = "btnAdduser"
        Me.btnAdduser.Size = New System.Drawing.Size(75, 23)
        Me.btnAdduser.TabIndex = 1
        Me.btnAdduser.Text = "Become VIP"
        Me.btnAdduser.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(14, 29)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(201, 20)
        Me.txtUsername.TabIndex = 2
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(41, 9)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(147, 13)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Put Your MC Username Here:"
        '
        'lblHosts
        '
        Me.lblHosts.AutoSize = True
        Me.lblHosts.Location = New System.Drawing.Point(23, 81)
        Me.lblHosts.Name = "lblHosts"
        Me.lblHosts.Size = New System.Drawing.Size(183, 26)
        Me.lblHosts.TabIndex = 4
        Me.lblHosts.Text = "You may have to restart your PC after" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "patching the Hosts File."
        Me.lblHosts.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'llblHackforums
        '
        Me.llblHackforums.AutoSize = True
        Me.llblHackforums.Location = New System.Drawing.Point(49, 110)
        Me.llblHackforums.Name = "llblHackforums"
        Me.llblHackforums.Size = New System.Drawing.Size(131, 13)
        Me.llblHackforums.TabIndex = 5
        Me.llblHackforums.TabStop = True
        Me.llblHackforums.Text = "Created By Vanadiumz HF"
        '
        'WebBrowser
        '
        Me.WebBrowser.Location = New System.Drawing.Point(189, 99)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(27, 24)
        Me.WebBrowser.TabIndex = 6
        Me.WebBrowser.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(228, 129)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.llblHackforums)
        Me.Controls.Add(Me.lblHosts)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnAdduser)
        Me.Controls.Add(Me.btnHosts)
        Me.Name = "frmMain"
        Me.Text = "HuzuniCrack"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHosts As System.Windows.Forms.Button
    Friend WithEvents btnAdduser As System.Windows.Forms.Button
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblHosts As System.Windows.Forms.Label
    Friend WithEvents llblHackforums As System.Windows.Forms.LinkLabel
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser

End Class
