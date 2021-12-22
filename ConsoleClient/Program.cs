using Newtonsoft.Json;

namespace Messanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("V", "Hey", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);
            //{ "UserName":"V","MessageText":"Hey","TimeStamp":"2021-12-22T19:21:31.6164227Z"}
            //V < 22.12.2021 19:21:31 >: Hey
        }
    }
}
