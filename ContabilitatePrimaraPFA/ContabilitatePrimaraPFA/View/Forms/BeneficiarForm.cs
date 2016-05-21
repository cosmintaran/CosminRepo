using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Queries.Core.Domain;
using Queries.Persitence;

namespace View.View.Forms
{
    public partial class BeneficiarForm : Form
    {

        #region Members Declaration Area

        public int GetBeneficiarId { get; private set; }
        private List<Beneficiar> _mlBeneficiari;
        public static readonly object Padlock = new object();
        private static BeneficiarForm _mBeneficiarForm;
        private AutoCompleteStringCollection _names;
        private Beneficiar _beneficiar;
        #endregion

        #region Initialization Area
        private BeneficiarForm()
        {
            InitializeComponent();
            
            GetBeneficiarId = 0;
            FillComboBox();
            GetBeneficiariForDb();
            AutoCompleteText();
            RadioButtonController();
        }

        public static BeneficiarForm GetBeneficiarInstance 
        {
            get
            {
                lock (Padlock)
                {
                    if (_mBeneficiarForm == null)
                    {
                        _mBeneficiarForm = new BeneficiarForm();
                    }
                }
                return _mBeneficiarForm;
            }
        }

        #endregion

        #region Command Area
        private void rbttPersFizica_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonController();
        }

        private void rbPersJuridica_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonController();
        }

        private void bttOK_Click(object sender, EventArgs e)
        {
            if (GetBeneficiarId > 0 && _beneficiar!= null)
            {
                PrepareObject();
                UpDate();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                _beneficiar = new Beneficiar();
                PrepareObject();
                Save();
                DialogResult = DialogResult.OK;
                Close();
            }
            CleanForm();
        }

        private void txtDenumire_Leave(object sender, EventArgs e)
        {
            int index = -1;
            foreach (var ben in _mlBeneficiari)
            {
                if ((ben.Nume) == txtDenumire.Text)
                {
                    GetBeneficiarId = ben.BeneficiarId;
                    index++;
                    break;
                }
                index++;
            }

            if (GetBeneficiarId <= 0) return;
            FillForm(index);
        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            CleanForm();
            Close();
        }

        #endregion


        #region Logic Area

        private void GetBeneficiariForDb()
        {
            ContaContext contaContext = new ContaContext();
            UnitOfWork unitOfWork = new UnitOfWork(contaContext);
            _mlBeneficiari =(List<Beneficiar>) unitOfWork.Beneficiari.GetAll();
            unitOfWork.Dispose();
            contaContext.Dispose();
            _names = new AutoCompleteStringCollection();
            foreach (var str in _mlBeneficiari)
                _names.Add(str.Nume);
            

        }

        private void AutoCompleteText()
        {
            txtDenumire.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDenumire.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtDenumire.AutoCompleteCustomSource = _names;
        }

        private void FillForm(int index)
        {
            bool? isPersoanaFizica = _mlBeneficiari[index].PersoanaFizica;
            if ((bool)isPersoanaFizica)
            {
                rbttPersFizica.Checked = true;
                rbPersJuridica.Checked = false;
                cbAtribFiscal.Enabled = false;
                txtRegCom.Enabled = false;
                grBoxActe.Enabled = true;
            }
            else
            {
                rbttPersFizica.Checked = false;
                rbPersJuridica.Checked = true;
                cbAtribFiscal.Enabled = true;
                txtRegCom.Enabled = true;
                grBoxActe.Enabled = false;
            }

            txtDenumire.Text = _mlBeneficiari[index].Nume;
            txtAdresa.Text = _mlBeneficiari[index].Adresa;
            cbAtribFiscal.SelectedItem = _mlBeneficiari[index].AtributFiscal;
            txtCNP.Text = _mlBeneficiari[index].CNP;
            txtRegCom.Text = _mlBeneficiari[index].NrRegComert;
            txtEmail.Text = _mlBeneficiari[index].AdresaEmail;
            txtTelefon.Text = _mlBeneficiari[index].Telefon;
            var tipActId = _mlBeneficiari[index].TipActId;
            if (tipActId != null) cbTipAct.SelectedIndex = (int)tipActId-1;
            txtSerie.Text = _mlBeneficiari[index].Serie;
            txtNumar.Text = _mlBeneficiari[index].Numar;
        }

        private void FillComboBox()
        {
            ContaContext contaContext = new ContaContext();
            UnitOfWork unitOfWork = new UnitOfWork(contaContext);
            
            BindingSource bindTipAct = new BindingSource {DataSource = unitOfWork.TipActe.GetAll()};
            unitOfWork.Dispose();
            contaContext.Dispose();
            cbTipAct.DataSource = bindTipAct;
            cbTipAct.DisplayMember = "TipAct1";
            cbAtribFiscal.Items.Add("");
            cbAtribFiscal.Items.Add("RO");

        }

        private void PrepareObject()
        {
            _beneficiar.Adresa = txtAdresa.Text.Trim();
            _beneficiar.AdresaEmail = txtEmail.Text.Trim();
            _beneficiar.AtributFiscal = cbAtribFiscal.Text;
            _beneficiar.CNP = txtCNP.Text.Trim();
            _beneficiar.NrRegComert = txtRegCom.Text.Trim();
            _beneficiar.Numar = txtNumar.Text.Trim();
            _beneficiar.Nume = txtDenumire.Text.Trim();
            _beneficiar.PersoanaFizica = rbttPersFizica.Checked;
            _beneficiar.Serie = txtSerie.Text.Trim();
            _beneficiar.Telefon = txtTelefon.Text.Trim();
            var tipActId = cbTipAct.SelectedItem as TipAct;
            if (tipActId != null)
                _beneficiar.TipActId = tipActId.TipActId;
            
        }

        private void Save()
        {
            ContaContext contaContext = new ContaContext();
            UnitOfWork unitOfWork = new UnitOfWork(contaContext);
            unitOfWork.Beneficiari.Add(_beneficiar);
            unitOfWork.Complete();
            unitOfWork.Dispose();
        }

        private void UpDate()
        {
            ContaContext contaContext = new ContaContext();
            UnitOfWork unitOfWork = new UnitOfWork(contaContext);
            unitOfWork.Beneficiari.UpdateEntry(_beneficiar);
            unitOfWork.Complete();
            unitOfWork.Dispose();
        }

        private void CleanForm()
        {
            txtAdresa.Text = "";
           txtEmail.Text = "";
            cbAtribFiscal.Text = "";
            txtCNP.Text = "";
            txtCNP.Text = "";
             txtNumar.Text = "";
            txtDenumire.Text = "";
            rbttPersFizica.Checked = true;
            /*  */
            txtSerie.Text = "";
            txtTelefon.Text = "";
            cbTipAct.SelectedText = "";

        }

        private void RadioButtonController()
        {
            if (rbPersJuridica.Checked)
            {
                grBoxActe.Enabled = false;
                cbAtribFiscal.Enabled = true;
                txtRegCom.Enabled = true;
            }

            else if (rbttPersFizica.Checked)
            {
                grBoxActe.Enabled = true;
                cbAtribFiscal.Enabled = false;
                txtRegCom.Enabled = false;
            }
        }

        #endregion


    }
}
