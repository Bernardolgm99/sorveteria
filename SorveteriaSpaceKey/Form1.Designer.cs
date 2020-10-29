namespace SorveteriaSpaceKey
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.rdbCasquinha = new System.Windows.Forms.RadioButton();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.rdbPote = new System.Windows.Forms.RadioButton();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.grbSabor = new System.Windows.Forms.GroupBox();
            this.chkBaunilha = new System.Windows.Forms.CheckBox();
            this.chkMorango = new System.Windows.Forms.CheckBox();
            this.grbCalda = new System.Windows.Forms.GroupBox();
            this.chkCaramelo = new System.Windows.Forms.CheckBox();
            this.chkChocolateQuente = new System.Windows.Forms.CheckBox();
            this.grbTipo.SuspendLayout();
            this.grbSabor.SuspendLayout();
            this.grbCalda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(348, 256);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(140, 59);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // rdbCasquinha
            // 
            this.rdbCasquinha.AutoSize = true;
            this.rdbCasquinha.Location = new System.Drawing.Point(32, 36);
            this.rdbCasquinha.Name = "rdbCasquinha";
            this.rdbCasquinha.Size = new System.Drawing.Size(75, 17);
            this.rdbCasquinha.TabIndex = 1;
            this.rdbCasquinha.TabStop = true;
            this.rdbCasquinha.Text = "Casquinha";
            this.rdbCasquinha.UseVisualStyleBackColor = true;
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.rdbPote);
            this.grbTipo.Controls.Add(this.rdbCasquinha);
            this.grbTipo.Location = new System.Drawing.Point(24, 41);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(221, 129);
            this.grbTipo.TabIndex = 2;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipo";
            // 
            // rdbPote
            // 
            this.rdbPote.AutoSize = true;
            this.rdbPote.Location = new System.Drawing.Point(32, 80);
            this.rdbPote.Name = "rdbPote";
            this.rdbPote.Size = new System.Drawing.Size(47, 17);
            this.rdbPote.TabIndex = 2;
            this.rdbPote.TabStop = true;
            this.rdbPote.Text = "Pote";
            this.rdbPote.UseVisualStyleBackColor = true;
            // 
            // chkChocolate
            // 
            this.chkChocolate.AutoSize = true;
            this.chkChocolate.Location = new System.Drawing.Point(19, 36);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(74, 17);
            this.chkChocolate.TabIndex = 3;
            this.chkChocolate.Text = "Chocolate";
            this.chkChocolate.UseVisualStyleBackColor = true;
            // 
            // grbSabor
            // 
            this.grbSabor.Controls.Add(this.chkBaunilha);
            this.grbSabor.Controls.Add(this.chkMorango);
            this.grbSabor.Controls.Add(this.chkChocolate);
            this.grbSabor.Location = new System.Drawing.Point(24, 218);
            this.grbSabor.Name = "grbSabor";
            this.grbSabor.Size = new System.Drawing.Size(221, 129);
            this.grbSabor.TabIndex = 4;
            this.grbSabor.TabStop = false;
            this.grbSabor.Text = "Sabor";
            // 
            // chkBaunilha
            // 
            this.chkBaunilha.AutoSize = true;
            this.chkBaunilha.Location = new System.Drawing.Point(19, 84);
            this.chkBaunilha.Name = "chkBaunilha";
            this.chkBaunilha.Size = new System.Drawing.Size(67, 17);
            this.chkBaunilha.TabIndex = 5;
            this.chkBaunilha.Text = "Baunilha";
            this.chkBaunilha.UseVisualStyleBackColor = true;
            // 
            // chkMorango
            // 
            this.chkMorango.AutoSize = true;
            this.chkMorango.Location = new System.Drawing.Point(19, 60);
            this.chkMorango.Name = "chkMorango";
            this.chkMorango.Size = new System.Drawing.Size(68, 17);
            this.chkMorango.TabIndex = 4;
            this.chkMorango.Text = "Morango";
            this.chkMorango.UseVisualStyleBackColor = true;
            // 
            // grbCalda
            // 
            this.grbCalda.Controls.Add(this.chkCaramelo);
            this.grbCalda.Controls.Add(this.chkChocolateQuente);
            this.grbCalda.Location = new System.Drawing.Point(308, 41);
            this.grbCalda.Name = "grbCalda";
            this.grbCalda.Size = new System.Drawing.Size(221, 129);
            this.grbCalda.TabIndex = 5;
            this.grbCalda.TabStop = false;
            this.grbCalda.Text = "Calda";
            // 
            // chkCaramelo
            // 
            this.chkCaramelo.AutoSize = true;
            this.chkCaramelo.Location = new System.Drawing.Point(26, 84);
            this.chkCaramelo.Name = "chkCaramelo";
            this.chkCaramelo.Size = new System.Drawing.Size(70, 17);
            this.chkCaramelo.TabIndex = 1;
            this.chkCaramelo.Text = "Caramelo";
            this.chkCaramelo.UseVisualStyleBackColor = true;
            // 
            // chkChocolateQuente
            // 
            this.chkChocolateQuente.AutoSize = true;
            this.chkChocolateQuente.Location = new System.Drawing.Point(26, 36);
            this.chkChocolateQuente.Name = "chkChocolateQuente";
            this.chkChocolateQuente.Size = new System.Drawing.Size(112, 17);
            this.chkChocolateQuente.TabIndex = 0;
            this.chkChocolateQuente.Text = "Chocolate Quente";
            this.chkChocolateQuente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 388);
            this.Controls.Add(this.grbCalda);
            this.Controls.Add(this.grbSabor);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.btnConfirmar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            this.grbSabor.ResumeLayout(false);
            this.grbSabor.PerformLayout();
            this.grbCalda.ResumeLayout(false);
            this.grbCalda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.RadioButton rdbCasquinha;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.RadioButton rdbPote;
        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.GroupBox grbSabor;
        private System.Windows.Forms.CheckBox chkBaunilha;
        private System.Windows.Forms.CheckBox chkMorango;
        private System.Windows.Forms.GroupBox grbCalda;
        private System.Windows.Forms.CheckBox chkCaramelo;
        private System.Windows.Forms.CheckBox chkChocolateQuente;
    }
}

