using DAL;
using Models;

namespace BLL
{
    public static class Cp218
    {
        public static IList<Entreprise> GetEnterprise(string pPath)
        {
            return FileUtility.ReadEnterpriseFromFileCP218(pPath);
        }
    }
}