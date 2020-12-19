using System;
using System.Linq;
using System.Collections.Generic;


namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVenda> Vendas { get; set; } = new List<RegistroVenda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double baseSalario, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataNascimento = dataNascimento;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AddVendas(RegistroVenda rv)
        {
            
            Vendas.Add(rv);
        }

        public void RemoverVendas(RegistroVenda rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(rv => rv.Data >= inicial && rv.Data <= final).Sum(rv => rv.Valor);
        }

    }
}
