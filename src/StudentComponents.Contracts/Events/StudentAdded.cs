using System;

namespace StudentComponents.Contracts.Events
{
    public class StudentAdded
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
