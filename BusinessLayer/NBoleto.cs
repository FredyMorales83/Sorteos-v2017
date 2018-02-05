using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class NBoleto
    {
        //public static IEnumerable<int> ObtenerNumerosOtorgados(int SorteoId, int ParticipanteId = 0)
        //{
        //    if (ParticipanteId == 0)
        //    {
        //        var boletos = GenericServices<Boleto>.ListarTodos().Where(x => x.SorteoId == SorteoId).ToList().Select(n => n.BoletoElectronico);

        //        return boletos;
        //    }
        //    else
        //    {
        //        var boletos = GenericServices<Boleto>.ListarTodos().Where(x => x.SorteoId == SorteoId && x.ParticipanteId == ParticipanteId).ToList().Select(n => n.BoletoElectronico);

        //        return boletos;
        //    }
        //}

        public static IEnumerable<Boleto> ObtenerNumerosOtorgados(int SorteoId, int ParticipanteId = 0)
        {
            if (ParticipanteId == 0)
            {
                var boletos = GenericServices<Boleto>.ListarTodos().Where(x => x.SorteoId == SorteoId).ToList();

                return boletos;
            }
            else
            {
                var boletos = GenericServices<Boleto>.ListarTodos().Where(x => x.SorteoId == SorteoId && x.ParticipanteId == ParticipanteId).ToList();

                return boletos;
            }
        }
    }
}
