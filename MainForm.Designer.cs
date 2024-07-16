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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientNameCmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.billClientLabel = new System.Windows.Forms.Label();
            this.billClientAddress = new System.Windows.Forms.Label();
            this.billMunicipioClient = new System.Windows.Forms.Label();
            this.billDepartmentClient = new System.Windows.Forms.Label();
            this.billRegisterClient = new System.Windows.Forms.Label();
            this.billGiroClient = new System.Windows.Forms.Label();
            this.billNITclient = new System.Windows.Forms.Label();
            this.billDateLabel = new System.Windows.Forms.Label();
            this.billDateFactureLabelPicker = new System.Windows.Forms.Label();
            this.billDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billPayConditions = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.printBillButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Facturación_local_MPService.Properties.Resources.SCN_0003;
            this.pictureBox1.Location = new System.Drawing.Point(12, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 1056);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // clientNameCmbx
            // 
            this.clientNameCmbx.FormattingEnabled = true;
            this.clientNameCmbx.Location = new System.Drawing.Point(834, 75);
            this.clientNameCmbx.Name = "clientNameCmbx";
            this.clientNameCmbx.Size = new System.Drawing.Size(398, 24);
            this.clientNameCmbx.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(834, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cliente";
            // 
            // billClientLabel
            // 
            this.billClientLabel.AutoSize = true;
            this.billClientLabel.BackColor = System.Drawing.Color.Transparent;
            this.billClientLabel.Location = new System.Drawing.Point(78, 215);
            this.billClientLabel.Name = "billClientLabel";
            this.billClientLabel.Size = new System.Drawing.Size(48, 16);
            this.billClientLabel.TabIndex = 5;
            this.billClientLabel.Text = "Cliente";
            // 
            // billClientAddress
            // 
            this.billClientAddress.AutoSize = true;
            this.billClientAddress.BackColor = System.Drawing.Color.Transparent;
            this.billClientAddress.Location = new System.Drawing.Point(93, 232);
            this.billClientAddress.Name = "billClientAddress";
            this.billClientAddress.Size = new System.Drawing.Size(64, 16);
            this.billClientAddress.TabIndex = 6;
            this.billClientAddress.Text = "Dirección";
            // 
            // billMunicipioClient
            // 
            this.billMunicipioClient.AutoSize = true;
            this.billMunicipioClient.BackColor = System.Drawing.Color.Transparent;
            this.billMunicipioClient.Location = new System.Drawing.Point(86, 262);
            this.billMunicipioClient.Name = "billMunicipioClient";
            this.billMunicipioClient.Size = new System.Drawing.Size(64, 16);
            this.billMunicipioClient.TabIndex = 7;
            this.billMunicipioClient.Text = "Municipio";
            // 
            // billDepartmentClient
            // 
            this.billDepartmentClient.AutoSize = true;
            this.billDepartmentClient.BackColor = System.Drawing.Color.Transparent;
            this.billDepartmentClient.Location = new System.Drawing.Point(117, 279);
            this.billDepartmentClient.Name = "billDepartmentClient";
            this.billDepartmentClient.Size = new System.Drawing.Size(93, 16);
            this.billDepartmentClient.TabIndex = 8;
            this.billDepartmentClient.Text = "Departamento";
            // 
            // billRegisterClient
            // 
            this.billRegisterClient.AutoSize = true;
            this.billRegisterClient.BackColor = System.Drawing.Color.Transparent;
            this.billRegisterClient.Location = new System.Drawing.Point(610, 232);
            this.billRegisterClient.Name = "billRegisterClient";
            this.billRegisterClient.Size = new System.Drawing.Size(58, 16);
            this.billRegisterClient.TabIndex = 10;
            this.billRegisterClient.Text = "Registro";
            // 
            // billGiroClient
            // 
            this.billGiroClient.AutoSize = true;
            this.billGiroClient.BackColor = System.Drawing.Color.Transparent;
            this.billGiroClient.Location = new System.Drawing.Point(584, 248);
            this.billGiroClient.Name = "billGiroClient";
            this.billGiroClient.Size = new System.Drawing.Size(32, 16);
            this.billGiroClient.TabIndex = 11;
            this.billGiroClient.Text = "Giro";
            // 
            // billNITclient
            // 
            this.billNITclient.AutoSize = true;
            this.billNITclient.BackColor = System.Drawing.Color.Transparent;
            this.billNITclient.Location = new System.Drawing.Point(577, 264);
            this.billNITclient.Name = "billNITclient";
            this.billNITclient.Size = new System.Drawing.Size(29, 16);
            this.billNITclient.TabIndex = 12;
            this.billNITclient.Text = "NIT";
            // 
            // billDateLabel
            // 
            this.billDateLabel.AutoSize = true;
            this.billDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.billDateLabel.Location = new System.Drawing.Point(597, 216);
            this.billDateLabel.Name = "billDateLabel";
            this.billDateLabel.Size = new System.Drawing.Size(45, 16);
            this.billDateLabel.TabIndex = 13;
            this.billDateLabel.Text = "Fecha";
            // 
            // billDateFactureLabelPicker
            // 
            this.billDateFactureLabelPicker.AutoSize = true;
            this.billDateFactureLabelPicker.BackColor = System.Drawing.Color.Transparent;
            this.billDateFactureLabelPicker.Location = new System.Drawing.Point(837, 116);
            this.billDateFactureLabelPicker.Name = "billDateFactureLabelPicker";
            this.billDateFactureLabelPicker.Size = new System.Drawing.Size(121, 16);
            this.billDateFactureLabelPicker.TabIndex = 14;
            this.billDateFactureLabelPicker.Text = "Fecha de la factura";
            // 
            // billDateTimePicker
            // 
            this.billDateTimePicker.Location = new System.Drawing.Point(834, 135);
            this.billDateTimePicker.Name = "billDateTimePicker";
            this.billDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.billDateTimePicker.TabIndex = 15;
            // 
            // billPayConditions
            // 
            this.billPayConditions.AutoSize = true;
            this.billPayConditions.BackColor = System.Drawing.Color.Transparent;
            this.billPayConditions.Location = new System.Drawing.Point(678, 279);
            this.billPayConditions.Name = "billPayConditions";
            this.billPayConditions.Size = new System.Drawing.Size(121, 16);
            this.billPayConditions.TabIndex = 16;
            this.billPayConditions.Text = "Condición de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(834, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Condición de pago";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(834, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 22);
            this.textBox1.TabIndex = 18;
            // 
            // printBillButton
            // 
            this.printBillButton.Location = new System.Drawing.Point(840, 255);
            this.printBillButton.Name = "printBillButton";
            this.printBillButton.Size = new System.Drawing.Size(133, 65);
            this.printBillButton.TabIndex = 19;
            this.printBillButton.Text = "Imprimir";
            this.printBillButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 1055);
            this.Controls.Add(this.printBillButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.billPayConditions);
            this.Controls.Add(this.billDateTimePicker);
            this.Controls.Add(this.billDateFactureLabelPicker);
            this.Controls.Add(this.billDateLabel);
            this.Controls.Add(this.billNITclient);
            this.Controls.Add(this.billGiroClient);
            this.Controls.Add(this.billRegisterClient);
            this.Controls.Add(this.billDepartmentClient);
            this.Controls.Add(this.billMunicipioClient);
            this.Controls.Add(this.billClientAddress);
            this.Controls.Add(this.billClientLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientNameCmbx);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteClientButtoon);
            this.Controls.Add(this.newClientButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Sistema de Facturación MP Service S.A de C.V.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newClientButton;
        private System.Windows.Forms.Button deleteClientButtoon;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox clientNameCmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label billClientLabel;
        private System.Windows.Forms.Label billClientAddress;
        private System.Windows.Forms.Label billMunicipioClient;
        private System.Windows.Forms.Label billDepartmentClient;
        private System.Windows.Forms.Label billRegisterClient;
        private System.Windows.Forms.Label billGiroClient;
        private System.Windows.Forms.Label billNITclient;
        private System.Windows.Forms.Label billDateLabel;
        private System.Windows.Forms.Label billDateFactureLabelPicker;
        private System.Windows.Forms.DateTimePicker billDateTimePicker;
        private System.Windows.Forms.Label billPayConditions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button printBillButton;
    }
}