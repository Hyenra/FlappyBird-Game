using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        // Oyun değişkenleri
        int boruHizi = 8;
        int yerCekimi = 10;
        int skor = 0;
        bool oyunBitti = false;

        public Form1()
        {
            InitializeComponent();
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            // Kuş başlangıç pozisyonu
            flappyBird.Top = 200;
            flappyBird.Left = 50;

            // Borular başlangıç pozisyonu
            boruUst.Left = 400;
            boruAlt.Left = 400;

            // Skor sıfırlama
            skor = 0;
            skorText.Text = "Skor: 0";

            oyunBitti = false;
            gameTimer.Start();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // Kuş aşağı düşer (yerçekimi)
            flappyBird.Top += yerCekimi;

            // Borular sola hareket eder
            boruAlt.Left -= boruHizi;
            boruUst.Left -= boruHizi;

            // Skor güncelleme
            skorText.Text = "Skor: " + skor;

            // Borular ekranın dışına çıktığında tekrar başa döner
            if (boruAlt.Left < -100)
            {
                boruAlt.Left = 600;
                skor++;
            }

            if (boruUst.Left < -100)
            {
                boruUst.Left = 800;
                skor++;
            }

            // Çarpışma kontrolü
            if (flappyBird.Bounds.IntersectsWith(boruAlt.Bounds) ||
                flappyBird.Bounds.IntersectsWith(boruUst.Bounds) ||
                flappyBird.Bounds.IntersectsWith(zemin.Bounds) ||
                flappyBird.Top < -25)
            {
                OyunuBitir();
            }
        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            // Boşluk tuşuna basıldığında kuş yukarı zıplar
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = -10;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            // Boşluk tuşu bırakıldığında yerçekimi normale döner
            if (e.KeyCode == Keys.Space)
            {
                yerCekimi = 10;
            }

            // R tuşu ile oyunu yeniden başlat
            if (e.KeyCode == Keys.R && oyunBitti)
            {
                OyunuBaslat();
            }
        }

        private void OyunuBitir()
        {
            gameTimer.Stop();
            oyunBitti = true;
            skorText.Text = "Oyun Bitti! Skor: " + skor + " - R'ye basarak tekrar oynayın";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}