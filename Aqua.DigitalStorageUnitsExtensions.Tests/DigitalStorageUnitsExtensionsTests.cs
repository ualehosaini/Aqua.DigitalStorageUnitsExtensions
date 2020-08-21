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

        [Theory]
        [InlineData(1, 1048576)]
        [InlineData(10, 10485760)]
        [InlineData(0.5, 524288)]
        public void ByteToMegaByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.ByteToMegaByte());
        }

        [Theory]
        [InlineData(1048576, 1)]
        [InlineData(10485760, 10)]
        [InlineData(524288, 0.5)]
        public void MegaByteToByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.MegaByteToByte());
        }

        [Theory]
        [InlineData(1, 1073741824)]
        [InlineData(10, 10737418240)]
        [InlineData(0.5, 536870912)]
        public void ByteToGigaByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.ByteToGigaByte());
        }

        [Theory]
        [InlineData(1073741824, 1)]
        [InlineData(10737418240, 10)]
        [InlineData(536870912, 0.5)]
        public void GigaByteToByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.GigaByteToByte());
        }

        [Theory]
        [InlineData(1, 1099511627776)]
        [InlineData(10, 10995116277760)]
        [InlineData(0.5, 549755813888)]
        public void ByteToTeraByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.ByteToTeraByte());
        }

        [Theory]
        [InlineData(1099511627776, 1)]
        [InlineData(10995116277760, 10)]
        [InlineData(549755813888, 0.5)]
        public void TeraByteToByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.TeraByteToByte());
        }

        [Theory]
        [InlineData(1, 1024)]
        [InlineData(10, 10240)]
        [InlineData(0.5, 512)]
        public void KiloByteToMegaByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.KiloByteToMegaByte());
        }


        [Theory]
        [InlineData(1024, 1)]
        [InlineData(10240, 10)]
        [InlineData(512, 0.5)]
        public void MegaByteToKiloByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.MegaByteToKiloByte());
        }

        [Theory]
        [InlineData(1, 1048576)]
        [InlineData(10, 10485760)]
        [InlineData(0.5, 524288)]
        public void KiloByteToGigaByte_Valid(decimal expected, decimal input)
        {
            Assert.Equal(expected, input.KiloByteToGigaByte());
        }
    }
}
