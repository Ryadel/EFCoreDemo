# ASP.NET Core 9 + Entity Framework Core 9 Sample Project

Welcome! 👋

This project is a simple, open-source **boilerplate** created to help developers—especially those just getting started with **ASP.NET Core 9** and **Entity Framework Core 9**—learn the basics of building modern web applications using Microsoft's latest technologies.

We created this example to be **clear**, **lightweight**, and **educational**, with the goal of giving you a solid foundation to build on. If you're looking for a quick way to understand how an ASP.NET Core API works, how to use EF Core for data access, and how to structure a basic web project with views and controllers—this is the place for you.

---

## 🚀 What’s Inside?

This project includes:

- ✅ **ASP.NET Core 9** application using the latest SDK
- 🧱 **Entity Framework Core 9** with support for both InMemory and LocalDB providers
- 🔌 A basic **Contact** model and related **DbContext**
- 🧠 A RESTful **API Controller** for full CRUD operations
- 🎨 Basic **Razor Views** with a simple layout and homepage
- 🏗️ Clean folder structure and minimal setup requirements
- 🌐 Fully functional with either `InMemory` or `LocalDB` backend (your choice)

---

## 📂 Project Structure

```
/AspNetCore9Demo
│
├── Controllers/
│   ├── ContactsController.cs   → API endpoints for Contact CRUD
│   └── HomeController.cs       → Home view controller
│
├── Data/
│   └── AppDbContext.cs         → Entity Framework Core DbContext
│
├── Models/
│   └── Contact.cs              → Sample data model
│
├── Views/
│   ├── Home/                   → Razor Views (Index.cshtml)
│   └── Shared/                 → Layout, _ViewStart, _ViewImports
│
├── Properties/
│   └── launchSettings.json     → Local dev settings
│
├── Program.cs                  → App configuration and pipeline
├── AspNetCore9Demo.csproj      → Project definition and NuGet packages
└── README.md                   → You’re reading it!
```

---

## ⚙️ Getting Started

To run the project, follow these simple steps:

1. **Clone this repo** or download the ZIP
2. **Open the solution in Visual Studio 2022**
3. Make sure you're using the **.NET 9 SDK (Preview)**  
4. Choose whether to use:
   - `InMemory` database (default)
   - or replace with a real SQL Server / LocalDB connection
5. Hit **F5** and you're good to go!

> Note: For LocalDB, make sure it's installed and accessible from your system.

---

## 🧪 Try It Out

Once the app is running:

- Visit `https://localhost:xxxx/` to see the home page
- Access the API at `https://localhost:xxxx/api/contacts`
- Use tools like **Postman** or **curl** to test POST, PUT, DELETE endpoints

---

## 💡 Why We Made This

We built this project because we know that starting with a new technology stack can be intimidating—especially one as powerful as ASP.NET Core and EF Core. There are tons of features, patterns, and best practices to learn.

So we decided to create a **no-nonsense, beginner-friendly template** that gets you up and running fast. No unnecessary complexity, no overengineering—just the fundamentals, well-organized and explained.

---

## 🤝 Contributing

Feel free to fork this repository, play around with it, or build on top of it for your own learning or projects. If you spot improvements or want to contribute, we’d love to hear from you!

---

## 📚 More Info

This project is explained in detail in our blog post:  
👉 [ASP.NET Core 9 and EF Core 9 Sample Project](https://www.ryadel.com/en/asp-net-core-and-ef-core-9-0-sample-project/)

---

## 🧑‍💻 Authors

Created with ❤️ by the team at [Ryadel](https://www.ryadel.com), passionate about clean code and developer education.

---

## 📜 License

This project is licensed under the **MIT License**.  
You are free to use, copy, modify, and distribute it with attribution.

Happy coding! 💻🔥
