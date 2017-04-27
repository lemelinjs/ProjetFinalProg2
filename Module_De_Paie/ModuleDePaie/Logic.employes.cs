using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleDePaie
{
    using System;
    using System.Collections.Generic;

    public partial class employes
    {
        public string NomComplet
        {
            get
            {
                return prenom + " " + nom;
            }
        }
    }
}
