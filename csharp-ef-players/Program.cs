// See https://aka.ms/new-console-template for more information
using csharp_ef_players;
using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;

using (EfPlayersContext db = new EfPlayersContext())
{

    /*Team BayernMunchen = new Team() { Name = "Bayern Munchen", Città = "Monaco di Baviera", Colori = "Bianco Rosso"};

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
    Console.WriteLine("Aggiunto");*/
    string inpututente="";

    do {foreach(Team team in db.Teams)
    {
        Console.WriteLine(team);  
    }

    Console.WriteLine("Cosa desideri fare?" +
        "\n\n" +
        "1) Aggiungere nuovi giocatori \n" +
        "2) Aggiungere una nuova squadra \n" +
        "*) Esci\n\n" +
        "Inserisci un input");

    inpututente = Console.ReadLine();
        switch (inpututente)
        {
            case "1":
                foreach (Team team in db.Teams)
                {
                    Console.WriteLine(team);
                }
                Console.WriteLine("\n\n\nA quale team vuoi aggiungere un giocatore? Inserisci l'ID");
                string ricerca = Console.ReadLine();
                foreach (Team team in db.Teams)
                {
                    if (team.TeamId.ToString() == ricerca)
                    {
                        Console.WriteLine("Inserisci il nome del Giocatore");
                        string name = Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome del Giocatore");
                        string cognome = Console.ReadLine();
                        FootballPlayer nuovoGiocatore = new FootballPlayer(name, cognome);
                        team.ListaGiocatori.Add(nuovoGiocatore);                        
                            }
                        }
                break;
            case "2":
                Console.WriteLine("Costruzione Team in corso...\n\n");
                Console.WriteLine("Inserisci il nome del Team");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci la città del Team");
                string città = Console.ReadLine();
                Console.WriteLine("Inserisci i colori del Team");
                string colori = Console.ReadLine();
                Console.WriteLine("Inserisci il nome dell'Allenatore");
                string nomeAllenatore = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome dell'Allenatore");
                string cognomeAllenatore = Console.ReadLine();
                Allenatore nuovoAllenatore = new Allenatore(nomeAllenatore, cognomeAllenatore);
                Team nuovoTeam = new Team() { Name = nome, Città = città, Colori = colori };
                nuovoTeam.Allenatore = nuovoAllenatore;
                db.Add(nuovoTeam);
                db.SaveChanges();
                break;
        }
        db.SaveChanges();

    } while (inpututente == "1" || inpututente == "2");
}



