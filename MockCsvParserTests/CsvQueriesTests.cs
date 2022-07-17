using MockCsvParser.Models;
using NUnit.Framework;
using FluentAssertions;
using System.Collections.Generic;

namespace MockCsvParserTests
{
    public class Tests
    {
        List<DataParser> data_0 = new List<DataParser>();
        List<DataParser> data_1 = new List<DataParser>();
        List<DataParser> data_2 = new List<DataParser>();
        DataParser dataPar = new DataParser();
        Queries Query = new Queries();

        [SetUp]
        public void Setup()
        {
                dataPar.FirstName = "Yuette";
                dataPar.LastName = "Klapec";
                dataPar.CompanyName = "Max Video";
                dataPar.Address = "45 Bradfield St #166";
                dataPar.City = "Parwich";
                dataPar.County = "Derbyshire";
                dataPar.Postal = "DE6 1QN";
                dataPar.Phone1 = "01903-649460";
                dataPar.Phone2 = "01933-512513";
                dataPar.Email = "yuette.klapec@klapec.co.uk";
                dataPar.Web = "http://www.maxvideo.co.uk";
                data_0.Add(dataPar);

                dataPar.FirstName = "Rueben";
                dataPar.LastName = "Gastellum";
                dataPar.CompanyName = "Industrial Engineering Assocs";
                dataPar.Address = "4 Forrest St";
                dataPar.City = "Weston-Super-Mare";
                dataPar.County = "North Somerset";
                dataPar.Postal = "BS23 3HG";
                dataPar.Phone1 = "01976-755279";
                dataPar.Phone2 = "01956-535511";
                dataPar.Email = "rueben_gastellum@gastellum.co.uk";
                dataPar.Web = "http://www.industrialengineeringassocs.co.uk";
                data_1.Add(dataPar);

                dataPar.FirstName = "Edgar";
                dataPar.LastName = "Kanne";
                dataPar.CompanyName = "Crowan, Kenneth W Esq";
                dataPar.Address = "99 Guthrie St";
                dataPar.City = "New Milton";
                dataPar.County = "Hampshire";
                dataPar.Postal = "BH25 5DF";
                dataPar.Phone1 = "01326-532337";
                dataPar.Phone2 = "01666-638176";
                dataPar.Email = "edgar.kanne@yahoo.com";
                dataPar.Web = "http://www.crowankennethwesq.co.uk";
                data_2.Add(dataPar);
        }

        [Test]
        public void WhoHasEsqInCompany_Should_Return_CorrectResult()
        {
            var expectedResult = new List<DataParser>()
            {
                 new DataParser
                 {
                    FirstName = "Edgar",
                    LastName = "Kanne",
                    CompanyName = "Crowan, Kenneth W Esq",
                    Address = "99 Guthrie St",
                    City = "New Milton",
                    County = "Hampshire",
                    Postal = "BH25 5DF",
                    Phone1 = "01326-532337",
                    Phone2 = "01666-638176",
                    Email = "edgar.kanne@yahoo.com",
                    Web = "http://www.crowankennethwesq.co.uk",
                 }
            };


            var result = Query.WhoHasEsqInCompany(data_0);
            result.Should().BeEquivalentTo(expectedResult);
        }
        
    }
}