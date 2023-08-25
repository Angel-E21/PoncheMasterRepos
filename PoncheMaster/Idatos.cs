using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoncheMaster
{
    public interface Idatos
    {
        
        bool Autentification(string username, string password);

        bool IsAdmin(string username, int Type = 2);

        bool Ponche(string cedula);

        bool AuthCedula(string cedula);


    }
}
