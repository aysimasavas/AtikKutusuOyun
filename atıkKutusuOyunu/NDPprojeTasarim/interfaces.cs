using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPprojeTasarim
{
    public interface IAtik
    {

        int Hacim { get; }

        System.Drawing.Image Image { get; }
        
    }

    public interface IAtikKutusu : IDolabilen
    {
        int BosaltmaPuani { get; }

        bool Ekle(Atik atik);

        bool Bosalt();
    }

    public interface IDolabilen
    {
        int Kapasite { get; set; }
        int DoluHacim { get; }
        int DolulukOrani { get; }

    }
}
