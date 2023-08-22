using System;
using System.Collections.Generic;
using System.IO;

namespace S.H.I.E.L.D_Server
{
	public class DecisionTreeClassifier
	{
		private TreeNode root;
		private string filePath;

		public DecisionTreeClassifier(string filePath)
        {
			this.filePath = filePath; 
		}

		public void Train(List<double[]> instances, List<string> labels)
		{
			root = BuildDecisionTree(instances, labels);

			StreamWriter writer = new StreamWriter(this.filePath, false);
			SaveTree(root, writer);
			writer.Close();
		}

		public string Predict(double[] instance)
		{
			TreeNode node = root;
			while (node.left != null && node.right != null)
			{
				if (instance[node.attributeIndex] <= node.threshold)
				{
					node = node.left;
				}
				else
				{
					node = node.right;
				}
			}
			return node.classification;
		}

		private TreeNode BuildDecisionTree(List<double[]> instances, List<string> labels)
		{
			if (AllInstancesHaveSameLabel(labels))
			{
				return new TreeNode { classification = labels[0] };
			}

			var AtrributeAndThreshold = ChooseBestAttribute(instances, labels);

			int bestAttributeIndex = AtrributeAndThreshold.Item1;
			double bestThreshold = AtrributeAndThreshold.Item2;

			List<double[]> leftInstances = new List<double[]>();
			List<double[]> rightInstances = new List<double[]>();
			List<string> leftLabels = new List<string>();
			List<string> rightLabels = new List<string>();

			for (int i = 0; i < instances.Count; i++)
			{
				if (instances[i][bestAttributeIndex] <= bestThreshold)
				{
					leftInstances.Add(instances[i]);
					leftLabels.Add(labels[i]);
				}
				else
				{
					rightInstances.Add(instances[i]);
					rightLabels.Add(labels[i]);
				}
			}

			TreeNode node = new TreeNode
			{
				attributeIndex = bestAttributeIndex,
				threshold = bestThreshold,
				classification = MostCommonLabel(labels)
			};

			if (leftInstances.Count == 0 || rightInstances.Count == 0)
			{
				return new TreeNode { classification = MostCommonLabel(labels) };
			}

			node.left = BuildDecisionTree(leftInstances, leftLabels);
			node.right = BuildDecisionTree(rightInstances, rightLabels);

			return node;
		}

		private string MostCommonLabel(List<string> labels)
		{
			Dictionary<string, int> labelCounts = new Dictionary<string, int>();
			foreach (string label in labels)
			{
				if (labelCounts.ContainsKey(label))
				{
					labelCounts[label]++;
				}
				else
				{
					labelCounts[label] = 1;
				}
			}
			int maxCount = -1;
			string mostCommonLabel = "";
			foreach (KeyValuePair<string, int> kvp in labelCounts)
			{
				if (kvp.Value > maxCount)
				{
					maxCount = kvp.Value;
					mostCommonLabel = kvp.Key;
				}
			}
			return mostCommonLabel;
		}

		private bool AllInstancesHaveSameLabel(List<string> labels)
		{
			for (int i = 1; i < labels.Count; i++)
			{
				if (labels[i] != labels[0])
				{
					return false;
				}
			}
			return true;
		}

		private (int, double) ChooseBestAttribute(List<double[]> instances, List<string> labels)
		{
			int numAttributes = instances[0].Length;
			double maxInfoGain = -1;
			int bestAttributeIndex = -1;
			double bestThreshold = 0;
			for (int i = 0; i < numAttributes; i++)
			{
				double threshold = ChooseBestThreshold(instances, labels, i);
				double infoGain = CalculateInformationGain(instances, labels, i, threshold);
				if (infoGain > maxInfoGain)
				{
					maxInfoGain = infoGain;
					bestThreshold = threshold;
					bestAttributeIndex = i;
				}
			}
			return (bestAttributeIndex, bestThreshold);
		}

		private double ChooseBestThreshold(List<double[]> instances, List<string> labels, int attributeIndex)
		{
			double[] attributeValues = new double[instances.Count];

			for (int i = 0; i < instances.Count; i++)
			{
				attributeValues[i] = instances[i][attributeIndex];
			}

			Array.Sort(attributeValues);
			List<double> thresholds = new List<double>();

			for (int i = 0; i < attributeValues.Length - 1; i++)
			{
				double threshold = (attributeValues[i] + attributeValues[i + 1]) / 2.0;
				if(!thresholds.Contains(threshold))
                {
					thresholds.Add(threshold);
				}
			}

			double bestThreshold = double.MinValue;
			double maxInfoGain = double.MinValue;
			for (int i = 0; i < thresholds.Count; i++)
			{
				double infoGain = CalculateInformationGain(instances, labels, attributeIndex, thresholds[i]);
				if (infoGain > maxInfoGain)
				{
					maxInfoGain = infoGain;
					bestThreshold = thresholds[i];
				}
			}

			return bestThreshold;
		}

		private double CalculateInformationGain(List<double[]> instances, List<string> labels, int attributeIndex, double threshold = double.NaN)
		{
			double entropyBefore = CalculateEntropy(labels);

			List<string> leftLabels = new List<string>();
			List<string> rightLabels = new List<string>();
			for (int i = 0; i < instances.Count; i++)
			{
				if (double.IsNaN(threshold))
				{
					if (instances[i][attributeIndex] <= threshold)
					{
						leftLabels.Add(labels[i]);
					}
					else
					{
						rightLabels.Add(labels[i]);
					}
				}
				else
				{
					if (instances[i][attributeIndex] < threshold)
					{
						leftLabels.Add(labels[i]);
					}
					else
					{
						rightLabels.Add(labels[i]);
					}
				}
			}

			double entropyAfter = (double)leftLabels.Count / labels.Count * CalculateEntropy(leftLabels) +
				(double)rightLabels.Count / labels.Count * CalculateEntropy(rightLabels);

			return entropyBefore - entropyAfter;
		}

		private double CalculateEntropy(List<string> labels)
		{
			Dictionary<string, int> labelCounts = new Dictionary<string, int>();
			foreach (string label in labels)
			{
				if (labelCounts.ContainsKey(label))
				{
					labelCounts[label]++;
				}
				else
				{
					labelCounts[label] = 1;
				}
			}
			double entropy = 0;
			foreach (KeyValuePair<string, int> kvp in labelCounts)
			{
				double p = (double)kvp.Value / labels.Count;
				entropy -= p * Math.Log(p, 2);
			}
			return entropy;
		}

		private void SaveTree(TreeNode node, StreamWriter writer)
		{
			writer.WriteLine(node.attributeIndex);
			writer.WriteLine(node.threshold);
			if (node.right == null && node.left == null)
			{
				writer.WriteLine(node.classification);
			}
			else
			{
				writer.WriteLine();
				SaveTree(node.right, writer);
				SaveTree(node.left, writer);
			}
		}

		public void LoadTree()
		{
			StreamReader reader = new StreamReader(filePath, true);
			root = new TreeNode();
			LoadNode(root, reader);
			reader.Close();
		}

		private void LoadNode(TreeNode node, StreamReader reader)
		{
			node.attributeIndex = int.Parse(reader.ReadLine());
			node.threshold = double.Parse(reader.ReadLine());
			string label = reader.ReadLine();
			if (!label.Equals(""))
			{
				node.classification = label;
			}
			else
			{
				node.left = new TreeNode();
				node.right = new TreeNode();
				LoadNode(node.right, reader);
				LoadNode(node.left, reader);
			}
		}

		public int[] ConfusionMatrix(List<String> y, List<double[]> X)
		{
			int[] counts = new int[4] { 0, 0, 0, 0 };

			for (int i = 0; i < X.Count; i++)
			{
				String y2 = Predict(X[i]);
				if (y2.Equals(y[i]))
				{
					if (y2.Equals("1"))
					{
						counts[0]++;
					}
					else
					{
						counts[1]++;
					}
				}
				else
				{
					if (y2.Equals("1"))
					{
						counts[2]++;
					}
					else
					{
						counts[3]++;
					}
				}
			}

			return counts;
		}

		public double CalculateAccuracy(int[] counts)
		{
			int tp = counts[0];
			int tn = counts[1];
			int fp = counts[2];
			int fn = counts[3];

			int total = tp + tn + fp + fn;
			int correct = tp + tn;
			return (double)correct / total;
		}

		public double CalculatePrecision(int[] counts)
		{
			int tp = counts[0];
			int fp = counts[2];

			return (double)tp / (tp + fp);
		}

		public double CalculateRecall(int[] counts)
		{
			int tp = counts[0];
			int fn = counts[3];

			return (double)tp / (tp + fn);
		}

		public double CalculateF1Score(double precision, double recall)
		{
			return 2 * ((precision * recall) / (precision + recall));
		}
	}
}