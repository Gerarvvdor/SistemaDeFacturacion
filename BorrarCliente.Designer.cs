namespace Sistema_de_Facturación_local_MPService
{
    partial class BorrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrarCliente));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnEliminarClick = new System.Windows.Forms.Button();
            this.deleteClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 900);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnEliminarClick
            // 
            this.BtnEliminarClick.Location = new System.Drawing.Point(12, 12);
            this.BtnEliminarClick.Name = "BtnEliminarClick";
            this.BtnEliminarClick.Size = new System.Drawing.Size(155, 48);
            this.BtnEliminarClick.TabIndex = 1;
            this.BtnEliminarClick.Text = "Borrar";
            this.BtnEliminarClick.UseVisualStyleBackColor = true;
            this.BtnEliminarClick.Click += new System.EventHandler(this.BtnEliminarClick_Click);
            // 
            // deleteClientButton
            // 
            this.deleteClientButton.Location = new System.Drawing.Point(173, 12);
            this.deleteClientButton.Name = "deleteClientButton";
            this.deleteClientButton.Size = new System.Drawing.Size(155, 48);
            this.deleteClientButton.TabIndex = 2;
            this.deleteClientButton.Text = "Regresar";
            this.deleteClientButton.UseVisualStyleBackColor = true;
            this.deleteClientButton.Click += new System.EventHandler(this.deleteClientButton_Click);
            // 
            // BorrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 1055);
            this.Controls.Add(this.deleteClientButton);
            this.Controls.Add(this.BtnEliminarClick);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorrarCliente";
            this.Text = "BorrarCliente";
            this.Load += new System.EventHandler(this.BorrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnEliminarClick;
        private System.Windows.Forms.Button deleteClientButton;
    }
}