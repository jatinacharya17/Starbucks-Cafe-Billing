<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashboardForm
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlRevenue = New System.Windows.Forms.Panel()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.pnlBills = New System.Windows.Forms.Panel()
        Me.lblBills = New System.Windows.Forms.Label()
        Me.pnlTopItem = New System.Windows.Forms.Panel()
        Me.lblTopItem = New System.Windows.Forms.Label()
        Me.pnlItems = New System.Windows.Forms.Panel()
        Me.lblItemsSold = New System.Windows.Forms.Label()
        Me.salesChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnBilling = New System.Windows.Forms.Button()
        Me.btnBillHistory = New System.Windows.Forms.Button()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.pnlRevenue.SuspendLayout()
        Me.pnlBills.SuspendLayout()
        Me.pnlTopItem.SuspendLayout()
        Me.pnlItems.SuspendLayout()
        CType(Me.salesChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(6, 12)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(555, 41)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "☕ STARBUCKS OWNER DASHBOARD"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(814, 16)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(98, 37)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "LOGOUT"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlRevenue
        '
        Me.pnlRevenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlRevenue.Controls.Add(Me.lblRevenue)
        Me.pnlRevenue.Location = New System.Drawing.Point(22, 117)
        Me.pnlRevenue.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlRevenue.Name = "pnlRevenue"
        Me.pnlRevenue.Size = New System.Drawing.Size(188, 98)
        Me.pnlRevenue.TabIndex = 2
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRevenue.ForeColor = System.Drawing.Color.White
        Me.lblRevenue.Location = New System.Drawing.Point(8, 37)
        Me.lblRevenue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(110, 21)
        Me.lblRevenue.TabIndex = 0
        Me.lblRevenue.Text = "Revenue : ₹ 0"
        '
        'pnlBills
        '
        Me.pnlBills.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlBills.Controls.Add(Me.lblBills)
        Me.pnlBills.Location = New System.Drawing.Point(232, 117)
        Me.pnlBills.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlBills.Name = "pnlBills"
        Me.pnlBills.Size = New System.Drawing.Size(188, 98)
        Me.pnlBills.TabIndex = 3
        '
        'lblBills
        '
        Me.lblBills.AutoSize = True
        Me.lblBills.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBills.ForeColor = System.Drawing.Color.White
        Me.lblBills.Location = New System.Drawing.Point(8, 37)
        Me.lblBills.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBills.Name = "lblBills"
        Me.lblBills.Size = New System.Drawing.Size(63, 21)
        Me.lblBills.TabIndex = 0
        Me.lblBills.Text = "Bills : 0"
        '
        'pnlTopItem
        '
        Me.pnlTopItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlTopItem.Controls.Add(Me.lblTopItem)
        Me.pnlTopItem.Location = New System.Drawing.Point(452, 117)
        Me.pnlTopItem.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlTopItem.Name = "pnlTopItem"
        Me.pnlTopItem.Size = New System.Drawing.Size(197, 98)
        Me.pnlTopItem.TabIndex = 4
        '
        'lblTopItem
        '
        Me.lblTopItem.AutoSize = True
        Me.lblTopItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopItem.ForeColor = System.Drawing.Color.White
        Me.lblTopItem.Location = New System.Drawing.Point(8, 37)
        Me.lblTopItem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTopItem.Name = "lblTopItem"
        Me.lblTopItem.Size = New System.Drawing.Size(101, 21)
        Me.lblTopItem.TabIndex = 0
        Me.lblTopItem.Text = "Top Item : --"
        '
        'pnlItems
        '
        Me.pnlItems.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.pnlItems.Controls.Add(Me.lblItemsSold)
        Me.pnlItems.Location = New System.Drawing.Point(674, 117)
        Me.pnlItems.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlItems.Name = "pnlItems"
        Me.pnlItems.Size = New System.Drawing.Size(188, 98)
        Me.pnlItems.TabIndex = 5
        '
        'lblItemsSold
        '
        Me.lblItemsSold.AutoSize = True
        Me.lblItemsSold.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemsSold.ForeColor = System.Drawing.Color.White
        Me.lblItemsSold.Location = New System.Drawing.Point(8, 37)
        Me.lblItemsSold.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblItemsSold.Name = "lblItemsSold"
        Me.lblItemsSold.Size = New System.Drawing.Size(111, 21)
        Me.lblItemsSold.TabIndex = 0
        Me.lblItemsSold.Text = "Items Sold : 0"
        '
        'salesChart
        '
        Me.salesChart.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        ChartArea2.Name = "ChartArea1"
        Me.salesChart.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.salesChart.Legends.Add(Legend2)
        Me.salesChart.Location = New System.Drawing.Point(22, 263)
        Me.salesChart.Margin = New System.Windows.Forms.Padding(2)
        Me.salesChart.Name = "salesChart"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.salesChart.Series.Add(Series2)
        Me.salesChart.Size = New System.Drawing.Size(840, 244)
        Me.salesChart.TabIndex = 6
        Me.salesChart.Text = "salesChart"
        '
        'btnBilling
        '
        Me.btnBilling.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBilling.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBilling.ForeColor = System.Drawing.Color.White
        Me.btnBilling.Location = New System.Drawing.Point(712, 16)
        Me.btnBilling.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBilling.Name = "btnBilling"
        Me.btnBilling.Size = New System.Drawing.Size(98, 37)
        Me.btnBilling.TabIndex = 7
        Me.btnBilling.Text = "Bill System"
        Me.btnBilling.UseVisualStyleBackColor = False
        '
        'btnBillHistory
        '
        Me.btnBillHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnBillHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBillHistory.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillHistory.ForeColor = System.Drawing.Color.White
        Me.btnBillHistory.Location = New System.Drawing.Point(610, 16)
        Me.btnBillHistory.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBillHistory.Name = "btnBillHistory"
        Me.btnBillHistory.Size = New System.Drawing.Size(98, 37)
        Me.btnBillHistory.TabIndex = 8
        Me.btnBillHistory.Text = "Bill History"
        Me.btnBillHistory.UseVisualStyleBackColor = False
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(22, 71)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(121, 21)
        Me.cmbFilter.TabIndex = 9
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(923, 551)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.btnBillHistory)
        Me.Controls.Add(Me.btnBilling)
        Me.Controls.Add(Me.salesChart)
        Me.Controls.Add(Me.pnlItems)
        Me.Controls.Add(Me.pnlTopItem)
        Me.Controls.Add(Me.pnlBills)
        Me.Controls.Add(Me.pnlRevenue)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Location = New System.Drawing.Point(30, 250)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "DashboardForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OWNER DASHBOARD"
        Me.pnlRevenue.ResumeLayout(False)
        Me.pnlRevenue.PerformLayout()
        Me.pnlBills.ResumeLayout(False)
        Me.pnlBills.PerformLayout()
        Me.pnlTopItem.ResumeLayout(False)
        Me.pnlTopItem.PerformLayout()
        Me.pnlItems.ResumeLayout(False)
        Me.pnlItems.PerformLayout()
        CType(Me.salesChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnLogout As Button
    Friend WithEvents pnlRevenue As Panel
    Friend WithEvents lblRevenue As Label
    Friend WithEvents pnlBills As Panel
    Friend WithEvents lblBills As Label
    Friend WithEvents pnlTopItem As Panel
    Friend WithEvents lblTopItem As Label
    Friend WithEvents pnlItems As Panel
    Friend WithEvents lblItemsSold As Label
    Friend WithEvents salesChart As DataVisualization.Charting.Chart
    Friend WithEvents btnBilling As Button
    Friend WithEvents btnBillHistory As Button
    Friend WithEvents cmbFilter As ComboBox
End Class
