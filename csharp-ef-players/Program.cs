// See https://aka.ms/new-console-template for more information
using csharp_ef_players;
using Azure.Identity;
using Microsoft.EntityFrameworkCore;


using (EfPlayersContext db = new EfPlayersContext())
{

    Team BayernMunchen = new Team() { Name = "Bayern Munchen", Città = "Monaco di Baviera", Colori = "Bianco Rosso"};

    DateTime scadenza1 = DateTime.Parse("01/01/2030");

    DateTime scadenza2 = DateTime.Parse("01/01/2027");

    Sponsor Adidas = new Sponsor("Adidas", 900, scadenza1);

    Sponsor Telekom = new Sponsor("Telekom", 250, scadenza2);

    BayernMunchen.ListaSponsor.Add(Adidas);
    BayernMunchen.ListaSponsor.Add(Telekom);

    Allenatore JulianNagelsmann = new Allenatore("Julian", "Nagelsmann");

    JulianNagelsmann.Team = BayernMunchen;
    BayernMunchen.Allenatore = JulianNagelsmann;

    FootballPlayer ThomasMuller= new FootballPlayer("Thomas","Muller");


    BayernMunchen.ListaGiocatori.Add(ThomasMuller);

    FootballPlayer AlphonsoDavies = new FootballPlayer("Alphonso", "Davies");

    BayernMunchen.ListaGiocatori.Add(AlphonsoDavies);

    FootballPlayer JamalMusiala = new FootballPlayer("Jamal", "Musiala");

    BayernMunchen.ListaGiocatori.Add(JamalMusiala);

    db.Add(BayernMunchen);

    db.SaveChanges();
    Console.WriteLine("Aggiunto");

    foreach(Team team in db.Teams)
    {
        Console.WriteLine(team);  
    }

}


