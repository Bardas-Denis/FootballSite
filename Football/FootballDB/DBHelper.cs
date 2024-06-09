using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDB
{
    public class DBHelper
    {
        public void PopulateLeagues()
        {
            var context = new FootballContext();
            var premierLeague = new League { Name = "Premier League" };
            PopulateTeams(premierLeague);
            var laLiga = new League { Name = "La Liga" };
            PopulateTeams(laLiga);
            var bundesliga = new League { Name = "Bundesliga" };
            PopulateTeams(bundesliga);
            var serieA = new League { Name = "Serie A" };
            PopulateTeams(serieA);
            var ligue1 = new League { Name = "Ligue 1" };
            PopulateTeams(ligue1);

            context.Leagues.AddRange(laLiga, bundesliga, serieA, ligue1);
            context.SaveChanges();
        }

        public void PopulateTeams(League league)
        {
            var context = new FootballContext();
            switch (league.Name)
            {
                case "Premier League":
                    {
                        //var manCity = new Team { Name = "Manchester City", GamesPlayed=10, GamesWon=9,GamesDrawn=1,GamesLost=0,GoalsFor=20,GoalsAgainst=7,Points=28,League=league};
                        //PopulatePlayers(manCity);
                        //var manUnited = new Team { Name = "Manchester United", GamesPlayed = 10, GamesWon = 8, GamesDrawn = 1, GamesLost = 1, GoalsFor = 25, GoalsAgainst = 9, Points = 25, League = league };
                        //PopulatePlayers(manUnited);
                        var chelsea = new Team { Name = "Chelsea", GamesPlayed = 10, GamesWon = 7, GamesDrawn = 2, GamesLost = 1, GoalsFor = 21, GoalsAgainst = 10, Points = 23, League = league };
                        PopulatePlayers(chelsea);
                        var liverpool = new Team { Name = "Liverpool", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 3, GamesLost = 1, GoalsFor = 20, GoalsAgainst = 9, Points = 21, League = league };
                        PopulatePlayers(liverpool);
                        var arsenal = new Team { Name = "Arsenal", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 2, GamesLost = 2, GoalsFor = 18, GoalsAgainst = 12, Points = 20, League = league };
                        PopulatePlayers(arsenal);
                        var tottenham = new Team { Name = "Tottenham Hotspur", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 1, GamesLost = 3, GoalsFor = 18, GoalsAgainst = 11, Points = 19, League = league };
                        PopulatePlayers(tottenham);

                        context.Teams.AddRange(chelsea,liverpool,arsenal, tottenham);
                        //league.Teams.Add(manCity);
                        //league.Teams.Add(manUnited);
                        league.Teams.Add(chelsea);
                        league.Teams.Add(liverpool);
                        league.Teams.Add(arsenal);
                        league.Teams.Add(tottenham);
                        break;
                    }
                case "La Liga":
                    {
                        var barcelona = new Team { Name = "FC Barcelona", GamesPlayed = 10, GamesWon = 8, GamesDrawn = 2, GamesLost = 0, GoalsFor = 30, GoalsAgainst = 10, Points = 26, League = league };
                        PopulatePlayers(barcelona);
                        var realMadrid = new Team { Name = "Real Madrid", GamesPlayed = 10, GamesWon = 7, GamesDrawn = 3, GamesLost = 0, GoalsFor = 25, GoalsAgainst = 12, Points = 24, League = league };
                        PopulatePlayers(realMadrid);
                        var atleticoMadrid = new Team { Name = "Atletico Madrid", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 4, GamesLost = 0, GoalsFor = 20, GoalsAgainst = 8, Points = 22, League = league };
                        PopulatePlayers(atleticoMadrid);
                        var sevilla = new Team { Name = "Sevilla", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 3, GamesLost = 1, GoalsFor = 18, GoalsAgainst = 10, Points = 21, League = league };
                        PopulatePlayers(sevilla);
                        var realSociedad = new Team { Name = "Real Sociedad", GamesPlayed = 10, GamesWon = 5, GamesDrawn = 3, GamesLost = 2, GoalsFor = 15, GoalsAgainst = 11, Points = 18, League = league };
                        PopulatePlayers(realSociedad);
                        var villarreal = new Team { Name = "Villarreal", GamesPlayed = 10, GamesWon = 4, GamesDrawn = 5, GamesLost = 1, GoalsFor = 16, GoalsAgainst = 12, Points = 17, League = league };
                        PopulatePlayers(villarreal);

                        context.Teams.AddRange(barcelona, realMadrid, atleticoMadrid, sevilla, realSociedad, villarreal);
                        league.Teams.Add(barcelona);
                        league.Teams.Add(realMadrid);
                        league.Teams.Add(atleticoMadrid);
                        league.Teams.Add(sevilla);
                        league.Teams.Add(realSociedad);
                        league.Teams.Add(villarreal);
                        break;
                    }
                case "Bundesliga":
                    {
                        var bayernMunich = new Team { Name = "Bayern Munich", GamesPlayed = 10, GamesWon = 8, GamesDrawn = 1, GamesLost = 1, GoalsFor = 35, GoalsAgainst = 10, Points = 25, League = league };
                        var borussiaDortmund = new Team { Name = "Borussia Dortmund", GamesPlayed = 10, GamesWon = 7, GamesDrawn = 2, GamesLost = 1, GoalsFor = 30, GoalsAgainst = 15, Points = 23, League = league };
                        var rbLeipzig = new Team { Name = "RB Leipzig", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 4, GamesLost = 0, GoalsFor = 25, GoalsAgainst = 12, Points = 22, League = league};
                        var bayerLeverkusen = new Team { Name = "Bayer Leverkusen", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 3, GamesLost = 1, GoalsFor = 22, GoalsAgainst = 10, Points = 21, League = league };
                        var wolfsburg = new Team { Name = "VfL Wolfsburg", GamesPlayed = 10, GamesWon = 5, GamesDrawn = 4, GamesLost = 1, GoalsFor = 18, GoalsAgainst = 11, Points = 19, League = league };
                        var eintrachtFrankfurt = new Team { Name = "Eintracht Frankfurt", GamesPlayed = 10, GamesWon = 5, GamesDrawn = 3, GamesLost = 2, GoalsFor = 20, GoalsAgainst = 15, Points = 18, League = league };

                        context.Teams.AddRange(bayernMunich, borussiaDortmund, rbLeipzig, bayerLeverkusen, wolfsburg, eintrachtFrankfurt);
                        league.Teams.Add(bayernMunich);
                        league.Teams.Add(borussiaDortmund);
                        league.Teams.Add(rbLeipzig);
                        league.Teams.Add(bayerLeverkusen);
                        league.Teams.Add(wolfsburg);
                        league.Teams.Add(eintrachtFrankfurt);

                        break;
                    }
                case "Serie A":
                    {
                        var juventus = new Team { Name = "Juventus", GamesPlayed = 10, GamesWon = 7, GamesDrawn = 2, GamesLost = 1, GoalsFor = 25, GoalsAgainst = 10, Points = 23, League = league};
                        var acMilan = new Team { Name = "AC Milan", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 3, GamesLost = 1, GoalsFor = 22, GoalsAgainst = 12, Points = 21, League = league};
                        var napoli = new Team { Name = "Napoli", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 2, GamesLost = 2, GoalsFor = 20, GoalsAgainst = 11, Points = 20, League = league };
                        var asRoma = new Team { Name = "AS Roma", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 1, GamesLost = 3, GoalsFor = 18, GoalsAgainst = 11, Points = 19, League = league };
                        var interMilan = new Team { Name = "Inter Milan", GamesPlayed = 10, GamesWon = 5, GamesDrawn = 3, GamesLost = 2, GoalsFor = 20, GoalsAgainst = 15, Points = 18, League = league};
                        var sassuolo = new Team { Name = "Sassuolo", GamesPlayed = 10, GamesWon = 4, GamesDrawn = 4, GamesLost = 2, GoalsFor = 18, GoalsAgainst = 12, Points = 16, League = league };

                        context.Teams.AddRange(juventus, acMilan, napoli, asRoma, interMilan, sassuolo);
                        league.Teams.Add(juventus);
                        league.Teams.Add(acMilan);
                        league.Teams.Add(napoli);
                        league.Teams.Add(asRoma);
                        league.Teams.Add(interMilan);
                        league.Teams.Add(sassuolo);

                        break;
                    }
                case "Ligue 1":
                    {
                        var parisSaintGermain = new Team { Name = "Paris Saint-Germain", GamesPlayed = 10, GamesWon = 8, GamesDrawn = 1, GamesLost = 1, GoalsFor = 30, GoalsAgainst = 10, Points = 25, League = league };
                        var lille = new Team { Name = "Lille", GamesPlayed = 10, GamesWon = 7, GamesDrawn = 2, GamesLost = 1, GoalsFor = 25, GoalsAgainst = 12, Points = 23, League = league };
                        var olympiqueMarseille = new Team { Name = "Olympique Marseille", GamesPlayed = 10, GamesWon = 7, GamesDrawn = 2, GamesLost = 1, GoalsFor = 22, GoalsAgainst = 10, Points = 23, League = league };
                        var lyon = new Team { Name = "Lyon", GamesPlayed = 10, GamesWon = 6, GamesDrawn = 3, GamesLost = 1, GoalsFor = 20, GoalsAgainst = 11, Points = 21, League = league };
                        var asMonaco = new Team { Name = "AS Monaco", GamesPlayed = 10, GamesWon = 5, GamesDrawn = 3, GamesLost = 2, GoalsFor = 18, GoalsAgainst = 12, Points = 18, League = league };
                        var rennes = new Team { Name = "Rennes", GamesPlayed = 10, GamesWon = 5, GamesDrawn = 2, GamesLost = 3, GoalsFor = 15, GoalsAgainst = 11, Points = 17, League = league };

                        context.Teams.AddRange(parisSaintGermain, lille, olympiqueMarseille, lyon, asMonaco, rennes);
                        league.Teams.Add(parisSaintGermain);
                        league.Teams.Add(lille);
                        league.Teams.Add(olympiqueMarseille);
                        league.Teams.Add(lyon);
                        league.Teams.Add(asMonaco);
                        league.Teams.Add(rennes);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }
        public void PopulatePlayers(Team team)
        {
            var context = new FootballContext();
            switch (team.Name) 
            {
                //case "Manchester City":
                //    {
                //        var haaland = new Player { Name = "Erling Haaland", Height = 194, Weight = 88, Age = 23, Goals = 12, Position = "ST", Team = team };
                //        Player deBruyne = new Player { Name = "Kevin De Bruyne", Height = 181, Weight = 68, Age = 31,Goals=7, Position = "CM", Team = team };
                //        Player rubenDias = new Player { Name = "Ruben Dias", Height = 187, Weight = 84, Age = 25, Goals = 2, Position = "CB", Team = team };
                //        Player philFoden = new Player { Name = "Phil Foden", Height = 171, Weight = 69, Age = 21,Goals = 6, Position = "CAM", Team = team };
                //        Player ederson = new Player { Name = "Ederson", Height = 188, Weight = 86, Age = 28, Goals = 0, Position = "GK", Team = team };
                //        Player johnStones = new Player { Name = "John Stones", Height = 188, Weight = 70, Age = 28,Goals = 3, Position = "CB", Team = team };

                //        context.Players.AddRange(haaland,deBruyne,rubenDias,philFoden, ederson, johnStones);
                //        team.Players.Add(haaland);
                //        team.Players.Add(deBruyne);
                //        team.Players.Add(rubenDias);
                //        team.Players.Add(ederson);
                //        team.Players.Add(johnStones);
                //        context.SaveChanges();
                //        break;
                //    }
                //case "Manchester United":
                //    var rashford = new Player { Name = "Marcus Rashford", Height = 180, Weight = 70, Age = 24, Goals = 9, Position = "LW", Team = team };
                //    var brunoFernandes = new Player { Name = "Bruno Fernandes", Height = 179, Weight = 69, Age = 27, Goals = 8, Position = "CAM", Team = team };
                //    var harryMaguire = new Player { Name = "Harry Maguire", Height = 194, Weight = 94, Age = 29, Goals = 3, Position = "CB", Team = team };
                //    var davidDeGea = new Player { Name = "David De Gea", Height = 192, Weight = 82, Age = 31, Goals = 0, Position = "GK", Team = team };
                //    var masonGreenwood = new Player { Name = "Mason Greenwood", Height = 181, Weight = 76, Age = 20, Goals = 5, Position = "RW", Team = team };
                //    var lukeShaw = new Player { Name = "Luke Shaw", Height = 181, Weight = 75, Age = 26, Goals = 2, Position = "LB", Team = team };

                //    context.Players.AddRange(rashford, brunoFernandes, harryMaguire, davidDeGea, masonGreenwood, lukeShaw);
                //    team.Players.Add(rashford);
                //    team.Players.Add(brunoFernandes);
                //    team.Players.Add(harryMaguire);
                //    team.Players.Add(davidDeGea);
                //    team.Players.Add(masonGreenwood);
                //    team.Players.Add(lukeShaw);
                //    context.SaveChanges();
                //    break;
                case "Liverpool":

                    var salah = new Player { Name = "Mohamed Salah", Height = 175, Weight = 71, Age = 29, Goals = 15, Position = "RW", Team = team };
                    var mane = new Player { Name = "Sadio Mane", Height = 175, Weight = 69, Age = 30, Goals = 10, Position = "LW", Team = team };
                    var vanDijk = new Player { Name = "Virgil van Dijk", Height = 193, Weight = 92, Age = 30, Goals = 1, Position = "CB", Team = team };
                    var alisson = new Player { Name = "Alisson Becker", Height = 191, Weight = 91, Age = 29, Goals = 0, Position = "GK", Team = team };
                    var robertson = new Player { Name = "Andrew Robertson", Height = 178, Weight = 64, Age = 28, Goals = 3, Position = "LB", Team = team };
                    var firmino = new Player { Name = "Roberto Firmino", Height = 181, Weight = 75, Age = 30, Goals = 7, Position = "CF", Team = team };

                    context.Players.AddRange(salah, mane, vanDijk, alisson, robertson, firmino);
                    team.Players.Add(salah);
                    team.Players.Add(mane);
                    team.Players.Add(vanDijk);
                    team.Players.Add(alisson);
                    team.Players.Add(robertson);
                    team.Players.Add(firmino);

                 

                    break;
                case "Chelsea":
                    var lukaku = new Player { Name = "Romelu Lukaku", Height = 190, Weight = 94, Age = 28, Goals = 11, Position = "ST", Team = team };
                    var mount = new Player { Name = "Mason Mount", Height = 178, Weight = 70, Age = 23, Goals = 5, Position = "CAM", Team = team };
                    var rudiger = new Player { Name = "Antonio Rudiger", Height = 191, Weight = 85, Age = 29, Goals = 2, Position = "CB", Team = team };
                    var mendy = new Player { Name = "Edouard Mendy", Height = 196, Weight = 92, Age = 30, Goals = 0, Position = "GK", Team = team };
                    var james = new Player { Name = "Reece James", Height = 182, Weight = 85, Age = 22, Goals = 4, Position = "RB", Team = team };
                    var havertz = new Player { Name = "Kai Havertz", Height = 188, Weight = 85, Age = 23, Goals = 8, Position = "CF", Team = team };

                    context.Players.AddRange(lukaku, mount, rudiger, mendy, james, havertz);
                    team.Players.Add(lukaku);
                    team.Players.Add(mount);
                    team.Players.Add(rudiger);
                    team.Players.Add(mendy);
                    team.Players.Add(james);
                    team.Players.Add(havertz);


                    break;
                case "Arsenal":
                    var aubameyang = new Player { Name = "Pierre-Emerick Aubameyang", Height = 187, Weight = 88, Age = 32, Goals = 9, Position = "ST", Team = team };
                    var saka = new Player { Name = "Bukayo Saka", Height = 178, Weight = 70, Age = 20, Goals = 6, Position = "RW", Team = team };
                    var white = new Player { Name = "Ben White", Height = 185, Weight = 76, Age = 24, Goals = 1, Position = "CB", Team = team };
                    var leno = new Player { Name = "Bernd Leno", Height = 190, Weight = 83, Age = 30, Goals = 0, Position = "GK", Team = team };
                    var tierney = new Player { Name = "Kieran Tierney", Height = 178, Weight = 70, Age = 24, Goals = 2, Position = "LB", Team = team };
                    var lacazette = new Player { Name = "Alexandre Lacazette", Height = 175, Weight = 73, Age = 30, Goals = 5, Position = "CF", Team = team };

                    context.Players.AddRange(aubameyang, saka, white, leno, tierney, lacazette);
                    team.Players.Add(aubameyang);
                    team.Players.Add(saka);
                    team.Players.Add(white);
                    team.Players.Add(leno);
                    team.Players.Add(tierney);
                    team.Players.Add(lacazette);

                    break;
                case "Tottenham Hotspur":
                    var harryKane = new Player { Name = "Harry Kane", Height = 188, Weight = 86, Age = 28, Goals = 10, Position = "ST", Team = team };
                    var sonHeungMin = new Player { Name = "Son Heung-Min", Height = 183, Weight = 77, Age = 29, Goals = 8, Position = "LW", Team = team };
                    var romero = new Player { Name = "Cristian Romero", Height = 187, Weight = 82, Age = 24, Goals = 1, Position = "CB", Team = team };
                    var lloris = new Player { Name = "Hugo Lloris", Height = 188, Weight = 82, Age = 35, Goals = 0, Position = "GK", Team = team };
                    var reguilon = new Player { Name = "Sergio Reguilon", Height = 180, Weight = 72, Age = 25, Goals = 3, Position = "LB", Team = team };
                    var lucasMoura = new Player { Name = "Lucas Moura", Height = 172, Weight = 76, Age = 30, Goals = 4, Position = "RW", Team = team };

                    context.Players.AddRange(harryKane, sonHeungMin, romero, lloris, reguilon, lucasMoura);
                    team.Players.Add(harryKane);
                    team.Players.Add(sonHeungMin);
                    team.Players.Add(romero);
                    team.Players.Add(lloris);
                    team.Players.Add(reguilon);
                    team.Players.Add(lucasMoura);

                    break;
                case "Real Madrid":
                    var benzema = new Player { Name = "Karim Benzema", Height = 185, Weight = 81, Age = 34, Goals = 12, Position = "ST", Team = team };
                    var modric = new Player { Name = "Luka Modric", Height = 172, Weight = 66, Age = 36, Goals = 5, Position = "CM", Team = team };
                    var varane = new Player { Name = "Raphael Varane", Height = 191, Weight = 81, Age = 28, Goals = 2, Position = "CB", Team = team };
                    var courtois = new Player { Name = "Thibaut Courtois", Height = 199, Weight = 96, Age = 29, Goals = 0, Position = "GK", Team = team };
                    var carvajal = new Player { Name = "Dani Carvajal", Height = 173, Weight = 73, Age = 30, Goals = 1, Position = "RB", Team = team };
                    var viniciusJr = new Player { Name = "Vinicius Jr", Height = 176, Weight = 73, Age = 21, Goals = 7, Position = "LW", Team = team };

                    context.Players.AddRange(benzema, modric, varane, courtois, carvajal, viniciusJr);
                    team.Players.Add(benzema);
                    team.Players.Add(modric);
                    team.Players.Add(varane);
                    team.Players.Add(courtois);
                    team.Players.Add(carvajal);
                    team.Players.Add(viniciusJr);

                    break;
                case "Barcelona":
                    var messi = new Player { Name = "Lionel Messi", Height = 170, Weight = 72, Age = 35, Goals = 14, Position = "RW", Team = team };
                    var deJong = new Player { Name = "Frenkie de Jong", Height = 180, Weight = 74, Age = 25, Goals = 3, Position = "CM", Team = team };
                    var pique = new Player { Name = "Gerard Piqué", Height = 194, Weight = 85, Age = 35, Goals = 2, Position = "CB", Team = team };
                    var terStegen = new Player { Name = "Marc-André ter Stegen", Height = 187, Weight = 85, Age = 30, Goals = 0, Position = "GK", Team = team };
                    var alba = new Player { Name = "Jordi Alba", Height = 170, Weight = 68, Age = 33, Goals = 2, Position = "LB", Team = team };
                    var ansuFati = new Player { Name = "Ansu Fati", Height = 178, Weight = 67, Age = 20, Goals = 5, Position = "LW", Team = team };

                    context.Players.AddRange(messi, deJong, pique, terStegen, alba, ansuFati);
                    team.Players.Add(messi);
                    team.Players.Add(deJong);
                    team.Players.Add(pique);
                    team.Players.Add(terStegen);
                    team.Players.Add(alba);
                    team.Players.Add(ansuFati);


                    break;
                case "Atletico Madrid":
                    var suarez = new Player { Name = "Luis Suárez", Height = 182, Weight = 86, Age = 35, Goals = 8, Position = "ST", Team = team };
                    var koke = new Player { Name = "Koke", Height = 176, Weight = 74, Age = 30, Goals = 4, Position = "CM", Team = team };
                    var gimenez = new Player { Name = "José Giménez", Height = 185, Weight = 77, Age = 27, Goals = 2, Position = "CB", Team = team };
                    var oblak = new Player { Name = "Jan Oblak", Height = 188, Weight = 87, Age = 29, Goals = 0, Position = "GK", Team = team };
                    var trippier = new Player { Name = "Kieran Trippier", Height = 178, Weight = 71, Age = 31, Goals = 1, Position = "RB", Team = team };
                    var joaoFelix = new Player { Name = "João Félix", Height = 180, Weight = 70, Age = 22, Goals = 6, Position = "CF", Team = team };

                    context.Players.AddRange(suarez, koke, gimenez, oblak, trippier, joaoFelix);
                    team.Players.Add(suarez);
                    team.Players.Add(koke);
                    team.Players.Add(gimenez);
                    team.Players.Add(oblak);
                    team.Players.Add(trippier);
                    team.Players.Add(joaoFelix);

                    break;
                case "Sevilla":
                    var enNesyri = new Player { Name = "Youssef En-Nesyri", Height = 192, Weight = 80, Age = 24, Goals = 9, Position = "ST", Team = team };
                    var jordan = new Player { Name = "Joan Jordán", Height = 178, Weight = 70, Age = 27, Goals = 3, Position = "CM", Team = team };
                    var diegoCarlos = new Player { Name = "Diego Carlos", Height = 183, Weight = 78, Age = 28, Goals = 1, Position = "CB", Team = team };
                    var bounou = new Player { Name = "Yassine Bounou", Height = 193, Weight = 87, Age = 30, Goals = 0, Position = "GK", Team = team };
                    var navas = new Player { Name = "Jesús Navas", Height = 173, Weight = 64, Age = 36, Goals = 2, Position = "RB", Team = team };
                    var ocampos = new Player { Name = "Lucas Ocampos", Height = 187, Weight = 75, Age = 27, Goals = 5, Position = "RW", Team = team };

                    context.Players.AddRange(enNesyri, jordan, diegoCarlos, bounou, navas, ocampos);
                    team.Players.Add(enNesyri);
                    team.Players.Add(jordan);
                    team.Players.Add(diegoCarlos);
                    team.Players.Add(bounou);
                    team.Players.Add(navas);
                    team.Players.Add(ocampos);

                    break;
                case "Villarreal":
                    var gerardMoreno = new Player { Name = "Gerard Moreno", Height = 183, Weight = 70, Age = 30, Goals = 10, Position = "ST", Team = team };
                    var capoue = new Player { Name = "Étienne Capoue", Height = 187, Weight = 82, Age = 33, Goals = 2, Position = "CM", Team = team };
                    var torres = new Player { Name = "Pau Torres", Height = 192, Weight = 82, Age = 25, Goals = 1, Position = "CB", Team = team };
                    var rulli = new Player { Name = "Geronimo Rulli", Height = 190, Weight = 84, Age = 30, Goals = 0, Position = "GK", Team = team };
                    var gaspar = new Player { Name = "Mario Gaspar", Height = 181, Weight = 75, Age = 31, Goals = 1, Position = "RB", Team = team };
                    var diaz = new Player { Name = "Yeremi Pino", Height = 174, Weight = 70, Age = 19, Goals = 4, Position = "LW", Team = team };

                    context.Players.AddRange(gerardMoreno, capoue, torres, rulli, gaspar, diaz);
                    team.Players.Add(gerardMoreno);
                    team.Players.Add(capoue);
                    team.Players.Add(torres);
                    team.Players.Add(rulli);
                    team.Players.Add(gaspar);
                    team.Players.Add(diaz);

                    break;
                case "Real Sociedad":
                    var isak = new Player { Name = "Alexander Isak", Height = 190, Weight = 75, Age = 22, Goals = 8, Position = "ST", Team = team };
                    var merino = new Player { Name = "Mikel Merino", Height = 188, Weight = 79, Age = 25, Goals = 3, Position = "CM", Team = team };
                    var leNormand = new Player { Name = "Robin Le Normand", Height = 183, Weight = 78, Age = 25, Goals = 1, Position = "CB", Team = team };
                    var remiro = new Player { Name = "Álex Remiro", Height = 189, Weight = 84, Age = 27, Goals = 0, Position = "GK", Team = team };
                    var gorosabel = new Player { Name = "Andoni Gorosabel", Height = 180, Weight = 76, Age = 26, Goals = 1, Position = "RB", Team = team };
                    var oyarzabal = new Player { Name = "Mikel Oyarzabal", Height = 181, Weight = 70, Age = 25, Goals = 5, Position = "LW", Team = team };

                    context.Players.AddRange(isak, merino, leNormand, remiro, gorosabel, oyarzabal);
                    team.Players.Add(isak);
                    team.Players.Add(merino);
                    team.Players.Add(leNormand);
                    team.Players.Add(remiro);
                    team.Players.Add(gorosabel);
                    team.Players.Add(oyarzabal);

                    break;
                case "Bayern Munich":
                    // Code for Bayern Munich
                    break;
                case "RB Leipzig":
                    // Code for RB Leipzig
                    break;
                case "Borussia Dortmund":
                    // Code for Borussia Dortmund
                    break;
                case "Bayer Leverkusen":
                    // Code for Bayer Leverkusen
                    break;
                case "VfL Wolfsburg":
                    // Code for Wolfsburg
                    break;
                case "Eintracht Frankfurt":
                    // Code for Eintracht Frankfurt
                    break;
                case "Juventus":
                    // Code for Juventus
                    break;
                case "Inter Milan":
                    // Code for Inter Milan
                    break;
                case "AC Milan":
                    // Code for AC Milan
                    break;
                case "Napoli":
                    // Code for Napoli
                    break;
                case "AS Roma":
                    // Code for AS Roma
                    break;
                case "Sassuolo":
                    // Code for Atalanta
                    break;
                case "Paris Saint-Germain":
                    // Code for Paris Saint-Germain
                    break;
                case "Lille":
                    // Code for Lille
                    break;
                case "AS Monaco":
                    // Code for AS Monaco
                    break;
                case "Lyon":
                    // Code for Lyon
                    break;
                case "Olympique Marseille":
                    // Code for Marseille
                    break;
                case "Rennes":
                    // Code for Rennes
                    break;
                default: { break; }
            }
        }
        public void PopulateTransfers()
        {
            var context = new FootballContext();
            Player player = context.Players.Where(p => p.Name == "Erling Haaland").First();
            Team team1 = context.Teams.Where(t => t.Name == "Borussia Dortmund").First();
            Team team2 = context.Teams.Where(t => t.Name == "Manchester City").First();
            context.Transfers.Add(new Transfer { Player = player, LastTeam = team1, NewTeam = team2 });

            player = context.Players.Where(p => p.Name == "Kieran Trippier").First();
            team1 = context.Teams.Where(t => t.Name == "Manchester City").First();
            team2 = context.Teams.Where(t => t.Name == "Atletico Madrid").First();
            context.Transfers.Add(new Transfer { Player = player, LastTeam = team1, NewTeam = team2 });

            player = context.Players.Where(p => p.Name == "Mikel Merino").First();
            team1 = context.Teams.Where(t => t.Name == "Sevilla").First();
            team2 = context.Teams.Where(t => t.Name == "Real Sociedad").First();
            context.Transfers.Add(new Transfer { Player = player, LastTeam = team1, NewTeam = team2 });

            player = context.Players.Where(p => p.Name == "Alexander Isak").First();
            team1 = context.Teams.Where(t => t.Name == "Sevilla").First();
            team2 = context.Teams.Where(t => t.Name == "Real Sociedad").First();
            context.Transfers.Add(new Transfer { Player = player, LastTeam = team1, NewTeam = team2 });

            context.SaveChanges();
        }
    }
}
