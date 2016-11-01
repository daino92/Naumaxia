<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form))
        Me.txt = New System.Windows.Forms.TextBox
        Me.SHIPS = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.hit = New System.Windows.Forms.Label
        Me.miss = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.b2 = New System.Windows.Forms.Button
        Me.b3 = New System.Windows.Forms.Button
        Me.b4 = New System.Windows.Forms.Button
        Me.b1 = New System.Windows.Forms.Button
        Me.b5 = New System.Windows.Forms.Button
        Me.b8 = New System.Windows.Forms.Button
        Me.b7 = New System.Windows.Forms.Button
        Me.b6 = New System.Windows.Forms.Button
        Me.d5 = New System.Windows.Forms.Button
        Me.d8 = New System.Windows.Forms.Button
        Me.d7 = New System.Windows.Forms.Button
        Me.d6 = New System.Windows.Forms.Button
        Me.d1 = New System.Windows.Forms.Button
        Me.d4 = New System.Windows.Forms.Button
        Me.d3 = New System.Windows.Forms.Button
        Me.d2 = New System.Windows.Forms.Button
        Me.d9 = New System.Windows.Forms.Button
        Me.d12 = New System.Windows.Forms.Button
        Me.d11 = New System.Windows.Forms.Button
        Me.d10 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.Location = New System.Drawing.Point(380, 276)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(66, 20)
        Me.txt.TabIndex = 3
        '
        'SHIPS
        '
        Me.SHIPS.AutoSize = True
        Me.SHIPS.Location = New System.Drawing.Point(377, 260)
        Me.SHIPS.Name = "SHIPS"
        Me.SHIPS.Size = New System.Drawing.Size(73, 13)
        Me.SHIPS.TabIndex = 4
        Me.SHIPS.Text = "SHOTS LEFT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(377, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "POINTS"
        '
        'hit
        '
        Me.hit.AutoSize = True
        Me.hit.Location = New System.Drawing.Point(38, 332)
        Me.hit.Name = "hit"
        Me.hit.Size = New System.Drawing.Size(123, 13)
        Me.hit.TabIndex = 6
        Me.hit.Text = "Μπράβο πέτυχες πλοίο!"
        Me.hit.Visible = False
        '
        'miss
        '
        Me.miss.AutoSize = True
        Me.miss.Location = New System.Drawing.Point(231, 332)
        Me.miss.Name = "miss"
        Me.miss.Size = New System.Drawing.Size(70, 13)
        Me.miss.TabIndex = 7
        Me.miss.Text = "Αστόχησες!!"
        Me.miss.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(380, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 32)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(368, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Πόσα πλοία θες;"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(328, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Πόσες βολές θες να έχεις;"
        '
        'txt1
        '
        Me.txt1.Enabled = False
        Me.txt1.Location = New System.Drawing.Point(380, 224)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(66, 20)
        Me.txt1.TabIndex = 12
        Me.txt1.Text = "0"
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(385, 19)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(22, 22)
        Me.b2.TabIndex = 17
        Me.b2.Text = "2"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(413, 19)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(22, 22)
        Me.b3.TabIndex = 18
        Me.b3.Text = "3"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(440, 19)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(22, 22)
        Me.b4.TabIndex = 19
        Me.b4.Text = "4"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(359, 19)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(22, 22)
        Me.b1.TabIndex = 21
        Me.b1.Text = "1"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(359, 47)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(22, 22)
        Me.b5.TabIndex = 25
        Me.b5.Text = "5"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Location = New System.Drawing.Point(440, 47)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(22, 22)
        Me.b8.TabIndex = 24
        Me.b8.Text = "8"
        Me.b8.UseVisualStyleBackColor = True
        '
        'b7
        '
        Me.b7.Location = New System.Drawing.Point(413, 47)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(22, 22)
        Me.b7.TabIndex = 23
        Me.b7.Text = "7"
        Me.b7.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(385, 47)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(22, 22)
        Me.b6.TabIndex = 22
        Me.b6.Text = "6"
        Me.b6.UseVisualStyleBackColor = True
        '
        'd5
        '
        Me.d5.Location = New System.Drawing.Point(354, 133)
        Me.d5.Name = "d5"
        Me.d5.Size = New System.Drawing.Size(27, 22)
        Me.d5.TabIndex = 33
        Me.d5.Text = "5"
        Me.d5.UseVisualStyleBackColor = True
        '
        'd8
        '
        Me.d8.Location = New System.Drawing.Point(435, 133)
        Me.d8.Name = "d8"
        Me.d8.Size = New System.Drawing.Size(27, 22)
        Me.d8.TabIndex = 32
        Me.d8.Text = "8"
        Me.d8.UseVisualStyleBackColor = True
        '
        'd7
        '
        Me.d7.Location = New System.Drawing.Point(408, 133)
        Me.d7.Name = "d7"
        Me.d7.Size = New System.Drawing.Size(27, 22)
        Me.d7.TabIndex = 31
        Me.d7.Text = "7"
        Me.d7.UseVisualStyleBackColor = True
        '
        'd6
        '
        Me.d6.Location = New System.Drawing.Point(380, 133)
        Me.d6.Name = "d6"
        Me.d6.Size = New System.Drawing.Size(27, 22)
        Me.d6.TabIndex = 30
        Me.d6.Text = "6"
        Me.d6.UseVisualStyleBackColor = True
        '
        'd1
        '
        Me.d1.Location = New System.Drawing.Point(354, 105)
        Me.d1.Name = "d1"
        Me.d1.Size = New System.Drawing.Size(27, 22)
        Me.d1.TabIndex = 29
        Me.d1.Text = "1"
        Me.d1.UseVisualStyleBackColor = True
        '
        'd4
        '
        Me.d4.Location = New System.Drawing.Point(435, 105)
        Me.d4.Name = "d4"
        Me.d4.Size = New System.Drawing.Size(27, 22)
        Me.d4.TabIndex = 28
        Me.d4.Text = "4"
        Me.d4.UseVisualStyleBackColor = True
        '
        'd3
        '
        Me.d3.Location = New System.Drawing.Point(408, 105)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(27, 22)
        Me.d3.TabIndex = 27
        Me.d3.Text = "3"
        Me.d3.UseVisualStyleBackColor = True
        '
        'd2
        '
        Me.d2.Location = New System.Drawing.Point(380, 105)
        Me.d2.Name = "d2"
        Me.d2.Size = New System.Drawing.Size(27, 22)
        Me.d2.TabIndex = 26
        Me.d2.Text = "2"
        Me.d2.UseVisualStyleBackColor = True
        '
        'd9
        '
        Me.d9.Location = New System.Drawing.Point(354, 161)
        Me.d9.Name = "d9"
        Me.d9.Size = New System.Drawing.Size(27, 22)
        Me.d9.TabIndex = 37
        Me.d9.Text = "9"
        Me.d9.UseVisualStyleBackColor = True
        '
        'd12
        '
        Me.d12.Location = New System.Drawing.Point(435, 161)
        Me.d12.Name = "d12"
        Me.d12.Size = New System.Drawing.Size(27, 22)
        Me.d12.TabIndex = 36
        Me.d12.Text = "12"
        Me.d12.UseVisualStyleBackColor = True
        '
        'd11
        '
        Me.d11.Location = New System.Drawing.Point(408, 161)
        Me.d11.Name = "d11"
        Me.d11.Size = New System.Drawing.Size(27, 22)
        Me.d11.TabIndex = 35
        Me.d11.Text = "11"
        Me.d11.UseVisualStyleBackColor = True
        '
        'd10
        '
        Me.d10.Location = New System.Drawing.Point(380, 161)
        Me.d10.Name = "d10"
        Me.d10.Size = New System.Drawing.Size(27, 22)
        Me.d10.TabIndex = 34
        Me.d10.Text = "10"
        Me.d10.UseVisualStyleBackColor = True
        '
        'form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 380)
        Me.Controls.Add(Me.d9)
        Me.Controls.Add(Me.d12)
        Me.Controls.Add(Me.d11)
        Me.Controls.Add(Me.d10)
        Me.Controls.Add(Me.d5)
        Me.Controls.Add(Me.d8)
        Me.Controls.Add(Me.d7)
        Me.Controls.Add(Me.d6)
        Me.Controls.Add(Me.d1)
        Me.Controls.Add(Me.d4)
        Me.Controls.Add(Me.d3)
        Me.Controls.Add(Me.d2)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.b8)
        Me.Controls.Add(Me.b7)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.miss)
        Me.Controls.Add(Me.hit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SHIPS)
        Me.Controls.Add(Me.txt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "form"
        Me.Text = "Ναυμαχία"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt As System.Windows.Forms.TextBox
    Friend WithEvents SHIPS As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hit As System.Windows.Forms.Label
    Friend WithEvents miss As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents b2 As System.Windows.Forms.Button
    Friend WithEvents b3 As System.Windows.Forms.Button
    Friend WithEvents b4 As System.Windows.Forms.Button
    Friend WithEvents b1 As System.Windows.Forms.Button
    Friend WithEvents b5 As System.Windows.Forms.Button
    Friend WithEvents b8 As System.Windows.Forms.Button
    Friend WithEvents b7 As System.Windows.Forms.Button
    Friend WithEvents b6 As System.Windows.Forms.Button
    Friend WithEvents d5 As System.Windows.Forms.Button
    Friend WithEvents d8 As System.Windows.Forms.Button
    Friend WithEvents d7 As System.Windows.Forms.Button
    Friend WithEvents d6 As System.Windows.Forms.Button
    Friend WithEvents d1 As System.Windows.Forms.Button
    Friend WithEvents d4 As System.Windows.Forms.Button
    Friend WithEvents d3 As System.Windows.Forms.Button
    Friend WithEvents d2 As System.Windows.Forms.Button
    Friend WithEvents d9 As System.Windows.Forms.Button
    Friend WithEvents d12 As System.Windows.Forms.Button
    Friend WithEvents d11 As System.Windows.Forms.Button
    Friend WithEvents d10 As System.Windows.Forms.Button

End Class
