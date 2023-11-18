using Data.Database;
using Data.Entities.Measurement;
using Logic.Measurement.Interfaces;
using Logic.Shared;

namespace Logic.Measurement
{
    public class MeasurementAdressRepository: GenericRepository<MeasurementAdress>, IMeasurementAdressRepository
    {
        public MeasurementAdressRepository(AppDataContext context): base(context)
        {
            
        }

        public async Task<List<MeasurementAdress>> GetAllAdresses()
        {
            return await Task.FromResult(await GetAll());
        }

        public async Task AddNew(MeasurementAdress measurementAdress)
        {
            var all = await GetAll();

            if(!all.Where(x => x.City.ToLower().Equals(measurementAdress.City.ToLower()) 
                && x.Street.ToLower().Equals(measurementAdress.Street.ToLower())
                && x.HouseNumber == measurementAdress.HouseNumber).Any())
            {
                await Insert(measurementAdress);
            }
        }
    }
}
