using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifreleme_odev.Models
{
    public class Sifre
    { 
       
        public Sifre()
        {
           
        }

        // Şifre= "portakal".
        // Harfler[0]='p'; p=22+2;
        // Harfler[1]='o'; o=54+2;
        //---------------------------
        // Şifrelenmiş = 11-99-412-42-3135-5335-22;

        private string SifreCoz(string s)
        {
            
            string a = null ,b=null;
            foreach (int item in s)
            {
                if (item!='-')
                {
                    b += Convert.ToChar(item);
                }
                else
                {
                    a += Convert.ToChar(((((Convert.ToInt32(b)-69)-31)/2)/5));
                    b = null;
                }
            }
            return a;
        }

        public string SifreKaristir(string s)
        {
            string a = null;
            foreach(char item in s)
            {               
                a +=  $"{Convert.ToInt32((((item *5)*2)+31)+69)}-";
            }
            return a;
        }
    }
}
