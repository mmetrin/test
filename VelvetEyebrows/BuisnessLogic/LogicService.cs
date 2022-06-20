using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelvetEyebrows
{
    class LogicService
    {
        VelvetBrowsBDEntities db = new VelvetBrowsBDEntities();

        public List<Service> ServiceList;

        public void LoadServices()
        {
            this.ServiceList = db.Service.ToList();
        }

        //сортировка по стоимости
        public void SortService(int Sorting = -1)
        {
            if(Sorting == 0)
            {
                this.ServiceList = this.ServiceList.OrderBy(p => p.Cost).ToList();
            }
            else if (Sorting == 1)
            {
                this.ServiceList = this.ServiceList.OrderByDescending(p => p.Cost).ToList();
            }
        }

        //фильтрация по скидке
        public void FilterServices(int IndexValue =-1)
        {
            switch (IndexValue)
            {
                case 1:
                    this.ServiceList = this.ServiceList.Where(p => p.Discount >= 0 && p.Discount < 0.05).ToList();
                    break;
                case 2:
                    this.ServiceList = this.ServiceList.Where(p => p.Discount >= 0.05 && p.Discount < 0.15).ToList();
                    break;
                case 3:
                    this.ServiceList = this.ServiceList.Where(p => p.Discount >= 0.15 && p.Discount < 0.3).ToList();
                    break;
                case 4:
                    this.ServiceList = this.ServiceList.Where(p => p.Discount >= 0.3 && p.Discount < 0.7).ToList();
                    break;
                case 5:
                    this.ServiceList = this.ServiceList.Where(p => p.Discount >= 0.07 && p.Discount <= 1).ToList();
                    break;
            }
              
        }

        //поиск по значению
        public void SearchServices(string ValueSearch)
        {
            if (string.IsNullOrEmpty(ValueSearch)) return;

            List<Service> ListSearchResult = new List<Service>();

            foreach(var item in this.ServiceList)
            {
                if(item.Title.Contains(ValueSearch) || item.Description.Contains(ValueSearch))
                {
                    ListSearchResult.Add(item);
                }
                this.ServiceList = ListSearchResult;
            }
        }

    }
}
