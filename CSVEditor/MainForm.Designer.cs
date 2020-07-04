namespace CSVEditor
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenuSection = new System.Windows.Forms.ToolStripMenuItem();
            this.importMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPageBtn = new System.Windows.Forms.Button();
            this.pageNumber = new System.Windows.Forms.TextBox();
            this.prevPageBtn = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.insert_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csvData = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvData)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuSection,
            this.aboutMenuBtn});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 28);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "mainMenu";
            // 
            // fileMenuSection
            // 
            this.fileMenuSection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importMenuBtn});
            this.fileMenuSection.Name = "fileMenuSection";
            this.fileMenuSection.Size = new System.Drawing.Size(59, 24);
            this.fileMenuSection.Text = "Файл";
            // 
            // importMenuBtn
            // 
            this.importMenuBtn.Name = "importMenuBtn";
            this.importMenuBtn.Size = new System.Drawing.Size(147, 26);
            this.importMenuBtn.Text = "Импорт";
            this.importMenuBtn.Click += new System.EventHandler(this.importMenuBtn_Click);
            // 
            // aboutMenuBtn
            // 
            this.aboutMenuBtn.Name = "aboutMenuBtn";
            this.aboutMenuBtn.Size = new System.Drawing.Size(81, 24);
            this.aboutMenuBtn.Text = "Справка";
            // 
            // nextPageBtn
            // 
            this.nextPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextPageBtn.AutoSize = true;
            this.nextPageBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.nextPageBtn.Location = new System.Drawing.Point(732, 3);
            this.nextPageBtn.Name = "nextPageBtn";
            this.nextPageBtn.Size = new System.Drawing.Size(35, 27);
            this.nextPageBtn.TabIndex = 3;
            this.nextPageBtn.Text = ">";
            this.nextPageBtn.UseVisualStyleBackColor = true;
            // 
            // pageNumber
            // 
            this.pageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageNumber.Location = new System.Drawing.Point(693, 3);
            this.pageNumber.Name = "pageNumber";
            this.pageNumber.Size = new System.Drawing.Size(33, 28);
            this.pageNumber.TabIndex = 4;
            this.pageNumber.Text = "1";
            this.pageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prevPageBtn
            // 
            this.prevPageBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prevPageBtn.Location = new System.Drawing.Point(652, 3);
            this.prevPageBtn.Name = "prevPageBtn";
            this.prevPageBtn.Size = new System.Drawing.Size(35, 27);
            this.prevPageBtn.TabIndex = 5;
            this.prevPageBtn.Text = "<";
            this.prevPageBtn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "csvFile";
            this.openFileDialog.Filter = "CSV Файлы|*.csv";
            // 
            // insert_date
            // 
            this.insert_date.HeaderText = "DateTime";
            this.insert_date.MinimumWidth = 50;
            this.insert_date.Name = "insert_date";
            this.insert_date.ReadOnly = true;
            // 
            // client
            // 
            this.client.HeaderText = "client";
            this.client.MinimumWidth = 50;
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // csvData
            // 
            this.csvData.AllowUserToAddRows = false;
            this.csvData.AllowUserToDeleteRows = false;
            this.csvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.csvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.csvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.csvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.csvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.client,
            this.insert_date});
            this.csvData.Location = new System.Drawing.Point(3, 3);
            this.csvData.MinimumSize = new System.Drawing.Size(100, 0);
            this.csvData.Name = "csvData";
            this.csvData.ReadOnly = true;
            this.csvData.RowHeadersWidth = 51;
            this.csvData.RowTemplate.Height = 24;
            this.csvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.csvData.Size = new System.Drawing.Size(770, 360);
            this.csvData.TabIndex = 2;
            this.csvData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.csvData_CellContentDoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.csvData, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(50, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.17199F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.82801F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 407);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.nextPageBtn);
            this.flowLayoutPanel1.Controls.Add(this.pageNumber);
            this.flowLayoutPanel1.Controls.Add(this.prevPageBtn);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 369);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(770, 35);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "CSVEditor";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csvData)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuSection;
        private System.Windows.Forms.ToolStripMenuItem importMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuBtn;
        private System.Windows.Forms.Button nextPageBtn;
        private System.Windows.Forms.TextBox pageNumber;
        private System.Windows.Forms.Button prevPageBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn insert_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridView csvData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

