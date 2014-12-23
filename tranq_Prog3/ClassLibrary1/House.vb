'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class House
'----------------------------------------------
Public MustInherit Class House
    Implements IDisposable
    Protected Shared ListHouse As List(Of House) = New List(Of House)
    Protected _Type As String
    Protected _ID As String
    Protected _Room As Integer
    Protected _Price As Single
    Protected _Garages As Integer



    Public Event Removed()


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
                ListHouse.Remove(Me)
                RaiseEvent Removed()
                RaiseEvent HouseListUpdated()
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    ' Change to Private!
    Private Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region


    ' Event HouseListUpdated prototype that u want!
    Public Shared Event HouseListUpdated()
    ' Returns the total count of house objects to be built.
    Public Shared ReadOnly Property TotalCount As Integer
        Get
            Return ListHouse.Count
        End Get
    End Property

    ' Returns the house at the specified index. 
    Public Shared ReadOnly Property HouseByIndex(ByVal index As Integer) As House
        Get
            Return ListHouse.Item(index)
        End Get
    End Property

    'Get method return the Type of the house 
    Public ReadOnly Property Type As String
        Get
            Return _Type
        End Get
    End Property

    'Get method return the ID of the house
    Public ReadOnly Property ID As String
        Get
            Return _ID
        End Get
    End Property

    'Get method return the number of rooms of the house
    Public ReadOnly Property Rooms As Integer
        Get
            Return _Room
        End Get
    End Property

    'Get method return the number of garages of the house
    Public ReadOnly Property Garages As Integer
        Get
            Return _Garages
        End Get
    End Property

    'Get method return the price of the house
    Public ReadOnly Property Price As Single
        Get
            Return _Price
        End Get
    End Property

    ' Modifies number of rooms and number of garages, and hence
    ' the price of the house if both parameters are valid.
    Public MustOverride Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)

    'Define PriceChanged event 
    Public Event PriceChanged()

    'Method to raise the event while in the subclass
    Protected Sub RaiseEventFromBaseClass()
        RaiseEvent PriceChanged()
    End Sub

    Protected Sub RaiseEventHouseListUpdate()
        RaiseEvent HouseListUpdated()
    End Sub
End Class
