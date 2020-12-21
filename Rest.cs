using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace DrHelperFront
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    class Rest
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string content { get; set; }

        public Rest()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
            content = string.Empty;
        }

        public string makeRequest()
        {
            string strResponse = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();
            request.ContentLength = Encoding.ASCII.GetBytes(content).Length;
            request.ContentType = "application/json";
            
            if (!string.IsNullOrEmpty(content))
            {
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(content);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(request.Method == "GET" && response.StatusCode!= HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());
                }
                else if (request.Method == "POST" && response.StatusCode!= HttpStatusCode.Created && response.StatusCode!=HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());
                }

                using (Stream responseStream = response.GetResponseStream())
                {
                    if(responseStream!=null)
                    {
                        using(StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponse = reader.ReadToEnd();
                        }
                    }
                }

            }

            return strResponse;
        }
    }
}
