using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP09
{
    class Automat:Stroj
    {
        private int kolikratServisovan = 0;
        private bool preprogramovan;
        public Automat(string evidencniCislo, DateTime uvedeniDoProvozu, bool preprogramovan):base(evidencniCislo,uvedeniDoProvozu)
        {
            this.preprogramovan = preprogramovan;
        }
        public void Preprogramuj()
        {
            preprogramovan = true;
        }
        public override void ProvedServis()
        {
            if (preprogramovan)
            {
                System.Windows.Forms.MessageBox.Show("Nelze provést servis, byl přeprogramován");
            }
            else
            {
                base.ProvedServis();
                ++kolikratServisovan;
            }
        }
        public override string ToString()
        {
            string s = "\nAutomat nebyl přeprogramován" +
                    "\nTolikrát byl servisován: " + kolikratServisovan;
            if (preprogramovan)
            {
                 s = "\nAutomat byl přeprogramován" +
                    "\nTolikrát byl servisován: " + kolikratServisovan;
            }
            return base.ToString()+s;
        }
    }
}
