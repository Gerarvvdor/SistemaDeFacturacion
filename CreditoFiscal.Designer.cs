namespace Sistema_de_Facturación_local_MPService
{
    partial class CreditoFiscal
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
            this.FCdeleteRowButton = new System.Windows.Forms.Button();
            this.FCaddRowButton = new System.Windows.Forms.Button();
            this.productsTable = new System.Windows.Forms.TableLayoutPanel();
            this.FCprintBillButton = new System.Windows.Forms.Button();
            this.FCPaymentCondition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FCPayConditions = new System.Windows.Forms.Label();
            this.FCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.billDateFactureLabelPicker = new System.Windows.Forms.Label();
            this.FCDateLabel = new System.Windows.Forms.Label();
            this.FCNITclient = new System.Windows.Forms.Label();
            this.FCGiroClient = new System.Windows.Forms.Label();
            this.FCRegisterClient = new System.Windows.Forms.Label();
            this.FCclientNameCmbx = new System.Windows.Forms.ComboBox();
            this.FCCancelButton = new System.Windows.Forms.Button();
            this.FCDepartmentLabell = new System.Windows.Forms.Label();
            this.FCClientLabel = new System.Windows.Forms.Label();
            this.FCMunicipioLabel = new System.Windows.Forms.Label();
            this.FCAddressLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FCClientNameLabel = new System.Windows.Forms.Label();
            this.FCIVALabel = new System.Windows.Forms.Label();
            this.IVARetenidoLabel = new System.Windows.Forms.Label();
            this.VtasExentas = new System.Windows.Forms.Label();
            this.FCsumasLabel = new System.Windows.Forms.Label();
            this.VtasNoSujetasLabel = new System.Windows.Forms.Label();
            this.FCsubTotalLabel = new System.Windows.Forms.Label();
            this.ventasTotalLabel = new System.Windows.Forms.Label();
            this.tittleCantLabel = new System.Windows.Forms.Label();
            this.cantTextbox = new System.Windows.Forms.TextBox();
            this.unitPriceTextbox = new System.Windows.Forms.TextBox();
            this.pUnitLabel = new System.Windows.Forms.Label();
            this.VtasNoSujetasTextBox = new System.Windows.Forms.TextBox();
            this.ventasNoSujetasLabel = new System.Windows.Forms.Label();
            this.TittleVentasExentasLabel = new System.Windows.Forms.Label();
            this.TittleDescripcion = new System.Windows.Forms.Label();
            this.VentasExentasTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextbox = new System.Windows.Forms.TextBox();
            this.bigBuyerRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FCdeleteRowButton
            // 
            this.FCdeleteRowButton.Location = new System.Drawing.Point(977, 656);
            this.FCdeleteRowButton.Name = "FCdeleteRowButton";
            this.FCdeleteRowButton.Size = new System.Drawing.Size(133, 31);
            this.FCdeleteRowButton.TabIndex = 37;
            this.FCdeleteRowButton.Text = "Eliminar de tabla";
            this.FCdeleteRowButton.UseVisualStyleBackColor = true;
            this.FCdeleteRowButton.Click += new System.EventHandler(this.FCdeleteRowButton_Click);
            // 
            // FCaddRowButton
            // 
            this.FCaddRowButton.Location = new System.Drawing.Point(838, 656);
            this.FCaddRowButton.Name = "FCaddRowButton";
            this.FCaddRowButton.Size = new System.Drawing.Size(133, 31);
            this.FCaddRowButton.TabIndex = 36;
            this.FCaddRowButton.Text = "Añadir a tabla";
            this.FCaddRowButton.UseVisualStyleBackColor = true;
            this.FCaddRowButton.Click += new System.EventHandler(this.FCaddRowButton_Click);
            // 
            // productsTable
            // 
            this.productsTable.ColumnCount = 6;
            this.productsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.59322F));
            this.productsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.40678F));
            this.productsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.productsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.productsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.productsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.productsTable.Location = new System.Drawing.Point(18, 308);
            this.productsTable.Name = "productsTable";
            this.productsTable.RowCount = 1;
            this.productsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.productsTable.Size = new System.Drawing.Size(794, 410);
            this.productsTable.TabIndex = 35;
            // 
            // FCprintBillButton
            // 
            this.FCprintBillButton.Location = new System.Drawing.Point(1098, 12);
            this.FCprintBillButton.Name = "FCprintBillButton";
            this.FCprintBillButton.Size = new System.Drawing.Size(133, 46);
            this.FCprintBillButton.TabIndex = 34;
            this.FCprintBillButton.Text = "Imprimir";
            this.FCprintBillButton.UseVisualStyleBackColor = true;
            this.FCprintBillButton.Click += new System.EventHandler(this.printBillButton_Click);
            // 
            // FCPaymentCondition
            // 
            this.FCPaymentCondition.Location = new System.Drawing.Point(837, 270);
            this.FCPaymentCondition.Name = "FCPaymentCondition";
            this.FCPaymentCondition.Size = new System.Drawing.Size(395, 22);
            this.FCPaymentCondition.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(834, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Condición de pago";
            // 
            // FCPayConditions
            // 
            this.FCPayConditions.AutoSize = true;
            this.FCPayConditions.BackColor = System.Drawing.Color.Transparent;
            this.FCPayConditions.Location = new System.Drawing.Point(678, 267);
            this.FCPayConditions.Name = "FCPayConditions";
            this.FCPayConditions.Size = new System.Drawing.Size(121, 16);
            this.FCPayConditions.TabIndex = 31;
            this.FCPayConditions.Text = "Condición de pago";
            // 
            // FCDateTimePicker
            // 
            this.FCDateTimePicker.Location = new System.Drawing.Point(838, 193);
            this.FCDateTimePicker.Name = "FCDateTimePicker";
            this.FCDateTimePicker.Size = new System.Drawing.Size(263, 22);
            this.FCDateTimePicker.TabIndex = 30;
            // 
            // billDateFactureLabelPicker
            // 
            this.billDateFactureLabelPicker.AutoSize = true;
            this.billDateFactureLabelPicker.BackColor = System.Drawing.Color.Transparent;
            this.billDateFactureLabelPicker.Location = new System.Drawing.Point(838, 174);
            this.billDateFactureLabelPicker.Name = "billDateFactureLabelPicker";
            this.billDateFactureLabelPicker.Size = new System.Drawing.Size(121, 16);
            this.billDateFactureLabelPicker.TabIndex = 29;
            this.billDateFactureLabelPicker.Text = "Fecha de la factura";
            // 
            // FCDateLabel
            // 
            this.FCDateLabel.AutoSize = true;
            this.FCDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.FCDateLabel.Location = new System.Drawing.Point(597, 204);
            this.FCDateLabel.Name = "FCDateLabel";
            this.FCDateLabel.Size = new System.Drawing.Size(45, 16);
            this.FCDateLabel.TabIndex = 28;
            this.FCDateLabel.Text = "Fecha";
            // 
            // FCNITclient
            // 
            this.FCNITclient.AutoSize = true;
            this.FCNITclient.BackColor = System.Drawing.Color.Transparent;
            this.FCNITclient.Location = new System.Drawing.Point(577, 252);
            this.FCNITclient.Name = "FCNITclient";
            this.FCNITclient.Size = new System.Drawing.Size(29, 16);
            this.FCNITclient.TabIndex = 27;
            this.FCNITclient.Text = "NIT";
            // 
            // FCGiroClient
            // 
            this.FCGiroClient.AutoSize = true;
            this.FCGiroClient.BackColor = System.Drawing.Color.Transparent;
            this.FCGiroClient.Location = new System.Drawing.Point(584, 236);
            this.FCGiroClient.Name = "FCGiroClient";
            this.FCGiroClient.Size = new System.Drawing.Size(32, 16);
            this.FCGiroClient.TabIndex = 26;
            this.FCGiroClient.Text = "Giro";
            // 
            // FCRegisterClient
            // 
            this.FCRegisterClient.AutoSize = true;
            this.FCRegisterClient.BackColor = System.Drawing.Color.Transparent;
            this.FCRegisterClient.Location = new System.Drawing.Point(610, 220);
            this.FCRegisterClient.Name = "FCRegisterClient";
            this.FCRegisterClient.Size = new System.Drawing.Size(58, 16);
            this.FCRegisterClient.TabIndex = 25;
            this.FCRegisterClient.Text = "Registro";
            // 
            // FCclientNameCmbx
            // 
            this.FCclientNameCmbx.FormattingEnabled = true;
            this.FCclientNameCmbx.Location = new System.Drawing.Point(837, 75);
            this.FCclientNameCmbx.Name = "FCclientNameCmbx";
            this.FCclientNameCmbx.Size = new System.Drawing.Size(395, 24);
            this.FCclientNameCmbx.TabIndex = 24;
            // 
            // FCCancelButton
            // 
            this.FCCancelButton.Location = new System.Drawing.Point(12, 12);
            this.FCCancelButton.Name = "FCCancelButton";
            this.FCCancelButton.Size = new System.Drawing.Size(133, 46);
            this.FCCancelButton.TabIndex = 38;
            this.FCCancelButton.Text = "Regresar";
            this.FCCancelButton.UseVisualStyleBackColor = true;
            this.FCCancelButton.Click += new System.EventHandler(this.fiscalCreditCancelButton_Click);
            // 
            // FCDepartmentLabell
            // 
            this.FCDepartmentLabell.AutoSize = true;
            this.FCDepartmentLabell.BackColor = System.Drawing.Color.Transparent;
            this.FCDepartmentLabell.Location = new System.Drawing.Point(119, 267);
            this.FCDepartmentLabell.Name = "FCDepartmentLabell";
            this.FCDepartmentLabell.Size = new System.Drawing.Size(93, 16);
            this.FCDepartmentLabell.TabIndex = 43;
            this.FCDepartmentLabell.Text = "Departamento";
            // 
            // FCClientLabel
            // 
            this.FCClientLabel.AutoSize = true;
            this.FCClientLabel.BackColor = System.Drawing.Color.Transparent;
            this.FCClientLabel.Location = new System.Drawing.Point(76, 204);
            this.FCClientLabel.Name = "FCClientLabel";
            this.FCClientLabel.Size = new System.Drawing.Size(48, 16);
            this.FCClientLabel.TabIndex = 42;
            this.FCClientLabel.Text = "Cliente";
            // 
            // FCMunicipioLabel
            // 
            this.FCMunicipioLabel.AutoSize = true;
            this.FCMunicipioLabel.BackColor = System.Drawing.Color.Transparent;
            this.FCMunicipioLabel.Location = new System.Drawing.Point(86, 252);
            this.FCMunicipioLabel.Name = "FCMunicipioLabel";
            this.FCMunicipioLabel.Size = new System.Drawing.Size(64, 16);
            this.FCMunicipioLabel.TabIndex = 41;
            this.FCMunicipioLabel.Text = "Municipio";
            // 
            // FCAddressLabel
            // 
            this.FCAddressLabel.AutoSize = true;
            this.FCAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.FCAddressLabel.Location = new System.Drawing.Point(89, 220);
            this.FCAddressLabel.Name = "FCAddressLabel";
            this.FCAddressLabel.Size = new System.Drawing.Size(58, 16);
            this.FCAddressLabel.TabIndex = 39;
            this.FCAddressLabel.Text = "Registro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_de_Facturación_local_MPService.Properties.Resources.SCN_0003;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(816, 1056);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FCClientNameLabel
            // 
            this.FCClientNameLabel.AutoSize = true;
            this.FCClientNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FCClientNameLabel.Location = new System.Drawing.Point(837, 49);
            this.FCClientNameLabel.Name = "FCClientNameLabel";
            this.FCClientNameLabel.Size = new System.Drawing.Size(48, 16);
            this.FCClientNameLabel.TabIndex = 44;
            this.FCClientNameLabel.Text = "Cliente";
            // 
            // FCIVALabel
            // 
            this.FCIVALabel.AutoSize = true;
            this.FCIVALabel.BackColor = System.Drawing.Color.Transparent;
            this.FCIVALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FCIVALabel.Location = new System.Drawing.Point(730, 741);
            this.FCIVALabel.Name = "FCIVALabel";
            this.FCIVALabel.Size = new System.Drawing.Size(14, 15);
            this.FCIVALabel.TabIndex = 45;
            this.FCIVALabel.Text = "0";
            // 
            // IVARetenidoLabel
            // 
            this.IVARetenidoLabel.AutoSize = true;
            this.IVARetenidoLabel.BackColor = System.Drawing.Color.Transparent;
            this.IVARetenidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IVARetenidoLabel.Location = new System.Drawing.Point(730, 773);
            this.IVARetenidoLabel.Name = "IVARetenidoLabel";
            this.IVARetenidoLabel.Size = new System.Drawing.Size(14, 15);
            this.IVARetenidoLabel.TabIndex = 46;
            this.IVARetenidoLabel.Text = "0";
            // 
            // VtasExentas
            // 
            this.VtasExentas.AutoSize = true;
            this.VtasExentas.BackColor = System.Drawing.Color.Transparent;
            this.VtasExentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VtasExentas.Location = new System.Drawing.Point(730, 806);
            this.VtasExentas.Name = "VtasExentas";
            this.VtasExentas.Size = new System.Drawing.Size(14, 15);
            this.VtasExentas.TabIndex = 47;
            this.VtasExentas.Text = "0";
            // 
            // FCsumasLabel
            // 
            this.FCsumasLabel.AutoSize = true;
            this.FCsumasLabel.BackColor = System.Drawing.Color.Transparent;
            this.FCsumasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FCsumasLabel.Location = new System.Drawing.Point(730, 723);
            this.FCsumasLabel.Name = "FCsumasLabel";
            this.FCsumasLabel.Size = new System.Drawing.Size(14, 15);
            this.FCsumasLabel.TabIndex = 48;
            this.FCsumasLabel.Text = "0";
            // 
            // VtasNoSujetasLabel
            // 
            this.VtasNoSujetasLabel.AutoSize = true;
            this.VtasNoSujetasLabel.BackColor = System.Drawing.Color.Transparent;
            this.VtasNoSujetasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.VtasNoSujetasLabel.Location = new System.Drawing.Point(730, 791);
            this.VtasNoSujetasLabel.Name = "VtasNoSujetasLabel";
            this.VtasNoSujetasLabel.Size = new System.Drawing.Size(14, 15);
            this.VtasNoSujetasLabel.TabIndex = 53;
            this.VtasNoSujetasLabel.Text = "0";
            // 
            // FCsubTotalLabel
            // 
            this.FCsubTotalLabel.AutoSize = true;
            this.FCsubTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.FCsubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.FCsubTotalLabel.Location = new System.Drawing.Point(730, 757);
            this.FCsubTotalLabel.Name = "FCsubTotalLabel";
            this.FCsubTotalLabel.Size = new System.Drawing.Size(14, 15);
            this.FCsubTotalLabel.TabIndex = 51;
            this.FCsubTotalLabel.Text = "0";
            // 
            // ventasTotalLabel
            // 
            this.ventasTotalLabel.AutoSize = true;
            this.ventasTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.ventasTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ventasTotalLabel.Location = new System.Drawing.Point(730, 823);
            this.ventasTotalLabel.Name = "ventasTotalLabel";
            this.ventasTotalLabel.Size = new System.Drawing.Size(14, 15);
            this.ventasTotalLabel.TabIndex = 52;
            this.ventasTotalLabel.Text = "0";
            // 
            // tittleCantLabel
            // 
            this.tittleCantLabel.AutoSize = true;
            this.tittleCantLabel.Location = new System.Drawing.Point(837, 317);
            this.tittleCantLabel.Name = "tittleCantLabel";
            this.tittleCantLabel.Size = new System.Drawing.Size(61, 16);
            this.tittleCantLabel.TabIndex = 55;
            this.tittleCantLabel.Text = "Cantidad";
            // 
            // cantTextbox
            // 
            this.cantTextbox.Location = new System.Drawing.Point(837, 342);
            this.cantTextbox.Name = "cantTextbox";
            this.cantTextbox.Size = new System.Drawing.Size(61, 22);
            this.cantTextbox.TabIndex = 56;
            // 
            // unitPriceTextbox
            // 
            this.unitPriceTextbox.Location = new System.Drawing.Point(922, 342);
            this.unitPriceTextbox.Name = "unitPriceTextbox";
            this.unitPriceTextbox.Size = new System.Drawing.Size(92, 22);
            this.unitPriceTextbox.TabIndex = 58;
            // 
            // pUnitLabel
            // 
            this.pUnitLabel.AutoSize = true;
            this.pUnitLabel.Location = new System.Drawing.Point(922, 317);
            this.pUnitLabel.Name = "pUnitLabel";
            this.pUnitLabel.Size = new System.Drawing.Size(92, 16);
            this.pUnitLabel.TabIndex = 57;
            this.pUnitLabel.Text = "Precio unitario";
            // 
            // VtasNoSujetasTextBox
            // 
            this.VtasNoSujetasTextBox.Location = new System.Drawing.Point(1033, 342);
            this.VtasNoSujetasTextBox.Name = "VtasNoSujetasTextBox";
            this.VtasNoSujetasTextBox.Size = new System.Drawing.Size(110, 22);
            this.VtasNoSujetasTextBox.TabIndex = 59;
            // 
            // ventasNoSujetasLabel
            // 
            this.ventasNoSujetasLabel.AutoSize = true;
            this.ventasNoSujetasLabel.Location = new System.Drawing.Point(1030, 317);
            this.ventasNoSujetasLabel.Name = "ventasNoSujetasLabel";
            this.ventasNoSujetasLabel.Size = new System.Drawing.Size(113, 16);
            this.ventasNoSujetasLabel.TabIndex = 60;
            this.ventasNoSujetasLabel.Text = "Ventas no sujetas";
            // 
            // TittleVentasExentasLabel
            // 
            this.TittleVentasExentasLabel.AutoSize = true;
            this.TittleVentasExentasLabel.Location = new System.Drawing.Point(840, 389);
            this.TittleVentasExentasLabel.Name = "TittleVentasExentasLabel";
            this.TittleVentasExentasLabel.Size = new System.Drawing.Size(100, 16);
            this.TittleVentasExentasLabel.TabIndex = 61;
            this.TittleVentasExentasLabel.Text = "Ventas Exentas";
            // 
            // TittleDescripcion
            // 
            this.TittleDescripcion.AutoSize = true;
            this.TittleDescripcion.Location = new System.Drawing.Point(841, 453);
            this.TittleDescripcion.Name = "TittleDescripcion";
            this.TittleDescripcion.Size = new System.Drawing.Size(79, 16);
            this.TittleDescripcion.TabIndex = 62;
            this.TittleDescripcion.Text = "Descripción";
            // 
            // VentasExentasTextBox
            // 
            this.VentasExentasTextBox.Location = new System.Drawing.Point(840, 408);
            this.VentasExentasTextBox.Name = "VentasExentasTextBox";
            this.VentasExentasTextBox.Size = new System.Drawing.Size(100, 22);
            this.VentasExentasTextBox.TabIndex = 63;
            // 
            // DescripcionTextbox
            // 
            this.DescripcionTextbox.AcceptsReturn = true;
            this.DescripcionTextbox.Location = new System.Drawing.Point(841, 472);
            this.DescripcionTextbox.Multiline = true;
            this.DescripcionTextbox.Name = "DescripcionTextbox";
            this.DescripcionTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DescripcionTextbox.Size = new System.Drawing.Size(392, 178);
            this.DescripcionTextbox.TabIndex = 64;
            // 
            // bigBuyerRadioButton
            // 
            this.bigBuyerRadioButton.AutoSize = true;
            this.bigBuyerRadioButton.Location = new System.Drawing.Point(837, 124);
            this.bigBuyerRadioButton.Name = "bigBuyerRadioButton";
            this.bigBuyerRadioButton.Size = new System.Drawing.Size(146, 20);
            this.bigBuyerRadioButton.TabIndex = 65;
            this.bigBuyerRadioButton.TabStop = true;
            this.bigBuyerRadioButton.Text = "Contribuidor grande";
            this.bigBuyerRadioButton.UseVisualStyleBackColor = true;
            // 
            // CreditoFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 1055);
            this.Controls.Add(this.bigBuyerRadioButton);
            this.Controls.Add(this.DescripcionTextbox);
            this.Controls.Add(this.VentasExentasTextBox);
            this.Controls.Add(this.TittleDescripcion);
            this.Controls.Add(this.TittleVentasExentasLabel);
            this.Controls.Add(this.ventasNoSujetasLabel);
            this.Controls.Add(this.VtasNoSujetasTextBox);
            this.Controls.Add(this.unitPriceTextbox);
            this.Controls.Add(this.pUnitLabel);
            this.Controls.Add(this.cantTextbox);
            this.Controls.Add(this.tittleCantLabel);
            this.Controls.Add(this.VtasNoSujetasLabel);
            this.Controls.Add(this.ventasTotalLabel);
            this.Controls.Add(this.FCsubTotalLabel);
            this.Controls.Add(this.FCsumasLabel);
            this.Controls.Add(this.VtasExentas);
            this.Controls.Add(this.IVARetenidoLabel);
            this.Controls.Add(this.FCIVALabel);
            this.Controls.Add(this.FCClientNameLabel);
            this.Controls.Add(this.FCDepartmentLabell);
            this.Controls.Add(this.FCClientLabel);
            this.Controls.Add(this.FCMunicipioLabel);
            this.Controls.Add(this.FCAddressLabel);
            this.Controls.Add(this.FCCancelButton);
            this.Controls.Add(this.FCdeleteRowButton);
            this.Controls.Add(this.FCaddRowButton);
            this.Controls.Add(this.productsTable);
            this.Controls.Add(this.FCprintBillButton);
            this.Controls.Add(this.FCPaymentCondition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FCPayConditions);
            this.Controls.Add(this.FCDateTimePicker);
            this.Controls.Add(this.billDateFactureLabelPicker);
            this.Controls.Add(this.FCDateLabel);
            this.Controls.Add(this.FCNITclient);
            this.Controls.Add(this.FCGiroClient);
            this.Controls.Add(this.FCRegisterClient);
            this.Controls.Add(this.FCclientNameCmbx);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreditoFiscal";
            this.Text = "CreditoFiscal";
            this.Load += new System.EventHandler(this.CreditoFiscal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FCdeleteRowButton;
        private System.Windows.Forms.Button FCaddRowButton;
        private System.Windows.Forms.TableLayoutPanel productsTable;
        private System.Windows.Forms.Button FCprintBillButton;
        private System.Windows.Forms.TextBox FCPaymentCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FCPayConditions;
        private System.Windows.Forms.DateTimePicker FCDateTimePicker;
        private System.Windows.Forms.Label billDateFactureLabelPicker;
        private System.Windows.Forms.Label FCDateLabel;
        private System.Windows.Forms.Label FCNITclient;
        private System.Windows.Forms.Label FCGiroClient;
        private System.Windows.Forms.Label FCRegisterClient;
        private System.Windows.Forms.ComboBox FCclientNameCmbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FCCancelButton;
        private System.Windows.Forms.Label FCDepartmentLabell;
        private System.Windows.Forms.Label FCClientLabel;
        private System.Windows.Forms.Label FCMunicipioLabel;
        private System.Windows.Forms.Label FCAddressLabel;
        private System.Windows.Forms.Label FCClientNameLabel;
        private System.Windows.Forms.Label FCIVALabel;
        private System.Windows.Forms.Label IVARetenidoLabel;
        private System.Windows.Forms.Label VtasExentas;
        private System.Windows.Forms.Label FCsumasLabel;
        private System.Windows.Forms.Label VtasNoSujetasLabel;
        private System.Windows.Forms.Label FCsubTotalLabel;
        private System.Windows.Forms.Label ventasTotalLabel;
        private System.Windows.Forms.Label tittleCantLabel;
        private System.Windows.Forms.TextBox cantTextbox;
        private System.Windows.Forms.TextBox unitPriceTextbox;
        private System.Windows.Forms.Label pUnitLabel;
        private System.Windows.Forms.TextBox VtasNoSujetasTextBox;
        private System.Windows.Forms.Label ventasNoSujetasLabel;
        private System.Windows.Forms.Label TittleVentasExentasLabel;
        private System.Windows.Forms.Label TittleDescripcion;
        private System.Windows.Forms.TextBox VentasExentasTextBox;
        private System.Windows.Forms.TextBox DescripcionTextbox;
        private System.Windows.Forms.RadioButton bigBuyerRadioButton;
    }
}