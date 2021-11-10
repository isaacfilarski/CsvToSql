using Core.Models;
using Core.Response.CsvToSql;
using CsvHelper;
using DAL.CsvToSql;
using Repositories.CsvToSql;
using Services.CsvToSql;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{
    public class CsvToSqlService : ICsvToSqlService
    {
        private readonly ICsvToSqlRespository _csvToSqlRepository;

        public CsvToSqlService(ICsvToSqlRespository csvToSqlRespository)
        {
            _csvToSqlRepository = csvToSqlRespository;
        }

        /// <summary>
        /// Adds a new record to the "Ad" table.
        /// </summary>
        /// <param name="file">Stream file</param>
        /// <returns>NewAdResponse containing the inserted record indentifier.</returns>
        public NewAdResponse AddNewAd(Stream file)
        {
            using (var csv = new CsvReader(new StreamReader(file), CultureInfo.InvariantCulture))
            {
                var rows = csv.GetRecords<NewAdRow>().ToList();

                var request = new Ad();
                foreach (var row in rows)
                {
                    request.Id = row.AdUnitId;
                }

                var newAdId = _csvToSqlRepository.AddNewAdvertisement(request);

                return new NewAdResponse { AdId = newAdId};
            }
        }
    }
}
