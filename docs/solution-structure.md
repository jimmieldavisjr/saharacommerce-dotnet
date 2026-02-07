Solution/
├── Infrastructure/
│  ├── Integrations/
│  │  ├── Identity/
│  │  │  ├── CurrentUser.cs
│  │  │  ├── ClaimsMapping.cs
│  │  │  ├── IdentityConfig.cs
│  │  │  └── IdentityModels.cs
│  │  │
│  │  ├── Payments/
│  │  │  ├── IPaymentGateway.cs          
│  │  │  ├── PaymentGatewayResult.cs
│  │  │  ├── StripeGateway.cs            
│  │  │  ├── PaymentWebhookHandler.cs
│  │  │  └── PaymentsModels.cs
│  │  │
│  │  └── Email/
│  │     ├── IEmailSender.cs              
│  │     ├── EmailMessage.cs
│  │     ├── SmtpEmailSender.cs           
│  │     └── EmailTemplates.cs
│  │
│  ├── Persistence/
│  │  ├── AppDbContext.cs
│  │  ├── Migrations/
│  │  └── PersistenceConfig.cs
│  │
│  ├── Observability/
│  │  ├── LoggingConfig.cs
│  │  ├── AuditTrailWriter.cs
│  │  └── Metrics.cs
│  │
│  └── BackgroundJobs/
│     ├── JobScheduler.cs
│     └── OutboxDispatcher.cs
│
└── Features/
   ├── Customers/
   │  ├── CustomersController.cs
   │  ├── CustomersService.cs
   │  ├── Customer.cs
   │  └── CustomersDtos.cs
   │
   ├── Vendors/
   │  ├── VendorsController.cs
   │  ├── VendorsService.cs
   │  ├── Vendor.cs
   │  └── VendorsDtos.cs
   │
   ├── Products/
   │  ├── ProductsController.cs
   │  ├── ProductsService.cs
   │  ├── Product.cs
   │  ├── ProductImage.cs
   │  ├── ProductStatus.cs
   │  └── ProductsDtos.cs
   │
   ├── Catalog/
   │  ├── CatalogController.cs
   │  ├── CatalogService.cs
   │  ├── Category.cs
   │  └── CatalogDtos.cs
   │
   ├── Carts/
   │  ├── CartsController.cs
   │  ├── CartsService.cs
   │  ├── Cart.cs
   │  ├── CartItem.cs
   │  └── CartsDtos.cs
   │
   ├── Checkout/
   │  ├── CheckoutController.cs
   │  ├── CheckoutService.cs
   │  ├── CheckoutSession.cs
   │  └── CheckoutDtos.cs
   │
   ├── Inventory/
   │  ├── InventoryController.cs
   │  ├── InventoryService.cs
   │  ├── InventoryItem.cs
   │  ├── InventoryAdjustment.cs
   │  └── InventoryDtos.cs
   │
   ├── Shipping/
   │  ├── AddressesController.cs
   │  ├── AddressesService.cs
   │  ├── Address.cs
   │  ├── ShippingService.cs
   │  ├── Shipment.cs
   │  └── ShippingDtos.cs
   │
   ├── Admin/
   │  ├── AdminVendorsController.cs
   │  ├── AdminProductsController.cs
   │  ├── AdminOrdersController.cs
   │  ├── AdminService.cs
   │  └── AdminDtos.cs
   │
   └── Orders/
      ├── OrdersController.cs
      ├── OrdersService.cs
      ├── Order.cs
      ├── OrderLineItem.cs
      ├── OrderStatus.cs
      ├── OrderHistory.cs
      └── OrdersDtos.cs
