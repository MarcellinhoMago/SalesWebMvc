using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.RegistroVenda.Any())
            {
                return; // O banco de dados já foi populado.
            }

            Departamento d1 = new Departamento(1, "Computadores");
            Departamento d2 = new Departamento(2, "Eletrônicos");
            Departamento d3 = new Departamento(3, "Moda");
            Departamento d4 = new Departamento(4, "Livros");

            Vendedor v1 = new Vendedor(1, "Marcello Domingues Pereira", "marcellinho.domingues@live.com", new DateTime(1985, 8, 16), 4000.0, d1);
            Vendedor v2 = new Vendedor(2, "Jennifer Aline Marques da Silva", "jenya590@gmail.com", new DateTime(1990, 12, 29), 4000.0, d4);
            Vendedor v3 = new Vendedor(3, "Lorena de Queiroz Pereira", "lorena@gmail.com", new DateTime(2013, 5, 1), 2000.0, d3);
            Vendedor v4 = new Vendedor(4, "Rosaura Ottero Domingues", "sculapio@gmail.com", new DateTime(1960, 9, 17), 10000.0, d3);
            Vendedor v5 = new Vendedor(5, "Alex Domingues Barreto", "alex@gmail.com", new DateTime(1969, 8, 28), 6000.0, d2);
            Vendedor v6 = new Vendedor(6, "Janderson Santos da Costa", "piggy_mau@gmail.com", new DateTime(1968, 4, 21), 6000.0, d1);

            RegistroVenda rv1 = new RegistroVenda(1, new DateTime(2018, 09, 25), 11000.0, StatusVenda.Faturado, v1);
            RegistroVenda rv2 = new RegistroVenda(2, new DateTime(2018, 09, 25), 12000.0, StatusVenda.Faturado, v2);
            RegistroVenda rv3 = new RegistroVenda(3, new DateTime(2018, 09, 25), 13000.0, StatusVenda.Faturado, v3);
            RegistroVenda rv4 = new RegistroVenda(4, new DateTime(2018, 09, 25), 14000.0, StatusVenda.Faturado, v4);
            RegistroVenda rv5 = new RegistroVenda(5, new DateTime(2018, 09, 25), 15000.0, StatusVenda.Faturado, v5);
            RegistroVenda rv6 = new RegistroVenda(6, new DateTime(2018, 09, 26), 11000.0, StatusVenda.Faturado, v6);
            RegistroVenda rv7 = new RegistroVenda(7, new DateTime(2018, 09, 26), 12000.0, StatusVenda.Faturado, v2);
            RegistroVenda rv8 = new RegistroVenda(8, new DateTime(2018, 09, 26), 13000.0, StatusVenda.Faturado, v3);
            RegistroVenda rv9 = new RegistroVenda(9, new DateTime(2018, 09, 26), 14000.0, StatusVenda.Faturado, v4);
            RegistroVenda rv10 = new RegistroVenda(10, new DateTime(2018, 09, 26), 15000.0, StatusVenda.Faturado, v5);
            RegistroVenda rv11 = new RegistroVenda(11, new DateTime(2018, 09, 26), 11000.0, StatusVenda.Faturado, v1);
            RegistroVenda rv12 = new RegistroVenda(12, new DateTime(2018, 09, 26), 12000.0, StatusVenda.Faturado, v6);
            RegistroVenda rv13 = new RegistroVenda(13, new DateTime(2018, 09, 26), 13000.0, StatusVenda.Faturado, v3);
            RegistroVenda rv14 = new RegistroVenda(14, new DateTime(2018, 09, 26), 14000.0, StatusVenda.Faturado, v4);
            RegistroVenda rv15 = new RegistroVenda(15, new DateTime(2018, 09, 27), 15000.0, StatusVenda.Faturado, v5);
            RegistroVenda rv16 = new RegistroVenda(16, new DateTime(2018, 09, 27), 11000.0, StatusVenda.Faturado, v1);
            RegistroVenda rv17 = new RegistroVenda(17, new DateTime(2018, 09, 27), 12000.0, StatusVenda.Faturado, v2);
            RegistroVenda rv18 = new RegistroVenda(18, new DateTime(2018, 09, 27), 13000.0, StatusVenda.Faturado, v6);
            RegistroVenda rv19 = new RegistroVenda(19, new DateTime(2018, 09, 27), 14000.0, StatusVenda.Faturado, v4);
            RegistroVenda rv20 = new RegistroVenda(20, new DateTime(2018, 09, 27), 15000.0, StatusVenda.Faturado, v6);
            RegistroVenda rv21 = new RegistroVenda(21, new DateTime(2018, 09, 28), 11000.0, StatusVenda.Faturado, v1);
            RegistroVenda rv22 = new RegistroVenda(22, new DateTime(2018, 09, 28), 12000.0, StatusVenda.Faturado, v2);
            RegistroVenda rv23 = new RegistroVenda(23, new DateTime(2018, 09, 28), 13000.0, StatusVenda.Faturado, v3);
            RegistroVenda rv24 = new RegistroVenda(24, new DateTime(2018, 09, 28), 14000.0, StatusVenda.Faturado, v4);
            RegistroVenda rv25 = new RegistroVenda(25, new DateTime(2018, 09, 28), 15000.0, StatusVenda.Faturado, v5);
            RegistroVenda rv26 = new RegistroVenda(26, new DateTime(2018, 09, 28), 11000.0, StatusVenda.Faturado, v6);
            RegistroVenda rv27 = new RegistroVenda(27, new DateTime(2018, 09, 29), 12000.0, StatusVenda.Faturado, v2);
            RegistroVenda rv28 = new RegistroVenda(28, new DateTime(2018, 09, 29), 13000.0, StatusVenda.Faturado, v3);
            RegistroVenda rv29 = new RegistroVenda(29, new DateTime(2018, 09, 29), 14000.0, StatusVenda.Faturado, v4);
            RegistroVenda rv30 = new RegistroVenda(30, new DateTime(2018, 09, 29), 15000.0, StatusVenda.Faturado, v5);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            
            _context.Vendedor.AddRange(v1, v2, v3, v4, v5, v6);
            
            _context.RegistroVenda.AddRange(
                rv1, rv2, rv3, rv4, rv5, rv6, rv7, rv8, rv9, rv10, 
                rv11, rv12, rv13, rv14, rv15, rv16, rv17, rv18, rv19, rv20, 
                rv21, rv22, rv23, rv24, rv25, rv26, rv27, rv28, rv29, rv30
            );

            _context.SaveChanges();
        }
    }
}
