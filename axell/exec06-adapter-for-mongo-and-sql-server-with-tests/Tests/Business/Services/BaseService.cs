using System;
using System.Linq;
using NetCoreApi.Business.Interfaces;
using NetCoreApi.Business.Services;
using NetCoreApi.Database.Models;
using NetCoreApi.Database.Contexts;
using NetCoreApi.Database.Repositories;
using NUnit.Framework;

namespace Tests
{
    public class BaseService
    {
        private IBaseService<WeatherForecast> _sqlServerBaseService { get; set; }
        private IBaseService<WeatherForecast> _mongoBaseService { get; set; }

        [SetUp]
        public void Setup()
        {
            var sqlServerRepository = new BaseRepository<WeatherForecast>(new DataContext());
            _sqlServerBaseService = new BaseService<WeatherForecast>(sqlServerRepository);

            var mongoRepository = new MongoRepository<WeatherForecast>();
            _mongoBaseService = new BaseService<WeatherForecast>(mongoRepository);
        }

        [Test]
        public void TestCreate()
        {
            _sqlServerBaseService.Create(new WeatherForecast()
            {
                Date = new DateTime(),
                Summary = "Hot SQL Server",
                TemperatureC = 30
            });

            Assert.AreEqual(
                _sqlServerBaseService.Filter(
                    weatherForecast => weatherForecast.Summary == "Hot SQL Server"
                ).Any(),
                true
            );

            _mongoBaseService.Create(new WeatherForecast()
            {
                Date = new DateTime(),
                Summary = "Hot Mongo",
                TemperatureC = 30
            });

            Assert.AreEqual(
                _mongoBaseService.Filter(
                    weatherForecast => weatherForecast.Summary == "Hot Mongo"
                ).Any(),
                true
            );
        }
    }
}