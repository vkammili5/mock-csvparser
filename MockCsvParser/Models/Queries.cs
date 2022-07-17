using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MockCsvParser.Models
{
    public class Queries
    {
        private int count =0;

        List<DataParser> dataParserList = new List<DataParser>();

        public List<DataParser> WhoHasEsqInCompany(List<DataParser> records)
        {
            var res = from record in records
                      where record.CompanyName.Contains("Esq")
                      select record;
            List<DataParser> dataParse = res.ToList();
            Console.WriteLine("Count {0} ", dataParse.Count);
            foreach (DataParser item in res.ToList())
            {
                dataParserList.Add(item);
            }
            return dataParserList;
        }

        public List<DataParser> WhoLivesInDerby(List<DataParser> records)
        {
            foreach (var item in records)
            { 
                if (item.County == "Derbyshire")
                {
                    count++;
                    dataParserList.Add(item);
                }
            }
            Console.WriteLine("Count: {0}", count);
            return dataParserList;
        }

        public List<DataParser> WhoseHouseNumberIsThreeDigits(List<DataParser> records)
        {

            string pattern = "^\\d{3}\\s";

            foreach (var item in records)
            {
                if (Regex.IsMatch(item.Address, pattern, RegexOptions.IgnoreCase))
                {
                    count++;
                    dataParserList.Add(item);
                }
            }
            Console.WriteLine("Count : {0} ", count);
            return dataParserList;
        }

        public List<DataParser> WhoseWebsiteIs35Char(List<DataParser> records)
        {
            var res = from item in records
                      where item.Web.Length > 35
                      select item;
            List<DataParser> dataParse = res.ToList();
            Console.WriteLine("Count {0} ", dataParse.Count);
            foreach (DataParser item in res.ToList())
            {
                dataParserList.Add(item);
            }
            return dataParserList;
        }

        public List<DataParser> WhoLivesInPostCodeArea(List<DataParser> records)
        {

            string pattern = "^[A-Za-z]{2}\\d{1}\\s";

            foreach (var item in records)
            {
                if (Regex.IsMatch(item.Postal, pattern, RegexOptions.IgnoreCase))
                {
                    count++;
                    dataParserList.Add(item);

//                    Console.WriteLine("{0} - {1} - {2} ", item.Pos, item.FirstName + item.LastName, item.CompanyName);
                }
            }
            Console.WriteLine("Count : {0} ", count);
            return dataParserList;
        }

        public List<DataParser> WhoseFirstPhoneNumberIsLargerThanSecondPhoneNumber(List<DataParser> records)
        {
            foreach (var item in records)
            {
                string numericPhone1 = new String(item.Phone1.Where(Char.IsDigit).ToArray());
                string numericPhone2 = new String(item.Phone2.Where(Char.IsDigit).ToArray());
                int phone1 = Int32.Parse(numericPhone1);
                int phone2 = Int32.Parse(numericPhone2);
                if (phone1 > phone2)
                {
                    dataParserList.Add(item);
                    count++;
                }
            }
            Console.WriteLine("Count : {0} ", count);
            return dataParserList;
        }
    }
}
