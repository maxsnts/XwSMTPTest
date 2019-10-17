using System.Runtime.Serialization;

namespace XwSMTPTest
{
    [DataContract]
    public class Test
    {
        [DataMember]
        public string SaveAs = "";
        [DataMember]
        public string Library = "";
        [DataMember]
        public string From = "";
        [DataMember]
        public string ReplyTo = "";
        [DataMember]
        public string To = "";
        [DataMember]
        public string Sender = "";
        [DataMember]
        public string CC = "";
        [DataMember]
        public string BCC = "";
        [DataMember]
        public string Subject = "";
        [DataMember]
        public string Body = "";
        [DataMember]
        public string SMTPHost = "";
        [DataMember]
        public string SMTPPort = "";
        [DataMember]
        public string SMTPUser = "";
        [DataMember]
        public string SMTPPassword = "";
        [DataMember]
        public string SMTPSecurity = "";

        public override string ToString()
        {
            return SaveAs;
        }
    }
}
