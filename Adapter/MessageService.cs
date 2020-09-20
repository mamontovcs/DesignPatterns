using Newtonsoft.Json.Linq;
using System;

namespace Adapter
{
    internal class MessageService
    {
        public JArray Publish(string message)
        {
            JArray array = new JArray();
            JValue text = new JValue(message);
            JValue date = new JValue(DateTime.Now);

            array.Add(text);
            array.Add(date);

            return array;
        }
    }
}
