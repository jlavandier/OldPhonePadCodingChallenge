using C__Coding_Challenge___Old_Pad_Phone.Services;
using Xunit;
namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("44 33 555 555 666 0 9 666 777 555 3#", "HELLO WORLD")]
        [InlineData("444 777 666 66 0 7777 666 333 8 9 2 777 33#", "IRON SOFTWARE")]
        [InlineData("8 33 7777 8 444 66 4#", "TESTING")]
        [InlineData("8 88 888 8888#", "TUVT")]
        public void OldPhonePad_ShouldReturnExpectedOutput(string input, string expected)
        {
            // Act
            var result = PhonePadController.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}