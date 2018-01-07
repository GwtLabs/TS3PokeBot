namespace TS3.PokeBot.Config
{
    public class Server
    {
        public string Host { get; set; } = "localhost";
        public ushort Port { get; set; } = 9987;
        public ushort QueryPort { get; set; } = 11011;
        public string Login { get; set; } = "serveradmin";
        public string Password { get; set; } = "";
    }
}
