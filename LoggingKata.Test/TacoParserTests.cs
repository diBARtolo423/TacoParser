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
        [InlineData("33.568475,-84.330193,Taco Bell Morro...", -84.330193)]
        [InlineData("33.239126,-87.575333,Taco Bell Northpor...", -87.575333)]
        [InlineData("34.113051,-84.56005,Taco Bell Woodstoc...", -84.56005)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            var longParser = new TacoParser();
            var actual = longParser.Parse(line);
            Assert.Equal(expected, actual);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.568475,-84.330193,Taco Bell Morro...", 33.568475)]
        [InlineData("33.239126,-87.575333,Taco Bell Northpor...", 33.239126)]
        [InlineData("34.113051,-84.56005,Taco Bell Woodstoc...", 34.113051)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            var latParser = new TacoParser();
            var actual = latParser.Parse(line);
            Assert.Equal(expected, actual);
        }

    }
}
