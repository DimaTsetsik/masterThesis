using System.Net;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using FFParserlibrary.Services.Abstractions;

namespace FFParserlibrary.Services
{
    public class WebClientHelper : IWebClientHelper
    {
        public async Task<T> GetWebRequest<T>(string url)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                JavaScriptSerializer oJS = new JavaScriptSerializer();
                var imdbEntity = oJS.Deserialize<T>(json);

                return imdbEntity;
            }
        }
    }
}
