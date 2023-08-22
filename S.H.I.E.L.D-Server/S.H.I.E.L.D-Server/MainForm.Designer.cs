
namespace S.H.I.E.L.D_Server
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
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startDataSniffing = new System.Windows.Forms.Button();
            this.stopDataSniffing = new System.Windows.Forms.Button();
            this.columnsList = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchValue = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanel.ColumnCount = 9;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.LayoutPanel.Controls.Add(this.startDataSniffing, 0, 0);
            this.LayoutPanel.Controls.Add(this.stopDataSniffing, 2, 0);
            this.LayoutPanel.Controls.Add(this.columnsList, 5, 0);
            this.LayoutPanel.Controls.Add(this.searchLabel, 4, 0);
            this.LayoutPanel.Controls.Add(this.searchValue, 6, 0);
            this.LayoutPanel.Controls.Add(this.searchButton, 7, 0);
            this.LayoutPanel.Controls.Add(this.clearButton, 8, 0);
            this.LayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 1;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanel.Size = new System.Drawing.Size(776, 30);
            this.LayoutPanel.TabIndex = 0;
            // 
            // startDataSniffing
            // 
            this.startDataSniffing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startDataSniffing.Location = new System.Drawing.Point(3, 3);
            this.startDataSniffing.Name = "startDataSniffing";
            this.startDataSniffing.Size = new System.Drawing.Size(111, 24);
            this.startDataSniffing.TabIndex = 0;
            this.startDataSniffing.Text = "Start data sniffing";
            this.startDataSniffing.UseVisualStyleBackColor = true;
            this.startDataSniffing.Click += new System.EventHandler(this.startDataSniffing_Click);
            // 
            // stopDataSniffing
            // 
            this.stopDataSniffing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stopDataSniffing.Location = new System.Drawing.Point(143, 3);
            this.stopDataSniffing.Name = "stopDataSniffing";
            this.stopDataSniffing.Size = new System.Drawing.Size(111, 24);
            this.stopDataSniffing.TabIndex = 1;
            this.stopDataSniffing.Text = "Stop data sniffing";
            this.stopDataSniffing.UseVisualStyleBackColor = true;
            this.stopDataSniffing.Click += new System.EventHandler(this.stopDataSniffing_Click);
            // 
            // columnsList
            // 
            this.columnsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.columnsList.FormattingEnabled = true;
            this.columnsList.Location = new System.Drawing.Point(401, 3);
            this.columnsList.Name = "columnsList";
            this.columnsList.Size = new System.Drawing.Size(88, 21);
            this.columnsList.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(348, 8);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(47, 13);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search: ";
            // 
            // searchValue
            // 
            this.searchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchValue.Location = new System.Drawing.Point(495, 3);
            this.searchValue.Name = "searchValue";
            this.searchValue.Size = new System.Drawing.Size(88, 20);
            this.searchValue.TabIndex = 4;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(589, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(88, 24);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(683, 3);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 24);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // GridView
            // 
            this.GridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Location = new System.Drawing.Point(15, 48);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(773, 390);
            this.GridView.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.LayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "S.H.I.E.L.D";
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Button startDataSniffing;
        private System.Windows.Forms.Button stopDataSniffing;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.ComboBox columnsList;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchValue;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
    }
}