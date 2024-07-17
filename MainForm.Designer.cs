namespace Sistema_de_Facturación_local_MPService
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.newClientButton = new System.Windows.Forms.Button();
            this.deleteClientButtoon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fiscalCreditButton = new System.Windows.Forms.Button();
            this.billButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newClientButton
            // 
            this.newClientButton.Location = new System.Drawing.Point(12, 12);
            this.newClientButton.Name = "newClientButton";
            this.newClientButton.Size = new System.Drawing.Size(148, 57);
            this.newClientButton.TabIndex = 0;
            this.newClientButton.Text = "Nuevo cliente";
            this.newClientButton.UseVisualStyleBackColor = true;
            this.newClientButton.Click += new System.EventHandler(this.newClientButton_Click);
            // 
            // deleteClientButtoon
            // 
            this.deleteClientButtoon.Location = new System.Drawing.Point(166, 12);
            this.deleteClientButtoon.Name = "deleteClientButtoon";
            this.deleteClientButtoon.Size = new System.Drawing.Size(148, 57);
            this.deleteClientButtoon.TabIndex = 1;
            this.deleteClientButtoon.Text = "Borrar Cliente";
            this.deleteClientButtoon.UseVisualStyleBackColor = true;
            this.deleteClientButtoon.Click += new System.EventHandler(this.deleteClientButtoon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de documento a emitir";
            // 
            // fiscalCreditButton
            // 
            this.fiscalCreditButton.Location = new System.Drawing.Point(12, 107);
            this.fiscalCreditButton.Name = "fiscalCreditButton";
            this.fiscalCreditButton.Size = new System.Drawing.Size(148, 54);
            this.fiscalCreditButton.TabIndex = 3;
            this.fiscalCreditButton.Text = "Credito Fiscal";
            this.fiscalCreditButton.UseVisualStyleBackColor = true;
            this.fiscalCreditButton.Click += new System.EventHandler(this.fiscalCreditButton_Click);
            // 
            // billButton
            // 
            this.billButton.Location = new System.Drawing.Point(166, 107);
            this.billButton.Name = "billButton";
            this.billButton.Size = new System.Drawing.Size(148, 54);
            this.billButton.TabIndex = 4;
            this.billButton.Text = "Factura";
            this.billButton.UseVisualStyleBackColor = true;
            this.billButton.Click += new System.EventHandler(this.billButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 180);
            this.Controls.Add(this.billButton);
            this.Controls.Add(this.fiscalCreditButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteClientButtoon);
            this.Controls.Add(this.newClientButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Sistema de Facturación MP Service S.A de C.V.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.Button deleteClientButtoon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button fiscalCreditButton;
        private System.Windows.Forms.Button billButton;
    }
}