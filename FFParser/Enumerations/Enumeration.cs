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

        public string GetImDbApiUrl => @"http://www.omdbapi.com/?t=";

        public string GetImDbapiToken => @"apikey=726ded0d";

        public string GetMoonwalkUrl => @"http://moonwalk.cc/api/videos.json?";

        public string [] GetMoonwalkToken => new string[] { "6eb82f15e2d7c6cbb2fdcebd05a197a2", "858facbc8b7d9061761e8540f46a2b3b", "29b413aaa453a43fb4a91d81648aca5c" };
    }
}