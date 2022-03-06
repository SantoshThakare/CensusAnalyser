using IndianStateAnalyser;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace CensusAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        string stateCensusPath = @"E:\VSCode\BasicProgram\CensusAnalyser\IndianStateAnalyser\IndianStateCensusData.csv";
        string wrongPath = @"E:\VSCode\BasicProgram\CensusAnalyser\IndianStateAnalyser\IndianStateCensusData.csv";
        string wrongFileType = @"E:\VSCode\BasicProgram\CensusAnalyser\IndianStateAnalyser\TextFile1.txt";
        string invalidDelimeter = @"E:\VSCode\BasicProgram\CensusAnalyser\IndianStateAnalyser\WorngDelimeter.csv";
        IndianStateAnalyser.CensusAdapterFactory csv = null;
        CensusAdapter adapter;
        Dictionary<string, CensusDataDAO> totalRecord;
        string[] stateRecord;

        [TestInitialize]
        public void testSetup()
        {
            csv = new CensusAdapterFactory();
            adapter = new CensusAdapter();
            totalRecord = new Dictionary<string, CensusDataDAO>();
        }

        //TC1.1
        //total count of the census list
        [TestMethod]
        public void GivenStateCensusReturnTotalRecord()
        {
            stateRecord = adapter.GetCensusData(stateCensusPath, "State,Population,AreaInSqKm,DensityPerSqKm");
            int actual = stateRecord.Length - 1;
            int expected = 5;
            
            Assert.AreEqual(actual, expected);
        }
        //TC 1.2
        // return file not exist
        [TestMethod]
        public void GivenIncorrectPath()
        {
            try
            {
                var stateRecor = adapter.GetCensusData(wrongPath, "State,Population,AreaInSqKm,DensityPerSqKm");

            }
            catch (CensusAnalyserException ce)
            {
                Assert.AreEqual("File Not Found", ce.Message);
            }
        }
        //TC 1.3
        // invalid file it returns invalid file type exception
        [TestMethod]
        public void GivenInvalidFile()
        {
            try
            {
                var stateRecor = adapter.GetCensusData(wrongFileType, "State,Population,AreaInSqKm,DensityPerSqKm");

            }
            catch (CensusAnalyserException ce)
            {
                Assert.AreEqual("Invalid File Type", ce.Message);
            }
        }
        //TC 1.4
        // invalid delimeter
        [TestMethod]
        public void GivenInvalidDelimeter()
        {
            try
            {
                var stateRecor = adapter.GetCensusData(invalidDelimeter, "State,Population,AreaInSqKm,DensityPerSqKm");

            }
            catch (CensusAnalyserException ce)
            {
                Assert.AreEqual("File contains invalid Delimiter", ce.Message);
            }
        }
        //TC 1.5
        //incorrect header
        [TestMethod]
        public void GivenIncorrectHeader()
        {
            try
            {
                var stateRecor = adapter.GetCensusData(invalidDelimeter, "State,Population,Area,DensityPerSqKm");

            }
            catch (CensusAnalyserException ce)
            {
                Assert.AreEqual("Data header in not matched", ce.Message);
            }
        }
    }
}
    
