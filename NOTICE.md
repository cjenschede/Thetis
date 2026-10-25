# NOTICE — ThetisLink TL2 fork of Thetis

ThetisLink TL2 is a fork of [Thetis](https://github.com/ramdor/Thetis)
by Richard Samphire (MW0LGE) — see upstream
[ramdor/Thetis@v2.10.3.15](https://github.com/ramdor/Thetis/releases/tag/v2.10.3.15)
as the base point of this fork.

## Upstream

- **Project:** Thetis
- **Upstream maintainer:** Richard Samphire (MW0LGE)
- **Upstream repository:** https://github.com/ramdor/Thetis
- **Upstream status:** archived 2 April 2026, active again since 2 July 2026 (see upstream ReadMe.md)
- **Base tag for this fork:** `v2.10.3.15`
- **License:** GNU General Public License, version 2 or later (`GPL-2.0-or-later`),
  see `LICENSE`
- **Author dual-licensing reservation:** Richard Samphire reserves the right to
  re-license his own contributions under different terms; see
  `LICENSE-DUAL-LICENSING`. This reservation applies only to code originally
  written by Richard Samphire — it does not extend to code contributed by
  others, including this fork's ThetisLink modifications.

## This fork

- **Fork name:** ThetisLink TL2 (current build: TL2-18)
- **Fork maintainer:** PA3GHM (cjenschede)
- **Branch:** `thetislink-tl2`
- **Purpose:** companion application support for the
  [ThetisLink](https://github.com/cjenschede/ThetisLink) remote-control client.
  All ThetisLink-specific TCI extensions are gated behind a single
  "ThetisLink extensions" checkbox in `Setup > Network > IQ Stream`.
  With the checkbox **off**, the stock TCI extension behavior of upstream
  v2.10.3.15 is preserved (the fork still carries its own build tag,
  release notes and About metadata), except for a few fixes of defects in
  standard Thetis that apply regardless of the checkbox (TL2-4, TL2-6,
  TL2-7, TL2-17, TL2-18; see `ReleaseNotes.txt`). With the checkbox **on**, additional
  `_ex` TCI commands and push notifications are enabled for ThetisLink
  clients.
- **Modifications:** see the per-file modification markers (author and date); the
  cumulative diff against `v2.10.3.15` is the complete set of fork changes.
- **License of modifications:** GNU General Public License, version 2 or later
  (`GPL-2.0-or-later`) — same as upstream. The dual-licensing reservation in
  `LICENSE-DUAL-LICENSING` is **not** claimed for ThetisLink modifications.

## Pre-upstream heritage

Thetis itself derives from earlier open-source SDR projects:

- **PowerSDR** — original software-defined-radio platform by FlexRadio Systems
- **OpenHPSDR** — community fork supporting the open Hermes/Apache hardware
  family, from which the Thetis lineage continues

Both ancestor projects are GPL-licensed; their contributions are preserved
through the unbroken upstream history of this repository.

## Build identification

Builds produced from this fork display `PA3GHM TL2-N` (currently `PA3GHM TL2-18`)
next to the upstream version string in the title bar.
