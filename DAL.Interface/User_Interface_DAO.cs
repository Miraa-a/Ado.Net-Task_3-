using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface User_Interface_DAO
    {
        IEnumerable<User<string>> GetAll();

        void Add(User<int> value);

        void RemoveUser(int ID);

    }
}
