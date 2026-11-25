# Enterprise Service Management System (ESMS)

## Overview

Enterprise Service Management System is a backend application designed to streamline internal enterprise service requests, vendor management, operational workflows, approvals, notifications and audit management.

The project is being developed progressively as an enterprise software engineering capstone alongside Ultimate ASP.NET Core Web API, Second Edition.

## Business Objectives

- Centralize enterprise service requests.
- Improve operational accountability and transparency.
- Streamline approval workflows.
- Manage external vendors.
- Provide secure access to enterprise resources.
- Maintain comprehensive audit trails.
- Improve operational reporting and service delivery.

## Technology Stack

| Technology | Purpose |
|---|---|
| C# 14 | Primary programming language |
| .NET 10 LTS | Application development platform |
| ASP.NET Core Web API | REST API framework |
| SQL Server | Planned relational database |
| Entity Framework Core | Planned data access framework |
| Onion Architecture | Planned architectural approach |
| Git and GitHub | Source control |
| Visual Studio Code | Development environment |
| Postman | API testing |
| xUnit | Planned automated testing framework |

## Planned Functional Modules

- Service Request Management
- Vendor Management
- User and Department Management
- Approval Workflow Management
- Notification Management
- Authentication and Authorization
- Audit Management
- Document Management
- Reporting and Analytics

## Development Approach

The application will be developed incrementally, introducing enterprise software engineering concepts as they are studied.

Each implementation stage will include:

- Business requirement analysis
- Technical implementation
- Code review
- Testing and verification
- Documentation
- Source control

## Prerequisites

- .NET 10 SDK
- Visual Studio Code
- Git

## Build Instructions

```powershell
dotnet restore
dotnet build --no-restore
```

## Run Instructions

```powershell
dotnet run --project EnterpriseServiceManagement
```

## Current Development Status

Phase 1: Initial ASP.NET Core Web API project configuration.

The application currently contains the foundational controller-based API configuration. Business modules, database integration, security and architectural layers will be introduced in subsequent development phases.