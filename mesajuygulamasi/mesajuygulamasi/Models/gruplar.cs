
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace MesajlasmaUygulamasi.Models
{

using System;
    using System.Collections.Generic;
    
public partial class gruplar
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public gruplar()
    {

        this.mesajlar = new HashSet<mesajlar>();

    }


    public int grupId { get; set; }

    public string grupAdi { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<mesajlar> mesajlar { get; set; }

}

}
