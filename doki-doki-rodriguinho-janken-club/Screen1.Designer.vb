<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screen1))
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNope = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.Transparent
        Me.btnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYes.FlatAppearance.BorderSize = 0
        Me.btnYes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYes.ForeColor = System.Drawing.Color.Transparent
        Me.btnYes.Location = New System.Drawing.Point(527, 366)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(72, 49)
        Me.btnYes.TabIndex = 0
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'btnNope
        '
        Me.btnNope.BackColor = System.Drawing.Color.Transparent
        Me.btnNope.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNope.FlatAppearance.BorderSize = 0
        Me.btnNope.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNope.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNope.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNope.ForeColor = System.Drawing.Color.Transparent
        Me.btnNope.Location = New System.Drawing.Point(667, 366)
        Me.btnNope.Name = "btnNope"
        Me.btnNope.Size = New System.Drawing.Size(87, 49)
        Me.btnNope.TabIndex = 1
        Me.btnNope.UseVisualStyleBackColor = False
        '
        'Screen1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.screen1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1264, 719)
        Me.Controls.Add(Me.btnNope)
        Me.Controls.Add(Me.btnYes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Screen1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doki Doki Rodriguinho Janken Club"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnYes As System.Windows.Forms.Button
    Friend WithEvents btnNope As System.Windows.Forms.Button

End Class
