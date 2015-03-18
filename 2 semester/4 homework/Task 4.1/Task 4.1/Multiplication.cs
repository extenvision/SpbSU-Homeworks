﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Multiplication : ParseTree
    {
        public Multiplication(char value)
            : base(value) { }

        public override int Calculate()
        {
            return LeftChild.Calculate() * RightChild.Calculate();
        }

        public override string Print()
        {
            return " *";
        }
    }
}
