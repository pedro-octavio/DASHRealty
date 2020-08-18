using System;
using System.ComponentModel.DataAnnotations;

namespace DASHRealty.Domain.Entities
{
    public class Property
    {
        public Guid Id { get; set; }
        [MaxLength(150)]
        public string Description{ get; set; }
        [MaxLength(80)]
        [MinLength(10)]
        public string Location{ get; set; }
        public double Rent { get; set; }
        public bool IsActive{ get; set; }
    }
}
