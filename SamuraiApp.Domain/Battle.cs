﻿using System;
using System.Collections.Generic;

namespace SamuraiApp.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndTime { get; private set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
    }
}
