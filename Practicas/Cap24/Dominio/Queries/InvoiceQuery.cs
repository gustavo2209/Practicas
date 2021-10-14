using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicas.Cap24.Dominio.Queries
{
    public class InvoiceQuery
    {
        public int InvoiceId { get; set; }

        public int CustomerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string BillingAddress { get; set; }

        public string BillingCity { get; set; }

        public string BillingState { get; set; }

        public string BillingCountry { get; set; }

        public string BillingPostalCode { get; set; }

        public decimal Total { get; set; }

        public int TrackId { get; set; }

        public string TrackName { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
