using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVVM_Modele_03.Models
{
    public enum ConditionCar
    {
        NEW,
        OCCASION,
        DAMAGED
    }
    public class Car
    {
        public int Id { get; set; }
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public ConditionCar Condition { get; set; }
        public int Kilometers { get; set; }
        public bool IsFunctional { get; set; }
        public double Price { get; set; }
        public bool HasStock { get; set; }
    }
}
