﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class InputInfo
    {
        //properties
        public int Id { get; set; }
        public string IdFood { get; set; }
        public int IdInput { get; set; }
        public int CountInput { get; set; }
        public float InputPrice { get; set; }
        public string StatusInput { get; set; }


        //constructor
        public InputInfo() { }
    }
}
