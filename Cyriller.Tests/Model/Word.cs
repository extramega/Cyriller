//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cyriller.Tests.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Word
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Word()
        {
            this.NounDictionaries = new HashSet<NounDictionary>();
            this.WordCases = new HashSet<WordCase>();
        }
    
        public int ID { get; set; }
        public int SpeechPartID { get; set; }
        public string Name { get; set; }
        public Nullable<int> GenderID { get; set; }
        public Nullable<int> AnimateID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public bool Error { get; set; }
    
        public virtual Animate Animate { get; set; }
        public virtual Gender Gender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NounDictionary> NounDictionaries { get; set; }
        public virtual SpeechPart SpeechPart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WordCase> WordCases { get; set; }
        public virtual WordType WordType { get; set; }
    }
}
