<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Panel1 = New Panel()
        Button1 = New Button()
        Button6 = New Button()
        Button3 = New Button()
        Button7 = New Button()
        enrollbtn = New Button()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        dashPanel = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleGoldenrod
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(enrollbtn)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(323, 608)
        Panel1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(0, 422)
        Button1.Name = "Button1"
        Button1.Size = New Size(323, 43)
        Button1.TabIndex = 51
        Button1.Text = "Enrollment"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(0, 375)
        Button6.Name = "Button6"
        Button6.Size = New Size(323, 43)
        Button6.TabIndex = 50
        Button6.Text = "Add Class"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(0, 329)
        Button3.Name = "Button3"
        Button3.Size = New Size(323, 43)
        Button3.TabIndex = 49
        Button3.Text = "Add Teacher"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(0, 283)
        Button7.Name = "Button7"
        Button7.Size = New Size(323, 43)
        Button7.TabIndex = 48
        Button7.Text = "Add Parent"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' enrollbtn
        ' 
        enrollbtn.Location = New Point(0, 237)
        enrollbtn.Name = "enrollbtn"
        enrollbtn.Size = New Size(323, 43)
        enrollbtn.TabIndex = 42
        enrollbtn.Text = "Add Enrollee"
        enrollbtn.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(62, 210)
        Label8.Name = "Label8"
        Label8.Size = New Size(170, 20)
        Label8.TabIndex = 47
        Label8.Text = "Welcome: Admin124999"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(62, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(194, 191)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dashPanel
        ' 
        dashPanel.BackColor = SystemColors.Menu
        dashPanel.Location = New Point(345, 15)
        dashPanel.Name = "dashPanel"
        dashPanel.Size = New Size(964, 442)
        dashPanel.TabIndex = 21
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1322, 632)
        Controls.Add(dashPanel)
        Controls.Add(Panel1)
        Name = "Form2"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dashPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents enrollbtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Addenrollee1 As Addenrollee
End Class
