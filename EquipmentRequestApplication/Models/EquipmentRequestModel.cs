using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentRequestApplication.Models
{
    public enum RoleType
    {
        Student,
        Professor
    }

    public enum EquipmentType
    {
        Laptop,
        Phone,
        Tablet,
        Another
    }

    public class EquipmentRequestModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Number format has to be : xxx-xxx-xxxx")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Your role is needed")]
        public RoleType RoleType { get; set; }

        [Required(ErrorMessage = "The equipment type is needed")]
        public EquipmentType EquipmentType { get; set; }

        [Required]
        public string Details { get; set; }

        [Required(ErrorMessage = "Duration is needed")]
        [Range(1, 30)]
        public int Duration { get; set; }

        public int ID { get; set; }
    }
}