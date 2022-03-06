using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyser
{
    public class CensusDataDAO
    {
        public string State;
        public string Population;
        public string AreaInSqKm;
        public string DensityPerSqKm;

        public CensusDataDAO(string State, string Population, string AreaInSqKm, string DensityPerSqKm)
        {
            this.State = State;
            this.Population = Population;
            this.AreaInSqKm = AreaInSqKm;
            this.DensityPerSqKm = DensityPerSqKm;
        }
    }
}
