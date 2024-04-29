Imports Newtonsoft
Imports Newtonsoft.Json.Linq
Imports System.IO

Public Class ClaseJSON
    Public campo1 As String
    Public campo2 As String
    Public campo3 As String
    Public campo4 As String


    Public Sub New()

        Me.campo1 = "-"
        Me.campo2 = "-"
        Me.campo3 = "-"
        Me.campo4 = "-"
        Dim rutaArchivo As String = "C:\MyJSON\datos.json"
        Dim rutaCarpeta As String = "C:\MyJSON"

        ' Se ve si existe la carpeta para guardar El Json, si no es asi la crea y tambien crea un json de dos registros

        If Not Directory.Exists(rutaCarpeta) Then

            Directory.CreateDirectory(rutaCarpeta)

            If Not File.Exists(rutaArchivo) Then
                Dim Json As String = "[
                 {'campo1': '-', 'campo2': '-', 'campo3': '-', 'campo4': '-'},
                {'campo1': '--', 'campo2': '--', 'campo3': '--', 'campo4': '--'}
                ]"
                File.WriteAllText(rutaArchivo, Json)


            End If


        End If


    End Sub
End Class
