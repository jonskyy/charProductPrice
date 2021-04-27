using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp_OData
{
    public class HttpRequest
    {

        public JArray loadData()
        {
            string addressUrl = "https://services.odata.org/V3/OData/OData.svc/Products?$top=9&$orderby=Price&$format=json";
            string webAddress = String.Format(addressUrl);
            WebRequest requestObjGet = WebRequest.Create(webAddress);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string content = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                content = sr.ReadToEnd();
                sr.Close();
            }

            var getData = JsonConvert.DeserializeObject<OData>(content);  // take only needed values
            JArray jsonArray = JArray.Parse(JsonConvert.SerializeObject(getData.Value));

            return jsonArray;
        }
    }
}
