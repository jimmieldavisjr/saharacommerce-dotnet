src/
├── Program.cs
├── Extensions/
│   ├── InfrastructureExtensions.cs
│   └── ModuleExtensions.cs
│
├── Controllers/
│   ├── AuthController.cs
│   └── HealthController.cs
│
├── Contracts/
│   ├── Payments/
│   ├── Email/
│   ├── Identity/
│   ├── FileStorage/
│   └── AuditLog/
│       ├── IAuditLogService.cs
│       ├── AuditLogEntry.cs
│       └── AuditActions.cs
│
├── Infrastructure/
│   ├── Payments/
│   ├── Email/
│   ├── Identity/
│   │   ├── AppUser.cs
│   │   ├── AppIdentityDbContext.cs
│   │   ├── TokenService.cs
│   │   └── IdentitySeed.cs
│   ├── FileStorage/
│   └── AuditLog/
│       ├── AuditLogDbContext.cs
│       └── AuditLogService.cs
│
├── Common/
│   └── Pagination/
│       ├── PagedRequest.cs
│       └── PagedResult.cs
│
└── Modules/
    ├── Customers/
    │   ├── Customers.Api/
    │   ├── Customers.Domain/
    │   ├── Customers.Application/
    │   └── Customers.Infrastructure/
    │
    ├── Vendors/
    │   ├── Vendors.Api/
    │   ├── Vendors.Domain/
    │   ├── Vendors.Application/
    │   └── Vendors.Infrastructure/
    │
    ├── Products/
    │   ├── Products.Api/
    │   ├── Products.Domain/
    │   ├── Products.Application/
    │   └── Products.Infrastructure/
    │
    ├── Cart/
    │   ├── Cart.Api/
    │   ├── Cart.Domain/
    │   ├── Cart.Application/
    │   └── Cart.Infrastructure/
    │
    ├── Orders/
    │   ├── Orders.Api/
    │   ├── Orders.Domain/
    │   ├── Orders.Application/
    │   └── Orders.Infrastructure/
    │
    └── Payments/
        ├── Payments.Api/
        ├── Payments.Domain/
        ├── Payments.Application/
        └── Payments.Infrastructure/