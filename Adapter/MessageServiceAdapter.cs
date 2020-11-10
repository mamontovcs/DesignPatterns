using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class MessageServiceAdapter : IMessageServiceAdapter
    {
        private readonly MessageService _messageService;

        public MessageServiceAdapter(MessageService messageService)
        {
            _messageService = messageService;
        }

        public string Publish(string message)
        {
            var json = _messageService.ConvertMesageToJson(message);

            return json.ToString();
        }
    }
}
