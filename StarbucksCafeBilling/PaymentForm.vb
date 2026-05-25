Imports QRCoder
Public Class PaymentForm
    Public BillAmount As Decimal
    Public PaymentMethod As String = ""

    Public UPIID As String = ""

    Public CardNumber As String = ""

    Public CardHolder As String = ""

    Private Sub PaymentForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        cmbPayment.Items.Add("Cash")
        cmbPayment.Items.Add("UPI")
        cmbPayment.Items.Add("Card")
        cmbPayment.Items.Add("QR")
        cmbPayment.SelectedIndex = 0

        HideFields()

    End Sub

    Private Sub HideFields()

        lblUPI.Visible = False
        txtUPI.Visible = False

        lblCard.Visible = False
        txtCard.Visible = False

        lblHolder.Visible = False
        txtHolder.Visible = False
        picQR.Visible = False

    End Sub

    Private Sub cmbPayment_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbPayment.SelectedIndexChanged

        HideFields()

        If cmbPayment.Text = "UPI" Then

            lblUPI.Visible = True
            txtUPI.Visible = True

        ElseIf cmbPayment.Text = "Card" Then

            lblCard.Visible = True
            txtCard.Visible = True

            lblHolder.Visible = True
            txtHolder.Visible = True

        End If
        If cmbPayment.Text = "QR" Then

            GenerateQRCode()

        End If

    End Sub

    Private Sub btnConfirm_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnConfirm.Click

        PaymentMethod = cmbPayment.Text

        UPIID = txtUPI.Text.Trim()

        CardNumber = txtCard.Text.Trim()

        CardHolder = txtHolder.Text.Trim()

        If PaymentMethod = "UPI" And UPIID = "" Then

            MessageBox.Show("Enter UPI ID")

            Exit Sub

        End If

        If PaymentMethod = "Card" Then

            If CardNumber = "" Or CardHolder = "" Then

                MessageBox.Show("Enter Card Details")

                Exit Sub

            End If

        End If

        Me.DialogResult = DialogResult.OK

        Me.Close()

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
    Private Sub GenerateQRCode()

        Try

            Dim upiLink As String =
                "upi://pay?pa=jatinacharya69@okicici" &
                "&pn=StarbucksCafe" &
                "&am=" & BillAmount.ToString("0.00") &
                "&cu=INR"

            Dim generator As New QRCodeGenerator()

            Dim data =
                generator.CreateQrCode(
                    upiLink,
                    QRCodeGenerator.ECCLevel.Q
                )

            Dim code As New QRCode(data)

            picQR.Image =
                code.GetGraphic(6)

            picQR.Visible = True

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub picQR_Click(sender As Object, e As EventArgs) Handles picQR.Click

    End Sub
End Class