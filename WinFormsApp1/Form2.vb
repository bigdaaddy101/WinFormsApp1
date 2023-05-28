Public Class Form2
    Private Shared instance As Form2

    Public Sub New()

        If instance IsNot Nothing Then

            Return
        End If

        InitializeComponent()


        instance = Me
    End Sub

    Private Sub enrollbtn_Click(sender As Object, e As EventArgs) Handles enrollbtn.Click
        Try
            Dim userControlInstance As New Addenrollee()

            With userControlInstance
                .TopLevel = False
                instance.dashPanel.Controls.Clear() ' Clear any existing controls from previous forms
                instance.dashPanel.Controls.Add(userControlInstance)
                .Dock = DockStyle.Fill ' Fill the entire dashPanel with the requestForm
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show("Error opening requestForm: " & ex.Message)
        End Try
    End Sub



End Class