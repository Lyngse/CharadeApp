using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CharadeApp
{
    public class GetCategoryItems
    {
        public List<string> customCategoryItems = new List<string>();
        public GetCategoryItems()
        {

        }

        // Good Luck (random shit), Lord of the Rings, Custom game, Memes, Lande, Erhverv, Serier, Brands

        public List<string> GetItems(string categoryStringId)
        {
            switch (categoryStringId)
            {
                case "LeagueOfLegends":
                    return LeagueOfLegends();
                case "SportAthletes":
                    return SportAthletes();
                case "MarvelCharacters":
                    return MarvelCharacters();
                case "DisneyMoviesAndShows":
                    return DisneyMoviesAndShows();
                case "DisneyCharacters":
                    return DisneyCharacters();
                case "GameOfThrones":
                    return GameOfThrones();
                case "Movies":
                    return Movies();
                case "StarWars":
                    return StarWars();
                case "CustomCategory":
                    return CustomCategory();
                default:
                    return new List<string>();
            }
        }

        public List<string> LeagueOfLegends()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Aatrox");
            resultList.Add("Ahri");
            resultList.Add("Akali");
            resultList.Add("Alistar");
            resultList.Add("Amumu");
            resultList.Add("Anivia");
            resultList.Add("Annie");
            resultList.Add("Ashe");
            resultList.Add("Aurelion Sol");
            resultList.Add("Azir");
            resultList.Add("Bard");
            resultList.Add("Blitzcrank");
            resultList.Add("Brand");
            resultList.Add("Braum");
            resultList.Add("Caitlyn");
            resultList.Add("Camille");
            resultList.Add("Cassiopeia");
            resultList.Add("Cho'Gath");
            resultList.Add("Corki");
            resultList.Add("Darius");
            resultList.Add("Diana");
            resultList.Add("Dr. Mundo");
            resultList.Add("Draven");
            resultList.Add("Ekko");
            resultList.Add("Elise");
            resultList.Add("Evelynn");
            resultList.Add("Ezreal");
            resultList.Add("Fiddlesticks");
            resultList.Add("Fiora");
            resultList.Add("Fizz");
            resultList.Add("Galio");
            resultList.Add("Gangplank");
            resultList.Add("Garen");
            resultList.Add("Gnar");
            resultList.Add("Gragas");
            resultList.Add("Graves");
            resultList.Add("Hecarim");
            resultList.Add("Heimerdinger");
            resultList.Add("Illaoi");
            resultList.Add("Irelia");
            resultList.Add("Ivern");
            resultList.Add("Janna");
            resultList.Add("Jarvan IV");
            resultList.Add("Jax");
            resultList.Add("Jayce");
            resultList.Add("Jhin");
            resultList.Add("Jinx");
            resultList.Add("Kai'Sa");
            resultList.Add("Kalista");
            resultList.Add("Karma");
            resultList.Add("Karthus");
            resultList.Add("Kassadin");
            resultList.Add("Katarina");
            resultList.Add("Kayle");
            resultList.Add("Kayn");
            resultList.Add("Kennen");
            resultList.Add("Kha'Zix");
            resultList.Add("Kindred");
            resultList.Add("Kled");
            resultList.Add("Kog'Maw");
            resultList.Add("LeBlanc");
            resultList.Add("Lee Sin");
            resultList.Add("Leona");
            resultList.Add("Lissandra");
            resultList.Add("Lucian");
            resultList.Add("Lulu");
            resultList.Add("Lux");
            resultList.Add("Malphite");
            resultList.Add("Malzahar");
            resultList.Add("Maokai");
            resultList.Add("Master Yi");
            resultList.Add("Miss Fortune");
            resultList.Add("Mordekaiser");
            resultList.Add("Morgana");
            resultList.Add("Nami");
            resultList.Add("Nasus");
            resultList.Add("Nautilus");
            resultList.Add("Neeko");
            resultList.Add("Nidalee");
            resultList.Add("Nocturne");
            resultList.Add("Nunu & Willump");
            resultList.Add("Olaf");
            resultList.Add("Orianna");
            resultList.Add("Ornn");
            resultList.Add("Pantheon");
            resultList.Add("Poppy");
            resultList.Add("Pyke");
            resultList.Add("Quinn");
            resultList.Add("Rakan");
            resultList.Add("Rammus");
            resultList.Add("Rek'Sai");
            resultList.Add("Renekton");
            resultList.Add("Rengar");
            resultList.Add("Riven");
            resultList.Add("Rumble");
            resultList.Add("Ryze");
            resultList.Add("Sejuani");
            resultList.Add("Shaco");
            resultList.Add("Shen");
            resultList.Add("Shyvana");
            resultList.Add("Singed");
            resultList.Add("Sion");
            resultList.Add("Sivir");
            resultList.Add("Skarner");
            resultList.Add("Sona");
            resultList.Add("Soraka");
            resultList.Add("Swain");
            resultList.Add("Syndra");
            resultList.Add("Tahm Kench");
            resultList.Add("Taliyah");
            resultList.Add("Talon");
            resultList.Add("Taric");
            resultList.Add("Teemo");
            resultList.Add("Thresh");
            resultList.Add("Tristana");
            resultList.Add("Trundle");
            resultList.Add("Tryndamere");
            resultList.Add("Twisted Fate");
            resultList.Add("Twitch");
            resultList.Add("Udyr");
            resultList.Add("Urgot");
            resultList.Add("Varus");
            resultList.Add("Vayne");
            resultList.Add("Veigar");
            resultList.Add("Vel'Koz");
            resultList.Add("Vi");
            resultList.Add("Viktor");
            resultList.Add("Vladimir");
            resultList.Add("Volibear");
            resultList.Add("Warwick");
            resultList.Add("Wukong");
            resultList.Add("Xayah");
            resultList.Add("Xerath");
            resultList.Add("Xin Zhao");
            resultList.Add("Yasuo");
            resultList.Add("Yorick");
            resultList.Add("Zac");
            resultList.Add("Zed");
            resultList.Add("Ziggs");
            resultList.Add("Zilean");
            resultList.Add("Zoe");

            return resultList;
        }

        public int LeagueOfLegendsCount()
        {
            var lol = LeagueOfLegends();
            return lol.Count;
        }

        public List<string> SportAthletes()
        {
            List<string> resultList = new List<string>();

            resultList.Add("Christiano Ronaldo");
            resultList.Add("LeBron James");
            resultList.Add("Lionel Messi");
            resultList.Add("Roger Federer");
            resultList.Add("Neymar");
            resultList.Add("Usain Bolt");
            resultList.Add("Tiger Woods");
            resultList.Add("Mikkel Hansen");
            resultList.Add("Niklas Landin");
            resultList.Add("Tom Brady");
            resultList.Add("Serena Williams");
            resultList.Add("Caroline Wozniacki");
            resultList.Add("Zlatan Ibrahimovix");
            resultList.Add("Mike Tyson");
            resultList.Add("Gareth Bale");
            resultList.Add("Ronaldinho");
            resultList.Add("Luis Suárez");
            resultList.Add("Michael Laudrup");
            resultList.Add("Peter Schmeichel");
            resultList.Add("Eli Manning");
            resultList.Add("David Beckham");
            resultList.Add("Manuel Neuer");
            resultList.Add("Lewis Hamilton");
            resultList.Add("Michael Schumacher");
            resultList.Add("Michael Phelps");
            resultList.Add("Jeanette Ottesen");
            resultList.Add("Nicklas Bendtner");
            resultList.Add("Christian Eriksen");
            resultList.Add("Harry Kane");
            resultList.Add("Viktor Axelsen");
            resultList.Add("Zinedine Zidane");
            resultList.Add("Roberto Carlos");
            resultList.Add("Ronaldo Nazario");
            resultList.Add("Kylian Mbappé");

            return resultList;
        }

        public int SportAthletesCount()
        {
            var sa = SportAthletes();
            return sa.Count;
        }

        public List<string> MarvelCharacters()
        {
            List<string> resultList = new List<string>();

            resultList.Add("Iron Man");
            resultList.Add("Hulk");
            resultList.Add("Thor");
            resultList.Add("Ultron");
            resultList.Add("Ant-Man");
            resultList.Add("Captain America");
            resultList.Add("Doctor Strange");
            resultList.Add("Spider-Man");
            resultList.Add("Black Panther");
            resultList.Add("Daredevil");
            resultList.Add("Punisher");
            resultList.Add("Deadpool");
            resultList.Add("Nick Fury");
            resultList.Add("Colossus");
            resultList.Add("Bucky Barnes");
            resultList.Add("Hawkeye");
            resultList.Add("Luke Cage");
            resultList.Add("Iron Fist");
            resultList.Add("Scarlet Witch");
            resultList.Add("Cable");
            resultList.Add("War Machine");
            resultList.Add("Captain Marvel");
            resultList.Add("Quicksilver");
            resultList.Add("Vision");
            resultList.Add("Black Widow");
            resultList.Add("Wasp");
            resultList.Add("Falcon");
            resultList.Add("Jessica Jones");
            resultList.Add("Harry Osborn");
            resultList.Add("Uncle Ben");
            resultList.Add("Aunt May");
            resultList.Add("Rocket Raccoon");
            resultList.Add("Groot");
            resultList.Add("Drax");
            resultList.Add("Star-Lord");
            resultList.Add("Mantis");
            resultList.Add("Thanos");
            resultList.Add("Venom");
            resultList.Add("Loki");
            resultList.Add("Gamora");
            resultList.Add("Yondu");

            return resultList;
        }

        public int MarvelCharactersCount()
        {
            var mc = MarvelCharacters();
            return mc.Count;
        }

        public List<string> DisneyMoviesAndShows()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Aladdin");
            resultList.Add("Den lille havfrue");
            resultList.Add("Bambi");
            resultList.Add("Dumbo");
            resultList.Add("Peter Pan");
            resultList.Add("Pinocchio");
            resultList.Add("Mulan");
            resultList.Add("101 Dalmatiner");
            resultList.Add("Tarzan");
            resultList.Add("Robin Hood");
            resultList.Add("Find Nemo");
            resultList.Add("Løvernes Konge");
            resultList.Add("Bjørnebrødre");
            resultList.Add("Skønheden og Udyret");
            resultList.Add("Askepot");
            resultList.Add("Snehvide");
            resultList.Add("Frozen");
            resultList.Add("Moana (Vaiana)");
            resultList.Add("De Utrolige");
            resultList.Add("Vilde Rolf");
            resultList.Add("Big Hero 6");
            resultList.Add("Monsters Inc.");
            resultList.Add("Toy Story");
            resultList.Add("Frikvarter");
            resultList.Add("Hannah Montana");
            resultList.Add("Kejserens nye flip");
            resultList.Add("Herkules");
            resultList.Add("Klokkeren fra Notre Dame");
            resultList.Add("Pocahontas");
            resultList.Add("Junglebogen");
            resultList.Add("Aristocats");
            resultList.Add("Lady og Vagabonden");
            resultList.Add("Tornerose");
            resultList.Add("Sværdet i stenen");
            resultList.Add("Basil mus");
            resultList.Add("Lilo og Stitch");
            resultList.Add("Biler");
            resultList.Add("Ratatouille");
            resultList.Add("Wall-E");
            resultList.Add("Op");
            resultList.Add("Inderst inde");
            resultList.Add("Zootopia");
            resultList.Add("Mads og Mikkel");

            return resultList;
        }

        public int DisneyMoviesAndShowsCount()
        {
            var mc = DisneyMoviesAndShows();
            return mc.Count;
        }

        public List<string> DisneyCharacters()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Abu");
            resultList.Add("Aladdin");
            resultList.Add("Ariel");
            resultList.Add("Baloo");
            resultList.Add("Bambi");
            resultList.Add("Udyret (Beast)");
            resultList.Add("Rip, Rap, og Rup");
            resultList.Add("Klokkeblomst");
            resultList.Add("Peter Pan");
            resultList.Add("Kaptajn Klo");
            resultList.Add("Herkules");
            resultList.Add("Dumbo");
            resultList.Add("Mickey Mouse");
            resultList.Add("Minnie Mouse");
            resultList.Add("Fedtmule");
            resultList.Add("Anders And");
            resultList.Add("Joakim Von And");
            resultList.Add("Pinocchio");
            resultList.Add("Mulan");
            resultList.Add("Andersine");
            resultList.Add("Belle");
            resultList.Add("Askepot");
            resultList.Add("Pluto");
            resultList.Add("Snehvide");
            resultList.Add("Elsa");
            resultList.Add("Sebastian");
            resultList.Add("Kaa");
            resultList.Add("Tarzan");
            resultList.Add("Robin Hood");
            resultList.Add("Genie");
            resultList.Add("Nemo");
            resultList.Add("Simba");
            resultList.Add("Timon");
            resultList.Add("Pumba");
            resultList.Add("Georg Gearløs");
            resultList.Add("Rafiki");
            resultList.Add("Jesper Fårekylling");
            resultList.Add("Chip og Chap");
            resultList.Add("Woody");
            resultList.Add("Buzz Lightyear");
            resultList.Add("Quasimodo");
            resultList.Add("Pocahontas");

            return resultList;
        }

        public int DisneyCharactersCount()
        {
            var mc = DisneyCharacters();
            return mc.Count;
        }

        public List<string> GameOfThrones()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Eddard 'Ned' Stark");
            resultList.Add("Robert Baratheon");
            resultList.Add("Jaime Lannister");
            resultList.Add("Catelyn Stark");
            resultList.Add("Cersei Lannister");
            resultList.Add("Daenerys Targaryen");
            resultList.Add("Jorah Mormont");
            resultList.Add("Viserys Targaryen");
            resultList.Add("Jon Snow");
            resultList.Add("Sansa Stark");
            resultList.Add("Arya Stark");
            resultList.Add("Robb Stark");
            resultList.Add("Theon Greyjoy");
            resultList.Add("Bran Stark");
            resultList.Add("Joffrey Baratheon");
            resultList.Add("Sandor 'The Hound' Clegane");
            resultList.Add("Tyrion Lannister");
            resultList.Add("Khal Drogo");
            resultList.Add("Petyr 'Littlefinger' Baelish");
            resultList.Add("Samwell Tarly");
            resultList.Add("Melisandre");
            resultList.Add("Varys");
            resultList.Add("Ygritte");
            resultList.Add("Ramsay Bolton");
            resultList.Add("Brienne of Tarth");
            resultList.Add("Tommen Baratheon");
            resultList.Add("Rickon Stark");
            resultList.Add("Gregor Clegane");
            resultList.Add("Hodor");
            resultList.Add("Jaqen H'ghar");
            resultList.Add("Ghost");

            return resultList;
        }

        public int GameOfThronesCount()
        {
            var mc = GameOfThrones();
            return mc.Count;
        }

        public List<string> Movies()
        {
            List<string> resultList = new List<string>();

            return resultList;
        }

        public int MoviesCount()
        {
            var mc = Movies();
            return mc.Count;
        }

        public List<string> StarWars()
        {
            List<string> resultList = new List<string>();
            resultList.Add("BB-8");
            resultList.Add("Jar Jar Binks");
            resultList.Add("C-3PO");
            resultList.Add("Chewbacca");
            resultList.Add("R2D2");
            resultList.Add("Boba Fett");
            resultList.Add("Finn");
            resultList.Add("Jabba the Hutt");
            resultList.Add("Qui-Gon Jinn");
            resultList.Add("Obi-Wan Kenobi");
            resultList.Add("Darth Maul");
            resultList.Add("Sheev Palpatine (Darth Sidious)");
            resultList.Add("Kylo Ren");
            resultList.Add("Anakin Skywalker");
            resultList.Add("Darth Vader");
            resultList.Add("Luke Skywalker");
            resultList.Add("Han Solo");
            resultList.Add("Rae Sloane");
            resultList.Add("Supreme Leader Snoke");
            resultList.Add("Yoda");
            resultList.Add("Leia Organa");

            return resultList;
        }

        public int StarWarsCount()
        {
            var mc = StarWars();
            return mc.Count;
        }

        public void AddCustomCategoryItem(string input)
        {
            customCategoryItems.Add(input);
        }

        public void ResetCustomCategory()
        {
            customCategoryItems.Clear();
        }

        public List<string> CustomCategory()
        {
            return customCategoryItems;
        }

        public int CustomCategoryCount()
        {
            var res = CustomCategory();
            return res.Count;
        }

    }
}