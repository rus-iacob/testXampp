//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testXampp
{
    using System;
    using System.Collections.Generic;
    
    public partial class piesa
    {
        public int id { get; set; }
        public string nume_Furnizor { get; set; }
        public string nume { get; set; }
        public Nullable<int> cantitate { get; set; }
        public int pret { get; set; }
        public int durata_asteptare_comanda { get; set; }
        public int listaOperatiuni_id { get; set; }
    
        public virtual listaoperatiuni listaoperatiuni { get; set; }
    }
}
