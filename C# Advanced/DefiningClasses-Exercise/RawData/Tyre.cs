using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tyre
    {
        private double tyrePressure;
        private int tyreAge;

        public Tyre(double tyrePressure, int tyreAge)
        {
            this.TyrePressure = tyrePressure;
            this.TyreAge = tyreAge;
        }
        public double TyrePressure { get; set; }
        public int TyreAge { get; set; }
    }
}
