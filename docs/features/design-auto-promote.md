# Design Auto-Promote – v0.1 Design (Locked)

## Purpose
Automatically handle project progression:
**Design → Alpha → Beta → Release**
with consistent notifications and a simple status dashboard.

## Core Rules
- Feature enabled by default (primary user is the author).
- Notifications are always active when the feature is enabled.
- Release condition = scheduled release day (set by player or publisher).
- Per-project overrides supported.
- Safety checks always applied.

## Global Settings

| Setting | Default | Description |
|---------|---------|-------------|
| Enabled | true | Master toggle |
| Design → Alpha | true | Auto-promote at iteration target |
| Alpha → Beta | true | Auto-promote when Alpha is complete |
| Auto-release | true | Release on the scheduled release day |
| Design iteration target | 3 | Iterations required for Design → Alpha |
| Respect manual hold | true | Skip auto-actions if project is held |
| Only if team assigned | true | Skip if no team is assigned |

## Per-project Overrides
Stored by project / work-item ID. Can override:
- Enable / disable for this project
- Iteration target
- Auto-release
- Only if team assigned

If no override exists, global settings are used.

## Behavior
1. Skip if the project is already past the target phase.
2. Apply per-project override if present, otherwise global settings.
3. If “only if team assigned” is active and no team → skip.
4. If conditions are met and project is not held → promote or release.
5. Always notify on phase change and on the release day.

## Notifications
When the feature is enabled:
- Phase promoted
- Released
- Release day reminder

## Simple Dashboard
Read-only summary showing:
- Active projects being watched
- Current phase
- Progress toward next promotion
- Team assigned (yes/no)
- Scheduled release day
- Override status (global / overridden)
- Last action taken

No editing from the dashboard in v0.1.

## Out of scope for v0.1
- Bug-count based release
- Quality thresholds
- Multi-day advance warnings
- Editing from the dashboard

## Status
**Locked for v0.1 implementation.**
