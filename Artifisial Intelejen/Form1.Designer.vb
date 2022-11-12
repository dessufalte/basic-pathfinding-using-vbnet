<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.subj = New System.Windows.Forms.PictureBox()
        Me.objc = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Disapears = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flags = New System.Windows.Forms.Label()
        Me.listx = New System.Windows.Forms.ListBox()
        Me.listy = New System.Windows.Forms.ListBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.xtr = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.ytr = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.subj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Disapears, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'subj
        '
        Me.subj.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.subj.Location = New System.Drawing.Point(276, 243)
        Me.subj.Name = "subj"
        Me.subj.Size = New System.Drawing.Size(49, 42)
        Me.subj.TabIndex = 0
        Me.subj.TabStop = False
        '
        'objc
        '
        Me.objc.BackColor = System.Drawing.Color.Maroon
        Me.objc.Location = New System.Drawing.Point(91, 64)
        Me.objc.Name = "objc"
        Me.objc.Size = New System.Drawing.Size(49, 42)
        Me.objc.TabIndex = 1
        Me.objc.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Disapears
        '
        Me.Disapears.BackColor = System.Drawing.Color.Transparent
        Me.Disapears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Disapears.Location = New System.Drawing.Point(156, 127)
        Me.Disapears.Name = "Disapears"
        Me.Disapears.Size = New System.Drawing.Size(81, 180)
        Me.Disapears.TabIndex = 2
        Me.Disapears.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Percobaan ke : "
        '
        'flags
        '
        Me.flags.AutoSize = True
        Me.flags.Location = New System.Drawing.Point(135, 9)
        Me.flags.Name = "flags"
        Me.flags.Size = New System.Drawing.Size(13, 13)
        Me.flags.TabIndex = 4
        Me.flags.Text = "0"
        '
        'listx
        '
        Me.listx.FormattingEnabled = True
        Me.listx.Location = New System.Drawing.Point(449, 9)
        Me.listx.Name = "listx"
        Me.listx.Size = New System.Drawing.Size(40, 121)
        Me.listx.TabIndex = 5
        '
        'listy
        '
        Me.listy.FormattingEnabled = True
        Me.listy.Location = New System.Drawing.Point(491, 9)
        Me.listy.Name = "listy"
        Me.listy.Size = New System.Drawing.Size(40, 121)
        Me.listy.TabIndex = 6
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "xtr: "
        '
        'xtr
        '
        Me.xtr.AutoSize = True
        Me.xtr.Location = New System.Drawing.Point(42, 415)
        Me.xtr.Name = "xtr"
        Me.xtr.Size = New System.Drawing.Size(24, 13)
        Me.xtr.TabIndex = 9
        Me.xtr.Text = "xtr: "
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(88, 415)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(24, 13)
        Me.label3.TabIndex = 10
        Me.label3.Text = "ytr :"
        '
        'ytr
        '
        Me.ytr.AutoSize = True
        Me.ytr.Location = New System.Drawing.Point(118, 415)
        Me.ytr.Name = "ytr"
        Me.ytr.Size = New System.Drawing.Size(24, 13)
        Me.ytr.TabIndex = 11
        Me.ytr.Text = "xtr: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 389)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Repeat"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 437)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ytr)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.xtr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listy)
        Me.Controls.Add(Me.listx)
        Me.Controls.Add(Me.flags)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.objc)
        Me.Controls.Add(Me.subj)
        Me.Controls.Add(Me.Disapears)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.subj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Disapears, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents subj As System.Windows.Forms.PictureBox
    Friend WithEvents objc As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Disapears As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents flags As System.Windows.Forms.Label
    Friend WithEvents listx As System.Windows.Forms.ListBox
    Friend WithEvents listy As System.Windows.Forms.ListBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents xtr As System.Windows.Forms.Label
    Friend WithEvents label3 As System.Windows.Forms.Label
    Friend WithEvents ytr As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
