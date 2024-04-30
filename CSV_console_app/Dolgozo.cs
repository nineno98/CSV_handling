using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_console_app
{
    //"nev","neme","reszleg","belepesev","ber"

    
    class Dolgozo
    {
        private string nev_;
        private string neme_;
        private string reszle_;
        private int belepesev_;
        private int ber_;

        public Dolgozo(string nev, string neme, string reszle, int belepesev, int ber)
        {
            this.nev_ = nev;
            this.neme_ = neme;
            this.reszle_ = reszle;
            this.belepesev_ = belepesev;
            this.ber_ = ber;
        }

        public string Nev { get => nev_; set => nev_ = value; }
        public string Neme { get => neme_; set => neme_ = value; }
        public string Reszle { get => reszle_; set => reszle_ = value; }
        public int Belepesev { get => belepesev_; set => belepesev_ = value; }
        public int Ber { get => ber_; set => ber_ = value; }

        public override string ToString()
        {
            return nev_+", "+neme_+", "+reszle_+", "+belepesev_+", "+ber_;
        }
    }
}
