namespace Stratsys.Models
{
    public class CrossCountrySkiLength
    {
        public CrossCountrySkiLength(int fromLength, int toLength)
        {
            FromLength = fromLength;
            ToLength = toLength;
        }

        public int FromLength { get; set; }
        public int ToLength { get; set; }
    }
}
