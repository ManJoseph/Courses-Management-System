# 🎓 ELearningSystem - Course Management Application

<div align="center">
  
![ElearningSystem](https://github.com/user-attachments/assets/6529da51-809e-4ed9-8253-59ff08bbbfb8)

**My Beginner's Windows Forms desktop application for comprehensive course management in e-learning environments**

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)](https://www.microsoft.com/en-us/sql-server)
[![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)

</div>

---

## 📋 Table of Contents

- [Overview](#-overview)
- [Features](#-features)
- [Technology Stack](#-technology-stack)
- [Database Schema](#-database-schema)
- [Installation](#-installation)
- [Usage Guide](#-usage-guide)
- [Application Screenshots](#-application-screenshots)
- [Project Structure](#-project-structure)
- [Contributing](#-contributing)
- [License](#-license)

---

## 🎯 Overview

**ELearningSystem** is a robust Windows Forms desktop application designed to streamline course management for educational institutions. It provides an intuitive interface for administrators and instructors to perform comprehensive CRUD (Create, Read, Update, Delete) operations on course data with SQL Server backend integration.

<div align="center">
  
### 🔄 Complete Course Management Lifecycle

```
➕ Create → 📖 Read → ✏️ Update → 🗑️ Delete
```

</div>

---

## ✨ Features

### 🔐 **Simple User Authentication System**
- Secure user registration and login functionality
- Simple Password for security
- Role-based access (Admin, Instructor, Student) Are thought to be implemented in future

### 📚 **Course Management**
| Feature | Description |
|---------|-------------|
| **Add Courses** | Create new courses with complete details |
| **View Courses** | Display all courses in an interactive DataGridView |
| **Edit Courses** | Update existing course information |
| **Delete Courses** | Remove courses with confirmation dialog |

### 🎨 **User Interface**
- Clean, Simple Windows Forms design
- Responsive layout with intuitive controls
- Real-time record counter
- Form clearing functionality
- Error handling with user-friendly messages

---

## 💻 Technology Stack

<div align="center">

| Layer | Technology |
|-------|------------|
| **Frontend** | Windows Forms (.NET Framework 4.8) |
| **Backend** | C# |
| **Database** | Microsoft SQL Server / LocalDB |
| **Data Access** | ADO.NET with SqlClient |
| **Version Control** | Git |

</div>

### 📦 **NuGet Packages**
```xml
System.Data.SqlClient
System.Configuration.ConfigurationManager
```

---

## 🗄️ Database Schema

### **Courses Table Structure**

```sql
CREATE TABLE Courses (
    CourseID INT PRIMARY KEY IDENTITY(1,1),
    CourseCode VARCHAR(20) UNIQUE NOT NULL,
    CourseName NVARCHAR(200) NOT NULL,
    Semester VARCHAR(50) NOT NULL,
    Credits INT NOT NULL CHECK (Credits > 0 AND Credits <= 10),
    Instructor NVARCHAR(150) NOT NULL,
    Description NVARCHAR(MAX) NULL,
    Department NVARCHAR(100) NULL,
    CourseLevel VARCHAR(50) NULL,
    StartDate DATE NULL,
    EndDate DATE NULL,
    MaxStudents INT NULL,
    IsActive BIT DEFAULT 1,
    Prerequisites NVARCHAR(500) NULL,
    LearningObjectives NVARCHAR(MAX) NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),
    ModifiedDate DATETIME DEFAULT GETDATE()
);
```

### **Users Table Structure**

```sql
CREATE TABLE Users (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    FullName NVARCHAR(150) NOT NULL,
    Username NVARCHAR(50) UNIQUE NOT NULL,
    Email NVARCHAR(150) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(255) NOT NULL,
    UserType NVARCHAR(20) DEFAULT 'Student',
    CreatedDate DATETIME DEFAULT GETDATE(),
    LastLogin DATETIME NULL,
    IsActive BIT DEFAULT 1
);
```

---

## 📥 Installation

### **Prerequisites**
- Windows 7 or later
- [.NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework/net48)
- [SQL Server LocalDB](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) or SQL Server Express
- [Visual Studio 2019+](https://visualstudio.microsoft.com/) (for development)

### **Setup Instructions**

#### 1️⃣ **Clone the Repository**
```bash
git clone https://github.com/ManJoseph/Courses-Management-System/
cd ELearningSystem
```

#### 2️⃣ **Configure Database Connection**

Update the connection string in `App.config`:

```xml
<connectionStrings>
    <add name="ELearningDB" 
         connectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ELearningSystem;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

#### 3️⃣ **Create Database**

Run the SQL scripts in SSMS:
1. Open SQL Server Management Studio
2. Connect to `(LocalDB)\MSSQLLocalDB`
3. Execute the database creation scripts from `/Database/Scripts/`

#### 4️⃣ **Build and Run**
```bash
# Open solution in Visual Studio
ELearningSystem.sln

# Build solution (Ctrl+Shift+B)
# Run application (F5)
```

---

## 🚀 Usage Guide

### **User Registration & Login**

| Step | Action | Description |
|------|--------|-------------|
| 1 | **Register** | Create new account with full name, username, email, and password |
| 2 | **Login** | Access the system with registered credentials |
| 3 | **Navigate** | Access course management dashboard |

### **Course Management Operations**

<div align="center">

| Operation | How to Perform |
|-----------|----------------|
| **➕ Add Course** | Fill all required fields → Click "Save" |
| **📖 View Courses** | Automatically loaded in DataGridView |
| **✏️ Update Course** | Select course → Edit fields → Click "Update" |
| **🗑️ Delete Course** | Select course → Click "Delete" → Confirm |
| **🔄 Reset Form** | Click "Clear" to reset all input fields |
| **🔄 Refresh** | Click "Refresh" to reload course list |

</div>

---

## 📸 Application View

### **Main Dashboard - Course Management**
![ElearningSystem](https://github.com/user-attachments/assets/6529da51-809e-4ed9-8253-59ff08bbbfb8)

*The main interface displaying all courses with comprehensive management controls*

---

## 📁 Project Structure

```
ELearningSystem/
│
├── ELearningSystem.sln                    # Solution file
├── ELearningSystem.csproj                 # Project file
├── App.config                            # Configuration with connection string
│
├── Forms/
│   ├── MainForm.cs                       # Main course management form
│   ├── MainForm.Designer.cs              # Designer-generated code
│   ├── LoginForm.cs                     # User authentication form
│   ├── SignUpForm.cs                    # User registration form
│   └── Form1.cs                         # Additional forms
│
├── Models/
│   └── Course.cs                        # Course entity model
│
├── Database/
│   ├── DatabaseHelper.cs                # SQL Server data access layer
│   └── Scripts/                         # Database creation scripts
│
└── Properties/
    └── AssemblyInfo.cs                  # Assembly metadata
```

---

## 🧩 Key Code Components

### **Course Model**
```csharp
public class Course
{
    public int CourseID { get; set; }
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public string Semester { get; set; }
    public int Credits { get; set; }
    public string Instructor { get; set; }
    // ... additional properties
}
```

### **Database Operation Example**
```csharp
public bool InsertCourse(Course course)
{
    using (SqlConnection conn = new SqlConnection(connectionString))
    {
        string query = "INSERT INTO Courses (...) VALUES (...)";
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            // Parameterized query to prevent SQL injection
            cmd.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
```

---

## 🤝 Contributing

Contributions are welcome! Here's how you can help:

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/AmazingFeature`)
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`)
4. **Push** to the branch (`git push origin feature/AmazingFeature`)
5. **Open** a Pull Request

### **Development Guidelines**
- Follow C# coding conventions
- Add XML comments for public methods
- Include unit tests for new features
- Update documentation accordingly

---

---

## 👨‍💻 Author

**Your Name**
- GitHub: [@ManJoseph](https://github.com/ManJoseph)
- LinkedIn: [Joseph Manizabayo](https://linkedin.com/in/manjoseph)
- Email: josephmanizabayo7@gmail.com
