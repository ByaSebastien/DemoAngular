using Demo_ASP_MVC_Modele.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ASP_MVC_Modele.DAL.Entities
{
    public class GameEntity :IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Nb_Player_Min { get; set; }
        public int Nb_Player_Max { get; set; }
        public int? Age { get; set; }
        public bool IsCoop { get; set; }
    }
}
