using Microsoft.VisualBasic.FileIO;

namespace MockCsvParser.Models
{
    public class ReadCsv
    {
        public List<DataParser> ReadingCsvFile()
        {
            string[] fields = null;

            var path = @"C:\Git_tech\mock-csvparser\csvmockk.csv";
            TextFieldParser csvParser = new TextFieldParser(path);
            csvParser.SetDelimiters(new string[] { "," });
            csvParser.HasFieldsEnclosedInQuotes = true;

            csvParser.ReadLine();

            List<DataParser> l_dataParser = new List<DataParser>();

            int pos = 1;
            while (!csvParser.EndOfData)
            {

                    DataParser person_data = new DataParser();
                    fields = csvParser.ReadFields();
                    person_data.FirstName = fields[0];
                    person_data.LastName = fields[1];
                    person_data.CompanyName = fields[2];
                    person_data.Address = fields[3];
                    person_data.City = fields[4];
                    person_data.County = fields[5];
                    person_data.Postal = fields[6];
                    person_data.Phone1 = fields[7];
                    person_data.Phone2 = fields[8];
                    person_data.Email = fields[9];
                    person_data.Web = fields[10];
                    person_data.Pos = pos;
                    pos = pos + 1;

                    l_dataParser.Add(person_data);
            }

                return l_dataParser;
            
        }
    }
}
