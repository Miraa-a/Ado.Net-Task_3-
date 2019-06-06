using BL.Interface;
using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class User_Logic: User_Interface
    {
        private User_DAO userDao = new User_DAO();
        public void Add(User<int> value)
        {
            userDao.Add(value);
        }

        public IEnumerable<User<string>> GetAll()
        {
            return userDao.GetAll();
        }

        public void Remove(int ID)
        {
            userDao.RemoveUser(ID);
        }
    }
}
