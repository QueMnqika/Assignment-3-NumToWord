using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_NumToWord
{
    public class NumToWord
    {
        public string[] unitsArray = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public string[] tensArray = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        public string NumberConverter(int userNumber)
        {
            string results = string.Empty;
            if (userNumber == 0)
            {
                return "Zero";
            }
            else
            {
                results += ConvertToThousands(userNumber);
                results += $" {ConvertToHundreds(userNumber)} ";
                results += $"& {ConvertToTensAndUnits(userNumber)}";
                return results;
            }
        }
        public string ConvertToThousands(int userNumber)
        {
            if (userNumber >= 1000)
            {
                int firstDigit = userNumber / 1000;
                
                return $"{unitsArray[firstDigit - 1]} Thousand";
            }
            return string.Empty;
        }
        public string ConvertToHundreds(int userNumber)
        {
            if (userNumber > 100)
            {
                int secondDigit = (userNumber % 1000) / 100;
                if (secondDigit == 0)
                {
                    return string.Empty;
                }
                return $"{unitsArray[secondDigit - 1]} Hundred";
            }
            return string.Empty;
        }

        public string ConvertToTensAndUnits(int userNumber)
        {
            string results = string.Empty;
            int tensAndUnits = userNumber % 100;
            if (tensAndUnits == 0)
            {
                return $"{results}";
            } else if (tensAndUnits < 20)
            {
                return $"{unitsArray[tensAndUnits - 1]}";
            }
            else
            {
                int tens = tensAndUnits / 10;
                int units = tensAndUnits % 10;
                string otherTensAndUnits = tensArray[tens - 2];

                if (units > 0)
                {
                    otherTensAndUnits += $" {unitsArray[units - 1]}";
                }
                results += otherTensAndUnits ;
                return results ;
            }

        }
    }
}
