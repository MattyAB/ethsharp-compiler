﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EthSharp.ContractDevelopment
{
    public class Message
    {
        public Address Sender { get; set; }
        public UInt256 Value { get; set; }
    }
}
