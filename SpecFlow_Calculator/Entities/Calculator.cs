using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlow_Calculator.Entities {
    public class Calculator {
        public int NumberOne { get; set; }
        public int NumberTwo { get; set; }

        public int Add() {
            return NumberOne + NumberTwo;
        }
    }
}
