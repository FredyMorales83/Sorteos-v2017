using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLayer
{
    public static class NSorteoReferencia
    {
        public static void LlenarCombobox(ComboBox cb, string DisplayMember, string ValueMember)
        {
            var lista = GenericServices<SorteoReferencia>.ListarTodos().ToList();

            cb.DisplayMember = DisplayMember;
            cb.ValueMember = ValueMember;
            cb.DataSource = lista;
        }
    }
}
