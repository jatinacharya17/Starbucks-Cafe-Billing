# Starbucks Cafe Billing & Management System

````md
# ☕ Starbucks Cafe Billing & Management System

A modern desktop-based Cafe Billing & Management System developed using **VB.NET**, **MySQL**, and **Windows Forms**.  
The system is designed to streamline cafe operations including billing, payment processing, sales tracking, and owner dashboard analytics with a professional Starbucks-inspired UI.

---

## 📌 Features

### 🧾 Smart Billing System
- Dynamic menu management
- Add/remove items from cart
- Quantity management
- Automatic GST calculation
- Real-time total updates
- Instant bill generation
- Receipt printing support

### 💳 Advanced Payment System
- Cash Payment
- UPI Payment
- Card Payment
- QR Payment Support
- UPI ID storage
- Card details management
- Payment tracking in database

### 📊 Owner Dashboard
- Total Revenue Tracking
- Today's Sales Analytics
- Best Selling Item Detection
- Total Bills Generated
- Total Items Sold
- Interactive Sales Charts

### 📁 Bill History Management
- Search bills using Bill ID
- View ordered items
- Payment method tracking
- Reprint old receipts
- Sales history management

### 📤 Excel Report Export
- Export sales records to Excel
- Properly formatted reports
- Payment information included
- Auto-generated billing reports

---

## 🛠 Technologies Used

| Technology | Purpose |
|------------|----------|
| VB.NET | Application Development |
| Windows Forms | User Interface |
| MySQL | Database Management |
| Guna UI / WinForms UI | Modern UI Design |
| ADO.NET | Database Connectivity |
| Git & GitHub | Version Control |

---

## 🗄 Database Structure

The project uses a normalized MySQL relational database containing:

### 1️⃣ users
Stores:
- User login credentials
- Roles (Owner/Admin)

### 2️⃣ bills
Stores:
- Bill details
- Payment method
- UPI/Card information
- Total amount
- Cashier details

### 3️⃣ bill_items
Stores:
- Ordered items
- Quantity
- Price
- Bill linkage

---

## 🔗 Database Relationships

- One User ➜ Many Bills
- One Bill ➜ Many Bill Items

---

## 🎨 UI Highlights

- Starbucks-inspired dark theme
- Professional dashboard design
- Responsive billing interface
- Modern analytics charts
- Premium POS-style layout

---

## 👨‍💻 Team Contribution

### 👤 Jatin Acharya
- Billing System Development
- Payment Gateway Logic
- QR Payment Integration
- Bill History Module
- Excel Export System
- Database Linking
- Receipt Printing
- Dashboard Analytics

### 👤 Abhishek
- Login System
- Starbucks Theme Design
- Dashboard UI Design
- Database Assistance

---

## 📷 Screenshots

### 🖥 Dashboard
- Revenue Analytics
- Top Selling Items
- Sales Graphs

### 🧾 Billing System
- Dynamic Menu
- Cart System
- Checkout Interface

### 💳 Payment Form
- Multiple Payment Methods
- QR Payment Support

### 📁 Bill History
- Search & Reprint Bills
- Payment Tracking

---

## 🚀 How to Run

### 1️⃣ Clone Repository

```bash
git clone YOUR_REPOSITORY_LINK
````

### 2️⃣ Open Project

Open:

```text
StarbucksCafeBilling.sln
```

in Visual Studio.

### 3️⃣ Configure Database

Import MySQL database and update connection string in:

```vb
DB.vb
```

### 4️⃣ Run Application

Press:

```text
F5
```

---

## 📈 Future Enhancements

* Online Ordering System
* Customer Loyalty Program
* Barcode Scanner Integration
* Cloud Database Support
* Inventory Management
* Mobile App Integration

---

## 📄 License

This project is developed for educational and academic purposes.

---

# ☕ Developed with Passion by

## Jatin Acharya & Abhishek

```
```
