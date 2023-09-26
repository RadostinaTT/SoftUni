namespace BookShop
{
    using Data;
    using Initializer;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);

            //int input = int.Parse(Console.ReadLine());
            //string input = Console.ReadLine();

            //string result = CountCopiesByAuthor(db, input);
            //string result = IncreasePrices(db);
            IncreasePrices(db);

            //Console.WriteLine(result);


        }

        //02
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            

            List<string> bookTitles = context
                .Books
                .AsEnumerable()
                .Where(b => b.AgeRestriction.ToString().ToLower() == command.ToLower())
                .Select(b => b.Title)
                .OrderBy(bt => bt)
                .ToList();

            return string.Join(Environment.NewLine, bookTitles);
        }

        //03
        public static string GetGoldenBooks(BookShopContext context)
        {
            List<string> bookTitles = context.Books
                .Where(b => b.EditionType == Models.Enums.EditionType.Gold && b.Copies < 5000)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return String.Join(Environment.NewLine, bookTitles);
        }

        //05
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            List<string> bookTitlesNotReleased = context.Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            return String.Join(Environment.NewLine, bookTitlesNotReleased);
        }

        //06
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            string[] categories = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(c => c.ToLower())
                .ToArray();

            List<string> booksByCategory = new List<string>();

            foreach (var cat in categories)
            {
                List<string> currentBooks = context.Books
                .Where(b => b.BookCategories.Any(bc => bc.Category.Name.ToLower() == cat))
                .Select(b => b.Title)
                .ToList();

                booksByCategory.AddRange(currentBooks);
            }

            booksByCategory = booksByCategory.OrderBy(bc => bc).ToList();
                       
            return String.Join(Environment.NewLine, booksByCategory);
        }

        //09
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            List<string> bookTitlesContaining = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))                
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            return String.Join(Environment.NewLine, bookTitlesContaining);
        }

        //12
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var copiesByAuthor = context.Authors
                .Select(b => new 
                {
                    FullName = b.FirstName + " " + b.LastName,
                    CountBooks = b.Books.Sum(bc => bc.Copies)
                })
                .OrderByDescending(b => b.CountBooks)
                .ToList();

            foreach (var copy in copiesByAuthor)
            {
                sb.AppendLine($"{copy.FullName} - {copy.CountBooks}");
            }

            return sb.ToString().TrimEnd();
        }

        //13
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categories = context.Categories
                .Select(c => new
                {
                    c.Name,
                    TotalProfit = c.CategoryBooks.Select(cb => new
                    {
                        BookProfit = cb.Book.Price * cb.Book.Copies
                    })
                    .Sum(cb => cb.BookProfit)
                })
                .OrderByDescending(b => b.TotalProfit)
                .ThenBy(c => c.Name)
                .ToList();

            foreach (var cat in categories)
            {
                sb.AppendLine($"{cat.Name} ${cat.TotalProfit:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        //14
        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categories = context.Categories
                .Select(c => new
                {
                    CategoryName = c.Name,
                    MostRecent = c.CategoryBooks.Select(cb => new 
                    { 
                        BookTitle = cb.Book.Title,
                        ReleaseDate = cb.Book.ReleaseDate

                    })
                    .OrderByDescending(cb => cb.ReleaseDate)
                    .Take(3)
                    .ToList()
                })
                .OrderBy(b => b.CategoryName)
                .ToList();

            foreach (var cat in categories)
            {
                sb.AppendLine($"--{cat.CategoryName}");
                foreach (var book in cat.MostRecent)
                {
                    sb.AppendLine($"{book.BookTitle} ({book.ReleaseDate.Value.Year})");
                }
            }

            return sb.ToString().TrimEnd();
        }

        //15
        public static void IncreasePrices(BookShopContext context)
        {
            var booksToUpdate = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010);

            foreach (var book in booksToUpdate)
            {
                book.Price += 5;
            }

            context.SaveChanges();
        }
    }
}
