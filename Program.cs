using Entity;
using System.Linq;

using (ApplicationDbContext db = new ApplicationDbContext())
{
    // элементы с массой меньше 100
    List<ChemicalElements> massElements = db.ChemicalElements
        .Where(e => e.Mass > 100)
        .ToList();
    Console.WriteLine("Элементы с массой больше 100:");
    foreach (var element in massElements)
    {
        Console.WriteLine(element);
    }

    // Элементы названные в честь кого-то
    List<ChemicalElements> namemassElements = db.ChemicalElements
        .Where(e => e.NamedAfter != null && e.NamedAfter != string.Empty)
        .ToList();

    Console.WriteLine("\nЭлементы, названные в честь кого-то:");
    foreach (var element in namemassElements)
    {
        Console.WriteLine(element);
    }
}