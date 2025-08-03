# 📚 Book Up

Book Up é uma aplicação moderna construída com .NET 8 e React TypeScript, voltada para gerenciamento e reserva de livros. A arquitetura foi pensada para escalabilidade, desempenho e organização de código, utilizando os principais padrões e boas práticas do mercado.

---

## 🧱 Tecnologias Utilizadas

### Backend (.NET 8 - C#)
- ASP.NET Core Web API
- Entity Framework Core
- JWT Authentication
- Repository Pattern & Unit of Work
- Dependency Injection (DI)
- Factory Pattern
- Strategy Pattern
- Mediator Pattern (com MediatR)
- Docker & Docker Compose
- AWS S3 (armazenamento de imgs)
- CI/CD com GitHub Actions** ✅

### Frontend (React + TypeScript)
- Vite
- Redux (Toolkit)
- React Query (para gerenciamento de estado assíncrono)
- HTTP State Management
- Componentização com boas práticas
- Integração com autenticação JWT
- CI/CD com GitHub Actions** ✅

---

## ⚙️ Como Rodar o Projeto

### Pré-requisitos
- Docker e Docker Compose
- .NET 8 SDK
- Node.js (versão 18+)
- AWS CLI (configurado se for subir arquivos)

### 📦 Backend
```bash
cd backend
dotnet restore
dotnet build
dotnet run
