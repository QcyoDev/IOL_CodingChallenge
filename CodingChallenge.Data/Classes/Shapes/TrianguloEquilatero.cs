using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class TrianguloEquilatero : IShape
    {
        private decimal _witdth;

        public string ShapeName => "Triangle";

        public TrianguloEquilatero(decimal witdth)
        {
            _witdth = witdth;
        }

        public decimal GetArea()
        {
            return Math.Round(((decimal)Math.Sqrt(3) / 4) * _witdth * _witdth, 2);

        }

        public decimal GetPerimetro()
        {
            return Math.Round(_witdth * 3, 2);

        }
    }
}
