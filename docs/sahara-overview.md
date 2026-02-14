# Sahara — Product Overview

Sahara is an enterprise multi-vendor e-commerce platform analogous to Amazon, modeled on its marketplace dynamics. Independent sellers list products, buyers browse and purchase, and the platform orchestrates everything in between, designed for real-world production demands.

Built on the secure, scalable, and high-performance Microsoft .NET ecosystem, Sahara implements ASP.NET Web API for its backend services, Blazor for the frontend framework, and .NET MAUI for mobile and desktop application versions of the product.

Sahara's backend architecture is business-driven, structured around the commerce domain so that its organization maps naturally to the business it serves. This makes the system intuitive to navigate, straightforward to scale, and resilient against the coupling and volatility that undermine critical components in poorly structured applications.

Sahara is architected as a modular monolith, decomposed into vertically sliced modules by business capability such as Payments, Orders, Cart, and Products. Each module implements a pragmatic internal clean architecture shaped by its own domain.

The architecture is domain-first and business-driven. Domain-first means the system's structure is modeled directly after the business capabilities required for the platform to function, each becoming its own module. Business-driven means the system is guided by real business operations: customers searching for and browsing products, sellers listing inventory, processing refunds, registering accounts. These operations reveal the critical subject areas that become modules.

Not every business need qualifies as a module. A component earns module status when it encapsulates business rules, invariants, lifecycle, and persisted state. Capabilities that don't meet these constraints, like sending emails, while important to the business, serve as infrastructure services that support the operational modules rather than standing on their own. Each qualifying module has its own domain, and that domain shapes the module's entire internal structure.

At the lowest level of the system, each qualifying module implements clean architecture internally, giving it structure and guiding principles. This architecture enforces inward dependencies with the business domain at the center, reducing coupling, enabling separation of concerns so each layer manages its own responsibility, and keeping the module and system maintainable and testable.

The domain layer contains business logic with no external dependencies. The application layer coordinates application services centered around the domain. Infrastructure plugs in as a replaceable outer layer, handling data persistence and other external concerns. The API layer exposes the module's capabilities through controllers to external clients such as the web frontend or mobile application.

Each module owns its entire vertical responsibility and consumes shared contracts across the system for cross-cutting capabilities like sending email or file storage. No module depends on another module directly; they interact only through contracts or abstractions.

---

# Architecture Overview — Reference Specification

**Modular Monolith With Business-Capability Slices And Clean Architecture**

## Architectural Classification

This system implements a Modular Monolith that is vertically sliced by business capability modules, with each module internally structured using Clean Architecture principles. The architecture is intentionally composed of multiple architectural styles, each applied at a specific scope and responsibility level.

The architecture is domain-first and business-driven, where structure emerges from business rules, invariants, lifecycle, and persisted state rather than technical convenience.

## Architectural Hierarchy (Top → Bottom)

1. Modular Monolith (system-level)
2. Business-Capability Modules / Vertical Slices (system decomposition)
3. Clean Architecture (module-internal design)
4. Supporting Capabilities / Platform Infrastructure
5. Application Workflows (use-case orchestration)

Each layer governs a different concern and should not be conflated with the others.

## 1. Modular Monolith

**Architectural Level:** System / Deployment Architecture

### Description

The system is deployed as a single, unified application (single process, single deployment unit) while being internally partitioned into well-defined modules with explicit boundaries.

### What it governs

- Deployment topology (single deployable)
- Runtime model (in-process communication)
- Operational simplicity
- Shared hosting and infrastructure

### What it is for

- Avoids distributed-system complexity
- Enables strong modularity without microservices
- Supports incremental evolution and future extraction if needed

### Where it lives

- Solution-level architecture
- Runtime and deployment model

## 2. Business-Capability Modules (Vertical Slices)

**Architectural Level:** System Decomposition / Business Architecture

### Description

The system is decomposed into business-capability modules (e.g., Orders, Products, Customers, Vendors). Each module represents a bounded context and a source of business truth.

A component qualifies as a business module only if it owns:

- Business rules
- Domain invariants
- A meaningful lifecycle
- Persisted business state (database-owned)

### What it governs

- Module boundaries
- Ownership of data and rules
- Change blast radius
- Cognitive and conceptual ownership

### What it is for

- Aligns code structure with business language
- Prevents over-modularization
- Ensures clear ownership of business truth

### Where it lives

- Module boundaries in the solution
- High-level folder / project structure

## 3. Clean Architecture (Per Module)

**Architectural Level:** Module Internal Architecture

### Description

Each business module is internally implemented using Clean Architecture principles, applied pragmatically. This governs dependency direction and separation of concerns inside the module.

### Typical internal structure

- Domain
- Application (use cases)
- Infrastructure
- API / Presentation

### What it governs

- Inward dependency flow
- Isolation of business policy from frameworks
- Separation of domain logic from technical concerns

### What it is for

- Maintainability and clarity
- Testability of business logic
- Controlled evolution of infrastructure

### Key characteristics

- Domain is framework-agnostic
- Infrastructure and API depend inward
- Domain models may be rich or anemic based on business need
- Abstractions are introduced only where they add value

### Where it lives

- Project boundaries inside each module
- Dependency graph between module projects

## 4. Supporting Capabilities (Platform / Infrastructure)

**Architectural Level:** Technical Enablement

### Description

Supporting capabilities provide technical services used by business modules but do not own business truth.

### Examples

- Email
- SMS
- Authentication / Identity
- Payment gateways
- Logging, caching, file storage

### What it governs

- External system integration
- Technical cross-cutting concerns

### What it is for

- Enable business effects
- Centralize technical concerns
- Avoid duplication across modules

### Where it lives

- Platform or Infrastructure areas
- Integration-focused projects

## 5. Application Workflows

**Architectural Level:** Use-Case Design

### Description

Workflows are transient orchestration logic that coordinate multiple rules or modules but do not own independent state or business truth.

### Examples

- Checkout
- Order placement flows
- Payment confirmation processes

### What it governs

- Sequencing of business operations
- Coordination between rules and modules

### What it is for

- Express business processes
- Keep orchestration out of domain entities

### Where it lives

- Application layer of the owning business module

## Core Decision Rule (Canonical)

A capability becomes a business module only when it owns:

- Business rules
- Domain invariants
- A lifecycle
- Persisted business state

If these are not present, the capability is either:

- A workflow (application logic), or
- A supporting infrastructure concern

## Final One-Sentence Summary

This system is a modular monolith, decomposed into business-capability vertical slices, with each module internally implemented using Clean Architecture to enforce inward dependency flow and isolate business policy from technical concerns.