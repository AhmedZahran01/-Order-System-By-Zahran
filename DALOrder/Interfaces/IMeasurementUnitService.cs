using BLLOrder.Models;

namespace Dewan.QuickOrder.Client.Domain.Services
{
    public interface IMeasurementUnitService
    {
        List<MeasurementUnit> GetAllMeasurementUnits();
        MeasurementUnit GetMeasurementUnitById(int id);
        void InsertMeasurmentUnit(MeasurementUnit measurmentUnit);
    }
}