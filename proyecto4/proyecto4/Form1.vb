Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles botonMas.Click

        Dim Numero1 As Integer = Integer.Parse(Me.num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.num2.Text)

        Dim resultado As Integer = Numero1 + Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botonMenos.Click
        Dim Numero1 As Integer = Integer.Parse(Me.num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.num2.Text)

        Dim resultado As Integer = Numero1 - Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles botonPor.Click
        Dim Numero1 As Integer = Integer.Parse(Me.num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.num2.Text)

        Dim resultado As Integer = Numero1 * Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles botonEntre.Click
        Dim Numero1 As Integer = Integer.Parse(Me.num1.Text)
        Dim Numero2 As Integer = Integer.Parse(Me.num2.Text)

        Dim resultado As Integer = Numero1 / Numero2

        Label4.Text = resultado.ToString()
    End Sub

    Private Sub boton0_Click(sender As Object, e As EventArgs) Handles boton0.Click
        num1.Text = num1.Text & "0"
    End Sub

    Private Sub boton1_Click(sender As Object, e As EventArgs) Handles boton1.Click
        num1.Text = num1.Text & "1"
    End Sub

    Private Sub boton2_Click(sender As Object, e As EventArgs) Handles boton2.Click
        num1.Text = num1.Text & "2"
    End Sub

    Private Sub boton3_Click(sender As Object, e As EventArgs) Handles boton3.Click
        num1.Text = num1.Text & "3"
    End Sub

    Private Sub boton4_Click(sender As Object, e As EventArgs) Handles boton4.Click
        num1.Text = num1.Text & "4"
    End Sub

    Private Sub boton5_Click(sender As Object, e As EventArgs) Handles boton5.Click
        num1.Text = num1.Text & "5"
    End Sub

    Private Sub boton6_Click(sender As Object, e As EventArgs) Handles boton6.Click
        num1.Text = num1.Text & "6"
    End Sub

    Private Sub boton7_Click(sender As Object, e As EventArgs) Handles boton7.Click
        num1.Text = num1.Text & "7"
    End Sub

    Private Sub boton8_Click(sender As Object, e As EventArgs) Handles boton8.Click
        num1.Text = num1.Text & "8"
    End Sub

    Private Sub boton9_Click(sender As Object, e As EventArgs) Handles boton9.Click
        num1.Text = num1.Text & "9"
    End Sub

    Private Sub botonBorrar_Click(sender As Object, e As EventArgs) Handles botonBorrar.Click
        num1.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
