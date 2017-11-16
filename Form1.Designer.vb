<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoggoForm
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Dog = New System.Windows.Forms.PictureBox()
        CType(Me.Dog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Dog
        '
        Me.Dog.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dog.Image = Global.Doggo.My.Resources.Resources.Dog_Idle_2
        Me.Dog.Location = New System.Drawing.Point(0, 0)
        Me.Dog.Name = "Dog"
        Me.Dog.Size = New System.Drawing.Size(64, 64)
        Me.Dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Dog.TabIndex = 0
        Me.Dog.TabStop = False
        '
        'DoggoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Dog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "DoggoForm"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.Dog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dog As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Doggo As System.Windows.Forms.ImageList

End Class
