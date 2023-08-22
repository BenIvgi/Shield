using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace S.H.I.E.L.D_Server
{
    public partial class StatisticsForm : Form
    {
        private static DecisionTreeClassifier classifier;

        public StatisticsForm(DecisionTreeClassifier classifier, DataManager data_source, List<double[]> X_test, List<string> y_test)
        {
            StatisticsForm.classifier = classifier;

            InitializeComponent();

            CalculateAndPrintStatistics(y_test, X_test);
            SetFeatureLabelCorrelation(data_source.data, data_source.labels);
        }

        private void CalculateAndPrintStatistics(List<string> y, List<double[]> X)
        {
            int[] counts = classifier.ConfusionMatrix(y, X);

            double accuracy = classifier.CalculateAccuracy(counts);
            double precision = classifier.CalculatePrecision(counts);
            double recall = classifier.CalculateRecall(counts);
            double f1Score = classifier.CalculateF1Score(precision, recall);

            posPosLabel.Text = counts[0].ToString(); // true positive
            posNegLabel.Text = counts[1].ToString(); // true negative
            negPosLabel.Text = counts[2].ToString(); // false positive
            negNegLabel.Text = counts[3].ToString(); // false negative

            accuracyLabel.Text = accuracy.ToString();
            precisionLabel.Text = precision.ToString();
            recallLabel.Text = recall.ToString();
            f1ScoreLabel.Text = f1Score.ToString();

            this.Refresh();
        }

        private void SetFeatureLabelCorrelation(List<double[]> data, List<string> labels)
        {
            int numFeatures = data[0].Length;
            double[] featureValues;

            featureValues = DataManager.GetFeatureValues(data, 0);
            destinationPortLabel.Text = DataManager.CalculateCorrelation(featureValues, labels).ToString();

            featureValues = DataManager.GetFeatureValues(data, 1);
            avgFwdSegmentSizeLabel.Text = DataManager.CalculateCorrelation(featureValues, labels).ToString();

            featureValues = DataManager.GetFeatureValues(data, 2);
            maxPacketLenLabel.Text = DataManager.CalculateCorrelation(featureValues, labels).ToString();

            featureValues = DataManager.GetFeatureValues(data, 3);
            minPacketLenLabel.Text = DataManager.CalculateCorrelation(featureValues, labels).ToString();

            featureValues = DataManager.GetFeatureValues(data, 4);
            totalLenOfFwdPacketsLabel.Text = DataManager.CalculateCorrelation(featureValues, labels).ToString();

            featureValues = DataManager.GetFeatureValues(data, 5);
            totalLenOfBwdPacketsLabel.Text = DataManager.CalculateCorrelation(featureValues, labels).ToString();

            this.Refresh();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(classifier);
            mainForm.Show();
            this.Hide();
        }
    }
}
