'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class PlattevilleHouse
'----------------------------------------------
Public Class PlattevilleHouse
   Inherits House
   Private Const DEFAULTPRICE As Single = 200000
   Private Const DEFAULTROOMS As Single = 2
   Public Sub New(ByVal inId As String)
      _Type = "Platteville"
      _Price = DEFAULTPRICE
      _Garages = 1
      _Room = DEFAULTROOMS
      _ID = inId
        ListHouse.Add(Me)
        RaiseEventHouseListUpdate()
   End Sub

   Private Const THREE_ROOMS As Single = 3
   Private Const TWO_GARAGES As Integer = 2
   Private Const EXTRA_ROOM_PRICE As Single = 8000
   Private Const EXTRA_GARAGE_PRICE As Single = 2500

   ' Modifies number of rooms and number of garages, and hence
   ' the price of the house if both parameters are valid.
   Public Overrides Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)
      Dim oldPrice = _Price
      If (numRooms < DEFAULTROOMS Or numRooms > THREE_ROOMS) And numGarages > TWO_GARAGES Then
            Throw New Exception("Number of Room is out of range" & vbLf & "Number of Garage is out of range")
      ElseIf numRooms < DEFAULTROOMS Or numRooms > THREE_ROOMS Then
            Throw New Exception("Number of Room is out of range")
      ElseIf numGarages > TWO_GARAGES Then
         Throw New Exception("Number of Garage is out of range")
      Else
         _Room = numRooms
         _Garages = numGarages
         _Price = DEFAULTPRICE + (numRooms - DEFAULTROOMS) * EXTRA_ROOM_PRICE + (numGarages - 1) * EXTRA_GARAGE_PRICE
         If oldPrice <> _Price Then
            RaiseEventFromBaseClass()
         End If
        End If
        RaiseEventHouseListUpdate()
   End Sub



End Class
