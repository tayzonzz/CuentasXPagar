using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CuentasXPagar.Models
{
    public class PayConceptsModels
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Description { get; set; }
        public string PayConceptsState { get; set; }

        public PayConceptsModels()
        {

        }
    }
}