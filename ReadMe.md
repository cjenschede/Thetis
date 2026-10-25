# Thetis — PA3GHM ThetisLink TL2 fork

This repository is a **fork** of [ramdor/Thetis](https://github.com/ramdor/Thetis)
maintained by **PA3GHM (cjenschede)** as the companion build for the
[ThetisLink](https://github.com/cjenschede/ThetisLink) remote-control client.

The fork is actively maintained on branch [`thetislink-tl2`](https://github.com/cjenschede/Thetis/tree/thetislink-tl2).
For the upstream `master` branch (a verbatim mirror of ramdor's archived tree),
switch the branch selector to `master`.

## Latest release

**[`TL2-18`](https://github.com/cjenschede/Thetis/releases/tag/TL2-18)** — drop-in
`Thetis.exe` + `ChannelMaster.dll` + `ReleaseNotes.txt`, base
[`v2.10.3.15`](https://github.com/ramdor/Thetis/releases/tag/v2.10.3.15)
(2 May 2026, last release by ramdor / MW0LGE / Richard Samphire). Released
together with [ThetisLink v2.13.0](https://github.com/cjenschede/ThetisLink/releases/tag/v2.13.0).

The full list of fork changes, build by build, is in `ReleaseNotes.txt`
(also shown by the button in the About box).

## What this fork adds

The fork adds TCI extensions used by ThetisLink, gated behind the
**"ThetisLink extensions"** checkbox in `Setup > Network > IQ Stream`:

- `tci_caps_ex` — capability broadcast so clients auto-detect available extensions
- `auto_recenter_ex` — server-side CTUN recenter (no round-trip); the spectrum
  follows whoever changed the VFO last (`vfo_source_ex`)
- `rx_filter_preset_ex` — per-RX filter preset push (F1..VAR2/NONE)
- `ddc_sample_rate_ex` — per-RX DDC sample rate, up to 1536 kHz (stock cap is 384 kHz)
- `rx_only_ex` — preventive transmit inhibit through Thetis' own "Receive only" flag,
  with a push when it changes
- `tx_queue_report_ex` — one report per transmission on what the TCI TX queue did
- `tci_mix_one_step_ex` — the TCI RX-audio mixer switches in one step on PTT
  release, so receive audio is back sooner
- Diversity auto-null suite (Auto / Smart / Ultra) with live phase/gain circle broadcast
- **TL Lean** — a menu-bar button that turns the displays, panadapter analyzers
  and meter containers off on a station where Thetis only serves ThetisLink,
  and puts them back with a second click
- Push-based state updates that ThetisLink subscribes to

A few fixes apply **regardless of the checkbox**, because they repair defects in
standard Thetis:

- a mode change over TCI now sends the new filter band to every TCI client (TL2-4)
- a TCI client that keyed (TRX or TUNE) and then went away no longer leaves MOX or
  TUNE on (TL2-6, TL2-7)
- closing Thetis with the radio still on no longer stops at an ADC-overload error
  or touches freed network state (TL2-17, TL2-18)

Build identifies as **`PA3GHM TL2-18`** next to the upstream version string in the
title bar.

With the **"ThetisLink extensions"** checkbox **off**, the stock TCI extension
behaviour of upstream v2.10.3.15 is preserved apart from the fixes above (the
fork still carries its own build tag, release notes and About metadata).

## Installation

From the [`TL2-18`](https://github.com/cjenschede/Thetis/releases/tag/TL2-18)
release page:

1. Download `Thetis.exe`, `ChannelMaster.dll` and `ReleaseNotes.txt`
2. Close Thetis. If you use **TL Lean**, switch it off first if you may later
   start another Thetis on the same settings
3. Back up the originals in your Thetis installation folder (e.g. rename
   `Thetis.exe` to `Thetis-original.exe` and `ChannelMaster.dll` to
   `ChannelMaster-original.dll`)
4. Drop in the fork files (overwrite). **Copy `Thetis.exe` and `ChannelMaster.dll`
   together**: since TL2-11 the fork needs its own `ChannelMaster.dll`; with an
   older one Thetis still starts, but without the faster mixer switch and the
   close fixes
5. Start Thetis — verify the title bar shows `PA3GHM TL2-18`

All other files (other DLLs, database, settings) remain unchanged. Revert by
restoring the backed-up originals.

## Upstream

Original Thetis project by Richard Samphire (MW0LGE), maintained from 2019
to 2 April 2026 when it was archived. The upstream releases (with full
per-version change logs) are at:

- Repository: <https://github.com/ramdor/Thetis>
- Releases (per-version change logs): <https://github.com/ramdor/Thetis/releases>
- Last upstream release: [v2.10.3.15](https://github.com/ramdor/Thetis/releases/tag/v2.10.3.15)

Thetis itself derives from PowerSDR (FlexRadio) via OpenHPSDR. The full
provenance chain is documented in [`ATTRIBUTION.md`](ATTRIBUTION.md); the
fork notice and licensing scope are in [`NOTICE.md`](NOTICE.md).

## License

Distributed under **GNU General Public License v2.0-or-later**, same as
upstream:

- [`LICENSE`](LICENSE) — canonical GPLv2 text
- [`LICENSE-DUAL-LICENSING`](LICENSE-DUAL-LICENSING) — Richard Samphire's
  reservation on his own original contributions; does not extend to fork
  modifications introduced here
- [`NOTICE.md`](NOTICE.md) — fork notice
- [`ATTRIBUTION.md`](ATTRIBUTION.md) — upstream lineage and contributor credits

All fork modifications are licensed under GPL-2.0-or-later with no
additional reservation.

## Source diff against upstream

Per-file SPDX headers and `[ThetisLink TL2-N] BEGIN/END` markers (N is the
build that introduced the change) identify fork-modified sections. The
cumulative diff against the upstream base tag is:

```bash
git diff v2.10.3.15..thetislink-tl2 --stat
git log v2.10.3.15..thetislink-tl2 --oneline
```

## Companion application

This fork is the companion build for **ThetisLink v2.13.0** — a remote-control
Rust application for ANAN 7000DLE + Thetis SDR over the network with audio,
spectrum, PTT and full radio control via TCI WebSocket. ThetisLink also works
with stock Thetis v2.10.3.15; the fork adds the extensions listed above.

Repo: <https://github.com/cjenschede/ThetisLink>

73 de PA3GHM
