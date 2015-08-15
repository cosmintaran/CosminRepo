using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resources.Interfaces
{
    interface IEncryptor
    {
        string Encrypt(string text);
        string Decrypt(string text);
    }
}
