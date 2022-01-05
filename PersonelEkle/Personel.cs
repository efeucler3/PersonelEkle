using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelEkle
{
    class Personel
    {
        public string ad, soyad, birim,  maas;
        private string  sicilNo;

        public Personel()
        {
            birim = "yönetici";
        }


        public string SicilNo
        {
            get
            {
                return sicilNo;
            }
            set
            {
                if (value.Length == 8)
                {
                    sicilNo = value;
                }
                else
                {
                    sicilNo = "0";
                }
            }

        }
       


        public void yeniformac()
        {
            Form1 frm1 = new Form1();
            Form2 frm2 = new Form2();
            frm1.Hide();
            frm2.Show();

        }







    }
}
