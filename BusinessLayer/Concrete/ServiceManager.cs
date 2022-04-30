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
    public class ServiceManager : IGenericService<Service>
    {

        IServiceDAL _serviceDAL;

        public ServiceManager(IServiceDAL serviceDAL)
        {
            _serviceDAL = serviceDAL;
        }

        public Service GetByID(int id)
        {
            return _serviceDAL.GetByID(id);
        }

        public void TAdd(Service t)
        {
            _serviceDAL.Insert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDAL.Delete(t);
        }

        public List<Service> TGetList()
        {
            return _serviceDAL.GetList();
        }

        public void TUpdate(Service t)
        {
            _serviceDAL.Update(t);
        }
    }
}
