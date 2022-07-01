<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BetterMe
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BetterMe))
        Me.NewQuest = New System.Windows.Forms.Button()
        Me.AddQuest = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewQuest
        '
        Me.NewQuest.BackColor = System.Drawing.Color.Teal
        Me.NewQuest.BackgroundImage = CType(resources.GetObject("NewQuest.BackgroundImage"), System.Drawing.Image)
        Me.NewQuest.FlatAppearance.BorderSize = 0
        Me.NewQuest.Font = New System.Drawing.Font("Helvetica Neue", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.NewQuest.ForeColor = System.Drawing.Color.Green
        Me.NewQuest.Location = New System.Drawing.Point(25, 89)
        Me.NewQuest.Name = "NewQuest"
        Me.NewQuest.Size = New System.Drawing.Size(252, 69)
        Me.NewQuest.TabIndex = 0
        Me.NewQuest.UseVisualStyleBackColor = False
        '
        'AddQuest
        '
        Me.AddQuest.BackColor = System.Drawing.Color.Teal
        Me.AddQuest.BackgroundImage = CType(resources.GetObject("AddQuest.BackgroundImage"), System.Drawing.Image)
        Me.AddQuest.FlatAppearance.BorderSize = 0
        Me.AddQuest.Font = New System.Drawing.Font("Helvetica Neue", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AddQuest.ForeColor = System.Drawing.Color.Green
        Me.AddQuest.Location = New System.Drawing.Point(97, 164)
        Me.AddQuest.Name = "AddQuest"
        Me.AddQuest.Size = New System.Drawing.Size(114, 27)
        Me.AddQuest.TabIndex = 1
        Me.AddQuest.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Helvetica Neue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(178, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(82, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 20)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BetterMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(302, 279)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddQuest)
        Me.Controls.Add(Me.NewQuest)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Helvetica Neue", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BetterMe"
        Me.Text = "BetterMe"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewQuest As Button
    Friend WithEvents AddQuest As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
