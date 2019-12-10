namespace Aqua.DigitalStorageUnitsExtensions
{
    public static class DigitalStorageUnitsExtensions
    {
        private const decimal KiloByte = 1024;
        private const decimal Megabyte = 1048576;
        private const decimal GigaByte = 1073741824;

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

        /// <summary>
        /// Converts Byte to MegaByte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ByteToMegaByte(this decimal input)
        {
            return input / Megabyte;
        }

        /// <summary>
        /// Converts MegaByte to Byte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal MegaByteToByte(this decimal input)
        {
            return input * Megabyte;
        }

        /// <summary>
        /// Converts Byte to GigaByte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ByteToGigaByte(this decimal input)
        {
            return input / GigaByte;
        }

        /// <summary>
        /// Converts GigaByte to Byte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal GigaByteToByte(this decimal input)
        {
            return input * GigaByte;
        }
    }
}
