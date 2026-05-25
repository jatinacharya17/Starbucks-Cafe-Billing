Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class BillHistoryForm

    ' ================= VARIABLES =================
    Private WithEvents printDoc As New PrintDocument()

    Private billText As String = ""

    ' ================= FORM LOAD =================
    Private Sub BillHistoryForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' ================= FORM =================
        Me.StartPosition =
            FormStartPosition.CenterScreen

        Me.Size =
            New Size(1200, 700)

        Me.BackColor =
            Color.FromArgb(8, 18, 37)

        Me.Text = "Bill History"

        ' ================= TITLE =================
        lblBillTitle.ForeColor =
            Color.White

        lblBillTitle.Font =
            New Font(
                "Segoe UI",
                24,
                FontStyle.Bold
            )

        ' ================= SEARCH LABEL =================
        lblSearch.ForeColor =
            Color.White

        lblSearch.Font =
            New Font(
                "Segoe UI",
                11,
                FontStyle.Bold
            )

        ' ================= TEXTBOX =================
        txtSearch.BackColor =
            Color.FromArgb(19, 34, 56)

        txtSearch.ForeColor =
            Color.White

        txtSearch.BorderStyle =
            BorderStyle.FixedSingle

        txtSearch.Font =
            New Font(
                "Segoe UI",
                11
            )

        ' ================= DATAGRIDVIEW =================
        dgvBills.BackgroundColor =
            Color.FromArgb(15, 23, 42)

        dgvBills.BorderStyle =
            BorderStyle.None

        dgvBills.EnableHeadersVisualStyles =
            False

        dgvBills.ColumnHeadersBorderStyle =
            DataGridViewHeaderBorderStyle.None

        dgvBills.ColumnHeadersDefaultCellStyle.BackColor =
            Color.FromArgb(19, 34, 56)

        dgvBills.ColumnHeadersDefaultCellStyle.ForeColor =
            Color.White

        dgvBills.ColumnHeadersDefaultCellStyle.Font =
            New Font(
                "Segoe UI",
                11,
                FontStyle.Bold
            )

        dgvBills.DefaultCellStyle.BackColor =
            Color.FromArgb(15, 23, 42)

        dgvBills.DefaultCellStyle.ForeColor =
            Color.White

        dgvBills.DefaultCellStyle.SelectionBackColor =
            Color.FromArgb(22, 163, 74)

        dgvBills.DefaultCellStyle.SelectionForeColor =
            Color.White

        dgvBills.DefaultCellStyle.Font =
            New Font(
                "Segoe UI",
                10
            )

        dgvBills.RowTemplate.Height = 35

        dgvBills.RowHeadersVisible = False

        dgvBills.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect

        dgvBills.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        dgvBills.GridColor =
            Color.FromArgb(30, 41, 59)

        dgvBills.CellBorderStyle =
            DataGridViewCellBorderStyle.SingleHorizontal

        dgvBills.ReadOnly = True

        dgvBills.AllowUserToAddRows = False

        dgvBills.AllowUserToResizeRows = False

        ' ================= BUTTON DESIGN =================
        StyleButton(
            btnSearch,
            Color.FromArgb(22, 163, 74)
        )

        StyleButton(
            btnRefresh,
            Color.FromArgb(30, 41, 59)
        )

        StyleButton(
            btnReprint,
            Color.FromArgb(22, 163, 74)
        )

        StyleButton(
            btnClose,
            Color.FromArgb(239, 68, 68)
        )

        ' ================= LOAD DATA =================
        LoadBills()

    End Sub

    ' ================= BUTTON STYLE =================
    Private Sub StyleButton(
        btn As Button,
        clr As Color
    )

        btn.BackColor = clr

        btn.ForeColor = Color.White

        btn.FlatStyle = FlatStyle.Flat

        btn.FlatAppearance.BorderSize = 0

        btn.Cursor = Cursors.Hand

        btn.Font =
            New Font(
                "Segoe UI",
                10,
                FontStyle.Bold
            )

    End Sub

    ' ================= LOAD BILLS =================
    Private Sub LoadBills()

        Try

            DB.Open()

            Dim da As New MySqlDataAdapter(
    "SELECT 
        b.bill_id,
        b.bill_date,
        GROUP_CONCAT(
            CONCAT(
                bi.item_name,
                ' x',
                bi.qty
            )
            SEPARATOR ', '
        ) AS items,
        b.total,
        b.created_by,
        b.payment_method
     FROM bills b
     LEFT JOIN bill_items bi
        ON b.bill_id = bi.bill_id
     GROUP BY b.bill_id
     ORDER BY b.bill_id DESC",
    DB.conn
)

            Dim dt As New DataTable()

            da.Fill(dt)


            dgvBills.DataSource = dt
            If dgvBills.Columns.Count > 2 Then

                dgvBills.Columns(2).Width = 350

            End If

            DB.Close()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub

    ' ================= SEARCH =================
    Private Sub btnSearch_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSearch.Click

        Try

            DB.Open()

            Dim da As New MySqlDataAdapter(
    "SELECT 
        b.bill_id,
        b.bill_date,
        GROUP_CONCAT(
            CONCAT(
                bi.item_name,
                ' x',
                bi.qty
            )
            SEPARATOR ', '
        ) AS items,
        b.total,
        b.created_by,
        b.payment_method
     FROM bills b
     LEFT JOIN bill_items bi
        ON b.bill_id = bi.bill_id
     GROUP BY b.bill_id
     ORDER BY b.bill_id DESC",
    DB.conn
)

            da.SelectCommand.Parameters.AddWithValue(
                "@id",
                "%" & txtSearch.Text & "%"
            )

            Dim dt As New DataTable()

            da.Fill(dt)

            dgvBills.DataSource = dt

            If dgvBills.Columns.Count > 2 Then

                dgvBills.Columns(2).Width = 350

            End If

            DB.Close()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub

    ' ================= REFRESH =================
    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        txtSearch.Clear()

        LoadBills()

    End Sub

    ' ================= CLOSE =================
    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClose.Click

        Me.Close()

    End Sub

    ' ================= REPRINT BILL =================
    Private Sub btnReprint_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReprint.Click

        Try

            If dgvBills.SelectedRows.Count = 0 Then

                MessageBox.Show(
                    "Please select a bill first."
                )

                Exit Sub

            End If

            Dim billId As Integer =
                Convert.ToInt32(
                    dgvBills.SelectedRows(0).
                    Cells("bill_id").Value
                )

            DB.Open()

            ' ================= BILL DETAILS =================
            Dim billCmd As New MySqlCommand(
                "SELECT * FROM bills
                 WHERE bill_id=@id",
                DB.conn
            )

            billCmd.Parameters.AddWithValue(
                "@id",
                billId
            )

            Dim billReader As MySqlDataReader =
                billCmd.ExecuteReader()

            Dim cashier As String = ""
            Dim paymentMethod As String = ""
            Dim upiId As String = ""
            Dim cardHolder As String = ""

            If billReader.Read() Then

                cashier =
                    billReader("created_by").ToString()

                paymentMethod =
                    billReader("payment_method").ToString()

                upiId =
                    billReader("upi_id").ToString()

                cardHolder =
                    billReader("card_holder").ToString()

            End If

            billReader.Close()

            ' ================= BILL ITEMS =================
            Dim cmd As New MySqlCommand(
                "SELECT * FROM bill_items
                 WHERE bill_id=@id",
                DB.conn
            )

            cmd.Parameters.AddWithValue(
                "@id",
                billId
            )

            Dim reader As MySqlDataReader =
                cmd.ExecuteReader()

            billText = ""

            billText &= "================================" &
                vbNewLine

            billText &= "       STARBUCKS CAFE BILL" &
                vbNewLine

            billText &= "================================" &
                vbNewLine & vbNewLine

            billText &= "Bill ID : " &
                billId &
                vbNewLine

            billText &= "Reprinted On : " &
                DateTime.Now.ToString(
                    "dd-MM-yyyy HH:mm:ss"
                ) &
                vbNewLine

            billText &= "Cashier : " &
                cashier &
                vbNewLine

            billText &= "Payment : " &
                paymentMethod &
                vbNewLine

            If paymentMethod = "UPI" Then

                billText &= "UPI ID : " &
                    upiId &
                    vbNewLine

            End If

            If paymentMethod = "Card" Then

                billText &= "Card Holder : " &
                    cardHolder &
                    vbNewLine

            End If

            billText &= vbNewLine

            billText &= "Item        Qty     Total" &
                vbNewLine

            billText &= "--------------------------------" &
                vbNewLine

            Dim subtotal As Decimal = 0

            While reader.Read()

                Dim item As String =
                    reader("item_name").ToString()

                Dim qty As Integer =
                    Convert.ToInt32(
                        reader("qty")
                    )

                Dim price As Decimal =
                    Convert.ToDecimal(
                        reader("price")
                    )

                Dim total As Decimal =
                    qty * price

                subtotal += total

                billText &= item.PadRight(12)

                billText &= qty.ToString().
                    PadRight(8)

                billText &= total.ToString("0.00")

                billText &= vbNewLine

            End While

            Dim gst As Decimal =
                subtotal * 0.05D

            Dim grandTotal As Decimal =
                subtotal + gst

            billText &= "--------------------------------" &
                vbNewLine

            billText &= "Subtotal : ₹ " &
                subtotal.ToString("0.00") &
                vbNewLine

            billText &= "GST (5%) : ₹ " &
                gst.ToString("0.00") &
                vbNewLine

            billText &= "GRAND TOTAL : ₹ " &
                grandTotal.ToString("0.00") &
                vbNewLine

            billText &= "================================" &
                vbNewLine

            billText &= "      THANK YOU VISIT AGAIN ☕"

            reader.Close()

            DB.Close()

            ' ================= PRINT =================
            Dim ps As New Printing.PageSettings()

            ps.PaperSize =
                New Printing.PaperSize(
                    "Receipt",
                    280,
                    700
                )

            ps.Margins =
                New Printing.Margins(
                    5,
                    5,
                    5,
                    5
                )

            printDoc.DefaultPageSettings = ps

            Dim preview As New PrintPreviewDialog()

            preview.Document = printDoc

            preview.Width = 500

            preview.Height = 700

            preview.PrintPreviewControl.Zoom = 1.0

            preview.ShowDialog()

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub

    ' ================= PRINT =================
    Private Sub printDoc_PrintPage(
        sender As Object,
        e As PrintPageEventArgs
    ) Handles printDoc.PrintPage

        Dim font As New Font(
            "Consolas",
            11
        )

        e.Graphics.DrawString(
            billText,
            font,
            Brushes.Black,
            10,
            10
        )

    End Sub

    Private Sub dgvBills_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBills.CellContentClick

    End Sub

    Private Sub lblBillTitle_Click(sender As Object, e As EventArgs) Handles lblBillTitle.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class