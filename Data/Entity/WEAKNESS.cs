//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PokemonDataStore.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEAKNESS
    {
        public long CHARACTERID { get; set; }
        public long CLASSID { get; set; }
        public decimal RATIO { get; set; }
    
        public virtual CHARACTERS CHARACTERS { get; set; }
        public virtual CLASSES CLASSES { get; set; }
    }
}
