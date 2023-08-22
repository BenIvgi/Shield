
namespace S.H.I.E.L.D_Server
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateDecisionTree = new System.Windows.Forms.Button();
            this.btnLoadDecisionTree = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.LayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanel.ColumnCount = 1;
            this.LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutPanel.Controls.Add(this.btnCreateDecisionTree, 0, 0);
            this.LayoutPanel.Controls.Add(this.btnLoadDecisionTree, 0, 2);
            this.LayoutPanel.Location = new System.Drawing.Point(225, 300);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.RowCount = 3;
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.LayoutPanel.Size = new System.Drawing.Size(350, 100);
            this.LayoutPanel.TabIndex = 0;
            // 
            // btnCreateDecisionTree
            // 
            this.btnCreateDecisionTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateDecisionTree.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCreateDecisionTree.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDecisionTree.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateDecisionTree.Location = new System.Drawing.Point(3, 3);
            this.btnCreateDecisionTree.Name = "btnCreateDecisionTree";
            this.btnCreateDecisionTree.Size = new System.Drawing.Size(344, 32);
            this.btnCreateDecisionTree.TabIndex = 0;
            this.btnCreateDecisionTree.Text = "Create Decision Tree";
            this.btnCreateDecisionTree.UseVisualStyleBackColor = false;
            this.btnCreateDecisionTree.Click += new System.EventHandler(this.btnCreateDecisionTree_Click);
            // 
            // btnLoadDecisionTree
            // 
            this.btnLoadDecisionTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadDecisionTree.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLoadDecisionTree.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDecisionTree.Location = new System.Drawing.Point(3, 64);
            this.btnLoadDecisionTree.Name = "btnLoadDecisionTree";
            this.btnLoadDecisionTree.Size = new System.Drawing.Size(344, 33);
            this.btnLoadDecisionTree.TabIndex = 1;
            this.btnLoadDecisionTree.Text = "Load Decision Tree";
            this.btnLoadDecisionTree.UseVisualStyleBackColor = false;
            this.btnLoadDecisionTree.Click += new System.EventHandler(this.btnLoadDecisionTree_Click);
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(325, 50);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(150, 200);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // Nextbutton
            // 
            this.Nextbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Nextbutton.BackColor = System.Drawing.SystemColors.Control;
            this.Nextbutton.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nextbutton.Location = new System.Drawing.Point(700, 400);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 30);
            this.Nextbutton.TabIndex = 2;
            this.Nextbutton.Text = "Next >>";
            this.Nextbutton.UseVisualStyleBackColor = false;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.LayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "S.H.I.E.L.D";
            this.LayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel LayoutPanel;
        private System.Windows.Forms.Button btnCreateDecisionTree;
        private System.Windows.Forms.Button btnLoadDecisionTree;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Nextbutton;
    }
}