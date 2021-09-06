using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDeviceManager.Models
{

    public class IOTDevice
    {
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
      
        public string ConnectionState { get; set; }
        public string Status { get; set; }
          public string JsonData { get; set; }
       public DateTime JsonDataLastUpdated { get; set; }
        public bool AllowSending { get; set; }

    }

   

}
