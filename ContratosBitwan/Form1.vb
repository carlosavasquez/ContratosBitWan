Imports Microsoft.Office.Interop.Word 'control de office
Imports System.IO 'sistema de archivos
Imports Microsoft.Office.Interop
Public Class Form1
    
    Private Sub CrearCarpeta(ByVal nom As String)
        System.IO.Directory.CreateDirectory("c:\resultados\" + nom + "")
    End Sub
    Private Sub CrearContrato()
        Dim MSWord As New Word.Application
        Dim Documento As Word.Document
        Dim nom As String = ""
        nom = txt_nombre_completo.Text.ToUpper
        CrearCarpeta(nom)
        FileCopy("C:\CONTRATO.docx", "C:\resultados\" + nom + "\" + nom + "salida.docx")
        Documento = MSWord.Documents.Open("C:\resultados\" + nom + "\" + nom + "salida.docx")

        'AGREGAR INFO A LOS MARCADORES
        Documento.Bookmarks.Item("añopedido").Range.Text = Year(Now)
        Documento.Bookmarks.Item("barrio").Range.Text = txt_barrio.Text
        If txt_tipo_documento.SelectedIndex = 0 Then
            Documento.Bookmarks.Item("cc").Range.Text = "X"
        ElseIf txt_tipo_documento.SelectedIndex = 1 Then
            Documento.Bookmarks.Item("nit").Range.Text = "X"
        ElseIf txt_tipo_documento.SelectedIndex = 2 Then
            Documento.Bookmarks.Item("ce").Range.Text = "X"
        End If
        Documento.Bookmarks.Item("celular").Range.Text = txt_celular.Text()
        Documento.Bookmarks.Item("celularalterno").Range.Text = txt_celular_alterno.Text
        Documento.Bookmarks.Item("ciudad").Range.Text = txt_ciudad.Text
        Documento.Bookmarks.Item("correo").Range.Text = txt_correo.Text
        Documento.Bookmarks.Item("departamento").Range.Text = txt_departamento.Text()
        Documento.Bookmarks.Item("diapedido").Range.Text = Month(Now)
        Documento.Bookmarks.Item("direccionfacturacion").Range.Text = txt_direccion_facturacion.Text()
        Documento.Bookmarks.Item("mespedido").Range.Text = Month(Now)
        Dim MyString As String = txt_nombre_completo.Text
        Dim conver As String = MyString.PadRight(58, " "c)
        MsgBox(conver)
        Documento.Bookmarks.Item("nombrecompleto").Range.Text = conver
        Documento.Bookmarks.Item("numerocontrato").Range.Text = txt_num_contrato.Text()

        Documento.Bookmarks.Item("numerodocumento").Range.Text = txt_num_contrato.Text

        Documento.Save()

        ' GUARDA EL ARCHIVO Y LO CIERRA SIN PREGUNTAR AL USUARIO
        MSWord.Documents(nom + "salida.docx").Close(Word.WdSaveOptions.wdSaveChanges)
        MsgBox("listo el contrato", MsgBoxStyle.Information, "LISTO")
    End Sub
    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click
        CrearContrato()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_tipo_documento.SelectedIndex = 0
        txt_departamento.SelectedIndex = 0
        txt_ciudad.SelectedIndex = 0
    End Sub
End Class
