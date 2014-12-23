'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class FormClassHouse
'----------------------------------------------
Public Class FormClassHouse
   Private WithEvents aHouse As House
   'Set ahouse with a value House
   Public WriteOnly Property chosenHouse As House
      Set(value As House)
         aHouse = value
      End Set
   End Property

   Private currentRooms As Integer
   Private currentGarage As Integer
   Private _frmList As FormClassList

   'Set _frmList with a FormClassList value
   Public WriteOnly Property ListForm As FormClassList
      Set(value As FormClassList)
         _frmList = value
      End Set
   End Property

   'Save a house after this button btnSave is click if id and type of the house is valid
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      If btnSave.Text = "SAVE" Then
         Dim IDString = txtId.Text
         Try
            CheckValidInput(IDString)
            Dim CityName = cboCityName.SelectedItem.ToString
            SaveHouse(IDString, CityName)
            btnSave.Text = "NEW"
            EnableElements(True)
         Catch ex As Exception
            MsgBox(ex.Message)
         End Try
      Else
            NewButton()
      End If
   End Sub
    Private Sub NewButton()
        txtId.Text = ""
        txtPrice.Text = ""
        cboCityName.SelectedIndex = -1
        btnSave.Text = "SAVE"
        EnableElements(False)
        aHouse = Nothing
    End Sub
   'Method to save the house by invoke the appropriate house type constructor
   Private Sub SaveHouse(ByVal id As String, ByVal City As String)
      If City = "Chicago" Then
         aHouse = New ChicagoHouse(id)
         CheckRadioButton()
         txtPrice.Text = FormatCurrency(aHouse.Price, 0)
      ElseIf City = "Madison" Then
         aHouse = New MadisonHouse(id)
         CheckRadioButton()
         txtPrice.Text = FormatCurrency(aHouse.Price, 0)
      Else
         aHouse = New PlattevilleHouse(id)
         CheckRadioButton()
         txtPrice.Text = FormatCurrency(aHouse.Price, 0)
        End If
   End Sub

   'Check the radio buttons automaticaly after a house is created 
   Private Sub CheckRadioButton()
      Dim city = cboCityName.SelectedItem.ToString
      If city = "Chicago" Then
         rdoThreeRooms.Checked = True
         rdoTwoGarages.Checked = True
         txtPrice.Text = FormatCurrency(aHouse.Price, 0)
      ElseIf city = "Madison" Then
         rdoTwoRooms.Checked = True
         rdoOneGarage.Checked = True
         txtPrice.Text = FormatCurrency(aHouse.Price, 0)
      Else
         rdoTwoRooms.Checked = True
         rdoOneGarage.Checked = True
         txtPrice.Text = FormatCurrency(aHouse.Price, 0)
      End If
   End Sub
   Private Const MAXCHARS As Integer = 5

   'Check if the Input is valid or not.
   Protected Sub CheckValidInput(ByVal IDString As String)
      If cboCityName.SelectedItem = Nothing Then
         Throw New Exception("Select house type please!")
      Else
         If IDString.Count <> MAXCHARS Then
            Throw New Exception("ID must have exactly five Character")
         Else
            If Not CheckInvalidCharacters(IDString) Then
               Throw New Exception("Each character of ID must be a digit or a number")
            Else
               If NameExist(IDString) = False Then
               Else
                  Throw New Exception("ID must be unique")
               End If
            End If
         End If
      End If
   End Sub

   'Method to check if the name of a house is already exist in the list
   Private Function NameExist(ByVal txtIDString As String) As Boolean

      For i As Integer = 0 To House.TotalCount - 1
         If House.HouseByIndex(i).ID = txtIDString Then
            Return True
         End If
      Next
      Return False

   End Function

   'Method to check if the ID input is LetterOrDigit. 
   Private Function CheckInvalidCharacters(ByVal StringID As String) As Boolean
      For Each character In StringID
         If Not Char.IsLetterOrDigit(character) Then
            Return False
         End If
      Next
      Return True
   End Function

   Private Const FOUR_ROOMS As Integer = 4
   Private Const THREE_ROOMS As Integer = 3
   Private Const TWO_ROOMS As Integer = 2
   Private Const THREE_GARAGES As Integer = 3
   Private Const TWO_GARAGES As Integer = 2

   'Method to set the currentRooms and currentGarage by values on the checked radio button
   Private Sub GetSelectedRoomAndGarage()
      If rdoFourRooms.Checked = True Then
         currentRooms = FOUR_ROOMS
      End If
      If rdoThreeRooms.Checked = True Then
         currentRooms = THREE_ROOMS
      End If
      If rdoTwoRooms.Checked = True Then
         currentRooms = TWO_ROOMS
      End If
      If rdoThreeGarages.Checked = True Then
         currentGarage = THREE_GARAGES
      End If
      If rdoTwoGarages.Checked = True Then
         currentGarage = TWO_GARAGES
      End If
      If rdoOneGarage.Checked = True Then
         currentGarage = 1
      End If

   End Sub

   'Method to check the radio buttons by the value from currentRooms and currentGarages
   Private Sub SetSelectedRoomAndGarage()
        If aHouse.Rooms = FOUR_ROOMS Then
            rdoFourRooms.Checked = True
        End If
        If aHouse.Rooms = THREE_ROOMS Then
            rdoThreeRooms.Checked = True
        End If
        If aHouse.Rooms = TWO_ROOMS Then
            rdoTwoRooms.Checked = True
        End If
        If aHouse.Garages = THREE_GARAGES Then
            rdoThreeGarages.Checked = True
        End If
        If aHouse.Garages = TWO_GARAGES Then
            rdoTwoGarages.Checked = True
        End If
        If aHouse.Garages = 1 Then
            rdoOneGarage.Checked = True
        End If
   End Sub

    'Handle the event HouseListUpdate
    Private Sub Handle_HouseListUpdate() Handles aHouse.HouseListUpdated
        Try
            SetSelectedRoomAndGarage()
            txtPrice.Text = FormatCurrency(aHouse.Price, 0)
        Catch ex As Exception
            NewButton()
        End Try



    End Sub



    'Modify the price after this button is clicked
    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        Try
            AllError.Clear()
            GetSelectedRoomAndGarage()
            aHouse.Modify(currentRooms, currentGarage)
            txtPrice.Text = FormatCurrency(aHouse.Price, 0)

        Catch ex As Exception
            If ex.Message = "Number of Room is out of range" Then
                AllError.SetError(GroupBox1, ex.Message)
            ElseIf ex.Message = "Number of Garage is out of range" Then
                AllError.SetError(GroupBox2, ex.Message)
            Else
                AllError.SetError(GroupBox1, ex.Message)
                AllError.SetError(GroupBox2, ex.Message)
            End If
        End Try
    End Sub






    'Enabling/disabling elements on the form base on the take in boolean value
    Private Sub EnableElements(ByVal onOrof As Boolean)
        cboCityName.Enabled = Not onOrof
        txtId.Enabled = Not onOrof
        GroupBox1.Enabled = onOrof
        GroupBox2.Enabled = onOrof
        BtnModify.Enabled = onOrof
    End Sub

    'Handle the PriceChanged event
    Private Sub HandlePriceChangedEvent() Handles aHouse.PriceChanged
        MsgBox("Price Changed!")
    End Sub

    'Exit the program
    Protected Overridable Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'hide this form and show the _frmList
    Protected Overridable Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        _frmList.SetMainFormHouse = aHouse
        Me.Hide()
        _frmList.Show()
        _frmList.BringToFront()

    End Sub

    Private Const PLATTEVILLE_INDEX As Integer = 2

    'Decide what will happened whenever the form is activate.
    Private Sub FormClassHouse_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        cboCityName.Focus()
        AllError.Clear()
        Try
            If aHouse.Type = "Chicago" Then
                cboCityName.SelectedIndex = 0
            ElseIf aHouse.Type = "Madison" Then
                cboCityName.SelectedIndex = 1
            ElseIf aHouse.Type = "Platteville" Then
                cboCityName.SelectedIndex = PLATTEVILLE_INDEX
            End If
            txtId.Text = aHouse.ID
            txtPrice.Text = FormatCurrency(aHouse.Price, 0)
            SetSelectedRoomAndGarage()
            btnSave.Text = "NEW"
            EnableElements(True)

        Catch ex As Exception
            NewButton()
        End Try

    End Sub

    'Handle the remove event
    Private Sub handleRemoveEvent() Handles aHouse.Removed
        Me.BringToFront()
        NewButton()
    End Sub

    Private Sub FormClassHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
