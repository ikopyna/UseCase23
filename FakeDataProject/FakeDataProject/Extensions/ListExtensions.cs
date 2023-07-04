using CsvHelper;
using System.Globalization;

namespace FakeDataProject.Extensions
{
    /// <summary>
    /// Provides extension methods for <see cref="List{T}"/>.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Writes the List of T to a CSV file.
        /// </summary>
        /// <typeparam name="T">The type of the objects in the list.</typeparam>
        /// <param name="list">The list of objects to write to the CSV file.</param>
        /// <param name="filePath">The path to the CSV file.</param>
        public static void WriteToCsv<T>(this List<T> list, string filePath)
        {
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(list);
        }
    }
}
