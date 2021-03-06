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

using KHSave.Lib3.Types;
using Xe.BinaryMapper;

namespace KHSave.Lib3.Models
{
	public class MagicGroup
	{
		[Data] public CommandType Magic1 { get; set; }
		[Data] public CommandType Magic2 { get; set; }
		[Data] public CommandType Magic3 { get; set; }
		[Data] public CommandType Magic4 { get; set; }
		[Data] public CommandType Magic5 { get; set; }
		[Data] public CommandType Magic6 { get; set; }
		[Data] public CommandType Magic7 { get; set; }
		[Data] public CommandType Magic8 { get; set; }
		[Data] public CommandType Magic9 { get; set; }
	}
}