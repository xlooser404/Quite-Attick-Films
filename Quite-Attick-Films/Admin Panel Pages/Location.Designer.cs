namespace Quite_Attick_Films.Pages
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.locationPal = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LnkClearData = new System.Windows.Forms.LinkLabel();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.CBLtype = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFeez = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLocCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescript = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LocationDGV = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.PBSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PBclose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CBLtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclose)).BeginInit();
            this.SuspendLayout();
            // 
            // locationPal
            // 
            this.locationPal.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.locationPal.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.locationPal.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.locationPal.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.locationPal.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.locationPal.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.locationPal.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.locationPal.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.locationPal.FormStyles.FormMain.StateCommon.Border.Width = 1;
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
            // LnkClearData
            // 
            this.LnkClearData.AutoSize = true;
            this.LnkClearData.Location = new System.Drawing.Point(263, 564);
            this.LnkClearData.Name = "LnkClearData";
            this.LnkClearData.Size = new System.Drawing.Size(57, 13);
            this.LnkClearData.TabIndex = 88;
            this.LnkClearData.TabStop = true;
            this.LnkClearData.Text = "Clear Data";
            this.LnkClearData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClearData_LinkClicked);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(136, 641);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 39);
            this.btnDelete.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnDelete.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnDelete.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDelete.StateCommon.Border.Color1 = System.Drawing.Color.Lime;
            this.btnDelete.StateCommon.Border.Color2 = System.Drawing.Color.Lime;
            this.btnDelete.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnDelete.StateCommon.Border.Rounding = 20;
            this.btnDelete.StateCommon.Border.Width = 1;
            this.btnDelete.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnDelete.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.StateNormal.Back.Color1 = System.Drawing.Color.Lime;
            this.btnDelete.StateNormal.Back.Color2 = System.Drawing.Color.Lime;
            this.btnDelete.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateNormal.Border.Rounding = 20;
            this.btnDelete.StateNormal.Border.Width = 1;
            this.btnDelete.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnDelete.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnDelete.StatePressed.Border.Color1 = System.Drawing.Color.Lime;
            this.btnDelete.StatePressed.Border.Color2 = System.Drawing.Color.Lime;
            this.btnDelete.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StatePressed.Border.Rounding = 20;
            this.btnDelete.StatePressed.Border.Width = 1;
            this.btnDelete.StatePressed.Content.LongText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.StatePressed.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Lime;
            this.btnDelete.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Lime;
            this.btnDelete.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.btnDelete.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.btnDelete.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDelete.StateTracking.Border.Rounding = 20;
            this.btnDelete.StateTracking.Border.Width = 1;
            this.btnDelete.TabIndex = 87;
            this.btnDelete.Values.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(220, 589);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 39);
            this.btnUpdate.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnUpdate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnUpdate.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateCommon.Border.Color1 = System.Drawing.Color.Lime;
            this.btnUpdate.StateCommon.Border.Color2 = System.Drawing.Color.Lime;
            this.btnUpdate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnUpdate.StateCommon.Border.Rounding = 20;
            this.btnUpdate.StateCommon.Border.Width = 1;
            this.btnUpdate.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUpdate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StateNormal.Back.Color1 = System.Drawing.Color.Lime;
            this.btnUpdate.StateNormal.Back.Color2 = System.Drawing.Color.Lime;
            this.btnUpdate.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateNormal.Border.Rounding = 20;
            this.btnUpdate.StateNormal.Border.Width = 1;
            this.btnUpdate.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnUpdate.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnUpdate.StatePressed.Border.Color1 = System.Drawing.Color.Lime;
            this.btnUpdate.StatePressed.Border.Color2 = System.Drawing.Color.Lime;
            this.btnUpdate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StatePressed.Border.Rounding = 20;
            this.btnUpdate.StatePressed.Border.Width = 1;
            this.btnUpdate.StatePressed.Content.LongText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StatePressed.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnUpdate.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Lime;
            this.btnUpdate.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Lime;
            this.btnUpdate.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.btnUpdate.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.btnUpdate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnUpdate.StateTracking.Border.Rounding = 20;
            this.btnUpdate.StateTracking.Border.Width = 1;
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Values.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 589);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 39);
            this.btnAdd.StateCommon.Back.Color1 = System.Drawing.Color.Lime;
            this.btnAdd.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.btnAdd.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateCommon.Border.Color1 = System.Drawing.Color.Lime;
            this.btnAdd.StateCommon.Border.Color2 = System.Drawing.Color.Lime;
            this.btnAdd.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnAdd.StateCommon.Border.Rounding = 20;
            this.btnAdd.StateCommon.Border.Width = 1;
            this.btnAdd.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAdd.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnAdd.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateNormal.Back.Color1 = System.Drawing.Color.Lime;
            this.btnAdd.StateNormal.Back.Color2 = System.Drawing.Color.Lime;
            this.btnAdd.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateNormal.Border.Rounding = 20;
            this.btnAdd.StateNormal.Border.Width = 1;
            this.btnAdd.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnAdd.StatePressed.Back.Color2 = System.Drawing.Color.White;
            this.btnAdd.StatePressed.Border.Color1 = System.Drawing.Color.Lime;
            this.btnAdd.StatePressed.Border.Color2 = System.Drawing.Color.Lime;
            this.btnAdd.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StatePressed.Border.Rounding = 20;
            this.btnAdd.StatePressed.Border.Width = 1;
            this.btnAdd.StatePressed.Content.LongText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StatePressed.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAdd.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Lime;
            this.btnAdd.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Lime;
            this.btnAdd.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.btnAdd.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.btnAdd.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAdd.StateTracking.Border.Rounding = 20;
            this.btnAdd.StateTracking.Border.Width = 1;
            this.btnAdd.TabIndex = 85;
            this.btnAdd.Values.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 23);
            this.label5.TabIndex = 83;
            this.label5.Text = "Location Description";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(73, 387);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 66);
            this.txtAddress.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtAddress.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtAddress.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtAddress.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtAddress.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtAddress.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtAddress.StateCommon.Border.Rounding = 20;
            this.txtAddress.StateCommon.Border.Width = 1;
            this.txtAddress.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtAddress.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtAddress.TabIndex = 82;
            this.txtAddress.Text = "Address";
            // 
            // CBLtype
            // 
            this.CBLtype.DropDownWidth = 236;
            this.CBLtype.Items.AddRange(new object[] {
            "Indoor ",
            "Outdoor"});
            this.CBLtype.Location = new System.Drawing.Point(75, 324);
            this.CBLtype.Name = "CBLtype";
            this.CBLtype.Size = new System.Drawing.Size(248, 34);
            this.CBLtype.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.White;
            this.CBLtype.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.CBLtype.StateCommon.ComboBox.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.CBLtype.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CBLtype.StateCommon.ComboBox.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.CBLtype.StateCommon.ComboBox.Border.Rounding = 20;
            this.CBLtype.StateCommon.ComboBox.Border.Width = 1;
            this.CBLtype.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Gray;
            this.CBLtype.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBLtype.StateCommon.ComboBox.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.CBLtype.TabIndex = 81;
            this.CBLtype.Text = "Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(65, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 80;
            this.label9.Text = "Location Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(65, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 79;
            this.label8.Text = "Location Type";
            // 
            // txtFeez
            // 
            this.txtFeez.Location = new System.Drawing.Point(71, 261);
            this.txtFeez.Name = "txtFeez";
            this.txtFeez.Size = new System.Drawing.Size(250, 33);
            this.txtFeez.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtFeez.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtFeez.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtFeez.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFeez.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtFeez.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtFeez.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtFeez.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtFeez.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtFeez.StateCommon.Border.Rounding = 20;
            this.txtFeez.StateCommon.Border.Width = 1;
            this.txtFeez.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtFeez.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeez.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtFeez.TabIndex = 78;
            this.txtFeez.Text = "feez";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(65, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 23);
            this.label7.TabIndex = 77;
            this.label7.Text = "Location fee";
            // 
            // txtLocCode
            // 
            this.txtLocCode.Location = new System.Drawing.Point(71, 203);
            this.txtLocCode.Name = "txtLocCode";
            this.txtLocCode.Size = new System.Drawing.Size(250, 33);
            this.txtLocCode.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtLocCode.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocCode.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLocCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtLocCode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocCode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLocCode.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtLocCode.StateCommon.Border.Rounding = 20;
            this.txtLocCode.StateCommon.Border.Width = 1;
            this.txtLocCode.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtLocCode.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocCode.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtLocCode.TabIndex = 76;
            this.txtLocCode.Text = "Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(65, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 23);
            this.label6.TabIndex = 75;
            this.label6.Text = "Location Code";
            // 
            // txtLocName
            // 
            this.txtLocName.Location = new System.Drawing.Point(73, 143);
            this.txtLocName.Name = "txtLocName";
            this.txtLocName.Size = new System.Drawing.Size(250, 33);
            this.txtLocName.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtLocName.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocName.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocName.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLocName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtLocName.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocName.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtLocName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtLocName.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtLocName.StateCommon.Border.Rounding = 20;
            this.txtLocName.StateCommon.Border.Width = 1;
            this.txtLocName.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtLocName.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocName.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtLocName.TabIndex = 74;
            this.txtLocName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(67, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 73;
            this.label3.Text = "Location Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(58, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 37);
            this.label4.TabIndex = 72;
            this.label4.Text = "Locations Registeration";
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(73, 485);
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
            this.txtDescript.TabIndex = 89;
            this.txtDescript.Text = "Description";
            // 
            // LocationDGV
            // 
            this.LocationDGV.BackgroundColor = System.Drawing.Color.White;
            this.LocationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LocationDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.LocationDGV.GridColor = System.Drawing.Color.Lime;
            this.LocationDGV.Location = new System.Drawing.Point(402, 95);
            this.LocationDGV.Name = "LocationDGV";
            this.LocationDGV.Size = new System.Drawing.Size(853, 532);
            this.LocationDGV.TabIndex = 90;
            this.LocationDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LocationDGV_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(645, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 23);
            this.label10.TabIndex = 93;
            this.label10.Text = "Search ";
            // 
            // PBSearch
            // 
            this.PBSearch.Image = global::Quite_Attick_Films.Properties.Resources.loupe;
            this.PBSearch.Location = new System.Drawing.Point(966, 55);
            this.PBSearch.Name = "PBSearch";
            this.PBSearch.Size = new System.Drawing.Size(33, 33);
            this.PBSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSearch.TabIndex = 92;
            this.PBSearch.TabStop = false;
            this.PBSearch.Click += new System.EventHandler(this.PBSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(710, 56);
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
            this.txtSearch.TabIndex = 91;
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
            this.btnBack.TabIndex = 94;
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
            this.PBclose.TabIndex = 95;
            this.PBclose.TabStop = false;
            this.PBclose.Click += new System.EventHandler(this.PBclose_Click);
            // 
            // Location
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
            this.Controls.Add(this.LocationDGV);
            this.Controls.Add(this.txtDescript);
            this.Controls.Add(this.LnkClearData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.CBLtype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFeez);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLocName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Location";
            this.Palette = this.locationPal;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location";
            ((System.ComponentModel.ISupportInitialize)(this.CBLtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LocationDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette locationPal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LnkClearData;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CBLtype;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtFeez;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLocCode;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtLocName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDescript;
        private System.Windows.Forms.DataGridView LocationDGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox PBSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.PictureBox PBclose;
    }
}