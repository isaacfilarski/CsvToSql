using DAL.CsvToSql;
using System.Threading.Tasks;

namespace Repositories.CsvToSql
{
    public interface ICsvToSqlRespository
    {
        /// <summary>
        /// Adds a new Ad record into the table Ad
        /// </summary>
        /// <param name="request">Ad</param>
        /// <returns>The inserted record identifier.</returns>
        int AddNewAdvertisement(Ad request);
    }
}
