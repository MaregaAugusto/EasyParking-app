using System;
using System.Collections.Generic;
using System.Text;

namespace EasyParking.Interfaces
{
    public interface IMessage
    {
        void Longtime(string message);
        void Shorttime(string message);
    }
}
