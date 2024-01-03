using BusinessLayer.Abstract;
using DateAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal) ///Yapıcı metot ve bu yapı dependency intection olarak geçiyor 
        {
            _aboutDal = aboutDal;
        }
        public void Tadd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public List<About> TGetlist()
        {
          return  _aboutDal.Getlist();
        }

        public About TGetTByID(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
