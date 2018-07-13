using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace downloader2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebClient client;
        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtIn.Text;
            if (!string.IsNullOrEmpty(url)) {
                Thread thread = new Thread(()=> {
                    Uri uri = new Uri(url);
                    string name = System.IO.Path.GetFileName(uri.AbsolutePath);
                    client.DownloadFileAsync(uri, Application.StartupPath+"/"+name); 
                });
                thread.Start();
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }
        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e) {
            Invoke(new MethodInvoker(delegate () {
                progreso.Minimum = 0;
                double recibido = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double porcentaje = recibido / total * 100;
                lblPorcentaje.Text = $"{string.Format("{0:0.##}", porcentaje)}%";
                progreso.Value = int.Parse(Math.Truncate(porcentaje).ToString());
            }));
        }
        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lblPorcentaje.Text = "Listo!";
            Process.Start("shutdown", "/s /t 15");
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            int segundos = int.Parse(txtTime.Text) *60;
            Process.Start("shutdown", "/s /t "+segundos);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/a");
        }
    }
}
