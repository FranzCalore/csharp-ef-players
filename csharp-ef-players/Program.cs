// See https://aka.ms/new-console-template for more information
using csharp_ef_players;

using(EfPlayersContext db = new EfPlayersContext())
{
    Random random = new Random();
    double numeroCasualeVoto = random.NextDouble()*10;
    double numeroCasualeArrotondato = Math.Round(numeroCasualeVoto, 1);
    int numeroCasualePartiteVinte = random.Next(1, 101);
    int numeroCasualePartiteGiocate = random.Next(numeroCasualePartiteVinte, 101);

    FootballPlayer ThomasMuller= new FootballPlayer() { name="Thomas",surname="Muller",vote=numeroCasualeArrotondato, gameNumber=numeroCasualePartiteGiocate, winNumber=numeroCasualePartiteVinte};
    db.Add(ThomasMuller);
    Console.WriteLine(ThomasMuller);
    db.SaveChanges();
    Console.WriteLine("Aggiunto");

    ThomasMuller.name = "Tom";
    ThomasMuller.surname = "Mueller";
    Console.WriteLine(ThomasMuller);
    db.SaveChanges();

    db.Remove(ThomasMuller);
    db.SaveChanges();
}

