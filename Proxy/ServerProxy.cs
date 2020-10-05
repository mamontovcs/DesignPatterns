namespace Proxy
{
    class ServerProxy : IServer
    {
        private IServer _realServer;

        public string GETRequest()
        {
            if (_realServer == null)
            {
                _realServer = new Server();
            }

            return _realServer.GETRequest();
        }
    }
}
