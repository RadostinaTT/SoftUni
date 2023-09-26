using System;

namespace DateModifier
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier diffrence = new DateModifier();
            var result = Math.Abs(diffrence.DiffrenceInDaysBetweenTwoDates(firstDate, secondDate));
            Console.WriteLine(result);
        }
    }
}
