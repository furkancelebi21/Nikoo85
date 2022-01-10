using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace furkii.Databases
{
    public class User
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string ProfilResmi { get; set; }
        public string SiteAciklama { get; set; }
        public string SiteIsim { get; set; }
        public string Logo { get; set; }
    }
}
