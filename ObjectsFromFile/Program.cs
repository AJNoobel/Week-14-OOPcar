using System;
using System.IO;
namespace ObjectsFromFile
{
    class Program
    {
        class movie
        {
            public string title;
            public string rating;
            public string year;


            public movie(string _title, string _rating, string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }




        }
       public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\opilane\samples\movies.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
        public static void DisplayArrayElements(string [] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine(element);
            }
        }

        static void Main(string[] args)
        {
            foreach(string movie in GetDataFromFile())
            {
                string[] tempArray = movie.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                movie newMovie = new movie(tempArray[0], tempArray[1], tempArray[2]);
                Console.WriteLine($"Title: {newMovie.title}, Rating: {newMovie.rating}, Year: {newMovie.year}");
            }

            //DisplayArrayElements(GetDataFromFile());

           /* Console.WriteLine($"Title:, rating:, year:")*/;
            
        }
    }
}
