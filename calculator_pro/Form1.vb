Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "0"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "0"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "1"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "1"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "2"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "2"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "3"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "3"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "4"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "4"
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        'Me.display_Label1.Text = Me.display_Label1.Text + "5"
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "5"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "5"
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'Me.display_Label1.Text = Me.display_Label1.Text + "6"
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "6"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "6"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'Me.display_Label1.Text = Me.display_Label1.Text + "7"
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "7"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "7"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        'Me.display_Label1.Text = Me.display_Label1.Text + "8"
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "8"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "8"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'Me.display_Label1.Text = Me.display_Label1.Text + "9"
        If (Me.display_Label1.Text = "0") Then
            Me.display_Label1.Text = "9"
        Else
            Me.display_Label1.Text = Me.display_Label1.Text + "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'Me.display_Label1.Text = ""
        Me.display_Label1.ResetText()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.operator_Label1.Text = "+"

        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        Me.display_Label1.Text = ""

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.operator_Label1.Text = "-"

        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        Me.display_Label1.Text = ""
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.operator_Label1.Text = "x"

        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        Me.display_Label1.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.operator_Label1.Text = "%"

        If (Me.display_Label1.Text = "") Then
        Else
            Me.first_num_Label2.Text = Me.display_Label1.Text
        End If
        Me.display_Label1.Text = ""
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim fn As Double
        Dim sn As Double
        Dim rn As Double
        Dim op As String

        Double.TryParse(Me.first_num_Label2.Text, fn)
        Double.TryParse(Me.display_Label1.Text, sn)

        op = Me.operator_Label1.Text

        Select Case op
            Case "+"
                rn = fn + sn
            Case "-"
                rn = fn - sn
            Case "x"
                rn = fn * sn
            Case "%"
                rn = fn / sn
            Case Else
        End Select

        Me.display_Label1.Text = rn.ToString()
        Me.first_num_Label2.ResetText()
        Me.operator_Label1.ResetText()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.display_Label1.Text += "."
    End Sub
End Class
