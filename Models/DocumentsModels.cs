using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CuentasXPagar.Models
{
    public class DocumentsModels
    {
        public int Id { get; set; }
     
        public string DocumentNumber { get; set; }

        public string InvoiceNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime DocumentDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime RecordDate { get; set; }

        public string Proveedor { get; set; }

        public DocumentsModels()
        {

        }
    }
}