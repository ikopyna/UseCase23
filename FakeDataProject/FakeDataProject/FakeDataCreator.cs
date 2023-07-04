using Bogus;
using FakeDataProject.Enums;
using FakeDataProject.Models;

namespace FakeDataProject
{
    /// <summary>
    /// Provides static methods for creating fake data.
    /// </summary>
    public static class FakeDataCreator
    {
        private static readonly string[] Genres = new[] { "Action", "Adventure", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Thriller", "Sci-Fi" };

        /// <summary>
        /// Generates a list of fake <see cref="Title"/> objects.
        /// </summary>
        /// <param name="quantity">The number of Title objects to generate.</param>
        /// <returns>A list of fake Title objects.</returns>
        public static List<Title> GenerateFakeTitles(int quantity)
        {
            var fakeTitle = new Faker<Title>()
                .RuleFor(t => t.Id, f => ++f.IndexVariable)
                .RuleFor(t => t.TitleName, f => f.Lorem.Word())
                .RuleFor(t => t.Description, f => f.Lorem.Sentence())
                .RuleFor(t => t.ReleaseYear, f => f.Date.Past(20).Year)
                .RuleFor(t => t.Certification, f => f.PickRandom<AgeCertification>())
                .RuleFor(t => t.Runtime, f => f.Random.Number(60, 180))
                .RuleFor(t => t.Genres, f => f.PickRandom(Genres, f.Random.Number(1, Genres.Length)).ToList())
                .RuleFor(t => t.ProductionCountry, f => f.Address.CountryCode())
                .RuleFor(t => t.Seasons, f => f.Random.Bool() ? null : f.Random.Number(1, 10));

            return fakeTitle.Generate(quantity);
        }

        /// <summary>
        /// Generates a list of fake <see cref="Credit"/> objects associated with given <see cref="Title"/> list.
        /// </summary>
        /// <param name="titles">The list of Title objects to which the Credit objects will be associated.</param>
        /// <param name="maxQuantityPerTitle">The maximum number of Credit objects to generate for each Title.</param>
        /// <returns>A list of fake Credit objects.</returns>
        public static List<Credit> GenerateFakeCredits(List<Title> titles, int maxQuantityPerTitle)
        {
            var fakeCredit = new Faker<Credit>()
                .RuleFor(c => c.Id, f => ++f.IndexVariable)
                .RuleFor(c => c.RealName, f => f.Person.FullName)
                .RuleFor(c => c.CharacterName, f => f.Name.FullName())
                .RuleFor(c => c.Role, f => f.PickRandom<CreditRole>());

            var random = new Random();
            var credits = new List<Credit>();
            foreach (var title in titles)
            {
                int quantityPerTitle = random.Next(1, maxQuantityPerTitle + 1);

                fakeCredit.RuleFor(c => c.TitleId, title.Id); // Ensure the credit belongs to the current title
                credits.AddRange(fakeCredit.Generate(quantityPerTitle));
            }

            return credits;
        }
    }
}
