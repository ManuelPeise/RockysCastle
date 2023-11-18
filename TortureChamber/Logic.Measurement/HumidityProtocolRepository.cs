using Data.Database;
using Data.Entities.Measurement;
using Logic.Measurement.Interfaces;
using Logic.Shared;

namespace Logic.Measurement
{
    public class HumidityProtocolRepository : GenericRepository<HumidityLogEntry>, IHumidityProtocolRepository
    {
        public HumidityProtocolRepository(AppDataContext context) : base(context)
        {

        }

        public async Task<IEnumerable<HumidityLogEntry>> GetLogEntriesByDate(DateTime date)
        {
            var allEntites = await GetAll();

            return allEntites.Where(x => x.TimeStamp.ToString("yyyy-MM-dd").Equals(date.ToString("yyyy-MM-dd")));
        }

        public async Task<IEnumerable<IGrouping<DateTime, HumidityLogEntry>>> GetOrderedByDate()
        {
            var allEntites = await GetAll();

            var grouped = allEntites.GroupBy(x => x.TimeStamp);

            return grouped;
        }

    }
}
