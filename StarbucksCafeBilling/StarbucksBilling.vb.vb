Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class StarbucksBilling

    ' ================= VARIABLES =================
    Private WithEvents printDoc As New PrintDocument()
    Private billText As String = ""



    '================= MENU =================
    Private coffeeMenu As New Dictionary(Of String, Decimal) From {
        {"Latte", 180},
        {"Cappuccino", 220},
        {"Espresso", 150},
        {"Americano", 170},
        {"Mocha", 260},
        {"Flat White", 240}
    }

    Private drinksMenu As New Dictionary(Of String, Decimal) From {
        {"Cold Coffee", 200},
        {"Blue Lagoon", 250},
        {"Mojito", 220},
        {"Chocolate Shake", 240},
        {"Oreo Shake", 280}
    }

    Private foodMenu As New Dictionary(Of String, Decimal) From {
        {"Burger", 299},
        {"Pizza", 499},
        {"Pasta", 320},
        {"French Fries", 150},
        {"Sandwich", 250}
    }

    Private dessertMenu As New Dictionary(Of String, Decimal) From {
        {"Brownie", 120},
        {"Cheesecake", 350},
        {"Donut", 140},
        {"Muffin", 160},
        {"Red Velvet", 320}
    }

    '' ================= FORM LOAD =================
    Private Sub StarbucksBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ================= DEFAULT MENU =================
        LoadMenu(coffeeMenu)
        dgvCart.Columns(2).ReadOnly = False
    End Sub
    'End Sub

    '' ================= CATEGORY CLICK =================
    Private Sub Category_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click, btnFood.Click, btnDesserts.Click

        Dim btn As Button = CType(sender, Button)

        If btn.Text.Contains("Coffee") Then
            LoadMenu(coffeeMenu)

        ElseIf btn.Text.Contains("Drinks") Then
            LoadMenu(drinksMenu)

        ElseIf btn.Text.Contains("Food") Then
            LoadMenu(foodMenu)

        ElseIf btn.Text.Contains("Desserts") Then
            LoadMenu(dessertMenu)

        End If

    End Sub



    ' ================= ADD ITEM =================
    Private Sub MenuItem_Click(sender As Object, e As EventArgs)

        Dim btn As Button = CType(sender, Button)

        Dim item =
            CType(btn.Tag, KeyValuePair(Of String, Decimal))

        AddToCart(item.Key, item.Value)

    End Sub

    ' ================= ADD TO CART =================
    Private Sub AddToCart(itemName As String, price As Decimal)

        Dim found As Boolean = False

        For Each row As DataGridViewRow In dgvCart.Rows

            If Not row.IsNewRow AndAlso row.Cells(0).Value IsNot Nothing Then

                If row.Cells(0).Value.ToString() = itemName Then

                    Dim qty As Integer =
                        Convert.ToInt32(row.Cells(2).Value)

                    qty += 1

                    row.Cells(2).Value = qty
                    row.Cells(3).Value = qty * price

                    found = True

                    Exit For

                End If

            End If

        Next

        If Not found Then
            dgvCart.Rows.Add(itemName, price, 1, price)
        End If

        CalculateTotal()

    End Sub

    ' ================= TOTAL =================
    Private Sub CalculateTotal()

        Dim subtotal As Decimal = 0

        For Each row As DataGridViewRow In dgvCart.Rows

            If Not row.IsNewRow AndAlso row.Cells(3).Value IsNot Nothing Then
                subtotal += Convert.ToDecimal(row.Cells(3).Value)
            End If

        Next

        Dim gst As Decimal = subtotal * 0.05D
        Dim grandTotal As Decimal = subtotal + gst

        lblSubtotal.Text = "Subtotal: ₹ " & subtotal.ToString("0.00")
        lblGST.Text = "GST (5%): ₹ " & gst.ToString("0.00")
        lblTotal.Text = "Grand Total: ₹ " & grandTotal.ToString("0.00")

    End Sub

    ' ================= PRINT =================
    Private Sub printDoc_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles printDoc.PrintPage

        Dim font As New Font("Consolas", 11)
        Dim brush As New SolidBrush(Color.Black)

        e.Graphics.DrawString(
        billText,
        font,
        brush,
        10,
        10
    )

    End Sub

    ' ================= LOAD MENU =================
    Private Sub LoadMenu(menu As Dictionary(Of String, Decimal))

        menuPanel.Controls.Clear()

        For Each item In menu

            Dim card As New Panel()

            card.Size = New Size(180, 180)
            card.BackColor = Color.FromArgb(30, 41, 59)
            card.Margin = New Padding(15)

            Dim lblItem As New Label()

            lblItem.Text = item.Key
            lblItem.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            lblItem.ForeColor = Color.White
            lblItem.AutoSize = True
            lblItem.Location = New Point(20, 40)

            Dim lblPrice As New Label()

            lblPrice.Text = "₹ " & item.Value
            lblPrice.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblPrice.ForeColor = Color.LimeGreen
            lblPrice.AutoSize = True
            lblPrice.Location = New Point(20, 80)

            Dim btnAdd As New Button()

            btnAdd.Text = "ADD"

            btnAdd.Size = New Size(120, 40)
            btnAdd.Location = New Point(25, 120)

            btnAdd.FlatStyle = FlatStyle.Flat
            btnAdd.FlatAppearance.BorderSize = 0

            btnAdd.BackColor = Color.FromArgb(22, 163, 74)
            btnAdd.ForeColor = Color.White

            btnAdd.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            btnAdd.Tag = item

            AddHandler btnAdd.Click, AddressOf MenuItem_Click

            card.Controls.Add(lblItem)
            card.Controls.Add(lblPrice)
            card.Controls.Add(btnAdd)

            menuPanel.Controls.Add(card)

        Next

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub BtnCheckout_Click_1(sender As Object, e As EventArgs) Handles btnCheckout.Click

        If dgvCart.Rows.Count = 0 Then
            MessageBox.Show("Cart is Empty!")
            Exit Sub
        End If

        Try

            ' ================= CONFIRM =================
            Dim result As DialogResult

            result = MessageBox.Show(
            "Confirm and Print Bill?",
            "Bill Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

            If result = DialogResult.No Then
                Exit Sub
            End If

            ' ================= PAYMENT FORM =================

            ' ================= SUBTOTAL =================
            Dim subtotal As Decimal = 0

            For Each row As DataGridViewRow In dgvCart.Rows

                If Not row.IsNewRow AndAlso row.Cells(3).Value IsNot Nothing Then

                    subtotal += Convert.ToDecimal(row.Cells(3).Value)

                End If

            Next

            ' ================= GST =================
            Dim gst As Decimal = subtotal * 0.05D

            Dim totalAmount As Decimal =
            subtotal + gst
            Dim payForm As New PaymentForm()
            payForm.BillAmount = totalAmount
            If payForm.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            DB.Open()


            ' ================= INSERT BILL =================
            Dim cmd As New MySqlCommand(
    "INSERT INTO bills(
        bill_date,
        total,
        created_by,
        payment_method,
        upi_id,
        card_number,
        card_holder
    )
    VALUES(
        @d,
        @t,
        @u,
        @pm,
        @upi,
        @card,
        @holder
    )",
    DB.conn
)

            cmd.Parameters.AddWithValue(
            "@d",
            DateTime.Now
        )

            cmd.Parameters.AddWithValue(
            "@t",
            totalAmount
        )

            cmd.Parameters.AddWithValue(
            "@u",
            SessionManager.LoggedInUser
        )
            cmd.Parameters.AddWithValue(
    "@pm",
    payForm.PaymentMethod
)

            cmd.Parameters.AddWithValue(
    "@upi",
    payForm.UPIID
)

            cmd.Parameters.AddWithValue(
    "@card",
    payForm.CardNumber
)

            cmd.Parameters.AddWithValue(
    "@holder",
    payForm.CardHolder
)

            cmd.ExecuteNonQuery()

            Dim billId As Integer =
            Convert.ToInt32(cmd.LastInsertedId)

            ' ================= INSERT ITEMS =================
            For Each row As DataGridViewRow In dgvCart.Rows

                If Not row.IsNewRow AndAlso
               row.Cells(0).Value IsNot Nothing Then

                    Dim cmd2 As New MySqlCommand(
                    "INSERT INTO bill_items(
                        bill_id,
                        item_name,
                        qty,
                        price
                    )
                    VALUES(
                        @b,
                        @i,
                        @q,
                        @p
                    )",
                    DB.conn
                )

                    cmd2.Parameters.AddWithValue(
                    "@b",
                    billId
                )

                    cmd2.Parameters.AddWithValue(
                    "@i",
                    row.Cells(0).Value.ToString()
                )

                    cmd2.Parameters.AddWithValue(
                    "@q",
                    Convert.ToInt32(row.Cells(2).Value)
                )

                    cmd2.Parameters.AddWithValue(
                    "@p",
                    Convert.ToDecimal(row.Cells(1).Value)
                )

                    cmd2.ExecuteNonQuery()

                End If

            Next

            DB.Close()

            ' ================= BILL TEXT =================
            billText = ""

            billText &= "================================" & vbNewLine
            billText &= "       STARBUCKS CAFE BILL" & vbNewLine
            billText &= "================================" & vbNewLine & vbNewLine
            billText &= "Bill ID : " &
    billId &
    vbNewLine

            billText &= "Date : " &
    DateTime.Now.ToString(
        "dd-MM-yyyy HH:mm:ss"
    ) &
    vbNewLine

            billText &= "Cashier : " &
    SessionManager.LoggedInUser &
    vbNewLine

            billText &= "Payment : " &
    payForm.PaymentMethod &
    vbNewLine
            billText &= "Payment : " &
    payForm.PaymentMethod &
    vbNewLine
            If payForm.PaymentMethod = "UPI" Then

                billText &= "UPI ID : " &
        payForm.UPIID &
        vbNewLine

            End If

            If payForm.PaymentMethod = "Card" Then

                billText &= "Card Holder : " &
        payForm.CardHolder &
        vbNewLine

            End If

            billText &= vbNewLine

            billText &= "Item        Qty     Total" &
            vbNewLine

            billText &= "--------------------------------" &
            vbNewLine

            For Each row As DataGridViewRow In dgvCart.Rows

                If Not row.IsNewRow Then

                    billText &= row.Cells(0).Value.ToString().
                    PadRight(12)

                    billText &= row.Cells(2).Value.ToString().
                    PadRight(8)

                    billText &= row.Cells(3).Value.ToString()

                    billText &= vbNewLine

                End If

            Next

            billText &= "--------------------------------" &
            vbNewLine

            billText &= "Subtotal : ₹ " &
            subtotal.ToString("0.00") &
            vbNewLine

            billText &= "GST (5%) : ₹ " &
            gst.ToString("0.00") &
            vbNewLine

            billText &= "GRAND TOTAL : ₹ " &
            totalAmount.ToString("0.00") &
            vbNewLine

            billText &= "================================" &
            vbNewLine

            billText &= "      THANK YOU VISIT AGAIN ☕"

            ' ================= PRINT SETTINGS =================
            Dim ps As New Printing.PageSettings()

            ps.PaperSize =
            New Printing.PaperSize(
                "Receipt",
                280,
                600
            )

            ps.Margins =
            New Printing.Margins(5, 5, 5, 5)

            printDoc.DefaultPageSettings = ps

            ' ================= PRINT PREVIEW =================
            Dim preview As New PrintPreviewDialog()

            preview.Document = printDoc

            preview.Width = 500
            preview.Height = 600

            preview.PrintPreviewControl.Zoom = 1.0

            preview.ShowDialog()

            ' ================= EXPORT =================
            ExportToExcel()

            ' ================= RESET =================
            MessageBox.Show(
            "Order Placed Successfully ☕"
        )

            dgvCart.Rows.Clear()

            lblSubtotal.Text = "Subtotal: ₹ 0.00"

            lblGST.Text = "GST (5%): ₹ 0.00"

            lblTotal.Text = "Grand Total: ₹ 0.00"

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnRemove_Click_1(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvCart.SelectedRows.Count > 0 Then

            dgvCart.Rows.RemoveAt(
                dgvCart.SelectedRows(0).Index
            )

            CalculateTotal()

        End If
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvCart.Rows.Clear()

        lblSubtotal.Text = "Subtotal: ₹ 0"
        lblGST.Text = "GST (5%): ₹ 0"
        lblTotal.Text = "Grand Total: ₹ 0"
    End Sub

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick

    End Sub

    Private Sub lblSubtotal_Click(sender As Object, e As EventArgs) Handles lblSubtotal.Click

    End Sub
    Private Sub dgvCart_CellEndEdit(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles dgvCart.CellEndEdit

        Try

            If e.ColumnIndex = 2 Then

                Dim row As DataGridViewRow =
                    dgvCart.Rows(e.RowIndex)

                Dim qty As Integer =
                    Convert.ToInt32(row.Cells(2).Value)

                Dim price As Decimal =
                    Convert.ToDecimal(row.Cells(1).Value)

                row.Cells(3).Value =
                    qty * price

                CalculateTotal()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnBillHistory_Click(sender As Object, e As EventArgs) Handles btnBillHistory.Click
        BillHistoryForm.Show()
    End Sub
End Class