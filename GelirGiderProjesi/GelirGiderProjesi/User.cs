﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderProjesi
{
    internal class User:Abstract
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
