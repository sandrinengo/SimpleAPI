using System;
using Xunit;
using SimpleAPI.Controllers;
using Moq;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace SimpleAPI.Test
{
    public class WeatherForecastTest
    {
        private readonly WeatherForecast _model;
        private readonly Mock<ILogger<WeatherForecastController>> _ilogger = new Mock<ILogger<WeatherForecastController>>();
        WeatherForecastController controller;

        public WeatherForecastTest()
        {
            controller = new WeatherForecastController(_ilogger.Object);
        }

        [Fact]
        public void WeatherTest()
        {

        }

        [Fact]
        public async Task GetBySummary_ShouldReturnWeatherDetails_WhenSummaryExist()
        {
            //Arrange
            //Act
            var returnValue = await Task.FromResult(controller.GetBySummary("Warm"));
            //Assert
            Assert.Equal("Warm", returnValue.Result.Summary);
        }
    }
}
