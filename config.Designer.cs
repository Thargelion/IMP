namespace WindowsFormsApplication1
{
    partial class config
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
            this.Estado = new System.Windows.Forms.Label();
            this.abrir = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Location = new System.Drawing.Point(42, 28);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(46, 13);
            this.Estado.TabIndex = 0;
            this.Estado.Text = "Sumatra";
            this.Estado.Click += new System.EventHandler(this.label1_Click);
            // 
            // abrir
            // 
            this.abrir.Location = new System.Drawing.Point(42, 53);
            this.abrir.Name = "abrir";
            this.abrir.Size = new System.Drawing.Size(160, 23);
            this.abrir.TabIndex = 1;
            this.abrir.Text = "Elegir ubicación de Sumatra";
            this.abrir.UseVisualStyleBackColor = true;
            this.abrir.Click += new System.EventHandler(this.button1_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(94, 28);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(105, 13);
            this.status.TabIndex = 2;
            this.status.Text = "NO CONFIGURADO";
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 101);
            this.Controls.Add(this.status);
            this.Controls.Add(this.abrir);
            this.Controls.Add(this.Estado);
            this.Name = "config";
            this.Text = "config";
            this.Load += new System.EventHandler(this.config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button abrir;
        private System.Windows.Forms.Label status;
    }
}