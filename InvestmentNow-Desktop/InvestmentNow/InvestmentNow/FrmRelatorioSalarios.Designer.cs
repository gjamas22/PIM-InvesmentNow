namespace InvestmentNow
{
    partial class FrmRelatorioSalarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRelatorioSalarios));
            this.lblSalarios = new System.Windows.Forms.Label();
            this.lblTotalLucro = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.dgvSalarios = new System.Windows.Forms.DataGridView();
            this.btnConsultarSalarios = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalarios
            // 
            this.lblSalarios.AutoSize = true;
            this.lblSalarios.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.lblSalarios.Location = new System.Drawing.Point(4, 6);
            this.lblSalarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalarios.Name = "lblSalarios";
            this.lblSalarios.Size = new System.Drawing.Size(247, 37);
            this.lblSalarios.TabIndex = 18;
            this.lblSalarios.Text = "Salários totais: R$";
            this.lblSalarios.Visible = false;
            // 
            // lblTotalLucro
            // 
            this.lblTotalLucro.AutoSize = true;
            this.lblTotalLucro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTotalLucro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.lblTotalLucro.Location = new System.Drawing.Point(249, 6);
            this.lblTotalLucro.Name = "lblTotalLucro";
            this.lblTotalLucro.Size = new System.Drawing.Size(96, 37);
            this.lblTotalLucro.TabIndex = 17;
            this.lblTotalLucro.Text = "label1";
            this.lblTotalLucro.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSalarios);
            this.panel2.Controls.Add(this.lblTotalLucro);
            this.panel2.Location = new System.Drawing.Point(46, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 52);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 61);
            this.panel1.TabIndex = 22;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblLogin.Location = new System.Drawing.Point(13, 9);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(211, 37);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Gastos Salários";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(793, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(73, 61);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Location = new System.Drawing.Point(57, 92);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.RowHeadersWidth = 51;
            this.dgvSalarios.RowTemplate.Height = 24;
            this.dgvSalarios.Size = new System.Drawing.Size(748, 298);
            this.dgvSalarios.TabIndex = 24;
            // 
            // btnConsultarSalarios
            // 
            this.btnConsultarSalarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(0)))));
            this.btnConsultarSalarios.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnConsultarSalarios.ForeColor = System.Drawing.Color.White;
            this.btnConsultarSalarios.Location = new System.Drawing.Point(352, 488);
            this.btnConsultarSalarios.Name = "btnConsultarSalarios";
            this.btnConsultarSalarios.Size = new System.Drawing.Size(138, 58);
            this.btnConsultarSalarios.TabIndex = 25;
            this.btnConsultarSalarios.Text = "Consultar";
            this.btnConsultarSalarios.UseVisualStyleBackColor = false;
            this.btnConsultarSalarios.Click += new System.EventHandler(this.btnConsultarSalarios_Click);
            // 
            // FrmRelatorioSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(866, 570);
            this.Controls.Add(this.btnConsultarSalarios);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRelatorioSalarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioSalarios";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSalarios;
        private System.Windows.Forms.Label lblTotalLucro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridView dgvSalarios;
        private System.Windows.Forms.Button btnConsultarSalarios;
    }
}