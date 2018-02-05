using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawsDAL
{
    public class GenericDAL<T> : Repository<T> where T : class
    {
        DbContext myDbContext;

        public GenericDAL(DbContext context)
        {
            this.myDbContext = context;
        }
        public override void Actualizar( T obj )
        {
            myDbContext.Set<T>().Attach( obj );
            myDbContext.Entry( obj ).State = EntityState.Modified;
        }

        public override void Eliminar( T obj )
        {
            myDbContext.Set<T>().Remove( obj );
        }

        public override void GuardarCambios()
        {
            myDbContext.SaveChanges();
        }

        public override T Insertar( T obj )
        {
            myDbContext.Set<T>().Add( obj );

            return obj;
        }

        public override T ObtenerPorId( int id )
        {
            return myDbContext.Set<T>().Find( id );
        }

        public override T ObtenerPorId(params object[] id)
        {
            return myDbContext.Set<T>().Find( id );
        }

        public override IEnumerable<T> ObtenerTodos()
        {
            return myDbContext.Set<T>().ToList();
        }
    }
}
