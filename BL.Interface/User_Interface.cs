using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface User_Interface
    {
        IEnumerable<User<string>> GetAll();

        void Add(User<int> value);

        void Remove(int ID);
    }
}
