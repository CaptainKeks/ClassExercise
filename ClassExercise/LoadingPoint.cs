using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise;
/// <summary>
/// Klasse für die LoadingPoints
/// </summary>
/// <param name="Name">String für den Namen der Zuladung</param>
/// <param name="Weight">Dezimal für das Gewicht der Zuladung</param>
/// <param name="Distance">Dezimal für die Distanz vom angegebenen Schwerpunkt der Zuladung</param>
    public class LoadingPoint(string Name = "", decimal Weight = 0, decimal Distance = 0)
{
    public static List<LoadingPoint> AllPoints = [];
    public string Name { get; set; } = Name;
    public decimal Weight { get; set; } = Weight;
    public decimal Distance { get; set; } = Distance;
}

    
