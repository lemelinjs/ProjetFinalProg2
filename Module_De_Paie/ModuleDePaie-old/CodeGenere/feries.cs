//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModuleDePaie.CodeGenere
{
    using System;
    using System.Collections.Generic;
    
    public partial class feries
    {
        public feries()
        {
            this.paies_feries = new HashSet<paies_feries>();
        }
    
        public int id { get; set; }
        public string nom { get; set; }
    
        public virtual ICollection<paies_feries> paies_feries { get; set; }
    }
}
