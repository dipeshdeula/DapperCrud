# Dapper in ASP.NET Core Web API

Welcome to the **Dapper Implementation** guide for your ASP.NET Core Web API project! 🚀 This repository demonstrates how to integrate **Dapper**, the lightning-fast micro-ORM, to create efficient and scalable data access layers for your applications.

---

## 📖 Table of Contents

1. [What is Dapper?](#what-is-dapper)
2. [Why is Dapper so Popular?](#why-is-dapper-so-popular)
3. [What is a Micro-ORM?](#what-is-a-micro-orm)
4. [Why Use Dapper?](#why-use-dapper)
5. [Dapper vs EF Core](#choosing-dapper-over-ef-core)
6. [Getting Started](#getting-started)
    - [Project Setup](#project-setup)
    - [Required Packages](#required-packages)
7. [Contact](#contact)

---

## 🌟 What is Dapper?

**Dapper** is an open-source **Micro-ORM** for .NET, created by **Marc Gravel** and **Sam Saffron** in 2011 to tackle performance issues on one of the world's most accessed websites: **Stack Overflow**.  
Dapper’s simplicity and speed make it a preferred choice for developers looking to interact with databases efficiently without the overhead of full-fledged ORMs.

**Key Highlights:**
- 🚀 **Blazing Fast Performance**: Direct SQL execution with minimal overhead.  
- ✍️ **Write Raw SQL**: Retain full control over your queries.
- ✅ **SQL Injection Safe**: Supports **parameterized queries** for security.
- 🛠️ **Supports Multiple Databases**: SQL Server, MySQL, PostgreSQL, SQLite, and more.

👉 Want to dive deeper? Check out the [official documentation](https://github.com/DapperLib/Dapper).

---

## 🎯 Why is Dapper so Popular?

The performance results achieved by Dapper made it stand out among its competitors. It resolved **performance bottlenecks** for **Stack Overflow**, a website serving millions of users daily.

- Removes complexity by simplifying query building.  
- Maps objects and parameters to SQL queries with ease.  
- Lightweight and focused, making it the **second-fastest ORM** after hand-coded SQL.

---

## 🔍 What is a Micro-ORM?

A **Micro-ORM** (Object-Relational Mapper) is a lightweight ORM that provides basic functionalities to interact with a database, unlike full ORMs like **Entity Framework**.  
Dapper, the **king of micro-ORMs**, is renowned for its **speed** and **simplicity**, extending the capabilities of **ADO.NET** without compromising performance.

---

## 🤔 Why Use Dapper?

- 📦 Lightweight and high-performance.  
- ✂️ Drastically reduces boilerplate **ADO.NET** code.  
- 🔧 Works seamlessly with **raw SQL**.  
- 🌍 Multi-database support (SQL Server, MySQL, PostgreSQL, Oracle, SQLite, etc.).  
- 🛡️ Built-in **SQL Injection Protection** with parameterized queries.  

> 💡 **Fun Fact:** Dapper is not just an ORM but a library that focuses on **database tasks**, letting you write SQL as you would in your favorite database.

---

## ⚔️ Choosing Dapper Over EF Core

Both **Entity Framework Core** and **Dapper** have their strengths. Here’s why you might prefer Dapper:

- 🏗️ **Existing Database**: Optimized for legacy databases with numerous stored procedures.  
- 📊 **Dashboard/Report Focused**: Excellent for data-heavy applications with custom queries.  
- 🧠 **Developer Familiarity**: Leverages raw SQL knowledge for direct control.  
- 🌐 **Multi-Database Support**: Work with multiple databases in the same application effortlessly.  

---

## 🚀 Getting Started

### Project Setup

1. **Create an ASP.NET Core Web API project** (ensure .NET version **7.0 or above**).
2. Add the following NuGet packages:

### Required Packages

- **Microsoft.Data.SqlClient**  
- **Dapper**  

Use the following commands in the Package Manager Console:

```bash
Install-Package Microsoft.Data.SqlClient
Install-Package Dapper
```
## 💬 Contact
Having any confusion or queries about the project? Feel free to reach out!
📧 Email: **deulatech@gmail.com**

✨ Happy Learning! All rights reserved.
<sup>Developed by Dipesh Deula</sup>
