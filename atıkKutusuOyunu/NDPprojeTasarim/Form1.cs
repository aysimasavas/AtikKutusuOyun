
/**************************************************************************************************
**
**                         ÖĞRENCİ ADI: AYŞE AYSİMA SAVAŞ
**                         ÖĞRENCİ NUMARASI:B191210056
**                         DERS GRUBU:1.ÖĞRETİM C GRUBU
**
***************************************************************************************************/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPprojeTasarim
{
    public partial class Form1 : Form
    {
        private int _secim = 0;
        //puan ve zamanı tutan alanlar
        private int _time = 60;
        private int _puan = 0;

        Salatalik _salatalik;
        Domates _domates;
        CamSise _camSise;
        Bardak _bardak;
        Dergi _dergi;
        Gazete _gazete;
        KolaKutusu _kolaKutusu;
        SalcaKutusu _salcaKutusu;

        OrganikAtikKutusu _organikAtikKutusu;
        KagitKutusu _kagitKutusu;
        CamKutusu _camKutusu;
        MetalKutusu _metalKutusu;

        //random atık secebilmek için atık listesi
        private List<Atik> _atikListesi;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _salatalik = new Salatalik(120, Image.FromFile("salatalik.jpg"), "salatalık(120)");
            _domates = new Domates(150, Image.FromFile("domates.jpg"), "domates(150)");
            _camSise = new CamSise(600, Image.FromFile("camSise.jpg"), "cam şişe(600)");
            _bardak = new Bardak(250, Image.FromFile("camBardak.jpg"), "bardak(250)");
            _dergi = new Dergi(200, Image.FromFile("dergi.jpg"), "dergi(200)");
            _gazete = new Gazete(250, Image.FromFile("gazete.jpg"), "gazete(250)");
            _kolaKutusu = new KolaKutusu(350, Image.FromFile("kolaKutusu.jpg"), "kola kutusu(350)");
            _salcaKutusu = new SalcaKutusu(550, Image.FromFile("salcaKutusu.png"), "salca kutusu(550)");

            _organikAtikKutusu = new OrganikAtikKutusu(0, 700);  //atık kutularının bosaltmaPuanı ve kapasitesi
            _kagitKutusu = new KagitKutusu(1000, 1200);
            _camKutusu = new CamKutusu(600, 2200);
            _metalKutusu = new MetalKutusu(800, 2300);

            //atıklar bir listeye toplanır 
            _atikListesi = new List<Atik>() { _salatalik, _domates, _camSise, _bardak, _dergi, _gazete, _kolaKutusu, _salcaKutusu };

            butonlarDevreDisi();

            //BOSALT butonları

            bosaltOrganikAtikButton.Click += (s, ev) => { _secim = 1; bosalt(); };

            bosaltKagitButton.Click += (s, ev) => { _secim = 2; bosalt(); };

            bosaltCamButton.Click += (s, ev) => { _secim = 3; bosalt(); };

            bosaltMetalButton.Click += (s, ev) => { _secim = 4; bosalt(); };


            //ÇIKIŞ butonu

            cikisButton.Click += (se, ev) => { Application.Exit(); };

        }

        public void atikGetir()
        {
            //_atikListesinden random atik secerek atığın resmini pictureBoxa cıkarır

            Random _random;
            _random = new Random();

            pictureBox1.Image = _atikListesi[_random.Next(0, _atikListesi.Count)].Image;

        }


        public void bosalt()
        {
            switch (_secim)
            {
                case 1:

                    _organikAtikKutusu.Bosalt();

                    if (_organikAtikKutusu.Bosalt() == true)       //atik kutusundaki bosalt fonksyonu true dönerse işlemleri yapar
                    {
                        listBoxOrganik.Items.Clear();              //listbox temizlenir

                        progressBarOrganik.Value = 0;              //progressBar sıfırlanır

                        _time += 3;                                //süreye ekleme gerceklesir

                        _puan += _organikAtikKutusu.BosaltmaPuani;  //bosaltma puanı varsa eklenir

                        lblPuan.Text = _puan.ToString();

                    }

                    break;

                case 2:

                    _kagitKutusu.Bosalt();

                    if (_kagitKutusu.Bosalt() == true)
                    {
                        listBoxKagit.Items.Clear();

                        progressBarKagit.Value = 0;

                        _time += 3;

                        _puan += _kagitKutusu.BosaltmaPuani;

                        lblPuan.Text = _puan.ToString();

                    }


                    break;

                case 3:

                    _camKutusu.Bosalt();

                    if (_camKutusu.Bosalt() == true)
                    {
                        listBoxCam.Items.Clear();

                        progressBarCam.Value = 0;

                        _time += 3;

                        _puan += _camKutusu.BosaltmaPuani;

                        lblPuan.Text = _puan.ToString();

                    }


                    break;

                case 4:

                    _metalKutusu.Bosalt();

                    if (_metalKutusu.Bosalt() == true)
                    {
                        listBoxMetal.Items.Clear();

                        progressBarMetal.Value = 0;

                        _time += 3;

                        _puan += _metalKutusu.BosaltmaPuani;

                        lblPuan.Text = _puan.ToString();

                    }


                    break;

                default:

                    break;
            }
        }

        private void organikAtikButton_Click(object sender, EventArgs e)  //ORGANİK ATIK butonu
        {
            if (pictureBox1.Image == _salatalik.Image)
            {

                if (_organikAtikKutusu.Ekle(_salatalik) == true)      //ekle fonksyonu true dönerse işlemleri yapar
                {
                    listBoxOrganik.Items.Add(_organikAtikKutusu._yazi);
                    _puan += _salatalik.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarOrganik.Value = _organikAtikKutusu.DolulukOrani;
                    atikGetir();
                }

            }

            else if (pictureBox1.Image == _domates.Image)
            {

                if (_organikAtikKutusu.Ekle(_domates) == true)
                {
                    listBoxOrganik.Items.Add(_organikAtikKutusu._yazi);
                    _puan += _domates.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarOrganik.Value = _organikAtikKutusu.DolulukOrani;
                    atikGetir();
                }
            }


        }

        private void kagitButton_Click(object sender, EventArgs e)   //KAĞIT butonu
        {
            if (pictureBox1.Image == _dergi.Image)
            {

                if (_kagitKutusu.Ekle(_dergi) == true)
                {
                    listBoxKagit.Items.Add(_kagitKutusu._yazi);
                    _puan += _dergi.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarKagit.Value = _kagitKutusu.DolulukOrani;
                    atikGetir();
                }

            }
            else if (pictureBox1.Image == _gazete.Image)
            {

                if (_kagitKutusu.Ekle(_gazete) == true)
                {
                    listBoxKagit.Items.Add(_kagitKutusu._yazi);
                    _puan += _gazete.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarKagit.Value = _kagitKutusu.DolulukOrani;
                    atikGetir();
                }

            }

        }

        private void yeniOyunButton_Click(object sender, EventArgs e)    //YENİ OYUN butonu
        {

            yeniOyunBaslat();

            atikGetir();

            timerStart();

            butonlarEtkin();

            yeniOyunButton.Enabled = false;

        }

        private void camButton_Click(object sender, EventArgs e)  //CAM butonu
        {
            if (pictureBox1.Image == _camSise.Image)
            {

                if (_camKutusu.Ekle(_camSise) == true)
                {
                    listBoxCam.Items.Add(_camKutusu._yazi);
                    _puan += _camSise.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarCam.Value = _camKutusu.DolulukOrani;
                    atikGetir();
                }

            }
            else if (pictureBox1.Image == _bardak.Image)
            {

                if (_camKutusu.Ekle(_bardak) == true)
                {
                    listBoxCam.Items.Add(_camKutusu._yazi);
                    _puan += _bardak.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarCam.Value = _camKutusu.DolulukOrani;
                    atikGetir();
                }


            }

        }

        private void metalButton_Click(object sender, EventArgs e)  //METAL butonu
        {

            if (pictureBox1.Image == _kolaKutusu.Image)
            {
                if (_metalKutusu.Ekle(_kolaKutusu) == true)
                {
                    listBoxMetal.Items.Add(_metalKutusu._yazi);
                    _puan += _kolaKutusu.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarMetal.Value = _metalKutusu.DolulukOrani;
                    atikGetir();
                }

            }

            else if (pictureBox1.Image == _salcaKutusu.Image)
            {
                if (_metalKutusu.Ekle(_salcaKutusu) == true)
                {
                    listBoxMetal.Items.Add(_metalKutusu._yazi);
                    _puan += _salcaKutusu.Hacim;
                    lblPuan.Text = _puan.ToString();
                    progressBarMetal.Value = _metalKutusu.DolulukOrani;
                    atikGetir();
                }
            }

        }
        public void butonlarDevreDisi()    //butonları devre dısı bırakan fonksiyon
        {
            organikAtikButton.Enabled = false;
            kagitButton.Enabled = false;
            camButton.Enabled = false;
            metalButton.Enabled = false;


            bosaltOrganikAtikButton.Enabled = false;
            bosaltKagitButton.Enabled = false;
            bosaltCamButton.Enabled = false;
            bosaltMetalButton.Enabled = false;

        }
        public void butonlarEtkin()        //butonları etkin hale getiren fonksiyon
        {

            organikAtikButton.Enabled = true;
            kagitButton.Enabled = true;
            camButton.Enabled = true;
            metalButton.Enabled = true;


            bosaltOrganikAtikButton.Enabled = true;
            bosaltKagitButton.Enabled = true;
            bosaltCamButton.Enabled = true;
            bosaltMetalButton.Enabled = true;


        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            _time--;                       //time geri sayar

            if (_time == 0)               //süre bitince timer durur,label renkleri değişir,butonlar devre dısı olur.
            {
                timer1.Stop();
                lblSaniye.BackColor = Color.SlateGray;
                lblPuan.BackColor = Color.SlateGray;
                butonlarDevreDisi();
                yeniOyunButton.Enabled = true;
            }

            lblSaniye.Text = _time.ToString();

        }
        public void timerStart()         //timer başladığındaki işlemleri yapan fonksiyon
        {

            timer1.Interval = 1000; // 1 second
            _time = 60;
            timer1.Start();
            lblSaniye.BackColor = Color.CornflowerBlue;
            lblPuan.BackColor = Color.CornflowerBlue;
            lblSaniye.Text = _time.ToString();


        }
        public void yeniOyunBaslat()    //yeni oyun için gerekli olan fonksiyon
        {

            _organikAtikKutusu.yeniOyun();     //atık kutularının hacmini bosaltır,listboxları temizler,progressbarları sıfırlar.
            _kagitKutusu.yeniOyun();
            _camKutusu.yeniOyun();
            _metalKutusu.yeniOyun();


            progressBarOrganik.Value = 0;
            progressBarKagit.Value = 0;
            progressBarCam.Value = 0;
            progressBarMetal.Value = 0;


            listBoxOrganik.Items.Clear();
            listBoxKagit.Items.Clear();
            listBoxCam.Items.Clear();
            listBoxMetal.Items.Clear();


            _puan = 0;
            lblPuan.Text = _puan.ToString();

        }
    }
}
