# Inventory Management System (WinForms | C# | .NET Framework 4.8)

A Windows desktop **Inventory Management System** built using **C# WinForms** and **SQL Server LocalDB** (ADO.NET).  
It provides basic CRUD operations for common inventory modules like products, categories, customers, users, and orders.

---

## ✨ Features

- ✅ Login screen
- ✅ Dashboard / main window navigation (WinForms)
- ✅ Category management (Add / Edit / Delete)
- ✅ Product management (Add / Edit / Delete)
- ✅ Customer management (Add / Edit / Delete)
- ✅ User management (Add / Edit / Delete)
- ✅ Order management
- ✅ SQL Server LocalDB integration using `SqlConnection`, `SqlCommand`, `SqlDataAdapter`

---

## 🧰 Tech Stack

- **Language:** C#
- **UI:** Windows Forms (WinForms)
- **Framework:** .NET Framework **4.8**
- **Database:** SQL Server **LocalDB** (MSSQLLocalDB)
- **Data Access:** ADO.NET (`System.Data.SqlClient`)

---

## 📁 Project Structure (main files)

- `Program.cs` → Application entry point (starts `WelcomeForm`)
- `WelcomeForm.cs` → Splash / welcome screen
- `LoginForm.cs` → Login UI + DB check
- `ProductForm.cs`, `CategoryForm.cs`, `CustomerForm.cs`, `UserForm.cs`, `OrderForm.cs` → Main modules
- `*ModuleForm.cs` → Add/Edit dialog forms

---

## ✅ Requirements

- Windows 10/11
- **Visual Studio 2019/2022** (with .NET desktop development workload)
- **.NET Framework 4.8 Developer Pack**
- SQL Server LocalDB (usually installed with Visual Studio)

---

## 🚀 How to Run (Visual Studio)

1. Clone the repository
2. Open `InventoryManagementSystem.csproj` in Visual Studio
3. Build & Run (Start button)

---

## 🖥️ Run / Build from Console (commands to type)

### OutPuts

<img width="1036" height="788" alt="Screenshot 2026-01-15 174440" src="https://github.com/user-attachments/assets/0942f42d-6db6-4bd4-a6a4-acc050c59df4" />

<img width="593" height="683" alt="Screenshot 2026-01-15 174356" src="https://github.com/user-attachments/assets/06759676-6421-44c0-bffd-322f42d57e64" />

<img width="1182" height="742" alt="Screenshot 2026-01-15 174505" src="https://github.com/user-attachments/assets/6d7ec4d0-1058-49c1-b7e0-1501af473881" />

<img width="1122" height="737" alt="Screenshot 2026-01-15 174648" src="https://github.com/user-attachments/assets/ba0bc49f-d021-4071-957a-b937a2edc899" />

<img width="1021" height="664" alt="Screenshot 2026-01-15 174750" src="https://github.com/user-attachments/assets/380b3c00-1675-478a-b289-f829979f3333" />







git clone <your-repo-url>
cd InventoryManagementSystem
