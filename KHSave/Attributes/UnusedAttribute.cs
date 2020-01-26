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

using KHSave.Services;
using System;
using System.Linq;

namespace KHSave.Attributes
{
	public class UnusedAttribute : Attribute
    {
        private static CacheService<bool> cache = new CacheService<bool>();

        public static bool IsUnused(object value) => cache.Get(value, x =>
        {
            var memberValue = value.ToString();
            var memberInfo = value
                .GetType()
                .GetMember(memberValue)
                .FirstOrDefault();

            if (memberInfo != null)
            {
                if (memberInfo.GetCustomAttributes(typeof(UnusedAttribute), false).Length > 0)
                    return true;
                if (memberInfo.GetCustomAttributes(typeof(InfoAttribute), false).Length > 0)
                    return false;
            }

            return true;
        });
	}
}
