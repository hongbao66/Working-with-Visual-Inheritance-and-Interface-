'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class ChicagoHouse
'----------------------------------------------
Public Class ChicagoHouse
   Inherits House
   Private Const DEFAULTPRICE As Single = 400000
   Private Const DEFAULTGARAGES As Integer = 2
   Private Const DEFAULTROOMS As Integer = 3
   Private Const THREEROOMS As Integer = 3
   Private Const FOURROOMS As Integer = 4
   Private Const TWOGARAGES As Integer = 2
   Private Const THREEGARAGES As Integer = 3

   'constructor for ChicagoHouse object
   Public Sub New(ByVal inId As String)
      _Type = "Chicago"
      _Price = DEFAULTPRICE
      _Garages = DEFAULTGARAGES
      _Room = DEFAULTROOMS
      _ID = inId
        ListHouse.Add(Me)
        RaiseEventHouseListUpdate()
   End Sub

   ' Modifies number of rooms and number of garages, and hence
   ' the price of the house if both parameters are valid.
   Public Overrides Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)
      Dim oldPrice = _Price
      If (numRooms < THREEROOMS Or numRooms > FOURROOMS) And numGarages < 2 Then
            Throw New Exception("Number of Room is out of range" & vbLf & "Number of Garage is out of range")
      ElseIf numRooms < THREEROOMS Or numRooms > FOURROOMS Then
            Throw New Exception("Number of Room is out of range")
      ElseIf numGarages < TWOGARAGES Then
         Throw New Exception("Number of Garage is out of range")
      Else
         _Room = numRooms
         _Garages = numGarages
         ChangePrice(numRooms, numGarages)
         If oldPrice <> _Price Then
            RaiseEventFromBaseClass()
         End If
        End If
        RaiseEventHouseListUpdate()
   End Sub

   Private Const PRICE_THREE_ROOM_THREE_GARAGES As Single = 410000
   Private Const PRICE_fOUR_ROOM_TWO_GARAGES As Single = 420000
   Private Const PRICE_ELSE As Single = 428000

   'Change the price coresponding to given number of rooms and numbers of garages
   Private Sub ChangePrice(ByVal numRooms As Integer, ByVal numGarages As Integer)
      If numRooms = THREEROOMS And numGarages = TWOGARAGES Then
         _Price = DEFAULTPRICE
      ElseIf numRooms = THREEROOMS And numGarages = THREEGARAGES Then
         _Price = PRICE_THREE_ROOM_THREE_GARAGES
      ElseIf numRooms = FOURROOMS And numGarages = TWOGARAGES Then
         _Price = PRICE_fOUR_ROOM_TWO_GARAGES
      Else
         _Price = PRICE_ELSE
      End If

   End Sub
End Class
