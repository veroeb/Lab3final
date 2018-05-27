namespace Laboratorio_3.Forms
{
    partial class Ejercito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercito));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnCuartelNormal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCuartelOscuro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCampamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(337, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ejército";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(186)))), ((int)(((byte)(159)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 69);
            this.panel1.TabIndex = 6;
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
            this.btnHome.Location = new System.Drawing.Point(14, 21);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(127, 26);
            this.btnHome.TabIndex = 42;
            this.btnHome.Text = "Volver a inicio";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCuartelNormal
            // 
            this.btnCuartelNormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuartelNormal.BackgroundImage")));
            this.btnCuartelNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCuartelNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuartelNormal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCuartelNormal.FlatAppearance.BorderSize = 0;
            this.btnCuartelNormal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCuartelNormal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCuartelNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuartelNormal.Location = new System.Drawing.Point(94, 173);
            this.btnCuartelNormal.Name = "btnCuartelNormal";
            this.btnCuartelNormal.Size = new System.Drawing.Size(120, 120);
            this.btnCuartelNormal.TabIndex = 7;
            this.btnCuartelNormal.UseVisualStyleBackColor = true;
            this.btnCuartelNormal.Click += new System.EventHandler(this.btnCuartelNormal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(87, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cuartel Normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(330, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cuartel Oscuro";
            // 
            // btnCuartelOscuro
            // 
            this.btnCuartelOscuro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCuartelOscuro.BackgroundImage")));
            this.btnCuartelOscuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCuartelOscuro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCuartelOscuro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCuartelOscuro.FlatAppearance.BorderSize = 0;
            this.btnCuartelOscuro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCuartelOscuro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCuartelOscuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuartelOscuro.Location = new System.Drawing.Point(337, 173);
            this.btnCuartelOscuro.Name = "btnCuartelOscuro";
            this.btnCuartelOscuro.Size = new System.Drawing.Size(120, 120);
            this.btnCuartelOscuro.TabIndex = 9;
            this.btnCuartelOscuro.UseVisualStyleBackColor = true;
            this.btnCuartelOscuro.Click += new System.EventHandler(this.btnCuartelOscuro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(568, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Campamento";
            // 
            // btnCampamento
            // 
            this.btnCampamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCampamento.BackgroundImage")));
            this.btnCampamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCampamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCampamento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.btnCampamento.FlatAppearance.BorderSize = 0;
            this.btnCampamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCampamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCampamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampamento.Location = new System.Drawing.Point(575, 173);
            this.btnCampamento.Name = "btnCampamento";
            this.btnCampamento.Size = new System.Drawing.Size(120, 120);
            this.btnCampamento.TabIndex = 11;
            this.btnCampamento.UseVisualStyleBackColor = true;
            this.btnCampamento.Click += new System.EventHandler(this.btnCampamento_Click);
            // 
            // Ejercito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCampamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCuartelOscuro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCuartelNormal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejercito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clash of Clans";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnCuartelNormal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCuartelOscuro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCampamento;
    }
}