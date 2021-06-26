using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDied.model;

namespace WpfAppDied.Model
{
    public class LocalDataProvider : IDataProvider
    {
        public IEnumerable<Bus> GetBus()
        {
            return new Bus[]{ 
                new Bus{Type="Пассажирский", Number=1, Speed=2.5F, TimeFrom=new DateTime(2021,05,25) },
            new Bus{Type="Школьный", Number=2, Speed=3.2F,TimeFrom=new DateTime(2021,05,16)},
            new Bus{Type="Заказной",Number=3,Speed=4.1F,TimeFrom=new DateTime(2021,05,20)} };
          
         
         
        }

        
                             
    }
}
