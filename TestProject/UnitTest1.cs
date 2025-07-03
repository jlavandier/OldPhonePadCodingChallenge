using C__Coding_Challenge___Old_Pad_Phone.Services;
using Xunit;
namespace TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("44 33 555 555 666 0 9 666 777 555 3#", "HELLO WORLD")]
        [InlineData("8 33 7777 8 444 66 4#", "TESTING")]
        [InlineData("8 88 888 8888#", "TUVT")]
        [InlineData("7777 0 7777 0 7777#", "S S S")]
        [InlineData("2 22 222 0 3 33 333#", "ABC DEF")]
        [InlineData("44 33 555 * 555 666#", "HELO")]
        [InlineData("6 66 666#", "MNO")]
        [InlineData("2 2 2#", "AAA")]
        [InlineData("2 22 222", "")]
        public void OldPhonePad_ShouldReturnExpectedOutput(string input, string expected)
        {
            // Act
            var result = PhonePadController.OldPhonePad(input);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}