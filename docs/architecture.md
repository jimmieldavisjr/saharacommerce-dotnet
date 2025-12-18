# Sahara Commerce — Architecture

## 1. Purpose of This Document
This document explains the **high-level architecture** of Sahara Commerce.  
It is intended to be:
- Easy to understand
- Easy to extend
- A learning reference as the system grows

This is **not** a full technical specification. It describes *structure, boundaries, and intent*.

---

## 2. System Overview

Sahara Commerce is an **enterprise-grade modular monolith** built on the **.NET platform**.

The system is designed to:
- Start simple
- Scale in complexity without structural rewrites
- Support multiple client applications

At a high level:
- A single backend API hosts multiple business modules
- Multiple UI clients consume the same API
- Shared contracts define the public language of the system

---

## 3. Architectural Style

**Primary style:** Modular Monolith  
**Secondary principles:** Clean Architecture, Domain-Driven Design (DDD)

Key characteristics:
- One deployable backend
- Clear module boundaries
- No shared business logic between modules
- Explicit dependency direction

This architecture intentionally avoids premature microservices.

---

## 4. High-Level Component Diagram

```
Clients (Blazor Server, MAUI)
        ↓
Shared.Contracts
        ↓
Sahara.Api (Composition Root)
        ↓
Business Modules
        ↓
Domain Models
```

---

## 5. Repository Structure

```
/docs        → Architecture & design documentation
/src         → Production code
/tests       → All test projects
/infra       → Infrastructure & deployment (optional)
```

### /src Breakdown

```
/src
  /Api        → Backend host & configuration
  /Modules    → Business capabilities (modular monolith)
  /Shared     → API contracts & shared language
  /Clients    → UI applications
```

---

## 6. Module Structure

Each module represents a **business capability** and follows a consistent internal structure:

```
ModuleName
  ├─ Domain          → Business rules & entities
  ├─ Application     → Use cases & orchestration
  ├─ Infrastructure  → Persistence & external services
  ├─ Api             → HTTP endpoints
  └─ Tests           → Module-specific tests (optional)
```

Modules:
- Do not reference each other directly
- Communicate only through explicit contracts or application boundaries

---

## 7. Shared Contracts

`/Shared/Contracts` contains **DTOs and API contracts** consumed by multiple clients.

Structure mirrors backend domains:

```
Shared/Contracts
  ├─ Common
  ├─ Identity
  ├─ Users
  ├─ Catalog
  └─ Orders
```

Rules:
- No business logic
- No infrastructure concerns
- Pure data structures only

---

## 8. Clients

Clients are **API consumers**, not part of the backend.

Examples:
- Blazor Server (Web)
- .NET MAUI (Mobile)

Rules:
- Clients reference `Shared.Contracts`
- Clients never reference backend modules
- Clients are independently deployable

---

## 9. Dependency Rules (Very Important)

Allowed:
- Clients → Shared.Contracts
- Api → Modules
- Modules → Domain

Not Allowed:
- Clients → Modules
- Modules → Clients
- Domain → Infrastructure

Architecture is enforced by **dependency direction**, not folder order.

---

## 10. Testing Strategy

Tests live outside `/src` and are organized by purpose:

```
/tests
  /Unit
  /Integration
  /E2E
```

- Unit tests focus on domain and application logic
- Integration tests validate module + infrastructure
- E2E tests validate system behavior

---

## 11. Non-Goals (Intentional)

At this stage, Sahara Commerce does **not** aim to:
- Use microservices
- Introduce distributed messaging
- Implement full CQRS separation

These decisions are intentional and documented to prevent accidental overengineering.

---

## 12. How This Document Evolves

This document is expected to:
- Be edited
- Grow gradually
- Reflect architectural decisions over time

---

## 13. Guiding Principle

> **Clarity over cleverness. Structure before scale.**

This architecture prioritizes understanding, maintainability, and long-term flexibility.

