namespace Tapanyagok.Views
{
    partial class TablazatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablazatForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TotalItemLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PrevButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PageLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MentestoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.UjtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TorlesoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.keresestoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.KeresestoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.torlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tapanyagokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.energiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feherjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zsirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szenhidratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TotalItemLabel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 43);
            this.panel1.TabIndex = 7;
            // 
            // TotalItemLabel
            // 
            this.TotalItemLabel.AutoSize = true;
            this.TotalItemLabel.Location = new System.Drawing.Point(9, 12);
            this.TotalItemLabel.Name = "TotalItemLabel";
            this.TotalItemLabel.Size = new System.Drawing.Size(59, 13);
            this.TotalItemLabel.TabIndex = 3;
            this.TotalItemLabel.Text = "Összesen: ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.PrevButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.FirstButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LastButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.NextButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.PageLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(209, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(386, 42);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrevButton.Location = new System.Drawing.Point(80, 9);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(71, 23);
            this.PrevButton.TabIndex = 1;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // FirstButton
            // 
            this.FirstButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstButton.Location = new System.Drawing.Point(3, 9);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(71, 23);
            this.FirstButton.TabIndex = 0;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastButton.Location = new System.Drawing.Point(311, 9);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(72, 23);
            this.LastButton.TabIndex = 3;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextButton.Location = new System.Drawing.Point(234, 9);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(71, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PageLabel
            // 
            this.PageLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PageLabel.AutoSize = true;
            this.PageLabel.Location = new System.Drawing.Point(180, 14);
            this.PageLabel.Name = "PageLabel";
            this.PageLabel.Size = new System.Drawing.Size(24, 13);
            this.PageLabel.TabIndex = 4;
            this.PageLabel.Text = "0/0";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MentestoolStripButton1,
            this.UjtoolStripButton,
            this.TorlesoolStripButton1,
            this.toolStripSeparator1,
            this.keresestoolStripTextBox,
            this.KeresestoolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.KeresestoolStripButton_Click);
            // 
            // MentestoolStripButton1
            // 
            this.MentestoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("MentestoolStripButton1.Image")));
            this.MentestoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MentestoolStripButton1.Name = "MentestoolStripButton1";
            this.MentestoolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.MentestoolStripButton1.Text = "Mentés";
            this.MentestoolStripButton1.Click += new System.EventHandler(this.mentestoolStripButton_Click);
            // 
            // UjtoolStripButton
            // 
            this.UjtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UjtoolStripButton.Image")));
            this.UjtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UjtoolStripButton.Name = "UjtoolStripButton";
            this.UjtoolStripButton.Size = new System.Drawing.Size(38, 22);
            this.UjtoolStripButton.Text = "Új";
            this.UjtoolStripButton.Click += new System.EventHandler(this.UjtoolStripButton_Click);
            // 
            // TorlesoolStripButton1
            // 
            this.TorlesoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("TorlesoolStripButton1.Image")));
            this.TorlesoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TorlesoolStripButton1.Name = "TorlesoolStripButton1";
            this.TorlesoolStripButton1.Size = new System.Drawing.Size(57, 22);
            this.TorlesoolStripButton1.Text = "Törlés";
            this.TorlesoolStripButton1.Click += new System.EventHandler(this.TorlesoolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // keresestoolStripTextBox
            // 
            this.keresestoolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keresestoolStripTextBox.Name = "keresestoolStripTextBox";
            this.keresestoolStripTextBox.Size = new System.Drawing.Size(200, 25);
            // 
            // KeresestoolStripButton1
            // 
            this.KeresestoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("KeresestoolStripButton1.Image")));
            this.KeresestoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.KeresestoolStripButton1.Name = "KeresestoolStripButton1";
            this.KeresestoolStripButton1.Size = new System.Drawing.Size(66, 22);
            this.KeresestoolStripButton1.Text = "Keresés";
            this.KeresestoolStripButton1.Click += new System.EventHandler(this.KeresestoolStripButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.energiaDataGridViewTextBoxColumn,
            this.feherjeDataGridViewTextBoxColumn,
            this.zsirDataGridViewTextBoxColumn,
            this.szenhidratDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.tapanyagokBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 376);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.szerkesztésToolStripMenuItem,
            this.torlesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 48);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.SzerkToolStripMenuItem_Click);
            // 
            // torlesToolStripMenuItem
            // 
            this.torlesToolStripMenuItem.Name = "torlesToolStripMenuItem";
            this.torlesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.torlesToolStripMenuItem.Text = "Törlés";
            this.torlesToolStripMenuItem.Click += new System.EventHandler(this.torlesToolStripMenuItem_Click);
            // 
            // tapanyagokBindingSource
            // 
            this.tapanyagokBindingSource.DataSource = typeof(Tapanyagok.Models.tapanyag);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Azonosító";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "nev";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            // 
            // energiaDataGridViewTextBoxColumn
            // 
            this.energiaDataGridViewTextBoxColumn.DataPropertyName = "energia";
            this.energiaDataGridViewTextBoxColumn.HeaderText = "Energia";
            this.energiaDataGridViewTextBoxColumn.Name = "energiaDataGridViewTextBoxColumn";
            // 
            // feherjeDataGridViewTextBoxColumn
            // 
            this.feherjeDataGridViewTextBoxColumn.DataPropertyName = "feherje";
            this.feherjeDataGridViewTextBoxColumn.HeaderText = "Fehérje";
            this.feherjeDataGridViewTextBoxColumn.Name = "feherjeDataGridViewTextBoxColumn";
            // 
            // zsirDataGridViewTextBoxColumn
            // 
            this.zsirDataGridViewTextBoxColumn.DataPropertyName = "zsir";
            this.zsirDataGridViewTextBoxColumn.HeaderText = "Zsír";
            this.zsirDataGridViewTextBoxColumn.Name = "zsirDataGridViewTextBoxColumn";
            // 
            // szenhidratDataGridViewTextBoxColumn
            // 
            this.szenhidratDataGridViewTextBoxColumn.DataPropertyName = "szenhidrat";
            this.szenhidratDataGridViewTextBoxColumn.HeaderText = "Szénhidrát";
            this.szenhidratDataGridViewTextBoxColumn.Name = "szenhidratDataGridViewTextBoxColumn";
            // 
            // TablazatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TablazatForm";
            this.Text = "Tablazat";
            this.Load += new System.EventHandler(this.TablazatPresenter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tapanyagokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label PageLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UjtoolStripButton;
        private System.Windows.Forms.ToolStripButton TorlesoolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox keresestoolStripTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tapanyagokBindingSource;
        private System.Windows.Forms.ToolStripButton MentestoolStripButton1;
        private System.Windows.Forms.ToolStripButton KeresestoolStripButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem torlesToolStripMenuItem;
        private System.Windows.Forms.Label TotalItemLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn energiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feherjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zsirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szenhidratDataGridViewTextBoxColumn;
    }
}