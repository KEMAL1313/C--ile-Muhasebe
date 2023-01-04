using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderProjesi
{
    internal class GiderProccess : ICrud<Gider>
    {
        public bool Add(Gider obj)
        {
            Gider gider = obj;
            if (gider != null)
            {
                DbContext.GiderList.Add(gider);
                return true;
            }
            else return false;
        }

        

        public bool Delete(int id)
        {
            bool IsDelete = false;
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == id)
                {
                    DbContext.GiderList.Remove(gider);
                    IsDelete = true;
                    break;

                }
            }
            return IsDelete;
        }

        public Gider Detail(int id)
        {
            Gider giderDetail = new Gider();
            foreach (var gider in DbContext.GiderList.ToList())
            {
                if (gider.Id == id)
                {
                    giderDetail = gider;
                    break;

                }
            }
            return giderDetail;
        }

        public List<Gider> List()
        {
            List<Gider> giders = DbContext.GiderList;
            return giders;
        }
    }
}
