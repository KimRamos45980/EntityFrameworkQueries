using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using System.Text;

namespace EntityFrameworkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSelectAllVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new APContext();

            // Note to self: Due to changing the namespace of the files
            // ie. needing to add a using .Data/.Models
            // The database APContext was missing the same files
            // So I needed to add a using.models to the context in order to use dbContext properly

            // LINQ (Language Integrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       select v).ToList();
        }

        private void BtnAllCaliVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA")
                                        .OrderBy(v => v.VendorName)
                                        .ToList();

            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       where v.VendorState == "CA"
                                       orderby v.VendorName
                                       select v).ToList();
        }

        private void BtnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            APContext dbContext = new APContext();

            // Annoymous type (t = 'a) <= the a is the annoymous type
            // Replaced var with created class below
            List<VendorLocation> results = (from v in dbContext.Vendors
                          select new VendorLocation
                          {
                              VendorName = v.VendorName, 
                              VendorState = v.VendorState, 
                              VendorCity = v.VendorCity
                          }).ToList();

            StringBuilder displayString = new();
            foreach(VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }

            MessageBox.Show(displayString.ToString());
        }
    }

    // Created to have a type set instead of just 'a
    class VendorLocation
    {
        public string VendorName { get; set; }

        public string VendorCity { get; set; }

        public string VendorState { get; set; }
    }
}