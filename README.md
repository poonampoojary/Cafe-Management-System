# ☕ Cafe Management System

A desktop-based **Cafe Management System** developed using **C# and Microsoft Access Database**. The application is designed to simplify cafe operations such as managing menu items, processing customer orders, generating bills, recording transactions, and allowing customers to place orders as guests.

---

## 📖 Overview

The **Cafe Management System** provides a simple and user-friendly interface for managing daily cafe operations. It helps organize menu items, customer orders, billing, and transaction records efficiently.

The system also includes **guest ordering functionality**, allowing customers to place orders without creating or logging into an account.

---

## ✨ Key Features

### 🏠 Main Dashboard

The main dashboard provides easy access to different modules of the Cafe Management System.

### 🍔 Menu Item Management

- Add new food and beverage items.
- View available menu items.
- Update existing item details.
- Manage item prices and availability.

### 🛒 Order Management

- Create new customer orders.
- Select multiple menu items.
- Automatically calculate the total order amount.
- Manage and track customer orders.

### 👤 Guest Ordering

- Customers can place orders as guests.
- No account registration or login is required.
- Guests can browse available menu items and place orders easily.

### 🧾 Billing

- Automatically calculates the total bill based on selected items.
- Displays order details and total amount.
- Simplifies the checkout and billing process.

### 💳 Transaction Management

- Stores transaction information.
- Maintains records of completed orders.
- Helps track previous transactions.

### 🗄️ Database Integration

The application uses a **Microsoft Access Database** to store and manage:

- Menu items
- Customer orders
- Guest orders
- Billing information
- Transaction records

---

## 🛠️ Tech Stack

- **Programming Language:** C#
- **Framework:** .NET Framework
- **Application Type:** Windows Forms Desktop Application
- **Database:** Microsoft Access
- **IDE:** Microsoft Visual Studio
- **Database Connectivity:** OleDb

---

## 📂 Project Structure

```text
CAFE MANAGEMENT 2/
│
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
│
├── GUESTFORM.cs
├── GUESTFORM.Designer.cs
├── GUESTFORM.resx
│
├── ITEM.cs
├── ITEM.Designer.cs
├── ITEM.resx
│
├── Database1DataSet.xsd
├── Database1DataSet.xsc
├── Database1DataSet.xss
│
├── Program.cs
├── App.config
└── README.md
```

---

## ⚙️ Prerequisites

Before running the project, ensure that the following software is installed:

- Microsoft Visual Studio
- .NET Framework
- Microsoft Access or Microsoft Access Database Engine
- Windows Operating System

---

## 🚀 How to Run the Project

### 1. Clone or Download the Repository

Download the project files to your computer.

### 2. Open the Project in Visual Studio

Open the solution file:

```text
CAFE MANAGEMENT 2.sln
```

### 3. Check the Database Connection

Ensure that the Microsoft Access database file is available and that the connection string points to the correct database location.

### 4. Build the Project

In Visual Studio, select:

```text
Build → Build Solution
```

### 5. Run the Application

Press:

```text
F5
```

Or click the **Start** button in Visual Studio.

---

## 🔄 System Workflow

The basic workflow of the system is:

```text
Start Application
        ↓
Open Main Dashboard
        ↓
View Menu Items
        ↓
Select Items
        ↓
Place Customer or Guest Order
        ↓
Calculate Total Bill
        ↓
Complete Transaction
        ↓
Store Order Details in Database
```

---

## 🗃️ Database

The project uses **Microsoft Access Database** for storing application data.

The database manages information related to:

- Menu items
- Orders
- Guest orders
- Bills
- Transactions

The C# application communicates with the Microsoft Access database using **OleDb database connectivity**.

---

## 🎯 Purpose of the Project

The purpose of this project is to demonstrate the development of a database-driven desktop application using **C#, Windows Forms, and Microsoft Access**.

The system demonstrates concepts such as:

- Graphical User Interface development
- Event-driven programming
- Database connectivity
- CRUD operations
- Order processing
- Billing calculations
- Transaction management

---

## 🔮 Future Enhancements

Possible future improvements include:

- User authentication and role-based access
- Online ordering functionality
- Inventory and stock management
- Digital payment integration
- Sales analytics and reporting
- Receipt generation and printing
- Migration from Microsoft Access to SQL Server or MySQL
- Web-based or mobile version of the application

---

## 👩‍💻 Author

Developed as an academic project to demonstrate the practical implementation of **C#, Windows Forms, Microsoft Access database connectivity, order management, guest ordering, billing, and transaction operations**.
