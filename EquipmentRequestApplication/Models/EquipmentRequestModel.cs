using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentRequestApplication.Models
{
    //Role type to show if the user is student or prof
    public enum RoleType
    {
        Student,
        Professor
    }

    //Type of equipment requesting to be taken out with descriptions
    public enum EquipmentType
    {
        [Description("Macbook Pro with i5")]
        Laptop,
        [Description("Iphone 14 Pro")]
        Phone,
        [Description("Ipad Pro")]
        Tablet,
        [Description("Other Devices")]
        Another
    }



    public class EquipmentRequestModel
    {
        //name - required
        [Required]
        public string Name { get; set; }

        //phone - required and must be in xxx-xxx-xxxx format
        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Number format has to be : xxx-xxx-xxxx")]
        public string Phone { get; set; }

        //email - required and must be a email format
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //role type - required
        [Required(ErrorMessage = "Your role is needed")]
        public RoleType RoleType { get; set; }

        //equipment type - required
        [Required(ErrorMessage = "The equipment type is needed")]
        public EquipmentType EquipmentType { get; set; }

        //details - required
        [Required]
        public string Details { get; set; }

        //duration - required, must be withing 1 - 30 days 
        [Required(ErrorMessage = "Duration is needed")]
        [Range(1, 30)]
        public int Duration { get; set; }

        public int ID { get; set; }

        public bool IsAvailable { get; set; } = true;
    }
}