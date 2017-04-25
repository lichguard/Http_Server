using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Http_Server
{

    public partial class Form1 : Form
    {
        Server server;
        Config configfile = new Config();

        List<System.Windows.Forms.TabPage> Tabs = new List<TabPage>();
        List<System.Windows.Forms.TextBox> logs = new List<TextBox>();
        Hashtable Clients = new Hashtable();
        public Form1()
        {
            InitializeComponent();
            // to create new one:

            Clients.Add("txtbox","");
            if ( configfile.AutoIp_checked)
            {
                checkBox_autoip.Checked = true;
                txtbox_ip.Text = LocalIPAddress();

            }
            else
            txtbox_ip.Text = configfile.IP_int;

            if (configfile.Autopath_checked)
            {
                checkBox_autopath.Checked = true;
                txtbox_path.Text = Directory.GetCurrentDirectory();

            }
            else
                txtbox_path.Text = configfile.Root_string;

            numeric_port.Value = configfile.Port_int;
            numeric_timeout.Value = configfile.Timout_int;
            txtbox_path.Text = configfile.Root_string;
            numeric_maxcon.Value = configfile.Max_con;



          
        }
        public string LocalIPAddress()
        {

            string strHostName = "";
            strHostName = System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);
            IPAddress[] addr = ipEntry.AddressList;
            return addr[addr.Length - 2].ToString(); ;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            // to start it
            bool success = false;
            server = new Server();
            success = server.start(IPAddress.Parse(txtbox_ip.Text), decimal.ToInt32(numeric_port.Value), decimal.ToInt32(numeric_timeout.Value), decimal.ToInt32(numeric_maxcon.Value), txtbox_path.Text, this);
            button_stop.Enabled = true;
            button_start.Enabled = false;
            timer.Enabled = true;
            label_timeelapsed.Text = "0";
            txtbox_ip.Enabled = false;

            txtbox_path.Enabled = false;
            numeric_port.Enabled = false;
            numeric_timeout.Enabled = false;
            numeric_maxcon.Enabled = false;

            if (!success)
            {
                button_stop_Click(this, new EventArgs());
            }

        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            // to stop it
            if (server != null)
            {
                if (server.running)
                {
                    server.stop();
                    AppendTextBox("txtbox", "The server has been terminated...");
                    button_stop.Enabled = false;
                    button_start.Enabled = true;
                    timer.Enabled = false;
                    txtbox_ip.Enabled = true;

                    txtbox_path.Enabled = true;
                    numeric_port.Enabled = true;
                    numeric_timeout.Enabled = true;
                    numeric_maxcon.Enabled = true;
                }
            }
        }

        public delegate void Invoke_Text(string control, string text);  // defines a delegate 

        public void AppendTextBox(string client, string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Invoke_Text(AppendTextBox), new object[] { client, value });
                return;
            }

            Control[] the_log = this.Controls.Find(client + "_log", true);
            

                if (!Clients.ContainsKey(client))
                {
                    Clients.Add(client, "");
                    Add_New_Client(client);
                 }


            if (the_log.Length != 0)
            {
                TextBox txt = (TextBox)the_log[0];
                txt.Text += Environment.NewLine + value + Environment.NewLine;

                txt.SelectionStart = txt.TextLength;
                txt.ScrollToCaret();

          }
        }

        public void Add_New_Client(string value)
        {
            Tabs.Add(new System.Windows.Forms.TabPage());
            Tabs[Tabs.Count - 1].Location = new System.Drawing.Point(4, 22);
            Tabs[Tabs.Count - 1].Name = value + "_tab";
            Tabs[Tabs.Count - 1].Padding = new System.Windows.Forms.Padding(3);
            Tabs[Tabs.Count - 1].Size = new System.Drawing.Size(377, 241);
            Tabs[Tabs.Count - 1].TabIndex = 1;
            Tabs[Tabs.Count - 1].Text = value;
            this.Tab_log.Controls.Add(this.Tabs[Tabs.Count - 1]);
            Tabs[Tabs.Count - 1].UseVisualStyleBackColor = true;
          //  this.Controls.Add(Tabs[Tabs.Count - 1]);


            logs.Add(new System.Windows.Forms.TextBox());
            logs[logs.Count - 1] = new System.Windows.Forms.TextBox();
            this.Tabs[Tabs.Count - 1].Controls.Add(this.logs[logs.Count - 1]);
            logs[logs.Count - 1].BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            logs[logs.Count - 1].ForeColor = System.Drawing.SystemColors.Window;
            logs[logs.Count - 1].Location = new System.Drawing.Point(-2, -2);
            logs[logs.Count - 1].Multiline = true;
            logs[logs.Count - 1].Name = value + "_log";
            logs[logs.Count - 1].ReadOnly = true;
            logs[logs.Count - 1].ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            logs[logs.Count - 1].Size = new System.Drawing.Size(377, 242);
            logs[logs.Count - 1].TabIndex = 2;
           
        }

        private void txtbox_log_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            button_stop_Click(this, new EventArgs());

       
            configfile.IP_int = txtbox_ip.Text;
            configfile.Port_int = numeric_port.Value;
            configfile.Timout_int = numeric_timeout.Value;
            configfile.Max_con = numeric_maxcon.Value;
            configfile.Root_string = txtbox_path.Text;
            configfile.Save();


          
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_timeelapsed.Text = (int.Parse(label_timeelapsed.Text)+1).ToString();
        }

        private void checkBox_autoip_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_autoip.Checked)
            {
                txtbox_ip.Text = LocalIPAddress();
                configfile.AutoIp_checked = true;
            }
            else
            {
                txtbox_ip.Text = configfile.IP_int;
                configfile.AutoIp_checked = false;
            }


        }

        private void checkBox_autopath_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox_autopath.Checked)
            {
                txtbox_path.Text = Directory.GetCurrentDirectory();
                configfile.Autopath_checked = true;
            }
            else
            {
                txtbox_path.Text = configfile.Root_string;
                configfile.Autopath_checked = false;
            }
        }
    }

    public class Server
    {
        public bool running = false; // Is it running?
        private Form1 control_panel;
       // private int timeout = 10; // Time limit for data transfers.
        private Encoding charEncoder = Encoding.UTF8; // To encode string
        private Socket serverSocket; // Our server socket
        private string contentPath; // Root path of our contents
        private Hashtable Clients = new Hashtable();
        // Content types that are supported by our server
        // You can add more...
        // To see other types: http://www.webmaster-toolkit.com/mime-types.shtml
        private Dictionary<string, string> extensions = new Dictionary<string, string>()
{ 
    //{ "extension", "content type" }
    { "htm", "text/html" },
    { "html", "text/html" },
    { "xml", "text/xml" },
    { "txt", "text/plain" },
    { "css", "text/css" },
    { "png", "image/png" },
    { "gif", "image/gif" },
    { "jpg", "image/jpg" },
    { "jpeg", "image/jpeg" },
    { "zip", "application/zip"},
     { "js", "application/js"}
};
        public bool start(IPAddress ipAddress, int port,int timeout, int maxNOfCon, string contentPath,Form1 control_panel)
        {
            this.control_panel = control_panel;
            if (running) return false; // If it is already running, exit.

            try
            {
                // A tcp/ip socket (ipv4)
                serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
                               ProtocolType.Tcp);
                serverSocket.Bind(new IPEndPoint(ipAddress, port));
                serverSocket.Listen(maxNOfCon);
                serverSocket.ReceiveTimeout = timeout;
                serverSocket.SendTimeout = timeout;
                running = true;
                this.contentPath = contentPath;
                control_panel.AppendTextBox("txtbox", string.Format("Initiating server with setting: {0}:{1}.  Timeout:{2}.  Path:{3}", ipAddress, port, timeout, contentPath));
            }
            catch( Exception e) 
            {
                control_panel.AppendTextBox("txtbox","FATAL ERROR STARING SERVER: " + e.Message );
                return false;
            }

            // Our thread that will listen connection requests
            // and create new threads to handle them.
            Thread requestListenerT = new Thread(() =>
            {
                while (running)
                {
                    Socket clientSocket;
                    IPEndPoint remoteIpEndPoint;
                    try
                    {
                        clientSocket = serverSocket.Accept();
                        // Create new thread to handle the request and continue to listen the socket.
                        remoteIpEndPoint = clientSocket.RemoteEndPoint as IPEndPoint;
                        control_panel.AppendTextBox("txtbox", "New Client IP - " + remoteIpEndPoint.Address + " : " + remoteIpEndPoint.Port + Environment.NewLine + "Delpoying new thread.. ( " + timeout.ToString() + " timeout )");
                        Thread requestHandler = new Thread(() =>
                        {
                            clientSocket.ReceiveTimeout = timeout;
                            clientSocket.SendTimeout = timeout;
                            try { handleTheRequest(clientSocket); }
                            catch
                            {
                                try { clientSocket.Close(); control_panel.AppendTextBox("txtbox", "Error - closing connection"); }
                                catch { }
                            }
                        });
                        requestHandler.Start();
                    }
                    catch { }
                }
            });
            requestListenerT.Start();

            return true;
        }
        public void stop()
        {
            if (running)
            {
                running = false;
                try { serverSocket.Close(); }
                catch { }
                serverSocket = null;
            }
        }
        private void handleTheRequest(Socket clientSocket)
        {
           


            byte[] buffer = new byte[10240]; // 10 kb, just in case
            int receivedBCount = clientSocket.Receive(buffer); // Receive the request
            string strReceived = charEncoder.GetString(buffer, 0, receivedBCount);

            IPEndPoint remoteIpEndPoint = clientSocket.RemoteEndPoint as IPEndPoint;

            if (!Clients.ContainsKey(remoteIpEndPoint.Address.ToString()))
            {
                Clients.Add(remoteIpEndPoint.Address.ToString(),"");
               
            }
            control_panel.AppendTextBox(remoteIpEndPoint.Address.ToString(), "Processing request: " + Environment.NewLine + "******************" + Environment.NewLine + strReceived + "**************");
            // Parse method of the request
            string httpMethod = strReceived.Substring(0, strReceived.IndexOf(" "));

            int start = strReceived.IndexOf(httpMethod) + httpMethod.Length + 1;
            int length = strReceived.LastIndexOf("HTTP") - start - 1;
            string requestedUrl = strReceived.Substring(start, length);

            string requestedFile;
            if (httpMethod.Equals("GET") || httpMethod.Equals("POST"))
                requestedFile = requestedUrl.Split('?')[0];
            else // You can implement other methods...
            {
                notImplemented(clientSocket);
                return;
            }

            requestedFile = requestedFile.Replace("/", @"\").Replace("\\..", "");
            start = requestedFile.LastIndexOf('.') + 1;

            control_panel.AppendTextBox(remoteIpEndPoint.Address.ToString(), "Sending file: " + Environment.NewLine + "------------------" + Environment.NewLine + contentPath + requestedFile + Environment.NewLine + "-----------------");

            if (start > 0)
            {
                length = requestedFile.Length - start;
                string extension = requestedFile.Substring(start, length);
                if (extensions.ContainsKey(extension)) // Do we support this extension?
                    if (File.Exists(contentPath + requestedFile)) //If yes check existence of the file
                        // Everything is OK, send requested file with correct content type:
                        sendOkResponse(clientSocket, File.ReadAllBytes(contentPath + requestedFile), extensions[extension]);
                    else
                        notFound(clientSocket); // We don't support this extension.
                // We are assuming that it doesn't exist.
            }
            else
            {


          
                // If file is not specified try to send index.htm or index.html
                // You can add more (default.htm, default.html)
                if (requestedFile.Substring(length - 1, 1) != @"\")
                    requestedFile += @"\";
                if (File.Exists(contentPath + requestedFile + "index.htm"))
                    sendOkResponse(clientSocket,
                      File.ReadAllBytes(contentPath + requestedFile + "\\index.htm"), "text/html");
                else if (File.Exists(contentPath + requestedFile + "index.html"))
                    sendOkResponse(clientSocket,
                      File.ReadAllBytes(contentPath + requestedFile + "\\index.html"), "text/html");
                else
                    notFound(clientSocket);
            }
        }
        private void notImplemented(Socket clientSocket)
        {

            sendResponse(clientSocket, "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"></head><body><h2>Atasoy Simple Web Server</h2><div>501 - Method Not Implemented</div></body></html>", "501 Not Implemented", "text/html");

        }

        private void notFound(Socket clientSocket)
        {

            sendResponse(clientSocket, "<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\"></head><body><h2>Atasoy Simple Web Server</h2><div>404 - Not Found</div></body></html>", "404 Not Found", "text/html");
        }

        private void sendOkResponse(Socket clientSocket, byte[] bContent, string contentType)
        {
            sendResponse(clientSocket, bContent, "200 OK", contentType);
        }
        // For strings
        private void sendResponse(Socket clientSocket, string strContent, string responseCode,
                                  string contentType)
        {
            byte[] bContent = charEncoder.GetBytes(strContent);
            sendResponse(clientSocket, bContent, responseCode, contentType);
        }

        // For byte arrays
        private void sendResponse(Socket clientSocket, byte[] bContent, string responseCode,
                                  string contentType)
        {
            try
            {
                byte[] bHeader = charEncoder.GetBytes(
                                    "HTTP/1.1 " + responseCode + "\r\n"
                                  + "Server: Internal Web Server\r\n"
                                  + "Content-Length: " + bContent.Length.ToString() + "\r\n"
                                  + "Connection: close\r\n"
                                  + "Content-Type: " + contentType + "\r\n\r\n");
                clientSocket.Send(bHeader);
                clientSocket.Send(bContent);
                clientSocket.Close();
                control_panel.AppendTextBox("txtbox", "Closing connection");

            }
            catch { }
        }
    }
}
