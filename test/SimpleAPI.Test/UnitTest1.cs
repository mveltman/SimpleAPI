using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        WeatherForecastController controller = new WeatherForecastController();
        [Fact]
        public void GetWeather(){
            var returnvalue = controller.Get();
            Assert.Equal("Freezing", returnvalue);
        }


        [Fact]
        public void Test1()
        {

        }
    }
}
