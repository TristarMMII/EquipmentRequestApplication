using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EquipmentRequestApplication.Models
{
    public class RequestRepository
    {
        //request id
        public static int ID;

        // list of requests
        private static List<EquipmentRequestModel> _requests = new List<EquipmentRequestModel>();

        //add requests to list
        public static void AddResponse(EquipmentRequestModel request)
        {

            _requests.Add(request);

        }

        //return all available requests
        public static IEnumerable<EquipmentRequestModel> GetComingRequests()
        {
            return _requests.Where(x => x.ID > 0);
        }
    }
}