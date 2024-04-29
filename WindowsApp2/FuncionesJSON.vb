Imports Microsoft.VisualBasic.Devices
Imports Newtonsoft
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO

Module FuncionesJSON

    Public Function WriteJson(clase1JSON As ClaseJSON, clase2JSON As ClaseJSON) As Boolean
        Dim lista As List(Of ClaseJSON) = New List(Of ClaseJSON)

        lista.Add(clase1JSON)
        lista.Add(clase2JSON)
        Dim json As String = JsonConvert.SerializeObject(lista)
        Dim rutaArchivo As String = "C:\MyJSON\datos.json"
        Dim rutaCarpeta As String = "C:\MyJSON"

        ' Se ve si existe la carpeta para guardar El Json, si no es asi la crea y tambien crea un json de dos registros

        If Not Directory.Exists(rutaCarpeta) Then

            Directory.CreateDirectory(rutaCarpeta)

            If Not File.Exists(rutaArchivo) Then
                Dim Js As String = "[
                 {'campo1': '-', 'campo2': '-', 'campo3': '-', 'campo4': '-'},
                {'campo1': '--', 'campo2': '--', 'campo3': '--', 'campo4': '--'}
                ]"
                File.WriteAllText(rutaArchivo, Js)


            End If


        End If


        ' Mostrar el JSON resultante
        Console.WriteLine("JSON resultante:")
        Console.WriteLine(json)

        File.WriteAllText(rutaArchivo, json)
        Return True

    End Function
    Public Function ReadJSON() As List(Of ClaseJSON)
        Dim rutaArchivo As String = "C:\MyJSON\datos.json"
        Dim rutaCarpeta As String = "C:\MyJSON"

        ' Se ve si existe la carpeta para guardar El Json, si no es asi la crea y tambien crea un json de dos registros

        If Not Directory.Exists(rutaCarpeta) Then

            Directory.CreateDirectory(rutaCarpeta)
            If Not File.Exists(rutaArchivo) Then
                Dim Js As String = "[
                 {'campo1': '-', 'campo2': '-', 'campo3': '-', 'campo4': '-'},
                {'campo1': '--', 'campo2': '--', 'campo3': '--', 'campo4': '--'}
                ]"
                File.WriteAllText(rutaArchivo, Js)


            End If
        End If
        Dim json As String = File.ReadAllText("C:\MyJSON\datos.json")
        Dim Clases As List(Of ClaseJSON) = JsonConvert.DeserializeObject(Of List(Of ClaseJSON))(json)
        Return Clases
    End Function

End Module
