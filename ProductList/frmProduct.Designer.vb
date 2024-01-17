<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProduct
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
        lbProduct = New ListBox()
        lblCode = New Label()
        lblName = New Label()
        lblPrice = New Label()
        txtCode = New TextBox()
        txtName = New TextBox()
        txtPrice = New TextBox()
        btnAdd = New Button()
        btnDelete = New Button()
        btnUpdate = New Button()
        SuspendLayout()
        ' 
        ' lbProduct
        ' 
        lbProduct.FormattingEnabled = True
        lbProduct.ItemHeight = 15
        lbProduct.Location = New Point(11, 8)
        lbProduct.Name = "lbProduct"
        lbProduct.Size = New Size(384, 424)
        lbProduct.TabIndex = 0
        ' 
        ' lblCode
        ' 
        lblCode.AutoSize = True
        lblCode.Location = New Point(442, 28)
        lblCode.Name = "lblCode"
        lblCode.Size = New Size(35, 15)
        lblCode.TabIndex = 1
        lblCode.Text = "Code"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(442, 93)
        lblName.Name = "lblName"
        lblName.Size = New Size(39, 15)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(442, 163)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 1
        lblPrice.Text = "Price"
        ' 
        ' txtCode
        ' 
        txtCode.Location = New Point(528, 25)
        txtCode.Name = "txtCode"
        txtCode.Size = New Size(217, 23)
        txtCode.TabIndex = 2
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(528, 90)
        txtName.Name = "txtName"
        txtName.Size = New Size(217, 23)
        txtName.TabIndex = 2
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(528, 160)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(217, 23)
        txtPrice.TabIndex = 2
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(442, 224)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(670, 224)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(556, 224)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' frmProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnUpdate)
        Controls.Add(btnDelete)
        Controls.Add(btnAdd)
        Controls.Add(txtPrice)
        Controls.Add(txtName)
        Controls.Add(txtCode)
        Controls.Add(lblPrice)
        Controls.Add(lblName)
        Controls.Add(lblCode)
        Controls.Add(lbProduct)
        Name = "frmProduct"
        Text = "frmProduct"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbProduct As ListBox
    Friend WithEvents lblCode As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtCode As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
End Class
