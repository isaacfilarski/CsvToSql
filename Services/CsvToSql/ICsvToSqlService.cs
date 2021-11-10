using Core.Response.CsvToSql;
using System.IO;
using System.Threading.Tasks;

namespace Services.CsvToSql
{
    public interface ICsvToSqlService
    {
        /// <summary>
        /// Adds a new record to the "Ad" table.
        /// </summary>
        /// <param name="file">Stream file</param>
        /// <returns>NewAdResponse containing the inserted record indentifier.</returns>
        NewAdResponse AddNewAd(Stream file);
    }
}
