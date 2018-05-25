namespace Laboratorio_3.Forms
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnRecursos = new System.Windows.Forms.Button();
            this.btnDefensas = new System.Windows.Forms.Button();
            this.btnEjercito = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(330, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tienda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(186)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 69);
            this.panel1.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Location = new System.Drawing.Point(13, 18);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 26);
            this.btnHome.TabIndex = 43;
            this.btnHome.Text = "Volver a inicio";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnRecursos
            // 
            this.btnRecursos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecursos.BackgroundImage")));
            this.btnRecursos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecursos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecursos.FlatAppearance.BorderSize = 0;
            this.btnRecursos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnRecursos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRecursos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRecursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursos.Location = new System.Drawing.Point(64, 178);
            this.btnRecursos.Name = "btnRecursos";
            this.btnRecursos.Size = new System.Drawing.Size(200, 151);
            this.btnRecursos.TabIndex = 5;
            this.btnRecursos.UseVisualStyleBackColor = true;
            this.btnRecursos.Click += new System.EventHandler(this.btnRecursos_Click);
            // 
            // btnDefensas
            // 
            this.btnDefensas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDefensas.BackgroundImage")));
            this.btnDefensas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDefensas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDefensas.FlatAppearance.BorderSize = 0;
            this.btnDefensas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnDefensas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDefensas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnDefensas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefensas.Location = new System.Drawing.Point(292, 178);
            this.btnDefensas.Name = "btnDefensas";
            this.btnDefensas.Size = new System.Drawing.Size(200, 151);
            this.btnDefensas.TabIndex = 6;
            this.btnDefensas.UseVisualStyleBackColor = true;
            this.btnDefensas.Click += new System.EventHandler(this.btnDefensas_Click);
            // 
            // btnEjercito
            // 
            this.btnEjercito.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEjercito.BackgroundImage")));
            this.btnEjercito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEjercito.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjercito.FlatAppearance.BorderSize = 0;
            this.btnEjercito.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEjercito.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEjercito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEjercito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercito.Location = new System.Drawing.Point(520, 178);
            this.btnEjercito.Name = "btnEjercito";
            this.btnEjercito.Size = new System.Drawing.Size(200, 151);
            this.btnEjercito.TabIndex = 7;
            this.btnEjercito.UseVisualStyleBackColor = true;
            this.btnEjercito.Click += new System.EventHandler(this.btnEjercito_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEjercito);
            this.Controls.Add(this.btnDefensas);
            this.Controls.Add(this.btnRecursos);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Shop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clash of Clans";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRecursos;
        private System.Windows.Forms.Button btnDefensas;
        private System.Windows.Forms.Button btnEjercito;
        private System.Windows.Forms.Button btnHome;
    }
}