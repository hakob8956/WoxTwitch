﻿using System.Collections.Generic;

namespace WoxTwitch.Objects.TopGame
{
    public class RootObject
    {
        public int _total { get; set; }
        public Links _links { get; set; }
        public List<Games> top { get; set; }
    }
}
