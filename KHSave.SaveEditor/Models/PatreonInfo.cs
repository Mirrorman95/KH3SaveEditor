﻿using System.Collections.Generic;

namespace KHSave.SaveEditor.Models
{
    public class PatreonInfo
    {
        public string PatreonUrl { get; set; }

        public IEnumerable<PatronModel> Patrons { get; set; }
    }
}
