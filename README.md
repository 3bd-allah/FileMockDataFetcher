# FileMockDataFetcher.IO

A high-performance C# console utility that fetches data from user-defined REST APIs and streams the payload directly to the local file system using asynchronous I/O operations. 

---

## 🚀 Features

* **Dynamic API Requesting:** Accepts arbitrary HTTP/HTTPS endpoints at runtime via an interactive CLI loop.
* **Asynchronous File I/O:** Utilizes `System.IO` non-blocking operations to handle network streams efficiently without locking the main execution thread.
* **Resource Management:** Implements robust lifecycle management for network resources, utilizing the `using` pattern to prevent socket exhaustion and memory leaks.

## 🛠️ Tech Stack & Concepts

* **Language:** C# 11+ / .NET 10.0
* **Framework:** .NET Console Application
* **I/O Operations:** `System.Net.Http.HttpClient`, `System.IO.File`
* **Design Patterns:** Async/Await Pattern, IDisposable/Dependency Lifecycle Management


---

## 🏃 Getting Started


### Installation & Run

1. Clone the repository:
   ```bash
   git clone [https://github.com/3bd-allah/FileMockDataFetcher.git]
   cd FileMockDataFetcher.IO

2. Run the Application:
  ```bash
  dotnet run
   
