namespace pryReservasAmbordt
{
    partial class frmReservar
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
            label1 = new Label();
            btnReservarQuenaquen = new Button();
            btnReservarOnas = new Button();
            btnReservarTobas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 29);
            label1.Name = "label1";
            label1.Size = new Size(201, 25);
            label1.TabIndex = 0;
            label1.Text = "Seleccione la sala";
            // 
            // btnReservarQuenaquen
            // 
            btnReservarQuenaquen.Location = new Point(58, 166);
            btnReservarQuenaquen.Name = "btnReservarQuenaquen";
            btnReservarQuenaquen.Size = new Size(102, 42);
            btnReservarQuenaquen.TabIndex = 1;
            btnReservarQuenaquen.Text = "Quenaquen";
            btnReservarQuenaquen.UseVisualStyleBackColor = true;
            btnReservarQuenaquen.Click += btnReservarQuenaquen_Click;
            // 
            // btnReservarOnas
            // 
            btnReservarOnas.Location = new Point(187, 166);
            btnReservarOnas.Name = "btnReservarOnas";
            btnReservarOnas.Size = new Size(102, 42);
            btnReservarOnas.TabIndex = 2;
            btnReservarOnas.Text = "Onas";
            btnReservarOnas.UseVisualStyleBackColor = true;
            btnReservarOnas.Click += btnReservarOnas_Click;
            // 
            // btnReservarTobas
            // 
            btnReservarTobas.Location = new Point(322, 166);
            btnReservarTobas.Name = "btnReservarTobas";
            btnReservarTobas.Size = new Size(102, 42);
            btnReservarTobas.TabIndex = 3;
            btnReservarTobas.Text = "Tobas";
            btnReservarTobas.UseVisualStyleBackColor = true;
            btnReservarTobas.Click += btnReservarTobas_Click;
            // 
            // frmReservar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReservarTobas);
            Controls.Add(btnReservarOnas);
            Controls.Add(btnReservarQuenaquen);
            Controls.Add(label1);
            Name = "frmReservar";
            Text = "frmReservar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnReservarQuenaquen;
        private Button btnReservarOnas;
        private Button btnReservarTobas;
    }
}