//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test {
    using System;
    using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public partial class TVisitMedication {
        public int intVisitMedicationID { get; set; }
        public int intVisitID { get; set; }
        public int intMedicationID { get; set; }
        public System.DateTime dtmDatePrescribed { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public int intQuantity { get; set; }
        public string strMedicationNotes { get; set; }

        public virtual TMedication TMedication { get; set; }
        public virtual TVisit TVisit { get; set; }
        public string strMedicationName { get; internal set; }
    }
}
