<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FormatCB = New System.Windows.Forms.ComboBox()
        Me.TextColorCB = New System.Windows.Forms.ComboBox()
        Me.BackColorCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CopyCodeBtn = New System.Windows.Forms.Button()
        Me.TextToCopy = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FormatCB
        '
        Me.FormatCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.FormatCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.FormatCB.FormattingEnabled = True
        Me.FormatCB.Items.AddRange(New Object() {"0: Normal", "1: Bold", "4: Underline"})
        Me.FormatCB.Location = New System.Drawing.Point(12, 27)
        Me.FormatCB.Name = "FormatCB"
        Me.FormatCB.Size = New System.Drawing.Size(121, 23)
        Me.FormatCB.TabIndex = 1
        Me.FormatCB.Text = "0: Normal"
        '
        'TextColorCB
        '
        Me.TextColorCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextColorCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TextColorCB.FormattingEnabled = True
        Me.TextColorCB.Items.AddRange(New Object() {"30: Gray", "31: Red", "32: Green", "33: Yellow", "34: Blue", "35: Pink", "36: Cyan", "37: White"})
        Me.TextColorCB.Location = New System.Drawing.Point(139, 27)
        Me.TextColorCB.Name = "TextColorCB"
        Me.TextColorCB.Size = New System.Drawing.Size(121, 23)
        Me.TextColorCB.TabIndex = 1
        Me.TextColorCB.Text = "37: White"
        '
        'BackColorCB
        '
        Me.BackColorCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BackColorCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BackColorCB.FormattingEnabled = True
        Me.BackColorCB.Items.AddRange(New Object() {"Clear Back Ground", "40: Dark Blue", "41: Orange", "42: Gray", "43: Light gray", "44: Even lighter Gray", "45: Indigo", "46: Dark Gray", "47: White"})
        Me.BackColorCB.Location = New System.Drawing.Point(266, 27)
        Me.BackColorCB.Name = "BackColorCB"
        Me.BackColorCB.Size = New System.Drawing.Size(121, 23)
        Me.BackColorCB.TabIndex = 1
        Me.BackColorCB.Text = "40: Dark Blue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Format"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Text Color"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(266, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Back Color"
        '
        'CopyCodeBtn
        '
        Me.CopyCodeBtn.Location = New System.Drawing.Point(393, 27)
        Me.CopyCodeBtn.Name = "CopyCodeBtn"
        Me.CopyCodeBtn.Size = New System.Drawing.Size(82, 23)
        Me.CopyCodeBtn.TabIndex = 3
        Me.CopyCodeBtn.Text = "Copy Code"
        Me.CopyCodeBtn.UseVisualStyleBackColor = True
        '
        'TextToCopy
        '
        Me.TextToCopy.BackColor = System.Drawing.Color.SeaShell
        Me.TextToCopy.Location = New System.Drawing.Point(12, 99)
        Me.TextToCopy.Name = "TextToCopy"
        Me.TextToCopy.ReadOnly = True
        Me.TextToCopy.Size = New System.Drawing.Size(187, 23)
        Me.TextToCopy.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Copy Text"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(291, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 75)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Make sure the code block is ansi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "```ansi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[0;31;40mText Goes Here[0m" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "```"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 153)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextToCopy)
        Me.Controls.Add(Me.CopyCodeBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackColorCB)
        Me.Controls.Add(Me.TextColorCB)
        Me.Controls.Add(Me.FormatCB)
        Me.Name = "Form1"
        Me.Text = "Ansi Color Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormatCB As ComboBox
    Friend WithEvents TextColorCB As ComboBox
    Friend WithEvents BackColorCB As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CopyCodeBtn As Button
    Friend WithEvents TextToCopy As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
