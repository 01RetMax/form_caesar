namespace form_caesar
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_ver = new System.Windows.Forms.TextBox();
            this.tb_sch = new System.Windows.Forms.TextBox();
            this.tb_ent = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.lbl_sch = new System.Windows.Forms.Label();
            this.lbl_ent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_ver
            // 
            this.tb_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_ver.Location = new System.Drawing.Point(264, 63);
            this.tb_ver.Multiline = true;
            this.tb_ver.Name = "tb_ver";
            this.tb_ver.Size = new System.Drawing.Size(672, 93);
            this.tb_ver.TabIndex = 0;
            this.tb_ver.TextChanged += new System.EventHandler(this.tb_ver_TextChanged);
            // 
            // tb_sch
            // 
            this.tb_sch.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sch.Location = new System.Drawing.Point(319, 199);
            this.tb_sch.Name = "tb_sch";
            this.tb_sch.Size = new System.Drawing.Size(73, 45);
            this.tb_sch.TabIndex = 1;
            this.tb_sch.TextChanged += new System.EventHandler(this.tb_sch_TextChanged);
            // 
            // tb_ent
            // 
            this.tb_ent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tb_ent.Location = new System.Drawing.Point(264, 285);
            this.tb_ent.Multiline = true;
            this.tb_ent.Name = "tb_ent";
            this.tb_ent.Size = new System.Drawing.Size(672, 93);
            this.tb_ent.TabIndex = 2;
            this.tb_ent.TextChanged += new System.EventHandler(this.tb_ent_TextChanged);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(433, 180);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(503, 84);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "Verschlüsseln <---> Entschlüsseln";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_ver.Location = new System.Drawing.Point(4, 98);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(242, 29);
            this.lbl_ver.TabIndex = 4;
            this.lbl_ver.Text = "Verschlüsselter Text";
            // 
            // lbl_sch
            // 
            this.lbl_sch.AutoSize = true;
            this.lbl_sch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_sch.Location = new System.Drawing.Point(169, 209);
            this.lbl_sch.Name = "lbl_sch";
            this.lbl_sch.Size = new System.Drawing.Size(123, 29);
            this.lbl_sch.TabIndex = 5;
            this.lbl_sch.Text = "Schlüssel";
            // 
            // lbl_ent
            // 
            this.lbl_ent.AutoSize = true;
            this.lbl_ent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_ent.Location = new System.Drawing.Point(5, 315);
            this.lbl_ent.Name = "lbl_ent";
            this.lbl_ent.Size = new System.Drawing.Size(241, 29);
            this.lbl_ent.TabIndex = 6;
            this.lbl_ent.Text = "Entschlüsselter Text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.lbl_ent);
            this.Controls.Add(this.lbl_sch);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.tb_ent);
            this.Controls.Add(this.tb_sch);
            this.Controls.Add(this.tb_ver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ver;
        private System.Windows.Forms.TextBox tb_sch;
        private System.Windows.Forms.TextBox tb_ent;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label lbl_ver;
        private System.Windows.Forms.Label lbl_sch;
        private System.Windows.Forms.Label lbl_ent;
    }
}

