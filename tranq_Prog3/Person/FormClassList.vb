'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class FormClassList
'----------------------------------------------
Public Class FormClassList
    Private _mainForm As FormClassHouse
    Private WithEvents _mainFormHouse As House
    'Set _mainForm with a FormClassHouse value
    Public WriteOnly Property MainForm As FormClassHouse
        Set(value As FormClassHouse)
            _mainForm = value
        End Set
    End Property

    'Set _mainFormHouse with a FormClassHouse value
    Public WriteOnly Property SetMainFormHouse As House
        Set(value As House)
            _mainFormHouse = value
        End Set
    End Property
    Private Const LEFT_ALLIGN As Integer = 14

    'Decide what happen whenever this form is activate
    Private Sub FormClassList_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateList()
        AddHandler House.HouseListUpdated, AddressOf UpdateList
        ErrorProvider1.Clear()
    End Sub

    'hide this form and show the main form with information from selected house
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Try
            Dim index = ListBox1.SelectedIndex
            Dim SelectedHouse As House = House.HouseByIndex(index)
            _mainForm.chosenHouse = SelectedHouse
            Me.Hide()
            _mainForm.Show()
            _mainForm.BringToFront()
        Catch ex As Exception
            'MsgBox("Select a house in the list")
            ErrorProvider1.SetError(ListBox1, " Please Select House First ")
        End Try



    End Sub

    'Hide this form and show the mainform
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        _mainForm.chosenHouse = _mainFormHouse
        _mainForm.Show()
        _mainForm.BringToFront()
    End Sub

    'Remove a selected house
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim index = ListBox1.SelectedIndex
            Dim SelectedHouse As House = House.HouseByIndex(index)
            For i As Integer = ListBox1.Items.Count - 1 To 0 Step -1
                If ListBox1.GetSelected(i) Then
                    ListBox1.Items.RemoveAt(i)
                End If
            Next
            If SelectedHouse.Equals(_mainFormHouse) Then
                _mainFormHouse = Nothing
            End If
            CType(SelectedHouse, IDisposable).Dispose()
            SelectedHouse = Nothing
            txtCount.Text = House.TotalCount
            ErrorProvider1.Clear()
        Catch ex As Exception
            'MsgBox("Select a house in the list")
            ErrorProvider1.SetError(ListBox1, " Please Select House First ")
        End Try
    End Sub

    'Update the List when a house is change
    Private Sub UpdateList()
        txtCount.Text = House.TotalCount
        ListBox1.Items.Clear()
        For i As Integer = 0 To House.TotalCount - 1
            Dim HouseOfIndex = House.HouseByIndex(i)
            ListBox1.Items.Add(HouseOfIndex.ID & HouseOfIndex.Type.PadLeft(LEFT_ALLIGN) _
                               & FormatCurrency(HouseOfIndex.Price, 0).PadLeft(LEFT_ALLIGN))
        Next
    End Sub

End Class