Option Explicit On
Option Strict On
Imports DAL
Imports System.Data.SqlClient

Public Class frmBuscar
    Public sTabla As String
    Public sValor1 As String
    Public sValor2 As String
    Public sValor3 As String
    Public sValor4 As String
    Public sValor5 As String
    Public sValor6 As String
    Public sValor7 As String
    Public sValor8 As String
    Public sValor9 As String
    Public sValor10 As String

    Public Sub Catalogo(ByVal Tabla As String,
                        Optional ByVal pFilter As String = vbNullString)

        Dim dtTabla As DataTable = Nothing

        sTabla = Tabla.Trim

        cmdSeleccion.Enabled = False
        cmbCampo.Items.Clear()
        lvw.Groups.Clear()
        cmbCampo.Items.Add(sAll)

        With lvw
            .Items.Clear()
            .Columns.Clear()
            .BeginUpdate()

            dtTabla = DB.Retrieve_Tabla("TABLAS", , , "TablaID='" & sTabla.Trim & "'")

            If dtTabla.Rows.Count > 0 Then
                Text = dtTabla.Rows(0).Item("Titulo").ToString
                iCantidad = Convert.ToInt32(dtTabla.Rows(0).Item("Cantidad").ToString)
            End If

            dtTabla = Nothing
            dtTabla = DB.Retrieve_Tabla("TABLAS_DETALLES", , , "TablaID='" & sTabla.Trim & "' AND Ver=1", "Indice ASC")

            cmbCampo.BeginUpdate()

            For Each drw As DataRow In dtTabla.Rows
                cmbCampo.Items.Add(drw("Titulo"))

                If sCampos = vbNullString Then
                    sCampos = sCampos & drw("CampoID").ToString.Trim

                Else
                    sCampos = sCampos & ", " & drw("CampoID").ToString.Trim
                End If

                .Columns.Add(drw("CampoID").ToString.Trim, drw("Titulo").ToString.Trim)
            Next drw

            cmbCampo.EndUpdate()
            .EndUpdate()
            .AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        End With

        dtTabla_Detalles = DB.Retrieve_Tabla(sTabla.Trim, sCampos.Trim, , "1=0")
        cmbCampo.SelectedIndex = 0
        dtTabla = Nothing
        ShowDialog()
    End Sub
    Private Const sAll As String = "[Todo]"
    Dim dtTabla_Detalles As DataTable = Nothing

    Dim iCantidad As Integer
    Dim sCampos As String = vbNullString

    Private Sub cmbCampo_KeyPress(ByVal sender As Object,
                                  ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles cmbCampo.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cmdBuscar_Click(Nothing, Nothing)

            If cmdSeleccion.Enabled Then lvw.Focus()
        End If

    End Sub
    Private Sub frmBuscar_Activated(ByVal sender As Object,
                                    ByVal e As System.EventArgs) _
            Handles Me.Activated
        TxtValor.Focus()
    End Sub

    Private Sub frmBuscar_Disposed(ByVal sender As Object,
                                   ByVal e As System.EventArgs) _
            Handles Me.Disposed
        lvw.Dispose()
        dtTabla_Detalles = Nothing
        Dispose(True)
    End Sub

    Private Sub frmBuscar_KeyPress(ByVal sender As Object,
                                   ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles Me.KeyPress

        If e.KeyChar = ChrW(Keys.Escape) Then
            e.Handled = True : Close()
        End If

    End Sub

    Private Sub lvw_ColumnClick(ByVal sender As Object,
                                ByVal e As System.Windows.Forms.ColumnClickEventArgs) _
            Handles lvw.ColumnClick
        Me.cmbCampo.SelectedIndex = Convert.ToInt32(e.Column.ToString()) + 1
    End Sub

    Private Sub lvw_DoubleClick(ByVal sender As Object,
                                ByVal e As System.EventArgs) _
            Handles lvw.DoubleClick

        If cmdSeleccion.Enabled Then cmdSeleccion_Click(Nothing, Nothing)
    End Sub

    Private Sub lvw_KeyPress(ByVal sender As Object,
                             ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles lvw.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            cmdSeleccion_Click(Nothing, Nothing)
        End If

    End Sub
    Private Function SafeLike(ByVal pString As String) As String

        Dim s As String = vbNullString
        s = pString.Replace("'", "''")
        s = s.Replace("[", "[[]")
        s = s.Replace("%", "[%]")
        s = s.Replace("_", "[_]")
        Return s.Trim
    End Function

    Private Sub TxtValor_GotFocus(ByVal sender As Object,
                                  ByVal e As System.EventArgs) _
            Handles TxtValor.GotFocus

        If TxtValor.Text.Trim() = "Buscar elemento..." Then
            TxtValor.Text = vbNullString
            TxtValor.ForeColor = Color.Black
        End If
    End Sub
    Private Sub TxtValor_KeyPress(ByVal sender As Object,
                                  ByVal e As System.Windows.Forms.KeyPressEventArgs) _
            Handles TxtValor.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            cmdBuscar_Click(Nothing, Nothing)
            If cmdSeleccion.Enabled Then lvw.Focus()
        End If
    End Sub

    Private Sub TxtValor_LostFocus(ByVal sender As Object,
                                   ByVal e As System.EventArgs) _
            Handles TxtValor.LostFocus

        If TxtValor.Text = vbNullString Then
            TxtValor.Text = "Buscar elemento..."
            TxtValor.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub cmdBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click
        Dim dtTabla As DataTable = Nothing
        Dim sFindWhat As String = CStr(IIf(TxtValor.Text = "Buscar elemento...", vbNullString, SafeLike(TxtValor.Text)))
        Dim sNewFindWhat As String = vbNullString
        Dim sFilter As String = vbNullString
        Dim sOperador As String = vbNullString
        Dim sOrderBy As String = vbNullString
        Dim pFecha As Date
        Dim i As Integer = 0

        If Me.cmbCampo.SelectedIndex = 0 Then

            For i = 0 To (dtTabla_Detalles.Columns.Count - 1)

                If i <> 0 Then sFilter &= "OR "
                If dtTabla_Detalles.Columns(i).DataType Is GetType(System.DateTime) _
                    OrElse dtTabla_Detalles.Columns(i).DataType Is GetType(System.TimeSpan) Then

                    If IsDate(sFindWhat) Then
                        sOperador = "="
                        pFecha = Convert.ToDateTime(sFindWhat)

                        sNewFindWhat = "'" & Format(pFecha, "yyyyMMdd") & "'"

                    Else
                        sOperador = "="
                        sNewFindWhat = "'" & "99990101" & "'"
                    End If

                Else
                    sOperador = " LIKE "
                    sNewFindWhat = "'%" & sFindWhat & "%'"
                End If

                sFilter &= dtTabla_Detalles.Columns(i).ColumnName.Trim & " " & sOperador
                sFilter &= sNewFindWhat.Trim
            Next i

            sOrderBy &= dtTabla_Detalles.Columns(0).ColumnName.Trim & " ASC"

        Else

            If dtTabla_Detalles.Columns(cmbCampo.SelectedIndex - 1).DataType Is GetType(System.DateTime) _
                OrElse dtTabla_Detalles.Columns(cmbCampo.SelectedIndex - 1).DataType Is GetType(System.TimeSpan) Then

                If IsDate(sFindWhat) Then
                    sOperador = "="
                    pFecha = Convert.ToDateTime(sFindWhat)
                    sNewFindWhat = "'" & Format(pFecha, "yyyyMMdd") & "'"
                    Debug.Print(sNewFindWhat)

                Else
                    sOperador = "="
                    sNewFindWhat = "'" & "99990101" & "'"
                End If

            Else
                sOperador = " LIKE "
                sNewFindWhat = "'%" & sFindWhat & "%'"
            End If
            sFilter &= dtTabla_Detalles.Columns(cmbCampo.SelectedIndex - 1).ColumnName.Trim & " " & sOperador.Trim
            sFilter &= sNewFindWhat.Trim
            sOrderBy &= dtTabla_Detalles.Columns(cmbCampo.SelectedIndex - 1).ColumnName.Trim & " ASC"
        End If

        lvw.Items.Clear()
        lvw.Groups.Clear()
        lvw.BeginUpdate()

        dtTabla = DB.Retrieve_Tabla(sTabla.Trim, sCampos.Trim, iCantidad, sFilter.Trim, sOrderBy.Trim)

        lvw.Groups.Add(New ListViewGroup("Grupo", "Resultados de la Búsqueda"))


        For i = 0 To (dtTabla.Rows.Count - 1)

            Dim Item As New ListViewItem(dtTabla.Rows(i).Item(0).ToString.Trim)

            For j As Integer = 1 To (dtTabla.Columns.Count - 1)

                If dtTabla.Columns(j).DataType Is GetType(System.DateTime) _
                OrElse dtTabla.Columns(j).DataType Is GetType(System.TimeSpan) Then
                    Item.SubItems.Add(Format(Convert.ToDateTime(dtTabla.Rows(i).Item(j).ToString), "dd/MM/yyyy"))
                Else
                    Item.SubItems.Add(dtTabla.Rows(i).Item(j).ToString.Trim)
                End If

            Next j
            lvw.Items.Add(Item)
            lvw.Items.Item(i).Group = lvw.Groups(0)
        Next i
        lvw.EndUpdate()
        lvw.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        cmdSeleccion.Enabled = (lvw.Items.Count > 0)
        If lvw.Items.Count > 0 Then
            lvw.TopItem.Selected = True
            lvw.TopItem.Focused = True
            lvw.TopItem.EnsureVisible()
            lvw.Select()
        End If
        dtTabla = Nothing
    End Sub
    Private Sub cmdSeleccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleccion.Click
        Try


            If Not IsNothing(lvw.FocusedItem) Then
                sValor1 = lvw.FocusedItem.Text.Trim & vbNullString
                sValor2 = lvw.FocusedItem.SubItems(1).Text.Trim & vbNullString
                sValor3 = lvw.FocusedItem.SubItems(2).Text.Trim & vbNullString
                sValor4 = lvw.FocusedItem.SubItems(3).Text.Trim & vbNullString
                sValor5 = lvw.FocusedItem.SubItems(4).Text.Trim & vbNullString
                sValor6 = lvw.FocusedItem.SubItems(5).Text.Trim & vbNullString
                sValor7 = lvw.FocusedItem.SubItems(6).Text.Trim & vbNullString
                sValor8 = lvw.FocusedItem.SubItems(7).Text.Trim & vbNullString
                sValor9 = lvw.FocusedItem.SubItems(8).Text.Trim & vbNullString
                sValor10 = lvw.FocusedItem.SubItems(9).Text.Trim & vbNullString
            End If
        Catch ex As Exception
            Debug.Print(ex.Message.ToString.Trim)
        Finally
            Debug.Print("Already man")
        End Try
        Hide()
    End Sub

End Class
