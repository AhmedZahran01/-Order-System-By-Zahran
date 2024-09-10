using BLLOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLOrder.Interfaces
{
    public interface IMeasurementUnitService
    {
        List<MeasurementUnit> GetAllMeasurementUnits();
        MeasurementUnit GetMeasurementUnitById(int id);
        void InsertMeasurmentUnit(MeasurementUnit measurmentUnit);
    }
}
