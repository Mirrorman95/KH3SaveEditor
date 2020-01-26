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

using KHSave.Lib3;
using KHSave.Lib3.Types;
using KHSave.SaveEditor.Common;
using KHSave.SaveEditor.Kh3.Models;
using System.Linq;
using Xe.Tools.Wpf.Models;

namespace KHSave.SaveEditor.Kh3.ViewModels
{
    public class MaterialsViewModel : GenericListModel<MaterialModel>
    {
        public MaterialsViewModel(ISaveKh3 save) :
            base(save.MaterialsCount
                .Where((_, i) => Global.CanDisplay((MaterialType)i))
                .Select((_, i) => new MaterialModel(save, i)))
        { }

        protected override MaterialModel OnNewItem()
        {
            throw new System.NotImplementedException();
        }
    }
}
