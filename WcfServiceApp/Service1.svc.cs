using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public int wordCount(String str)
        {
            int i = 0;
            int myWorld = 1;
            while (i <= str.Length - 1)
            {
                if (str[i] == '.')
                {
                    myWorld++;
                }
                i++;
            }
            return myWorld;

        }

        //consists of Uppercase count, Lower case count,
        //Digit count, and Vowel count as data items
        public stringStatistics analyzerStr(String str)
        {
            stringStatistics statistic = new stringStatistics();

            // int statistic.Uppercase = 0;

            //statistic.Uppercase = 1;

            //count upper case number
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    statistic.Uppercase++;

                }
            }

            //count lower case number
            for (int j = 0; j < str.Length; j++)
            {
                if (char.IsLower(str[j]))
                {
                    statistic.Lowercase++;
                }
            }

            //count digit number
            for (int a = 0; a < str.Length; a++)
            {
                if (char.IsDigit(str[a]))
                {
                    statistic.Digit++;
                }
            }

            //count Vowel number
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' ||
                    str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    statistic.Vowel++;
                }
            }

            return statistic;
        }
    }
}
