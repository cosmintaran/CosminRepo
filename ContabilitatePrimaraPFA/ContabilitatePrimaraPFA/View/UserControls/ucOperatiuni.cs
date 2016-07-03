using System.Windows.Forms;
using Queries.Core.Domain;
using Queries.Persitence.Repositories;
using Queries.Persitence;

namespace ContaPFA.View.UserControls
{
    public partial class ucOperatiuni : UserControl
    {
        #region Declared Members
        private static ucOperatiuni m_instance = null;
        public static readonly object padlock = new object();
        private Incasare _incasare; 
        #endregion

        private ucOperatiuni()
        {
            InitializeComponent();
            ClearForm();
            _incasare = new Incasare();
            FillCombobox();
            FillGridView();
        }

        #region Init Area
        public static ucOperatiuni GetUiOperatiuni
        {
          get
            {
                lock(padlock)
                {
                    if(m_instance == null)
                        m_instance = new ucOperatiuni();
                }
                return m_instance;
            }
        }
        #endregion

        #region Command region
        private void bttNew_Click(object sender, System.EventArgs e)
        {
            grBoxForm.Enabled = true;
            bttAdd.Enabled = true;
            bttClear.Enabled = true;
        }

        private void bttAdd_Click(object sender, System.EventArgs e)
        {
            ClearForm();
        }

        #endregion

        #region Logic

        private void ClearForm()
        {
            rbIncasare.Checked = true;
            rbPlata.Checked = false;
            checkTVA.Checked = false;
            cbTipDoc.SelectedIndex = -1;
            txtNumar.Text = "";
            txtSerie.Text = "";
            txtSuma.Text = "";
            txtCotaTVA.Text = "";
            txtFelOperatiune.Text = "";
            txtContract.Text = "";
        }

        private void FillCombobox()
        {
            /*var bindTipAct = new BindingSource();
            var contaContext = new ContaContext();
            var unitOfWork = new UnitOfWork(contaContext);

            bindTipAct.DataSource = unitOfWork.TipActe.GetAll();
            cbTipDoc.DataSource = bindTipAct;
            cbTipDoc.DisplayMember = "TipAct1";*/

            cbTipDoc.Items.Add("Chitanta");
            cbTipDoc.Items.Add("Ordin de plata");
            cbTipDoc.Items.Add("Bon de casa");
            cbTipDoc.Items.Add("Extras de cont");


        }

        private void FillGridView()
        {
            
        }
        #endregion


    }
}
