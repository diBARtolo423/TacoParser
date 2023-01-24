using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.435038,-86.081123,Taco Bell Talladeg...", -86.081123)]
        [InlineData("34.742044,-87.667791,Taco Bell Muscle Shoal...", -87.667791)]
        [InlineData("32.326279,-86.325015,Taco Bell Montgomery...", -86.325015)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            var longParser = new TacoParser();
            var actual = longParser.Parse(line);
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.435038,-86.081123,Taco Bell Talladeg...", 33.435038)]
        [InlineData("34.742044,-87.667791,Taco Bell Muscle Shoal...", 34.742044)]
        [InlineData("32.326279,-86.325015,Taco Bell Montgomery...", 32.326279)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            var latParser = new TacoParser();
            var actual = latParser.Parse(line);
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
