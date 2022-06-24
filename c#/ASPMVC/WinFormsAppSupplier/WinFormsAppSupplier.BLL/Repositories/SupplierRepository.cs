using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SupplierRepository : ISupplierRepository
    {
        public int Add(Supplier supplier)
        {
            DAL.ISupplierRepository supplierRepository = new DAL.SupplierRepository();
            int result = supplierRepository.Add(new DAL.Supplier(supplier.Id,supplier.CompanyName,supplier.ContactName,supplier.ContactTitle,supplier.Address,supplier.City,supplier.Region,supplier.PostalCode,supplier.Country,supplier.Phone,supplier.Fax,supplier.HomePage,supplier.CountriesID));
            return result;
        }

        public bool Delete(int id)
        {
            DAL.ISupplierRepository supplierRepository = new DAL.SupplierRepository();
            bool result = supplierRepository.Delete(id);
            return result;
        }

        public IEnumerable<Supplier> GetAll()
        {
            ICollection<Supplier> result = new List<Supplier>();
            DAL.ISupplierRepository supplierRepository = new DAL.SupplierRepository();
            foreach (DAL.Supplier supplier in supplierRepository.GetAll())
            {
                result.Add(new Supplier(supplier));
            }
            return result;
        }

        public Supplier GetById(int id)
        {
            DAL.ISupplierRepository supplierRepository = new DAL.SupplierRepository();
            DAL.Supplier supplier = supplierRepository.GetById(id);
            Supplier result = new Supplier(supplier);
            return result;
        }

        public bool Update(Supplier supplier)
        {
            DAL.ISupplierRepository supplierRepository = new DAL.SupplierRepository();
            bool result = supplierRepository.Update(new DAL.Supplier(supplier.Id, supplier.CompanyName, supplier.ContactName, supplier.ContactTitle, supplier.Address, supplier.City, supplier.Region, supplier.PostalCode, supplier.Country, supplier.Phone, supplier.Fax, supplier.HomePage, supplier.CountriesID));
            return result;
        }
    }
}
