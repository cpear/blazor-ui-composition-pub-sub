using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorComponentBus
{
    public class ComponentBus
    {
        private List<KeyValuePair<Type, EventHandler<MessageArgs>>> _componentRegistrants = 
            new List<KeyValuePair<Type, EventHandler<MessageArgs>>>();

//        private List<KeyValuePair<Type, EventHandler<MessageArgs>> _subscriberDictionary =
//            new List<KeyValuePair<Type, EventHandler<MessageArgs>>>();
        
        public void Subscribe(Type messageType, EventHandler<MessageArgs> callBack)
        {
            _componentRegistrants.Add(new KeyValuePair<Type, EventHandler<MessageArgs>>(messageType, callBack));
        }

        public async Task Publish<T>(T message)
        {
            var messageType = typeof(T);

            var args = new MessageArgs(message, messageType);

            var subscribers = _componentRegistrants.ToLookup(item => item.Key);

            foreach (var subscriber in subscribers[messageType])
            {
                await Task.Run(() => subscriber.Value.Invoke(this, args));
            }

            //Look for subscribers of this message type
            //Call the subscriber and pass the message along
        } 
    }
}