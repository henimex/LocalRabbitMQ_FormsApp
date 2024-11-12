using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace LocalRabbitMQ_FormsApp
{
    public partial class Form1 : Form
    {
        #region Variables

        private bool _isConnectionOpen;
        private bool isConnectionOpen;
        private string ConnectionString = "amqp://guest:guest@127.0.0.1:5672";
        private IConnection connection;
        private IModel _channel;
        private IModel channel => _channel ?? (_channel = HandleChannel());

        #endregion

        public Form1()
        {
            InitializeComponent();
            FillData();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!isConnectionOpen || connection == null)
            {
                connection = GetConnection();
            }
            else
            {
                connection.Close();
            }

            isConnectionOpen = connection.IsOpen;
            ConnectionStateChanged();
        }

        private void btnDeclareExchange_Click(object sender, EventArgs e)
        {
            channel.ExchangeDeclare(txtExchangeName.Text, cboxExchangeType.Text, autoDelete: false);
            AddLog($"Exchange Create: {txtExchangeName.Text} | {cboxExchangeType.Text} Created");
        }

        private void btnDeclareQue_Click(object sender, EventArgs e)
        {
            channel.QueueDeclare(txtQueName.Text, exclusive: false, autoDelete: false);
            AddLog($"Que Create: {txtQueName.Text} Created");
        }

        private void btnBindQueue_Click(object sender, EventArgs e)
        {
            channel.QueueBind(txtQueName.Text, txtExchangeName.Text, txtRoutingKey1.Text);
            AddLog($"Que Create: {txtQueName.Text} and {txtExchangeName.Text} were bind under {txtRoutingKey1.Text}");
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            var message = txtMessage.Text;

            if (checkUseCounter.Checked)
            {
                for (int i = 0; i < numCounter.Value; i++)
                {
                    message = $"{i + 1} {message}";
                    WriteData(txtPublishExchange.Text, txtPublishRoutingKey.Text, message);
                    AddLog($"Message Sent ({i + 1})");
                }
            }
            else
            {
                WriteData(txtPublishExchange.Text, txtPublishRoutingKey.Text, message);
                AddLog("Message Sent...");
            }
        }

        private void WriteData(string exchange, string routingKey, object data)
        {
            var dataArray = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
            channel.BasicPublish(exchange, routingKey, null, dataArray);
        }

        private IConnection GetConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri(txtConnectionString.Text, UriKind.RelativeOrAbsolute)
            };
            return factory.CreateConnection();
        }

        private IModel HandleChannel()
        {
            return connection.CreateModel();
        }

        #region Methods

        private void ConnectionStateChanged()
        {
            btnConnect.Text = isConnectionOpen ? "Disconnect" : "Connect";
            UpdateConnectionStatus();
        }

        private void UpdateConnectionStatus()
        {
            string state = $"{(isConnectionOpen ? "" : "Not ")}Connected";
            AddLog(state);
        }

        private void AddLog(string logStr)
        {
            logStr = $"{DateTime.Now:dd.MM.yyyy HH:mm:ss}: {logStr}";
            txtLog.AppendText($"{logStr}\n");

            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }

        private void FillData()
        {
            txtConnectionString.Text = ConnectionString;

            cboxExchangeType.Items.Add("direct");
            cboxExchangeType.Items.Add("fanout");
            cboxExchangeType.Items.Add("headers");
            cboxExchangeType.Items.Add("topic");

            cboxPublishExchangeType.Items.Add("direct");
            cboxPublishExchangeType.Items.Add("fanout");
            cboxPublishExchangeType.Items.Add("headers");
            cboxPublishExchangeType.Items.Add("topic");

            cboxExchangeType.SelectedIndex = cboxPublishExchangeType.SelectedIndex = 0;
        }

        #endregion
    }
}