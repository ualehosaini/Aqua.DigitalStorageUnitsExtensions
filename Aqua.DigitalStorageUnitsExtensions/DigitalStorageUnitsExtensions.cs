namespace Aqua.DigitalStorageUnitsExtensions
{
    public static class DigitalStorageUnitsExtensions
    {
        private const decimal KiloByte = 1024;

        /// <summary>
        /// Converts Byte to KiloByte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ByteToKiloByte(this decimal input)
        {
            return input / KiloByte;
        }

        /// <summary>
        /// Converts KiloByte to Byte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal KiloByteToByte(this decimal input)
        {
            return input * KiloByte;
        }

    }
}
