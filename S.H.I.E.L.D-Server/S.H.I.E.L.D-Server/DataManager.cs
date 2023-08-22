using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace S.H.I.E.L.D_Server
{
    public class DataManager
    {
        public List<double[]> data = new List<double[]>();
        public List<string> labels = new List<string>();
        private string filePath;

        public DataManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void ConvertCSVToList()
        {
            try
            {
                double label;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    // Read the header line
                    string headerLine = reader.ReadLine();

                    // Read the remaining lines while ((line = reader.ReadLine()) != null)
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] values = line.Split(',');

                        // Convert string values to doubles
                        double[] dataRow = new double[values.Length - 1];
                        for (int i = 0; i < values.Length - 1; i++)
                        {
                            if (!double.TryParse(values[i], out dataRow[i]))
                            {
                                // Handle parsing error if needed
                                throw new FormatException($"Error parsing value '{values[i]}' at line {data.Count + 1}, column {i + 1}.");
                            }
                        }
                        if (!double.TryParse(values[values.Length - 1], out label))
                        {
                            // Handle parsing error if needed
                            throw new FormatException($"Error parsing label '{values[values.Length - 1]}'.");
                        }

                        data.Add(dataRow);
                        labels.Add(label.ToString());
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // Handle file not found error if needed
                throw;
            }
            catch (Exception)
            {
                // Handle other exceptions if needed
                throw;
            }
        }

        public static void ShuffleData(List<String> y, List<double[]> X)
        {
            int[] indexes = new int[X.Count];
            for (int i = 0; i < X.Count; i++) { indexes[i] = i; }
            indexes = indexes.OrderBy(x => Guid.NewGuid()).ToArray();
            List<double[]> data = new List<double[]>();
            List<String> labels = new List<String>();
            for (int i = 0; i < X.Count; i++)
            {
                data.Add(X[indexes[i]]);
                labels.Add(y[indexes[i]]);
            }
            X = data;
            y = labels;
        }

        public static (List<double[]>, List<double[]>, List<String>, List<String>) DivideData(List<double[]> X, List<String> y, double ratio)
        {
            int i;
            List<double[]> data = new List<double[]>(X);
            List<String> labels = new List<String>(y);
            ShuffleData(labels, data);

            List<double[]> X_train = new List<double[]>();
            List<double[]> X_test = new List<double[]>();
            List<String> y_train = new List<String>();
            List<String> y_test = new List<String>();

            for (i = 0; i < X.Count * ratio; i++)
            {
                X_train.Add(data[i]);
                y_train.Add(labels[i]);
            }
            for (int j = i; j < X.Count; j++)
            {
                X_test.Add(data[j]);
                y_test.Add(labels[j]);
            }
            return (X_train, X_test, y_train, y_test);
        }

        public static double[] GetFeatureValues(List<double[]> data, int featureIndex)
        {
            double[] featureValues = new double[data.Count];
            for (int i = 0; i < data.Count; i++)
            {
                featureValues[i] = data[i][featureIndex];
            }
            return featureValues;
        }

        public static double CalculateCorrelation(double[] featureValues, List<string> labels)
        {
            int numSamples = featureValues.Length;

            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumXSquare = 0;
            double sumYSquare = 0;

            for (int i = 0; i < numSamples; i++)
            {
                double x = featureValues[i];
                double y = (labels[i] == "1") ? 1 : 0;

                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumXSquare += x * x;
                sumYSquare += y * y;
            }

            double correlation = (numSamples * sumXY - sumX * sumY) /
                                Math.Sqrt((numSamples * sumXSquare - sumX * sumX) *
            (numSamples * sumYSquare - sumY * sumY));
            return correlation;
        }
    }
}
