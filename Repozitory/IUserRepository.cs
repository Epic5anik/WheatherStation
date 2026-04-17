using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repozitory
{
    public interface IUserRepository
    {
        User? GetUser(int id);
    }
}
