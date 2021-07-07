using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LCU.State.API.Devices.ConfigManager.Models
{
    [DataContract]
    public class DevicesConfigManagerState
    {
        [DataMember]
        public virtual bool DevicesConfigured { get; set; }

        [DataMember]
        public virtual bool Loading { get; set; }
    }
}