Imports System.Drawing
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.DataVisualization.Charting

Public Class DashboardForm

    ' ================= FORM LOAD =================
    Private Sub DashboardForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ' ================= FORM THEME =================
        Me.BackColor =
            Color.FromArgb(8, 18, 37)

        ' ================= CHART THEME =================
        salesChart.BackColor =
            Color.FromArgb(15, 23, 42)

        salesChart.ChartAreas(0).BackColor =
            Color.FromArgb(15, 23, 42)

        salesChart.ChartAreas(0).AxisX.LabelStyle.ForeColor =
            Color.White

        salesChart.ChartAreas(0).AxisY.LabelStyle.ForeColor =
            Color.White

        salesChart.ChartAreas(0).AxisX.LineColor =
            Color.FromArgb(30, 41, 59)

        salesChart.ChartAreas(0).AxisY.LineColor =
            Color.FromArgb(30, 41, 59)

        salesChart.ChartAreas(0).AxisX.MajorGrid.LineColor =
            Color.FromArgb(30, 41, 59)

        salesChart.ChartAreas(0).AxisY.MajorGrid.LineColor =
            Color.FromArgb(30, 41, 59)

        salesChart.ChartAreas(0).AxisX.LabelStyle.Font =
            New Font("Segoe UI", 10, FontStyle.Bold)

        salesChart.ChartAreas(0).AxisY.LabelStyle.Font =
            New Font("Segoe UI", 10, FontStyle.Bold)

        salesChart.Legends.Clear()

        Dim legend As New Legend()

        legend.BackColor =
            Color.FromArgb(15, 23, 42)

        legend.ForeColor = Color.White

        salesChart.Legends.Add(legend)

        ' ================= FILTER =================
        cmbFilter.Items.Clear()

        cmbFilter.Items.Add("Today Sales")
        cmbFilter.Items.Add("All Time Sales")

        cmbFilter.SelectedIndex = 0

        cmbFilter.BackColor =
            Color.FromArgb(30, 41, 59)

        cmbFilter.ForeColor =
            Color.White

        cmbFilter.FlatStyle = FlatStyle.Flat

        ' ================= PANEL COLORS =================
        pnlRevenue.BackColor =
            Color.FromArgb(19, 34, 56)

        pnlBills.BackColor =
            Color.FromArgb(19, 34, 56)

        pnlTopItem.BackColor =
            Color.FromArgb(19, 34, 56)

        pnlItems.BackColor =
            Color.FromArgb(19, 34, 56)

        ' ================= PANEL BORDER STYLE =================
        pnlRevenue.BorderStyle = BorderStyle.FixedSingle

        pnlBills.BorderStyle = BorderStyle.FixedSingle

        pnlTopItem.BorderStyle = BorderStyle.FixedSingle

        pnlItems.BorderStyle = BorderStyle.FixedSingle

        ' ================= LABEL COLORS =================
        lblRevenue.ForeColor = Color.White

        lblBills.ForeColor = Color.White

        lblTopItem.ForeColor = Color.White

        lblItemsSold.ForeColor = Color.White

        ' ================= BUTTON COLORS =================
        btnBilling.BackColor =
            Color.FromArgb(239, 68, 68)

        btnBillHistory.BackColor =
            Color.FromArgb(239, 68, 68)

        btnLogout.BackColor =
            Color.FromArgb(239, 68, 68)

        btnBilling.ForeColor = Color.White

        btnBillHistory.ForeColor = Color.White

        btnLogout.ForeColor = Color.White

        btnBilling.FlatStyle = FlatStyle.Flat

        btnBillHistory.FlatStyle = FlatStyle.Flat

        btnLogout.FlatStyle = FlatStyle.Flat

        btnBilling.FlatAppearance.BorderSize = 0

        btnBillHistory.FlatAppearance.BorderSize = 0

        btnLogout.FlatAppearance.BorderSize = 0

        ' ================= LOAD =================
        LoadStats()

        LoadChart()

    End Sub

    ' ================= LOAD CHART =================
    Private Sub LoadChart()

        Try

            DB.Open()

            Dim query As String = ""

            ' ================= TODAY SALES =================
            If cmbFilter.Text = "Today Sales" Then

                query =
                "SELECT 
                    bi.item_name,
                    SUM(bi.qty) AS total_qty
                 FROM bill_items bi
                 INNER JOIN bills b
                 ON bi.bill_id = b.bill_id
                 WHERE DATE(b.bill_date)=CURDATE()
                 GROUP BY bi.item_name
                 ORDER BY total_qty DESC
                 LIMIT 5"

            Else

                ' ================= ALL TIME SALES =================
                query =
                "SELECT 
                    item_name,
                    SUM(qty) AS total_qty
                 FROM bill_items
                 GROUP BY item_name
                 ORDER BY total_qty DESC
                 LIMIT 5"

            End If

            Dim cmd As New MySqlCommand(
                query,
                DB.conn
            )

            Dim reader As MySqlDataReader =
                cmd.ExecuteReader()

            salesChart.Series.Clear()

            Dim series As New Series()

            series.Name = cmbFilter.Text

            series.ChartType =
                SeriesChartType.Column

            series.Color =
                Color.FromArgb(22, 163, 74)

            series.BorderWidth = 0

            series.IsValueShownAsLabel = True

            series.LabelForeColor =
                Color.White

            series.Font =
                New Font("Segoe UI", 10, FontStyle.Bold)

            salesChart.Series.Add(series)

            While reader.Read()

                series.Points.AddXY(
                    reader("item_name").ToString(),
                    Convert.ToInt32(
                        reader("total_qty")
                    )
                )

            End While

            reader.Close()

            DB.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    ' ================= LOAD STATS =================
    Private Sub LoadStats()

        Try

            DB.Open()

            ' ================= REVENUE =================
            Dim revenueQuery As String = ""

            If cmbFilter.Text = "Today Sales" Then

                revenueQuery =
                    "SELECT IFNULL(SUM(total),0)
                     FROM bills
                     WHERE DATE(bill_date)=CURDATE()"

            Else

                revenueQuery =
                    "SELECT IFNULL(SUM(total),0)
                     FROM bills"

            End If

            Dim cmdRevenue As New MySqlCommand(
                revenueQuery,
                DB.conn
            )

            Dim revenue As Decimal =
                Convert.ToDecimal(
                    cmdRevenue.ExecuteScalar()
                )

            lblRevenue.Text =
                "Revenue : ₹ " &
                revenue.ToString("0.00")

            ' ================= TOTAL BILLS =================
            Dim billsQuery As String = ""

            If cmbFilter.Text = "Today Sales" Then

                billsQuery =
                    "SELECT COUNT(*)
                     FROM bills
                     WHERE DATE(bill_date)=CURDATE()"

            Else

                billsQuery =
                    "SELECT COUNT(*)
                     FROM bills"

            End If

            Dim cmdBills As New MySqlCommand(
                billsQuery,
                DB.conn
            )

            Dim bills As Integer =
                Convert.ToInt32(
                    cmdBills.ExecuteScalar()
                )

            lblBills.Text =
                "Bills : " &
                bills.ToString()

            ' ================= TOP ITEM =================
            Dim topQuery As String = ""

            If cmbFilter.Text = "Today Sales" Then

                topQuery =
                    "SELECT bi.item_name
                     FROM bill_items bi
                     INNER JOIN bills b
                     ON bi.bill_id=b.bill_id
                     WHERE DATE(b.bill_date)=CURDATE()
                     GROUP BY bi.item_name
                     ORDER BY SUM(bi.qty) DESC
                     LIMIT 1"

            Else

                topQuery =
                    "SELECT item_name
                     FROM bill_items
                     GROUP BY item_name
                     ORDER BY SUM(qty) DESC
                     LIMIT 1"

            End If

            Dim cmdTop As New MySqlCommand(
                topQuery,
                DB.conn
            )

            Dim topItem As Object =
                cmdTop.ExecuteScalar()

            If topItem IsNot Nothing Then

                lblTopItem.Text =
                    "Top Item : " &
                    topItem.ToString()

            Else

                lblTopItem.Text =
                    "Top Item : None"

            End If

            ' ================= TOTAL ITEMS SOLD =================
            Dim itemsQuery As String = ""

            If cmbFilter.Text = "Today Sales" Then

                itemsQuery =
                    "SELECT IFNULL(SUM(bi.qty),0)
                     FROM bill_items bi
                     INNER JOIN bills b
                     ON bi.bill_id=b.bill_id
                     WHERE DATE(b.bill_date)=CURDATE()"

            Else

                itemsQuery =
                    "SELECT IFNULL(SUM(qty),0)
                     FROM bill_items"

            End If

            Dim cmdItems As New MySqlCommand(
                itemsQuery,
                DB.conn
            )

            Dim totalItems As Integer =
                Convert.ToInt32(
                    cmdItems.ExecuteScalar()
                )

            lblItemsSold.Text =
                "Items Sold : " &
                totalItems.ToString()

            DB.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    ' ================= FILTER CHANGE =================
    Private Sub cmbFilter_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbFilter.SelectedIndexChanged

        LoadStats()

        LoadChart()

    End Sub

    ' ================= BILLING =================
    Private Sub btnBilling_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBilling.Click

        StarbucksBilling.Show()

    End Sub

    ' ================= BILL HISTORY =================
    Private Sub btnBillHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBillHistory.Click

        Dim f As New BillHistoryForm()

        f.Show()

    End Sub

    ' ================= LOGOUT =================
    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        Me.Hide()

        LoginForm.Show()

    End Sub

End Class