using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographGabs.Cryptograph
{
    public class Security
    {
        //Methods public 
        public static string cryptographer(string info, string key) {
           var coded = EncodedTo64(info);
           var codeWithKey = string.Concat(key, "=======" , coded);
           var coded2X = EncodedTo64(codeWithKey);
           return EncodedTo64(coded2X); ;
        }

        public static string decrypt(string info, string key) {
            try{
                var decoded = DecodedFrom64(info);
                var decoded2xInfoFull = DecodedFrom64(decoded);
                String[] separator = { "=======" };
                Int32 count = 2;
                var separatoInfo = decoded2xInfoFull.Split(separator, count, StringSplitOptions.None);

                if (separatoInfo[0].ToString() == key)
                {
                    return DecodedFrom64(separatoInfo[1].ToString());
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error:" + e.Message);
            }
            return string.Empty;
        }


        //Method private Decoded
        static private string DecodedFrom64(string encodeData)
        {
            //byte[] encodeDataAsByte = Convert.FromBase64String(encodeData);

            //string returnValue = System.Text.ASCIIEncoding.UTF8.GetString(encodeDataAsByte);
            string returnValue = Encoding.UTF8.GetString(Convert.FromBase64String(encodeData));
            return returnValue;
        }

        //Method private Encoded
        static private string EncodedTo64(string valueEncoded) {
            byte[] valueAsByte = System.Text.ASCIIEncoding.UTF8.GetBytes(valueEncoded);

            string returnValue = System.Convert.ToBase64String(valueAsByte);

            return returnValue;
        }
    }
}
