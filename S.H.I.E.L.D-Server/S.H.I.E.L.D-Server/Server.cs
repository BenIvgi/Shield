using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace S.H.I.E.L.D_Server
{
    class Server
    {
        private TcpListener listener;
        private DecisionTreeClassifier classifier;
        private MainForm mainForm;

        public Server(DecisionTreeClassifier classifier, MainForm mainForm)
        {
            this.classifier = classifier;
            this.mainForm = mainForm;

            this.listener = new TcpListener(IPAddress.Any, GlobalVariables.Port);

            listener.Start();
        }

        public void EstablishConnection()
        {
            TcpClient client = listener.AcceptTcpClient();
            NetworkStream stream = client.GetStream();

            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string packetData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

            string[] packetParts = packetData.Split(';');
            string[] headers = packetParts[0].Split(',');

            List<double> valuesForAnalysis = new List<double>();
            List<string> displayValues = new List<string>();

            lock (GlobalVariables.LockIDPacket)
            {
                displayValues.Add(GlobalVariables.IDPacket.ToString());
                GlobalVariables.IDPacket += 1;
            }

            foreach (string header in headers)
            {
                string[] values = header.Split(':');
                if (values[0] == "Source IP")
                {
                    displayValues.Add(values[1]);
                }
                else
                {
                    displayValues.Add(values[1]);
                    valuesForAnalysis.Add(double.Parse(values[1]));
                }
            }

            string classification = classifier.Predict(valuesForAnalysis.ToArray());
            if (classification == "0")
            {
                displayValues.Add("Reliable");
            }
            else if (classification == "1")
            {
                displayValues.Add("Malicious");
            }

            displayValues.Add(packetParts[1]);

            mainForm.AddNewRow(displayValues.ToArray());

            stream.Close();
            client.Close();
        }
    }
}