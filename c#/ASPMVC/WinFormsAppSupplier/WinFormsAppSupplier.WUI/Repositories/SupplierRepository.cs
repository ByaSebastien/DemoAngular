using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WUI
{
    public class SupplierRepository : ISupplierRepository
    {
        public int Add(Supplier supplier)
        {
            BLL.ISupplierRepository supplierRepository = new BLL.SupplierRepository();
            int result = supplierRepository.Add(new BLL.Supplier(supplier.Id, supplier.CompanyName, supplier.ContactName, supplier.ContactTitle, supplier.Address, supplier.City, supplier.Region, supplier.PostalCode, supplier.Country, supplier.Phone, supplier.Fax, supplier.HomePage, supplier.CountriesID));
            return result;
        }

        public bool Delete(int id)
        {
            BLL.ISupplierRepository supplierRepository = new BLL.SupplierRepository();
            bool result = supplierRepository.Delete(id);
            return result;
        }

        public IEnumerable<Supplier> GetAll()
        {
            ICollection<Supplier> result = new List<Supplier>();
            BLL.ISupplierRepository supplierRepository = new BLL.SupplierRepository();
            foreach (BLL.Supplier supplier in supplierRepository.GetAll())
            {
                result.Add(new Supplier(supplier));
            }
            return result;
        }

        public Supplier GetById(int id)
        {
            BLL.ISupplierRepository supplierRepository = new BLL.SupplierRepository();
            BLL.Supplier supplier = supplierRepository.GetById(id);
            Supplier result = new Supplier(supplier);
            return result;
        }

        public bool Update(Supplier supplier)
        {
            BLL.ISupplierRepository supplierRepository = new BLL.SupplierRepository();
            bool result = supplierRepository.Update(new BLL.Supplier(supplier.Id, supplier.CompanyName, supplier.ContactName, supplier.ContactTitle, supplier.Address, supplier.City, supplier.Region, supplier.PostalCode, supplier.Country, supplier.Phone, supplier.Fax, supplier.HomePage, supplier.CountriesID));
            return result;
        }
    }
}
