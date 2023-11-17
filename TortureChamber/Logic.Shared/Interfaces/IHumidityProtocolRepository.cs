using Data.Entities.Measurement;

namespace Logic.Shared.Interfaces
{
    public interface IHumidityProtocolRepository: IGenericRepository<HumidityLogEntry>
    {
        Task<IEnumerable<HumidityLogEntry>> GetLogEntriesByDate(DateTime date);
        Task<IEnumerable<IGrouping<DateTime, HumidityLogEntry>>> GetOrderedByDate();
    }
}
