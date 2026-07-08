using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorldRank.Console.Exceptions
{
    public class WalletException : Exception
    {
        public WalletException() { 
        
            public WalletException(string message) : base message {
        }
            public WalletException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
