using System.Text;
using Models;

namespace DAL
{
    public static class FileUtility
    {
        public static IList<Entreprise> ReadEnterpriseFromFileCP218(string pPath)
        {
            IList<Entreprise> entreprises = new List<Entreprise>();
            string[]lines = File.ReadAllLines(pPath, Encoding.UTF7);
            foreach (string line in lines.Skip(1))//Linq
            {
                Entreprise entreprise = new Entreprise(line);
                entreprises.Add(entreprise);
            }
            return entreprises.OrderBy(ent => ent.Name).ToList();
        }
    }
}