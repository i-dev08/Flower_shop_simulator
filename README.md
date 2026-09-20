# Flower Shop Simulator

A first-person flower shop simulation built with **Unity and C#**.

The player runs a small flower shop where customers arrive with randomly generated bouquet orders. The player must gather the requested flowers and ribbon, choose the correct wrapping, assemble the bouquet, and fulfill the order before the customer's patience runs out.

This project was built as a hands-on exploration of **Unity game development, C# gameplay programming, interaction systems, UI, inventory management, and basic game architecture**.

---

## Gameplay

The core gameplay loop is:

**Customer arrives → Order generated → Gather materials → Assemble bouquet → Fulfill order → Earn points → Next customer**

Customers request combinations such as:

```text
Rose × 2
Tulip × 1

Ribbon: Blue
Wrapping: Green
```

The player must correctly fulfill the order before the customer leaves.

---

## Features

* First-person player controller
* Mouse-look camera system
* New Unity Input System
* Flower inventory system
* Ribbon selection system
* Randomly generated customer orders
* Customer spawning and lifecycle management
* Customer patience timer
* Interactive shop stations
* Bouquet assembly system
* Order validation
* Earnings / points system
* In-game UI
* Continuous customer/order gameplay loop

---

## Architecture

The project is organized around separate gameplay systems rather than putting all game logic into a single script.

```text
Game Systems
│
├── CustomerManager
│   └── Customer spawning and lifecycle
│
├── Customer
│   └── Patience and leaving behaviour
│
├── OrderManager
│   └── Random order generation
│
├── InventoryManager
│   └── Flowers and ribbon tracking
│
├── InteractionSystem
│   └── Player interaction with shop stations
│
├── CraftingManager
│   └── Bouquet/order validation
│
├── PointsManager
│   └── Earnings tracking
│
└── UI Systems
    ├── Order UI
    ├── Inventory UI
    ├── Flower Selection UI
    ├── Ribbon Selection UI
    └── Bouquet UI
```

---

## Tech Stack

* **Engine:** Unity
* **Language:** C#
* **Input:** Unity Input System
* **UI:** Unity UI / TextMeshPro
* **Version Control:** Git / GitHub

---

## External Assets

This project uses third-party Unity assets for visual elements and character models. These assets are **not included in this repository** and must be obtained separately from their original sources.

### Required External Assets

* **Stylized Hand-Painted Plant & Flower Pack** — Patchmesh
  Used for flower models and shop decorations.

* **Girl & Boy Characters**
  Used for customer character models.

* **Stylized Low Poly Coffee Shop Props Pack – Free**
  Used for shop environment and decorative props.

> **Note:** These assets are excluded from this repository to respect third-party asset licensing and redistribution terms. The project code, scenes, gameplay systems, and custom UI remain part of this repository.

---

## What I Learned

This project was my first hands-on project with Unity.

Through building it, I worked with:

* Unity's GameObject and Component architecture
* MonoBehaviour lifecycle
* C# scripting in Unity
* Character Controllers
* Colliders and raycasting
* Unity's New Input System
* Prefabs and object instantiation
* UI and TextMeshPro
* Dictionaries and enums
* Object references through the Unity Inspector
* Coroutines / delayed gameplay events
* Separation of gameplay responsibilities
* Basic game-state and gameplay-loop design

Rather than following a complete game tutorial, the project was built incrementally by learning a system and immediately implementing it into the game.

---

## Current Status

**Prototype / Version 0.1**

The core gameplay loop is functional.

Current development is focused on improving:

* Visual presentation
* Customer feedback
* Audio
* Animations
* Game feel
* Additional gameplay systems

---

## Planned Features

Future iterations may include:

* More flower types
* Multiple bouquet recipes
* Stock and restocking
* More advanced customer patience
* Wrong-order penalties
* Shop economy
* Shop upgrades
* Day progression
* Save/load system
* More customer types
* Sound effects and music
* Visual polish

---

## Project Goal

This project was created as a focused introduction to **Unity game programming**, with an emphasis on understanding how gameplay systems communicate with each other rather than only producing visual assets.

The long-term goal is to turn the prototype into a small but complete playable game.

---

## Author

**Ishika R Dev**

---

More features and improvements coming as development continues.
