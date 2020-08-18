using System;

namespace DASHRealty.Application.DTOs
{
    public class PropertyDTO
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public double Rent { get; set; }
        public bool IsActive { get; set; }
    }
}
