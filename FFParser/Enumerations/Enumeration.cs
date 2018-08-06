using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFParser.Enumerations
{
    public class Enumeration : IEnumeration
    {
        public string GetGoogleBooksApiUrl => @"https://www.googleapis.com/books/v1/volumes/?q=";
    }
}