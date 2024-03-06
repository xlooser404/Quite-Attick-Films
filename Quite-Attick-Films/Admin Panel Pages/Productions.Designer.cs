namespace Quite_Attick_Films.Pages
{
    partial class Productions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productions));
            this.productionsPal = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDecription = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProdTitle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtType = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDuration = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBudget = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdd = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnUpdate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDelete = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LnkClearData = new System.Windows.Forms.LinkLabel();
            this.productionDGV = new System.Windows.Forms.DataGridView();
            this.btnBack = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtSearch = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PBSearch = new System.Windows.Forms.PictureBox();
            this.PBclose = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productionDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclose)).BeginInit();
            this.SuspendLayout();
            // 
            // productionsPal
            // 
            this.productionsPal.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.productionsPal.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.productionsPal.FormStyles.FormMain.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.productionsPal.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.productionsPal.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.productionsPal.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.productionsPal.FormStyles.FormMain.StateCommon.Border.Rounding = 15;
            this.productionsPal.FormStyles.FormMain.StateCommon.Border.Width = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Best Film Production Crew";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quite Attick Films";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(59, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 37);
            this.label4.TabIndex = 6;
            this.label4.Text = "Production Registeration";
            // 
            // txtDecription
            // 
            this.txtDecription.Location = new System.Drawing.Point(75, 200);
            this.txtDecription.Multiline = true;
            this.txtDecription.Name = "txtDecription";
            this.txtDecription.Size = new System.Drawing.Size(250, 95);
            this.txtDecription.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtDecription.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDecription.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDecription.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDecription.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDecription.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDecription.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDecription.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDecription.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDecription.StateCommon.Border.Rounding = 20;
            this.txtDecription.StateCommon.Border.Width = 1;
            this.txtDecription.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDecription.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecription.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDecription.TabIndex = 11;
            this.txtDecription.Text = "Decription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(68, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Production Description";
            // 
            // txtProdTitle
            // 
            this.txtProdTitle.Location = new System.Drawing.Point(75, 138);
            this.txtProdTitle.Name = "txtProdTitle";
            this.txtProdTitle.Size = new System.Drawing.Size(250, 33);
            this.txtProdTitle.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtProdTitle.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtProdTitle.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtProdTitle.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProdTitle.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtProdTitle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtProdTitle.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtProdTitle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProdTitle.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtProdTitle.StateCommon.Border.Rounding = 20;
            this.txtProdTitle.StateCommon.Border.Width = 1;
            this.txtProdTitle.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtProdTitle.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdTitle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtProdTitle.TabIndex = 9;
            this.txtProdTitle.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(69, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Production Title";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(75, 321);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(250, 33);
            this.txtType.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtType.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtType.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtType.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtType.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtType.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtType.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtType.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtType.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtType.StateCommon.Border.Rounding = 20;
            this.txtType.StateCommon.Border.Width = 1;
            this.txtType.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtType.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtType.TabIndex = 13;
            this.txtType.Text = "Production Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(69, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "Production Type";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(75, 379);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(250, 33);
            this.txtCode.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtCode.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCode.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCode.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtCode.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCode.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtCode.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCode.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtCode.StateCommon.Border.Rounding = 20;
            this.txtCode.StateCommon.Border.Width = 1;
            this.txtCode.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtCode.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtCode.TabIndex = 15;
            this.txtCode.Text = "Production Code";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(69, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Production Code";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(75, 441);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(250, 33);
            this.txtDuration.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtDuration.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDuration.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDuration.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDuration.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtDuration.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDuration.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtDuration.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDuration.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtDuration.StateCommon.Border.Rounding = 20;
            this.txtDuration.StateCommon.Border.Width = 1;
            this.txtDuration.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtDuration.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtDuration.TabIndex = 17;
            this.txtDuration.Text = "Duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(69, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Number of Dates";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(75, 503);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(250, 33);
            this.txtBudget.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txtBudget.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtBudget.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtBudget.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBudget.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txtBudget.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtBudget.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.txtBudget.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBudget.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txtBudget.StateCommon.Border.Rounding = 20;
            this.txtBudget.StateCommon.Border.Width = 1;
            this.txtBudget.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txtBudget.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudget.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.txtBudget.TabIndex = 19;
            this.txtBudget.Text = "Budget";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(69, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Production Budget";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(58, 570);
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
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Values.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(225, 570);
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
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Values.Text = "UPDATE";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 622);
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
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Values.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LnkClearData
            // 
            this.LnkClearData.AutoSize = true;
            this.LnkClearData.Location = new System.Drawing.Point(268, 539);
            this.LnkClearData.Name = "LnkClearData";
            this.LnkClearData.Size = new System.Drawing.Size(57, 13);
            this.LnkClearData.TabIndex = 23;
            this.LnkClearData.TabStop = true;
            this.LnkClearData.Text = "Clear Data";
            this.LnkClearData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkClearData_LinkClicked);
            // 
            // productionDGV
            // 
            this.productionDGV.BackgroundColor = System.Drawing.Color.White;
            this.productionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productionDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.productionDGV.GridColor = System.Drawing.Color.Lime;
            this.productionDGV.Location = new System.Drawing.Point(404, 77);
            this.productionDGV.Name = "productionDGV";
            this.productionDGV.Size = new System.Drawing.Size(853, 532);
            this.productionDGV.TabIndex = 24;
            this.productionDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productionDGV_CellClick);
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
            this.btnBack.TabIndex = 25;
            this.btnBack.Values.Text = "BACK";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(688, 31);
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
            this.txtSearch.TabIndex = 27;
            this.txtSearch.Text = "Type Production Code";
            // 
            // PBSearch
            // 
            this.PBSearch.Image = global::Quite_Attick_Films.Properties.Resources.loupe;
            this.PBSearch.Location = new System.Drawing.Point(944, 30);
            this.PBSearch.Name = "PBSearch";
            this.PBSearch.Size = new System.Drawing.Size(33, 33);
            this.PBSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBSearch.TabIndex = 28;
            this.PBSearch.TabStop = false;
            this.PBSearch.Click += new System.EventHandler(this.PBSearch_Click);
            // 
            // PBclose
            // 
            this.PBclose.Image = global::Quite_Attick_Films.Properties.Resources.close__2_;
            this.PBclose.Location = new System.Drawing.Point(1277, 12);
            this.PBclose.Name = "PBclose";
            this.PBclose.Size = new System.Drawing.Size(38, 38);
            this.PBclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBclose.TabIndex = 26;
            this.PBclose.TabStop = false;
            this.PBclose.Click += new System.EventHandler(this.PBclose_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(623, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 23);
            this.label10.TabIndex = 29;
            this.label10.Text = "Search ";
            // 
            // Productions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1327, 708);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.PBSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.PBclose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.productionDGV);
            this.Controls.Add(this.LnkClearData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDecription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProdTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productions";
            this.Palette = this.productionsPal;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productions";
            ((System.ComponentModel.ISupportInitialize)(this.productionDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette productionsPal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDecription;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProdTitle;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtType;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCode;
        private System.Windows.Forms.Label label7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDuration;
        private System.Windows.Forms.Label label8;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtBudget;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnAdd;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnUpdate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDelete;
        private System.Windows.Forms.LinkLabel LnkClearData;
        private System.Windows.Forms.DataGridView productionDGV;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBack;
        private System.Windows.Forms.PictureBox PBclose;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtSearch;
        private System.Windows.Forms.PictureBox PBSearch;
        private System.Windows.Forms.Label label10;
    }
}