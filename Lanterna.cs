using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lanterna
{
    class Lanterna : INotifyPropertyChanged
    {
        private bool isOn;
        private Bateria bateria;
        public event PropertyChangedEventHandler PropertyChanged;

        public Lanterna() 
        {
            this.isOn = false;
            this.bateria = new Bateria();
            bateria.PropertyChanged += bateria_PropertyChanged;
        }

        public void mudarEstado() 
        {
            isOn = !isOn;
            bateria.usandoBateria(isOn);
        }
        public void trocarBateria() 
        {
            bateria = new Bateria();
            bateria.PropertyChanged += bateria_PropertyChanged;
            bateria.usandoBateria(isOn);
        }
        public string getEstado() 
        {
            return isOn ? "Ligada" : "Desligada";
        }
        public string getNivelBateria() 
        {
            return bateria.getNivelBateria();
        }

        private void bateria_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TorchPropertyChanged();
        }

        private void TorchPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
