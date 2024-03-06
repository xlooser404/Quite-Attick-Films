namespace Quite_Attick_Films.Pages
{
    partial class Payments
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            this.PaymentPal = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Paytype = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNIC = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescript = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrice = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOrdCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCliName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LnkClearData = new System.Windows.Forms.LinkLabel();
            this.btnPay = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.PBSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PBclose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Paytype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclose)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentPal
            // 
            this.PaymentPal.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.PaymentPal.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.PaymentPal.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PaymentPal.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.PaymentPal.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.PaymentPal.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.PaymentPal.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.PaymentPal.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.PaymentPal.FormStyles.FormMain.StateCommon.Border.Width = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Your Best Film Production Crew";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Quite Attick Films";
            // 
            // Paytype
            // 
            this.Paytype.DropDownWidth = 236;
            this.Paytype.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Bank Transfer",
            "Paypal"});
            this.Paytype.Location = new System.Drawing.Point(75, 347);
            this.Paytype.Name = "Paytype";
            this.Paytype.Size = new System.Drawing.Size(250, 34);
            this.Paytype.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.Paytype.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.Paytype.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.Paytype.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Paytype.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Paytype.StateCommon.ComboBox.Border.Rounding = 20;
            this.Paytype.StateCommon.ComboBox.Border.Width = 1;
            this.Paytype.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.Paytype.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Paytype.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Paytype.TabIndex = 123;
            this.Paytype.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(69, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 122;
            this.label9.Text = "Payment Type ";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(75, 408);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(250, 33);
            this.txtNIC.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtNIC.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtNIC.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtNIC.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNIC.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtNIC.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtNIC.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtNIC.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNIC.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtNIC.StateCommon.Border.Rounding = 20;
            this.txtNIC.StateCommon.Border.Width = 1;
            this.txtNIC.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtNIC.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIC.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtNIC.TabIndex = 121;
            this.txtNIC.Text = "NIC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(69, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 23);
            this.label8.TabIndex = 120;
            this.label8.Text = "Client NIC";
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(75, 470);
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(250, 74);
            this.txtDescript.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtDescript.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDescript.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDescript.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescript.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDescript.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDescript.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDescript.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDescript.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDescript.StateCommon.Border.Rounding = 20;
            this.txtDescript.StateCommon.Border.Width = 1;
            this.txtDescript.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDescript.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescript.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDescript.TabIndex = 119;
            this.txtDescript.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(71, 444);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 118;
            this.label5.Text = "Order Description";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(75, 285);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 33);
            this.txtPrice.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtPrice.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtPrice.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtPrice.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrice.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtPrice.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtPrice.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtPrice.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPrice.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtPrice.StateCommon.Border.Rounding = 20;
            this.txtPrice.StateCommon.Border.Width = 1;
            this.txtPrice.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtPrice.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtPrice.TabIndex = 117;
            this.txtPrice.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(69, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 116;
            this.label7.Text = "Order Price";
            // 
            // txtOrdCode
            // 
            this.txtOrdCode.Location = new System.Drawing.Point(75, 227);
            this.txtOrdCode.Name = "txtOrdCode";
            this.txtOrdCode.Size = new System.Drawing.Size(250, 33);
            this.txtOrdCode.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtOrdCode.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOrdCode.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOrdCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOrdCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtOrdCode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOrdCode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtOrdCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOrdCode.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtOrdCode.StateCommon.Border.Rounding = 20;
            this.txtOrdCode.StateCommon.Border.Width = 1;
            this.txtOrdCode.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtOrdCode.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrdCode.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtOrdCode.TabIndex = 115;
            this.txtOrdCode.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(69, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 23);
            this.label6.TabIndex = 114;
            this.label6.Text = "Order Code";
            // 
            // txtCliName
            // 
            this.txtCliName.Location = new System.Drawing.Point(77, 167);
            this.txtCliName.Name = "txtCliName";
            this.txtCliName.Size = new System.Drawing.Size(248, 33);
            this.txtCliName.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtCliName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCliName.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCliName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCliName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCliName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCliName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCliName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCliName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCliName.StateCommon.Border.Rounding = 20;
            this.txtCliName.StateCommon.Border.Width = 1;
            this.txtCliName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtCliName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCliName.TabIndex = 113;
            this.txtCliName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 112;
            this.label3.Text = "Client Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(109, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 37);
            this.label4.TabIndex = 111;
            this.label4.Text = "Payment Form";
            // 
            // LnkClearData
            // 
            this.LnkClearData.AutoSize = true;
            this.LnkClearData.Location = new System.Drawing.Point(265, 547);
            this.LnkClearData.Name = "LnkClearData";
            this.LnkClearData.Size = new System.Drawing.Size(57, 13);
            this.LnkClearData.TabIndex = 127;
            this.LnkClearData.TabStop = true;
            this.LnkClearData.Text = "Clear Data";
            this.LnkClearData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClearData_LinkClicked);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(137, 582);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(125, 39);
            this.btnPay.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnPay.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnPay.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPay.StateCommon.Border.Color1 = System.Drawing.Color.Lime;
            this.btnPay.StateCommon.Border.Color2 = System.Drawing.Color.Lime;
            this.btnPay.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPay.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnPay.StateCommon.Border.Rounding = 20;
            this.btnPay.StateCommon.Border.Width = 1;
            this.btnPay.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPay.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPay.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnPay.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.StateNormal.Back.Color1 = System.Drawing.Color.Lime;
            this.btnPay.StateNormal.Back.Color2 = System.Drawing.Color.Lime;
            this.btnPay.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPay.StateNormal.Border.Rounding = 20;
            this.btnPay.StateNormal.Border.Width = 1;
            this.btnPay.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnPay.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnPay.StatePressed.Border.Color1 = System.Drawing.Color.Lime;
            this.btnPay.StatePressed.Border.Color2 = System.Drawing.Color.Lime;
            this.btnPay.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPay.StatePressed.Border.Rounding = 20;
            this.btnPay.StatePressed.Border.Width = 1;
            this.btnPay.StatePressed.Content.LongText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.StatePressed.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPay.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Lime;
            this.btnPay.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Lime;
            this.btnPay.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.btnPay.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.btnPay.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPay.StateTracking.Border.Rounding = 20;
            this.btnPay.StateTracking.Border.Width = 1;
            this.btnPay.TabIndex = 124;
            this.btnPay.Values.Text = "Pay";
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // OrderDGV
            // 
            this.OrderDGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDGV.GridColor = System.Drawing.Color.Lime;
            this.OrderDGV.Location = new System.Drawing.Point(410, 89);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.Size = new System.Drawing.Size(853, 532);
            this.OrderDGV.TabIndex = 128;
            this.OrderDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDGV_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(657, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 23);
            this.label10.TabIndex = 131;
            this.label10.Text = "Search ";
            // 
            // PBSearch
            // 
            this.PBSearch.Image = global::Quite_Attick_Films.Properties.Resources.loupe;
            this.PBSearch.Location = new System.Drawing.Point(978, 49);
            this.PBSearch.Name = "PBSearch";
            this.PBSearch.Size = new System.Drawing.Size(33, 33);
            this.PBSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSearch.TabIndex = 130;
            this.PBSearch.TabStop = false;
            this.PBSearch.Click += new System.EventHandler(this.PBSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(722, 50);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 33);
            this.txtSearch.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtSearch.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtSearch.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtSearch.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtSearch.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtSearch.StateCommon.Border.Rounding = 20;
            this.txtSearch.StateCommon.Border.Width = 1;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtSearch.TabIndex = 129;
            this.txtSearch.Text = "Type Production Code";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1190, 657);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 39);
            this.btnBack.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnBack.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnBack.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBack.StateCommon.Border.Color1 = System.Drawing.Color.Lime;
            this.btnBack.StateCommon.Border.Color2 = System.Drawing.Color.Lime;
            this.btnBack.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnBack.StateCommon.Border.Rounding = 20;
            this.btnBack.StateCommon.Border.Width = 1;
            this.btnBack.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnBack.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnBack.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.StateNormal.Back.Color1 = System.Drawing.Color.Lime;
            this.btnBack.StateNormal.Back.Color2 = System.Drawing.Color.Lime;
            this.btnBack.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateNormal.Border.Rounding = 20;
            this.btnBack.StateNormal.Border.Width = 1;
            this.btnBack.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnBack.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnBack.StatePressed.Border.Color1 = System.Drawing.Color.Lime;
            this.btnBack.StatePressed.Border.Color2 = System.Drawing.Color.Lime;
            this.btnBack.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StatePressed.Border.Rounding = 20;
            this.btnBack.StatePressed.Border.Width = 1;
            this.btnBack.StatePressed.Content.LongText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.StatePressed.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnBack.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Lime;
            this.btnBack.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Lime;
            this.btnBack.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.btnBack.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.btnBack.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBack.StateTracking.Border.Rounding = 20;
            this.btnBack.StateTracking.Border.Width = 1;
            this.btnBack.TabIndex = 132;
            this.btnBack.Values.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // PBclose
            // 
            this.PBclose.Image = global::Quite_Attick_Films.Properties.Resources.close__2_;
            this.PBclose.Location = new System.Drawing.Point(1277, 12);
            this.PBclose.Name = "PBclose";
            this.PBclose.Size = new System.Drawing.Size(38, 38);
            this.PBclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBclose.TabIndex = 133;
            this.PBclose.TabStop = false;
            this.PBclose.Click += new System.EventHandler(this.PBclose_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 708);
            this.Controls.Add(this.PBclose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PBSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.OrderDGV);
            this.Controls.Add(this.LnkClearData);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.Paytype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtOrdCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCliName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payments";
            this.Palette = this.PaymentPal;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)(this.Paytype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette PaymentPal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Paytype;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNIC;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescript;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOrdCode;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCliName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LnkClearData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnPay;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PBSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.PictureBox PBclose;
    }
}