// See https://aka.ms/new-console-template for more information

using MockCsvParser.Models;

ReadCsv readCsv = new ReadCsv();

List<DataParser> dataParser = readCsv.ReadingCsvFile();

Console.WriteLine("Choose an option from the menu below:");
Console.WriteLine("1) Every person who has 'Esq' in their company ");
Console.WriteLine("2) Every person who lives in 'Derbyshire' ");
Console.WriteLine("3) Every person whose house number is exactly three digits ");
Console.WriteLine("4) Every person whose website URL is longer than 35 characters ");
Console.WriteLine("5) Every person who lives in a postcode area with a single-digit value ");
Console.WriteLine("6) Every person whose first phone number is numerically larger than their second phone number ");

Console.WriteLine("7) Exit ");
Console.Write("\r\nSelect an option: ");

int option = Convert.ToInt32(Console.ReadLine());



