using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPprojeTasarim
{


    public class Atik : IAtik
    {

        private int _hacim { get; set; }

        public int Hacim => _hacim;

        private string _ad { get; set; }

        public string Ad => _ad;




        private Image _image { get; set; }

        public Image Image => _image;


        public Atik(int hacim, Image image, string ad)
        {

            this._image = image;
            this._hacim = hacim;
            this._ad = ad;

        }

    }

    public class Salatalik : Atik
    {

        public Salatalik(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }

    }

    public class Domates : Atik
    {

        public Domates(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }
    }

    public class Dergi : Atik
    {

        public Dergi(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }
    }

    public class Gazete : Atik
    {
        public Gazete(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }
    }

    public class CamSise : Atik
    {

        public CamSise(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }

    }

    public class Bardak : Atik
    {

        public Bardak(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }

    }

    public class KolaKutusu : Atik
    {

        public KolaKutusu(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }
    }

    public class SalcaKutusu : Atik
    {

        public SalcaKutusu(int hacim, Image image, string ad) : base(hacim, image, ad)
        {

        }
    }


}
