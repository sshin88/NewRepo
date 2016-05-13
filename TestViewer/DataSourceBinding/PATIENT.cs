namespace DataSourceBinding
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PATIENT")]
    public partial class PATIENT
    {
        [Key]
        public int PatientKey { get; set; }

        public int? DeleteStatus { get; set; }

        [StringLength(64)]
        public string PatientId { get; set; }

        [StringLength(64)]
        public string PatientName { get; set; }

        [StringLength(8)]
        public string PatientBirthDate { get; set; }

        [StringLength(16)]
        public string PatientBirthTime { get; set; }

        [StringLength(16)]
        public string PatientSex { get; set; }

        public int? OtherPatientIDsCount { get; set; }

        [StringLength(64)]
        public string OtherPatientIDs0 { get; set; }

        [StringLength(64)]
        public string OtherPatientIDs1 { get; set; }

        [StringLength(64)]
        public string OtherPatientIDs2 { get; set; }

        [StringLength(64)]
        public string OtherPatientIDs3 { get; set; }

        [StringLength(64)]
        public string OtherPatientIDs4 { get; set; }

        public int? OtherPatientNamesCount { get; set; }

        [StringLength(64)]
        public string OtherPatientNames0 { get; set; }

        [StringLength(64)]
        public string OtherPatientNames1 { get; set; }

        [StringLength(64)]
        public string OtherPatientNames2 { get; set; }

        [StringLength(64)]
        public string OtherPatientNames3 { get; set; }

        [StringLength(64)]
        public string OtherPatientNames4 { get; set; }

        [StringLength(16)]
        public string EthnicGroup { get; set; }

        [StringLength(64)]
        public string PatientAddress { get; set; }

        [StringLength(16)]
        public string PatientTelephoneNumbers { get; set; }

        [StringLength(4000)]
        public string PatientComment { get; set; }

        [StringLength(64)]
        public string PatientSpeciesDescription { get; set; }

        public int? SpeciesCodeSequenceKey { get; set; }

        [StringLength(64)]
        public string PATIENT_BREED_DESCRIPTION { get; set; }

        public int? BreedCodeSequenceKey { get; set; }

        [StringLength(64)]
        public string BREED_REGISTRATION_NUMBER { get; set; }

        public int? BreedRegistryCodeSequenceKey { get; set; }

        [StringLength(64)]
        public string RESPONSIBLE_PERSON { get; set; }

        [StringLength(16)]
        public string RESPONSIBLE_PERSON_ROLE { get; set; }

        [StringLength(64)]
        public string RESPONSIBLE_ORGANIZATION { get; set; }

        [StringLength(16)]
        public string PATIENT_SEX_NEUTERED { get; set; }

        public int? Exposured { get; set; }

        public int? LocationKey { get; set; }

        public int? OrderNum { get; set; }
    }
}
