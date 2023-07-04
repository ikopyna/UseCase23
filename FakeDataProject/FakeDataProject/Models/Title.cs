using FakeDataProject.Enums;

namespace FakeDataProject.Models
{
    /// <summary>
    /// Represents a movie or series title.
    /// </summary>
    public class Title
    {
        /// <summary>
        /// Gets or sets the unique identifier for the title.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the title.
        /// </summary>
        public string TitleName { get; set; }

        /// <summary>
        /// Gets or sets the description of the title.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the release year of the title.
        /// </summary>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// Gets or sets the age certification of the title.
        /// </summary>
        public AgeCertification Certification { get; set; }

        /// <summary>
        /// Gets or sets the runtime duration of the title in minutes.
        /// </summary>
        public int Runtime { get; set; }

        /// <summary>
        /// Gets or sets the list of genres of the title.
        /// </summary>
        public List<string> Genres { get; set; }

        /// <summary>
        /// Gets or sets the ISO 3166-1 Alpha-3 code of the production country of the title.
        /// </summary>
        public string ProductionCountry { get; set; }

        /// <summary>
        /// Gets or sets the number of seasons of the series. This field is null for movies.
        /// </summary>
        public int? Seasons { get; set; }
    }
}
