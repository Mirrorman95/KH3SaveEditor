﻿/*
    Kingdom Hearts 0.2 and 3 Save Editor
    Copyright (C) 2019  Luciano Ciccariello

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using KHSave.Attributes;

namespace KHSave.Types
{
	public enum ArmorType : byte
	{
		Empty,
		Unknown01,
		Unknown02,
		Unknown03,
		Unknown04,
		Unknown05,
		Unknown06,
		[Armor("Buster Band")] BusterBand,
		[Armor("Buster Band+")] BusterBandPlus,
		[Armor("Cosmic Belt")] CosmicBelt,
		[Armor("Cosmic Belt+")] CosmicBeltPlus,
		[Armor("Fire Bangle")] FireBangle,
		Unknown0c,
		Unknown0d,
		Unknown0e,
		Unknown0f,
		Unknown10,
		Unknown11,
		Unknown12,
		Unknown13,
		Unknown14,
		Unknown15,
		Unknown16,
		Unknown17,
		Unknown18,
		Unknown19,
		Unknown1a,
		Unknown1b,
		Unknown1c,
		Unknown1d,
		Unknown1e,
		Unknown1f,
		Unknown20,
		Unknown21,
		[Armor("Arcisus")] Arcisus,
		[Armor("Cosmic Chain")] CosmicChain,
		[Armor("Petite Ribbon")] PetiteRibbon,
		[Armor("Ribbon")] Ribbon,
		Unknown26,
		Unknown27,
		Unknown28,
		Unknown29,
		Unknown2a,
		Unknown2b,
		[Armor("Royal Ribbon")] RoyalRibbon,
		Unknown2d,
		Unknown2e,
		Unknown2f,
	}
}
