using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineChallange3
{
    public interface IVeiculosService
    {
        List<Marcas> GetMarcas();

        List<Modelos> GetModelos(int modeloID);

        List<Veiculos> GetVersoes(int versoesID);

        List<Veiculos> GetVeiculos(int veiculosID);

    }
}
