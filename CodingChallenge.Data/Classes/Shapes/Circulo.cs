using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class Circulo : IShape
    {
        private decimal _witdth;

        public string ShapeName => "Circle";

        public Circulo(decimal witdth)
        {
            _witdth = witdth;
        }

        public decimal GetArea()
        {
            return Math.Round((decimal)Math.PI * (_witdth / 2) * (_witdth / 2), 2);
        }

        public decimal GetPerimetro()
        {
            return Math.Round((decimal)Math.PI * _witdth, 2);
        }

    }
}
