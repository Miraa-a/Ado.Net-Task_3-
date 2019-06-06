using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface Award_Interface
    {
        IEnumerable<Award> GetAll();

        void Add(Award value);

        void GetAllUserAndAwards(int ID, int ID_Award);

        IEnumerable<Award> GetUserAwards(int ID);
    }
}
