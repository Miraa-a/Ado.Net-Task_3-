using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL.Interface
{
    public interface Award_Interface_DAO
    {
        IEnumerable<Award> GetAll();

        void Add(Award value);

        void AddUserAward(int ID_User, int ID_Award);

        IEnumerable<Award> GetAllUserAndAward(int ID_user);

        //IEnumerable<Award> GetUserAward();

       // Award GetByID(int ID);
    }
}
