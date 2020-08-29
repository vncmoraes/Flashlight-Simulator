using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Lanterna
{
    class Bateria : INotifyPropertyChanged
    {
        private int nivelBateria;
        private Timer timer;
        public event PropertyChangedEventHandler PropertyChanged;

        public Bateria() 
        {
            this.nivelBateria = 100;
            this.timer = new Timer();
            this.timer.Tick += new EventHandler(atualizarNivelBateria);
            this.timer.Interval = 1000;
            this.timer.Start();
            this.timer.Enabled = false;
        }
        public string getNivelBateria() 
        {
            return nivelBateria.ToString() + "%";
        }
        private void atualizarNivelBateria(object sender, EventArgs a) 
        {
            nivelBateria -= 1;
            BatteryPropertyChanged();
            if (nivelBateria == 0) timer.Enabled = false;
        }
        public void usandoBateria(bool isOn) 
        {
            if (isOn && nivelBateria > 0)
                timer.Enabled = true;
            else
                timer.Enabled = false;
        }
        private void BatteryPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
