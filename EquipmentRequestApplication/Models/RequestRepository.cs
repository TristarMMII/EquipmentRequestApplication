using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentRequestApplication.Models
{
    public class RequestRepository
    {

        public static int ID;
        private static List<EquipmentRequestModel> _requests = new List<EquipmentRequestModel>();

        public static void AddResponse(EquipmentRequestModel request)
        {

            _requests.Add(request);

        }

        public static IEnumerable<EquipmentRequestModel> GetComingRequests()
        {
            return _requests.Where(x => x.ID > 0);
        }

    }
}