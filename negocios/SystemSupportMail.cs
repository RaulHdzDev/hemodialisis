using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talent.negocios
{
    class SystemSupportMail:MasterMailServer
    {
            public SystemSupportMail()
        {
            senderMail = "hemodialisisclinica@gmail.com";
            password = "clinicahemodialisis";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            inicializarSmtpCliente();
        }
    }
}
