using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserMessageManager:IUserMessageService
    {
        IUserMessageDAL _userMessageDAL;
        public UserMessageManager(IUserMessageDAL userMessageDAL)
        {
            _userMessageDAL = userMessageDAL;
        }

        public UserMessage GetByID(int id)
        {
            return _userMessageDAL.GetByID(id);
        }

        public List<UserMessage> GetUserMessageWithUserService()
        {
           return _userMessageDAL.GetUserMessagesWithUser();
        }

        public void TAdd(UserMessage t)
        {
            _userMessageDAL.Insert(t);
        }

        public void TDelete(UserMessage t)
        {
            _userMessageDAL.Delete(t);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDAL.GetList();
        }

        public void TUpdate(UserMessage t)
        {
            _userMessageDAL.Update(t);
        }
    }
}
