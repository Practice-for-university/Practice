using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_2._0.Модели
{
    internal class WriterInGreeder: INotifyPropertyChanged
    {
        private string _Name = "Проба";
        public string Name
        {
            get { return _Name; }
            set {
                if (_Name == value)
                    return;
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _C ="0.1";
        public string C 
        {
            get { return _C; }
            set
            {
                if (_C == value)
                    return;
                _C = value;
                OnPropertyChanged("C");
            }
        }
        
        private string _Si = "0.1";
        public string Si
        {
            get { return _Si; }
            set
            {
                if (_Si == value)
                    return;
                _Si = value;
                OnPropertyChanged("Si");
            }
        }

        private string _Mn = "0.1";
        public string Mn
        {
            get { return _Mn; }
            set
            {
                if (_Mn == value)
                    return;
                _Mn = value;
                OnPropertyChanged("Mn");
            }
        }

        private string _Ni = "0.1";
        public string Ni
        {
            get { return _Ni; }
            set
            {
                if (_Ni == value)
                    return;
                _Ni = value;
                OnPropertyChanged("Ni");
            }
        }

        private string _Mo = "0.1";
        public string Mo
        {
            get { return _Mo; }
            set
            {
                if (_Mo == value)
                    return;
                _Mo = value;
                OnPropertyChanged("Mo");
            }
        }

        private string _Cr = "0.1";
        public string Cr
        {
            get { return _Cr; }
            set
            {
                if (_Cr == value)
                    return;
                _Cr = value;
                OnPropertyChanged("Cr");
            }
        }

        private string _Cu = "0.1";
        public string Cu
        {
            get { return _Cu; }
            set
            {
                if (_Cu == value)
                    return;
                _Cu = value;
                OnPropertyChanged("Cu");
            }
        }

        private string _V = "0.1";
        public string V
        {
            get { return _V; }
            set
            {
                if (_V == value)
                    return;
                _V = value;
                OnPropertyChanged("V");
            }
        }

        private string _B = "0.1";
        public string B
        {
            get { return _B; }
            set
            {
                if (_B == value)
                    return;
                _B = value;
                OnPropertyChanged("B");
            }
        }
        
        //-------------------------------------------

        private string _Ceq;
        public string Ceq
        {
            get { return _Ceq; }
            set
            {
                if (_Ceq == value)
                    return;
                _Ceq = value;
                OnPropertyChanged("Ceq");
            }
        }

        private string _SET;
        public string SET
        {
            get { return _SET; }
            set
            {
                if (_SET == value)
                    return;
                _SET = value;
                OnPropertyChanged("SET");
            }
        }

        private string _Pct;
        public string Pct
        {
            get { return _Pct; }
            set
            {
                if (_Pct == value)
                    return;
                _Pct = value;
                OnPropertyChanged("Pct");
            }
        }

        //------------------------------------------------------

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
