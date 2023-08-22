
namespace S.H.I.E.L.D_Server
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.confusionMatrixLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.positiveLabel1 = new System.Windows.Forms.Label();
            this.negativeLabel1 = new System.Windows.Forms.Label();
            this.positiveLabel2 = new System.Windows.Forms.Label();
            this.negativeLabel2 = new System.Windows.Forms.Label();
            this.posPosLabel = new System.Windows.Forms.Label();
            this.posNegLabel = new System.Windows.Forms.Label();
            this.negPosLabel = new System.Windows.Forms.Label();
            this.negNegLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.accuracyTag = new System.Windows.Forms.Label();
            this.accuracyLabel = new System.Windows.Forms.Label();
            this.precisionTag = new System.Windows.Forms.Label();
            this.precisionLabel = new System.Windows.Forms.Label();
            this.recallTag = new System.Windows.Forms.Label();
            this.f1ScoreTag = new System.Windows.Forms.Label();
            this.recallLabel = new System.Windows.Forms.Label();
            this.f1ScoreLabel = new System.Windows.Forms.Label();
            this.CorrelationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.destinationPortTag = new System.Windows.Forms.Label();
            this.avgFwdSegmentSizeTag = new System.Windows.Forms.Label();
            this.maxPacketLenTag = new System.Windows.Forms.Label();
            this.minPacketLenTag = new System.Windows.Forms.Label();
            this.totalLenOfFwdPacketsTag = new System.Windows.Forms.Label();
            this.totalLenOfBwdPacketsTag = new System.Windows.Forms.Label();
            this.destinationPortLabel = new System.Windows.Forms.Label();
            this.avgFwdSegmentSizeLabel = new System.Windows.Forms.Label();
            this.maxPacketLenLabel = new System.Windows.Forms.Label();
            this.minPacketLenLabel = new System.Windows.Forms.Label();
            this.totalLenOfFwdPacketsLabel = new System.Windows.Forms.Label();
            this.totalLenOfBwdPacketsLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.confusionMatrixLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CorrelationLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(38, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(187, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(326, 40);
            this.title.TabIndex = 0;
            this.title.Text = "The statistics of the model";
            // 
            // confusionMatrixLabel
            // 
            this.confusionMatrixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.confusionMatrixLabel.AutoSize = true;
            this.confusionMatrixLabel.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confusionMatrixLabel.Location = new System.Drawing.Point(3, 40);
            this.confusionMatrixLabel.Name = "confusionMatrixLabel";
            this.confusionMatrixLabel.Size = new System.Drawing.Size(134, 26);
            this.confusionMatrixLabel.TabIndex = 1;
            this.confusionMatrixLabel.Text = "Confusion Matrix:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.tableLayoutPanel2.Controls.Add(this.positiveLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.negativeLabel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.positiveLabel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.negativeLabel2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.posPosLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.posNegLabel, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.negPosLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.negNegLabel, 2, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 93);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // positiveLabel1
            // 
            this.positiveLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positiveLabel1.AutoSize = true;
            this.positiveLabel1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveLabel1.Location = new System.Drawing.Point(71, 32);
            this.positiveLabel1.Name = "positiveLabel1";
            this.positiveLabel1.Size = new System.Drawing.Size(52, 32);
            this.positiveLabel1.TabIndex = 0;
            this.positiveLabel1.Text = "Positive";
            // 
            // negativeLabel1
            // 
            this.negativeLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negativeLabel1.AutoSize = true;
            this.negativeLabel1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeLabel1.Location = new System.Drawing.Point(66, 64);
            this.negativeLabel1.Name = "negativeLabel1";
            this.negativeLabel1.Size = new System.Drawing.Size(57, 29);
            this.negativeLabel1.TabIndex = 1;
            this.negativeLabel1.Text = "Negative";
            // 
            // positiveLabel2
            // 
            this.positiveLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.positiveLabel2.AutoSize = true;
            this.positiveLabel2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positiveLabel2.Location = new System.Drawing.Point(129, 10);
            this.positiveLabel2.Name = "positiveLabel2";
            this.positiveLabel2.Size = new System.Drawing.Size(120, 22);
            this.positiveLabel2.TabIndex = 2;
            this.positiveLabel2.Text = "Positive";
            // 
            // negativeLabel2
            // 
            this.negativeLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.negativeLabel2.AutoSize = true;
            this.negativeLabel2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negativeLabel2.Location = new System.Drawing.Point(255, 10);
            this.negativeLabel2.Name = "negativeLabel2";
            this.negativeLabel2.Size = new System.Drawing.Size(118, 22);
            this.negativeLabel2.TabIndex = 3;
            this.negativeLabel2.Text = "Negative";
            // 
            // posPosLabel
            // 
            this.posPosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.posPosLabel.AutoSize = true;
            this.posPosLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posPosLabel.Location = new System.Drawing.Point(166, 32);
            this.posPosLabel.Name = "posPosLabel";
            this.posPosLabel.Size = new System.Drawing.Size(45, 32);
            this.posPosLabel.TabIndex = 4;
            this.posPosLabel.Text = "11359";
            // 
            // posNegLabel
            // 
            this.posNegLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.posNegLabel.AutoSize = true;
            this.posNegLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posNegLabel.Location = new System.Drawing.Point(305, 32);
            this.posNegLabel.Name = "posNegLabel";
            this.posNegLabel.Size = new System.Drawing.Size(17, 32);
            this.posNegLabel.TabIndex = 5;
            this.posNegLabel.Text = "0";
            // 
            // negPosLabel
            // 
            this.negPosLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.negPosLabel.AutoSize = true;
            this.negPosLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negPosLabel.Location = new System.Drawing.Point(170, 64);
            this.negPosLabel.Name = "negPosLabel";
            this.negPosLabel.Size = new System.Drawing.Size(38, 29);
            this.negPosLabel.TabIndex = 6;
            this.negPosLabel.Text = "4001";
            // 
            // negNegLabel
            // 
            this.negNegLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.negNegLabel.AutoSize = true;
            this.negNegLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negNegLabel.Location = new System.Drawing.Point(291, 64);
            this.negNegLabel.Name = "negNegLabel";
            this.negNegLabel.Size = new System.Drawing.Size(45, 29);
            this.negNegLabel.TabIndex = 7;
            this.negNegLabel.Text = "29789";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.14894F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.85107F));
            this.tableLayoutPanel3.Controls.Add(this.accuracyTag, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.accuracyLabel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.precisionTag, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.precisionLabel, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.recallTag, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.f1ScoreTag, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.recallLabel, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.f1ScoreLabel, 1, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.7037F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2963F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 108);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // accuracyTag
            // 
            this.accuracyTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracyTag.AutoSize = true;
            this.accuracyTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyTag.Location = new System.Drawing.Point(3, 0);
            this.accuracyTag.Name = "accuracyTag";
            this.accuracyTag.Size = new System.Drawing.Size(66, 29);
            this.accuracyTag.TabIndex = 0;
            this.accuracyTag.Text = "Accuracy:";
            // 
            // accuracyLabel
            // 
            this.accuracyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accuracyLabel.AutoSize = true;
            this.accuracyLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accuracyLabel.Location = new System.Drawing.Point(75, 0);
            this.accuracyLabel.Name = "accuracyLabel";
            this.accuracyLabel.Size = new System.Drawing.Size(298, 29);
            this.accuracyLabel.TabIndex = 1;
            this.accuracyLabel.Text = "0.9113823119005958";
            // 
            // precisionTag
            // 
            this.precisionTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precisionTag.AutoSize = true;
            this.precisionTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precisionTag.Location = new System.Drawing.Point(3, 29);
            this.precisionTag.Name = "precisionTag";
            this.precisionTag.Size = new System.Drawing.Size(66, 25);
            this.precisionTag.TabIndex = 2;
            this.precisionTag.Text = "Precision:";
            // 
            // precisionLabel
            // 
            this.precisionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(75, 29);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(298, 25);
            this.precisionLabel.TabIndex = 3;
            this.precisionLabel.Text = "0.7395182291666667";
            // 
            // recallTag
            // 
            this.recallTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recallTag.AutoSize = true;
            this.recallTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recallTag.Location = new System.Drawing.Point(3, 54);
            this.recallTag.Name = "recallTag";
            this.recallTag.Size = new System.Drawing.Size(66, 26);
            this.recallTag.TabIndex = 4;
            this.recallTag.Text = "Recall:";
            // 
            // f1ScoreTag
            // 
            this.f1ScoreTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f1ScoreTag.AutoSize = true;
            this.f1ScoreTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1ScoreTag.Location = new System.Drawing.Point(3, 80);
            this.f1ScoreTag.Name = "f1ScoreTag";
            this.f1ScoreTag.Size = new System.Drawing.Size(66, 28);
            this.f1ScoreTag.TabIndex = 5;
            this.f1ScoreTag.Text = "F1 Score:";
            // 
            // recallLabel
            // 
            this.recallLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recallLabel.AutoSize = true;
            this.recallLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recallLabel.Location = new System.Drawing.Point(75, 54);
            this.recallLabel.Name = "recallLabel";
            this.recallLabel.Size = new System.Drawing.Size(298, 26);
            this.recallLabel.TabIndex = 6;
            this.recallLabel.Text = "1";
            // 
            // f1ScoreLabel
            // 
            this.f1ScoreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.f1ScoreLabel.AutoSize = true;
            this.f1ScoreLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f1ScoreLabel.Location = new System.Drawing.Point(75, 80);
            this.f1ScoreLabel.Name = "f1ScoreLabel";
            this.f1ScoreLabel.Size = new System.Drawing.Size(298, 28);
            this.f1ScoreLabel.TabIndex = 7;
            this.f1ScoreLabel.Text = "0.8502563718702048";
            // 
            // CorrelationLabel
            // 
            this.CorrelationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CorrelationLabel.AutoSize = true;
            this.CorrelationLabel.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrelationLabel.Location = new System.Drawing.Point(3, 279);
            this.CorrelationLabel.Name = "CorrelationLabel";
            this.CorrelationLabel.Size = new System.Drawing.Size(694, 22);
            this.CorrelationLabel.TabIndex = 4;
            this.CorrelationLabel.Text = "Feature-Label Correlation:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.destinationPortTag, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.avgFwdSegmentSizeTag, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.maxPacketLenTag, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.minPacketLenTag, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.totalLenOfFwdPacketsTag, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.totalLenOfBwdPacketsTag, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.destinationPortLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.avgFwdSegmentSizeLabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.maxPacketLenLabel, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.minPacketLenLabel, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.totalLenOfFwdPacketsLabel, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.totalLenOfBwdPacketsLabel, 1, 5);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 304);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(376, 119);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // destinationPortTag
            // 
            this.destinationPortTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationPortTag.AutoSize = true;
            this.destinationPortTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationPortTag.Location = new System.Drawing.Point(3, 0);
            this.destinationPortTag.Name = "destinationPortTag";
            this.destinationPortTag.Size = new System.Drawing.Size(182, 19);
            this.destinationPortTag.TabIndex = 0;
            this.destinationPortTag.Text = "Destination Port:";
            // 
            // avgFwdSegmentSizeTag
            // 
            this.avgFwdSegmentSizeTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avgFwdSegmentSizeTag.AutoSize = true;
            this.avgFwdSegmentSizeTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgFwdSegmentSizeTag.Location = new System.Drawing.Point(3, 19);
            this.avgFwdSegmentSizeTag.Name = "avgFwdSegmentSizeTag";
            this.avgFwdSegmentSizeTag.Size = new System.Drawing.Size(182, 19);
            this.avgFwdSegmentSizeTag.TabIndex = 1;
            this.avgFwdSegmentSizeTag.Text = "Average Forward Segment Size:";
            // 
            // maxPacketLenTag
            // 
            this.maxPacketLenTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPacketLenTag.AutoSize = true;
            this.maxPacketLenTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPacketLenTag.Location = new System.Drawing.Point(3, 38);
            this.maxPacketLenTag.Name = "maxPacketLenTag";
            this.maxPacketLenTag.Size = new System.Drawing.Size(182, 20);
            this.maxPacketLenTag.TabIndex = 2;
            this.maxPacketLenTag.Text = "Maximum Packet Length:";
            // 
            // minPacketLenTag
            // 
            this.minPacketLenTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minPacketLenTag.AutoSize = true;
            this.minPacketLenTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPacketLenTag.Location = new System.Drawing.Point(3, 58);
            this.minPacketLenTag.Name = "minPacketLenTag";
            this.minPacketLenTag.Size = new System.Drawing.Size(182, 20);
            this.minPacketLenTag.TabIndex = 3;
            this.minPacketLenTag.Text = "Minimum Packet Length:";
            // 
            // totalLenOfFwdPacketsTag
            // 
            this.totalLenOfFwdPacketsTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLenOfFwdPacketsTag.AutoSize = true;
            this.totalLenOfFwdPacketsTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLenOfFwdPacketsTag.Location = new System.Drawing.Point(3, 78);
            this.totalLenOfFwdPacketsTag.Name = "totalLenOfFwdPacketsTag";
            this.totalLenOfFwdPacketsTag.Size = new System.Drawing.Size(182, 20);
            this.totalLenOfFwdPacketsTag.TabIndex = 4;
            this.totalLenOfFwdPacketsTag.Text = "Total Length Of Forward Packets:";
            // 
            // totalLenOfBwdPacketsTag
            // 
            this.totalLenOfBwdPacketsTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLenOfBwdPacketsTag.AutoSize = true;
            this.totalLenOfBwdPacketsTag.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLenOfBwdPacketsTag.Location = new System.Drawing.Point(3, 98);
            this.totalLenOfBwdPacketsTag.Name = "totalLenOfBwdPacketsTag";
            this.totalLenOfBwdPacketsTag.Size = new System.Drawing.Size(182, 21);
            this.totalLenOfBwdPacketsTag.TabIndex = 5;
            this.totalLenOfBwdPacketsTag.Text = "Total Length Of Backward Packets:";
            // 
            // destinationPortLabel
            // 
            this.destinationPortLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.destinationPortLabel.AutoSize = true;
            this.destinationPortLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationPortLabel.Location = new System.Drawing.Point(191, 0);
            this.destinationPortLabel.Name = "destinationPortLabel";
            this.destinationPortLabel.Size = new System.Drawing.Size(182, 19);
            this.destinationPortLabel.TabIndex = 6;
            this.destinationPortLabel.Text = "-0.5097984263116994";
            // 
            // avgFwdSegmentSizeLabel
            // 
            this.avgFwdSegmentSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avgFwdSegmentSizeLabel.AutoSize = true;
            this.avgFwdSegmentSizeLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgFwdSegmentSizeLabel.Location = new System.Drawing.Point(191, 19);
            this.avgFwdSegmentSizeLabel.Name = "avgFwdSegmentSizeLabel";
            this.avgFwdSegmentSizeLabel.Size = new System.Drawing.Size(182, 19);
            this.avgFwdSegmentSizeLabel.TabIndex = 7;
            this.avgFwdSegmentSizeLabel.Text = "-0.3568946974641414";
            // 
            // maxPacketLenLabel
            // 
            this.maxPacketLenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxPacketLenLabel.AutoSize = true;
            this.maxPacketLenLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPacketLenLabel.Location = new System.Drawing.Point(191, 38);
            this.maxPacketLenLabel.Name = "maxPacketLenLabel";
            this.maxPacketLenLabel.Size = new System.Drawing.Size(182, 20);
            this.maxPacketLenLabel.TabIndex = 8;
            this.maxPacketLenLabel.Text = "0.414398870658917";
            // 
            // minPacketLenLabel
            // 
            this.minPacketLenLabel.AutoSize = true;
            this.minPacketLenLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPacketLenLabel.Location = new System.Drawing.Point(191, 58);
            this.minPacketLenLabel.Name = "minPacketLenLabel";
            this.minPacketLenLabel.Size = new System.Drawing.Size(136, 20);
            this.minPacketLenLabel.TabIndex = 9;
            this.minPacketLenLabel.Text = "-0.4273963444748251";
            // 
            // totalLenOfFwdPacketsLabel
            // 
            this.totalLenOfFwdPacketsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLenOfFwdPacketsLabel.AutoSize = true;
            this.totalLenOfFwdPacketsLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLenOfFwdPacketsLabel.Location = new System.Drawing.Point(191, 78);
            this.totalLenOfFwdPacketsLabel.Name = "totalLenOfFwdPacketsLabel";
            this.totalLenOfFwdPacketsLabel.Size = new System.Drawing.Size(182, 20);
            this.totalLenOfFwdPacketsLabel.TabIndex = 10;
            this.totalLenOfFwdPacketsLabel.Text = "-0.31969338728047997";
            // 
            // totalLenOfBwdPacketsLabel
            // 
            this.totalLenOfBwdPacketsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLenOfBwdPacketsLabel.AutoSize = true;
            this.totalLenOfBwdPacketsLabel.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLenOfBwdPacketsLabel.Location = new System.Drawing.Point(191, 98);
            this.totalLenOfBwdPacketsLabel.Name = "totalLenOfBwdPacketsLabel";
            this.totalLenOfBwdPacketsLabel.Size = new System.Drawing.Size(182, 21);
            this.totalLenOfBwdPacketsLabel.TabIndex = 11;
            this.totalLenOfBwdPacketsLabel.Text = "0.04124448298560015";
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nextButton.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextButton.Location = new System.Drawing.Point(635, 402);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(153, 33);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next >>";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(635, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 194);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticsForm";
            this.Text = "S.H.I.E.L.D";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label confusionMatrixLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label CorrelationLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label positiveLabel1;
        private System.Windows.Forms.Label negativeLabel1;
        private System.Windows.Forms.Label positiveLabel2;
        private System.Windows.Forms.Label negativeLabel2;
        private System.Windows.Forms.Label posPosLabel;
        private System.Windows.Forms.Label posNegLabel;
        private System.Windows.Forms.Label negPosLabel;
        private System.Windows.Forms.Label negNegLabel;
        private System.Windows.Forms.Label accuracyTag;
        private System.Windows.Forms.Label accuracyLabel;
        private System.Windows.Forms.Label precisionTag;
        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Label recallTag;
        private System.Windows.Forms.Label f1ScoreTag;
        private System.Windows.Forms.Label recallLabel;
        private System.Windows.Forms.Label f1ScoreLabel;
        private System.Windows.Forms.Label destinationPortTag;
        private System.Windows.Forms.Label avgFwdSegmentSizeTag;
        private System.Windows.Forms.Label maxPacketLenTag;
        private System.Windows.Forms.Label minPacketLenTag;
        private System.Windows.Forms.Label totalLenOfFwdPacketsTag;
        private System.Windows.Forms.Label totalLenOfBwdPacketsTag;
        private System.Windows.Forms.Label destinationPortLabel;
        private System.Windows.Forms.Label avgFwdSegmentSizeLabel;
        private System.Windows.Forms.Label maxPacketLenLabel;
        private System.Windows.Forms.Label minPacketLenLabel;
        private System.Windows.Forms.Label totalLenOfFwdPacketsLabel;
        private System.Windows.Forms.Label totalLenOfBwdPacketsLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}