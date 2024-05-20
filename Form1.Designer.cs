namespace pryReservasAmbordt
{
    partial class Form1
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
            btnReservar = new Button();
            btnMostrarReservas = new Button();
            SuspendLayout();
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(147, 46);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(163, 71);
            btnReservar.TabIndex = 0;
            btnReservar.Text = "Reservar";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // btnMostrarReservas
            // 
            btnMostrarReservas.Location = new Point(147, 169);
            btnMostrarReservas.Name = "btnMostrarReservas";
            btnMostrarReservas.Size = new Size(163, 71);
            btnMostrarReservas.TabIndex = 1;
            btnMostrarReservas.Text = "Mostrar Reservas";
            btnMostrarReservas.UseVisualStyleBackColor = true;
            btnMostrarReservas.Click += btnMostrarReservas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 391);
            Controls.Add(btnMostrarReservas);
            Controls.Add(btnReservar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnReservar;
        private Button btnMostrarReservas;
    }
}
