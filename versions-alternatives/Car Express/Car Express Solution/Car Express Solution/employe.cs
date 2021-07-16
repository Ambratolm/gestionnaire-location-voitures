//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Car_Express_Solution
{
    using System;
    using System.Collections.Generic;
    
    public partial class employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employe()
        {
            this.contrats = new HashSet<contrat>();
            this.reservations = new HashSet<reservation>();
            this.utilisateurs = new HashSet<utilisateur>();
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
        public System.DateTime C_row_insert_datetime { get; set; }
        public Nullable<System.DateTime> C_row_update_datetime { get; set; }
        public Nullable<System.DateTime> C_row_delete_datetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<utilisateur> utilisateurs { get; set; }
    }
}
