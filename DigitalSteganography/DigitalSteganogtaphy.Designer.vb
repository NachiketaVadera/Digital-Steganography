<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winMain
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
        Me.txtDataInput = New System.Windows.Forms.TextBox()
        Me.btnChooseImage = New System.Windows.Forms.Button()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.pbxImage = New System.Windows.Forms.PictureBox()
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDataInput
        '
        Me.txtDataInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDataInput.Location = New System.Drawing.Point(20, 18)
        Me.txtDataInput.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDataInput.Multiline = True
        Me.txtDataInput.Name = "txtDataInput"
        Me.txtDataInput.Size = New System.Drawing.Size(1008, 66)
        Me.txtDataInput.TabIndex = 0
        '
        'btnChooseImage
        '
        Me.btnChooseImage.Location = New System.Drawing.Point(20, 92)
        Me.btnChooseImage.Name = "btnChooseImage"
        Me.btnChooseImage.Size = New System.Drawing.Size(179, 35)
        Me.btnChooseImage.TabIndex = 2
        Me.btnChooseImage.Text = "Choose an Image"
        Me.btnChooseImage.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExecute.Location = New System.Drawing.Point(946, 92)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(84, 35)
        Me.btnExecute.TabIndex = 3
        Me.btnExecute.Text = "Process"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'pbxImage
        '
        Me.pbxImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxImage.Location = New System.Drawing.Point(20, 133)
        Me.pbxImage.Name = "pbxImage"
        Me.pbxImage.Size = New System.Drawing.Size(1010, 414)
        Me.pbxImage.TabIndex = 4
        Me.pbxImage.TabStop = False
        '
        'winMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 559)
        Me.Controls.Add(Me.pbxImage)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.btnChooseImage)
        Me.Controls.Add(Me.txtDataInput)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "winMain"
        Me.Text = "Digital Steganography"
        CType(Me.pbxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDataInput As TextBox
    Friend WithEvents btnChooseImage As Button
    Friend WithEvents btnExecute As Button
    Friend WithEvents pbxImage As PictureBox
End Class
