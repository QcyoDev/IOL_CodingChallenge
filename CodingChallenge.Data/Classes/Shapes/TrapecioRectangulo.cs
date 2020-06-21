using CodingChallenge.Data.Interfaces;
using System;

namespace CodingChallenge.Data.Classes.Shapes
{
    public class TrapecioRectangulo : IShape
    {
        private decimal _bottomWitdth;
        private decimal _topWitdth;
        private decimal _straightSide;
        private decimal _diagonalSide;

        public string ShapeName => "Trapeze";

        public TrapecioRectangulo(decimal bottomWitdth, decimal topWitdth, decimal straightSide, decimal diagonalSide)
        {
            _bottomWitdth = bottomWitdth;
            _topWitdth = topWitdth;
            _straightSide = straightSide;
            _diagonalSide = diagonalSide;
        }

        public decimal GetArea()
        {
            decimal area = _straightSide * ((_bottomWitdth + _topWitdth) / 2);
            return Math.Round(area, 2);
        }

        public decimal GetPerimetro()
        {
            decimal perimetro = _bottomWitdth + _topWitdth + _straightSide + _diagonalSide;
            return Math.Round(perimetro, 2);
        }
    }
}
