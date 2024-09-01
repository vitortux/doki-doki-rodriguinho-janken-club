<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Screen2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Screen2))
        Me.btnPedra = New System.Windows.Forms.Button()
        Me.btnPapel = New System.Windows.Forms.Button()
        Me.btnTesoura = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPedra
        '
        Me.btnPedra.BackColor = System.Drawing.Color.Transparent
        Me.btnPedra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPedra.FlatAppearance.BorderSize = 0
        Me.btnPedra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPedra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedra.Location = New System.Drawing.Point(429, 188)
        Me.btnPedra.Name = "btnPedra"
        Me.btnPedra.Size = New System.Drawing.Size(422, 42)
        Me.btnPedra.TabIndex = 0
        Me.btnPedra.UseVisualStyleBackColor = False
        '
        'btnPapel
        '
        Me.btnPapel.BackColor = System.Drawing.Color.Transparent
        Me.btnPapel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPapel.FlatAppearance.BorderSize = 0
        Me.btnPapel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnPapel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnPapel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPapel.Location = New System.Drawing.Point(429, 249)
        Me.btnPapel.Name = "btnPapel"
        Me.btnPapel.Size = New System.Drawing.Size(422, 42)
        Me.btnPapel.TabIndex = 1
        Me.btnPapel.UseVisualStyleBackColor = False
        '
        'btnTesoura
        '
        Me.btnTesoura.BackColor = System.Drawing.Color.Transparent
        Me.btnTesoura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTesoura.FlatAppearance.BorderSize = 0
        Me.btnTesoura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnTesoura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnTesoura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTesoura.Location = New System.Drawing.Point(429, 311)
        Me.btnTesoura.Name = "btnTesoura"
        Me.btnTesoura.Size = New System.Drawing.Size(422, 42)
        Me.btnTesoura.TabIndex = 2
        Me.btnTesoura.UseVisualStyleBackColor = False
        '
        'Screen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.screen2vc
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1264, 719)
        Me.Controls.Add(Me.btnTesoura)
        Me.Controls.Add(Me.btnPapel)
        Me.Controls.Add(Me.btnPedra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Screen2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doki Doki Rodriguinho Janken Club"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPedra As System.Windows.Forms.Button
    Friend WithEvents btnPapel As System.Windows.Forms.Button
    Friend WithEvents btnTesoura As System.Windows.Forms.Button
End Class
