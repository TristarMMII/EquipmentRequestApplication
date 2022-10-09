using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentRequestApplication.Models
{
    public class RequestRepository
    {

        public static int ID;
        private static List<EquipmentRequestModel> _responses = new List<EquipmentRequestModel>();

        public static void AddResponse(EquipmentRequestModel request)
        {

            _responses.Add(request);

        }

        // public static bool IsDurationPositive(int duration)
        // {
        //     //check if duraiton is below 0
        //     if (duration > 0)
        //     {
        //         return true;
        //     }
        //     return false;
        // }
    }
}