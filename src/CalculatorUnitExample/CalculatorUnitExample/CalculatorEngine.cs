﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorUnitExample
{
    public class CalculatorEngine
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                return -9999;
            }            

            return a / b;
        }

        public double Pow(int a, int b)
        {
            return Math.Pow(a, b);
        }


    }
}
