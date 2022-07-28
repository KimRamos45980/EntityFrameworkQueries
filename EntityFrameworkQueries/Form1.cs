using EntityFrameworkQueries.Data;
using EntityFrameworkQueries.Models;
using Microsoft.EntityFrameworkCore;
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

        private void BtnMiscQueries_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();

            // Check if a vendor exists in washington
            bool doesExist = (from v in dbContext.Vendors
                              where v.VendorState == "WA"
                              select v).Any();

            // Get number of Invoices
            int invoiceCount = (from v in dbContext.Invoices
                                select v).Count();

            // Query a single Vendor
            Vendor ? ibm = (from v in dbContext.Vendors
                            where v.VendorName == "IBM"
                            select v).SingleOrDefault();

            if (ibm != null)
            {
                // Do something with the Vendor object
            }
        }

        private void BtnVendorsAndInvoices_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();

            // Vendors LEFT JOIN Invoices
            List<Vendor> allVendors = dbContext.Vendors.Include(v => v.Invoices).ToList();

            // Unfinished code: This pulls a Vendor object for each individual invoice, vendors
            // are also pulled back if they have no invoices
            //List<Vendor> allVendors = (from v in dbContext.Vendors
            //                           join inv in dbContext.Invoices
            //                             on v.VendorId equals inv.VendorId into grouping
            //                           from inv in grouping.DefaultIfEmpty()
            //                           select v).ToList();

            StringBuilder results = new();

            foreach (Vendor v in allVendors)
            {
                results.Append(v.VendorName);
                foreach(Invoice inv in v.Invoices)
                {
                    results.Append(", " + inv.InvoiceNumber);
                }
                results.AppendLine();
            }

            MessageBox.Show(results.ToString());
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