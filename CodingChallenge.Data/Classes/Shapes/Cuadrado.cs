using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Cuadrado : IShape
    {
        private decimal _witdth;

        public string ShapeName => "Square";

        public Cuadrado(decimal witdth)
        {
            _witdth = witdth;
        }

        public decimal GetArea()
        {
            return Math.Round(_witdth * _witdth, 2);
        }

        public decimal GetPerimetro()
        {
            return Math.Round(_witdth * 4, 2);
        }
    }
}
