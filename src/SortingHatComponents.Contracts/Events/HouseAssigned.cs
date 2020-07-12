using System;

namespace SortingHatComponents.Contracts.Events
{
    public class HouseAssigned
    {
        public Guid Id { get; set; }
        public string House { get; set; }
    }
}