// See https://aka.ms/new-console-template for more information
using csharp_ef_players;

using(EfPlayersContext db = new EfPlayersContext())
{

    Team BayernMunchen = new Team() { name = "Bayern Munchen", città = "Monaco di Baviera", allenatore = "Julian Nagelsmann", colori = "Bianco Rosso"};
    
    Random random = new Random();
    double numeroCasualeVoto = random.NextDouble()*10;
    double numeroCasualeArrotondato = Math.Round(numeroCasualeVoto, 1);
    int numeroCasualePartiteVinte = random.Next(1, 101);
    int numeroCasualePartiteGiocate = random.Next(numeroCasualePartiteVinte, 101);

    FootballPlayer ThomasMuller= new FootballPlayer() { name="Thomas",surname="Muller",vote=numeroCasualeArrotondato, gameNumber=numeroCasualePartiteGiocate, winNumber=numeroCasualePartiteVinte};

    numeroCasualeVoto = random.NextDouble() * 10;
    numeroCasualeArrotondato = Math.Round(numeroCasualeVoto, 1);
    numeroCasualePartiteVinte = random.Next(1, 101);
    numeroCasualePartiteGiocate = random.Next(numeroCasualePartiteVinte, 101);

    BayernMunchen.listaGiocatori.Add(ThomasMuller);

    FootballPlayer AlphonsoDavies = new FootballPlayer() { name = "Alphonso", surname = "Davies", vote = numeroCasualeArrotondato, gameNumber = numeroCasualePartiteGiocate, winNumber = numeroCasualePartiteVinte };

    numeroCasualeVoto = random.NextDouble() * 10;
    numeroCasualeArrotondato = Math.Round(numeroCasualeVoto, 1);
    numeroCasualePartiteVinte = random.Next(1, 101);
    numeroCasualePartiteGiocate = random.Next(numeroCasualePartiteVinte, 101);

    BayernMunchen.listaGiocatori.Add(AlphonsoDavies);

    FootballPlayer JamalMusiala = new FootballPlayer() { name = "Jamal", surname = "Musiala", vote = numeroCasualeArrotondato, gameNumber = numeroCasualePartiteGiocate, winNumber = numeroCasualePartiteVinte };

    BayernMunchen.listaGiocatori.Add(JamalMusiala);

    db.Add(BayernMunchen);
    db.Add(ThomasMuller);
    db.Add(AlphonsoDavies);
    db.Add(JamalMusiala);

    Console.WriteLine(ThomasMuller);
    db.SaveChanges();
    Console.WriteLine("Aggiunto");

   /* ThomasMuller.name = "Tom";
    ThomasMuller.surname = "Mueller";
    Console.WriteLine(ThomasMuller);
    db.SaveChanges();

    db.Remove(ThomasMuller);
    db.SaveChanges();*/
}

