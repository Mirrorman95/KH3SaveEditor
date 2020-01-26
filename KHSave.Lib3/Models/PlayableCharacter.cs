﻿/*
    Kingdom Hearts Save Editor
    Copyright (C) 2019 Luciano Ciccariello

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

using System.Collections.Generic;
using Xe.BinaryMapper;

namespace KHSave.Lib3.Models
{
	public class PlayableCharacter
	{
        [Data(0x6)] public byte CurrentWeaponIndex { get; set; }
        [Data(0x80, 3, 8)] public List<WeaponEquipmentItem> Weapons { get; set; }
		[Data(0x98, 8, 8)] public List<ArmorEquipmentItem> Armors { get; set; }
		[Data(0xD8, 8, 8)] public List<AccessoryEquipmentItem> Accessories { get; set; }
		[Data(0x118, 8, 8)] public List<ConsumableEquipmentItem> Items { get; set; }
		[Data(0x158)] public byte AiCombatStyle { get; set; }
		[Data(0x158)] public byte AiAbilities { get; set; }
		[Data(0x158)] public AiModel Ai { get; set; }
		[Data(0x160, 512, 4)] public List<Ability> Abilities { get; set; }
		[Data(0x980)] public byte AtkBoost { get; set; }
		[Data] public byte MagBoost { get; set; }
		[Data] public byte DefBoost { get; set; }
		[Data] public byte ApBoost { get; set; }
		[Data] public int Hp { get; set; }
		[Data] public int Mp { get; set; }
		[Data] public int Focus { get; set; }

		public override string ToString()
		{
			return $"HP {Hp} MP {Mp}";
		}
	}
}