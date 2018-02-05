using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawsDAL
{
    public abstract class Repository<TEntity> where TEntity : class
    {
        public abstract void Actualizar( TEntity obj );
        public abstract void Eliminar( TEntity obj );
        public abstract void GuardarCambios();
        public abstract TEntity Insertar( TEntity obj );
        public abstract TEntity ObtenerPorId( int id );
        public abstract TEntity ObtenerPorId(params object[]  id);
        public abstract IEnumerable<TEntity> ObtenerTodos();
    }
}
