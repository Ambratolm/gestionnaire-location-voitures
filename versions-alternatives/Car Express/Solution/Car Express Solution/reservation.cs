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
    
    public partial class reservation
    {
        public int id_reservation_pk { get; set; }
        public Nullable<int> id_client_fk { get; set; }
        public string immatriculation_vehicule_fk { get; set; }
        public Nullable<int> id_client_compagnon_fk { get; set; }
        public Nullable<int> id_employe_conducteur_fk { get; set; }
        public string description_equipements_speciaux_reservation { get; set; }
        public System.DateTime date_heure_depart_vehicule_reservation { get; set; }
        public Nullable<System.DateTime> date_heure_retour_vehicule_reservation { get; set; }
        public string lieu_depart_vehicule_reservation { get; set; }
        public string lieu_retour_vehicule_reservation { get; set; }
        public decimal frais_conducteur_reservation { get; set; }
        public decimal frais_equipements_speciaux_reservation { get; set; }
        public decimal montant_forfait_reservation { get; set; }
        public decimal montant_remise_reservation { get; set; }
        public string mode_paiement_reservation { get; set; }
        public System.DateTime C_row_insert_datetime { get; set; }
        public Nullable<System.DateTime> C_row_update_datetime { get; set; }
        public Nullable<System.DateTime> C_row_delete_datetime { get; set; }
    
        public virtual client client { get; set; }
        public virtual client client1 { get; set; }
        public virtual employe employe { get; set; }
        public virtual vehicule vehicule { get; set; }
    }
}