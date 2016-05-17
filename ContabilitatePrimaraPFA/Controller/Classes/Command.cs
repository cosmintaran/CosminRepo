namespace Controller.Classes
{
    using System.ComponentModel;

    public abstract class Command : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private bool _enabled, _visble;
        private string _displaydName, _key;

        public string Key { get;  set; }

        public string DisplaydName
        {
            get { return _displaydName; }
            set
            {
                // ReSharper disable once RedundantCheckBeforeAssignment
                if (_displaydName != value)
                    _displaydName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DisplayName"));
            }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set
            {
                if (_enabled == value) return;
                _enabled = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Enabled"));
            }
        }

        public bool Visible
        {
            get { return _visble; }
            set
            {
                if (_visble == value) return;
                _visble = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Visible"));
            }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs arg)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, arg);
        }

        public abstract void Execute();
       
    }
}
