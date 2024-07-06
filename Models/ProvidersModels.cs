using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CuentasXPagar.Models
{
    public class ProvidersModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonType { get; set; }
        // public List<string> PersonType { get; set; }
        public int CedulaOrRNC { get; set; }
        public int Balance { get; set; }
        public string State { get; set; }
        // public List<string> State { get; set; }

        public ProvidersModels()
        {
            // PersonType = new List<string> { "Física", "Jurídica" };
            // State = new List<string> { "Activo", "Inactivo" };
        }
    }
}