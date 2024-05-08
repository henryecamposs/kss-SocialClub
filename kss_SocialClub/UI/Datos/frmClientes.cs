using kss_SocialClub.UI.Templates;
using ksslib;
using System;
using System.Windows.Forms;

namespace kss_SocialClub.UI.Datos
{
    public partial class frmClientes :   ClientesEdit
    {
        int idresidencia = 0;

        public frmClientes()
        {
            InitializeComponent();
            panelDatos = panel3;
            this.ResetControles += Frm_ResetControles;
            this.GuardarDatos += Frm_GuardarDatos;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            this.CargarDatos += Frm_CargarDatos;
            this._unitOfWork.currentRepository.MoveFirst();
            //en mayusculas
            txtNombres.CharacterCasing = CharacterCasing.Upper;
            txtApellidos.CharacterCasing = CharacterCasing.Upper;
        }

        private void Frm_CargarDatos(object sender)
        {
            errorProvider1.Clear();
            EntidadActual = (Clientes)sender;
            if (EntidadActual != null)
            {
                txtNombres.Text = EntidadActual.Nombres;
                txtCIRIF.Text = EntidadActual.Cedula;
                txtApellidos.Text = EntidadActual.Apellidos;
                txtTelf.Text = EntidadActual.Telefono;
                txtDiasFrec.Text = EntidadActual.DiasFrecuencia.ToString();
                _unitOfWork.currentRepository.IDActual = EntidadActual.ID;
            }
        }

        private void Frm_GuardarDatos(Object sender)
        {
            isGuardar = true;
            tmpEntidad = (Clientes)sender;
            tmpEntidad.ID = _unitOfWork.currentRepository.statusRegistro == ksslib.enuStatusRegistro.Agregando ?
                (int)_unitOfWork.currentRepository.LastID() + 1 : tmpEntidad.ID;
            tmpEntidad.Apellidos = txtApellidos.Text;
            tmpEntidad.Cedula = txtCIRIF.Text;
            tmpEntidad.DiasFrecuencia = Convert.ToInt16(txtDiasFrec.Text);
            tmpEntidad.Nombres = txtNombres.Text;
            tmpEntidad.Telefono = txtTelf.Text;
            tmpEntidad.esActivo = true;
            _unitOfWork.currentRepository.IDActual = tmpEntidad.ID;
            isGuardar = DatosCompletos();
        }

        private bool DatosCompletos()
        {
            //Falta apartamentos
            //Falta RIF
            if (txtCIRIF.Text.Trim().Length == 0)
            {
                kss_msjDelay.Show("Indique la Cédula o RIF",enuMsgBoxImag.msgCritical, "Datos Incompletos!!", 5);
                return false;
            }
            if (txtNombres.Text.Trim().Length == 0)
            {
                kss_msjDelay.Show("Indique el Nombre",enuMsgBoxImag.msgCritical, "Datos Incompletos!!", 5);
                return false;
            }
            return true;
        }

       
        private void Frm_ResetControles(object sender, EventArgs e)
        {
            txtNombres.Text = "";
            txtCIRIF.Text = "";
            txtApellidos.Text = "";
            txtTelf.Text = "";
            txtDiasFrec.Text = "15";
            txtCIRIF.Focus();
        }

        private void Txt_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            ksslib_c.clsUtil_Strings.PermitirSoloDecimales(sender, e);
        }

        private void txtDiasFrec_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(((DevComponents.DotNetBar.Controls.TextBoxX)sender).Text))
                ((DevComponents.DotNetBar.Controls.TextBoxX)sender).Text = "0";
        }


        //#region Tabla Auxiliar

        //private void VerificarAux()
        //{
        //    if (loadCmb() == 0)
        //    {
        //        ksslib.kss_msjDelay.Show("Es necesario crear RESIDENCIAS!");
        //        btnAdd_Residencia_Click(null, null);
        //        if (cmbResidencia.Items.Count == 0)
        //        {
        //            ksslib.kss_msjDelay.Show("No existen RESIDENCIAS!\n Se cerrará el Módulo.");
        //        }
        //    }
        //}
        //private int loadCmb()
        //{
        //    var ListRepo = new MoralesLarios.Data.Dapper.DPGenericRepository<Residencias>(Program.Connection);
        //    string qry = $"SELECT ID,Residencia,esActivo FROM {typeof(Residencias).Name} WHERE esActivo = @esActivo ";
        //    //string qry = string.Format("SELECT {0}.ID,{0}.Residencia,{0}.esActivo,{1}.id_Residencia FROM {0},aptos WHERE {0}.esActivo = @esActivo AND {0}.id = {1}.id_Residencia", "Residencias", "Aptos");
        //    object parameters = new { esActivo = 1 };
        //    List<Residencias> ListAux = (List<Residencias>)ListRepo.GetData(qry, parameters);
        //    if (ListAux.Count > 0)
        //    {
        //        cmbResidencia.DataSource = ListAux;
        //        cmbResidencia.DisplayMember = "Residencia";
        //        cmbResidencia.ValueMember = "ID";
        //    }
        //    else
        //    {
        //        cmbResidencia.DataSource = null;
        //        cmbResidencia.Items.Clear();
        //    }
        //    return ListAux.Count;
        //}
        //private int loadCmb2(int idResidencia)
        //{
        //    var ListRepo = new MoralesLarios.Data.Dapper.DPGenericRepository<Aptos>(Program.Connection);
        //    string qry = $"SELECT ID,Apto,esActivo FROM {typeof(Aptos).Name} WHERE id_residencia = @id_residencia";
        //    object parameters = new { id_residencia = idResidencia };
        //    List<Aptos> ListAux = (List<Aptos>)ListRepo.GetData(qry, parameters);
        //    if (ListAux.Count > 0)
        //    {
        //        cmbApto.DataSource = ListAux;
        //        cmbApto.DisplayMember = "Apto";
        //        cmbApto.ValueMember = "ID";
        //    }
        //    else
        //    {
        //        cmbApto.DataSource = null;
        //        cmbApto.Items.Clear();
        //    }
        //    return ListAux.Count;
        //}
        //private void btnAdd_Residencia_Click(object sender, EventArgs e)
        //{
        //    //Cargar Tabla enlazada
        //    frmResidencias frm = new frmResidencias()
        //    { StartPosition = System.Windows.Forms.FormStartPosition.CenterParent, isAuxiliarTable = true };
        //    //Load data aux cmb
        //    frm.ShowDialog(this);
        //    loadCmb();
        //    if (frm.DialogResult == System.Windows.Forms.DialogResult.Yes)
        //        if (frm.EntidadActual != null)
        //            cmbResidencia.SelectedValue = frm.EntidadActual.ID;
        //        else
        //            cmbResidencia.SelectedIndex = 0;
        //    frm = null;

        //}
        //private void btnAdd_Apto_Click(object sender, EventArgs e)
        //{
        //    //Cargar Tabla enlazada
        //    frmApartamentos frm = new frmApartamentos()
        //    { StartPosition = System.Windows.Forms.FormStartPosition.CenterParent, isAuxiliarTable = true };
        //    //Load data aux cmb
        //    frm.ShowDialog(this);
        //    loadCmb();
        //    if (frm.DialogResult == System.Windows.Forms.DialogResult.Yes)
        //        if (frm.EntidadActual != null)
        //            cmbApto.SelectedValue = frm.EntidadActual.ID;
        //        else
        //            cmbApto.SelectedIndex = 0;
        //    frm = null;
        //}
        //#endregion

        //private void cmbResidencia_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cargarcmbAuxiliar();
        //}

        //private void cmbResidencia_ValueMemberChanged(object sender, EventArgs e)
        //{
        //    cargarcmbAuxiliar();
        //}

        //private void cargarcmbAuxiliar()
        //{
        //    if (cmbResidencia.SelectedIndex >= 0)
        //    {
        //        if (!cmbResidencia.SelectedValue.GetType().Name.Equals("Residencias"))
        //        {
        //            idresidencia = (int)cmbResidencia.SelectedValue;
        //            loadCmb2(idresidencia);
        //        }

        //    }
        //}
    }
}
