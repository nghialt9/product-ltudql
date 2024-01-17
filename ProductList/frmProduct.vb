Public Class frmProduct
    Private lstProduct As List(Of Product)

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstProduct = New List(Of Product)

        Dim product = New Product()
        product.Code = "PRO001"
        product.Name = "Keo"
        product.Price = 200000
        lstProduct.Add(product)

        product = New Product()
        product.Code = "PRO002"
        product.Name = "Khan"
        product.Price = 300000
        lstProduct.Add(product)

        product = New Product()
        product.Code = "PRO003"
        product.Name = "Kiem"
        product.Price = 400000
        lstProduct.Add(product)

        For Each product In lstProduct
            Dim str = String.Format("{0} - {1} - {2}", product.Code, product.Name, product.Price)
            lbProduct.Items.Add(str)
        Next
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim product = New Product()
        product.Code = txtCode.Text
        product.Name = txtName.Text
        product.Price = txtPrice.Text
        lstProduct.Add(product)

        Dim str = String.Format("{0} - {1} - {2}", product.Code, product.Name, product.Price)
        lbProduct.Items.Add(str)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If lbProduct.SelectedIndex >= 0 Then
            Dim index = lbProduct.SelectedIndex
            Dim product = lstProduct(index)

            product.Code = txtCode.Text
            product.Name = txtName.Text
            product.Price = txtPrice.Text

            lbProduct.Items.RemoveAt(index)
            Dim str = String.Format("{0} - {1} - {2}", product.Code, product.Name, product.Price)
            lbProduct.Items.Insert(index, str)
        Else
            MessageBox.Show("Vui lòng chọn sản phẩm cần sửa", "Thông báo")
        End If
    End Sub

    Private Sub lbProduct_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbProduct.SelectedIndexChanged
        Dim index = lbProduct.SelectedIndex
        Dim product = lstProduct(index)

        txtCode.Text = product.Code
        txtName.Text = product.Name
        txtPrice.Text = product.Price
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lbProduct.SelectedIndex >= 0 Then
            Dim index = lbProduct.SelectedIndex
            Dim product = lstProduct(index)
            Dim isConfirm = MessageBox.Show(String.Format("Bạn có muốn xóa sản phẩm {0} - {1}", product.Code, product.Name), "Thông báo", MessageBoxButtons.YesNo)
            If isConfirm = DialogResult.Yes Then
                lbProduct.Items.RemoveAt(index)
                lstProduct.RemoveAt(index)
            End If
        Else
            MessageBox.Show("Vui lòng chọn sản phẩm cần xóa", "Thông báo")
        End If
    End Sub
End Class