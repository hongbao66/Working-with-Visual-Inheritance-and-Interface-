'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class FormClassBranch
'----------------------------------------------
Imports UWPCS3340
Public Class FormClassBranch
    Private BranchNumber As Integer
    Private frmList As FormClassList

    'Set the value of Branch Number to value
    Public WriteOnly Property BranchNo
        Set(value)
            BranchNumber = value
            Me.Text = "Branch #" & BranchNumber
            btnExit.Text = "UNLOAD"
        End Set
    End Property

    'Only close this form when user hit unload
    Protected Overrides Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmList.Close()
    End Sub

    'WHen A branch is loading
    Private Sub FormClassBranch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmList = New FormClassList
        frmList.MainForm = Me
        frmList.Text = "Branch #" & BranchNumber
        frmList.MdiParent = Me.MdiParent

    End Sub

    'SHow ListForm and Hide this form
    Protected Overrides Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Me.Hide()
        frmList.Show()
        frmList.BringToFront()
    End Sub
End Class
