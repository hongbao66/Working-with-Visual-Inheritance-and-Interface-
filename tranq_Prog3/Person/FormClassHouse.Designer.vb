<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassHouse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoTwoRooms = New System.Windows.Forms.RadioButton()
        Me.rdoThreeRooms = New System.Windows.Forms.RadioButton()
        Me.rdoFourRooms = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoOneGarage = New System.Windows.Forms.RadioButton()
        Me.rdoTwoGarages = New System.Windows.Forms.RadioButton()
        Me.rdoThreeGarages = New System.Windows.Forms.RadioButton()
        Me.cboCityName = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.BtnModify = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.AllError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.AllError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(44, 205)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(121, 20)
        Me.txtId.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrice.Location = New System.Drawing.Point(44, 267)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = true
        Me.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(83, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(83, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(83, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoTwoRooms)
        Me.GroupBox1.Controls.Add(Me.rdoThreeRooms)
        Me.GroupBox1.Controls.Add(Me.rdoFourRooms)
        Me.GroupBox1.Enabled = false
        Me.GroupBox1.Location = New System.Drawing.Point(261, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 100)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Rooms"
        '
        'rdoTwoRooms
        '
        Me.rdoTwoRooms.AutoSize = true
        Me.rdoTwoRooms.Location = New System.Drawing.Point(220, 42)
        Me.rdoTwoRooms.Name = "rdoTwoRooms"
        Me.rdoTwoRooms.Size = New System.Drawing.Size(31, 17)
        Me.rdoTwoRooms.TabIndex = 2
        Me.rdoTwoRooms.TabStop = true
        Me.rdoTwoRooms.Text = "2"
        Me.rdoTwoRooms.UseVisualStyleBackColor = true
        '
        'rdoThreeRooms
        '
        Me.rdoThreeRooms.AutoSize = true
        Me.rdoThreeRooms.Location = New System.Drawing.Point(110, 42)
        Me.rdoThreeRooms.Name = "rdoThreeRooms"
        Me.rdoThreeRooms.Size = New System.Drawing.Size(31, 17)
        Me.rdoThreeRooms.TabIndex = 1
        Me.rdoThreeRooms.TabStop = true
        Me.rdoThreeRooms.Text = "3"
        Me.rdoThreeRooms.UseVisualStyleBackColor = true
        '
        'rdoFourRooms
        '
        Me.rdoFourRooms.AutoSize = true
        Me.rdoFourRooms.Location = New System.Drawing.Point(6, 42)
        Me.rdoFourRooms.Name = "rdoFourRooms"
        Me.rdoFourRooms.Size = New System.Drawing.Size(31, 17)
        Me.rdoFourRooms.TabIndex = 0
        Me.rdoFourRooms.TabStop = true
        Me.rdoFourRooms.Text = "4"
        Me.rdoFourRooms.UseVisualStyleBackColor = true
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoOneGarage)
        Me.GroupBox2.Controls.Add(Me.rdoTwoGarages)
        Me.GroupBox2.Controls.Add(Me.rdoThreeGarages)
        Me.GroupBox2.Enabled = false
        Me.GroupBox2.Location = New System.Drawing.Point(261, 224)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(310, 100)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Garages"
        '
        'rdoOneGarage
        '
        Me.rdoOneGarage.AutoSize = true
        Me.rdoOneGarage.Location = New System.Drawing.Point(214, 56)
        Me.rdoOneGarage.Name = "rdoOneGarage"
        Me.rdoOneGarage.Size = New System.Drawing.Size(31, 17)
        Me.rdoOneGarage.TabIndex = 2
        Me.rdoOneGarage.TabStop = true
        Me.rdoOneGarage.Text = "1"
        Me.rdoOneGarage.UseVisualStyleBackColor = true
        '
        'rdoTwoGarages
        '
        Me.rdoTwoGarages.AutoSize = true
        Me.rdoTwoGarages.Location = New System.Drawing.Point(110, 56)
        Me.rdoTwoGarages.Name = "rdoTwoGarages"
        Me.rdoTwoGarages.Size = New System.Drawing.Size(31, 17)
        Me.rdoTwoGarages.TabIndex = 1
        Me.rdoTwoGarages.TabStop = true
        Me.rdoTwoGarages.Text = "2"
        Me.rdoTwoGarages.UseVisualStyleBackColor = true
        '
        'rdoThreeGarages
        '
        Me.rdoThreeGarages.AutoSize = true
        Me.rdoThreeGarages.Location = New System.Drawing.Point(6, 56)
        Me.rdoThreeGarages.Name = "rdoThreeGarages"
        Me.rdoThreeGarages.Size = New System.Drawing.Size(31, 17)
        Me.rdoThreeGarages.TabIndex = 0
        Me.rdoThreeGarages.TabStop = true
        Me.rdoThreeGarages.Text = "3"
        Me.rdoThreeGarages.UseVisualStyleBackColor = true
        '
        'cboCityName
        '
        Me.cboCityName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCityName.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboCityName.FormattingEnabled = true
        Me.cboCityName.Items.AddRange(New Object() {"Chicago", "Madison", "Platteville"})
        Me.cboCityName.Location = New System.Drawing.Point(44, 154)
        Me.cboCityName.Name = "cboCityName"
        Me.cboCityName.Size = New System.Drawing.Size(121, 21)
        Me.cboCityName.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(64, 326)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'BtnModify
        '
        Me.BtnModify.Enabled = false
        Me.BtnModify.Location = New System.Drawing.Point(371, 353)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(75, 23)
        Me.BtnModify.TabIndex = 10
        Me.BtnModify.Text = "MODIFY"
        Me.BtnModify.UseVisualStyleBackColor = true
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(607, 131)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 11
        Me.btnList.Text = "LIST"
        Me.btnList.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(607, 241)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'AllError
        '
        Me.AllError.ContainerControl = Me
        '
        'FormClassHouse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 452)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cboCityName)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtId)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormClassHouse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program3(Quang Tran)"
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.AllError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoTwoRooms As System.Windows.Forms.RadioButton
    Friend WithEvents rdoThreeRooms As System.Windows.Forms.RadioButton
    Friend WithEvents rdoFourRooms As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoOneGarage As System.Windows.Forms.RadioButton
    Friend WithEvents rdoTwoGarages As System.Windows.Forms.RadioButton
    Friend WithEvents rdoThreeGarages As System.Windows.Forms.RadioButton
    Friend WithEvents cboCityName As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
    Friend WithEvents AllError As System.Windows.Forms.ErrorProvider
    Protected WithEvents btnExit As System.Windows.Forms.Button
    Protected WithEvents btnList As System.Windows.Forms.Button

End Class
