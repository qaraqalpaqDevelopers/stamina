using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;


namespace stamina
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player1 = new WindowsMediaPlayer();
        WindowsMediaPlayer player2 = new WindowsMediaPlayer();
        WindowsMediaPlayer player3 = new WindowsMediaPlayer();
        WindowsMediaPlayer player4 = new WindowsMediaPlayer();
        WindowsMediaPlayer player5 = new WindowsMediaPlayer();
        WindowsMediaPlayer player6 = new WindowsMediaPlayer();
        WindowsMediaPlayer player7 = new WindowsMediaPlayer();
        WindowsMediaPlayer player8 = new WindowsMediaPlayer();
        WindowsMediaPlayer player9 = new WindowsMediaPlayer();
        WindowsMediaPlayer player10 = new WindowsMediaPlayer();
        WindowsMediaPlayer player11 = new WindowsMediaPlayer();
        WindowsMediaPlayer player12 = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
                
        }
        int dawis = 0,duris=0;
        private void label1_Click(object sender, EventArgs e)
        {

        }
        string sanlar = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 ";
        string qisqa_sozler = " top bala shala qala terek kerek awa yaq aha jaz guz qis bahar sahar zat ata ana apa ala fon jaman jaqsi ";
        string uzin_sozler="Jasasin Biyg'a'rez ha'm Keleshegi Ulli  Qaraqalpaqstan Respublikasi !!! ";
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == bir.Text[0]&&bir.Text!=" ")
            {
                duris++;
                bir.Text=bir.Text.Substring(1);
                eki.Text+=e.KeyChar;
                if(eki.Text.Length > 15)
                    eki.Text=eki.Text.Substring(eki.Text.Length-15);
            }
            else if(baslawToolStripMenuItem.Text=="Baslaw"&&e.KeyChar==' ')
            {
                player3.URL = @"C:\Nursultan\fon.Mp3";
                taq_jup++;
                waqit.Start();
                baslawToolStripMenuItem.Text = "Toqtatiw";
                bir.Text = sanlar;
                eki.Text = "";
            }
            else if(bir.Text==" ")
            {
                button1.Enabled = false;
                waqit.Stop();
                panel1.Visible = true;
                label2.Text = "waqit:" + label4.Text + "\n50 den " + duris + " belgi jazildi";

            }
            else
            {
                
                if(dawis%11==0)
                player2.URL= @"C:\Nursultan\qate.Mp3";
                else if (dawis % 11 == 1)
                    player1.URL = @"C:\Nursultan\korova.Mp3";
                else if (dawis % 11 == 2)
                    player4.URL = @"C:\Nursultan\giena.Mp3"; 
                else if (dawis % 11 == 3)
                    player5.URL = @"C:\Nursultan\eshki.Mp3";
                else if (dawis % 11 == 4)
                    player6.URL = @"C:\Nursultan\shimpanze.Mp3";
               else if (dawis % 11 == 5)
                    player7.URL = @"C:\Nursultan\burunduk.Mp3";
                else if (dawis % 11 == 6)
                    player8.URL = @"C:\Nursultan\udar.Mp3";
                else if (dawis % 11 == 7)
                    player9.URL = @"C:\Nursultan\pishiq.Mp3";
                else if (dawis % 11 == 8)
                    player10.URL = @"C:\Nursultan\aaw.Mp3";
                else if (dawis % 11 == 9)
                    player11.URL = @"C:\Nursultan\lazer.Mp3";
                else if (dawis % 11 == 10)
                    player12.URL = @"C:\Nursultan\temir.Mp3";
                
                dawis++;
            }
        }

        private void baslawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            taq_jup++;
            if (taq_jup % 2 == 1)
            {
                player3.URL = @"C:\Nursultan\fon.Mp3";
                waqit.Start();
                baslawToolStripMenuItem.Text = "Toqtatiw";
                bir.Text = sanlar;
                eki.Text = "";
            }
            else
            {
                button1.Enabled=false;
                waqit.Stop();
                panel1.Visible = true;
                label2.Text = "waqit:" + label4.Text + "\n50 den " + duris + " belgi jazildi";
            }
        }
        int taq_jup = 0;
        private void rejimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bir.Text = sanlar;
            eki.Text = "";
        }

        private void qisqaSozlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bir.Text = qisqa_sozler;
            eki.Text = "";
        }

        private void uzinSozlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bir.Text = uzin_sozler;
            eki.Text = "";
        }
        int sekund = 0, minut = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            button1.Enabled = true;
            waqit.Start();
        }

        private void waqit_Tick(object sender, EventArgs e)
        {
            if (sekund == 59)
            {
                minut++;
                sekund = 0;
            }
            else
            {
                sekund++;
            }
            if (sekund < 10)
                label4.Text = "0" + minut + ":0" + sekund;
            else
            {
                label4.Text = "0" + minut + ":" + sekund;
            }
        }

        private void qizilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
