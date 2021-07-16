//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RCD_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employe()
        {
            this.Contrats = new HashSet<Contrat>();
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int id_employe_pk { get; set; }
        public byte[] photo_employe { get; set; }
        public string nom_employe { get; set; }
        public string prenom_employe { get; set; }
        public string nationalite_employe { get; set; }
        public Nullable<System.DateTime> date_naissance_employe { get; set; }
        public string lieu_naissance_employe { get; set; }
        public string adresse_domicile_employe { get; set; }
        public string ville_domicile_employe { get; set; }
        public string code_postal_domicile_employe { get; set; }
        public string telephone_portable_employe { get; set; }
        public string telephone_fixe_employe { get; set; }
        public string fax_employe { get; set; }
        public string email_employe { get; set; }
        public Nullable<System.DateTime> date_embauche_employe { get; set; }
        public string fonction_employe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contrat> Contrats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
