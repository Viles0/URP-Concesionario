namespace URP
{
    partial class VehiculoFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculoFrm));
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.cbCilindraje = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxPorsche = new System.Windows.Forms.PictureBox();
            this.pictureBoxAudi = new System.Windows.Forms.PictureBox();
            this.pictureBoxBmw = new System.Windows.Forms.PictureBox();
            this.pictureBoxFerrari = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPorsche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBmw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFerrari)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMarca
            // 
            this.cbMarca.BackColor = System.Drawing.Color.DimGray;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(11, 187);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(170, 28);
            this.cbMarca.TabIndex = 0;
            this.cbMarca.Text = "--Marca--";
            this.cbMarca.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // cbModelo
            // 
            this.cbModelo.BackColor = System.Drawing.Color.Gray;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(11, 236);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(170, 28);
            this.cbModelo.TabIndex = 2;
            this.cbModelo.Text = "--Modelo--";
            this.cbModelo.SelectedIndexChanged += new System.EventHandler(this.cbModelo_SelectedIndexChanged);
            // 
            // cbAño
            // 
            this.cbAño.BackColor = System.Drawing.Color.Gray;
            this.cbAño.FormattingEnabled = true;
            this.cbAño.Location = new System.Drawing.Point(11, 282);
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(170, 28);
            this.cbAño.TabIndex = 3;
            this.cbAño.Text = "--Año--";
            this.cbAño.SelectedIndexChanged += new System.EventHandler(this.cbAño_SelectedIndexChanged);
            // 
            // cbColor
            // 
            this.cbColor.BackColor = System.Drawing.Color.Gray;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(12, 327);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(170, 28);
            this.cbColor.TabIndex = 4;
            this.cbColor.Text = "--Color--";
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // cbCilindraje
            // 
            this.cbCilindraje.BackColor = System.Drawing.Color.Gray;
            this.cbCilindraje.FormattingEnabled = true;
            this.cbCilindraje.Location = new System.Drawing.Point(12, 371);
            this.cbCilindraje.Name = "cbCilindraje";
            this.cbCilindraje.Size = new System.Drawing.Size(170, 28);
            this.cbCilindraje.TabIndex = 5;
            this.cbCilindraje.Text = "--Cilindraje--";
            this.cbCilindraje.SelectedIndexChanged += new System.EventHandler(this.cbMarca_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(718, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 43);
            this.button2.TabIndex = 7;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBoxPorsche
            // 
            this.pictureBoxPorsche.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPorsche.Image")));
            this.pictureBoxPorsche.Location = new System.Drawing.Point(247, 92);
            this.pictureBoxPorsche.Name = "pictureBoxPorsche";
            this.pictureBoxPorsche.Size = new System.Drawing.Size(259, 177);
            this.pictureBoxPorsche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPorsche.TabIndex = 8;
            this.pictureBoxPorsche.TabStop = false;
            this.pictureBoxPorsche.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxAudi
            // 
            this.pictureBoxAudi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAudi.Image")));
            this.pictureBoxAudi.Location = new System.Drawing.Point(572, 92);
            this.pictureBoxAudi.Name = "pictureBoxAudi";
            this.pictureBoxAudi.Size = new System.Drawing.Size(289, 177);
            this.pictureBoxAudi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAudi.TabIndex = 9;
            this.pictureBoxAudi.TabStop = false;
            this.pictureBoxAudi.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBoxBmw
            // 
            this.pictureBoxBmw.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBmw.Image")));
            this.pictureBoxBmw.Location = new System.Drawing.Point(247, 309);
            this.pictureBoxBmw.Name = "pictureBoxBmw";
            this.pictureBoxBmw.Size = new System.Drawing.Size(285, 177);
            this.pictureBoxBmw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBmw.TabIndex = 10;
            this.pictureBoxBmw.TabStop = false;
            this.pictureBoxBmw.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxFerrari
            // 
            this.pictureBoxFerrari.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFerrari.Image")));
            this.pictureBoxFerrari.Location = new System.Drawing.Point(572, 309);
            this.pictureBoxFerrari.Name = "pictureBoxFerrari";
            this.pictureBoxFerrari.Size = new System.Drawing.Size(259, 177);
            this.pictureBoxFerrari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFerrari.TabIndex = 11;
            this.pictureBoxFerrari.TabStop = false;
            this.pictureBoxFerrari.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(443, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ir a Pago";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.Gray;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(11, 416);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(170, 28);
            this.cbEstado.TabIndex = 13;
            this.cbEstado.Text = "--Estado--";
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // VehiculoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxFerrari);
            this.Controls.Add(this.pictureBoxBmw);
            this.Controls.Add(this.pictureBoxAudi);
            this.Controls.Add(this.pictureBoxPorsche);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbCilindraje);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbAño);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbMarca);
            this.Name = "VehiculoFrm";
            this.Text = "Vehiculo";
            this.Load += new System.EventHandler(this.VehiculoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPorsche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAudi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBmw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFerrari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbAño;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.ComboBox cbCilindraje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxPorsche;
        private System.Windows.Forms.PictureBox pictureBoxAudi;
        private System.Windows.Forms.PictureBox pictureBoxBmw;
        private System.Windows.Forms.PictureBox pictureBoxFerrari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbEstado;
    }
}