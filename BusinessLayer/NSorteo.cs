using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class NSorteo
    {
        public static void LlenarCombobox(ComboBox cb, string DisplayMember, string ValueMember)
        {
            var lista = GenericServices<Sorteo>.ListarTodos().ToList();

            cb.DisplayMember = DisplayMember;
            cb.ValueMember = ValueMember;
            cb.DataSource = lista;
        }
    }
}
