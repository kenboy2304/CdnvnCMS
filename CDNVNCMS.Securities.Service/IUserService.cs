using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDNVNCMS.Securities.Data;
using CDNVNONE.Service;

namespace CDNVNCMS.Securities.Service
{
    public interface IUserService : IEntityService<User>
    {
        User GetUser(string username);
        bool Exist(string username);
    }
}
