using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateAnalyser
{
    public class CensusAdapterFactory : CensusAnalyser
    {
        public void LoadCsvData(CensusAnalyser.Country country, string csvFilePath, string dataHeader)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    new IndianCensusAdapter().LoadCensusData(csvFilePath, dataHeader);
                    break;
                default:
                    throw new CensusAnalyserException("No such country", CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }
        }
    }
}
