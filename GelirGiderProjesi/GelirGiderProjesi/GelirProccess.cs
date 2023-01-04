using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderProjesi
{
    internal class GelirProccess : ICrud<Gelir> 
    {
        public bool Add(Gelir obj)
        {
            Gelir gelir = obj;
            if (gelir != null)
            {
                DbContext.GelirList.Add(gelir);
                return true;
            }
            else return false;
        }

        public bool Delete(int id)
        {
            bool IsDelete = false;
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == id)
                {
                    DbContext.GelirList.Remove(gelir);
                    IsDelete = true;
                    break;

                }
            }
            return IsDelete;
        }

        public Gelir Detail(int id)
        {
            Gelir gelirDetail = new Gelir();
            foreach (var gelir in DbContext.GelirList.ToList())
            {
                if (gelir.Id == id)
                {
                    gelirDetail = gelir;
                    break;

                }
            }
            return gelirDetail;
        }

        public List<Gelir> List()
        {
            List<Gelir> gelirs = DbContext.GelirList;
            return gelirs;
        }
    }
}
