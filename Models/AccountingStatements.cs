using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CuentasXPagar.Models
{
    public class AccountingStatements
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int InventoryID { get; set; }
        public string Account { get; set; }
        public string TypeOfMovement { get; set; }

        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal Ammount { get; set; }
        public string State { get; set; }

        public AccountingStatements()
        {

        }

    }
}