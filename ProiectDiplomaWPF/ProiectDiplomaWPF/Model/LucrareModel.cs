using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDiplomaWPF.ViewModel
{
    class Lucrare :INotifyPropertyChanged
    {
        private string m_AcceptRespins;
        private string m_NrInregOCPI;
        private DateTime m_DataInreg;
        private DateTime m_TermenSolutionare;
        private string m_AvizatorRegistrator;
        private string m_TipLucrare;
        private string m_Nrproiect;
        private string m_Beneficiar;
        private string m_NrCad;
        private string m_UAT;
        private string m_Contract;
        private string m_Receptionat;
        private string m_Observartii;
        
        public string AcceptRespins
        {
            get { return m_AcceptRespins; }
            set 
            {
                m_AcceptRespins = value;
                OnPropertyChanged("AcceptRespins");
            }
        }

        public string NrInregOCPI
        {
            get { return m_NrInregOCPI; }
            set
            {
                m_NrInregOCPI = value;
                OnPropertyChanged("NrInregOCPI");
            }
        }

        public DateTime DataInregistrare
        {
            get { return m_DataInreg; }
            set
            {
                m_DataInreg = value;
                OnPropertyChanged("DataInregistrare");
            }
        }

        public DateTime TermenSolutionare
        {
            get { return m_TermenSolutionare; }
            set
            { 
                value = m_TermenSolutionare;
                OnPropertyChanged("TermenSolutionare");
            }

        }


        public string AvizatorRegistrator
        {
            get { return m_AvizatorRegistrator; }
            set 
            {
                m_AvizatorRegistrator = value;
                OnPropertyChanged("AvizatorRegistrator");
            }
        }


        public string TipLucrare
        {
            get { return m_TipLucrare; }
            set
            {
                m_TipLucrare = value;
                OnPropertyChanged("TipLucrare");
            }
        }

        public string NrProiect
        {
            get { return m_Nrproiect; }
            set 
            {
                m_Nrproiect = value;
                OnPropertyChanged("NrProiect");
            }
        }


        public string Beneficiar
        {
            get { return m_Beneficiar; }
            set 
            {
                m_Beneficiar = value;
                OnPropertyChanged("Beneficiar");
            }
        }

       public string NrCadastral
        {
            get { return m_NrCad; }
            set 
            {
                m_NrCad = value;
                OnPropertyChanged("NrCadastral");
            }
        }

        public string UAT
       {
           get { return m_UAT; }
           set
           {
               m_UAT = value;
               OnPropertyChanged("UAT");
           }
       }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged (string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
