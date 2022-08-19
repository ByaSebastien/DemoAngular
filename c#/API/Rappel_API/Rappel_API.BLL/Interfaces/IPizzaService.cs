using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IPizzaService
    {
        IEnumerable<Pizza> GetAll();

        Pizza GetById(int id);

        Pizza Insert(Pizza pizza);

        bool Delete(int id);   
    }
}
