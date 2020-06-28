namespace Restaurante
{
    partial class Tables
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmTables = new System.Windows.Forms.TableLayoutPanel();
            this.tlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnResumeProcess = new System.Windows.Forms.Button();
            this.lbboxTables = new System.Windows.Forms.ListBox();
            this.frmTables.SuspendLayout();
            this.tlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmTables
            // 
            this.frmTables.BackColor = System.Drawing.Color.LightSeaGreen;
            this.frmTables.ColumnCount = 3;
            this.frmTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.348548F));
            this.frmTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.82158F));
            this.frmTables.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.93361F));
            this.frmTables.Controls.Add(this.tlButtons, 1, 2);
            this.frmTables.Controls.Add(this.lbboxTables, 1, 1);
            this.frmTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmTables.Location = new System.Drawing.Point(0, 0);
            this.frmTables.Name = "frmTables";
            this.frmTables.RowCount = 3;
            this.frmTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.frmTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.6F));
            this.frmTables.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.23746F));
            this.frmTables.Size = new System.Drawing.Size(964, 500);
            this.frmTables.TabIndex = 1;
            // 
            // tlButtons
            // 
            this.tlButtons.ColumnCount = 2;
            this.tlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 467F));
            this.tlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlButtons.Controls.Add(this.btnAddOrder, 1, 0);
            this.tlButtons.Controls.Add(this.btnResumeProcess, 0, 0);
            this.tlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlButtons.Location = new System.Drawing.Point(15, 396);
            this.tlButtons.Name = "tlButtons";
            this.tlButtons.RowCount = 2;
            this.tlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlButtons.Size = new System.Drawing.Size(936, 101);
            this.tlButtons.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddOrder.BackColor = System.Drawing.Color.White;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrder.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddOrder.Location = new System.Drawing.Point(578, 22);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(246, 37);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "Agregar Orden";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnResumeProcess
            // 
            this.btnResumeProcess.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResumeProcess.BackColor = System.Drawing.Color.White;
            this.btnResumeProcess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResumeProcess.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeProcess.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnResumeProcess.Location = new System.Drawing.Point(110, 22);
            this.btnResumeProcess.Name = "btnResumeProcess";
            this.btnResumeProcess.Size = new System.Drawing.Size(246, 37);
            this.btnResumeProcess.TabIndex = 1;
            this.btnResumeProcess.Text = "Reaunudar P. de Atencion";
            this.btnResumeProcess.UseVisualStyleBackColor = false;
            this.btnResumeProcess.Click += new System.EventHandler(this.btnResumeProcess_Click);
            // 
            // lbboxTables
            // 
            this.lbboxTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbboxTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbboxTables.FormattingEnabled = true;
            this.lbboxTables.ItemHeight = 29;
            this.lbboxTables.Location = new System.Drawing.Point(15, 23);
            this.lbboxTables.Name = "lbboxTables";
            this.lbboxTables.Size = new System.Drawing.Size(936, 367);
            this.lbboxTables.TabIndex = 0;
            this.lbboxTables.SelectedIndexChanged += new System.EventHandler(this.lbboxTables_SelectedIndexChanged);
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 500);
            this.Controls.Add(this.frmTables);
            this.Name = "Tables";
            this.Text = "Victoria\'s Restaurant";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tables_FormClosed);
            this.Load += new System.EventHandler(this.Tables_Load);
            this.VisibleChanged += new System.EventHandler(this.Tables_VisibleChanged);
            this.frmTables.ResumeLayout(false);
            this.tlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel frmTables;
        private System.Windows.Forms.ListBox lbboxTables;
        private System.Windows.Forms.TableLayoutPanel tlButtons;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnResumeProcess;
    }
}

