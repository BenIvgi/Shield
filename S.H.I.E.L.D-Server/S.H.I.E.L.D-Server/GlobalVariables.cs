namespace S.H.I.E.L.D_Server
{
    public static class GlobalVariables
    {
        public static int Port { get; set; } = 1234;

        public static int IDPacket { get; set; } = 1;
        public static readonly object LockIDPacket = new object();

        public static string FilePathModelTree { get; set; } = "F:\\Beit Barel College\\Final Project\\S.H.I.E.L.D\\S.H.I.E.L.D-Server\\S.H.I.E.L.D-Server\\ModelFiles\\ModelTree.txt";
        public static string FilePathDataSource { get; set; } = "F:\\Beit Barel College\\Final Project\\S.H.I.E.L.D\\S.H.I.E.L.D-Server\\S.H.I.E.L.D-Server\\ModelFiles\\CICIDS2017.csv";
    }
}
