using FakeDataProject.Enums;

namespace FakeDataProject.Models
{
    /// <summary>
    /// Represents a single credit entry for a movie or series.
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// Gets or sets the unique identifier for the credit.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the title to which this credit is associated.
        /// </summary>
        public int TitleId { get; set; }

        /// <summary>
        /// Gets or sets the real name of the person associated with the credit.
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// Gets or sets the character name associated with the credit.
        /// </summary>
        public string CharacterName { get; set; }

        /// <summary>
        /// Gets or sets the role associated with the credit.
        /// </summary>
        public CreditRole Role { get; set; }
    }
}
