using CodingChallenge.Data.Interfaces;
using CodingChallenge.Data.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;

/*
 * 
 * Refactorear la clase para respetar principios de programación orientada a objetos. 
 * Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. 
 * La única condición es que los tests pasen OK.
 *
 * TODO: 
 * Implementar Trapecio/Rectangulo, 
 * Agregar otro idioma a reporting.
 * 
 * */

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region Idiomas

        public const string Castellano = "es";
        public const string Ingles = "en";
        public const string Portugues = "pt";

        #endregion

        public string Imprimir(List<IShape> shapes, string lang)
        {
            try
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);
            }
            catch (Exception)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Ingles);
            }

            try
            {
                if (!shapes.Any())
                    return Resource.empty;

                StringBuilder sb = new StringBuilder();
                ResourceManager rm = new ResourceManager("CodingChallenge.Data.Resources.Resource", GetType().Assembly);

                //Header
                sb.Append(Resource.header);

                //Content
                int totalShapes = 0;
                decimal totalAreas = 0;
                decimal totalPerimeters = 0;

                var ShapesTypes = shapes.Select(s => s.ShapeName).Distinct().ToList();
                foreach (var name in ShapesTypes)
                {
                    var shapesOfType = shapes.Where(s => s.ShapeName == name).ToList();
                    var count = shapesOfType.Count;
                    var area = shapesOfType.Select(s => s.GetArea()).Sum();
                    var perimeter = shapesOfType.Select(s => s.GetPerimetro()).Sum();

                    totalShapes += count;
                    totalAreas += area;
                    totalPerimeters += perimeter;

                    sb.Append($"{count} ");
                    sb.Append($"{rm.GetString(name)}");
                    sb.Append($"{(count > 1 ? "s" : string.Empty)} | ");
                    sb.Append($"Area {area:#.##} | ");
                    sb.Append($"{Resource.perimeter} {perimeter:#.##} <br/>");
                }

                //Footer
                sb.Append("TOTAL:<br/>");
                sb.Append($"{totalShapes} {Resource.shapes} ");
                sb.Append($"{Resource.perimeter} {totalPerimeters:#.##} ");
                sb.Append($"Area {totalAreas:#.##}");

                return sb.ToString();
            }
            catch (Exception e)
            {
                //Log exception
                return Resource.error;
            }
        }

    }
}