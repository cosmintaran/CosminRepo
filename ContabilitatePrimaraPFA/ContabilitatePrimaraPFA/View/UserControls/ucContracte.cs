
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Globalization;
using System.Windows.Forms;
using ContabilitatePrimaraPFA.View.Classes;
using ContabilitatePrimaraPFA.View.Forms;
using Queries.Core.Domain;
using Queries.Persitence;
using View.View.Forms;

namespace View.View.UserControls
{
    public partial class UcContracte : UserControl
    {
        #region Declared Members
        private static UcContracte _mContracte;
        private static readonly object Padlock = new object();
        private Contract _contract;
        private const int DefValue = 1;
        private FilterCriteria _filter = FilterCriteria.None;
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
            FillGridView(_filter, DateTime.Today.Year.ToString());
        }
        #endregion

        #region Command region
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
                try
                {
                    unityOfWork.Contracte.Remove(contract);
                    unityOfWork.Complete();
                    unityOfWork.Dispose();
                    contaContext.Dispose();
                    bttDeleteContract.Enabled = false;
                    FillGridView(_filter, DateTime.Now.Year.ToString());
                    ClearFormContract();
                }
                catch (DbUpdateException)
                {
                    // ReSharper disable once LocalizableElement
                    MessageBox.Show("Contractul este folosit de o alta intrare din baza de date.\nStergere refuzata", @"Eroare stergere contract", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex) { MessageBox.Show(ex.Message, @"Eroare stergere contract", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
            Dictionary<string, FilterCriteria> mDictionary = new Dictionary<string, FilterCriteria>()
            {
                {"None",FilterCriteria.None}, {"Nr. Contract",FilterCriteria.NrContract}, {"An Contract", FilterCriteria.An },
                { "Nume Beneficiar",FilterCriteria.NumeBeneficiar },{"Valoare Contract",FilterCriteria.Suma }
            };

            FilterForm sel = FilterForm.GetCautaForm(mDictionary);
            var result = sel.ShowDialog();
            if (result != DialogResult.OK) return;           
            var key = sel.SearchKey;
            //if (string.IsNullOrEmpty(key)) return;
            _filter = sel.FilterCriteria;
            FillGridView(_filter, key);

            if (IsFilterd())
            {
                lblFilter.Text = @"Filter On";
                lblFilter.Font = new System.Drawing.Font(lblFilter.Font, System.Drawing.FontStyle.Bold);
            }
            else
            {
                lblFilter.Text = "";
            }
        }

        private void bttBeneficiar_Click(object sender, EventArgs e)
        {
            BeneficiarForm ben = BeneficiarForm.GetBeneficiarInstance;
            var result = ben.ShowDialog();
            if (result != DialogResult.OK) return;
            _contract.BeneficiarId = ben.GetBeneficiarId;
            ben.Dispose();
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

            FillGridView(_filter, DateTime.Today.Year.ToString());

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
            IList<Contract> checkIfIsExist = (IList<Contract>)unityOfWork.Contracte.GetContractByNumberAndYear(_contract.NrContract, DateTime.Today);
            if (checkIfIsExist == null || checkIfIsExist.Count > 0)
            {
                MessageBox.Show(@"Contractul cu numarul " + _contract.NrContract + @" exista deja.",
                    @"Eroare la salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNrContr.Text = "";
                return;
            }
            if (_contract.BeneficiarId <= 0)
            {
                MessageBox.Show(@"Contractul nu poate fi salvat fara Beneficiar.\nVa rugam selectati unul sau creati unul nou ",
                     @"Eroare la salvare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            unityOfWork.Contracte.Add(_contract);
            unityOfWork.Complete();
            unityOfWork.Dispose();
            contaContext.Dispose();
            grBoxContract.Enabled = false;
            bttNewContract.Enabled = true;
            FillGridView(_filter, DateTime.Today.Year.ToString());
        }
        #endregion Command Region

        #region Logic Area

        private void PrepareObject()
        {
            _contract.NrContract = txtNrContr.Text.Trim();
            _contract.Data = dateTimePickerContr.Value;
            _contract.Suma = !string.IsNullOrEmpty(txtSuma.Text) ? decimal.Parse(txtSuma.Text.Trim()) : 0;
            _contract.ObiectulContractului = txtObiect.Text.Trim();
            //Setarea se face in bttBeneficiar
            if(_contract.BeneficiarId == null || _contract.BeneficiarId <= 0 )
                _contract.BeneficiarId = DefValue; // Initializam campul cu  valoare default daca nu se alege beneficiarul 
            _contract.Observatii = txtObs.Text.Trim();
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

        private void FillGridView(FilterCriteria criteria, string key)
        {
            try
            {
                ContaContext conta = new ContaContext();
                UnitOfWork unityOfWork = new UnitOfWork(conta);

                BindingSource bindingSource;

                #region Switch 
                switch (criteria)
                {
                    case FilterCriteria.An:

                        try
                        {
                            int year = int.Parse(key);
                            bindingSource = new BindingSource
                            {
                                DataSource = unityOfWork.Contracte.GetGridViewContractByYear(year)
                            };
                        }
                        catch (Exception)
                        {
                            return;
                        }
                        break;

                    case FilterCriteria.NrContract:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Contracte.GetContractByNumber(key) };
                        break;

                    case FilterCriteria.Suma:
                        try
                        {
                            decimal value = decimal.Parse(key);
                            bindingSource = new BindingSource{ DataSource = unityOfWork.Contracte.GetContractByAmount(value) };
                        }
                        catch (Exception)
                        {
                            return;
                        }
                        
                        break;

                    case FilterCriteria.NumeBeneficiar:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Contracte.GetContractByBeneficiar(key) };
                        break;

                    default:
                        bindingSource = new BindingSource { DataSource = unityOfWork.Contracte.GetContracts() };
                        break;
                }
                #endregion Switch

                // ReSharper disable once ConstantConditionalAccessQualifier
                if (bindingSource?.DataSource == null) return;
                gridViewContract.DataSource = bindingSource;
                if (gridViewContract.Columns["ContractId"] == null)
                {
                    gridViewContract.Rows.Clear();
                    gridViewContract.Refresh();
                }
                else
                {
                    var dataGridViewColumn = gridViewContract.Columns["ContractId"];
                    dataGridViewColumn.Visible = false;
                }

            }
            catch (InvalidOperationException ex) { MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private bool IsFilterd()
        {
            bool isFiltred = _filter != FilterCriteria.None;
            return isFiltred;
        }
        #endregion LogicArea

        #region Validation area


        #endregion

        private void txtNrContr_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNrContr.Text))
            {
                e.Cancel = true;
                txtNrContr.Focus(); errorProviderContracte.SetError(txtNrContr, "Campul Nr. Contract trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtNrContr.Text, "[A-Za-z0-9]"))
            {
                e.Cancel = true;
                txtNrContr.Focus(); errorProviderContracte.SetError(txtNrContr, "Campul contine caractere invalide");
            }
            else
            {
                e.Cancel = false; errorProviderContracte.SetError(txtNrContr, "");
            }
        }

        private void txtSuma_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNrContr.Text))
            {
                e.Cancel = true;
                txtSuma.Focus(); errorProviderContracte.SetError(txtSuma, "Campul Valoare Contract trebuie completat");
            }

            else if (!FormValidator.NamesValidator(txtNrContr.Text, "[0-9]"))
            {
                e.Cancel = true;
                txtSuma.Focus(); errorProviderContracte.SetError(txtSuma, "Campul contine caractere invalide");
            }
            else
            {
                e.Cancel = false; errorProviderContracte.SetError(txtSuma, "");
            }
        }

        private void txtObiect_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNrContr.Text))
            {
                e.Cancel = true;
                txtObiect.Focus(); errorProviderContracte.SetError(txtNrContr, "Campul Obiect Contract trebuie completat");
            }
            else
            {
                e.Cancel = false; errorProviderContracte.SetError(txtObiect, "");
            }

        }
    }
}
