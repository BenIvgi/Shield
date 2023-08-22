using System;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;

namespace S.H.I.E.L.D_Client
{
    public partial class MainForm : Form
    {
        private Thread communicationThread;
        private bool activityFlag = false;
        private string serverIP;
        private int port;

        public MainForm(string serverIP, int port)
        {
            this.serverIP = serverIP;
            this.port = port;

            InitializeComponent();
            stop.Enabled = false;

            communicationThread = new Thread(HandleCommunication);
            communicationThread.Start();
        }

        private void HandleCommunication()
        {
            while (true)
            {
                if(activityFlag)
                {
                    SendPacket();
                }

                Thread.Sleep(250);
            }
        }

        private void SendPacket()
        {
            // Build the packet
            Packet packet = new Packet();
            byte[] packetBytes = packet.PacketBuilder();

            // Create a TCP client and connect to the server
            TcpClient client = new TcpClient();
            client.Connect(serverIP, port);

            // Send the packet to the server
            NetworkStream stream = client.GetStream();
            stream.Write(packetBytes, 0, packetBytes.Length);

            // Close the connection
            stream.Close();
            client.Close();
        }

        private void start_Click(object sender, EventArgs e)
        {
            activityFlag = true;

            start.Enabled = false;
            stop.Enabled = true;
        }

        private void stop_Click(object sender, EventArgs e)
        {
            activityFlag = false;

            stop.Enabled = false;
            start.Enabled = true;
        }
    }
}
