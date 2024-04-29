
Public Class Form1
    Public Global1 As ClaseJSON = New ClaseJSON
    Public Global2 As ClaseJSON = New ClaseJSON

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Clases As List(Of ClaseJSON) = FuncionesJSON.ReadJSON()

        Global1 = Clases(0)

        Global2 = Clases(1)

        Cl1_Par1.Text = Global1.campo1
        Cl2_Par1.Text = Global2.campo1

        Cl1_Par2.Text = Global1.campo2
        Cl2_Par2.Text = Global2.campo2

        Cl1_Par3.Text = Global1.campo3
        Cl2_Par3.Text = Global2.campo3

        Cl1_Par4.Text = Global1.campo4
        Cl2_Par4.Text = Global2.campo4



    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Cl1_Par3.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Cl1_Par2_TextChanged(sender As Object, e As EventArgs) Handles Cl1_Par2.TextChanged

    End Sub

    Private Sub Cl1_Par4_TextChanged(sender As Object, e As EventArgs) Handles Cl1_Par4.TextChanged

    End Sub

    Private Sub Cl1_Par1_TextChanged(sender As Object, e As EventArgs) Handles Cl1_Par1.TextChanged

    End Sub

    Private Sub Cl2_Par1_TextChanged(sender As Object, e As EventArgs) Handles Cl2_Par1.TextChanged

    End Sub

    Private Sub Cl2_Par3_TextChanged(sender As Object, e As EventArgs) Handles Cl2_Par3.TextChanged

    End Sub

    Private Sub Cl2_Par2_TextChanged(sender As Object, e As EventArgs) Handles Cl2_Par2.TextChanged

    End Sub

    Private Sub Cl2_Par4_TextChanged(sender As Object, e As EventArgs) Handles Cl2_Par4.TextChanged

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Global1.campo1 = Cl1_Par1.Text
        Global2.campo1 = Cl2_Par1.Text

        Global1.campo2 = Cl1_Par2.Text
        Global2.campo2 = Cl2_Par2.Text

        Global1.campo3 = Cl1_Par3.Text
        Global2.campo3 = Cl2_Par3.Text

        Global1.campo4 = Cl1_Par4.Text
        Global2.campo4 = Cl2_Par4.Text

        Dim f As Boolean = FuncionesJSON.WriteJson(Global1, Global2)
        If f Then
            relod()
        End If

    End Sub
    Public Sub relod()

        Cl1_Par1.Text = Global1.campo1
        Cl2_Par1.Text = Global2.campo1

        Cl1_Par2.Text = Global1.campo2
        Cl2_Par2.Text = Global2.campo2

        Cl1_Par3.Text = Global1.campo3
        Cl2_Par3.Text = Global2.campo3

        Cl1_Par4.Text = Global1.campo4
        Cl2_Par4.Text = Global2.campo4
    End Sub
End Class
