# ATTRIBUTION — Thetis lineage and contributions

This file documents the upstream lineage of the ThetisLink TL2 fork. For the
fork-statement and license overview, see `NOTICE.md`. For the legal license
text itself, see `LICENSE` (GPL-2.0) and `LICENSE-DUAL-LICENSING` (Richard
Samphire's reservation on his own contributions).

## Project lineage

```
PowerSDR  ──►  OpenHPSDR  ──►  Thetis  ──►  ThetisLink TL2
(FlexRadio)    (community)    (ramdor)        (PA3GHM, this fork)
```

Each step in this chain is a GPL-licensed open-source software project
building on the previous one. The unbroken upstream history of this
repository preserves the contributions of all prior maintainers and
contributors.

## Upstream Thetis (ramdor)

- **Maintainer:** Richard Samphire (MW0LGE) — `mw0lge@grange-lane.co.uk`
- **Repository:** https://github.com/ramdor/Thetis
- **Reference release for this fork:** `v2.10.3.15`
- **Status:** archived 2 April 2026, active again since 2 July 2026 — see upstream `ReadMe.md`

Richard Samphire's contributions to Thetis are dual-licensed: in addition to
the GPL grant (`LICENSE`), he reserves the right to relicense his own work
under different terms, including closed-source / proprietary licenses (see
`LICENSE-DUAL-LICENSING`). That reservation applies **only** to code originally
written by Richard Samphire and does **not** extend to:

- Code contributed to upstream Thetis by other contributors
- ThetisLink modifications introduced in this fork

ThetisLink modifications are licensed under GPL-2.0-or-later, with no
additional reservation.

## OpenHPSDR community

OpenHPSDR is a community-driven fork of PowerSDR that adapted and extended
the original software for the open Hermes / Apache / ANAN hardware family.
Many community contributors are credited in the upstream history. Their
GPL-licensed contributions are preserved in this fork.

## PowerSDR (FlexRadio)

The original codebase was written and released by FlexRadio Systems under
the GPL. Subsequent forks (OpenHPSDR, then Thetis, then this fork) build on
that foundation.

## ThetisLink TL2 contributions

Modifications introduced in this fork (commits between `v2.10.3.15` and the
current branch tip on `thetislink-tl2`):

- **PA3GHM (cjenschede)** — fork maintainer; all ThetisLink-specific
  modifications, scoped behind the "ThetisLink extensions" checkbox in
  `Setup > Network > IQ Stream`, apart from a few fixes of defects in
  standard Thetis that apply regardless of it (listed in `ReleaseNotes.txt`).

Per-file modification markers within source files identify which functions or
sections were changed and the date of change. The cumulative `git diff` from
`v2.10.3.15` to the current branch tip is the authoritative record of all
fork changes.

## How to inspect the diff

```text
git -C cjenschede/Thetis diff v2.10.3.15..thetislink-tl2 --stat
git -C cjenschede/Thetis log v2.10.3.15..thetislink-tl2 --oneline
```

These commands show every modification this fork makes relative to upstream.
