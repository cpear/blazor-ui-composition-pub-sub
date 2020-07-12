using System;
using BlazorComponentBus;
using MediatR;

namespace StudentComponents.Contracts.Events
{
    public class StudentAdded : IMessage, INotification
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
