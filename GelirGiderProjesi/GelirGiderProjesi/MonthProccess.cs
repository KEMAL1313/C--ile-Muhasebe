using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelirGiderProjesi
{
    internal class MonthProccess : ICrud<Month>
    {
        public bool Add(Month obj)
        {
            Month month = obj;
            if (month != null)
            {
                DbContext.months.Add(month);
                return true;
            }
            else return false;
        }

        public bool Add(Gelir obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            bool IsDelete = false;
            foreach (var month in DbContext.months.ToList())
            {
                if (month.Id == id)
                {
                    DbContext.months.Remove(month);
                    IsDelete = true;
                    break;

                }
            }
            return IsDelete;
        }

        public Month Detail(int id)
        {
            Month monthDetail = new Month();
            foreach (var months in DbContext.months.ToList())
            {
                if (months.Id == id)
                {
                    monthDetail = months;
                    break;

                }
            }
            return monthDetail;
        }

        public List<Month> List()
        {
            List<Month> months = DbContext.months;
            return months;
        }
    }
}
