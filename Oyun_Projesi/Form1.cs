using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Timers;

namespace Oyun_Projesi
{
    public partial class Form1 : Form
    {
        string project_dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;//Bulunan proje dosyasının yolunu verir.
        
        public int speed_left = 3;//topun hızı
        public int speed_top = 3;
        public int skorlar = 0;
        public DateTime then = DateTime.Now;
        

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = false;
            timer2.Enabled = true;
            
            this.TopMost = true;//Formu öne getir.
            raket.Top = oyunalani.Bottom - (oyunalani.Bottom / 10);//raketin pozisyonunu kuruldu.
            this.FormBorderStyle = FormBorderStyle.Sizable;
         
            //this.Bounds = Screen.PrimaryScreen.Bounds;//tam ekran yapmak
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void oyunalani_Paint(object sender, PaintEventArgs e)
        { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)//burada yeni oyun başlatacak kodu yazmak gerekli
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
            {
            timer_2_and_1_same_jobs();
            DateTime now = DateTime.Now;
            time_lbl.Text = Convert.ToString((now - then));//geçen süreyi gösterir.

            top.Left += speed_left; //topu harekete geçirme
            top.Top += speed_top;

            if (top.Bottom >= raket.Top && top.Bottom <= raket.Bottom && top.Left >= raket.Left && top.Right <= raket.Right) //raket çarpışması
            {
                speed_top += Convert.ToInt32((speed_top) * (0.1));
                speed_left += Convert.ToInt32((speed_left) * (0.1));
                speed_top = -speed_top; //yön değiştirme
            }
            if (top.Left <= oyunalani.Left)
            {
                speed_left = -speed_left;
            }
            if (top.Right >= oyunalani.Right)
            {
                speed_left = -speed_left;
            }
            if (top.Top <= oyunalani.Top)
            {
                speed_top = -speed_top;
            }
            if (top.Bottom >= oyunalani.Bottom)
            {
                timer1.Enabled = false;// top dışarıda.oyunu durdur
                timer2.Enabled = true;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(project_dir+"\\sad.wav");//proje dosyasının içinde bulunan sesi oynatmak için nesne tanımladık
                player.Play();//Oyun bittiğinde gelen sesi oynatır.
            }
        }

        private void skor_button_Click(object sender, EventArgs e)
        {

        }

        private void oyunalani_MouseClick(object sender, MouseEventArgs e)
        {
            // oyun ilk başındaki haline döndürülüyor.
            top.Top = 200;
            top.Left = 500;
            speed_left = 2; // oyun hızı başlangıca geri döndü
            speed_top = 2;
            skorlar = 0;
            timer1.Enabled = true;
            timer2.Enabled = false;
            then = DateTime.Now;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // oyun dururken hareketlerin gerçekleşmesi için timer2 oluşturduk.
            timer_2_and_1_same_jobs();
            
        }

        private void timer_2_and_1_same_jobs()
        {

            raket.Left = Cursor.Position.X - (raket.Width / 2); //raketin ortası imlecin pozisyonuna ayarlandı.
            if (raket.Left + raket.Width > oyunalani.Right)
            {
                raket.Left = oyunalani.Right - raket.Width;
            }
            if (raket.Left < oyunalani.Left)
            {
                raket.Left = oyunalani.Left;
            }
            oyunalani.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
            //İmleci gizle. Mauseun oyun alanının içinde olması koşuluyla.
            if (Cursor.Position.X <= oyunalani.Right && Cursor.Position.X >= oyunalani.Left)
            {
                if (Cursor.Position.Y >= oyunalani.Top && Cursor.Position.Y <= oyunalani.Bottom)
                {
                    Cursor.Hide(); 
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void oyunalani_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
   