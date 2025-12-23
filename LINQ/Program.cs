namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var games = new List<Game>
{
    new Game { Title = "The Legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 9.5, Price = 60 },
    new Game { Title = "Super Mario Bros.", Genre = "Platformer", ReleaseYear = 1985, Rating = 9.2, Price = 50 },
    new Game { Title = "Elden Ring", Genre = "Adventure", ReleaseYear = 2022, Rating = 9.8, Price = 50 },
    new Game { Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
    new Game { Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10 }
};

            //foreach (var game in games) {
            //    Console.WriteLine(game.Title);
            //}

            // Projection

            //            var allGames = games.Select(g => g.Title);
            // Console.WriteLine(allGames); => WILL GIVE REFERENCE ONLY NOT VALUES
            //          foreach (var game in allGames) {
            //          Console.WriteLine(game);
            //        }

            // Now using filter

            //var allGames = games.Where(g => g.Genre == "Puzzle");
            //foreach (var game in allGames) {
            //    Console.WriteLine($"Game Title = {game.Title} Release Year = {game.ReleaseYear}");
            //}


            // Now using Any Property=> returns true or false for condition
            /*
            var mordenGamesExists = games.Any(g => g.ReleaseYear > 2012);
            Console.WriteLine($"Do Morden Games Exists : {mordenGamesExists}");

            var listMordernGames = games.Where(g => g.ReleaseYear > 2012);
            foreach(var game in listMordernGames)
            {
                Console.WriteLine(game.Title);
            }
            */

            // Sorting

            /*
            var sortedGames = games.OrderBy(g => g.ReleaseYear);

            foreach (var game in sortedGames) {
                Console.WriteLine($"{game.Title}  {game.ReleaseYear}");
            }
            Console.WriteLine("-----------------------------------");
            var DescsortedGames = games.OrderByDescending(g => g.ReleaseYear);
            foreach (var game in DescsortedGames)
            {
                Console.WriteLine($"{game.Title}  {game.ReleaseYear}");
            }
            */

            // Aggregate Fnc

            /*
            var avgPrice = games.Average(g => g.Price);
            Console.WriteLine(avgPrice.ToString());

            */
            // Will throw an error because max is returning double not an object
            /*
             var bestGame = games.Max(g => g.Rating);
             Console.WriteLine($"BEST GAME IS : {bestGame.Title} {bestGame.Rating}");
            */

            // Step 1  (MaxBy) => returns complete obj

            /*
             var bestGame = games.MaxBy(g => g.Rating);
             Console.WriteLine($"BEST GAME IS : {bestGame.Title} {bestGame.Rating}");
            */

            // STEP2  USING SORTING AND FIRST

            /*
            var bestGame = games.OrderByDescending(g=>g.Rating).First();
            Console.WriteLine($"Best GAME IS : {bestGame.Title} AND RATING IS {bestGame.Rating}");
            */

            // STEP 3 TWO STEP APPROACH
            /*
                        var maxRating = games.Max(g => g.Rating);
                        var bestGames = games.First(g => g.Rating == maxRating);
                        Console.WriteLine($"Best GAME IS : {bestGames.Title} AND RATING IS {bestGames.Rating}");

                        //what if there are multiple games with highest rating and we want all of them

                        var maXrating = games.Max(g => g.Rating);
                        var AllbestGames = games.Where(g => g.Rating == maXrating);
                        foreach(var game in AllbestGames)
                        {
                            Console.WriteLine(game.Title);
                        }

                        */

            // Grouping

            /*
            var grpGenre = games.GroupBy(g => g.Genre);
            foreach(var grp in grpGenre)
            {
                Console.WriteLine($"Genre is : {grp.Key}");
                foreach(var game in grp)
                {
                    Console.WriteLine(game.Title);
                }
            }
            */

            // Chaining
            /*
            var budgetAdventureGames = games
                                    .Where(g => g.Genre == "Adventure" && g.Price <= 60)
                                    .OrderBy(g => g.Rating)
                                    .Select(g => $"{g.Title} - ${g.Price}");
            foreach (var game in budgetAdventureGames)
                Console.WriteLine(game);
            */

            // Pagination skip and take
            /*
            var paginated = games.Skip(1).Take(2);
            foreach (var game in paginated) {
                Console.WriteLine($"GAME TITLE : {game.Title}");
            }
            */


            // Practical Scenario
            // Finding the chepeast game

            /*
             var cheapestGame = games.OrderBy(g => g.Price).First();

             Console.WriteLine($"{cheapestGame.Title}- {cheapestGame.Price}");
            */

            // Distinct Genre
            var Alldistinct = games.Select(g => g.Genre).Distinct();
            foreach (var genre in Alldistinct) {
                Console.WriteLine(genre);
            }
        }
    }
}
