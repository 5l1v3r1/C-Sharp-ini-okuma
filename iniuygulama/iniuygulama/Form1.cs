using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace iniuygulama
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dizin = Application.StartupPath;
            string progYol= dizin + @"\";
            //Tanımlama
            INIOkuyucu INI = new INIOkuyucu(progYol + "sunucuBilgileri.ini");

            //Okuma
            string web = INI.Oku("Sunucular", "web");
            textBox2.Text = web.ToString();

            string genelip = INI.Oku("Sunucular", "genelip");
            ipText.Text = genelip.ToString();

            string sohbet = INI.Oku("Sunucular", "sohbet");
            portSOHBETtext.Text = sohbet.ToString();

            string goruntu = INI.Oku("Sunucular", "goruntu");
            portGORUNTUtext.Text = goruntu.ToString();

            string ses = INI.Oku("Sunucular", "ses");
            portSEStext.Text = ses.ToString();

            string tahta = INI.Oku("Sunucular", "tahta");
            portTAHTAtext.Text = tahta.ToString();

            string diger = INI.Oku("Sunucular", "diger");
            portDIGERtext.Text = diger.ToString();

            //Yazma
            //INI.Yaz("Bilgiler", "Kullanici", "Umut Çağdaş");
        }
    }
}
