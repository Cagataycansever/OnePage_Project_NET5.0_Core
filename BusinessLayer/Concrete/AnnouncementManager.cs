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
    public class AnnouncementManager : IGenericService<Announcement>
    {
        IAnnouncementDAL _announcementDAL;

        public AnnouncementManager(IAnnouncementDAL announcementDAL)
        {
            _announcementDAL = announcementDAL;
        }

        public Announcement GetByID(int id)
        {
            return _announcementDAL.GetByID(id);
        }

        public void TAdd(Announcement t)
        {
            _announcementDAL.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _announcementDAL.Delete(t);
        }

        public List<Announcement> TGetList()
        {
            return _announcementDAL.GetList();
        }

        public void TUpdate(Announcement t)
        {
            _announcementDAL.Update(t);
        }
    }
}
