# DevEase

QoL overhaul mod for Software Inc.

- Design Auto-Promote
- Research Queue
- Team Optimizer
- Notification Manager
- Project Helpers

Fully compatible with data mods. Steam Workshop ready (.cs files, C# 3).

## Install (local test)
1. Clone or download this repo
2. Copy the contents of `src/` into `Software Inc/DLLMods/DevEase/`
3. Launch the game with `-DisableModErrors`

## Structure
```
src/
├── meta.tyd
├── DevEaseMeta.cs
├── DevEaseBehaviour.cs
├── Settings.cs
└── Features/
    └── DesignAutoPromote.cs
```
