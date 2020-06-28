namespace Restaurante
{
    partial class OrderResume
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMesa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.lblOrders = new System.Windows.Forms.ListBox();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesa.Location = new System.Drawing.Point(76, 9);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(21, 13);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personas";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.BackColor = System.Drawing.Color.LightSeaGreen;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(76, 40);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(21, 13);
            this.lblPersonas.TabIndex = 3;
            this.lblPersonas.Text = "no";
            // 
            // cboNames
            // 
            this.cboNames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cboNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(0, 86);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(629, 24);
            this.cboNames.TabIndex = 4;
            this.cboNames.SelectedIndexChanged += new System.EventHandler(this.cboNames_SelectedIndexChanged);
            // 
            // lblOrders
            // 
            this.lblOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.FormattingEnabled = true;
            this.lblOrders.ItemHeight = 16;
            this.lblOrders.Location = new System.Drawing.Point(0, 110);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(629, 244);
            this.lblOrders.TabIndex = 5;
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.BackColor = System.Drawing.Color.White;
            this.btnDeleteOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeleteOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrders.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnDeleteOrders.Location = new System.Drawing.Point(0, 311);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(629, 43);
            this.btnDeleteOrders.TabIndex = 6;
            this.btnDeleteOrders.Text = "Finalizar Orden";
            this.btnDeleteOrders.UseVisualStyleBackColor = false;
            this.btnDeleteOrders.Click += new System.EventHandler(this.btnDeleteOrders_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-2, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 149);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.cboNames);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 110);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(629, 17);
            this.panel3.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(629, 67);
            this.panel5.TabIndex = 6;
            // 
            // OrderResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(629, 354);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnDeleteOrders);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "OrderResume";
            this.Text = "OrderResume";
            this.Load += new System.EventHandler(this.OrderResume_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.ComboBox cboNames;
        private System.Windows.Forms.ListBox lblOrders;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
    }
}