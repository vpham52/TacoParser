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
        [InlineData("31.447495,-85.657311,Taco Bell Ozar...", -85.657311)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", -85.291147)]
        [InlineData("33.594359,-86.122022,Taco Bell Lincoln...", -86.122022)]
        [InlineData("34.944183,-85.22637,Taco Bell Fort Oglethorp...", -85.22637)]
        [InlineData("34.113051,-84.56005,Taco Bell Woodstoc...", -84.56005)]

        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line);

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("31.447495,-85.657311,Taco Bell Ozar...", 31.447495)]
        [InlineData("34.996237,-85.291147,Taco Bell Chattanooga...", 34.996237)]
        [InlineData("33.594359,-86.122022,Taco Bell Lincoln...", 33.594359)]
        [InlineData("34.944183,-85.22637,Taco Bell Fort Oglethorp...", 34.944183)]
        [InlineData("34.113051,-84.56005,Taco Bell Woodstoc...", 34.113051)]

        public void ShouldParseLatitudee(string line, double expected)
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Latitude;

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
