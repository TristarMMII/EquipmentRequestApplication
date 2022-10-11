using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EquipmentRequestApplication.Models
{
    // this class allows the extraction of description attributes from enums
    public static class EnumDescription
    {
        public static string GetDescription(this Object e)
        {
            var descriptionAttr = e.GetType().GetMember(e.ToString())[0].GetCustomAttributes(typeof(DescriptionAttribute), inherit: false)[0] as DescriptionAttribute;

            return descriptionAttr.Description;
        }
    }
}
