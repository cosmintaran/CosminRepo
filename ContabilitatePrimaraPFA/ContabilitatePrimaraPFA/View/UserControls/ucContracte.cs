using System.Globalization;
using ContabilitatePrimaraPFA.View.Classes;

namespace ContabilitatePrimaraPFA.View.UserControls
{
    using System;
    using System.Windows.Forms;
    using Queries.Core.Domain;
    using Queries.Persitence;

    public partial class UcContracte : UserControl
    {
        #region Declared Members
        private static UcContracte _mContracte;
        private static readonly object Padlock = new object();
        private Contract _contract;
        private const int DefValue = 1;
        #endregion

        #region Init Area
        public static UcContracte GetUiContracte
        {
            get
            {
                lock(Padlock)
                {
                    return _mContracte ?? (_mContracte = new UcContracte());
                }
            }
            
        }
        private UcContracte()
        {
            InitializeComponent();
            FillGridView(SearchCriteria.An, DateTime.Today.Year.ToString());
        }
        #endregion

        private void gridViewContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bttDeleteContract.Enabled) return;
            bttDeleteContract.Enabled = true;

        }

        private void gridViewContract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow iterator in gridViewContract.SelectedRows)
            {
                selectedRow = iterator;
            }

            var selRow = selectedRow?.Cells["ContractId"].Value;
            if (selRow == null) return;

            ContaContext contaContext = new ContaContext();
            UnitOfWork unitOfWork = new UnitOfWork(contaContext);

            _contract = unitOfWork.Contracte.Get((int) selRow);
            unitOfWork.Dispose();
            contaContext.Dispose();

            if (_contract == null) return;
            // Completeaza formul cu datele din baza de date
            txtNrContr.Text = _contract.NrContract;
            txtSuma.Text = _contract.Suma.ToString(CultureInfo.InstalledUICulture);
            txtObiect.Text = _contract.ObiectulContractului;
            txtObs.Text = _contract.Observatii;
            dateTimePickerContr.Value = _contract.Data;

            //Set enable disabe or visibilty for controls
            bttNewContract.Enabled = false;
            bttDeleteContract.Enabled = false;
            grBoxContract.Enabled = true;
            bttEdit.Visible = true;
            bttCancel.Visible = true;
            bttSave.Visible = false;
            bttClear.Visible = false;
        }

        private void bttNewContract_Click(object sender, EventArgs e)
        {
            _contract = new Contract();

            if (grBoxContract == null || bttDeleteContract == null || bttNewContract == null) return;
            
                grBoxContract.Enabled = true;
                bttNewContract.Enabled = false;
                bttDeleteContract.Enabled = false;
            
        }

        private void bttDeleteContract_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow iterator in gridViewContract.SelectedRows)
            {
                selectedRow = iterator;
            }

            var selRow = selectedRow?.Cells["ContractId"].Value;

            if (selRow == null) return;
            ContaContext contaContext = new ContaContext();
            UnitOfWork unityOfWork = new UnitOfWork(contaContext);

            Contract contract = unityOfWork.Contracte.Get((int) selRow);
            if (contract == null) return;
            var userConfirm =
                MessageBox.Show(
                    @"Confirmati stergerea din baza de date a contractului cu nr. " + contract.NrContract + @"/" +
                    contract.Data, @"Delete confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userConfirm == DialogResult.Yes)
            {
                unityOfWork.Contracte.Remove(contract);
                unityOfWork.Complete();
                unityOfWork.Dispose();
                contaContext.Dispose();
                bttDeleteContract.Enabled = false;
                //FillGridView(SearchDocCriteria.AnDoc, DateTime.Now.Year.ToString());// TODO implementeaza functia vezi ce e cu metoda find din framework 

            }
            else
            {
                bttDeleteContract.Enabled = false;
                unityOfWork.Dispose();
                contaContext.Dispose();
            }
        }

        private void bttSearchContract_Click(object sender, EventArgs e)
        {

        }

        private void bttBeneficiar_Click(object sender, EventArgs e)
        {

        }
        private void bttEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled)) return;

            PrepareObject();
            ContaContext contaContext = new ContaContext();
            UnitOfWork unitOfWork = new UnitOfWork(contaContext);
            unitOfWork.Contracte.UpdateEntry(_contract);
            unitOfWork.Complete();
            unitOfWork.Dispose();

            FillGridView(SearchCriteria.An, DateTime.Today.Year.ToString());

            ClearFormContract();

            bttClear.Visible = true;
            bttClear.Enabled = true;
            bttSave.Visible = true;
            bttSave.Enabled = true;
            bttEdit.Visible = false;
            bttCancel.Visible = false;
            bttNewContract.Enabled = true;
            bttDeleteContract.Enabled = false;
            grBoxContract.Enabled = false;

        }

        private void bttCancel_Click(object sender, EventArgs e)
        {
            ClearFormContract();
            bttClear.Visible = true;
            bttNewContract.Visible = true;
            bttEdit.Visible = false;
            bttCancel.Visible = false;
            bttNewContract.Enabled = true;
            bttDeleteContract.Enabled = false;
            grBoxContract.Enabled = false;
            _contract = new Contract();
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearFormContract();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            PrepareObject();
            ContaContext contaContext = new ContaContext();
            UnitOfWork unityOfWork = new UnitOfWork(contaContext);
            unityOfWork.Contracte.Add(_contract);
            unityOfWork.Complete();
            unityOfWork.Dispose();
            contaContext.Dispose();
            grBoxContract.Enabled = false;
            bttNewContract.Enabled = true;
        }


        #region Logic Area

        private void PrepareObject()
        {
            _contract.NrContract = txtNrContr.Text;
            _contract.Data = dateTimePickerContr.Value;
            _contract.Suma = decimal.Parse(txtSuma.Text);
            _contract.ObiectulContractului = txtObiect.Text;
            //Setarea se face in bttBeneficiar
            _contract.BeneficiarId = DefValue; // Initializam campul cu  valoare default daca nu se alege beneficiarul 
            _contract.Observatii = txtObs.Text;
        }

        private void ClearFormContract()
        {
            txtNrContr.Text = "";
            txtObiect.Text = "";
            txtObs.Text = "";
            txtSuma.Text = "";
            _contract.BeneficiarId = DefValue;
            dateTimePickerContr.Value = DateTime.Today;
        }

        private void FillGridView(SearchCriteria criteria, string key)
        {
            try
            {
                ContaContext conta = new ContaContext();
                UnitOfWork unityOfWork = new UnitOfWork(conta);

                BindingSource bindingSource;

                #region Switch 
                switch (criteria)
                {
                    case SearchCriteria.An:

                        try
                        {
                            int year = int.Parse(key);
                            bindingSource = new BindingSource
                            {
                                DataSource = unityOfWork.Contracte.GetContractByYear(year)
                            };
                        }
                        catch (Exception)
                        {
                            return;
                        }
                        break;
                    case SearchCriteria.NrContract:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrareByContract(key) };
                        break;
                    case SearchCriteria.NrDoc:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByNrDocumentatie(key) };
                        break;
                    case SearchCriteria.NumeBeneficiar:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByBeneficiarName(key) };
                        break;
                    default:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Lucrari.GetLucrariByYear(key) };
                        break;
                }
                #endregion Switch

                // ReSharper disable once ConstantConditionalAccessQualifier
                if (bindingSource?.DataSource == null) return;
                gridViewContract.DataSource = bindingSource;
                if (gridViewContract.Columns["LucrareId"] == null)
                {
                    gridViewContract.Rows.Clear();
                    gridViewContract.Refresh();
                }
                else
                {
                    var dataGridViewColumn = gridViewContract.Columns["LucrareId"];
                    dataGridViewColumn.Visible = false;
                }

            }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        #endregion LogicArea


    }
}
