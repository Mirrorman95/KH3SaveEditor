﻿using KHSave.Lib2.Types;
using Xe.BinaryMapper;

namespace KHSave.Lib2.Models
{
    public class Character
    {
        [Data] public EquipmentType Weapon { get; set; }
        [Data] public short Unk02 { get; set; }
        [Data] public byte HpCur { get; set; }
        [Data] public byte HpMax { get; set; }
        [Data] public byte MpCur { get; set; }
        [Data] public byte MpMax { get; set; }
        [Data] public byte ApBoost { get; set; }
        [Data] public byte StrengthBoost { get; set; }
        [Data] public byte MagicBoost { get; set; }
        [Data] public byte DefenseBoost { get; set; }
        [Data] public byte Unk0c { get; set; }
        [Data] public byte Unk0d { get; set; }
        [Data] public byte Unk0e { get; set; }
        [Data] public byte Level { get; set; }
        [Data] public byte ArmorCount { get; set; }
        [Data] public byte AccessoryCount { get; set; }
        [Data] public byte ItemCount { get; set; }
        [Data] public byte UnknownCount { get; set; }
        [Data(Count = 8)] public short[] Armors { get; set; }
        [Data(Count = 8)] public short[] Accessories { get; set; }
        [Data(Count = 8)] public short[] Items { get; set; }
        [Data(Count = 8)] public short[] ItemAutoReload { get; set; }

        [Data(0x54, Count = 0x8e)] public byte[] Abilities { get; set; }

        [Data(0xf4)] public BattleStyleType BattleStyle { get; set; }
        [Data(0xfc)] public AbilityStyleType AbilityStyle1 { get; set; }
        [Data] public AbilityStyleType AbilityStyle2 { get; set; }
        [Data] public AbilityStyleType AbilityStyle3 { get; set; }
        [Data] public AbilityStyleType AbilityStyle4 { get; set; }
    }
}
