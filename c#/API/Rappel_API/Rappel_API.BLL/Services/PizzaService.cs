using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PizzaService : IPizzaService
    {
        private const decimal _REDUC_PRICE = 7.95m;

        private IPizzaRepository _Repository;

        public PizzaService(PizzaRepository pizzaRepository)
        {
            _Repository = pizzaRepository;
        }
        private Pizza ApplyReduc(Pizza pizza)
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                pizza.Price = _REDUC_PRICE;
            }
            return pizza;
        }
        public IEnumerable<Pizza> GetAll()
        {
            return _Repository.GetAll().Select(p => p.ToBLL()).Select(p => ApplyReduc(p));
        }

        public Pizza GetById(int id)
        {
            Pizza pizza = _Repository.GetById(id).ToBLL();
            if(DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                pizza.Price = _REDUC_PRICE;
            }
            return pizza;
        }

        public Pizza Insert(Pizza pizza)
        {
            pizza.Id = _Repository.Insert(pizza.ToDAL());
            return pizza;
        }
        public bool Delete(int id)
        {
            return _Repository.Delete(id);
        }
    }
}
