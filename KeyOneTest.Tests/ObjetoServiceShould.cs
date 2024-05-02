using KeyOneTest.Models;
using KeyOneTest.Services;

namespace KeyOneTest.Tests
{
    public class ObjetoServiceShould
    {
        [Fact]
        public void ValidateResponse_NotEmpty()
        {
            //Arrange
            var objetoService = new ObjetoService();

            //Act
            List<ResponseObject> responseObjects = objetoService.ProcessData();

            //Assert
            Assert.True(responseObjects.Count != 0);
        }

        [Fact]
        public void ValidateResponse_Have3Items()
        {
            //Arrange
            var objetoService = new ObjetoService();

            //Act
            List<ResponseObject> responseObjects = objetoService.ProcessData();

            //Assert
            Assert.True(responseObjects.Count == 3);
        }

        [Fact]
        public void Validate_SortedList()
        {
            //Arrange
            var objetoService = new ObjetoService();

            //Act
            List<ResponseObject> responseObjects = objetoService.ProcessData();

            //Assert
            Assert.True(responseObjects[0].Category.Equals("C"));
            Assert.True(responseObjects[1].Category.Equals("B"));
            Assert.True(responseObjects[2].Category.Equals("A"));
        }

        [Fact]
        public void Validate_SumValues()
        {
            //Arrange
            var objetoService = new ObjetoService();

            //Act
            List<ResponseObject> responseObjects = objetoService.ProcessData();

            //Assert
            Assert.True(responseObjects[0].ValueSum == 720);
            Assert.True(responseObjects[1].ValueSum == 430);
            Assert.True(responseObjects[2].ValueSum == 420);
        }

        [Fact]
        public void Validate_AvgValues()
        {
            //Arrange
            var objetoService = new ObjetoService();

            //Act
            List<ResponseObject> responseObjects = objetoService.ProcessData();

            //Assert
            Assert.True(responseObjects[0].ValueAvg == 144);
            Assert.True(responseObjects[1].ValueAvg == 86);
            Assert.True(responseObjects[2].ValueAvg == 84);
        }

        [Fact]
        public void Validate_LastDate()
        {
            //Arrange
            var objetoService = new ObjetoService();

            //Act
            List<ResponseObject> responseObjects = objetoService.ProcessData();

            //Assert
            Assert.True(responseObjects[0].LastDate.Equals("2024-04-22"));
            Assert.True(responseObjects[1].LastDate.Equals("2024-04-26"));
            Assert.True(responseObjects[2].LastDate.Equals("2024-04-30"));
        }

    }
}
