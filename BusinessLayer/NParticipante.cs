using DrawsDAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class NParticipante
    {
        /// <summary>
        /// Devuelve la lista de partipantes que contienen el parametro de busqueda en nombre, apellido paterno o materno
        /// </summary>
        /// <param name="str">Cadena a buscar</param>
        /// <returns>Devuelve la lista de partipantes que contienen el parametro de busqueda en nombre, apellido paterno o materno</returns>
        public static List<Participante> BuscarParticipantePorNombreApellidos(string str)
        {
            using (var db = new SorteosDB())
            {
                return db.Participantes.Where( x => x.Nombre.Contains( str ) || x.ApellidoPaterno.Contains( str ) || x.ApellidoMaterno.Contains( str ) ).ToList();
            }
        }

        /// <summary>
        /// Registra un nuevo participante en la base de datos
        /// </summary>
        /// <param name="participante">Participante a guardar</param>
        public static void AgregarParticipante(Participante participante)
        {
            GenericServices<Participante>.Insertar( participante );
            GenericServices<Participante>.Guardar();
        }

        /// <summary>
        /// Devuelve lista de todos los participantes en la BD
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Participante> MostrarTodos()
        {
            return GenericServices<Participante>.ListarTodos();
        }

        /// <summary>
        /// Devuelve una lista de todos los participantes de un sorteo determinado
        /// </summary>
        /// <param name="sorteoid">ID del sorteo a listar</param>
        /// <returns></returns>
        public static IEnumerable<Participante> ObtenerParticipantesPorSorteo(int sorteoid)
        {
            // lista;

            using (var db = new SorteosDB())
            {
                //IEnumerable<Participante> lista = from p in db.Participantes join b in db.Boletos on p.ParticipanteId equals b.ParticipanteId where b.SorteoId == sorteoid select p;
                //return lista.ToList();

                IEnumerable<Participante> lista = from p in db.Participantes
                                                  from b in db.Boletos
                                                  where p.ParticipanteId == b.ParticipanteId && b.SorteoId == sorteoid
                                                  select p;
                //select new { p.Nombre, p.ApellidoPaterno, p.ApellidoMaterno, p.FechaModificado };
                //return lista.Distinct().ToList();
                return lista.Distinct().ToList();
            }


        }
    }
}
