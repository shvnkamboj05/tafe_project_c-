using System;

using System.Windows.Forms;

using System.Text;

using System.Net.Sockets ;

using System.Threading;

    public partial class ClientNew : Form

    {

        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

        NetworkStream serverStream = default(NetworkStream);
        private Label label1;
        private TextBox textBox3;
        private Button button2;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private RichTextBox serverRichTextBox2;
        private TextBox serverTextBox1;
        private Button button1;
        private Label label4;
        private Label label5;
        private Label label6;

        string readData = null;


        public ClientNew()
        {
            InitializeComponent();

        }


        private void button2_Click(object sender, EventArgs e)

        {

            readData = "Conected to Chat Server ...";

            msg();

            clientSocket.Connect("127.0.0.1", 8888);

            serverStream = clientSocket.GetStream();



            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(textBox3.Text + "$");

            serverStream.Write(outStream, 0, outStream.Length);

            serverStream.Flush();



            Thread ctThread = new Thread(getMessage);

            ctThread.Start();

        }



        private void getMessage()

        {

            while (true)

            {

                serverStream = clientSocket.GetStream();

                int buffSize = 0;

                byte[] inStream = new byte[10025];

                buffSize = clientSocket.ReceiveBufferSize;

                serverStream.Read(inStream, 0, buffSize);

                string returndata = System.Text.Encoding.ASCII.GetString(inStream);

                readData = "" + returndata;

                msg();

            }

        }



        private void msg()

        {

            if (this.InvokeRequired)

                this.Invoke(new MethodInvoker(msg));


        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serverRichTextBox2 = new System.Windows.Forms.RichTextBox();
            this.serverTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Below are the messages recieved from server";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 258);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(441, 20);
            this.textBox3.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(422, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Client Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Client Says:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server Says:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(96, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(441, 223);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // serverRichTextBox2
            // 
            this.serverRichTextBox2.Location = new System.Drawing.Point(740, 29);
            this.serverRichTextBox2.Name = "serverRichTextBox2";
            this.serverRichTextBox2.ReadOnly = true;
            this.serverRichTextBox2.Size = new System.Drawing.Size(463, 223);
            this.serverRichTextBox2.TabIndex = 9;
            this.serverRichTextBox2.Text = "";
            // 
            // serverTextBox1
            // 
            this.serverTextBox1.Location = new System.Drawing.Point(740, 261);
            this.serverTextBox1.Name = "serverTextBox1";
            this.serverTextBox1.Size = new System.Drawing.Size(463, 20);
            this.serverTextBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1076, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Server Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(670, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Server Says:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(670, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Client Says";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Below are the messages recieved from client";
            // 
            // ClientNew
            // 
            this.ClientSize = new System.Drawing.Size(1233, 351);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serverTextBox1);
            this.Controls.Add(this.serverRichTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ClientNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private string messageFromClient = null;
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            messageFromClient = textBox3.Text;
            Client.sendMessage(messageFromClient);
            while (true)
            {
                if (Server.getMessage() == null)
                {
                    continue;
                }
                serverRichTextBox2.AppendText("Client Says: " + Server.getMessage() + "\n");
                Server.setMessage(null);
                break;
            }
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = serverTextBox1.Text;
            Server.sendMessage(msg);
            while (true)
            {
                if (Client.getMessage() == null)
                {
                    continue;
                }
                richTextBox1.AppendText("Server Says : " + Client.getMessage() + "\n");
                Client.sendMessage(null);
                break;
            }
            serverTextBox1.Text = "";
        }

    }

