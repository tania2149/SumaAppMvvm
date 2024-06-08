using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SumaAppMvvm.ViewModels
{
    public class SumaViewModel : INotifyPropertyChanged
    {
        private string _resultado;

        public string Resultado
        {
            get => _resultado;
            set
            {
                _resultado = value;
                OnPropertyChanged(nameof(Resultado));
            }
        }

        public ICommand SumarCommand => new Command(() =>
        {
            if (string.IsNullOrEmpty(Valor1) || string.IsNullOrEmpty(Valor2))
            {
                Resultado = "Por favor ingrese ambos valores.";
            }
            else
            {
                Resultado = (int.Parse(Valor1) + int.Parse(Valor2)).ToString();
            }
        });

        public ICommand LimpiarCommand => new Command(() =>
        {
            Valor1 = string.Empty;
            Valor2 = string.Empty;
            Resultado = string.Empty;
        });

        private string _valor1;
        public string Valor1
        {
            get => _valor1;
            set
            {
                _valor1 = value;
                OnPropertyChanged(nameof(Valor1));
            }
        }

        private string _valor2;
        public string Valor2
        {
            get => _valor2;
            set
            {
                _valor2 = value;
                OnPropertyChanged(nameof(Valor2));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
