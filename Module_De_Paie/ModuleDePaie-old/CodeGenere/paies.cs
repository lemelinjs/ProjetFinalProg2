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
    
    public partial class paies
    {
        public paies()
        {
            this.jours_travailles = new HashSet<jours_travailles>();
            this.paies_feries = new HashSet<paies_feries>();
            this.paies_retenues = new HashSet<paies_retenues>();
            this.vacances = new HashSet<vacances>();
        }
    
        public int id { get; set; }
        public System.DateTime date_paie { get; set; }
        public decimal heures_surtemps { get; set; }
        public decimal heures_regulieres { get; set; }
        public int compagnie_employe_id { get; set; }
        public int employe_id { get; set; }
    
        public virtual ICollection<jours_travailles> jours_travailles { get; set; }
        public virtual ICollection<paies_feries> paies_feries { get; set; }
        public virtual ICollection<paies_retenues> paies_retenues { get; set; }
        public virtual ICollection<vacances> vacances { get; set; }
    }
}
