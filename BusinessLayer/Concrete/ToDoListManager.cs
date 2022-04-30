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
    public class ToDoListManager : IGenericService<ToDoList>
    {
        IToDoListDAL _toDoListDAL;

        public ToDoListManager(IToDoListDAL toDoList)
        {
                _toDoListDAL= toDoList;
        }

        public ToDoList GetByID(int id)
        {
            return _toDoListDAL.GetByID(id);
        }

        public void TAdd(ToDoList t)
        {
            _toDoListDAL.Insert(t);
        }

        public void TDelete(ToDoList t)
        {
            _toDoListDAL.Delete(t);
        }

        public List<ToDoList> TGetList()
        {
            return _toDoListDAL.GetList();
        }

        public void TUpdate(ToDoList t)
        {
            _toDoListDAL.Update(t);
        }
    }
}
