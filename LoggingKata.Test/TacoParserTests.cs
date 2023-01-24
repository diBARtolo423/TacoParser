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
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", -86.217115)]
        [InlineData("33.887468,-84.248611,Taco Bell Doravill...", -84.248611)]
        [InlineData("34.741158,-86.662532,Taco Bell Huntsville...", -86.662532)]
        [InlineData("34.752697,-86.747007,Taco Bell Madiso...", -86.747007)]
        [InlineData("30.190097,-85.711394,Taco Bell Panama City...", -85.711394)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var longParser = new TacoParser();

            //Act
            var actual = longParser.Parse(line);

            //Assert

            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.280205,-86.217115,Taco Bell Albertvill...", 34.280205)]
        [InlineData("33.887468,-84.248611,Taco Bell Doravill...", 33.887468)]
        [InlineData("34.741158,-86.662532,Taco Bell Huntsville...", 34.741158)]
        [InlineData("34.752697,-86.747007,Taco Bell Madiso...", 34.752697)]
        [InlineData("30.190097,-85.711394,Taco Bell Panama City...", 30.190097)]
        public void ShouldParseLatitude(string line, double expected)
        {
            var latParser = new TacoParser();
            var actual = latParser.Parse(line);
            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
