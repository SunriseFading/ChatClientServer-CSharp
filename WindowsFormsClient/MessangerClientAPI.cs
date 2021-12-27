using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    class MessangerClientAPI
    {
        private static readonly HttpClient client = new HttpClient();

        public void TestNewtonsoftJson()
        {
            Message msg = new Message("V", "Hey", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
        }

        public async Task<Message> GetMessageHTTPAsync(int MessageId)
        {
            var responseString = await client.GetStringAsync("http://localhost:5000/api/Messanger/" + MessageId.ToString());
            if (responseString != null)
            {
                Message deserializedMsg = JsonConvert.DeserializeObject<Message>(responseString);
                return deserializedMsg;
            }
            return null;
        }

        public bool SendMessage(Message msg)
        {
            WebRequest request = WebRequest.Create("http://localhost:5000/api/Messanger");
            request.Method = "POST";
            //Message msg = new Message("RusAl", "Privet1100", DateTime.Now);
            string postData = JsonConvert.SerializeObject(msg);
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/json";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            WebResponse response = request.GetResponse();
            //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            //Console.WriteLine(responseFromServer);
            reader.Close();
            dataStream.Close();
            response.Close();
            return true;
        }
    }
}
