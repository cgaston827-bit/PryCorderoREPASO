namespace PryCorderoREPASO
{
    partial class frmCalculos
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
            txtMonto = new TextBox();
            lblMonto = new Label();
            lblIVA = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            lblresultado = new Label();
            SuspendLayout();
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(139, 46);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 0;
            txtMonto.Text = "Monto";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(61, 54);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 2;
            lblMonto.Text = "Monto";
            lblMonto.Click += label1_Click;
            // 
            // lblIVA
            // 
            lblIVA.AutoSize = true;
            lblIVA.Location = new Point(66, 110);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(24, 15);
            lblIVA.TabIndex = 3;
            lblIVA.Text = "IVA";
            // 
            // button1
            // 
            button1.Location = new Point(181, 189);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calculo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10%", "21%" });
            comboBox1.Location = new Point(139, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(89, 256);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(59, 15);
            lblresultado.TabIndex = 6;
            lblresultado.Text = "Resultado";
            // 
            // frmCalculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 336);
            Controls.Add(lblresultado);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(lblIVA);
            Controls.Add(lblMonto);
            Controls.Add(txtMonto);
            Name = "frmCalculos";
            Text = "Calculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMonto;
        private Label lblMonto;
        private Label lblIVA;
        private Button button1;
        private ComboBox comboBox1;
        private Label lblresultado;
    }
}