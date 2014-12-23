'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class MadisonHouse
'----------------------------------------------
Public Class MadisonHouse
   Inherits House
   Private Const DEFAULT_PRICE As Single = 300000
   Private Const EXTRA_ROOM_PRICE As Integer = 10000
   Private Const EXTRA_GARAGE_PRICE As Integer = 5000
   Private Const DEFAULTROOMS As Integer = 2

   'Constructor for MadisonHouse object that take in a ID string.
   Public Sub New(ByVal inID As String)
      _Type = "Madison"
      _Price = DEFAULT_PRICE
      _Garages = 1
      _Room = DEFAULTROOMS
      _ID = inID
        ListHouse.Add(Me)
        RaiseEventHouseListUpdate()
   End Sub

   ' Modifies number of rooms and number of garages, and hence
   ' the price of the house if both parameters are valid.
   Public Overrides Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)
      Dim oldPrice = _Price
      _Price = DEFAULT_PRICE + _
         (numRooms - DEFAULTROOMS) * EXTRA_ROOM_PRICE + (numGarages - 1) * EXTRA_GARAGE_PRICE
      _Room = numRooms
      _Garages = numGarages
      If oldPrice <> _Price Then
         RaiseEventFromBaseClass()
      End If
        RaiseEventHouseListUpdate()
   End Sub
End Class
