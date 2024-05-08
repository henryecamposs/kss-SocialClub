using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using kss_A_Ganador.Forms.Datos;
using kssEF61Entidad;
using kssEF61Negocio;

namespace kss_A_Ganador.Forms.Plantillas
{
    public partial class frmListChild<T> : Form
        where T : class
    {
        //Shared
        internal kssEF61Datos.UnitOFWork.UnitOfWork _unitOfWork = new kssEF61Datos.UnitOFWork.UnitOfWork();
        internal BindingSource bsEntity = new BindingSource();
        internal SortableBindingList<T> blEntity;
        internal T CurrentEntity;

        private string _Titulo;
        private bool sizeDG;
        public int totalWidth = 0;
        public int LastColumnIndex = 0;
        public string Titulo
        {
            get
            { return _Titulo; }
            set
            {
                _Titulo = value;
                this.Text = _Titulo;
            }
        }
        internal void PrecargaLeftBarMedidas()
        {
            //Niveles
            lgiNiveles.Height = 40+ (lciNivel1.Visible ? lciNivel1.Height : 0) + (lciNivel2.Visible ? lciNivel2.Height : 0) + (lciNivel3.Visible ? lciNivel3.Height : 0);
            //Mostrar
            lgiMostrar.Height = 30 + (lyiBtnFiltro.Height) + (lciTodos.Visible ? lciTodos.Height : 0) + (lciFiltro1.Visible ? lciFiltro1.Height : 0) + (lciFiltro2.Visible ? lciFiltro2.Height : 0);
            //ExpandFiltro
            expandFiltro.Height = 40 + (lgiMostrar.Visible? lgiMostrar.Height:0) + (lgiNiveles.Visible? lgiNiveles.Height:0);

        }
        internal string TablaAuxiliar
        {
            get;
            set;
        }

        public frmListChild()
        {
            InitializeComponent();
            this.TablaAuxiliar = getEnityName;
        }

        internal void FormList_Hijo_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            rbmergedArchivo.RibbonTabText = Titulo;
            lblTittleDataGrid.Text = Titulo;

            CargarEntity();
            bsEntity.DataSource = blEntity;
            DataGridView1.DataSource = bsEntity;

            //SetupDataBindingsForLabels();
            SetupEventsForDataGridViewSorting();

            bsEntity.Position = 0;
            bnDatosEnlazados.BindingSource = bsEntity;

            //Cargar Controlador de Datos

            // set up to allow filtering by company name
            //  cboFilterOptionsForString.DataSource = typeof(FilterOptions).Names().ToList();
            bnDatosEnlazados.AddNewRecordButton = null;
            bnDatosEnlazados.DeleteButton = null;
            ribbCustom1.Visible = false;
            ribbCustom2.Visible = false;
        }

        private void CargarEntity()
        {
            Cursor tmpCrs = this.Cursor;
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();

            switch (TablaAuxiliar.ToLower())
            {
                case "empresas":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.EmpresasEntityAdapter.DataSource);
                    //PrimaryKeyColumnName = _unitOfWork.EmpresasEntityAdapter.GetPrimaryKeyColumnName<Empresas>(new Empresas());
                    break;
                case "sucursales":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.SucursalesEntityAdapter.DataSource);
                    break;
                case "cajas":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.CajasEntityAdapter.DataSource);
                    break;
                case "hipodromos":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.HipodromosEntityAdapter.DataSource);
                    break;
                case "studs":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.StudsEntityAdapter.DataSource);
                    break;
                case "entrenadores":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.EntrenadoresEntityAdapter.DataSource);
                    break;
                case "caballos":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.CaballosEntityAdapter.DataSource);
                    break;
                case "jinetes":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.JinetesEntityAdapter.DataSource);
                    break;
                case "carrerascaballo":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.CarrerasCaballoEntityAdapter.DataSource);
                    break;
                case "clientes":
                    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.ClientesEntityAdapter.DataSource);
                    break;
                //case "studs":
                //    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.StudsRepository.DataSource);
                //    break;
                //case "studs":
                //    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.StudsRepository.DataSource);
                //    break;
                //case "studs":
                //    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.StudsRepository.DataSource);
                //    break;
                //case "studs":
                //    blEntity = new SortableBindingList<T>((IList<T>)_unitOfWork.StudsRepository.DataSource);
                //    break;

                default:
                    ksslib.kss_msjDelay.Show("Debe Indicar Datasource Origen", 40);
                    break;


            }
            this.Cursor = tmpCrs;
        }
        private string getEnityName
        {
            get
            {
                return ksslib_c.Utiles.clsUtil_Class.GetName<T>();
            }
        }
        private void FormList_Hijo_Activated(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            DataGridView1.Focus();
        }

        private void FormList_Hijo_Resize(object sender, EventArgs e)
        {
            if (!sizeDG && totalWidth > 0)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    sizeDG = true;
                    if (totalWidth < DataGridView1.Width)
                        DataGridView1.Columns[LastColumnIndex].Width += DataGridView1.Width - totalWidth;
                    else if (totalWidth > DataGridView1.Width)
                        DataGridView1.Columns[LastColumnIndex].Width -= totalWidth - DataGridView1.Width;
                }
            }
        }
        internal virtual void btnEnlazAdd_Click(object sender, EventArgs e)
        {
            AddNew();
        }
        internal virtual void btnEnlazDel_Click(object sender, EventArgs e)
        {
            Remove();
        }
        internal virtual void DataGridView1_Sorted(object sender, EventArgs e)
        {
            if (bsEntity.CurrentRowIsValid())
                bsEntity.Position = blEntity.IndexOf(CurrentEntity);
        }
        internal virtual void bsEntity_PositionChanged(object sender, EventArgs e)
        {
            if (bsEntity.CurrentRowIsValid())
                CurrentEntity = ((T)bsEntity.Current);
            else
                CurrentEntity = null;
        }

        private void AddNew()
        {

        }

        internal virtual bool EditCurrentRow()
        {
            if (CurrentEntity != null)
                return true;
            else
                return false;
        }

        private void Remove()
        {
            this.RemoveCurrentRow();
        }


        /// <summary>
        /// Data bind two fields to labels
        /// </summary>
        internal void SetupDataBindingsForLabels()
        {
            //lblCustomerIdentifier.DataBindings.Add("text", bsCustomers, "CustomerIdentifier");
            //lblCompanyName.DataBindings.Add("text", bsCustomers, "CompanyName");
        }
        internal void PrepareDataGridViewColumns(List<clsDataGridColumnStyle> ColumnCustom)
        {
            List<DataGridViewColumn> newColumns = new List<DataGridViewColumn>();
            List<DataGridViewColumn> oldCOlumns = new List<DataGridViewColumn>();
            foreach (DataGridViewColumn col in DataGridView1.Columns)
            {
                col.Visible = false;
                oldCOlumns.Add(col);
            }
            //DataGridView1.Columns.Clear();
            foreach (clsDataGridColumnStyle colCustom in ColumnCustom)
            {
                DataGridViewColumn ColFound = oldCOlumns.Find(x => x.DataPropertyName.ToLower() == colCustom.DataColumn.ToLower());
                if (ColFound != null)
                {
                    DataGridViewColumn newcol = null;
                    if (ColFound.ValueType.FullName.Contains("Boolean"))
                        newcol = new DataGridViewCheckBoxColumn();
                    else
                        newcol = new DataGridViewTextBoxColumn();
                    newcol.HeaderText = colCustom.HeaderText;
                    newcol.Name = colCustom.DataColumn;
                    newcol.AutoSizeMode = colCustom.esAutoFill ? DataGridViewAutoSizeColumnMode.Fill : DataGridViewAutoSizeColumnMode.None;
                    newcol.DefaultCellStyle = ColFound.DefaultCellStyle;
                    newcol.CellTemplate.Style.BackColor = ColFound.CellTemplate.Style.BackColor;
                    newcol.Width = colCustom.Width;
                    newcol.Visible = true;
                    newcol.DataPropertyName = colCustom.DataColumn;
                    DataGridView1.Columns.Add(newcol);
                }
                else
                    continue;
                totalWidth += colCustom.Width;

            }
            if (DataGridView1.Columns.Count > 0)
                LastColumnIndex = DataGridView1.Columns.GetLastColumn(DataGridViewElementStates.Visible, DataGridViewElementStates.Frozen).Index;
            foreach (DataGridViewColumn col in DataGridView1.Columns)
            {
                if (col.Visible)
                    if (col.HeaderText != "RIF")
                        col.HeaderText = Regex.Replace(col.HeaderText, "(\\B[A-Z])", " $1");
            }
            //DataGridView1.ExpandColumns();
            DataGridView1.Refresh();
        }
        internal virtual void SetupEventsForDataGridViewSorting()
        {
            bsEntity.PositionChanged += bsEntity_PositionChanged;
            DataGridView1.Sorted += DataGridView1_Sorted;
        }

        private void lblIRecientes_MouseHover(object sender, EventArgs e)
        {
            ((LabelItem)sender).BackColor = System.Drawing.Color.Gold;
            ((LabelItem)sender).Focus();
        }

        private void lblIRecientes_MouseLeave(object sender, EventArgs e)
        {
            ((LabelItem)sender).BackColor = System.Drawing.Color.Transparent;
        }

        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                e.Handled = true;
                RemoveCurrentRow();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                EditCurrentRow();
            }
        }

        private void RemoveCurrentRow()
        {
            //if (Question($"Remove '{bsEntity.CompanyName()}' ?"))
            //{
            //    Customers customers = new Customers();
            //    customers.Remove(bsCustomers.Customer());
            //    bsCustomers.RemoveCurrent();
            //    ActiveControl = dataGridView1;
            //}
        }

        private void DataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                EditCurrentRow();
            }
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = true;
            //MessageBox.Show( "Error: " + e.Exception + "en: " + e.RowIndex);
        }

        private void btnINew_Click(object sender, EventArgs e)
        {

        }

        private void btnIDuplicar_Click(object sender, EventArgs e)
        {

        }

        private void btnIEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnIDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnIFind_Click(object sender, EventArgs e)
        {

        }

        private void btnIFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnIOrderAZ_Click(object sender, EventArgs e)
        {

        }

        private void btnIOrderZA_Click(object sender, EventArgs e)
        {

        }

        private void btnIPrintList_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom1_1_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom1_2_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom1_3_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom1_4_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom2_1_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom2_2_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom2_3_Click(object sender, EventArgs e)
        {

        }

        private void btnICustom2_4_Click(object sender, EventArgs e)
        {

        }

        private void btnIConfig_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {

        }
    }
    #region Instancias de la Plantilla...
    public class EmpresasListChildBase : frmListChild<Empresas> { }
    public class CaballosListChildBase : frmListChild<Caballos> { }
    public class CarrerasCaballosListChildBase : frmListChild<CarrerasCaballo> { }
    public class ClientesListChildBase : frmListChild<Clientes> { }
    public class EntrenadoresListChildBase : frmListChild<Entrenadores> { }
    public class HipodromosListChildBase : frmListChild<Hipodromos> { }
    public class StudsListChildBase : frmListChild<Studs> { }
    public class SucursalesListChildBase : frmListChild<Sucursales> { }
    public class TaquillasListChildBase : frmListChild<Cajas> { }
    public class JinetesListChildBase : frmListChild<Jinetes> { }
    #endregion
}
