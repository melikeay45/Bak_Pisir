//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BakPisir.EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StepTBL
    {
        public int stepId { get; set; }
        public Nullable<int> recipeId { get; set; }
        public string stepDescription { get; set; }
        public string stepImageUrl { get; set; }
        public Nullable<bool> isDelete { get; set; }
        public string stepName { get; set; }
    
        public virtual RecipeTBL RecipeTBL { get; set; }
    }
}
