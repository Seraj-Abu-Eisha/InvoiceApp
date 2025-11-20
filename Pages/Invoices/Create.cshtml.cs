using InvoiceApp.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace InvoiceApp.Pages.Invoices
{
    public class CreateModel : PageModel
    {
        public InvoiceDto invoiceDto { get; set; } = new();
        public void OnGet()
        {
        }
    }
}
