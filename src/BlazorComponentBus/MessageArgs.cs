using System;

namespace BlazorComponentBus
{
    public class MessageArgs : EventArgs
    {
        private readonly Type _typeOfMessagePublished;
        private readonly object _message;

        public MessageArgs(object message, Type typeOfMessagePublished)
        {
            _typeOfMessagePublished = typeOfMessagePublished;
            _message = message;
        }

        public TypeIWant GetMessage<TypeIWant>()
        {
            return (TypeIWant)_message;
        }
    }
}