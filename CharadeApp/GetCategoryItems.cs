using System.Collections.Generic;

namespace CharadeApp
{
    public class GetCategoryItems
    {
        public List<string> customCategoryItems = new List<string>();
        public GetCategoryItems()
        {

        }

        // Good Luck (random shit), Lord of the Rings, Custom game, Memes, Lande, Erhverv, Serier

        public List<string> GetItems(string categoryStringId)
        {
            switch (categoryStringId)
            {
                case "LeagueOfLegends":
                    return LeagueOfLegends();
                case "SportAthletes":
                    return SportAthletes();
                case "Marvel":
                    return Marvel();
                case "Disney":
                    return Disney();
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
                case "Professions":
                    return Professions();
                case "Brands":
                    return Brands();
                case "HarryPotter":
                    return HarryPotter();
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
            resultList.Add("Sylas");
            resultList.Add("Yuumi");
            resultList.Add("Qiyana");
            resultList.Add("Senna");
            resultList.Add("Aphelios");
            resultList.Add("Sett");
            resultList.Add("Lillia");

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

        public List<string> Marvel()
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
            resultList.Add("War Machine");
            resultList.Add("Captain Marvel");
            resultList.Add("Quicksilver");
            resultList.Add("Vision");
            resultList.Add("Black Widow");
            resultList.Add("Wasp");
            resultList.Add("Falcon");
            resultList.Add("Jessica Jones");
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

        public int MarvelCount()
        {
            var mc = Marvel();
            return mc.Count;
        }

        public List<string> Disney()
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

        public int DisneyCount()
        {
            var mc = Disney();
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
            resultList.Add("Unsullied");
            resultList.Add("Night's Watch");
            resultList.Add("Iron Throne");
            resultList.Add("The High Sparrow");
            resultList.Add("White Walkers");
            resultList.Add("Hand of the King");
            resultList.Add("The Mad King");
            resultList.Add("Wildlings");
            resultList.Add("Westeros");
            resultList.Add("Castle Black");
            resultList.Add("Winterfell");
            resultList.Add("Kings Landing");



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
            resultList.Add("Godfather");
            resultList.Add("The Dark Knight");
            resultList.Add("Ringenes herre");
            resultList.Add("Pulp Fiction");
            resultList.Add("Fight Club");
            resultList.Add("Forrest Gump");
            resultList.Add("The Matrix");
            resultList.Add("Saving Private Ryan");
            resultList.Add("The Green Mile");
            resultList.Add("Titanic");
            resultList.Add("Whiplash");
            resultList.Add("Terminator");
            resultList.Add("Gladiator");
            resultList.Add("The Avengers");
            resultList.Add("Django Unchained");
            resultList.Add("Braveheart");
            resultList.Add("Harry Potter");
            resultList.Add("Der Untergang");
            resultList.Add("The Wolf of Wall Street");
            resultList.Add("Blade Runner");
            resultList.Add("The Notebook");
            resultList.Add("Hacksaw Ridge");
            resultList.Add("Jurassic Park");
            resultList.Add("Transformers");
            resultList.Add("Robin Hood");
            resultList.Add("Deadpool");
            resultList.Add("Avatar");
            resultList.Add("Black Panther");
            resultList.Add("The Hunger Games");
            resultList.Add("Frozen");
            resultList.Add("American Sniper");
            resultList.Add("Guardians of the Galaxy");
            resultList.Add("Skyfall");
            resultList.Add("Twilight");
            resultList.Add("Narnia");
            resultList.Add("Home Alone");
            resultList.Add("Shrek");
            resultList.Add("Jaws");
            resultList.Add("Ghostbusters");
            resultList.Add("Men in Black");
            resultList.Add("The Fast and the Furious");
            resultList.Add("Pirates of the Caribbean");
            resultList.Add("The Hobbit");
            resultList.Add("Ice Age");
            resultList.Add("The Wolverine");
            resultList.Add("Indiana Jones");
            resultList.Add("The Da Vinci Code");
            resultList.Add("Suicide Squad ");
            resultList.Add("Intouchables");
            resultList.Add("Elf");
            resultList.Add("Far til Fire");
            resultList.Add("Min Søsters Børn");
            resultList.Add("Yes Man");
            resultList.Add("The Hangover");
            resultList.Add("Ted");
            resultList.Add("Kung Fu Panda");
            resultList.Add("E.T.");
            resultList.Add("The Breakfast Club");
            resultList.Add("King Kong");
            resultList.Add("Godzilla");
            resultList.Add("Step Up");
            resultList.Add("Spider-Man");
            resultList.Add("High School Musical");
            resultList.Add("Borat");
            resultList.Add("Karate Kid");
            resultList.Add("Back to the Future");
            resultList.Add("Scarface");
            resultList.Add("Mission: Impossible");
            resultList.Add("Die Hard");
            resultList.Add("Dirty Dancing");
            resultList.Add("Grease");
            resultList.Add("Top Gun");
            resultList.Add("Superman");
            resultList.Add("Scream");
            resultList.Add("Olsen Banden");
            resultList.Add("Mean Girls");
            resultList.Add("Politiskolen");
            resultList.Add("Saw");
            resultList.Add("Adams Æbler");
            resultList.Add("De Grønne Slagtere");
            resultList.Add("Kvinden i Buret");
            resultList.Add("Blinkende Lygter");
            resultList.Add("Klovn");
            resultList.Add("Flammen og Citronen");
            resultList.Add("De tre Musketerer");
            resultList.Add("Klassefesten");

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
            resultList.Add("Princess Leia");
            resultList.Add("Padawan");
            resultList.Add("Jedi");
            resultList.Add("Clone Trooper");
            resultList.Add("Lightsaber");
            resultList.Add("Millenium Falcon");
            resultList.Add("Droid");
            resultList.Add("AT-AT Walker");
            resultList.Add("Sith");
            resultList.Add("The Force");
            resultList.Add("Death Star");
            resultList.Add("Ewok");



            return resultList;
        }

        public int StarWarsCount()
        {
            var mc = StarWars();
            return mc.Count;
        }

        public List<string> Professions()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Advokat");
            resultList.Add("Murer");
            resultList.Add("Tømrer");
            resultList.Add("Akupuntør");
            resultList.Add("Arkitekt");
            resultList.Add("Arkæolog");
            resultList.Add("Astronaut");
            resultList.Add("Mekaniker");
            resultList.Add("Bager");
            resultList.Add("Bedemand");
            resultList.Add("Politibetjent");
            resultList.Add("Brandmand");
            resultList.Add("Bibliotekar");
            resultList.Add("Lærer");
            resultList.Add("Brolægger");
            resultList.Add("Buschauffør");
            resultList.Add("Graver");
            resultList.Add("Maler");
            resultList.Add("Danser");
            resultList.Add("Slagter");
            resultList.Add("Dommer");
            resultList.Add("Fodbolddommer");
            resultList.Add("Læge");
            resultList.Add("Sygeplejerske");
            resultList.Add("Elektriker");
            resultList.Add("Fysioterapeut");
            resultList.Add("Fotograf");
            resultList.Add("Fisker");
            resultList.Add("Fitnessinstruktør");
            resultList.Add("Pilot");
            resultList.Add("Stewardesse");
            resultList.Add("Frisør");
            resultList.Add("It-medarbejder");
            resultList.Add("Togfører");
            resultList.Add("Journalist");
            resultList.Add("Præst");
            resultList.Add("Sanger");
            resultList.Add("Kok");
            resultList.Add("Politiker");
            resultList.Add("Massør");
            resultList.Add("Landmand");
            resultList.Add("Bankmand");
            resultList.Add("Metrolog");
            resultList.Add("Soldat");
            resultList.Add("Akrobat");
            resultList.Add("Klovn");
            resultList.Add("Pedel");
            resultList.Add("Postbud");
            resultList.Add("Pædagog");
            resultList.Add("Jordemoder");
            resultList.Add("Turistguide");
            resultList.Add("Skuespiller");
            resultList.Add("Smed");
            resultList.Add("Fodboldspiller");
            resultList.Add("Tandlæge");
            resultList.Add("Tjener");
            resultList.Add("Urmager");


            return resultList;
        }

        public int ProfessionsCount()
        {
            var res = Professions();
            return res.Count;
        }

        public List<string> Brands()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Apple");
            resultList.Add("Google");
            resultList.Add("Microsoft");
            resultList.Add("Facebook");
            resultList.Add("Amazon");
            resultList.Add("Coca-Cola");
            resultList.Add("Disney");
            resultList.Add("Burger King");
            resultList.Add("McDonald's");
            resultList.Add("Redbull");
            resultList.Add("Nike");
            resultList.Add("BMW");
            resultList.Add("Tuborg");
            resultList.Add("Nescafe");
            resultList.Add("Starbucks");
            resultList.Add("Gucci");
            resultList.Add("IKEA");
            resultList.Add("Vestas");
            resultList.Add("Lego");
            resultList.Add("Netflix");
            resultList.Add("Colgate");
            resultList.Add("Rolex");
            resultList.Add("Corona");
            resultList.Add("Kellogg's");
            resultList.Add("Nivea");
            resultList.Add("Pampers");
            resultList.Add("Visa");
            resultList.Add("Shell");
            resultList.Add("PlayStation");
            resultList.Add("Tesla");
            resultList.Add("Harley Davidson");
            resultList.Add("Audi");
            resultList.Add("Gilette");
            resultList.Add("Samsung");
            resultList.Add("Nordea");
            resultList.Add("Prince");
            resultList.Add("Uber");
            resultList.Add("Bilka");
            resultList.Add("Pandora");
            resultList.Add("Mærsk");
            resultList.Add("TDC");
            resultList.Add("Carlsberg");
            resultList.Add("Danish Crown");
            resultList.Add("Lurpak");
            resultList.Add("Arla");
            resultList.Add("Tryg");

            return resultList;
        }

        public int BrandsCount()
        {
            var res = Brands();
            return res.Count;
        }

        public List<string> HarryPotter()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Harry Potter");
            resultList.Add("Sirius Black");
            resultList.Add("Fleur Delacour");
            resultList.Add("Cedric Diggory");
            resultList.Add("Albus Dumbledore");
            resultList.Add("Dudley Dursley");
            resultList.Add("Vernon Dursley");
            resultList.Add("Argus Filch");
            resultList.Add("Seamus Finnigan");
            resultList.Add("Professor Flitwick");
            resultList.Add("Hermione Granger");
            resultList.Add("Crabbe and Goyle");
            resultList.Add("Godric Gryffindor");
            resultList.Add("Madam Hooch");
            resultList.Add("Rubeus Hagrid");
            resultList.Add("Igor Karkaroff");
            resultList.Add("Viktor Krum");
            resultList.Add("Bellatrix Lestrange");
            resultList.Add("Neville Longbottom");
            resultList.Add("Luna Lovegood");
            resultList.Add("Remus Lupin");
            resultList.Add("Draco Malfoy");
            resultList.Add("Lucius Malfoy");
            resultList.Add("Alastor (Mad-Eye) Moody");
            resultList.Add("Garrick Ollivander");
            resultList.Add("Madam Pomfrey");
            resultList.Add("James Potter");
            resultList.Add("Lily Potter");
            resultList.Add("Rowena Ravenclaw");
            resultList.Add("Newt Scamander");
            resultList.Add("Salazar Slytherin");
            resultList.Add("Severus Snape");
            resultList.Add("Professor Sprout");
            resultList.Add("Dean Thomas");
            resultList.Add("Lord Voldemort ");
            resultList.Add("Ginny Weasley");
            resultList.Add("Ron Weasley");
            resultList.Add("Fred and George Weasley");
            resultList.Add("Dobby");
            resultList.Add("Fluffy");
            resultList.Add("Fawkes - Phoenix");
            resultList.Add("Hedwig");
            resultList.Add("Nagini");
            resultList.Add("Scrabbers");
            resultList.Add("Trevor");
            resultList.Add("Professor McGonagall");
            resultList.Add("Arthur Weasley");
            resultList.Add("Molly Weasley");
            resultList.Add("Moaning Myrtle");
            resultList.Add("Aragog");
            resultList.Add("The Fat Lady");
            resultList.Add("Nearly Headless Nick");
            resultList.Add("Sorting Hat");
            resultList.Add("Hogwarts");
            resultList.Add("Whomping Willow");
            resultList.Add("Mrs Norris");
            resultList.Add("Muggle");
            resultList.Add("Elder Wand");
            resultList.Add("Cloak of Invisibility");
            resultList.Add("Nicolas Flamel");
            resultList.Add("Azkaban");
            resultList.Add("Resurrection Stone");
            resultList.Add("Gringotts");
            resultList.Add("Forbidden Forrest");
            resultList.Add("Hogwarts Express");

            return resultList;
        }

        public int HarryPotterCount()
        {
            var res = HarryPotter();
            return res.Count;
        }

        public List<string> Danish()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Dronning Margrethe");
            resultList.Add("Anders Matthesen");
            resultList.Add("Anne Gadegaard");
            resultList.Add("Fie Laursen");
            resultList.Add("Inger Støjberg");
            resultList.Add("Lars Løkke");
            resultList.Add("Linse Kessler");
            resultList.Add("Mikkel Kessler");
            resultList.Add("Mads Mikkelsen");
            resultList.Add("Mick Øgendahl");
            resultList.Add("Peter Madsen");
            resultList.Add("Rasmus Seebach");
            resultList.Add("Chili Klaus");
            resultList.Add("Caroline Wozniacki");
            resultList.Add("Christian Eriksen");
            resultList.Add("Michael Laudrup");
            resultList.Add("Ole Henriksen");
            resultList.Add("Peter Schmeichel");
            resultList.Add("Viktor Axelsen");
            resultList.Add("Mikkel Hansen");
            resultList.Add("Lars Larsen");
            resultList.Add("Rune Klan");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");
            resultList.Add("");

            return resultList;
        }

        public int DanishCount()
        {
            var res = Danish();
            return res.Count;
        }

        public List<string> ThingYouCanDo()
        {
            List<string> resultList = new List<string>();
            resultList.Add("Putte makeup på");
            resultList.Add("Tage tøj på");
            resultList.Add("Vaske hår");
            resultList.Add("Få et baby til at bøvse");
            resultList.Add("Snitte løg");
            resultList.Add("Vaske gulv");
            resultList.Add("Støvsuge");
            resultList.Add("Rede en seng");
            resultList.Add("Åbne et brev");
            resultList.Add("Slå græsplænen");
            resultList.Add("Binde sin sko");
            resultList.Add("Spidse en blyant");
            resultList.Add("Åbne en gave");
            resultList.Add("Gå i kirke");
            resultList.Add("Gå i fitness");
            resultList.Add("Lave yoga");
            resultList.Add("Danse salsa");
            resultList.Add("Stepdanse");
            resultList.Add("Danse ballet");
            resultList.Add("Stå på snowboard");
            resultList.Add("Stå på ski");
            resultList.Add("Køre på mountainbike");
            resultList.Add("Køre på rulleskøjter");
            resultList.Add("Spille bowling");
            resultList.Add("Være på jagt");
            resultList.Add("Undervise");
            resultList.Add("Klippe en andens hår");
            resultList.Add("Blive anholdt");
            resultList.Add("Spille badminton");
            resultList.Add("Ridde på en hest");
            resultList.Add("Lave pandekager");
            resultList.Add("Spejle et æg");
            resultList.Add("Gøre rent");
            resultList.Add("Gå ud med skraldet");
            resultList.Add("Komme for sent");
            resultList.Add("Køre hurtigt");
            resultList.Add("Gymnastik");
            resultList.Add("Være en cirkusartist");
            resultList.Add("Malke en ko");
            resultList.Add("Se TV");
            resultList.Add("Skovle sne");
            resultList.Add("Gå tur med hunden");
            resultList.Add("Klatre");
            resultList.Add("Spise en banan");
            resultList.Add("Lave en pizza");
            resultList.Add("Få hjernefrys");
            resultList.Add("Lege Spiderman");
            resultList.Add("Karate");
            resultList.Add("Imitere Michael Jackson");
            resultList.Add("Sjippe");
            resultList.Add("Være en T-rex");
            resultList.Add("Være sur");
            resultList.Add("Være overrasket");
            resultList.Add("Være fuglekigger");
            resultList.Add("Fælde et træ");
            resultList.Add("Spille petanque");
            resultList.Add("Hoppe på kængurustylte");
            resultList.Add("Spille violin");
            resultList.Add("Spille trækbasun");
            resultList.Add("Skifte en ble");
            resultList.Add("Spille pool");
            resultList.Add("Faldskærmsudspring");
            resultList.Add("Flyve i helikopter");
            resultList.Add("Køre motorcross");
            resultList.Add("Drikke vin");

            return resultList;
        }

        public int ThingYouCanDoCount()
        {
            var res = ThingYouCanDo();
            return res.Count;
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