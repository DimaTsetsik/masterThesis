using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using FFParser.Services.Abstractions;

namespace FFParser.Services
{
    public class WebClientHelper : IWebClientHelper
    {
        public async Task<T> GetWebReuestAsync<T>(string url)
        {
            return await Task.Run(() => GetWebReuest<T>(url));
        }

        public T GetWebReuest<T>(string url) 
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding= Encoding.UTF8;

                var json = wc.DownloadString(url);
                JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
                var webEntity = javaScriptSerializer.Deserialize<T>(json);

                return webEntity;
            }
        }
    }
}