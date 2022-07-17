// See https://aka.ms/new-console-template for more information

using MockCsvParser.Models;

ReadCsv readCsv = new ReadCsv();

List<DataParser> dataParserList = readCsv.ReadingCsvFile();

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

//List<DataParser> dataParserList;

Queries query = new Queries();

switch (option)
{
    case 1:
        dataParserList = query.WhoHasEsqInCompany(dataParserList);
        break;
    case 2:
        dataParserList = query.WhoLivesInDerby(dataParserList);
        break;
    case 3:
        dataParserList = query.WhoseHouseNumberIsThreeDigits(dataParserList);
        break;
    case 4:
        dataParserList = query.WhoseWebsiteIs35Char(dataParserList);
        break;
    case 5:
        dataParserList = query.WhoLivesInPostCodeArea(dataParserList);
        break;
    case 6:
        dataParserList = query.WhoseFirstPhoneNumberIsLargerThanSecondPhoneNumber(dataParserList);
        break;
    default:
        break;
}

foreach(DataParser item in dataParserList)
{
    Console.WriteLine("{0} - {1} - {2} ", item.Pos, item.FirstName + item.LastName, item.CompanyName);
}


