//=================================================================
// titlebar.cs
//=================================================================
// PowerSDR is a C# implementation of a Software Defined Radio.
// Copyright (C) 2004-2012  FlexRadio Systems 
// Copyright (C) 2010-2020  Doug Wigley
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
//
// You may contact us via email at: gpl@flexradio.com.
// Paper mail may be sent to: 
//    FlexRadio Systems
//    4616 W. Howard Lane  Suite 1-150
//    Austin, TX 78728
//    USA
//
//=================================================================
// Continual modifications Copyright (C) 2019-2026 Richard Samphire (MW0LGE)
//=================================================================
//
//============================================================================================//
// Dual-Licensing Statement (Applies Only to Author's Contributions, Richard Samphire MW0LGE) //
// ------------------------------------------------------------------------------------------ //
// For any code originally written by Richard Samphire MW0LGE, or for any modifications       //
// made by him, the copyright holder for those portions (Richard Samphire) reserves the       //
// right to use, license, and distribute such code under different terms, including           //
// closed-source and proprietary licences, in addition to the GNU General Public License      //
// granted above. Nothing in this statement restricts any rights granted to recipients under  //
// the GNU GPL. Code contributed by others (not Richard Samphire) remains licensed under      //
// its original terms and is not affected by this dual-licensing statement in any way.        //
// Richard Samphire can be reached by email at :  mw0lge@grange-lane.co.uk                    //
//============================================================================================//
//
//================================================================================================//
// SPDX-License-Identifier: GPL-2.0-or-later                                                       //
// ThetisLink TL2-1 fork modifications by PA3GHM (cjenschede), starting 2026-05-06.                //
// Title-bar build-tag "PA3GHM TL2-1" appended next to upstream "MW0LGE" tag (NOTICE.md).          //
// See NOTICE.md and ATTRIBUTION.md in the repository root for fork details.                       //
//================================================================================================//

using System;
using System.Diagnostics;
using System.Reflection;

namespace Thetis
{
    class TitleBar
    {
        public const string BUILD_NAME = "MW0LGE";
        // [ThetisLink TL2-1] BEGIN — modification by PA3GHM (cjenschede), 2026-05-06
        // [ThetisLink TL2-11] BEGIN — value bump TL2-10 → TL2-11 (cjenschede, 2026-10-21)
        public const string FORK_BUILD_NAME = "PA3GHM TL2-11";
        // [ThetisLink TL2-11] END
        // [ThetisLink TL2-1] END
        public static string GetString(bool bWithFirmware = true)
        {
            string sRevision = "." + Common.GetRevision();
            if (sRevision == ".0") sRevision = "";

            string version = Common.GetVerNum() + sRevision;
            string s = "Thetis";

            string sBits = Common.Is64Bit ? " x64" : " x86";

            s += " v" + version + sBits;
            s += " (" + VersionInfo.BuildDate + ")<FW>";  //[2.10.2.2]MW0LGE use the auto generated class from pre build event for the BuildDate

            if (BUILD_NAME != "") s += " " + BUILD_NAME;
            // [ThetisLink TL2-1] BEGIN
            if (FORK_BUILD_NAME != "") s += " " + FORK_BUILD_NAME;
            // [ThetisLink TL2-1] END

            if (!bWithFirmware) s = s.Replace("<FW>", "");

            return s;
        }
    }
}