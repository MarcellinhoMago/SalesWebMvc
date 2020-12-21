using System.Collections.Generic;

namespace SalesWebMvc.Models.ViewModels
{
    public class VendedorFromViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamentos { get; set; }
    }
}
