﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BridgePattern
{
    // UML diyagramındaki RefinedAbstraction kısmına denk gelmektedir.
    // Abstraction (Message) sınıfından türer.
    public class EmailMessage : Message
    {
        public EmailMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        public override void Send()
        {
            messageSender.SendMessage(this);
            messageSender.SendMessage(this);
        }
    }
}
