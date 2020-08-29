namespace Lanterna
{
    partial class FormLanterna
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLanterna));
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnTrocarBateria = new System.Windows.Forms.Button();
            this.btnLigaDesliga = new System.Windows.Forms.Button();
            this.lblNivelBateria = new System.Windows.Forms.Label();
            this.imgOff = new System.Windows.Forms.PictureBox();
            this.imgOn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(3, 14);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(250, 28);
            this.lblEstado.TabIndex = 0;
            this.lblEstado.Text = "Desligada";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTrocarBateria
            // 
            this.btnTrocarBateria.BackColor = System.Drawing.Color.White;
            this.btnTrocarBateria.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrocarBateria.Location = new System.Drawing.Point(28, 146);
            this.btnTrocarBateria.Name = "btnTrocarBateria";
            this.btnTrocarBateria.Size = new System.Drawing.Size(199, 28);
            this.btnTrocarBateria.TabIndex = 1;
            this.btnTrocarBateria.Text = "Trocar Bateria";
            this.btnTrocarBateria.UseVisualStyleBackColor = false;
            this.btnTrocarBateria.Click += new System.EventHandler(this.btnTrocarBateria_Click);
            // 
            // btnLigaDesliga
            // 
            this.btnLigaDesliga.BackColor = System.Drawing.Color.White;
            this.btnLigaDesliga.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLigaDesliga.Location = new System.Drawing.Point(28, 112);
            this.btnLigaDesliga.Name = "btnLigaDesliga";
            this.btnLigaDesliga.Size = new System.Drawing.Size(199, 28);
            this.btnLigaDesliga.TabIndex = 2;
            this.btnLigaDesliga.Text = "Ligar/Desligar";
            this.btnLigaDesliga.UseVisualStyleBackColor = false;
            this.btnLigaDesliga.Click += new System.EventHandler(this.btnLigaDesliga_Click);
            // 
            // lblNivelBateria
            // 
            this.lblNivelBateria.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivelBateria.ForeColor = System.Drawing.Color.White;
            this.lblNivelBateria.Location = new System.Drawing.Point(3, 59);
            this.lblNivelBateria.Name = "lblNivelBateria";
            this.lblNivelBateria.Size = new System.Drawing.Size(250, 29);
            this.lblNivelBateria.TabIndex = 3;
            this.lblNivelBateria.Text = "Bateria: 100%";
            this.lblNivelBateria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgOff
            // 
            this.imgOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgOff.Image = global::Lanterna.Properties.Resources.LanternaOff;
            this.imgOff.Location = new System.Drawing.Point(12, 221);
            this.imgOff.Name = "imgOff";
            this.imgOff.Size = new System.Drawing.Size(256, 256);
            this.imgOff.TabIndex = 5;
            this.imgOff.TabStop = false;
            // 
            // imgOn
            // 
            this.imgOn.Image = global::Lanterna.Properties.Resources.LanternaOn;
            this.imgOn.Location = new System.Drawing.Point(12, 221);
            this.imgOn.Name = "imgOn";
            this.imgOn.Size = new System.Drawing.Size(256, 256);
            this.imgOn.TabIndex = 4;
            this.imgOn.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnTrocarBateria);
            this.panel1.Controls.Add(this.btnLigaDesliga);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.lblNivelBateria);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 203);
            this.panel1.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Lanterna.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(224, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseHover += new System.EventHandler(this.btnClose_MouseHover);
            // 
            // FormLanterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(280, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imgOff);
            this.Controls.Add(this.imgOn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLanterna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lanterna";
            ((System.ComponentModel.ISupportInitialize)(this.imgOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnTrocarBateria;
        private System.Windows.Forms.Button btnLigaDesliga;
        private System.Windows.Forms.Label lblNivelBateria;
        private System.Windows.Forms.PictureBox imgOn;
        private System.Windows.Forms.PictureBox imgOff;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClose;
    }
}

