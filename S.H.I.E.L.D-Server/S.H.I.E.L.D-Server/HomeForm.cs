using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace S.H.I.E.L.D_Server
{
    public partial class HomeForm : Form
    {
        private static DecisionTreeClassifier classifier;
        private static DataManager data_source;
        private static List<double[]> X_train;
        private static List<double[]> X_test;
        private static List<String> y_train;
        private static List<String> y_test;

        public HomeForm()
        {
            classifier = new DecisionTreeClassifier(GlobalVariables.FilePathModelTree);
            data_source = new DataManager(GlobalVariables.FilePathDataSource);
            data_source.ConvertCSVToList();
            (X_train, X_test, y_train, y_test) = DataManager.DivideData(data_source.data, data_source.labels, 0.8);

            InitializeComponent();
            Nextbutton.Enabled = false;
        }

        private void btnCreateDecisionTree_Click(object sender, EventArgs e)
        {
            btnCreateDecisionTree.Enabled = false;
            btnLoadDecisionTree.Enabled = false;

            classifier.Train(X_train, y_train);

            Nextbutton.Enabled = true;
        }

        private void btnLoadDecisionTree_Click(object sender, EventArgs e)
        {
            btnLoadDecisionTree.Enabled = false;
            btnCreateDecisionTree.Enabled = false;

            classifier.LoadTree();

            Nextbutton.Enabled = true;
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(classifier, data_source, X_test, y_test);
            statisticsForm.Show();
            this.Hide();
        }
    }
}