﻿namespace StockManagement.Design
{
    partial class PurchaseUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.purchaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.suplierComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceNoTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.invoiceNoErrorLabel = new System.Windows.Forms.Label();
            this.purchaseDateErrorlabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expireDatePicker = new System.Windows.Forms.DateTimePicker();
            this.manufacturedDatePicker = new System.Windows.Forms.DateTimePicker();
            this.remarkTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.addButton = new Guna.UI.WinForms.GunaButton();
            this.availableQuantityTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.MRPTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.previousMRPTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.previousUnitPriceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.totalPriceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.unitPriceTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.quantityTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.codeTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.productComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.categoryComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            this.productErrorLabel = new System.Windows.Forms.Label();
            this.unitPriceErrorLabel = new System.Windows.Forms.Label();
            this.quantityErrorLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitButton = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.showDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.purchaseDatePicker);
            this.groupBox1.Controls.Add(this.suplierComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.invoiceNoTextBox);
            this.groupBox1.Controls.Add(this.supplierLabel);
            this.groupBox1.Controls.Add(this.invoiceNoErrorLabel);
            this.groupBox1.Controls.Add(this.purchaseDateErrorlabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // purchaseDatePicker
            // 
            this.purchaseDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.purchaseDatePicker.Location = new System.Drawing.Point(85, 28);
            this.purchaseDatePicker.Name = "purchaseDatePicker";
            this.purchaseDatePicker.Size = new System.Drawing.Size(153, 25);
            this.purchaseDatePicker.TabIndex = 3;
            this.purchaseDatePicker.Value = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            // 
            // suplierComboBox
            // 
            this.suplierComboBox.BackColor = System.Drawing.Color.Transparent;
            this.suplierComboBox.BaseColor = System.Drawing.Color.White;
            this.suplierComboBox.BorderColor = System.Drawing.Color.Silver;
            this.suplierComboBox.BorderSize = 1;
            this.suplierComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.suplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suplierComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.suplierComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.suplierComboBox.ForeColor = System.Drawing.Color.Black;
            this.suplierComboBox.FormattingEnabled = true;
            this.suplierComboBox.Location = new System.Drawing.Point(85, 109);
            this.suplierComboBox.Name = "suplierComboBox";
            this.suplierComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.suplierComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.suplierComboBox.Size = new System.Drawing.Size(153, 26);
            this.suplierComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill/Invoice No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.BaseColor = System.Drawing.Color.White;
            this.invoiceNoTextBox.BorderColor = System.Drawing.Color.Silver;
            this.invoiceNoTextBox.BorderSize = 1;
            this.invoiceNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.invoiceNoTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.invoiceNoTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.invoiceNoTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.invoiceNoTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.invoiceNoTextBox.Location = new System.Drawing.Point(85, 68);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.PasswordChar = '\0';
            this.invoiceNoTextBox.Size = new System.Drawing.Size(153, 26);
            this.invoiceNoTextBox.TabIndex = 0;
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.ForeColor = System.Drawing.Color.Red;
            this.supplierLabel.Location = new System.Drawing.Point(83, 134);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(113, 13);
            this.supplierLabel.TabIndex = 1;
            this.supplierLabel.Text = "Please Select Supplier";
            // 
            // invoiceNoErrorLabel
            // 
            this.invoiceNoErrorLabel.AutoSize = true;
            this.invoiceNoErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceNoErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.invoiceNoErrorLabel.Location = new System.Drawing.Point(83, 94);
            this.invoiceNoErrorLabel.Name = "invoiceNoErrorLabel";
            this.invoiceNoErrorLabel.Size = new System.Drawing.Size(163, 13);
            this.invoiceNoErrorLabel.TabIndex = 1;
            this.invoiceNoErrorLabel.Text = "Please Enter Bill/Invoice Number";
            // 
            // purchaseDateErrorlabel
            // 
            this.purchaseDateErrorlabel.AutoSize = true;
            this.purchaseDateErrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseDateErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.purchaseDateErrorlabel.Location = new System.Drawing.Point(84, 52);
            this.purchaseDateErrorlabel.Name = "purchaseDateErrorlabel";
            this.purchaseDateErrorlabel.Size = new System.Drawing.Size(117, 13);
            this.purchaseDateErrorlabel.TabIndex = 1;
            this.purchaseDateErrorlabel.Text = "Please Select Category";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expireDatePicker);
            this.groupBox2.Controls.Add(this.manufacturedDatePicker);
            this.groupBox2.Controls.Add(this.remarkTextBox);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.MRPTextBox);
            this.groupBox2.Controls.Add(this.previousMRPTextBox);
            this.groupBox2.Controls.Add(this.previousUnitPriceTextBox);
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.unitPriceTextBox);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Controls.Add(this.productComboBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.categoryErrorLabel);
            this.groupBox2.Controls.Add(this.productErrorLabel);
            this.groupBox2.Controls.Add(this.unitPriceErrorLabel);
            this.groupBox2.Controls.Add(this.quantityErrorLabel);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(301, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 359);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase";
            // 
            // expireDatePicker
            // 
            this.expireDatePicker.CustomFormat = "--/--/----";
            this.expireDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expireDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDatePicker.Location = new System.Drawing.Point(106, 228);
            this.expireDatePicker.Name = "expireDatePicker";
            this.expireDatePicker.Size = new System.Drawing.Size(153, 25);
            this.expireDatePicker.TabIndex = 3;
            this.expireDatePicker.Value = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            this.expireDatePicker.ValueChanged += new System.EventHandler(this.expireDatePicker_ValueChanged);
            this.expireDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expireDatePicker_KeyDown);
            // 
            // manufacturedDatePicker
            // 
            this.manufacturedDatePicker.CustomFormat = "--/--/----";
            this.manufacturedDatePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manufacturedDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufacturedDatePicker.Location = new System.Drawing.Point(106, 188);
            this.manufacturedDatePicker.Name = "manufacturedDatePicker";
            this.manufacturedDatePicker.Size = new System.Drawing.Size(153, 25);
            this.manufacturedDatePicker.TabIndex = 3;
            this.manufacturedDatePicker.Value = new System.DateTime(2019, 10, 16, 0, 0, 0, 0);
            this.manufacturedDatePicker.ValueChanged += new System.EventHandler(this.manufacturedDatePicker_ValueChanged);
            this.manufacturedDatePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manufacturedDatePicker_KeyDown);
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.BaseColor = System.Drawing.Color.White;
            this.remarkTextBox.BorderColor = System.Drawing.Color.Silver;
            this.remarkTextBox.BorderSize = 1;
            this.remarkTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.remarkTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.remarkTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.remarkTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.remarkTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.remarkTextBox.Location = new System.Drawing.Point(106, 266);
            this.remarkTextBox.MultiLine = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.PasswordChar = '\0';
            this.remarkTextBox.Size = new System.Drawing.Size(446, 49);
            this.remarkTextBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.AnimationHoverSpeed = 0.07F;
            this.addButton.AnimationSpeed = 0.03F;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.addButton.BorderColor = System.Drawing.Color.Black;
            this.addButton.FocusedColor = System.Drawing.Color.Empty;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Image = null;
            this.addButton.ImageSize = new System.Drawing.Size(20, 20);
            this.addButton.Location = new System.Drawing.Point(422, 319);
            this.addButton.Name = "addButton";
            this.addButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.addButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.addButton.OnHoverForeColor = System.Drawing.Color.White;
            this.addButton.OnHoverImage = null;
            this.addButton.OnPressedColor = System.Drawing.Color.Black;
            this.addButton.Radius = 15;
            this.addButton.Size = new System.Drawing.Size(130, 34);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.BaseColor = System.Drawing.Color.White;
            this.availableQuantityTextBox.BorderColor = System.Drawing.Color.Silver;
            this.availableQuantityTextBox.BorderSize = 1;
            this.availableQuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.availableQuantityTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.availableQuantityTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.availableQuantityTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.availableQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.availableQuantityTextBox.Location = new System.Drawing.Point(105, 148);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.PasswordChar = '\0';
            this.availableQuantityTextBox.Size = new System.Drawing.Size(153, 26);
            this.availableQuantityTextBox.TabIndex = 0;
            // 
            // MRPTextBox
            // 
            this.MRPTextBox.BaseColor = System.Drawing.Color.White;
            this.MRPTextBox.BorderColor = System.Drawing.Color.Silver;
            this.MRPTextBox.BorderSize = 1;
            this.MRPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MRPTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.MRPTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.MRPTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.MRPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MRPTextBox.Location = new System.Drawing.Point(399, 227);
            this.MRPTextBox.Name = "MRPTextBox";
            this.MRPTextBox.PasswordChar = '\0';
            this.MRPTextBox.Size = new System.Drawing.Size(153, 26);
            this.MRPTextBox.TabIndex = 0;
            // 
            // previousMRPTextBox
            // 
            this.previousMRPTextBox.BaseColor = System.Drawing.Color.White;
            this.previousMRPTextBox.BorderColor = System.Drawing.Color.Silver;
            this.previousMRPTextBox.BorderSize = 1;
            this.previousMRPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.previousMRPTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.previousMRPTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.previousMRPTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.previousMRPTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.previousMRPTextBox.Location = new System.Drawing.Point(399, 187);
            this.previousMRPTextBox.Name = "previousMRPTextBox";
            this.previousMRPTextBox.PasswordChar = '\0';
            this.previousMRPTextBox.Size = new System.Drawing.Size(153, 26);
            this.previousMRPTextBox.TabIndex = 0;
            // 
            // previousUnitPriceTextBox
            // 
            this.previousUnitPriceTextBox.BaseColor = System.Drawing.Color.White;
            this.previousUnitPriceTextBox.BorderColor = System.Drawing.Color.Silver;
            this.previousUnitPriceTextBox.BorderSize = 1;
            this.previousUnitPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.previousUnitPriceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.previousUnitPriceTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.previousUnitPriceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.previousUnitPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.previousUnitPriceTextBox.Location = new System.Drawing.Point(399, 147);
            this.previousUnitPriceTextBox.Name = "previousUnitPriceTextBox";
            this.previousUnitPriceTextBox.PasswordChar = '\0';
            this.previousUnitPriceTextBox.Size = new System.Drawing.Size(153, 26);
            this.previousUnitPriceTextBox.TabIndex = 0;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.BaseColor = System.Drawing.Color.White;
            this.totalPriceTextBox.BorderColor = System.Drawing.Color.Silver;
            this.totalPriceTextBox.BorderSize = 1;
            this.totalPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.totalPriceTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.totalPriceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.totalPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalPriceTextBox.Location = new System.Drawing.Point(399, 108);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.PasswordChar = '\0';
            this.totalPriceTextBox.Size = new System.Drawing.Size(153, 26);
            this.totalPriceTextBox.TabIndex = 0;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.BaseColor = System.Drawing.Color.White;
            this.unitPriceTextBox.BorderColor = System.Drawing.Color.Silver;
            this.unitPriceTextBox.BorderSize = 1;
            this.unitPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitPriceTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.unitPriceTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.unitPriceTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.unitPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unitPriceTextBox.Location = new System.Drawing.Point(399, 68);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.PasswordChar = '\0';
            this.unitPriceTextBox.Size = new System.Drawing.Size(153, 26);
            this.unitPriceTextBox.TabIndex = 0;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.BaseColor = System.Drawing.Color.White;
            this.quantityTextBox.BorderColor = System.Drawing.Color.Silver;
            this.quantityTextBox.BorderSize = 1;
            this.quantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantityTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.quantityTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.quantityTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.quantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quantityTextBox.Location = new System.Drawing.Point(399, 27);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.PasswordChar = '\0';
            this.quantityTextBox.Size = new System.Drawing.Size(153, 26);
            this.quantityTextBox.TabIndex = 0;
            // 
            // codeTextBox
            // 
            this.codeTextBox.BaseColor = System.Drawing.Color.White;
            this.codeTextBox.BorderColor = System.Drawing.Color.Silver;
            this.codeTextBox.BorderSize = 1;
            this.codeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.codeTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.codeTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.codeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.codeTextBox.Location = new System.Drawing.Point(105, 108);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.Size = new System.Drawing.Size(153, 26);
            this.codeTextBox.TabIndex = 0;
            // 
            // productComboBox
            // 
            this.productComboBox.BackColor = System.Drawing.Color.Transparent;
            this.productComboBox.BaseColor = System.Drawing.Color.White;
            this.productComboBox.BorderColor = System.Drawing.Color.Silver;
            this.productComboBox.BorderSize = 1;
            this.productComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.productComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.productComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.productComboBox.ForeColor = System.Drawing.Color.Black;
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(105, 68);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.productComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.productComboBox.Size = new System.Drawing.Size(153, 26);
            this.productComboBox.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 267);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Remarks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Available Quantity";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.BackColor = System.Drawing.Color.Transparent;
            this.categoryComboBox.BaseColor = System.Drawing.Color.White;
            this.categoryComboBox.BorderColor = System.Drawing.Color.Silver;
            this.categoryComboBox.BorderSize = 1;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryComboBox.ForeColor = System.Drawing.Color.Black;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(105, 28);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.categoryComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.categoryComboBox.Size = new System.Drawing.Size(153, 26);
            this.categoryComboBox.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(339, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "MRP (TK.)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(295, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Pervious MRP (TK.)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(274, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pervious Unit Price (Tk.)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(312, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Total Price (TK.)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(317, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Unit Price (TK.)";
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.categoryErrorLabel.Location = new System.Drawing.Point(103, 53);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(117, 13);
            this.categoryErrorLabel.TabIndex = 1;
            this.categoryErrorLabel.Text = "Please Select Category";
            // 
            // productErrorLabel
            // 
            this.productErrorLabel.AutoSize = true;
            this.productErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.productErrorLabel.Location = new System.Drawing.Point(103, 93);
            this.productErrorLabel.Name = "productErrorLabel";
            this.productErrorLabel.Size = new System.Drawing.Size(112, 13);
            this.productErrorLabel.TabIndex = 1;
            this.productErrorLabel.Text = "Please Select Product";
            // 
            // unitPriceErrorLabel
            // 
            this.unitPriceErrorLabel.AutoSize = true;
            this.unitPriceErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.unitPriceErrorLabel.Location = new System.Drawing.Point(398, 93);
            this.unitPriceErrorLabel.Name = "unitPriceErrorLabel";
            this.unitPriceErrorLabel.Size = new System.Drawing.Size(81, 13);
            this.unitPriceErrorLabel.TabIndex = 1;
            this.unitPriceErrorLabel.Text = "Enter Unit Price";
            // 
            // quantityErrorLabel
            // 
            this.quantityErrorLabel.AutoSize = true;
            this.quantityErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.quantityErrorLabel.Location = new System.Drawing.Point(397, 52);
            this.quantityErrorLabel.Name = "quantityErrorLabel";
            this.quantityErrorLabel.Size = new System.Drawing.Size(74, 13);
            this.quantityErrorLabel.TabIndex = 1;
            this.quantityErrorLabel.Text = "Enter Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(350, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Code";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Expire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Manufactured Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category";
            // 
            // submitButton
            // 
            this.submitButton.AnimationHoverSpeed = 0.07F;
            this.submitButton.AnimationSpeed = 0.03F;
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(181)))));
            this.submitButton.BorderColor = System.Drawing.Color.Black;
            this.submitButton.FocusedColor = System.Drawing.Color.Empty;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Image = null;
            this.submitButton.ImageSize = new System.Drawing.Size(20, 20);
            this.submitButton.Location = new System.Drawing.Point(698, 124);
            this.submitButton.Name = "submitButton";
            this.submitButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.submitButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.submitButton.OnHoverForeColor = System.Drawing.Color.White;
            this.submitButton.OnHoverImage = null;
            this.submitButton.OnPressedColor = System.Drawing.Color.Black;
            this.submitButton.Radius = 15;
            this.submitButton.Size = new System.Drawing.Size(130, 34);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.showDataGridView);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Location = new System.Drawing.Point(23, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 164);
            this.panel1.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(426, 133);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(19, 15);
            this.gunaLabel2.TabIndex = 6;
            this.gunaLabel2.Text = "10";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(361, 132);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(65, 15);
            this.gunaLabel1.TabIndex = 6;
            this.gunaLabel1.Text = "Total Item :";
            // 
            // showDataGridView
            // 
            this.showDataGridView.AllowUserToAddRows = false;
            this.showDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.showDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.showDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.showDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.showDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.showDataGridView.ColumnHeadersHeight = 21;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.Action});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.showDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.showDataGridView.EnableHeadersVisualStyles = false;
            this.showDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.showDataGridView.Location = new System.Drawing.Point(3, -3);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.ReadOnly = true;
            this.showDataGridView.RowHeadersVisible = false;
            this.showDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showDataGridView.Size = new System.Drawing.Size(834, 123);
            this.showDataGridView.TabIndex = 0;
            this.showDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.FeterRiver;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.showDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.showDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.showDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(220)))), ((int)(((byte)(242)))));
            this.showDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.showDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.showDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.showDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.showDataGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.showDataGridView.ThemeStyle.ReadOnly = true;
            this.showDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.showDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.showDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.showDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.showDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.showDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.showDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // SL
            // 
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            this.SL.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            // 
            // PurchaseUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseUserControl";
            this.Size = new System.Drawing.Size(881, 570);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaComboBox suplierComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox invoiceNoTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaComboBox productComboBox;
        private Guna.UI.WinForms.GunaComboBox categoryComboBox;
        private Guna.UI.WinForms.GunaTextBox availableQuantityTextBox;
        private Guna.UI.WinForms.GunaTextBox totalPriceTextBox;
        private Guna.UI.WinForms.GunaTextBox unitPriceTextBox;
        private Guna.UI.WinForms.GunaTextBox quantityTextBox;
        private Guna.UI.WinForms.GunaTextBox codeTextBox;
        private Guna.UI.WinForms.GunaButton submitButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private Guna.UI.WinForms.GunaTextBox MRPTextBox;
        private Guna.UI.WinForms.GunaTextBox previousMRPTextBox;
        private Guna.UI.WinForms.GunaTextBox previousUnitPriceTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker purchaseDatePicker;
        private System.Windows.Forms.DateTimePicker expireDatePicker;
        private System.Windows.Forms.DateTimePicker manufacturedDatePicker;
        private System.Windows.Forms.Label productErrorLabel;
        private System.Windows.Forms.Label quantityErrorLabel;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label invoiceNoErrorLabel;
        private System.Windows.Forms.Label purchaseDateErrorlabel;
        private Guna.UI.WinForms.GunaTextBox remarkTextBox;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.Label unitPriceErrorLabel;
        private Guna.UI.WinForms.GunaDataGridView showDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton addButton;
    }
}
