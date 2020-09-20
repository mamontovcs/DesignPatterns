using System.Windows.Forms;

namespace Decorator
{
    internal class LoggerDecorator : ILogger
    {
        private ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public void Log(string message)
        {
            _logger.Log(message);
            MessageBox.Show("We have dynamically added new functionality !");
        }
    }
}
