namespace Calculadora
{
    partial class FrmConversor
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
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.bttnLimpar = new System.Windows.Forms.Button();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.txtMostraResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(173, 149);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(335, 43);
            this.bttnCalcular.TabIndex = 0;
            this.bttnCalcular.Text = "Converter";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            // 
            // bttnLimpar
            // 
            this.bttnLimpar.Location = new System.Drawing.Point(173, 324);
            this.bttnLimpar.Name = "bttnLimpar";
            this.bttnLimpar.Size = new System.Drawing.Size(335, 43);
            this.bttnLimpar.TabIndex = 1;
            this.bttnLimpar.Text = "Limpar";
            this.bttnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(178, 58);
            this.txtConta.Multiline = true;
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(329, 59);
            this.txtConta.TabIndex = 2;
            // 
            // txtMostraResultado
            // 
            this.txtMostraResultado.Location = new System.Drawing.Point(178, 242);
            this.txtMostraResultado.Multiline = true;
            this.txtMostraResultado.Name = "txtMostraResultado";
            this.txtMostraResultado.Size = new System.Drawing.Size(329, 61);
            this.txtMostraResultado.TabIndex = 3;
            // 
            // FrmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.txtMostraResultado);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.bttnLimpar);
            this.Controls.Add(this.bttnCalcular);
            this.Name = "FrmConversor";
            this.Text = "FrmConversor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Button bttnLimpar;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.TextBox txtMostraResultado;
    }
}