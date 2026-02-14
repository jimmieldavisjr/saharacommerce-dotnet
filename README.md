# Sahara
Sahara is an enterprise multi-vendor e-commerce platform analogous to Amazon, modeled on its marketplace dynamics. Independent sellers list products, buyers browse and purchase, and the platform orchestrates everything in between — designed for real-world production demands. Built on the secure, scalable, and high-performance Microsoft .NET ecosystem, Sahara implements ASP.NET Web API for its backend services, Blazor for the frontend framework, and .NET MAUI for mobile and desktop application versions of the product.

## Architecture

Sahara's backend architecture is business-driven, structured around the commerce domain so that its organization maps naturally to the business it serves. This makes the system intuitive to navigate, straightforward to scale, and resilient against the coupling and volatility that undermine critical components in poorly structured applications.

Sahara is architected as a modular monolith, decomposed into vertically sliced modules by business capability such as Payments, Orders, Cart, and Products. Each module implements a pragmatic internal clean architecture shaped by its own domain.

## Domain-First, Business-Driven Design

The architecture is domain-first and business-driven. Domain-first means the system's structure is modeled directly after the business capabilities required for the platform to function, each becoming its own module. Business-driven means the system is guided by real business operations: customers searching for and browsing products, sellers listing inventory, processing refunds, registering accounts. These operations reveal the critical subject areas that become modules.

Not every business need qualifies as a module. A component earns module status when it encapsulates business rules, invariants, lifecycle, and persisted state. Capabilities that don't meet these constraints — like sending emails — while important to the business, serve as infrastructure services that support the operational modules rather than standing on their own. Each qualifying module has its own domain, and that domain shapes the module's entire internal structure.

## Clean Architecture Within Each Module

At the lowest level of the system, each qualifying module implements clean architecture internally, giving it structure and guiding principles. This architecture enforces inward dependencies with the business domain at the center, reducing coupling, enabling separation of concerns so each layer manages its own responsibility, and keeping the module and system maintainable and testable.

The domain layer contains business logic with no external dependencies. The application layer coordinates application services centered around the domain. Infrastructure plugs in as a replaceable outer layer, handling data persistence and other external concerns. The API layer exposes the module's capabilities through controllers to external clients such as the web frontend or mobile application.

## Module Boundaries

Each module owns its entire vertical responsibility and consumes shared contracts across the system for cross-cutting capabilities like sending email or file storage. No module depends on another module directly; they interact only through contracts or abstractions.
