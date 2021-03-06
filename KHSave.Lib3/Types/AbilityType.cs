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

using KHSave.Attributes;

namespace KHSave.Lib3.Types
{
	public enum AbilityType
    {
        [Info("<untested>")] Ability000,
		[AbilityAction("Aerial Recovery")] Ability001,
		[AbilityAction("Payback Strike")] Ability002,
		[AbilityAction("Block")] Ability003,
		[AbilityAction("Counter Slash")] Ability004,
		[AbilityAction("Counter Impact")] Ability005,
		[AbilityAction("Counter Kick")] Ability006,
		[AbilityAction("Final Blow")] Ability007,
		[AbilityAction("Risk Dodge")] Ability008,
        [AbilityAction("<unnamed>")] Ability009,
		[AbilityAction("Rising Spiral")] Ability00A,
		[AbilityAction("Groundbreaker")] Ability00B,
		[AbilityAction("Falling Slash")] Ability00C,
		[AbilityAction("Speed Slash")] Ability00D,
		[AbilityAction("Triple Rush")] Ability00E,
		[AbilityAction("Magic Flash")] Ability00F,
		[AbilityMobility("High Jump")] Ability010,
		[AbilityMobility("Doubleflight")] Ability011,
		[AbilityMobility("Superjump")] Ability012,
		[AbilityMobility("Superslide")] Ability013,
		[AbilityMobility("Glide")] Ability014,
		[AbilitySupport("Scan")] Ability015,
		[AbilityMobility("Dodge Roll")] Ability016,
		[AbilityMobility("Air Slide")] Ability017,
		[AbilityMobility("Aerial Dodge")] Ability018,
		[AbilitySupport("MP Safety")] Ability019,
		[AbilitySupport("Zero EXP")] Ability01A,
		[AbilitySupport("Assist Friends")] Ability01B,
		[AbilitySupport("Combo Plus")] Ability01C,
		[AbilitySupport("Air Combo Plus")] Ability01D,
		[AbilitySupport("Combo Master")] Ability01E,
		[AbilitySupport("Combo Boost")] Ability01F,
		[AbilitySupport("Air Combo Boost")] Ability020,
		[AbilitySupport("Fire Boost")] Ability021,
		[AbilitySupport("Blizzard Boost")] Ability022,
		[AbilitySupport("Thunder Boost")] Ability023,
		[AbilitySupport("Water Boost")] Ability024,
		[AbilitySupport("Aero Boost")] Ability025,
		[AbilitySupport("Wizard´s Ruse")] Ability026,
		[AbilitySupport("Lucky Strike")] Ability027,
		[AbilitySupport("Item Boost")] Ability028,
		[AbilitySupport("Treasure Magnet")] Ability029,
		[AbilitySupport("No name")] Ability02A,
		[AbilitySupport("Leaf Bracer")] Ability02B,
		[AbilitySupport("Second Chance")] Ability02C,
		[AbilitySupport("Withstand Combo")] Ability02D,
		[AbilityAction("Focus Syphon")] Ability02E,
		[AbilitySupport("Attraction Extender")] Ability02F,
		[AbilitySupport("Link Extender")] Ability030,
		[AbilitySupport("Formchange Extender")] Ability031,
		[AbilitySupport("Defender")] Ability032,
		[AbilitySupport("Damage Control")] Ability033,
		[AbilitySupport("Damage Syphon")] Ability034,
		[AbilitySupport("MP Haste")] Ability035,
		[AbilitySupport("MP Hastera")] Ability036,
		[AbilitySupport("MP Hastega")] Ability037,
		[AbilitySupport("Magic Combo Thrift")] Ability038,
		[AbilitySupport("Magic Galvanizer")] Ability039,
		[AbilitySupport("MP Walker")] Ability03A,
		[AbilitySupport("HP Walker")] Ability03B,
		[AbilitySupport("Magic Treasure Magnet")] Ability03C,
		[AbilitySupport("Master Treasure Magnet")] Ability03D,
		[AbilitySupport("Attraction Enhancer")] Ability03E,
		[AbilitySupport("Burn Protection")] Ability03F,
		[AbilitySupport("Cloud Protection")] Ability040,
		[AbilitySupport("Sneeze Protection")] Ability041,
		[AbilitySupport("Freeze Protection")] Ability042,
		[AbilitySupport("Electric Protection")] Ability043,
		[AbilitySupport("Stun Protection")] Ability044,
		[AbilitySupport("Reprisal Boost")] Ability045,
		[AbilitySupport("Auto-Finish")] Ability046,
		[AbilitySupport("Situation Boost")] Ability047,
		[AbilitySupport("Grand Magic Extender")] Ability048,
		[AbilitySupport("Magic Lock-On")] Ability049,
		[AbilitySupport("Block Replenisher")] Ability04A,
		[AbilitySupport("MP Thrift")] Ability04B,
		[AbilitySupport("Extra Cast")] Ability04C,
		[AbilitySupport("Full MP Blast")] Ability04D,
		[AbilitySupport("Harvester")] Ability04E,
		[AbilitySupport("HP Converter")] Ability04F,
		[AbilitySupport("MP  Converter")] Ability050,
		[AbilitySupport("Munny Converter")] Ability051,
		[AbilitySupport("Endless Magic")] Ability052,
		[AbilitySupport("Focus Converter")] Ability053,
		[AbilitySupport("Fire Syphon")] Ability054,
		[AbilitySupport("Blizzard Syphon")] Ability055,
		[AbilitySupport("Thunder Syphon")] Ability056,
		[AbilitySupport("Water Syphon")] Ability057,
		[AbilitySupport("Aero Syphon")] Ability058,
		[AbilitySupport("Dark Syphon")] Ability059,
		[AbilitySupport("Team Effort")] Ability05A,
		[AbilityAction("Sonic Slash")] Ability05B,
		[AbilityAction("Sonic Cleave")] Ability05C,
		[AbilityAction("Buzz Saw")] Ability05D,
		[AbilityAction("Somersault")] Ability05E,
		[AbilityMobility("Pole Spin")] Ability05F,
		[AbilityMobility("Pole Swing")] Ability060,
		[AbilityMobility("Wall Kick")] Ability061,
		[AbilitySupport("Frontline Photographer")] Ability062,
		[AbilitySupport("Chef Extraordinaire")] Ability063,
		[AbilitySupport("Double Team")] Ability064,
		[AbilitySupport("Heartless Buster")] Ability065,
		[AbilitySupport("Nobody Buster")] Ability066,
		[AbilitySupport("Cure Converter")] Ability067,
		[AbilitySupport("Critical Counter")] Ability068,
		[AbilitySupport("Critical Recharge")] Ability069,
		[AbilitySupport("Critical Converter")] Ability06A,
		[Unused] Ability06B,
		[Unused] Ability06C,
		[Unused] Ability06D,
		[Unused] Ability06E,
		[Unused] Ability06F,
		[Unused] Ability070,
		[Unused] Ability071,
		[Unused] Ability072,
		[Unused] Ability073,
		[Unused] Ability074,
		[Unused] Ability075,
		[Unused] Ability076,
		[Unused] Ability077,
		[Unused] Ability078,
		[Unused] Ability079,
		[Unused] Ability07A,
		[Unused] Ability07B,
		[Unused] Ability07C,
		[Unused] Ability07D,
		[Unused] Ability07E,
		[Unused] Ability07F,
		[Unused] Ability080,
		[Unused] Ability081,
		[Unused] Ability082,
		[Unused] Ability083,
		[Unused] Ability084,
		[Unused] Ability085,
		[Unused] Ability086,
		[Unused] Ability087,
		[Unused] Ability088,
		[Unused] Ability089,
		[Unused] Ability08A,
		[Unused] Ability08B,
		[Unused] Ability08C,
		[Unused] Ability08D,
		[Unused] Ability08E,
		[Unused] Ability08F,
		[Unused] Ability090,
		[Unused] Ability091,
		[Unused] Ability092,
		[Unused] Ability093,
		[Unused] Ability094,
		[Unused] Ability095,
		[Unused] Ability096,
		[Unused] Ability097,
		[Unused] Ability098,
		[Unused] Ability099,
		[Unused] Ability09A,
		[Unused] Ability09B,
		[Unused] Ability09C,
		[Unused] Ability09D,
		[Unused] Ability09E,
		[Unused] Ability09F,
		[Unused] Ability0A0,
		[Unused] Ability0A1,
		[Unused] Ability0A2,
		[Unused] Ability0A3,
		[Unused] Ability0A4,
		[Unused] Ability0A5,
		[Unused] Ability0A6,
		[Unused] Ability0A7,
		[Unused] Ability0A8,
		[Unused] Ability0A9,
        [AbilitySupport("Cuisine Extender")] Ability0AA,
        [AbilitySupport("Hearty Meal")] Ability0AB,
        [AbilitySupport("Overtime")] Ability0AC,
        [AbilitySupport("Top Condition")] Ability0AD,
        [AbilitySupport("EXP Incentive")] Ability0AE,
        [AbilitySupport("Prize Proliferator")] Ability0AF,
        [AbilitySupport("Rags to Riches")] Ability0B0,
        [AbilitySupport("Curaza")] Ability0B1,
        [AbilitySupport("Berserk Change")] Ability0B2,
        [AbilitySupport("Hidden Potential")] Ability0B3,
        [AbilitySupport("More Grand Magic")] Ability0B4,
        [AbilitySupport("Firaza")] Ability0B5,
        [AbilitySupport("Blizzaza")] Ability0B6,
        [AbilitySupport("Thundaza")] Ability0B7,
        [AbilitySupport("Waterza")] Ability0B8,
        [AbilitySupport("Aeroza")] Ability0B9,
        [Unused] Ability0BA,
        [Unused] Ability0BB,
        [Unused] Ability0BC,
        [Unused] Ability0BD,
        [AbilityAction("Unison Fire")] Ability0BE,
        [AbilityAction("Unison Blizzard")] Ability0BF,
        [AbilityAction("Unison Thunder")] Ability0C0,
        [AbilityAction("Fusion Spin")] Ability0C1,
        [AbilityAction("Fusion Rocket")] Ability0C2,
        [AbilitySupport("Hyper Healing")] Ability0C3,
        [AbilitySupport("More Team Attacks")] Ability0C4,
        [AbilitySupport("Team Attack Extender")] Ability0C5,
        [AbilitySupport("Share Prizes")] Ability0C6,
        [AbilityAction("<unnamed>")] Ability0C7,
        [AbilityAction("<unnamed>")] Ability0C8,
        [AbilityAction("Donald Fire")] Ability0C9,
        [AbilityAction("Donald Blizzard")] Ability0CA,
        [AbilityAction("Donald Thunder")] Ability0CB,
        [AbilityAction("Donald Aero")] Ability0CC,
        [AbilityAction("Donald Cure")] Ability0CD,
        [AbilityAction("Goofy Tornado")] Ability0CE,
        [AbilityAction("Goofy Turbo")] Ability0CF,
        [AbilityAction("Goofy Discus")] Ability0D0,
        [AbilityAction("Boulder Toss")] Ability0D1,
        [AbilityAction("Burst of Energy")] Ability0D2,
        [AbilityAction("Shoulder Tackle")] Ability0D3,
        [AbilityAction("Lasso Attack")] Ability0D4,
        [AbilityAction("Laser Beam")] Ability0D5,
        [AbilityAction("Spinning Lariat")] Ability0D6,
        [AbilityAction("<untested???>")] Ability0D7,
        [AbilityAction("<untested???>")] Ability0D8,
        [AbilityAction("Frying Pan Toss")] Ability0D9,
        [AbilityAction("Barrel Bash")] Ability0DA,
        [AbilityAction("Monster Roar")] Ability0DB,
        [AbilityAction("Takedown")] Ability0DC,
        [AbilityAction("Googly Appeal")] Ability0DD,
        [AbilityAction("Pep Talk")] Ability0DE,
        [AbilityAction("Bone Crusher")] Ability0DF,
        [AbilityAction("Rolling Lunge")] Ability0E0,
        [AbilityAction("Leaping Smash")] Ability0E1,
        [AbilityAction("Cold Breath")] Ability0E2,
        [AbilityAction("Booster Punch")] Ability0E3,
        [AbilityAction("Care Spray")] Ability0E4,
        [AbilityAction("<unnamed>")] Ability0E5,
        [AbilityAction("<unnamed>")] Ability0E6,
        [AbilityAction("<unnamed>")] Ability0E7,
        [AbilityAction("<unnamed>")] Ability0E8,
        [AbilityAction("<unnamed>")] Ability0E9,
        [AbilityAction("<unnamed>")] Ability0EA,
        [AbilityAction("<unnamed>")] Ability0EB,
        [AbilityAction("<unnamed>")] Ability0EC,
        [AbilityAction("<unnamed>")] Ability0ED,
        [AbilityAction("<unnamed>")] Ability0EE,
        [Unused] Ability0EF,
        [AbilityAction("<unnamed>")] Ability0F0,
        [AbilityAction("<unnamed>")] Ability0F1,
        [Unused] Ability0F2,
		[Unused] Ability0F3,
		[Unused] Ability0F4,
		[Unused] Ability0F5,
		[Unused] Ability0F6,
		[Unused] Ability0F7,
		[Unused] Ability0F8,
		[Unused] Ability0F9,
		[Unused] Ability0FA,
		[Unused] Ability0FB,
		[Unused] Ability0FC,
		[Unused] Ability0FD,
		[Unused] Ability0FE,
		[Unused] Ability0FF,
        [Unused] Ability100,
		Ability101,
		Ability102,
		Ability103,
		Ability104,
		Ability105,
		Ability106,
		Ability107,
		Ability108,
		Ability109,
		Ability10A,
		Ability10B,
		Ability10C,
		Ability10D,
		Ability10E,
		Ability10F,
		Ability110,
		Ability111,
		Ability112,
		Ability113,
		Ability114,
		Ability115,
		Ability116,
		Ability117,
		Ability118,
		Ability119,
		Ability11A,
		Ability11B,
		Ability11C,
		Ability11D,
		Ability11E,
		Ability11F,
		Ability120,
		Ability121,
		Ability122,
		Ability123,
		Ability124,
		Ability125,
		Ability126,
		Ability127,
		Ability128,
		Ability129,
		Ability12A,
		Ability12B,
		Ability12C,
		Ability12D,
		Ability12E,
		Ability12F,
		Ability130,
		Ability131,
		Ability132,
		Ability133,
		Ability134,
		Ability135,
		Ability136,
		Ability137,
		Ability138,
		Ability139,
		Ability13A,
		Ability13B,
		Ability13C,
		Ability13D,
		Ability13E,
		Ability13F,
		Ability140,
		Ability141,
		Ability142,
		Ability143,
		Ability144,
		Ability145,
		Ability146,
		Ability147,
		Ability148,
		Ability149,
		Ability14A,
		Ability14B,
		Ability14C,
		Ability14D,
		Ability14E,
		Ability14F,
		Ability150,
		Ability151,
		Ability152,
		Ability153,
		Ability154,
		Ability155,
		Ability156,
		Ability157,
		Ability158,
		Ability159,
		Ability15A,
		Ability15B,
		Ability15C,
		Ability15D,
		[Unused] Ability15E,
		[Unused] Ability15F,
        [Unused] Ability160,
		Ability161,
		Ability162,
		Ability163,
		Ability164,
		Ability165,
		Ability166,
		Ability167,
		Ability168,
		[Unused] Ability169,
		[Unused] Ability16A,
		[Unused] Ability16B,
		[Unused] Ability16C,
		[Unused] Ability16D,
		[Unused] Ability16E,
		[Unused] Ability16F,
		[Unused] Ability170,
		[Unused] Ability171,
		[Unused] Ability172,
		[Unused] Ability173,
		[Unused] Ability174,
		[Unused] Ability175,
		[Unused] Ability176,
		[Unused] Ability177,
		[Unused] Ability178,
		[Unused] Ability179,
		[Unused] Ability17A,
		[Unused] Ability17B,
		[Unused] Ability17C,
		[Unused] Ability17D,
		[Unused] Ability17E,
		[Unused] Ability17F,
		[Unused] Ability180,
		[Unused] Ability181,
		[Unused] Ability182,
		[Unused] Ability183,
		[Unused] Ability184,
		[Unused] Ability185,
		[Unused] Ability186,
		[Unused] Ability187,
		[Unused] Ability188,
		[Unused] Ability189,
		[Unused] Ability18A,
		[Unused] Ability18B,
		[Unused] Ability18C,
		[Unused] Ability18D,
		[Unused] Ability18E,
		[Unused] Ability18F,
		[Unused] Ability190,
		[Unused] Ability191,
		[Unused] Ability192,
		[Unused] Ability193,
		[Unused] Ability194,
		[Unused] Ability195,
		[Unused] Ability196,
		[Unused] Ability197,
		[Unused] Ability198,
		[Unused] Ability199,
		[Unused] Ability19A,
		[Unused] Ability19B,
		[Unused] Ability19C,
		[Unused] Ability19D,
		[Unused] Ability19E,
		[Unused] Ability19F,
		[Unused] Ability1A0,
		[Unused] Ability1A1,
		[Unused] Ability1A2,
		[Unused] Ability1A3,
		[Unused] Ability1A4,
		[Unused] Ability1A5,
		[Unused] Ability1A6,
		[Unused] Ability1A7,
		[Unused] Ability1A8,
		[Unused] Ability1A9,
		[Unused] Ability1AA,
		[Unused] Ability1AB,
		[Unused] Ability1AC,
		[Unused] Ability1AD,
		[Unused] Ability1AE,
		[Unused] Ability1AF,
		[Unused] Ability1B0,
		[Unused] Ability1B1,
		[Unused] Ability1B2,
		[Unused] Ability1B3,
		[Unused] Ability1B4,
		[Unused] Ability1B5,
		[Unused] Ability1B6,
		[Unused] Ability1B7,
		[Unused] Ability1B8,
		[Unused] Ability1B9,
		[Unused] Ability1BA,
		[Unused] Ability1BB,
		[Unused] Ability1BC,
		[Unused] Ability1BD,
		[Unused] Ability1BE,
		[Unused] Ability1BF,
		[Unused] Ability1C0,
		[Unused] Ability1C1,
		[Unused] Ability1C2,
		[Unused] Ability1C3,
		[Unused] Ability1C4,
		[Unused] Ability1C5,
		[Unused] Ability1C6,
		[Unused] Ability1C7,
		[Unused] Ability1C8,
		[Unused] Ability1C9,
		[Unused] Ability1CA,
		[Unused] Ability1CB,
		[Unused] Ability1CC,
		[Unused] Ability1CD,
		[Unused] Ability1CE,
		[Unused] Ability1CF,
		[Unused] Ability1D0,
		[Unused] Ability1D1,
		[Unused] Ability1D2,
		[Unused] Ability1D3,
		[Unused] Ability1D4,
		[Unused] Ability1D5,
		[Unused] Ability1D6,
		[Unused] Ability1D7,
		[Unused] Ability1D8,
		[Unused] Ability1D9,
		[Unused] Ability1DA,
		[Unused] Ability1DB,
		[Unused] Ability1DC,
		[Unused] Ability1DD,
		[Unused] Ability1DE,
		[Unused] Ability1DF,
		[Unused] Ability1E0,
		[Unused] Ability1E1,
		[Unused] Ability1E2,
		[Unused] Ability1E3,
		[Unused] Ability1E4,
		[Unused] Ability1E5,
		[Unused] Ability1E6,
		[Unused] Ability1E7,
		[Unused] Ability1E8,
		[Unused] Ability1E9,
		[Unused] Ability1EA,
		[Unused] Ability1EB,
		[Unused] Ability1EC,
		[Unused] Ability1ED,
		[Unused] Ability1EE,
		[Unused] Ability1EF,
		[Unused] Ability1F0,
		[Unused] Ability1F1,
		[Unused] Ability1F2,
		[Unused] Ability1F3,
		[Unused] Ability1F4,
		[Unused] Ability1F5,
		[Unused] Ability1F6,
		[Unused] Ability1F7,
		[Unused] Ability1F8,
		[Unused] Ability1F9,
		[Unused] Ability1FA,
		[Unused] Ability1FB,
		[Unused] Ability1FC,
		[Unused] Ability1FD,
		[Unused] Ability1FE,
        [Unused] Ability1FF,
	}
}
