using Stratsys.Enums;
using Stratsys.Models;

namespace Stratsys.Services
{
    public class CrossCountrySkiService
    {
        const int youngChildAdditionFrom = 10;
        const int youngChildAdditionTo = 20;

        const int maxLengthClassic = 207;
        const int normalAdditionClassic = 20;

        const int maxLengthFreestyle = 192;
        const int normalAdditionFreestyleFrom = 10;
        const int normalAdditionFreestyleTo = 15;

        public CrossCountrySkiLength CalculateSkiLength(int length, int age, CrossCountrySkiStyle skiStyle)
        {
            if (age <= 4)
            {
                return new CrossCountrySkiLength(length, length);
            }
            else if (age > 4 && age <= 8)
            {
                var fromLength = length + youngChildAdditionFrom;
                var toLength = length + youngChildAdditionTo;
                   
                return new CrossCountrySkiLength(fromLength, toLength);
            }
            else
            {
                return CalculateNormalSkiLength(length, age, skiStyle);
            }
        }

        private CrossCountrySkiLength CalculateNormalSkiLength(int length, int age, CrossCountrySkiStyle skiStyle)
        {
            if (skiStyle == CrossCountrySkiStyle.Classic)
            {
                int newLength = length + normalAdditionClassic;
                if (newLength > maxLengthClassic)
                {
                    newLength = maxLengthClassic;
                }

                return new CrossCountrySkiLength(newLength, newLength);
            }
            else
            {
                int fromLength = length + normalAdditionFreestyleFrom;
                int toLength = length + normalAdditionFreestyleTo;

                if (fromLength > maxLengthFreestyle)
                {
                    fromLength = maxLengthFreestyle;
                }

                if (toLength > maxLengthFreestyle)
                {
                    toLength = maxLengthFreestyle;
                }

                return new CrossCountrySkiLength(fromLength, toLength);
            }
        }
    }
}
