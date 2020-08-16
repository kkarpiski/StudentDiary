using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(3.5f);

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            for (; ;)
            {
                Console.WriteLine("Podaj ocenę z zakresu od 1 - 10");

                float rating;
                bool  result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 11)
                {
                    break;
                }

                if (result)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba. Podaj liczbę od 1 do 10!");
                    }
                }

            }

            Console.WriteLine("Średnia wpisanych ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa wpisana ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa wpisana ocena to: " + diary.GiveMinRating());

            Console.ReadKey();
        }
    }
}
