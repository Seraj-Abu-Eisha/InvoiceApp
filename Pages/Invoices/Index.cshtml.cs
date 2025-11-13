using InvoiceApp.models;
using InvoiceApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDBContext context;

        public List<Invoce> invoiceList = new();

        public IndexModel(ApplicationDBContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            invoiceList = context.Invoices.OrderByDescending(i => i.Id).ToList(); 
        }
    }
}
