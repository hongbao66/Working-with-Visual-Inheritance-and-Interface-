'----------------------------------------------
' Name: Quang Tran
' Date: 02/25/14
' Description: Program3
'              Class PlattevilleHouse
'----------------------------------------------
Imports UWPCS3340
Public Class FormClassMDI
    Dim aform As FormClassHouse
    Dim List As FormClassList
    Dim countBranch = 1


    'Cascade the window forms within the MDI
    Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    'What happened when the MDI form is loading
    Private Sub FormClassMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel3.Text = Now.ToString
        aform = New FormClassHouse
        List = New FormClassList
        List.MdiParent = Me
        aform.ListForm = List
        List.MainForm = aform
        aform.MdiParent = Me
        aform.Show()
    End Sub

    'timer that used to display the clock
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel3.Text = Now.ToString
    End Sub

    ''Create new branch and show it on the form
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim newform = New FormClassBranch()
        newform.BranchNo = countBranch
        newform.MdiParent = Me
        newform.Show()
        countBranch += 1
    End Sub

    'terminate the program
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Application.Exit()
    End Sub

    'arrange icon
    Private Sub ArrangeIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    'arrange the Tital in Vertical
    Private Sub TileVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    'arrange the Tital in Horizontal
    Private Sub TileHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    'Cascade the child forms 
    Private Sub CascadeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

End Class