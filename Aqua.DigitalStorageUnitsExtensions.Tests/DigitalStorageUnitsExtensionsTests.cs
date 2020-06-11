using Xunit;

namespace Aqua.DigitalStorageUnitsExtensions.Tests
{
    public class DigitalStorageUnitsExtensionsTests
    {
        [Theory]
        [InlineData(1, 1024)]
        [InlineData(10, 10240)]
        [InlineData(0.5, 512)]
        public void ByteToKiloByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.ByteToKiloByte());
        }

        [Theory]
        [InlineData(1024, 1)]
        [InlineData(10240, 10)]
        [InlineData(512, 0.5)]
        public void KiloBytetoBytes_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.KiloByteToByte());
        }
    }
}
