using DateAccessLayer.Abstract;
using DateAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAccessLayer.EntityFramework
{
   public class EfFeature2Dal : GenericRepository<Feature2>, IFeature2Dal
    {
    }
}
