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

using System.IO;

namespace KHSave.Archives.Factories
{
    internal class Ps4Kh1Factory : IArchiveFactory
    {
        private const int EntryCount = 200;
        private const int Stride = 0x16C40;
        private const int Size = 0x11cd800;

        public string Name => "PS4 KH1";

        public string Description => "Kingdom Hearts Final Mix (PS4)";

        public IArchive Create() =>
            new Ps4SaveArchive(EntryCount, Stride);

        public IArchive Read(Stream stream)
        {
            var archive = Ps4SaveArchive.Read(stream, EntryCount, Stride);
            archive.Name = Description;

            return archive;
        }

        public bool IsValid(Stream stream) => stream.Length == Size;

        public IArchiveEntry CreateEntry() => new GenericEntry();
    }
}
