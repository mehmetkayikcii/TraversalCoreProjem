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
    public class AnnoncementManager : IAnnoncementService
    {
        private readonly IAnnoncementDal _annoncementDal;

        public AnnoncementManager(IAnnoncementDal annoncementDal)
        {
            _annoncementDal = annoncementDal;
        }

        public void TAdd(Annoncement t)
        {
            _annoncementDal.Insert(t);
        }

        public void TDelete(Annoncement t)
        {
            _annoncementDal.Delete(t);
        }

        public Annoncement TGetById(int id)
        {
            return _annoncementDal.GetByID(id);
        }

        public List<Annoncement> TGetList()
        {
            return _annoncementDal.GetList();
        }

        public void TUpdate(Annoncement t)
        {
            _annoncementDal.Update(t);
        }
    }
}
