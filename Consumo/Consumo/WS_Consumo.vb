
Imports System.Xml

Public Class frmConsumoServicioWS

    Public Function ObtenerTC_Dia(ByVal Fecha As Date) As Double
        Dim objServ As New Consumo.Servicio.Tipo_Cambio_BCNSoapClient


        ''Servicio.Tipo_Cambio_BCNSoapClient
        Try
            Return objServ.RecuperaTC_Dia(Year(Fecha), Month(Fecha), DatePart(DateInterval.Day, Fecha))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function ObtenerTC_Tabla(ByVal Fecha As Date) As DataTable
        Dim objServ As  New Consumo.Servicio.Tipo_Cambio_BCNSoapClient
        Dim objElement As XmlElement
        Dim xmlNodLista As XmlNodeList
        Dim dt As New DataTable
        Try

            ' CONSUMIMOS EL SERVICIO
            objElement = objServ.RecuperaTC_Mes(Year(Fecha), Month(Fecha))
            xmlNodLista = objElement.GetElementsByTagName("Tc")


            ' AGREGAMOS LAS COLUMNAS AL DATATABLE 
            For Each Node As XmlNode In xmlNodLista.Item(0).ChildNodes
                Dim Col As New DataColumn(Node.Name, System.Type.GetType("System.String"))
                dt.Columns.Add(Col)
            Next

            ' AGREGAR LA INFORMACION AL DATATABLE 
            For IntVal As Integer = 0 To xmlNodLista.Count - 1
                Dim dr As DataRow = dt.NewRow
                For Col As Integer = 0 To dt.Columns.Count - 1
                    If Not IsDBNull(xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText) Then
                        dr(Col) = xmlNodLista.Item(IntVal).ChildNodes(Col).InnerText
                    Else
                        dr(Col) = Nothing
                    End If
                Next
                dt.Rows.Add(dr)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function

    Private Sub CmdServicio_Click(sender As Object, e As EventArgs) Handles cmdServicio.Click
        Select Case Me.rbtCSencillo.Checked
            Case True
                Me.txtTc.Text = ObtenerTC_Dia(Me.dtpfecha.Value)
            Case False
                Me.grdtipocambio.DataSource = ObtenerTC_Tabla(Me.dtpfecha.Value)
        End Select
    End Sub
End Class
