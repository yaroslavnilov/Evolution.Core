# Evolution.Core 🧬

A modular evolutionary simulation engine built with **C#** and **.NET**. 
This project focuses on clean architecture, SOLID principles, and genetic algorithms.

## 🌟 About the Project
`Evolution.Core` is a simulation where digital entities (Creatures) live in a 2D world. Each creature has its own **genome** that determines its behavior. Through natural selection and mutations, creatures adapt to their environment to survive and reproduce.

The main goal of this project is to demonstrate high-quality software engineering practices:
* **SOLID Principles**: Decoupling logic from data.
* **Object-Oriented Design**: Using inheritance and polymorphism for world entities.
* **Performance**: Optimized memory management for large-scale simulations.

## 🏗️ Architecture
The project is divided into several logical layers:
- **World Engine**: Manages the 2D grid and entity interactions.
- **Entity System**: Base classes for all objects (Creatures, Food, Walls).
- **Genetic Processor**: Interprets genome sequences into actions (Movement, Eating, etc.).

## 🚀 Current Status
- [x] Basic World Engine with 2D Grid.
- [x] Entity inheritance system (BaseEntity).
- [x] Centralized spawning system.
- [ ] Basic movement logic (In progress).
- [ ] Genome interpretation and mutation.
- [ ] Console visualization.

## 🛠️ Technologies
- **Language**: C#
- **Platform**: .NET 8.0+
- **Version Control**: Git

## 📖 How to run
Currently, the project is in early development. 
1. Clone the repository.
2. Open `Evolution.Core.sln` in Visual Studio 2022.
3. Run the Console application.