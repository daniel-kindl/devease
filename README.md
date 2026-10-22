# DevEase

QoL overhaul for Software Inc. development, research, teams and project management.

Fully compatible with data mods. Steam Workshop ready (.cs files only, C# 3).

## Features (opt-in)
- Design Auto-Promote
- Research Queue
- Team Optimizer
- Notification Manager
- Project Helpers

## Local testing
1. Clone this repository
2. Copy the contents of `src/` into `Software Inc/DLLMods/DevEase/`
3. Launch the game with `-DisableModErrors`

## Development
See [CONTRIBUTING.md](CONTRIBUTING.md) for standards, branching and commit conventions.

## Structure
```
src/                  # Workshop payload
├── meta.tyd
├── DevEaseMeta.cs
├── DevEaseBehaviour.cs
├── Settings.cs
├── Features/
└── Utils/
docs/
└── architecture.md
```
