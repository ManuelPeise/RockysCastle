using Data.Entities.Measurement;
using Logic.Shared.Interfaces;

namespace Logic.Measurement.Interfaces
{
    public interface IHumidityProtocolRepository: IGenericRepository<HumidityLogEntry>
    {
        Task<IEnumerable<HumidityLogEntry>> GetLogEntriesByDate(DateTime date);
        Task<IEnumerable<IGrouping<DateTime, HumidityLogEntry>>> GetOrderedByDate();
    }
}
