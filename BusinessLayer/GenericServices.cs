using DrawsDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public static class GenericServices<T> where T : class
    {
        private static Repository<T> repository;

        static GenericServices()
        {
            repository = new GenericDAL<T>( new SorteosDB() );
        }

        public static T Insertar( T obj )
        {
            if (obj != null)
            {
                return repository.Insertar( obj );
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static IEnumerable<T> InsertarVarios(IEnumerable<T> obj)
        {
            if (obj != null)
            {
                foreach (var item in obj)
                {
                    repository.Insertar(item);
                }
                return obj;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static void Eliminar( T obj )
        {
            if (obj != null)
            {
                repository.Eliminar( obj );
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static void Actualizar( T obj )
        {
            if (obj != null)
            {
                repository.Actualizar( obj );
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public static IEnumerable<T> ListarTodos()
        {
            return repository.ObtenerTodos();
        }

        public static T BuscarPorId( int id )
        {
            return repository.ObtenerPorId( id );
        }

        public static T BuscarPorId(params object[] id)
        {
            return repository.ObtenerPorId(id);
        }

        public static void Guardar()
        {
            repository.GuardarCambios();
        }
    }
}
