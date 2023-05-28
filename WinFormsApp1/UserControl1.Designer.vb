<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Button1 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label3 = New Label()
        Label7 = New Label()
        Label4 = New Label()
        TextBox5 = New TextBox()
        TextBox7 = New TextBox()
        Label2 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        TextBox6 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(660, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(164, 29)
        Button1.TabIndex = 88
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(135, 42)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(215, 27)
        TextBox1.TabIndex = 81
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(135, 73)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(215, 27)
        TextBox2.TabIndex = 82
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(135, 105)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(215, 27)
        TextBox3.TabIndex = 83
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(135, 138)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(215, 27)
        TextBox4.TabIndex = 84
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(7, 67)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 28)
        Label3.TabIndex = 76
        Label3.Text = "LastName"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(7, 204)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 28)
        Label7.TabIndex = 80
        Label7.Text = "Phone#"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(7, 102)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 28)
        Label4.TabIndex = 77
        Label4.Text = "Gender"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(135, 171)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(215, 27)
        TextBox5.TabIndex = 85
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(135, 8)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(215, 27)
        TextBox7.TabIndex = 87
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(7, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 75
        Label2.Text = "First Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(7, 136)
        Label6.Name = "Label6"
        Label6.Size = New Size(122, 28)
        Label6.TabIndex = 79
        Label6.Text = "Date of Birth"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(7, 171)
        Label5.Name = "Label5"
        Label5.Size = New Size(129, 28)
        Label5.TabIndex = 78
        Label5.Text = "Grade Level   "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(7, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 74
        Label1.Text = "StudentID"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(135, 204)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(215, 27)
        TextBox6.TabIndex = 86
        ' 
        ' UserControl1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(TextBox7)
        Controls.Add(Label2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(TextBox6)
        Name = "UserControl1"
        Size = New Size(831, 247)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
End Class
