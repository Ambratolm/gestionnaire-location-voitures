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
    
    public partial class vehicule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehicule()
        {
            this.contrats = new HashSet<contrat>();
            this.reservations = new HashSet<reservation>();
        }
    
        public string immatriculation_vehicule_pk { get; set; }
        public byte[] photo_vehicule { get; set; }
        public string type_vehicule { get; set; }
        public string marque_vehicule { get; set; }
        public string description_vehicule { get; set; }
        public double distance_parcourue_vehicule { get; set; }
        public string type_energie_vehicule { get; set; }
        public double quantite_energie_vehicule { get; set; }
        public decimal prix_location_vehicule { get; set; }
        public Nullable<System.DateTime> date_achat_vehicule { get; set; }
        public Nullable<System.DateTime> date_derniere_maintenance_vehicule { get; set; }
        public System.DateTime C_row_insert_datetime { get; set; }
        public Nullable<System.DateTime> C_row_update_datetime { get; set; }
        public Nullable<System.DateTime> C_row_delete_datetime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<contrat> contrats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservations { get; set; }
    }
}
