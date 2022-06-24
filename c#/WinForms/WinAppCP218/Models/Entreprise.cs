using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Entreprise
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string PostalCode { get; private set; }
        public string City { get; private set; }
        public string NaceCode { get; private set; }
        public Language Idiom { get; private set; }
        public EmployeesNumber CountEmployees { get; private set; }
        public DateTime? SendingCVDate { get; private set; }
        public Entreprise(int pID,string pName,string pAddress, string pPostalCode,string pCity,string pNaceCode,Language pIdiom,EmployeesNumber pCountEmployees)
        {
            Id = pID;
            Name = pName;
            Address = pAddress;
            PostalCode = pPostalCode;
            City = pCity;
            NaceCode = pNaceCode;
            Idiom = pIdiom;
            CountEmployees = pCountEmployees;
        }
        public Entreprise(string pLine)
        {
            string[] line = pLine.Split(';');
            int CountEmployeesEnum = TranslateStringToInt(line[4]);
            Id = int.Parse(line[0]);
            Name = line[1];
            Address = line[6];
            PostalCode = line[7];
            City = line[9];
            try
            {
                Idiom = (Language)Enum.Parse(typeof(Language), line[5]);
            }
            catch (ArgumentException)
            {
                Idiom = Language.Inconnu;
            }
            NaceCode = line[2];
            CountEmployees = (EmployeesNumber)CountEmployeesEnum;
        }

        public int TranslateStringToInt(string v)
        {
            if (string.IsNullOrEmpty(v)) return 0;
            if (v.IndexOf("-") < 0 && v.IndexOf(">") < 0)
                throw new ArgumentException("manque - ou > dans le texte");
            string[] splitted = v.Trim().Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            return int.Parse(splitted[0]);
        }

        public override string ToString()
        {
            return $"{PostalCode} {Address,-50} {Name.Trim(),-100}";
        }
        public override bool Equals(object obj)
        {
            Entreprise? enterprise = obj as Entreprise;
            if(Idiom == enterprise?.Idiom && CountEmployees == enterprise?.CountEmployees && Id == enterprise.Id)
                return true;
            return false;
        }
    }
}
