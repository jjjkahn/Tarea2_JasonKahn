namespace WindowsFormsApp2
{
    partial class App
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
            this.LBL_titulo = new System.Windows.Forms.Label();
            this.lbl_Marca = new System.Windows.Forms.Label();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.input_marca = new System.Windows.Forms.TextBox();
            this.input_precio = new System.Windows.Forms.TextBox();
            this.input_saldo = new System.Windows.Forms.TextBox();
            this.btn_insertar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_display = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_Compra = new System.Windows.Forms.RadioButton();
            this.radio_Venta = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radio_Manual = new System.Windows.Forms.RadioButton();
            this.radio_Automatico = new System.Windows.Forms.RadioButton();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_titulo
            // 
            this.LBL_titulo.AutoSize = true;
            this.LBL_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.LBL_titulo.Location = new System.Drawing.Point(116, 50);
            this.LBL_titulo.Name = "LBL_titulo";
            this.LBL_titulo.Size = new System.Drawing.Size(113, 29);
            this.LBL_titulo.TabIndex = 0;
            this.LBL_titulo.Text = "Su Carro";
            // 
            // lbl_Marca
            // 
            this.lbl_Marca.AutoSize = true;
            this.lbl_Marca.Location = new System.Drawing.Point(78, 249);
            this.lbl_Marca.Name = "lbl_Marca";
            this.lbl_Marca.Size = new System.Drawing.Size(37, 13);
            this.lbl_Marca.TabIndex = 5;
            this.lbl_Marca.Text = "Marca";
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(78, 286);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_Precio.TabIndex = 6;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Location = new System.Drawing.Point(81, 397);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(34, 13);
            this.lbl_Saldo.TabIndex = 7;
            this.lbl_Saldo.Text = "Saldo";
            // 
            // input_marca
            // 
            this.input_marca.Location = new System.Drawing.Point(184, 249);
            this.input_marca.Name = "input_marca";
            this.input_marca.Size = new System.Drawing.Size(100, 20);
            this.input_marca.TabIndex = 8;
            this.input_marca.TextChanged += new System.EventHandler(this.input_marca_TextChanged);
            // 
            // input_precio
            // 
            this.input_precio.Location = new System.Drawing.Point(184, 286);
            this.input_precio.Name = "input_precio";
            this.input_precio.Size = new System.Drawing.Size(100, 20);
            this.input_precio.TabIndex = 9;
            this.input_precio.TextChanged += new System.EventHandler(this.input_precio_TextChanged);
            // 
            // input_saldo
            // 
            this.input_saldo.Location = new System.Drawing.Point(184, 389);
            this.input_saldo.Name = "input_saldo";
            this.input_saldo.Size = new System.Drawing.Size(100, 20);
            this.input_saldo.TabIndex = 10;
            this.input_saldo.TextChanged += new System.EventHandler(this.input_saldo_TextChanged);
            // 
            // btn_insertar
            // 
            this.btn_insertar.Location = new System.Drawing.Point(184, 331);
            this.btn_insertar.Name = "btn_insertar";
            this.btn_insertar.Size = new System.Drawing.Size(99, 36);
            this.btn_insertar.TabIndex = 11;
            this.btn_insertar.Text = "Insertar";
            this.btn_insertar.UseVisualStyleBackColor = true;
            this.btn_insertar.Click += new System.EventHandler(this.btn_insertar_Click);
            this.btn_insertar.MouseLeave += new System.EventHandler(this.btn_insertar_MouseLeave);
            this.btn_insertar.MouseHover += new System.EventHandler(this.btn_insertar_MouseHover);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(463, 158);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(292, 252);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_display
            // 
            this.btn_display.Location = new System.Drawing.Point(468, 93);
            this.btn_display.Name = "btn_display";
            this.btn_display.Size = new System.Drawing.Size(98, 42);
            this.btn_display.TabIndex = 13;
            this.btn_display.Text = "Display";
            this.btn_display.UseVisualStyleBackColor = true;
            this.btn_display.Click += new System.EventHandler(this.btn_display_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_Compra);
            this.panel1.Controls.Add(this.radio_Venta);
            this.panel1.Location = new System.Drawing.Point(70, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(169, 47);
            this.panel1.TabIndex = 14;
            // 
            // radio_Compra
            // 
            this.radio_Compra.AutoSize = true;
            this.radio_Compra.Location = new System.Drawing.Point(100, 16);
            this.radio_Compra.Name = "radio_Compra";
            this.radio_Compra.Size = new System.Drawing.Size(61, 17);
            this.radio_Compra.TabIndex = 1;
            this.radio_Compra.TabStop = true;
            this.radio_Compra.Text = "Compra";
            this.radio_Compra.UseVisualStyleBackColor = true;
            this.radio_Compra.CheckedChanged += new System.EventHandler(this.radio_Compra_CheckedChanged);
            // 
            // radio_Venta
            // 
            this.radio_Venta.AutoSize = true;
            this.radio_Venta.Location = new System.Drawing.Point(3, 17);
            this.radio_Venta.Name = "radio_Venta";
            this.radio_Venta.Size = new System.Drawing.Size(53, 17);
            this.radio_Venta.TabIndex = 0;
            this.radio_Venta.TabStop = true;
            this.radio_Venta.Text = "Venta";
            this.radio_Venta.UseVisualStyleBackColor = true;
            this.radio_Venta.CheckedChanged += new System.EventHandler(this.radio_Venta_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio_Manual);
            this.panel2.Controls.Add(this.radio_Automatico);
            this.panel2.Location = new System.Drawing.Point(70, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 48);
            this.panel2.TabIndex = 15;
            // 
            // radio_Manual
            // 
            this.radio_Manual.AutoSize = true;
            this.radio_Manual.Location = new System.Drawing.Point(101, 17);
            this.radio_Manual.Name = "radio_Manual";
            this.radio_Manual.Size = new System.Drawing.Size(60, 17);
            this.radio_Manual.TabIndex = 1;
            this.radio_Manual.TabStop = true;
            this.radio_Manual.Text = "Manual";
            this.radio_Manual.UseVisualStyleBackColor = true;
            this.radio_Manual.CheckedChanged += new System.EventHandler(this.radio_Manual_CheckedChanged);
            // 
            // radio_Automatico
            // 
            this.radio_Automatico.AutoSize = true;
            this.radio_Automatico.Location = new System.Drawing.Point(3, 17);
            this.radio_Automatico.Name = "radio_Automatico";
            this.radio_Automatico.Size = new System.Drawing.Size(78, 17);
            this.radio_Automatico.TabIndex = 0;
            this.radio_Automatico.TabStop = true;
            this.radio_Automatico.Text = "Automatico";
            this.radio_Automatico.UseVisualStyleBackColor = true;
            this.radio_Automatico.CheckedChanged += new System.EventHandler(this.radio_Automatico_CheckedChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(641, 93);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(105, 42);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_display);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_insertar);
            this.Controls.Add(this.input_saldo);
            this.Controls.Add(this.input_precio);
            this.Controls.Add(this.input_marca);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Marca);
            this.Controls.Add(this.LBL_titulo);
            this.Name = "App";
            this.Text = "Aplicacion Su Carro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_titulo;
        private System.Windows.Forms.Label lbl_Marca;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.TextBox input_marca;
        private System.Windows.Forms.TextBox input_precio;
        private System.Windows.Forms.TextBox input_saldo;
        private System.Windows.Forms.Button btn_insertar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radio_Compra;
        private System.Windows.Forms.RadioButton radio_Venta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radio_Manual;
        private System.Windows.Forms.RadioButton radio_Automatico;
        private System.Windows.Forms.Button btn_Clear;
    }
}

