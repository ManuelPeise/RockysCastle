using Data.Entities.Measurement;
using Logic.Shared.Interfaces;

namespace Logic.Measurement.Interfaces
{
    public interface IMeasurementAdressRepository: IGenericRepository<MeasurementAdress>
    {
        Task<List<MeasurementAdress>> GetAllAdresses();
        Task AddNew(MeasurementAdress measurementAdress);
    }
}
