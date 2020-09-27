using MbmStore.Infrastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public IActionResult Index()
        {

            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();

            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstname + " " +  invoice.Customer.Lastname,
                    Value = invoice.Customer.CustomerId.ToString()
                });
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            ViewData["Customers"] = customers;
            ViewData["Invoices"] = Repository.Invoices;

            return View();
        }

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            List<Invoice> invoices;

            if (customer != null)
            {
                // select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == customer).ToList();
            }
            else
            {
                invoices = Repository.Invoices;
            }


            // declare the list
            List<SelectListItem> customers = new List<SelectListItem>();

            // generate the dropdown list
            foreach (Invoice invoice in Repository.Invoices)
            {
                if (invoice.Customer.CustomerId == customer) {
                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                        Value = invoice.Customer.CustomerId.ToString(),
                        Selected = true
                    });
                }
                else { 

                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                        Value = invoice.Customer.CustomerId.ToString()
                    });
                }
            }

            // removes duplicate entries with same ID from a IEnumerable
            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            ViewData["Customers"] = customers;

            ViewData["Invoices"] = invoices;
            return View();
        }

    }
}