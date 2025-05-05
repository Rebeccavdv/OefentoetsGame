namespace ReisApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ZichtOpZee_berekenToesslag_ReturnTrue()
        {
            //arrange: variables, classes
            float prijs = 1;
            var zichtOpZee = new ZichtOpZee();

            //act
            float resultaat = zichtOpZee.berekenToeslag(prijs);

            //assert
            Assert.Equal(1.075f, resultaat, 3); // nauwkeurig tot 3 decimalen


        }
    }
}