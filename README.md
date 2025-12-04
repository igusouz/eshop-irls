
# 📦 Distributed E-Commerce Platform (Microservices • .NET 8 • Clean Architecture)

  

A fully containerized, distributed e-commerce platform built with .NET 8, following DDD, CQRS, Vertical Slice Architecture / Clean Architecture, and a microservices approach.

The system exposes its features through a Razor Pages Web App, which communicates exclusively with the backend via a YARP API Gateway.

Internally, services exchange data using REST, gRPC, and RabbitMQ.

All services are orchestrated via Docker, using Docker Compose generated from Visual Studio orchestration tools.

  

<img  src="utils\application-structure.jpg"/>

> Note: This picture is from <a
> href="https://www.udemy.com/course/microservices-architecture-and-implementation-on-dotnet/?utm_campaign=Search_DSA_Beta_Prof_la.EN_cc.ROW-English_Subs&utm_source=google&utm_medium=paid-search&portfolio=ROW-English&utm_audience=mx&utm_tactic=nb&utm_term=&utm_content=g&funnel=&test=&gad_source=1&gad_campaignid=22894903173&gbraid=0AAAAADROdO3PnuL0mIpVmGN6V6K0kNqL2&gclid=CjwKCAiA3L_JBhAlEiwAlcWO5_RxVKCvgInhKo9Kolb-X06cE8OUm55QEVw231lsib3QrIMg2HYf7BoC-ksQAvD_BwE">.NET
> 8 Microservices: DDD, CQRS, Vertical/Clean Architecture</a> by Mehmet
> Ozkaya

<br><br>  

## 🧩 Microservices

### 1. Catalog Service
 - Stores product catalog
 -  REST API
 - Database: PostgreSQL
 - Patterns: DDD, CQRS, Vertical Slice Architecture

### 2. Basket Service

 - Manages user shopping baskets 
 - Stores basket data in Redis 
 - Checkout events published to RabbitMQ 
 - Also persists relational basket data in PostgreSQL 
 - Communicates with Ordering through events

### 3. Discount Service
 - Provides discount/offer information 
 - Communication: gRPC 
 - Database:SQLite 
 - High-performance lightweight microservice

### 4. Ordering Service

 - Processes orders created by Basket
 - Consumes RabbitMQ events
 - Database: SQL Server
 - Fully DDD-based with Aggregates, Value Objects, and Domain Events


## 🌐 Gateway Layer (YARP API Gateway)

The **YARP (Yet Another Reverse Proxy)** gateway routes all HTTP requests from the Razor Web App to the microservices.  
Key responsibilities:
-   Routing & load balancing
-   Service isolation    
-   Centralized entrypoint    
-   Protocol abstraction (REST → gRPC, etc.)

## 🖥 Web Frontend (Razor Pages)

-   .NET 8 Razor Pages    
-   Uses HTTP requests only via YARP    
-   Displays products, manages shopping basket, and executes checkout    
-   No direct microservice access (design rule)

## 🧪 Technologies Used

### **Backend**

-   .NET 8    
-   ASP.NET Core Minimal APIs    
-   Razor Pages Web App    
-   gRPC    
-   YARP API Gateway    
-   DDD + CQRS + Vertical Slice Architecture    
-   MediatR    
-   FluentValidation
- Marten    
- Carter

### **Databases**
-   PostgreSQL    
-   SQL Server    
-   Redis    
-   SQLite
    
### **Messaging**
-   RabbitMQ

### **DevOps / Infrastructure**

-   Docker & Docker Compose    
-   Visual Studio Tools for Containers


## ▶️ Running the Project

### **1. Install prerequisites**

-   Docker Desktop    
-   .NET 8 SDK (only if running without Docker)
    

### **2. Run using Docker Compose**

From the root directory:

`docker compose up -d` 

Visual Studio users can also start the **orchestration project** directly.

### **3. Access the system**

-   Web UI (Razor Pages): `http://localhost:6005`    
-   RabbitMQ Dashboard: `http://localhost:15672/` (guest/guest)

### **4. Test API on Postman**

You can find the Postman collection under utils folder.
