﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Knight : Character
    {
        public Knight()
        {
            this.weapon = new SwordBehaviour();
        }
    }
}
