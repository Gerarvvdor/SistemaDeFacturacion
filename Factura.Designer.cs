namespace Sistema_de_Facturación_local_MPService
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.fiscalCreditCancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BillClientNameLabel = new System.Windows.Forms.Label();
            this.BilldeleteRowButton = new System.Windows.Forms.Button();
            this.BilladdRowButton = new System.Windows.Forms.Button();
            this.BillprintBillButton = new System.Windows.Forms.Button();
            this.BillPaymentCondition = new System.Windows.Forms.TextBox();
            this.BillPaymentoCondition = new System.Windows.Forms.Label();
            this.BillDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BillDateFactureLabelPicker = new System.Windows.Forms.Label();
            this.BillClientNameCmbx = new System.Windows.Forms.ComboBox();
            this.BillDepartmentLabell = new System.Windows.Forms.Label();
            this.BillClientLabel = new System.Windows.Forms.Label();
            this.BillMunicipioLabel = new System.Windows.Forms.Label();
            this.BillRegisterLabel = new System.Windows.Forms.Label();
            this.BillPayConditions = new System.Windows.Forms.Label();
            this.BillDateLabel = new System.Windows.Forms.Label();
            this.BillNITclient = new System.Windows.Forms.Label();
            this.BillVtasNoSujetas = new System.Windows.Forms.Label();
            this.BillVtasTotal = new System.Windows.Forms.Label();
            this.BillSumas = new System.Windows.Forms.Label();
            this.BillVtasExentas = new System.Windows.Forms.Label();
            this.BillIVARetenido = new System.Windows.Forms.Label();
            this.billTableProducts = new System.Windows.Forms.TableLayoutPanel();
            this.BillDescripcionTextbox = new System.Windows.Forms.TextBox();
            this.BillVentasExentasTextBox = new System.Windows.Forms.TextBox();
            this.TittleDescripcion = new System.Windows.Forms.Label();
            this.TittleVentasExentasLabel = new System.Windows.Forms.Label();
            this.ventasNoSujetasLabel = new System.Windows.Forms.Label();
            this.BillVtasNoSujetasTextBox = new System.Windows.Forms.TextBox();
            this.BillUnitPriceTextbox = new System.Windows.Forms.TextBox();
            this.pUnitLabel = new System.Windows.Forms.Label();
            this.billCantTextbox = new System.Windows.Forms.TextBox();
            this.tittleCantLabel = new System.Windows.Forms.Label();
            this.bigBuyerRadioButton = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fiscalCreditCancelButton
            // 
            this.fiscalCreditCancelButton.Location = new System.Drawing.Point(12, 12);
            this.fiscalCreditCancelButton.Name = "fiscalCreditCancelButton";
            this.fiscalCreditCancelButton.Size = new System.Drawing.Size(133, 46);
            this.fiscalCreditCancelButton.TabIndex = 39;
            this.fiscalCreditCancelButton.Text = "Regresar";
            this.fiscalCreditCancelButton.UseVisualStyleBackColor = true;
            this.fiscalCreditCancelButton.Click += new System.EventHandler(this.fiscalCreditCancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Facturación_local_MPService.Properties.Resources.SCN_0002;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 1056);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BillClientNameLabel
            // 
            this.BillClientNameLabel.AutoSize = true;
            this.BillClientNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.BillClientNameLabel.Location = new System.Drawing.Point(832, 61);
            this.BillClientNameLabel.Name = "BillClientNameLabel";
            this.BillClientNameLabel.Size = new System.Drawing.Size(48, 16);
            this.BillClientNameLabel.TabIndex = 53;
            this.BillClientNameLabel.Text = "Cliente";
            // 
            // BilldeleteRowButton
            // 
            this.BilldeleteRowButton.Location = new System.Drawing.Point(974, 633);
            this.BilldeleteRowButton.Name = "BilldeleteRowButton";
            this.BilldeleteRowButton.Size = new System.Drawing.Size(133, 31);
            this.BilldeleteRowButton.TabIndex = 52;
            this.BilldeleteRowButton.Text = "Borrar fila";
            this.BilldeleteRowButton.UseVisualStyleBackColor = true;
            this.BilldeleteRowButton.Click += new System.EventHandler(this.BilldeleteRowButton_Click);
            // 
            // BilladdRowButton
            // 
            this.BilladdRowButton.Location = new System.Drawing.Point(835, 633);
            this.BilladdRowButton.Name = "BilladdRowButton";
            this.BilladdRowButton.Size = new System.Drawing.Size(133, 31);
            this.BilladdRowButton.TabIndex = 51;
            this.BilladdRowButton.Text = "Añadir fila";
            this.BilladdRowButton.UseVisualStyleBackColor = true;
            this.BilladdRowButton.Click += new System.EventHandler(this.BilladdRowButton_Click_1);
            // 
            // BillprintBillButton
            // 
            this.BillprintBillButton.Location = new System.Drawing.Point(1098, 8);
            this.BillprintBillButton.Name = "BillprintBillButton";
            this.BillprintBillButton.Size = new System.Drawing.Size(133, 46);
            this.BillprintBillButton.TabIndex = 50;
            this.BillprintBillButton.Text = "Imprimir";
            this.BillprintBillButton.UseVisualStyleBackColor = true;
            this.BillprintBillButton.Click += new System.EventHandler(this.BillprintBillButton_Click);
            // 
            // BillPaymentCondition
            // 
            this.BillPaymentCondition.Location = new System.Drawing.Point(835, 270);
            this.BillPaymentCondition.Name = "BillPaymentCondition";
            this.BillPaymentCondition.Size = new System.Drawing.Size(398, 22);
            this.BillPaymentCondition.TabIndex = 49;
            // 
            // BillPaymentoCondition
            // 
            this.BillPaymentoCondition.AutoSize = true;
            this.BillPaymentoCondition.BackColor = System.Drawing.Color.Transparent;
            this.BillPaymentoCondition.Location = new System.Drawing.Point(832, 251);
            this.BillPaymentoCondition.Name = "BillPaymentoCondition";
            this.BillPaymentoCondition.Size = new System.Drawing.Size(121, 16);
            this.BillPaymentoCondition.TabIndex = 48;
            this.BillPaymentoCondition.Text = "Condición de pago";
            // 
            // BillDateTimePicker
            // 
            this.BillDateTimePicker.Location = new System.Drawing.Point(835, 204);
            this.BillDateTimePicker.Name = "BillDateTimePicker";
            this.BillDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.BillDateTimePicker.TabIndex = 47;
            // 
            // BillDateFactureLabelPicker
            // 
            this.BillDateFactureLabelPicker.AutoSize = true;
            this.BillDateFactureLabelPicker.BackColor = System.Drawing.Color.Transparent;
            this.BillDateFactureLabelPicker.Location = new System.Drawing.Point(832, 185);
            this.BillDateFactureLabelPicker.Name = "BillDateFactureLabelPicker";
            this.BillDateFactureLabelPicker.Size = new System.Drawing.Size(121, 16);
            this.BillDateFactureLabelPicker.TabIndex = 46;
            this.BillDateFactureLabelPicker.Text = "Fecha de la factura";
            // 
            // BillClientNameCmbx
            // 
            this.BillClientNameCmbx.FormattingEnabled = true;
            this.BillClientNameCmbx.Location = new System.Drawing.Point(835, 80);
            this.BillClientNameCmbx.Name = "BillClientNameCmbx";
            this.BillClientNameCmbx.Size = new System.Drawing.Size(398, 24);
            this.BillClientNameCmbx.TabIndex = 45;
            // 
            // BillDepartmentLabell
            // 
            this.BillDepartmentLabell.AutoSize = true;
            this.BillDepartmentLabell.BackColor = System.Drawing.Color.Transparent;
            this.BillDepartmentLabell.Location = new System.Drawing.Point(101, 212);
            this.BillDepartmentLabell.Name = "BillDepartmentLabell";
            this.BillDepartmentLabell.Size = new System.Drawing.Size(93, 16);
            this.BillDepartmentLabell.TabIndex = 62;
            this.BillDepartmentLabell.Text = "Departamento";
            // 
            // BillClientLabel
            // 
            this.BillClientLabel.AutoSize = true;
            this.BillClientLabel.BackColor = System.Drawing.Color.Transparent;
            this.BillClientLabel.Location = new System.Drawing.Point(61, 151);
            this.BillClientLabel.Name = "BillClientLabel";
            this.BillClientLabel.Size = new System.Drawing.Size(48, 16);
            this.BillClientLabel.TabIndex = 61;
            this.BillClientLabel.Text = "Cliente";
            // 
            // BillMunicipioLabel
            // 
            this.BillMunicipioLabel.AutoSize = true;
            this.BillMunicipioLabel.BackColor = System.Drawing.Color.Transparent;
            this.BillMunicipioLabel.Location = new System.Drawing.Point(73, 197);
            this.BillMunicipioLabel.Name = "BillMunicipioLabel";
            this.BillMunicipioLabel.Size = new System.Drawing.Size(64, 16);
            this.BillMunicipioLabel.TabIndex = 60;
            this.BillMunicipioLabel.Text = "Municipio";
            // 
            // BillRegisterLabel
            // 
            this.BillRegisterLabel.AutoSize = true;
            this.BillRegisterLabel.BackColor = System.Drawing.Color.Transparent;
            this.BillRegisterLabel.Location = new System.Drawing.Point(78, 167);
            this.BillRegisterLabel.Name = "BillRegisterLabel";
            this.BillRegisterLabel.Size = new System.Drawing.Size(58, 16);
            this.BillRegisterLabel.TabIndex = 59;
            this.BillRegisterLabel.Text = "Registro";
            // 
            // BillPayConditions
            // 
            this.BillPayConditions.AutoSize = true;
            this.BillPayConditions.BackColor = System.Drawing.Color.Transparent;
            this.BillPayConditions.Location = new System.Drawing.Point(664, 210);
            this.BillPayConditions.Name = "BillPayConditions";
            this.BillPayConditions.Size = new System.Drawing.Size(121, 16);
            this.BillPayConditions.TabIndex = 58;
            this.BillPayConditions.Text = "Condición de pago";
            // 
            // BillDateLabel
            // 
            this.BillDateLabel.AutoSize = true;
            this.BillDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.BillDateLabel.Location = new System.Drawing.Point(582, 149);
            this.BillDateLabel.Name = "BillDateLabel";
            this.BillDateLabel.Size = new System.Drawing.Size(45, 16);
            this.BillDateLabel.TabIndex = 57;
            this.BillDateLabel.Text = "Fecha";
            // 
            // BillNITclient
            // 
            this.BillNITclient.AutoSize = true;
            this.BillNITclient.BackColor = System.Drawing.Color.Transparent;
            this.BillNITclient.Location = new System.Drawing.Point(566, 195);
            this.BillNITclient.Name = "BillNITclient";
            this.BillNITclient.Size = new System.Drawing.Size(29, 16);
            this.BillNITclient.TabIndex = 56;
            this.BillNITclient.Text = "NIT";
            // 
            // BillVtasNoSujetas
            // 
            this.BillVtasNoSujetas.AutoSize = true;
            this.BillVtasNoSujetas.BackColor = System.Drawing.Color.Transparent;
            this.BillVtasNoSujetas.Location = new System.Drawing.Point(753, 729);
            this.BillVtasNoSujetas.Name = "BillVtasNoSujetas";
            this.BillVtasNoSujetas.Size = new System.Drawing.Size(14, 16);
            this.BillVtasNoSujetas.TabIndex = 69;
            this.BillVtasNoSujetas.Text = "0";
            // 
            // BillVtasTotal
            // 
            this.BillVtasTotal.AutoSize = true;
            this.BillVtasTotal.BackColor = System.Drawing.Color.Transparent;
            this.BillVtasTotal.Location = new System.Drawing.Point(753, 761);
            this.BillVtasTotal.Name = "BillVtasTotal";
            this.BillVtasTotal.Size = new System.Drawing.Size(14, 16);
            this.BillVtasTotal.TabIndex = 68;
            this.BillVtasTotal.Text = "0";
            // 
            // BillSumas
            // 
            this.BillSumas.AutoSize = true;
            this.BillSumas.BackColor = System.Drawing.Color.Transparent;
            this.BillSumas.Location = new System.Drawing.Point(754, 665);
            this.BillSumas.Name = "BillSumas";
            this.BillSumas.Size = new System.Drawing.Size(14, 16);
            this.BillSumas.TabIndex = 66;
            this.BillSumas.Text = "0";
            this.BillSumas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BillVtasExentas
            // 
            this.BillVtasExentas.AutoSize = true;
            this.BillVtasExentas.BackColor = System.Drawing.Color.Transparent;
            this.BillVtasExentas.Location = new System.Drawing.Point(753, 745);
            this.BillVtasExentas.Name = "BillVtasExentas";
            this.BillVtasExentas.Size = new System.Drawing.Size(14, 16);
            this.BillVtasExentas.TabIndex = 65;
            this.BillVtasExentas.Text = "0";
            // 
            // BillIVARetenido
            // 
            this.BillIVARetenido.AutoSize = true;
            this.BillIVARetenido.BackColor = System.Drawing.Color.Transparent;
            this.BillIVARetenido.Location = new System.Drawing.Point(753, 713);
            this.BillIVARetenido.Name = "BillIVARetenido";
            this.BillIVARetenido.Size = new System.Drawing.Size(14, 16);
            this.BillIVARetenido.TabIndex = 64;
            this.BillIVARetenido.Text = "0";
            // 
            // billTableProducts
            // 
            this.billTableProducts.ColumnCount = 6;
            this.billTableProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.billTableProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 424F));
            this.billTableProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.billTableProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.billTableProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.billTableProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.billTableProducts.Location = new System.Drawing.Point(7, 256);
            this.billTableProducts.Name = "billTableProducts";
            this.billTableProducts.RowCount = 1;
            this.billTableProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.billTableProducts.Size = new System.Drawing.Size(802, 405);
            this.billTableProducts.TabIndex = 70;
            // 
            // BillDescripcionTextbox
            // 
            this.BillDescripcionTextbox.AcceptsReturn = true;
            this.BillDescripcionTextbox.Location = new System.Drawing.Point(837, 436);
            this.BillDescripcionTextbox.Multiline = true;
            this.BillDescripcionTextbox.Name = "BillDescripcionTextbox";
            this.BillDescripcionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BillDescripcionTextbox.Size = new System.Drawing.Size(392, 178);
            this.BillDescripcionTextbox.TabIndex = 80;
            // 
            // BillVentasExentasTextBox
            // 
            this.BillVentasExentasTextBox.Location = new System.Drawing.Point(835, 386);
            this.BillVentasExentasTextBox.Name = "BillVentasExentasTextBox";
            this.BillVentasExentasTextBox.Size = new System.Drawing.Size(100, 22);
            this.BillVentasExentasTextBox.TabIndex = 79;
            // 
            // TittleDescripcion
            // 
            this.TittleDescripcion.AutoSize = true;
            this.TittleDescripcion.Location = new System.Drawing.Point(837, 417);
            this.TittleDescripcion.Name = "TittleDescripcion";
            this.TittleDescripcion.Size = new System.Drawing.Size(79, 16);
            this.TittleDescripcion.TabIndex = 78;
            this.TittleDescripcion.Text = "Descripción";
            // 
            // TittleVentasExentasLabel
            // 
            this.TittleVentasExentasLabel.AutoSize = true;
            this.TittleVentasExentasLabel.Location = new System.Drawing.Point(835, 367);
            this.TittleVentasExentasLabel.Name = "TittleVentasExentasLabel";
            this.TittleVentasExentasLabel.Size = new System.Drawing.Size(100, 16);
            this.TittleVentasExentasLabel.TabIndex = 77;
            this.TittleVentasExentasLabel.Text = "Ventas Exentas";
            // 
            // ventasNoSujetasLabel
            // 
            this.ventasNoSujetasLabel.AutoSize = true;
            this.ventasNoSujetasLabel.Location = new System.Drawing.Point(1025, 295);
            this.ventasNoSujetasLabel.Name = "ventasNoSujetasLabel";
            this.ventasNoSujetasLabel.Size = new System.Drawing.Size(113, 16);
            this.ventasNoSujetasLabel.TabIndex = 76;
            this.ventasNoSujetasLabel.Text = "Ventas no sujetas";
            // 
            // BillVtasNoSujetasTextBox
            // 
            this.BillVtasNoSujetasTextBox.Location = new System.Drawing.Point(1028, 320);
            this.BillVtasNoSujetasTextBox.Name = "BillVtasNoSujetasTextBox";
            this.BillVtasNoSujetasTextBox.Size = new System.Drawing.Size(110, 22);
            this.BillVtasNoSujetasTextBox.TabIndex = 75;
            // 
            // BillUnitPriceTextbox
            // 
            this.BillUnitPriceTextbox.Location = new System.Drawing.Point(917, 320);
            this.BillUnitPriceTextbox.Name = "BillUnitPriceTextbox";
            this.BillUnitPriceTextbox.Size = new System.Drawing.Size(92, 22);
            this.BillUnitPriceTextbox.TabIndex = 74;
            // 
            // pUnitLabel
            // 
            this.pUnitLabel.AutoSize = true;
            this.pUnitLabel.Location = new System.Drawing.Point(917, 295);
            this.pUnitLabel.Name = "pUnitLabel";
            this.pUnitLabel.Size = new System.Drawing.Size(92, 16);
            this.pUnitLabel.TabIndex = 73;
            this.pUnitLabel.Text = "Precio unitario";
            // 
            // billCantTextbox
            // 
            this.billCantTextbox.Location = new System.Drawing.Point(832, 320);
            this.billCantTextbox.Name = "billCantTextbox";
            this.billCantTextbox.Size = new System.Drawing.Size(61, 22);
            this.billCantTextbox.TabIndex = 72;
            // 
            // tittleCantLabel
            // 
            this.tittleCantLabel.AutoSize = true;
            this.tittleCantLabel.Location = new System.Drawing.Point(832, 295);
            this.tittleCantLabel.Name = "tittleCantLabel";
            this.tittleCantLabel.Size = new System.Drawing.Size(61, 16);
            this.tittleCantLabel.TabIndex = 71;
            this.tittleCantLabel.Text = "Cantidad";
            // 
            // bigBuyerRadioButton
            // 
            this.bigBuyerRadioButton.AutoSize = true;
            this.bigBuyerRadioButton.Location = new System.Drawing.Point(840, 124);
            this.bigBuyerRadioButton.Name = "bigBuyerRadioButton";
            this.bigBuyerRadioButton.Size = new System.Drawing.Size(146, 20);
            this.bigBuyerRadioButton.TabIndex = 81;
            this.bigBuyerRadioButton.TabStop = true;
            this.bigBuyerRadioButton.Text = "Contribuidor grande";
            this.bigBuyerRadioButton.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.ImprimirCréditoFiscal);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.BillNITclient);
            this.panel1.Controls.Add(this.BillDateLabel);
            this.panel1.Controls.Add(this.BillPayConditions);
            this.panel1.Controls.Add(this.BillRegisterLabel);
            this.panel1.Controls.Add(this.BillMunicipioLabel);
            this.panel1.Controls.Add(this.BillClientLabel);
            this.panel1.Controls.Add(this.BillDepartmentLabell);
            this.panel1.Controls.Add(this.BillIVARetenido);
            this.panel1.Controls.Add(this.BillVtasExentas);
            this.panel1.Controls.Add(this.BillSumas);
            this.panel1.Controls.Add(this.BillVtasTotal);
            this.panel1.Controls.Add(this.billTableProducts);
            this.panel1.Controls.Add(this.BillVtasNoSujetas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 1056);
            this.panel1.TabIndex = 82;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bigBuyerRadioButton);
            this.Controls.Add(this.BillDescripcionTextbox);
            this.Controls.Add(this.BillVentasExentasTextBox);
            this.Controls.Add(this.TittleDescripcion);
            this.Controls.Add(this.TittleVentasExentasLabel);
            this.Controls.Add(this.ventasNoSujetasLabel);
            this.Controls.Add(this.BillVtasNoSujetasTextBox);
            this.Controls.Add(this.BillUnitPriceTextbox);
            this.Controls.Add(this.pUnitLabel);
            this.Controls.Add(this.billCantTextbox);
            this.Controls.Add(this.tittleCantLabel);
            this.Controls.Add(this.BillClientNameLabel);
            this.Controls.Add(this.BilldeleteRowButton);
            this.Controls.Add(this.BilladdRowButton);
            this.Controls.Add(this.BillprintBillButton);
            this.Controls.Add(this.BillPaymentCondition);
            this.Controls.Add(this.BillPaymentoCondition);
            this.Controls.Add(this.BillDateTimePicker);
            this.Controls.Add(this.BillDateFactureLabelPicker);
            this.Controls.Add(this.BillClientNameCmbx);
            this.Controls.Add(this.fiscalCreditCancelButton);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fiscalCreditCancelButton;
        private System.Windows.Forms.Label BillClientNameLabel;
        private System.Windows.Forms.Button BilldeleteRowButton;
        private System.Windows.Forms.Button BilladdRowButton;
        private System.Windows.Forms.Button BillprintBillButton;
        private System.Windows.Forms.TextBox BillPaymentCondition;
        private System.Windows.Forms.Label BillPaymentoCondition;
        private System.Windows.Forms.DateTimePicker BillDateTimePicker;
        private System.Windows.Forms.Label BillDateFactureLabelPicker;
        private System.Windows.Forms.ComboBox BillClientNameCmbx;
        private System.Windows.Forms.Label BillDepartmentLabell;
        private System.Windows.Forms.Label BillClientLabel;
        private System.Windows.Forms.Label BillMunicipioLabel;
        private System.Windows.Forms.Label BillRegisterLabel;
        private System.Windows.Forms.Label BillPayConditions;
        private System.Windows.Forms.Label BillDateLabel;
        private System.Windows.Forms.Label BillNITclient;
        private System.Windows.Forms.Label BillVtasNoSujetas;
        private System.Windows.Forms.Label BillVtasTotal;
        private System.Windows.Forms.Label BillSumas;
        private System.Windows.Forms.Label BillVtasExentas;
        private System.Windows.Forms.Label BillIVARetenido;
        private System.Windows.Forms.TableLayoutPanel billTableProducts;
        private System.Windows.Forms.TextBox BillDescripcionTextbox;
        private System.Windows.Forms.TextBox BillVentasExentasTextBox;
        private System.Windows.Forms.Label TittleDescripcion;
        private System.Windows.Forms.Label TittleVentasExentasLabel;
        private System.Windows.Forms.Label ventasNoSujetasLabel;
        private System.Windows.Forms.TextBox BillVtasNoSujetasTextBox;
        private System.Windows.Forms.TextBox BillUnitPriceTextbox;
        private System.Windows.Forms.Label pUnitLabel;
        private System.Windows.Forms.TextBox billCantTextbox;
        private System.Windows.Forms.Label tittleCantLabel;
        private System.Windows.Forms.RadioButton bigBuyerRadioButton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}