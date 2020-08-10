using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_4
{
    public class User
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public User(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
        
    }
}
