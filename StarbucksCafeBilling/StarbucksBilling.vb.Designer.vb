<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StarbucksBilling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.topBar = New System.Windows.Forms.Panel()
        Me.btnDesserts = New System.Windows.Forms.Button()
        Me.btnFood = New System.Windows.Forms.Button()
        Me.btnDrinks = New System.Windows.Forms.Button()
        Me.btnCoffee = New System.Windows.Forms.Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.menuPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.dgvCart = New System.Windows.Forms.DataGridView()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblGST = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.sidebar = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnBillHistory = New System.Windows.Forms.Button()
        Me.topBar.SuspendLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'topBar
        '
        Me.topBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.topBar.Controls.Add(Me.btnDesserts)
        Me.topBar.Controls.Add(Me.btnFood)
        Me.topBar.Controls.Add(Me.btnDrinks)
        Me.topBar.Controls.Add(Me.btnCoffee)
        Me.topBar.Controls.Add(Me.lblMenu)
        Me.topBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.topBar.Location = New System.Drawing.Point(285, 0)
        Me.topBar.Margin = New System.Windows.Forms.Padding(2)
        Me.topBar.Name = "topBar"
        Me.topBar.Size = New System.Drawing.Size(788, 81)
        Me.topBar.TabIndex = 14
        '
        'btnDesserts
        '
        Me.btnDesserts.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesserts.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDesserts.ForeColor = System.Drawing.Color.White
        Me.btnDesserts.Location = New System.Drawing.Point(652, 15)
        Me.btnDesserts.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDesserts.Name = "btnDesserts"
        Me.btnDesserts.Size = New System.Drawing.Size(98, 32)
        Me.btnDesserts.TabIndex = 4
        Me.btnDesserts.Text = "🍰 Desserts"
        Me.btnDesserts.UseVisualStyleBackColor = False
        '
        'btnFood
        '
        Me.btnFood.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFood.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFood.ForeColor = System.Drawing.Color.White
        Me.btnFood.Location = New System.Drawing.Point(540, 15)
        Me.btnFood.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFood.Name = "btnFood"
        Me.btnFood.Size = New System.Drawing.Size(98, 32)
        Me.btnFood.TabIndex = 3
        Me.btnFood.Text = "🍔 Food"
        Me.btnFood.UseVisualStyleBackColor = False
        '
        'btnDrinks
        '
        Me.btnDrinks.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDrinks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDrinks.ForeColor = System.Drawing.Color.White
        Me.btnDrinks.Location = New System.Drawing.Point(428, 15)
        Me.btnDrinks.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDrinks.Name = "btnDrinks"
        Me.btnDrinks.Size = New System.Drawing.Size(98, 32)
        Me.btnDrinks.TabIndex = 2
        Me.btnDrinks.Text = "🧋 Drinks"
        Me.btnDrinks.UseVisualStyleBackColor = False
        '
        'btnCoffee
        '
        Me.btnCoffee.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCoffee.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoffee.ForeColor = System.Drawing.Color.White
        Me.btnCoffee.Location = New System.Drawing.Point(315, 15)
        Me.btnCoffee.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCoffee.Name = "btnCoffee"
        Me.btnCoffee.Size = New System.Drawing.Size(98, 32)
        Me.btnCoffee.TabIndex = 1
        Me.btnCoffee.Text = "☕ Coffee"
        Me.btnCoffee.UseVisualStyleBackColor = False
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.White
        Me.lblMenu.Location = New System.Drawing.Point(57, 15)
        Me.lblMenu.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(86, 32)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "MENU"
        '
        'menuPanel
        '
        Me.menuPanel.AutoScroll = True
        Me.menuPanel.Location = New System.Drawing.Point(290, 81)
        Me.menuPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.menuPanel.Name = "menuPanel"
        Me.menuPanel.Size = New System.Drawing.Size(657, 422)
        Me.menuPanel.TabIndex = 15
        '
        'dgvCart
        '
        Me.dgvCart.BackgroundColor = System.Drawing.Color.White
        Me.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem, Me.colPrice, Me.colQty, Me.colTotal})
        Me.dgvCart.Location = New System.Drawing.Point(951, 81)
        Me.dgvCart.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCart.Name = "dgvCart"
        Me.dgvCart.RowHeadersWidth = 51
        Me.dgvCart.RowTemplate.Height = 24
        Me.dgvCart.Size = New System.Drawing.Size(490, 418)
        Me.dgvCart.TabIndex = 0
        '
        'colItem
        '
        Me.colItem.HeaderText = "Item"
        Me.colItem.MinimumWidth = 6
        Me.colItem.Name = "colItem"
        Me.colItem.Width = 125
        '
        'colPrice
        '
        Me.colPrice.HeaderText = "Price"
        Me.colPrice.MinimumWidth = 6
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Width = 125
        '
        'colQty
        '
        Me.colQty.HeaderText = "Qty"
        Me.colQty.MinimumWidth = 6
        Me.colQty.Name = "colQty"
        Me.colQty.Width = 125
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.MinimumWidth = 6
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Width = 125
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Gold
        Me.lblTotal.Location = New System.Drawing.Point(900, 577)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(76, 51)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "₹ 0"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubtotal.ForeColor = System.Drawing.Color.White
        Me.lblSubtotal.Location = New System.Drawing.Point(900, 520)
        Me.lblSubtotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(98, 20)
        Me.lblSubtotal.TabIndex = 16
        Me.lblSubtotal.Text = "Subtotal: ₹ 0"
        '
        'lblGST
        '
        Me.lblGST.AutoSize = True
        Me.lblGST.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGST.ForeColor = System.Drawing.Color.White
        Me.lblGST.Location = New System.Drawing.Point(900, 544)
        Me.lblGST.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGST.Name = "lblGST"
        Me.lblGST.Size = New System.Drawing.Size(105, 20)
        Me.lblGST.TabIndex = 17
        Me.lblGST.Text = "GST (5%): ₹ 0"
        '
        'btnCheckout
        '
        Me.btnCheckout.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckout.ForeColor = System.Drawing.Color.White
        Me.btnCheckout.Location = New System.Drawing.Point(900, 642)
        Me.btnCheckout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(120, 45)
        Me.btnCheckout.TabIndex = 18
        Me.btnCheckout.Text = "CHECKOUT"
        Me.btnCheckout.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(1035, 642)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(120, 45)
        Me.btnRemove.TabIndex = 19
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(1169, 642)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 45)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'sidebar
        '
        Me.sidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.sidebar.BackgroundImage = Global.StarbucksCafeBilling.My.Resources.Resources.Gemini_Generated_Image_gybzf7gybzf7gybz1
        Me.sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sidebar.Controls.Add(Me.btnLogout)
        Me.sidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebar.Location = New System.Drawing.Point(0, 0)
        Me.sidebar.Margin = New System.Windows.Forms.Padding(2)
        Me.sidebar.Name = "sidebar"
        Me.sidebar.Size = New System.Drawing.Size(285, 609)
        Me.sidebar.TabIndex = 13
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(65, 171)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(128, 50)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "🚪 Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnBillHistory
        '
        Me.btnBillHistory.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnBillHistory.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBillHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBillHistory.Location = New System.Drawing.Point(301, 532)
        Me.btnBillHistory.Name = "btnBillHistory"
        Me.btnBillHistory.Size = New System.Drawing.Size(120, 45)
        Me.btnBillHistory.TabIndex = 21
        Me.btnBillHistory.Text = "Bill History"
        Me.btnBillHistory.UseVisualStyleBackColor = False
        '
        'StarbucksBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1073, 609)
        Me.Controls.Add(Me.btnBillHistory)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.lblGST)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.dgvCart)
        Me.Controls.Add(Me.menuPanel)
        Me.Controls.Add(Me.topBar)
        Me.Controls.Add(Me.sidebar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StarbucksBilling"
        Me.Text = "STARBUCKS POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.topBar.ResumeLayout(False)
        Me.topBar.PerformLayout()
        CType(Me.dgvCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidebar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents topBar As Panel
    Friend WithEvents btnDesserts As Button
    Friend WithEvents btnFood As Button
    Friend WithEvents btnDrinks As Button
    Friend WithEvents btnCoffee As Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents menuPanel As FlowLayoutPanel
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents colItem As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colQty As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblGST As Label
    Friend WithEvents btnCheckout As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBillHistory As Button
End Class
