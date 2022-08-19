using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal static class PizzaMapper
    {
        public static DAL.Pizza ToDAL(this BLL.Pizza pizza)
        {
            string pizzaType;
            switch (pizza.PizzaType)
            {
                case PizzaTypeEnum.Tomate:
                    pizzaType = "Base Tomate";
                    break;
                case PizzaTypeEnum.Crème:
                    pizzaType = "Base Crème";
                    break;
                case PizzaTypeEnum.Calzone:
                    pizzaType = "Calzone";
                    break;
                default:
                    throw new Exception("Type de Pizza non géré");
            }

            return new DAL.Pizza
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaType = pizzaType
            };
        }

        public static BLL.Pizza ToBLL(this DAL.Pizza pizza)
        {
            PizzaTypeEnum pizzaType;
            switch (pizza.PizzaType)
            {
                case "Base Tomate":
                    pizzaType = PizzaTypeEnum.Tomate;
                    break;
                case "Base Crème":
                    pizzaType = PizzaTypeEnum.Crème;
                    break;
                case "Calzone":
                    pizzaType = PizzaTypeEnum.Calzone;
                    break;
                default:
                    throw new Exception("Type de Pizza non géré");
            }

            return new BLL.Pizza
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaType = pizzaType
            };
        }
    }
}
