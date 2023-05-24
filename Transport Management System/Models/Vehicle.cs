using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Management_System.Models
{
    internal enum VehicleType
    {
        TRUCK,
        SEMI_TRUCK,
        VAN
    }

    internal class Vehicle
    {
        private string name;
        private int aquisitionYear;
        private VehicleType type;
        private int maxCargoWeight;
        private DateTime lastService;
        private DateTime nextService;

        public Vehicle(string name, int aquisitionYear, VehicleType type, int maxCargoWeight, DateTime lastService, DateTime nextService)
        {
            this.name = name;
            this.aquisitionYear = aquisitionYear;
            this.type = type;
            this.maxCargoWeight = maxCargoWeight;
            this.lastService = lastService;
            this.nextService = nextService;
        }

        public string Name { get => name; set => name = value; }
        public int AquisitionYear { get => aquisitionYear; set => aquisitionYear = value; }
        public VehicleType Type { get => type; set => type = value; }
        public int MaxCargoWeight { get => maxCargoWeight; set => maxCargoWeight = value; }
        public DateTime LastService { get => lastService; set => lastService = value; }
        public DateTime NextService { get => nextService; set => nextService = value; }

        public override string ToString()
        {
            return (Name + "," + AquisitionYear + "," + Type.ToString() + ","
                + MaxCargoWeight + "," + LastService.ToString() + "," + NextService.ToString());
        }
    }
}
