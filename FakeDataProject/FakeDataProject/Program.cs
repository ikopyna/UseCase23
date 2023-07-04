using FakeDataProject.Extensions;
using FakeDataProject.Models;

namespace FakeDataProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<Title> titles = FakeDataCreator.GenerateFakeTitles(120);
            List<Credit> credits = FakeDataCreator.GenerateFakeCredits(titles, 20);

            titles.WriteToCsv("Titles.csv");
            credits.WriteToCsv("Credits.csv");
        }
    }
}