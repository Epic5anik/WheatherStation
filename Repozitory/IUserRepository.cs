using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    internal interface IUserRepository
    {
        User? GetUser(int id);
    }
}
