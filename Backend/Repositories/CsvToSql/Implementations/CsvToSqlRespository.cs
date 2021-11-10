using DAL.CsvToSql;
using Repositories.CsvToSql;
using System;
using System.Threading.Tasks;

namespace Repositories
{
    public class CsvToSqlRespository : ICsvToSqlRespository
    {

        private readonly CsvToSqlContext _csvToSqlContext;

        public CsvToSqlRespository(CsvToSqlContext csvToSqlContext)
        {
            _csvToSqlContext = csvToSqlContext;
        }

        /// <summary>
        /// Adds a new adversiment record into the table Ad.
        /// </summary>
        /// <param name="adversiment">Adversiment to insert.</param>
        /// <returns>Inserted adversiment identifier.</returns>
        public int AddNewAdvertisement(Ad adversiment)
        {

            _csvToSqlContext.Ad.Add(adversiment);
            _csvToSqlContext.SaveChanges();
            return adversiment.Id;
        }
    }
}
