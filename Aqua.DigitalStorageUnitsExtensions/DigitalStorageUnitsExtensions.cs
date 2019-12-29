namespace Aqua.DigitalStorageUnitsExtensions
{
    public static class DigitalStorageUnitsExtensions
    {
        private const decimal KiloByte = 1024;
        private const decimal Megabyte = 1048576;
        private const decimal GigaByte = 1073741824;
        private const decimal TeraByte = 1099511627776;

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

        /// <summary>
        /// Converts Byte to TeraByte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal ByteToTeraByte(this decimal input)
        {
            return input / TeraByte;
        }

        /// <summary>
        /// Converts TeraByte to Byte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal TeraByteToByte(this decimal input)
        {
            return input * TeraByte;
        }

        /// <summary>
        /// Converts KiloByte to MegaByte
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static decimal KiloByteToMegaByte(this decimal input)
        {
            return input / KiloByte;
        }
    }
}
