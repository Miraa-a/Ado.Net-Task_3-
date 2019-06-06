using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class Award_Logic
    {
        private Award_DAO awardDao = new Award_DAO();

        public void Add(Award value)
        {
            awardDao.Add(value);

        }
        public void AddUserAward(int ID_User,int ID_Award)
        {
            awardDao.AddUserAward(ID_User, ID_Award);
        }

        public IEnumerable<Award> GetAll()
        {
            return awardDao.GetAll();
        }


        public IEnumerable<Award> GetAllUserAndAwards(int ID)
        {
            return awardDao.GetAllUserAndAward(ID);
        }

    }
}
