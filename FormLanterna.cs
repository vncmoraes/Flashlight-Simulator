using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanterna
{
    public partial class FormLanterna : Form
    {
        Lanterna lanterna;
        public FormLanterna()
        {
            InitializeComponent();
            this.lanterna = new Lanterna();
            this.lanterna.PropertyChanged += lanterna_PropertyChanged;
        }

        private void btnTrocarBateria_Click(object sender, EventArgs e)
        {
            lanterna.trocarBateria();
            lblNivelBateria.Text = "Bateria: " + lanterna.getNivelBateria();
            if (lanterna.getEstado().Equals("Ligada")) imgOff.SendToBack();
        }

        private void btnLigaDesliga_Click(object sender, EventArgs e)
        {
            lanterna.mudarEstado();
            String estado = lanterna.getEstado();
            lblEstado.Text = estado;

            if (estado.Equals("Ligada"))
            {
                lblEstado.ForeColor = Color.Green;
                if(lanterna.getNivelBateria() != "0%") imgOff.SendToBack();
            }
            else
            {
                lblEstado.ForeColor = Color.Red;
                imgOn.SendToBack();
            }
        }

        private void lanterna_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            String nivelBateria = lanterna.getNivelBateria();
            lblNivelBateria.Text = "Bateria: " + nivelBateria;
            if (nivelBateria == "0%") imgOn.SendToBack();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.Cursor = Cursors.Hand;
        }
    }
}
