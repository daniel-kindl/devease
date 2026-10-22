# Architecture

## Constraints
- Steam Workshop requires game compiler → `.cs` files only
- C# 3 only, no enums
- Fully compatible with any data mod (generic access only)

## Structure
- `DevEaseMeta` – metadata and options screen
- `DevEaseBehaviour` – lifecycle, settings, feature coordination
- `Features/*` – single-responsibility feature classes
- `Utils/` – shared generic helpers
- `Settings` – centralized configuration

## Principles applied
- Features are independent and opt-in
- No premature abstraction (YAGNI)
- Shared logic extracted only when duplicated (DRY)
- Open for new features without modifying core (Open/Closed)
