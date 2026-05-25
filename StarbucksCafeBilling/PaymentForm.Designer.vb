<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbPayment = New System.Windows.Forms.ComboBox()
        Me.lblUPI = New System.Windows.Forms.Label()
        Me.txtUPI = New System.Windows.Forms.TextBox()
        Me.lblCard = New System.Windows.Forms.Label()
        Me.txtCard = New System.Windows.Forms.TextBox()
        Me.lblHolder = New System.Windows.Forms.Label()
        Me.txtHolder = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblBillTitle = New System.Windows.Forms.Label()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(94, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(261, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Payment Details"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Mode Of Payment"
        '
        'cmbPayment
        '
        Me.cmbPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbPayment.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPayment.ForeColor = System.Drawing.Color.White
        Me.cmbPayment.FormattingEnabled = True
        Me.cmbPayment.Location = New System.Drawing.Point(16, 144)
        Me.cmbPayment.Name = "cmbPayment"
        Me.cmbPayment.Size = New System.Drawing.Size(250, 28)
        Me.cmbPayment.TabIndex = 2
        '
        'lblUPI
        '
        Me.lblUPI.AutoSize = True
        Me.lblUPI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUPI.ForeColor = System.Drawing.Color.White
        Me.lblUPI.Location = New System.Drawing.Point(12, 184)
        Me.lblUPI.Name = "lblUPI"
        Me.lblUPI.Size = New System.Drawing.Size(126, 20)
        Me.lblUPI.TabIndex = 3
        Me.lblUPI.Text = "Customer UPI ID"
        '
        'txtUPI
        '
        Me.txtUPI.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtUPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUPI.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPI.ForeColor = System.Drawing.Color.White
        Me.txtUPI.Location = New System.Drawing.Point(16, 218)
        Me.txtUPI.Name = "txtUPI"
        Me.txtUPI.Size = New System.Drawing.Size(300, 27)
        Me.txtUPI.TabIndex = 4
        '
        'lblCard
        '
        Me.lblCard.AutoSize = True
        Me.lblCard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCard.ForeColor = System.Drawing.Color.White
        Me.lblCard.Location = New System.Drawing.Point(12, 260)
        Me.lblCard.Name = "lblCard"
        Me.lblCard.Size = New System.Drawing.Size(103, 20)
        Me.lblCard.TabIndex = 5
        Me.lblCard.Text = "Card Number"
        '
        'txtCard
        '
        Me.txtCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCard.ForeColor = System.Drawing.Color.White
        Me.txtCard.Location = New System.Drawing.Point(16, 297)
        Me.txtCard.Name = "txtCard"
        Me.txtCard.Size = New System.Drawing.Size(300, 27)
        Me.txtCard.TabIndex = 6
        '
        'lblHolder
        '
        Me.lblHolder.AutoSize = True
        Me.lblHolder.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolder.ForeColor = System.Drawing.Color.White
        Me.lblHolder.Location = New System.Drawing.Point(16, 345)
        Me.lblHolder.Name = "lblHolder"
        Me.lblHolder.Size = New System.Drawing.Size(138, 20)
        Me.lblHolder.TabIndex = 7
        Me.lblHolder.Text = "Card Holder Name"
        '
        'txtHolder
        '
        Me.txtHolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.txtHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHolder.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHolder.ForeColor = System.Drawing.Color.White
        Me.txtHolder.Location = New System.Drawing.Point(16, 381)
        Me.txtHolder.Name = "txtHolder"
        Me.txtHolder.Size = New System.Drawing.Size(300, 27)
        Me.txtHolder.TabIndex = 8
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(140, 648)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(180, 45)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'picQR
        '
        Me.picQR.BackColor = System.Drawing.Color.White
        Me.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picQR.Location = New System.Drawing.Point(140, 442)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(180, 180)
        Me.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picQR.TabIndex = 11
        Me.picQR.TabStop = False
        Me.picQR.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblBillTitle)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 90)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StarbucksCafeBilling.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(20, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblBillTitle
        '
        Me.lblBillTitle.AutoSize = True
        Me.lblBillTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBillTitle.ForeColor = System.Drawing.Color.White
        Me.lblBillTitle.Location = New System.Drawing.Point(100, 28)
        Me.lblBillTitle.Name = "lblBillTitle"
        Me.lblBillTitle.Size = New System.Drawing.Size(333, 32)
        Me.lblBillTitle.TabIndex = 3
        Me.lblBillTitle.Text = "STARBUCKS CAFE | Payment"
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 721)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picQR)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtHolder)
        Me.Controls.Add(Me.lblHolder)
        Me.Controls.Add(Me.txtCard)
        Me.Controls.Add(Me.lblCard)
        Me.Controls.Add(Me.txtUPI)
        Me.Controls.Add(Me.lblUPI)
        Me.Controls.Add(Me.cmbPayment)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "PaymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaymentForm"
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPayment As ComboBox
    Friend WithEvents lblUPI As Label
    Friend WithEvents txtUPI As TextBox
    Friend WithEvents lblCard As Label
    Friend WithEvents txtCard As TextBox
    Friend WithEvents lblHolder As Label
    Friend WithEvents txtHolder As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents picQR As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblBillTitle As Label
End Class
