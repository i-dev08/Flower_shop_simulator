# Flower Shop Simulator

A first-person flower shop simulation built with **Unity and C#**.

The player runs a small flower shop where customers arrive with randomly generated bouquet orders. The player must gather the requested flowers and ribbon, choose the correct wrapping, assemble the bouquet, and fulfill the order before the customer's patience runs out.

The project was built as a hands-on exploration of **Unity game development, C# gameplay programming, interaction systems, UI design, inventory management, audio, and gameplay architecture**.

---

## Gameplay

The core gameplay loop is:

**Customer arrives → Order generated → Gather materials → Assemble bouquet → Fulfill order → Earn points → Next customer**

Customers can request different combinations of flowers, ribbons, and wrapping paper.

Example:

```text
Rose × 2
Sunflower × 1

Ribbon: Blue
Wrapping: Green
```

The player must collect the required materials and correctly assemble the bouquet before the customer's patience runs out.

---

## Features

### Player

* First-person player controller
* Mouse-look camera system
* Camera boundary handling
* Unity New Input System
* Raycast-based interaction system

### Customer System

* Customer spawning and lifecycle management
* Multiple customer character variants
* Customer movement and rotation
* Waiting and leaving behaviour
* Customer patience timer
* Automatic customer respawning
* Customer interaction with the order system

### Order & Gameplay Systems

* Randomly generated bouquet orders
* Multiple flower types
* Ribbon selection
* Wrapping selection
* Bouquet assembly system
* Order validation
* Wrong-order handling
* Customer patience and order deadlines
* Earnings / points system
* Continuous gameplay loop

### Inventory

* Flower inventory management
* Ribbon inventory management
* Quantity tracking
* Physical in-world inventory display

### UI

* World-space customer order display
* World-space inventory board
* Flower selection interface
* Ribbon selection interface
* Bouquet/wrapping selection interface
* Earnings display
* Dynamic UI updates based on gameplay state

### Audio

* Background music
* Looping music system
* Sound effect system
* Flower pickup sound
* UI interaction sounds
* Success and failure feedback
* Customer/order feedback sounds

---

## Architecture

The project is organized around separate gameplay systems rather than placing all game logic into a single script.

```text
Game Systems
│
├── CustomerManager
│   └── Customer spawning and lifecycle
│
├── Customer
│   └── Movement, patience and leaving behaviour
│
├── OrderManager
│   └── Random order generation
│
├── InventoryManager
│   └── Flower and ribbon tracking
│
├── InteractionSystem
│   └── Player interaction with shop stations
│
├── CraftingManager
│   └── Bouquet assembly and order validation
│
├── PointsManager
│   └── Earnings tracking
│
├── AudioManager
│   └── Music and sound effect management
│
└── UI Systems
    ├── World Order UI
    ├── Inventory UI
    ├── Flower Selection UI
    ├── Ribbon Selection UI
    ├── Bouquet Selection UI
    └── Earnings UI
```

This separation allows individual gameplay systems to be developed and modified independently.

---

## Tech Stack

* **Engine:** Unity
* **Language:** C#
* **Input:** Unity New Input System
* **UI:** Unity UI / TextMeshPro
* **Audio:** Unity Audio System
* **Version Control:** Git / GitHub

---

## External Assets

This project uses third-party Unity assets for visual elements, character models, environment props, and audio.

These assets are **not included in this repository** where redistribution is not permitted. They must be obtained separately from their original sources.

### Visual Assets

* **Stylized Hand-Painted Plant & Flower Pack** — Patchmesh
  Used for flower models and shop decorations.

* **Girl & Boy Characters**
  Used for customer character models.

* **Stylized Low Poly Coffee Shop Props Pack – Free**
  Used for shop environment and decorative props.

### Audio Assets

Third-party audio assets are used for background music and sound effects.

Refer to the original asset sources and their respective licenses for usage and redistribution terms.

> Third-party assets are excluded from the repository where required by their licensing terms. The custom gameplay code, systems, scenes, and UI created for this project remain part of the project repository.

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
* World-space UI
* Dictionaries and enums
* Unity Inspector references
* Coroutines and delayed gameplay events
* AudioSources and sound effect management
* Gameplay state management
* Separation of gameplay responsibilities
* Basic game architecture
* Iterative debugging and feature development

Rather than following a complete game tutorial, the project was built incrementally by learning individual systems and immediately implementing them into the game.

---

## Development Approach

The project was developed iteratively.

Each gameplay feature was built as an independent system and then integrated into the existing gameplay loop. This included:

1. Building the player controller and interaction system
2. Creating the inventory system
3. Implementing customer spawning and movement
4. Generating randomized orders
5. Building the bouquet assembly and validation systems
6. Adding the points and earnings system
7. Reworking the UI into world-space interfaces
8. Adding background music and gameplay sound effects
9. Iteratively debugging and polishing the gameplay experience

This approach helped me understand how individual gameplay systems communicate with each other while keeping responsibilities separated across different scripts.

---

## Current Status

**Playable Prototype**

The core gameplay loop is functional from customer arrival through order completion.

Current development is focused on **polishing the gameplay experience and expanding the simulation** rather than building the initial gameplay foundation.

Current areas of improvement include:

* Visual polish
* Customer feedback
* Animations
* Game feel
* Additional gameplay systems
* More content and variety

---

## Planned Features

Future iterations may include:

* More flower types
* More bouquet recipes
* Stock and restocking mechanics
* More advanced customer behaviour
* Additional customer personalities
* Wrong-order penalties
* Expanded shop economy
* Shop upgrades
* Day progression
* Save/load system
* Additional visual effects
* More animations
* Expanded audio feedback

---

## Project Goal

This project was created as a focused introduction to **Unity game programming**, with an emphasis on understanding how gameplay systems communicate with each other rather than only producing visual assets.

The long-term goal is to turn the prototype into a small, polished, and complete playable game while continuing to explore Unity and C# game development.

---

## Author

**Ishika R Dev**

More features and improvements coming as development continues.
