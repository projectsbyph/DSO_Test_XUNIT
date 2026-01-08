using Xunit;
namespace DSO25_TEST_INTRO_XUNIT
{
    public class CalculatorTest
    {

        [Fact]
        public void TestAdd()
        {
            //given
            Calculator calculator = new Calculator(); // Skapar en instans av Calculator-klassen
            int a = 5;
            int b = 3;
            int expected = 8;

            //when
            int result = calculator.Add(a, b); // Anropar Add-metoden med värdena a och b

            //then
            Assert.Equal(expected, result); // Denna rad kontrollerar att resultatet är som förväntat
        }
    }
}
