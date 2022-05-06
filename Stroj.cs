using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP09
{
    class Stroj
    {
        private string evidencniCislo;
        private DateTime posledniServis = new DateTime();
        public string EvidencniCislo
        {
            get
            {
                return evidencniCislo;
            }
            set
            {
                string s = value;
                int i = 0;
                string substr = s.Substring(i);
                while (i<=1)
                {
                    if (!char.IsLetter(s[i]))
                    {
                        
                        s = s.Replace(s[i], 'A');
                        
                    }
                    else ++i;
                }
                s += substr;
                evidencniCislo = s;
            }
        }
        public DateTime UvedenDoProvozu { get; }
        public Stroj(string evidencniCislo, DateTime uvedenDoProvozu)
        {
            EvidencniCislo = evidencniCislo;
            UvedenDoProvozu = uvedenDoProvozu;
        }
        public virtual void ProvedServis()
        {
            if (DateTime.Today > posledniServis.AddDays(42))
            {
                posledniServis = DateTime.Today;
            }
        }
        public override string ToString()
        {
            string s = "\nEvidenční číslo: " + EvidencniCislo +
                "\nUvedení do provozu: " + UvedenDoProvozu.ToShortDateString() +
                "\nDatum posledního servisu: " + posledniServis.ToShortDateString(); 
            return base.ToString()+s; 
        }
    }
}
