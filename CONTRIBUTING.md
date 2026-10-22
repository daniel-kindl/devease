# Contributing to DevEase

## Principles
- SOLID, DRY, KISS, YAGNI, orthogonality
- Short-lived feature branches
- Conventional Commits
- Semantic Versioning (tags)

## Branching
- `main` is always releasable
- Feature work on `feat/short-name` (or `fix/`, `docs/`)
- Open a PR, review, merge, delete branch

## Commits
Use Conventional Commits:
- `feat: add design auto-promote skeleton`
- `fix: prevent double promotion`
- `docs: update architecture notes`
- `refactor: extract game helpers`

## Versioning
Tag releases with SemVer (`v0.1.0`, `v0.2.0`, …).
Update version in `src/meta.tyd` when tagging.

## Testing
Pure logic should be extractable and unit-tested where feasible.
Game-dependent code is integration-only due to Workshop/C# 3 constraints.

## Code style
- C# 3 compatible (no enums, no modern language features)
- One responsibility per class
- Generic queries only (no hardcoded content names)
- Opt-in features via settings
