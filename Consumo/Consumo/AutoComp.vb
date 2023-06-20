Module AutoComp
    Public Sub AutoComplete(ByVal cbo As ComboBox,
                            ByVal e As System.Windows.Forms.KeyEventArgs)
        ' Call this from your form passing in the name 
        ' of your combobox and the event arg:
        ' AutoComplete(cboState, e)
        Dim iIndex As Integer
        Dim sActual As String
        Dim sFound As String
        Dim bMatchFound As Boolean

        'check if the text is blank or not, if not then only proceed
        If Not cbo.Text = "" Then 'if the text is not blank then only proceed

            If e.KeyCode = Keys.Back Then
                cbo.Text = Mid(cbo.Text, 1, Len(cbo.Text) - 1)
            End If

            ' Do nothing for some keys such as navigation keys...
            If ((e.KeyCode = Keys.Left) Or
             (e.KeyCode = Keys.Right) Or
             (e.KeyCode = Keys.Up) Or
             (e.KeyCode = Keys.Down) Or
             (e.KeyCode = Keys.PageUp) Or
             (e.KeyCode = Keys.PageDown) Or
             (e.KeyCode = Keys.Home) Or
             (e.KeyCode = Keys.End)) Then
                Return
            End If
            Do
                ' Store the actual text that has been typed.
                sActual = cbo.Text
                ' Find the first match for the typed value.
                iIndex = cbo.FindString(sActual)


                If (iIndex > -1) Then '** FOUND SECTION **
                    sFound = cbo.Items(iIndex).ToString()
                    ' Select this item from the list.
                    cbo.SelectedIndex = iIndex
                    ' Select the portion of the text that was automatically
                    ' added so that additional typing will replace it.
                    cbo.SelectionStart = sActual.Length
                    cbo.SelectionLength = sFound.Length
                    bMatchFound = True
                Else '** NOT FOUND SECTION **

                    'if there isn't a match and the text typed in is only 1 character 
                    'or nothing then just select the first entry in the combo box.

                    If sActual.Length = 1 Or sActual.Length = 0 Then
                        cbo.SelectedIndex = 0
                        cbo.SelectionStart = 0
                        cbo.SelectionLength = Len(cbo.Text)
                        bMatchFound = True
                    Else

                        cbo.SelectionStart = sActual.Length - 1
                        cbo.SelectionLength = sActual.Length - 1
                        cbo.Text = Mid(cbo.Text, 1, Len(cbo.Text) - 1)
                        '/////// THREE LINES SECTION ENDS HERE /////////////
                        'bMatchFound = True
                    End If
                End If
            Loop Until bMatchFound
        End If
    End Sub

    Public Sub AutoCompleteCombo_KeyUp(ByVal cbo As ComboBox, ByVal e As KeyEventArgs)
        Dim sTypedText As String
        Dim iFoundIndex As Integer
        Dim oFoundItem As Object
        Dim sFoundText As String
        Dim sAppendText As String

        'Allow select keys without Autocompleting
        Select Case e.KeyCode
            Case Keys.Back, Keys.Left, Keys.Right, Keys.Up, Keys.Delete, Keys.Down
                Return
        End Select

        'Get the Typed Text and Find it in the list
        sTypedText = cbo.Text
        iFoundIndex = cbo.FindString(sTypedText)

        'If we found the Typed Text in the list then Autocomplete
        If iFoundIndex >= 0 Then

            'Get the Item from the list (Return Type depends if Datasource was bound 
            ' or List Created)
            oFoundItem = cbo.Items(iFoundIndex)

            'Use the ListControl.GetItemText to resolve the Name in case the Combo 
            ' was Data bound
            sFoundText = cbo.GetItemText(oFoundItem)

            'Append then found text to the typed text to preserve case
            sAppendText = sFoundText.Substring(sTypedText.Length)
            cbo.Text = sTypedText & sAppendText

            'Select the Appended Text
            cbo.SelectionStart = sTypedText.Length
            cbo.SelectionLength = sAppendText.Length
        End If
    End Sub

    Public Sub AutoCompleteCombo_Leave(ByVal cbo As ComboBox)
        Dim iFoundIndex As Integer
        iFoundIndex = cbo.FindStringExact(cbo.Text)
        cbo.SelectedIndex = iFoundIndex
    End Sub
End Module
