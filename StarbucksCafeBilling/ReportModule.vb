Imports MySql.Data.MySqlClient
Imports ClosedXML.Excel

Module ReportModule

    Public Sub ExportToExcel()

        Try

            Dim path As String =
                Environment.GetFolderPath(
                    Environment.SpecialFolder.Desktop
                ) &
                "\Cafe_Report_" &
                DateTime.Now.ToString(
                    "yyyyMMdd_HHmmss"
                ) &
                ".xlsx"

            DB.Open()

            ' ================= QUERY =================
            Dim cmd As New MySqlCommand(
                "SELECT 
                    b.bill_id,
                    b.bill_date,
                    b.created_by,
                    b.payment_method,
                    b.upi_id,
                    b.card_holder,
                    bi.item_name,
                    bi.qty,
                    bi.price,
                    (bi.qty * bi.price) AS total
                 FROM bills b
                 INNER JOIN bill_items bi
                 ON b.bill_id = bi.bill_id
                 ORDER BY b.bill_id",
                DB.conn
            )

            Dim reader As MySqlDataReader =
                cmd.ExecuteReader()

            ' ================= EXCEL =================
            Dim wb As New XLWorkbook()

            Dim ws =
                wb.Worksheets.Add(
                    "Cafe Report"
                )

            ' ================= TITLE =================
            ws.Range("A1:J1").Merge()

            ws.Cell(1, 1).Value =
                "STARBUCKS CAFE SALES REPORT"

            ws.Cell(1, 1).Style.Font.Bold = True

            ws.Cell(1, 1).Style.Font.FontSize = 18

            ws.Cell(1, 1).Style.Font.FontColor =
                XLColor.White

            ws.Cell(1, 1).Style.Fill.BackgroundColor =
                XLColor.DarkGreen

            ws.Cell(1, 1).Style.Alignment.Horizontal =
                XLAlignmentHorizontalValues.Center

            ' ================= HEADERS =================
            Dim headers As String() = {
                "Bill ID",
                "Date",
                "Cashier",
                "Payment",
                "UPI ID",
                "Card Holder",
                "Item",
                "Qty",
                "Price",
                "Total"
            }

            For i As Integer = 0 To headers.Length - 1

                ws.Cell(3, i + 1).Value =
                    headers(i)

                ws.Cell(3, i + 1).Style.Font.Bold =
                    True

                ws.Cell(3, i + 1).Style.Fill.BackgroundColor =
                    XLColor.DarkBlue

                ws.Cell(3, i + 1).Style.Font.FontColor =
                    XLColor.White

            Next

            ' ================= DATA =================
            Dim row As Integer = 4

            While reader.Read()

                ws.Cell(row, 1).Value =
                    reader("bill_id").ToString()

                ws.Cell(row, 2).Value =
                    Convert.ToDateTime(
                        reader("bill_date")
                    )

                ws.Cell(row, 2).Style.DateFormat.Format =
                    "dd-MM-yyyy HH:mm:ss"

                ws.Cell(row, 3).Value =
                    reader("created_by").ToString()

                ws.Cell(row, 4).Value =
                    reader("payment_method").ToString()

                ws.Cell(row, 5).Value =
                    reader("upi_id").ToString()

                ws.Cell(row, 6).Value =
                    reader("card_holder").ToString()

                ws.Cell(row, 7).Value =
                    reader("item_name").ToString()

                ws.Cell(row, 8).Value =
                    reader("qty").ToString()

                ws.Cell(row, 9).Value =
                    Convert.ToDecimal(
                        reader("price")
                    )

                ws.Cell(row, 10).Value =
                    Convert.ToDecimal(
                        reader("total")
                    )

                ' Currency format
                ws.Cell(row, 9).Style.NumberFormat.Format =
                    "₹ #,##0.00"

                ws.Cell(row, 10).Style.NumberFormat.Format =
                    "₹ #,##0.00"

                row += 1

            End While

            reader.Close()

            DB.Close()

            ' ================= STYLE =================
            ws.Columns().AdjustToContents()

            ws.RangeUsed().Style.Border.OutsideBorder =
                XLBorderStyleValues.Thin

            ws.RangeUsed().Style.Border.InsideBorder =
                XLBorderStyleValues.Thin

            ' ================= SAVE =================
            wb.SaveAs(path)

            MessageBox.Show(
                "Professional Excel Report Exported!" &
                vbNewLine &
                vbNewLine &
                path
            )

        Catch ex As Exception

            MessageBox.Show(
                ex.Message
            )

        End Try

    End Sub

End Module