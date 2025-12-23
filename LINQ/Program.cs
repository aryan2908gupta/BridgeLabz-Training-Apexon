using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            var games = new List<Game>
{
    new Game { Title = "The Legend of Zelda", Genre = "Adventure", ReleaseYear = 1986, Rating = 9.5, Price = 60 },
    new Game { Title = "Super Mario Bros.", Genre = "Platformer", ReleaseYear = 1985, Rating = 9.2, Price = 50 },
    new Game { Title = "Elden Ring", Genre = "Adventure", ReleaseYear = 2022, Rating = 9.8, Price = 50 },
    new Game { Title = "Stardew Valley", Genre = "Simulation", ReleaseYear = 2016, Rating = 9.0, Price = 15 },
    new Game { Title = "Tetris", Genre = "Puzzle", ReleaseYear = 1984, Rating = 8.9, Price = 10 }
};
*/
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
            //var Alldistinct = games.Select(g => g.Genre).Distinct();
            //foreach (var genre in Alldistinct) {
            //    Console.WriteLine(genre);
            //}



            // Employees
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Aryan", Department = "IT", Salary = 60000, JoiningDate = DateTime.Now.AddMonths(-2), DepartmentId = 1 },
                new Employee { Id = 2, Name = "Rohit", Department = "HR", Salary = 45000, JoiningDate = DateTime.Now.AddMonths(-8), DepartmentId = 2 },
                new Employee { Id = 3, Name = "Sneha", Department = "IT", Salary = 80000, JoiningDate = DateTime.Now.AddMonths(-5), DepartmentId = 1 },
                new Employee { Id = 4, Name = "Pooja", Department = "Finance", Salary = 70000, JoiningDate = DateTime.Now.AddMonths(-3), DepartmentId = 3 },
                new Employee { Id = 5, Name = "Amit", Department = "HR", Salary = 50000, JoiningDate = DateTime.Now.AddMonths(-1), DepartmentId = 2 }
            };

            // Departments
            var departments = new List<Department>
            {
                new Department { Id = 1, DeptName = "IT" },
                new Department { Id = 2, DeptName = "HR" },
                new Department { Id = 3, DeptName = "Finance" }
            };

            // Products
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Category = "Electronics", Price = 70000 },
                new Product { Name = "Mouse", Category = "Electronics", Price = 800 },
                new Product { Name = "Chair", Category = "Furniture", Price = 5000 },
                new Product { Name = "Table", Category = "Furniture", Price = 12000 }
            };

            /*Q
            var empsal = employees.Average(e => e.Salary);
            
            var emp = employees.Where(e => e.Salary > empsal);
            foreach(var employee in emp)
            {
                Console.WriteLine($"Name : {employee.Name}  Salary : {employee.Salary}");
            }
            */

            /* TOP 3 HIGH PAYING SALARY
            var emp = employees.OrderByDescending(e => e.Salary).Take(3);
            foreach(var employee in emp)
            {
                Console.WriteLine($"Employee Name : {employee.Name} Salary : {employee.Salary}");
            }
            */


            //How do you filter products whose prices fall between a specific range using LINQ?

            /*
            var product = products.Where(e => e.Price>=800 && e.Price<=16000);
            foreach(var pro in product)
            {
                Console.WriteLine($"Product Name : {pro.Name}  Price : {pro.Price}");
            }
            */

            // Convert Name to UpperCasse
            /*
            var emp = employees.Select(e => e.Name = e.Name.ToUpper());
            foreach(var emplo in emp)
            {
                Console.WriteLine($"Name : {emplo}");
            }
            */


            /*
             GROUP BY AND COUNT
            var ans = employees.GroupBy(e => e.Department).Select(emp => new { Department = emp.Key,  empCount=emp.Count() });
            foreach(var i in ans)
            Console.WriteLine(i);

            */
            /*
            var emp = employees.Where(e => e.JoiningDate <= DateTime.Now.AddMonths(6) && e.Department == "IT");
            foreach (var empo in emp)
            {
                Console.WriteLine($"Name : {empo.Name} DOJ : {empo.JoiningDate}");
            }
            */

            // Sorting names on ascending order

            /*
            var emp = employees.OrderBy(e => e.Name);
            foreach(var empo in emp)
            {
                Console.WriteLine($"Name : {empo.Name}");
            }
            */

            // Category wise Product average price
            var productAvg = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    AvgPrice = g.Average(p => p.Price)
                });

            foreach (var pro in productAvg)
            {
                Console.WriteLine($"Category : {pro.Category}  AvgPrice : {pro.AvgPrice}");
            }

        }
    } 
}
