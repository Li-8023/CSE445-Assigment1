using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int wordCount(string str);

        [OperationContract]
        stringStatistics analyzerStr(string str);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class stringStatistics
    {
        int uppercase_count, lowercase_count, digit_count, vowel_count = 0;

        [DataMember]
        public int Uppercase
        {
            get { return uppercase_count; }
            set { uppercase_count = value; }
        }

        [DataMember]
        public int Lowercase
        {
            get { return lowercase_count; }
            set { lowercase_count = value; }
        }

        [DataMember]
        public int Digit
        {
            get { return digit_count; }
            set { digit_count = value; }
        }

        [DataMember]
        public int Vowel
        {
            get { return vowel_count; }
            set
            { vowel_count = value; }
        }
    }
}
