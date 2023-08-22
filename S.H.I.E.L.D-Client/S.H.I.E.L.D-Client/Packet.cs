using System;
using System.Linq;
using System.Text;

namespace S.H.I.E.L.D_Client
{
    public class Packet
    {
        private static readonly Random random = new Random();
        private string[] sourceIPAddresses = new string[] { "192.168.0.1", "10.0.0.1", "172.16.0.1", "192.168.1.1", "10.0.0.2", "192.168.0.10", "10.0.0.20", "172.16.0.5", "192.168.1.5", "10.0.0.100", "192.168.0.50", "10.0.0.255", "172.16.0.20", "192.168.1.100", "10.0.0.123", "192.168.0.100", "10.0.0.50", "172.16.0.100", "192.168.1.50", "10.0.0.192", "192.168.0.123", "10.0.0.150", "172.16.0.255", "192.168.1.123", "10.0.0.75", "192.168.0.200", "10.0.0.15", "172.16.1.1", "192.168.1.200", "10.0.0.30", "192.168.0.255", "10.0.0.5", "172.16.1.10", "192.168.1.255", "10.0.0.80", "192.168.0.77", "10.0.0.222", "172.16.1.100", "192.168.1.77", "10.0.0.35", "192.168.0.88", "10.0.0.12", "172.16.1.255", "192.168.1.88", "10.0.0.99", "192.168.0.33", "10.0.0.8", "172.16.2.1", "192.168.1.33", "10.0.0.125", "192.168.0.15", "10.0.0.222", "172.16.2.10", "192.168.1.15", "192.168.0.2", "10.0.0.3", "172.16.0.2", "192.168.1.2", "10.0.0.4", "192.168.0.11", "10.0.0.21", "172.16.0.6", "192.168.1.6", "10.0.0.101", "192.168.0.51", "10.0.0.256", "172.16.0.21", "192.168.1.101", "10.0.0.124", "192.168.0.101", "10.0.0.51", "172.16.0.101", "192.168.1.51", "10.0.0.193", "192.168.0.124", "10.0.0.151", "172.16.0.256", "192.168.1.124", "10.0.0.76", "192.168.0.201", "10.0.0.16", "172.16.1.2", "192.168.1.201", "10.0.0.31", "192.168.0.256", "10.0.0.6", "172.16.1.11", "192.168.1.256", "10.0.0.81", "192.168.0.78", "10.0.0.223", "172.16.1.101", "192.168.1.78", "10.0.0.36", "192.168.0.89", "10.0.0.13", "172.16.1.256", "192.168.1.89", "10.0.0.100", "192.168.0.34", "10.0.0.9", "172.16.2.2", "192.168.1.34", "10.0.0.126", "192.168.0.16", "10.0.0.223", "172.16.2.11", "192.168.1.16" };
		private double[] destinationPort = { 80, 27636, 64869, 64873, 80, 10010, 18715, 80, 25265, 28919, 50272, 80, 39396, 49283, 80, 33601, 51260, 50470, 62582, 9844, 9665, 80, 8719, 63607, 80, 80, 64924, 62404, 80, 21304, 21823, 20518, 35313, 80 };
		private double[] avgFwdSegmentSize = { 10.0, 3.0, 3.6, 4.0, 4.5, 4.8, 6.0, 6.25, 6.285714286, 6.333333333, 6.4, 6.5, 6.666666667, 6.727272727, 6.8, 6.888888889, 7.0, 7.142857143, 7.333333333, 7.6, 8.0, 8.666666667, 198.3333333, 164.0, 12.25, 202.0, 514.0, 55.42857143, 897.6666667, 95.5625, 95.7, 67.28571429 };
		private double[] maxPacketLength = { 10135, 10220, 11595, 1375, 1460, 20, 2920, 4295, 4380, 5755, 5840, 6, 7215, 7300, 8675, 8760, 10220, 601, 82, 453, 4488, 1370, 295, 2612, 3287, 466, 834, 808 };
		private double[] minPacketLength = { 0, 0, 0, 0, 0, 6, 6, 6, 6, 6, 256, 164, 110, 32, 29, 99, 84, 73, 60, 57, 52, 47, 45 };
		private double[] totalLengthOfFwdPackets = { 12, 18, 20, 24, 26, 30, 32, 36, 38, 44, 50, 56, 6, 62, 68, 74, 4237, 4898, 1010, 1604, 2570, 3800, 4930, 8243, 922, 73 };
		private double[] totalLengthOfBwdPackets = { 0, 11601, 11607, 11613, 1375, 1460, 30, 36, 6, 8766, 4791, 12287, 3434, 4454, 552, 42352, 11559, 3043, 4803, 49709 };
        private static readonly string[] data = { "Hello", "world", "This", "is", "a", "test", "packet", "Network", "data", "communication", "protocol", "transmission", "Message", "information", "computer", "internet", "system", "Packet", "transfer", "networking", "wireless", "router", "Server", "client", "request", "response", "TCP", "UDP", "IP", "address", "port", "protocol", "Ethernet", "DNS", "HTTP", "HTTPS", "FTP", "SMTP", "POP3", "IMAP", "Firewall", "Security", "Encryption", "Decryption", "Authentication", "Authorization", "Payload" };

        public byte[] PacketBuilder()
        {
            int index = random.Next(0, destinationPort.Length);
            string headers = "Source IP:" + sourceIPAddresses[index].ToString() + ",";
            index = random.Next(0, destinationPort.Length);
            headers += "Destination Port:" + destinationPort[index].ToString() + ",";
            index = random.Next(0, avgFwdSegmentSize.Length);
            headers += "Average Forward Segment Size:" + avgFwdSegmentSize[index].ToString() + ",";
            index = random.Next(0, maxPacketLength.Length);
            headers += "Max Packet Length:" + maxPacketLength[index].ToString() + ",";
            index = random.Next(0, minPacketLength.Length);
            headers += "Min Packet Length:" + minPacketLength[index].ToString() + ",";
            index = random.Next(0, totalLengthOfFwdPackets.Length);
            headers += "Total Length (Forward):" + totalLengthOfFwdPackets[index].ToString() + ",";
            index = random.Next(0, totalLengthOfBwdPackets.Length);
            headers += "Total Length (Backward):" + totalLengthOfBwdPackets[index].ToString();

            string packetData = GenerateRandomPacket();

            byte[] packet = Encoding.ASCII.GetBytes(headers + ";" + packetData);

            return packet;
        }

        private string GenerateRandomPacket()
        {
            int sentenceLength = random.Next(3, 8);
            string[] sentenceWords = GetRandomWords(sentenceLength);
            string packet = string.Join(" ", sentenceWords) + "!";

            return packet;
        }

        private string[] GetRandomWords(int count)
        {
            return Enumerable.Range(0, count).Select(_ => data[random.Next(data.Length)]).ToArray();
        }
    }
}

