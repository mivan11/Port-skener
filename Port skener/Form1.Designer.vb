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
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tekst1 = New System.Windows.Forms.TextBox()
        Me.tekst2 = New System.Windows.Forms.TextBox()
        Me.Lista2 = New System.Windows.Forms.ListBox()
        Me.start = New System.Windows.Forms.Button()
        Me.stani = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.osvjezi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(17, 149)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(400, 134)
        Me.Lista.TabIndex = 0
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(42, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP adresa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(43, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
        '
        'tekst1
        '
        Me.tekst1.Location = New System.Drawing.Point(121, 23)
        Me.tekst1.Name = "tekst1"
        Me.tekst1.Size = New System.Drawing.Size(100, 20)
        Me.tekst1.TabIndex = 3
        '
        'tekst2
        '
        Me.tekst2.Location = New System.Drawing.Point(121, 56)
        Me.tekst2.Name = "tekst2"
        Me.tekst2.Size = New System.Drawing.Size(100, 20)
        Me.tekst2.TabIndex = 4
        '
        'Lista2
        '
        Me.Lista2.FormattingEnabled = True
        Me.Lista2.Location = New System.Drawing.Point(19, 316)
        Me.Lista2.Name = "Lista2"
        Me.Lista2.Size = New System.Drawing.Size(396, 82)
        Me.Lista2.TabIndex = 5
        '
        'start
        '
        Me.start.Location = New System.Drawing.Point(296, 12)
        Me.start.Name = "start"
        Me.start.Size = New System.Drawing.Size(75, 23)
        Me.start.TabIndex = 6
        Me.start.Text = "Start"
        Me.start.UseVisualStyleBackColor = True
        '
        'stani
        '
        Me.stani.Location = New System.Drawing.Point(296, 49)
        Me.stani.Name = "stani"
        Me.stani.Size = New System.Drawing.Size(75, 23)
        Me.stani.TabIndex = 7
        Me.stani.Text = "Stop"
        Me.stani.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Otvoreni portovi"
        '
        'osvjezi
        '
        Me.osvjezi.Location = New System.Drawing.Point(296, 87)
        Me.osvjezi.Name = "osvjezi"
        Me.osvjezi.Size = New System.Drawing.Size(75, 23)
        Me.osvjezi.TabIndex = 9
        Me.osvjezi.Text = "Osvježi"
        Me.osvjezi.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RosyBrown
        Me.ClientSize = New System.Drawing.Size(436, 441)
        Me.Controls.Add(Me.osvjezi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.stani)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.Lista2)
        Me.Controls.Add(Me.tekst2)
        Me.Controls.Add(Me.tekst1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lista)
        Me.Name = "Form1"
        Me.Text = "Port skener"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lista As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tekst1 As TextBox
    Friend WithEvents tekst2 As TextBox
    Friend WithEvents Lista2 As ListBox
    Friend WithEvents start As Button
    Friend WithEvents stani As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents osvjezi As Button
End Class
