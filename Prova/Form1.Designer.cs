namespace Prova
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rndSluxo = new System.Windows.Forms.RadioButton();
            this.rdnLuxo = new System.Windows.Forms.RadioButton();
            this.rdnMedio = new System.Windows.Forms.RadioButton();
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbLavandeia = new System.Windows.Forms.CheckBox();
            this.chbPasseio = new System.Windows.Forms.CheckBox();
            this.chbAlmoco = new System.Windows.Forms.CheckBox();
            this.chbTranslado = new System.Windows.Forms.CheckBox();
            this.chbSeguro = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ncdAdulto = new System.Windows.Forms.NumericUpDown();
            this.ncdCriancas = new System.Windows.Forms.NumericUpDown();
            this.ncdDiaria = new System.Windows.Forms.NumericUpDown();
            this.btnReserva = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncdAdulto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncdCriancas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncdDiaria)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o Destino:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rndSluxo);
            this.groupBox1.Controls.Add(this.rdnLuxo);
            this.groupBox1.Controls.Add(this.rdnMedio);
            this.groupBox1.Controls.Add(this.rdbSimples);
            this.groupBox1.Location = new System.Drawing.Point(27, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Quarto";
            // 
            // rndSluxo
            // 
            this.rndSluxo.AutoSize = true;
            this.rndSluxo.Location = new System.Drawing.Point(19, 99);
            this.rndSluxo.Name = "rndSluxo";
            this.rndSluxo.Size = new System.Drawing.Size(79, 17);
            this.rndSluxo.TabIndex = 3;
            this.rndSluxo.TabStop = true;
            this.rndSluxo.Text = "Super Luxo";
            this.rndSluxo.UseVisualStyleBackColor = true;
            // 
            // rdnLuxo
            // 
            this.rdnLuxo.AutoSize = true;
            this.rdnLuxo.Location = new System.Drawing.Point(19, 75);
            this.rdnLuxo.Name = "rdnLuxo";
            this.rdnLuxo.Size = new System.Drawing.Size(48, 17);
            this.rdnLuxo.TabIndex = 2;
            this.rdnLuxo.TabStop = true;
            this.rdnLuxo.Text = "Luxo";
            this.rdnLuxo.UseVisualStyleBackColor = true;
            // 
            // rdnMedio
            // 
            this.rdnMedio.AutoSize = true;
            this.rdnMedio.Location = new System.Drawing.Point(19, 52);
            this.rdnMedio.Name = "rdnMedio";
            this.rdnMedio.Size = new System.Drawing.Size(54, 17);
            this.rdnMedio.TabIndex = 1;
            this.rdnMedio.TabStop = true;
            this.rdnMedio.Text = "Médio";
            this.rdnMedio.UseVisualStyleBackColor = true;
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Location = new System.Drawing.Point(19, 29);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(61, 17);
            this.rdbSimples.TabIndex = 0;
            this.rdbSimples.TabStop = true;
            this.rdbSimples.Text = "Simples";
            this.rdbSimples.UseVisualStyleBackColor = true;
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Items.AddRange(new object[] {
            "Londres",
            "Paris",
            "Nova York",
            "Barcelona"});
            this.cbDestino.Location = new System.Drawing.Point(27, 51);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 21);
            this.cbDestino.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbLavandeia);
            this.groupBox2.Controls.Add(this.chbPasseio);
            this.groupBox2.Controls.Add(this.chbAlmoco);
            this.groupBox2.Controls.Add(this.chbTranslado);
            this.groupBox2.Controls.Add(this.chbSeguro);
            this.groupBox2.Location = new System.Drawing.Point(27, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 152);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços Opcionais";
            // 
            // chbLavandeia
            // 
            this.chbLavandeia.AutoSize = true;
            this.chbLavandeia.Location = new System.Drawing.Point(18, 122);
            this.chbLavandeia.Name = "chbLavandeia";
            this.chbLavandeia.Size = new System.Drawing.Size(76, 17);
            this.chbLavandeia.TabIndex = 4;
            this.chbLavandeia.Text = "Lavandeia";
            this.chbLavandeia.UseVisualStyleBackColor = true;
            // 
            // chbPasseio
            // 
            this.chbPasseio.AutoSize = true;
            this.chbPasseio.Location = new System.Drawing.Point(18, 99);
            this.chbPasseio.Name = "chbPasseio";
            this.chbPasseio.Size = new System.Drawing.Size(63, 17);
            this.chbPasseio.TabIndex = 3;
            this.chbPasseio.Text = "Passeio";
            this.chbPasseio.UseVisualStyleBackColor = true;
            // 
            // chbAlmoco
            // 
            this.chbAlmoco.AutoSize = true;
            this.chbAlmoco.Location = new System.Drawing.Point(18, 76);
            this.chbAlmoco.Name = "chbAlmoco";
            this.chbAlmoco.Size = new System.Drawing.Size(61, 17);
            this.chbAlmoco.TabIndex = 2;
            this.chbAlmoco.Text = "Almoço";
            this.chbAlmoco.UseVisualStyleBackColor = true;
            // 
            // chbTranslado
            // 
            this.chbTranslado.AutoSize = true;
            this.chbTranslado.Location = new System.Drawing.Point(18, 53);
            this.chbTranslado.Name = "chbTranslado";
            this.chbTranslado.Size = new System.Drawing.Size(73, 17);
            this.chbTranslado.TabIndex = 1;
            this.chbTranslado.Text = "Translado";
            this.chbTranslado.UseVisualStyleBackColor = true;
            // 
            // chbSeguro
            // 
            this.chbSeguro.AutoSize = true;
            this.chbSeguro.Location = new System.Drawing.Point(18, 30);
            this.chbSeguro.Name = "chbSeguro";
            this.chbSeguro.Size = new System.Drawing.Size(60, 17);
            this.chbSeguro.TabIndex = 0;
            this.chbSeguro.Text = "Seguro";
            this.chbSeguro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de Adultos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 424);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número de Crianças";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Número de Diárias";
            // 
            // ncdAdulto
            // 
            this.ncdAdulto.Location = new System.Drawing.Point(148, 389);
            this.ncdAdulto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ncdAdulto.Name = "ncdAdulto";
            this.ncdAdulto.Size = new System.Drawing.Size(81, 20);
            this.ncdAdulto.TabIndex = 6;
            this.ncdAdulto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ncdCriancas
            // 
            this.ncdCriancas.Location = new System.Drawing.Point(148, 421);
            this.ncdCriancas.Name = "ncdCriancas";
            this.ncdCriancas.Size = new System.Drawing.Size(81, 20);
            this.ncdCriancas.TabIndex = 7;
            // 
            // ncdDiaria
            // 
            this.ncdDiaria.Location = new System.Drawing.Point(148, 454);
            this.ncdDiaria.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ncdDiaria.Name = "ncdDiaria";
            this.ncdDiaria.Size = new System.Drawing.Size(81, 20);
            this.ncdDiaria.TabIndex = 8;
            this.ncdDiaria.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(79, 488);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(113, 23);
            this.btnReserva.TabIndex = 9;
            this.btnReserva.Text = "Imprimir Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 520);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.ncdDiaria);
            this.Controls.Add(this.ncdCriancas);
            this.Controls.Add(this.ncdAdulto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncdAdulto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncdCriancas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ncdDiaria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rndSluxo;
        private System.Windows.Forms.RadioButton rdnLuxo;
        private System.Windows.Forms.RadioButton rdnMedio;
        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbLavandeia;
        private System.Windows.Forms.CheckBox chbPasseio;
        private System.Windows.Forms.CheckBox chbAlmoco;
        private System.Windows.Forms.CheckBox chbTranslado;
        private System.Windows.Forms.CheckBox chbSeguro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown ncdAdulto;
        private System.Windows.Forms.NumericUpDown ncdCriancas;
        private System.Windows.Forms.NumericUpDown ncdDiaria;
        private System.Windows.Forms.Button btnReserva;
    }
}

