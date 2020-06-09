using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace NDPprojeTasarim
{
    public class AtikKutusu : IAtikKutusu
    {


        public List<int> atiklar = new List<int>(); //atikları listeye ekler

        //listboxlara yazacak yazı alanı
        public string _yazi;

        public int _bosaltmaPuani { get; set; }

        public int _kapasite { get; set; }

        private int _doluHacim { get; set; }

        private int _dolulukOrani { get; set; }


        public int BosaltmaPuani => _bosaltmaPuani;

        public int Kapasite { get => _kapasite; set => _kapasite = value; }

        public int DoluHacim => _doluHacim;

        public int DolulukOrani => _dolulukOrani;


        public AtikKutusu(int bosaltmaPuani, int kapasite)
        {
            this._kapasite = kapasite;
            this._bosaltmaPuani = bosaltmaPuani;
        }


        public bool Bosalt()  //atik kutularını bosaltan fonksyon
        {


            if (_dolulukOrani >= 75)   // doluluk oranı %75 ten büyükse bosaltır 
            {

                atiklar.Clear();   //atik listesi temizlenir

                _doluHacim = 0;

                return true;

            }
            return false;

        }

        public bool Ekle(Atik atik)
        {
            if (_doluHacim + atik.Hacim <= _kapasite)  //atik kutusunda yeterli kapasite kaldıysa ekleme yapar
            {
                atiklar.Add(atik.Hacim);

                _doluHacim += atik.Hacim;   //kutuların dolan hacimleri

                _dolulukOrani = ((100 * _doluHacim) / _kapasite);    //doluluk orani hesaplanır

                _yazi = atik.Ad;  //listboxlara yazılacak yazı

                return true;
            }

            return false;

        }

        public void yeniOyun()   //yeni oyun için atık kutularının hacmini ve doluluk oranını sıfırlar 
        {
            atiklar.Clear();
            _doluHacim = 0;
            _dolulukOrani = 0;
        }

    }
    public class OrganikAtikKutusu : AtikKutusu
    {
        public OrganikAtikKutusu(int bosaltmaPuani, int kapasite) : base(bosaltmaPuani, kapasite)
        {


        }

    }
    public class KagitKutusu : AtikKutusu
    {
        public KagitKutusu(int bosaltmaPuani, int kapasite) : base(bosaltmaPuani, kapasite)
        {

        }
    }
    public class CamKutusu : AtikKutusu
    {
        public CamKutusu(int bosaltmaPuani, int kapasite) : base(bosaltmaPuani, kapasite)
        {


        }
    }
    public class MetalKutusu : AtikKutusu
    {
        public MetalKutusu(int bosaltmaPuani, int kapasite) : base(bosaltmaPuani, kapasite)
        {

        }
    }

}
