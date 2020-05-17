using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestClientApp.DigitalSignatureServRef;

namespace TestClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DigitalSignatureServRef.DigitalSignatureServiceSoapClient soapClient = new DigitalSignatureServRef.DigitalSignatureServiceSoapClient();
            string text = "some test text";
            Task<SignitureResponse> res = soapClient.SignitureAsync("user123", text);
            string finRes = res.Result.Body.SignitureResult;
            Console.WriteLine(finRes);
        }
    }
}
