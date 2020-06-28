using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CsvReader
    {
        private string _csvFilepath;//Ruta del archivo

        public CsvReader(string csvFilepath)
        {
            this._csvFilepath = csvFilepath;
        }
    
        public List<ResturantTable> ReadingTables()
        {
            List<ResturantTable> tables = new List<ResturantTable>();
            using(StreamReader sr=new StreamReader(_csvFilepath))
            {
                //reading header line
                sr.ReadLine();
                string csvLine;
                while ((csvLine = sr.ReadLine()) != null)
                {
                    tables.Add(ReadTablesFromCsvFile(csvLine));
                }
                return tables;
            }
        }

    public ResturantTable ReadTablesFromCsvFile(string csvLine)
    {
      string[] parts = csvLine.Split(new char[] { ',' });
            string name=parts[0];
            string people=parts[1];
            string state = parts[2];

            int.TryParse(people, out int peopleQ);

            return new ResturantTable(name, peopleQ, state);
           
        }
}
}