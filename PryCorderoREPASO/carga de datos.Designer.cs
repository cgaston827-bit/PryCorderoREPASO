namespace PryCorderoREPASO
{
    partial class lblNombre
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblcodigo = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtRegistrar = new Button();
            contextMenuStrip2 = new ContextMenuStrip(components);
            txtCodigo = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(60, 60);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(46, 15);
            lblcodigo.TabIndex = 0;
            lblcodigo.Text = "Codigo";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtRegistrar
            // 
            txtRegistrar.Location = new Point(149, 114);
            txtRegistrar.Name = "txtRegistrar";
            txtRegistrar.Size = new Size(75, 23);
            txtRegistrar.TabIndex = 2;
            txtRegistrar.Text = "Registrar";
            txtRegistrar.UseVisualStyleBackColor = true;
            txtRegistrar.Click += txtRegistrar_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(124, 52);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 4;
            txtCodigo.TextChanged += txtcodigo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 93);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 85);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 6;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // lblNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(txtCodigo);
            Controls.Add(txtRegistrar);
            Controls.Add(lblcodigo);
            Name = "lblNombre";
            Text = "Nombre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcodigo;
        private ContextMenuStrip contextMenuStrip1;
        private Button txtRegistrar;
        private ContextMenuStrip contextMenuStrip2;
        private TextBox txtCodigo;
        private Label label1;
        private TextBox txtNombre;
    }
}
