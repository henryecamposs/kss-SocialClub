using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace KSS_DataObjects.kss_SocialClub.Capas.Negocio
{
    public class LoadAuxDbToListBoxCtrl<TEntity> : adapterEntity<TEntity>
        where TEntity : class
    {
        private ComboBox cmbBinded;
        private string DisplayMember;
        private string ValueMember;
        private ListBox lisBinded;

        public LoadAuxDbToListBoxCtrl(ComboBox comboBox, string displayMember, string valueMember, SQLiteConnection dbConnection, string id_campo = "ID", string querySelect = "", object parameterQuerySelect = null) : base(dbConnection, id_campo, querySelect, parameterQuerySelect)
        {
            cmbBinded = comboBox;
            DisplayMember = displayMember;
            ValueMember = valueMember;
            loadListCtrl();
        }

        public LoadAuxDbToListBoxCtrl(ListBox listBox, string displayMember, string valueMember, SQLiteConnection dbConnection, string id_campo = "ID", string querySelect = "", object parameterQuerySelect = null) : base(dbConnection, id_campo, querySelect, parameterQuerySelect)
        {
            lisBinded = listBox;
            DisplayMember = displayMember;
            ValueMember = valueMember;
            loadListCtrl();
        }
        private int loadListCtrl()
        {
            //var ListRepo = new MoralesLarios.Data.Dapper.DPGenericRepository<TEntity>(base._dbConnection);
            //string qry = $"SELECT   *  FROM {typeof(TEntity).Name} WHERE esActivo = @esActivo";
            //object parameters = new { esActivo = 1 };
            List<TEntity> ListAux = getData();
            if (ListAux != null)
            {
                if (ListAux.Count > 0)
                {
                    if (cmbBinded != null)
                    {
                        cmbBinded.DataSource = ListAux;
                        cmbBinded.DisplayMember = DisplayMember;
                        cmbBinded.ValueMember = ValueMember;
                        cmbBinded.SelectedIndex = -1;
                    }
                    else if (lisBinded != null)
                    {
                        lisBinded.DataSource = ListAux;
                        lisBinded.DisplayMember = DisplayMember;
                        lisBinded.ValueMember = ValueMember;
                        lisBinded.SelectedIndex = -1;
                    }
                }
                return ListAux.Count;
            }
            return 0;
        }
    }
}
