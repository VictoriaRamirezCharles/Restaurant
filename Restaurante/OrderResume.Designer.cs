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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa";
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Location = new System.Drawing.Point(76, 9);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(19, 13);
            this.lblMesa.TabIndex = 1;
            this.lblMesa.Text = "no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personas";
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Location = new System.Drawing.Point(76, 40);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(19, 13);
            this.lblPersonas.TabIndex = 3;
            this.lblPersonas.Text = "no";
            // 
            // cboNames
            // 
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(25, 67);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(548, 21);
            this.cboNames.TabIndex = 4;
            this.cboNames.SelectedIndexChanged += new System.EventHandler(this.cboNames_SelectedIndexChanged);
            // 
            // lblOrders
            // 
            this.lblOrders.FormattingEnabled = true;
            this.lblOrders.Location = new System.Drawing.Point(25, 109);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(548, 147);
            this.lblOrders.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteOrders);
            this.panel1.Controls.Add(this.lblOrders);
            this.panel1.Controls.Add(this.cboNames);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 340);
            this.panel1.TabIndex = 6;
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Location = new System.Drawing.Point(183, 274);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(235, 43);
            this.btnDeleteOrders.TabIndex = 6;
            this.btnDeleteOrders.Text = "Finalizar Orden";
            this.btnDeleteOrders.UseVisualStyleBackColor = true;
            this.btnDeleteOrders.Click += new System.EventHandler(this.btnDeleteOrders_Click);
            // 
            // OrderResume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 340);
            this.Controls.Add(this.lblPersonas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "OrderResume";
            this.Text = "OrderResume";
            this.Load += new System.EventHandler(this.OrderResume_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteOrders;
    }
}