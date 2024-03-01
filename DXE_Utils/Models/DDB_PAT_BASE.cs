namespace DXE_Utils.Models
{
    public class DDB_PAT_BASE
    {
        public int PATID { get; set; }
        public int PATDB { get; set; }
        public int? FAMILYID { get; set; }
        public int? GUARID { get; set; }
        public int? GUARDB { get; set; }
        public int? PRINSUREDID { get; set; }
        public int? PRINSUREDDB { get; set; }
        public int? SCINSUREDID { get; set; }
        public int? SCINSUREDDB { get; set; }
        public int? ADDRESSID { get; set; }
        public int? ADDRESSDB { get; set; }
        public int? EMPID { get; set; }
        public int? EMPDB { get; set; }
        public int? CLAIMINFID { get; set; }
        public int? CLAIMINFDB { get; set; }
        public int? PRPROVID { get; set; }
        public int? PRPROVDB { get; set; }
        public int? SCPROVID { get; set; }
        public int? SCPROVDB { get; set; }
        public int? REFTOID { get; set; }
        public int? REFTODB { get; set; }
        public int? REFBYDOCID { get; set; }
        public int? REFBYDOCDB { get; set; }
        public int? REFBYPATID { get; set; }
        public int? REFBYPATDB { get; set; }
        public int? PRMEDINSID { get; set; }
        public int? PRMEDINSDB { get; set; }
        public int? SCMEDINSID { get; set; }
        public int? SCMEDINSDB { get; set; }
        public string? LASTNAME { get; set; }
        public string? FIRSTNAME { get; set; }
        public string? MI { get; set; }
        public string? PREFNAME { get; set; }
        public string? SALUTATION { get; set; }
        public string? WKEXT { get; set; }
        public string? BESTTIME { get; set; }
        public string? CHART { get; set; }
        public int? CHARTDB { get; set; }
        public string? SS { get; set; }
        public int? SSNDB { get; set; }
        public short GUARFLG { get; set; }
        public short INSPFLG { get; set; }
        public short HEADHFLG { get; set; }
        public short GENDER { get; set; }
        public short STATUS { get; set; }
        public short FAMPOS { get; set; }
        public short PREMED { get; set; }
        public DateTime? BIRTHDATE { get; set; }
        public DateTime? FIRSTVISITDATE { get; set; }
        public DateTime? LASTVISITDATE { get; set; }
        public DateTime? REFTODATE { get; set; }
        public DateTime? CONSENTDATE { get; set; }
        public short PRINSREL { get; set; }
        public short SCINSREL { get; set; }
        public int? PRBENEFITS { get; set; }
        public int? SCBENEFITS { get; set; }
        public string? WKPHONE { get; set; }
        public int? FEESCHFLAG { get; set; }
        public int? MISSEDAPPT { get; set; }
        public DateTime? LASTMISSEDAPPT { get; set; }
        public string? TITLE { get; set; }
        public string? ID2 { get; set; }
        public short TITLEFLG { get; set; }
        public int? EZDWPATID { get; set; }
        public string? EMAILADDRESS { get; set; }
        public string? DRIVERSLICENSE { get; set; }
        public string? FAX { get; set; }
        public string? PAGER { get; set; }
        public string? OTHERPHONE { get; set; }
        public int? PRDED { get; set; }
        public int? PRDED2 { get; set; }
        public int? PRDED3 { get; set; }
        public int? SCDED { get; set; }
        public int? SCDED2 { get; set; }
        public int? SCDED3 { get; set; }
        public int? PRDEDUCTLT { get; set; }
        public int? PRDEDUCTLT2 { get; set; }
        public int? PRDEDUCTLT3 { get; set; }
        public int? SCDEDUCTLT { get; set; }
        public int? SCDEDUCTLT2 { get; set; }
        public int? SCDEDUCTLT3 { get; set; }
        public string? MEDALERT { get; set; }
        public int? FEESCHEDID { get; set; }
        public int? FEESCHEDDB { get; set; }
        public short PRMEDINSREL { get; set; }
        public short SCMEDINSREL { get; set; }
        public short PrInsCDADepCode { get; set; }
        public short ScInsCDADepCode { get; set; }
        public short ConsultFlag { get; set; }
        public short TOAFlag { get; set; }
        public int? DefaultClinic { get; set; }
        public int? OperatorID { get; set; }
        public int? OperatorDB { get; set; }
        public string? UPLASTNAME { get; set; }
        public string? UPFIRSTNAME { get; set; }
        public string? UPCHART { get; set; }
        public short ACTIVE { get; set; }
        public short PATALERT { get; set; }
        public string? Suffix { get; set; }
        public string? CountyName { get; set; }
        public string? EmpStatus { get; set; }
        public short Race { get; set; }
        public int? FamIncome { get; set; }
        public string? ExternalStatus { get; set; }
        public string? PatExtID { get; set; }
        public string? GuarantorExtID { get; set; }
        public string? EntrySystem { get; set; }
        public DateTime? EntryDateTime { get; set; }
        public string? LastUpdateMethod { get; set; }
        public string? LastUpdateSystem { get; set; }
        public string? VisitNumber { get; set; }
        public int? PATIMAGEID { get; set; }
        public int? INITPROVID { get; set; }
        public int? INITPROVDB { get; set; }
        public short RELIGION { get; set; }
        public int? RVUID { get; set; }
        public int? RVUDB { get; set; }
        public DateTime? MedHistoryViewDate { get; set; }
        public DateTime? DDB_LAST_MOD { get; set; }
        public string? PatClass { get; set; }
        public string? PatFacility { get; set; }
        public string? PatAlias_LastName { get; set; }
        public string? PatAlias_FirstName { get; set; }
        public string? PatAlias_MiddleName { get; set; }
        public string? PatAlias_Suffix { get; set; }
        public string? PatAlias_Prefix { get; set; }
        public string? MotherMaiden_LName { get; set; }
        public string? MotherMaiden_FName { get; set; }
        public string? MotherMaiden_MName { get; set; }
        public string? MotherMaiden_Suffix { get; set; }
        public string? MotherMaiden_Prefix { get; set; }
        public DateTime? PatientDeathDate { get; set; }
        public short Language { get; set; }
        public short PovertyLevel { get; set; }
        public short WorkerStatus { get; set; }
        public short HomelessStatus { get; set; }
        public short PrivacyFlags { get; set; }
        public short PATCOPIED { get; set; }
        public string? tempchart { get; set; }
        public short Veteran { get; set; }
        public string? GUIDID { get; set; }
        public int? TertDentInsuredID { get; set; }
        public int? TertDentInsuredDB { get; set; }
        public int? QuatDentInsuredID { get; set; }
        public int? QuatDentInsuredDB { get; set; }
        public short TertInsRel { get; set; }
        public short QuatInsRel { get; set; }
        public short TertInsCDADepCode { get; set; }
        public short QuatInsCDADepCode { get; set; }
        public string? OVERRIDEUSERID { get; set; }
        public string? PermDescript { get; set; }
        public int? EthnicityID { get; set; }
        public int? UDPatCatID { get; set; }
        public string? ExtPatIDType { get; set; }
        public string? ExtGuarIDType { get; set; }
        public string? PatExtID2 { get; set; }
        public string? ExtPatID2Type { get; set; }
        public string? PatType { get; set; }
        public string? AccountStatus { get; set; }
        public short FinancialClassID { get; set; }
        public string? PatAccountNumber { get; set; }
        public int? DeclinedEmail { get; set; }
        public short CommunicationPref { get; set; }
        public int? SmokingStatusID { get; set; }
        public int? SmokingStatusDB { get; set; }
        public short RxAutoRefill { get; set; }
        public short OtherRace { get; set; }
        public short HousingStatus { get; set; }
        public int? FamSize { get; set; }
        public int? SexualOrientation { get; set; }
        public int? GenderIdentity { get; set; }
        public int? HohIncome { get; set; }
        public int? IncomeRecurr { get; set; }
        public int PracticeIdInt { get; set; }
        public DateTime? LastUpdateTimestamp { get; set; }
        public bool? IsDeletedFromSource { get; set; }
        public DateTime? MinProcDate_di { get; set; }
        public DateTime? MaxProcDate_di { get; set; }
        public DateTime? LastPerioProc_di { get; set; }
        public DateTime? LastHygieneProc_di { get; set; }
        public decimal? PatientValue_0to6 { get; set; }
        public decimal? PatientValue_7to12 { get; set; }
        public decimal? PatientValue_13to18 { get; set; }
        public decimal? PatientValue_19to24 { get; set; }
        public decimal? PatientValue_25to30 { get; set; }
        public decimal? PatientValue_31to36 { get; set; }
        public decimal? UnScheduledTX { get; set; }
        public decimal? TotalTX { get; set; }
        public DateTime? NextHygieneAppt { get; set; }
        public DateTime? NextNonHygieneAppt { get; set; }
        public DateTime? StatusModifiedDate { get; set; }
        public int? HygieneInterval_di { get; set; }
        public string? PrimaryInsurance_DI { get; set; }
        public string? SecondaryInsurance_DI { get; set; }
        public decimal? RemainingInsurance_DI { get; set; }
        public DateTime? FirstPerioProc_DI { get; set; }
        public DateTime? NextRestorativeAppointment_DI { get; set; }
        public DateTime? NextMiscAppointment_DI { get; set; }
        public decimal? RemainingPrimaryInsurance_DI { get; set; }
        public decimal? RemainingSecondaryInsurance_DI { get; set; }
        public decimal? Aging0To30_di { get; set; }
        public decimal? Aging31To60_di { get; set; }
        public decimal? Aging61To90_di { get; set; }
        public decimal? AgingPlus90_di { get; set; }
        public decimal? TotalAging_di { get; set; }
        public decimal? EstInsuranceAging_di { get; set; }
        public decimal? EstPatientAging_di { get; set; }
        public string? PrimaryProvider_DI { get; set; }
        public string? SecondaryProvider_DI { get; set; }
        public string? ReferralSource_DI { get; set; }
        public bool? NextHygieneApptIsOnQuickFill_DI { get; set; }
        public bool? NextNonHygieneApptIsOnQuickFill_DI { get; set; }
        public bool? NextRestorativeApptIsOnQuickFill_DI { get; set; }
        public bool? NextMiscApptIsOnQuickFill_DI { get; set; }
        public int? FamilyMembersNotScheduled_DI { get; set; }
        public decimal? HygieneUnScheduledTX_DI { get; set; }
        public decimal? RestorativeUnScheduledTX_DI { get; set; }
        public decimal? AppointmentCandidateWeightingRestorative_DI { get; set; }
        public decimal? AppointmentCandidateWeightingHygiene_DI { get; set; }
        public DateTime? NextHygieneApptEndTime_DI { get; set; }
        public DateTime? NextNonHygieneApptEndTime_DI { get; set; }
        public DateTime? NextRestorativeAppointmentEndTime_DI { get; set; }
        public DateTime? NextMiscAppointmentEndTime_DI { get; set; }
        public bool? PatientIsOnUnscheduledQuickFill { get; set; }
        public bool? FupHygieneRecareChanged_di { get; set; }
        public bool? FupARChanged_di { get; set; }
        public DateTime? LastMajorFilmProc_di { get; set; }
        public DateTime? LastBiteWingProc_di { get; set; }
        public DateTime? LastPanoProc_di { get; set; }
        public DateTime? LastFmxProc_di { get; set; }
        public decimal? UnScheduledTx0To30_DI { get; set; }
        public decimal? UnScheduledTx31To60_DI { get; set; }
        public decimal? UnScheduledTx61To90_DI { get; set; }
        public decimal? UnScheduledTxPlus90_DI { get; set; }
        public decimal? RestorativeUnScheduledTx0To30_DI { get; set; }
        public decimal? RestorativeUnScheduledTx31To60_DI { get; set; }
        public decimal? RestorativeUnScheduledTx61To90_DI { get; set; }
        public decimal? RestorativeUnScheduledTxPlus90_DI { get; set; }
        public decimal? HygieneUnScheduledTx0To30_DI { get; set; }
        public decimal? HygieneUnScheduledTx31To60_DI { get; set; }
        public decimal? HygieneUnScheduledTx61To90_DI { get; set; }
        public decimal? HygieneUnScheduledTxPlus90_DI { get; set; }
        public decimal? TreatmentLifetimeValue_di { get; set; }
        public int? BrokenAppointmentCount_DI { get; set; }
        public int? CompletedAppointmentCount_DI { get; set; }
        public int? NumberPatientsReferred_DI { get; set; }
        public DateTime? AppointmentCandidateSnoozeTime_DI { get; set; }
        public int? AppointmentCandidateSnoozeHours_DI { get; set; }
        public DateTime? AppointmentCandidateContactedTime_DI { get; set; }
        public int? AppointmentCandidateContactedHours_DI { get; set; }
        public int? AppointmentPreferredDayOfWeek { get; set; }
        public int? AppointmentPreferredHourOfDay { get; set; }
        public decimal? Treatment18MonthValue_DI { get; set; }
        public int? PATEXTIDTYPEID { get; set; }
        public int? PATEXTIDTYPEDB { get; set; }
        public bool? CONFIDENTIAL_STATE { get; set; }
        public string? MiddleName { get; set; }
        public int? ConfidentialCodeID { get; set; }
        public int? ConfidentialCodeDB { get; set; }
        public bool? OrganDonorCode { get; set; }
        public bool? VipCode { get; set; }
        public bool? SensitivityFlag { get; set; }
        public int? BirthPlaceCountryID { get; set; }
        public int? BirthPlaceCountryDB { get; set; }
        public bool? MultipleBirthFlag { get; set; }
        public short MultipleBirthOrder { get; set; }
        public bool? DNACode { get; set; }
        public string? BloodTypeVerCode { get; set; }
        public string? HOMEPHONE { get; set; }
        public string? HOMEPHONEEXT { get; set; }
        public string? WORKEMAIL { get; set; }
        public int? OtherEthnicityId { get; set; }
        public int? NextOfKinID { get; set; }
        public int? NextOfKinDB { get; set; }
        public int? EmergencyID { get; set; }
        public int? EmergencyDB { get; set; }
        public int? GuardianID { get; set; }
        public int? GuardianDB { get; set; }
        public int? SponsorID { get; set; }
        public int? SponsorDB { get; set; }
        public int? CreationReasonID { get; set; }
        public bool? DoDUpdateAuth { get; set; }
        public string? DoDUpdateAuthText { get; set; }
        public short PrInsSubRel { get; set; }
        public short ScInsSubRel { get; set; }
        public short TertInsSubRel { get; set; }
        public short QuatInsSubRel { get; set; }
        public short PrMedInsSubRel { get; set; }
        public short ScMedInsSubRel { get; set; }
        public int? InmateID { get; set; }
        public int? InmateDB { get; set; }
        public string? FamExtID { get; set; }
        public int? OriginalPatId { get; set; }
        public int? OriginalPatDb { get; set; }
        public decimal? Hygiene18MonthPerVisitAverage_di { get; set; }
        public bool? OnPaymentPlan_di { get; set; }
        public DateTime? PaymentCampaignDoNotSendDate_DI { get; set; }
        public DateTime? PaymentCampaignSnoozeUntil_DI { get; set; }
        public string? PaymentCampaignSnoozeReason_DI { get; set; }
        public DateTime? LastPatientPaymentDate_DI { get; set; }
        public DateTime? LastInsurancePaymentDate_DI { get; set; }
        public DateTime? PrimaryInsuranceLastDateClaimSent_DI { get; set; }
        public DateTime? SecondaryInsuranceLastDateClaimSent_DI { get; set; }
        public int? PrimaryInsuranceNumOpenClaims_DI { get; set; }
        public int? SecondaryInsuranceNumOpenClaims_DI { get; set; }
        public string? PrimaryProviderId_di { get; set; }
        public string? SecondaryProviderId_di { get; set; }


        public DDB_PAT_BASE() { }
                
        public DDB_PAT_BASE(int PATID_, int PATDB_, int? FAMILYID_, int? GUARID_, int? GUARDB_, int? PRINSUREDID_, int? PRINSUREDDB_, int? SCINSUREDID_, int? SCINSUREDDB_, int? ADDRESSID_, int? ADDRESSDB_, int? EMPID_, int? EMPDB_, int? CLAIMINFID_, int? CLAIMINFDB_, int? PRPROVID_, int? PRPROVDB_, int? SCPROVID_, int? SCPROVDB_, int? REFTOID_, int? REFTODB_, int? REFBYDOCID_, int? REFBYDOCDB_, int? REFBYPATID_, int? REFBYPATDB_, int? PRMEDINSID_, int? PRMEDINSDB_, int? SCMEDINSID_, int? SCMEDINSDB_, string? LASTNAME_, string? FIRSTNAME_, string? MI_, string? PREFNAME_, string? SALUTATION_, string? WKEXT_, string? BESTTIME_, string? CHART_, int? CHARTDB_, string? SS_, int? SSNDB_, short GUARFLG_, short INSPFLG_, short HEADHFLG_, short GENDER_, short STATUS_, short FAMPOS_, short PREMED_, DateTime? BIRTHDATE_, DateTime? FIRSTVISITDATE_, DateTime? LASTVISITDATE_, DateTime? REFTODATE_, DateTime? CONSENTDATE_, short PRINSREL_, short SCINSREL_, int? PRBENEFITS_, int? SCBENEFITS_, string? WKPHONE_, int? FEESCHFLAG_, int? MISSEDAPPT_, DateTime? LASTMISSEDAPPT_, string? TITLE_, string? ID2_, short TITLEFLG_, int? EZDWPATID_, string? EMAILADDRESS_, string? DRIVERSLICENSE_, string? FAX_, string? PAGER_, string? OTHERPHONE_, int? PRDED_, int? PRDED2_, int? PRDED3_, int? SCDED_, int? SCDED2_, int? SCDED3_, int? PRDEDUCTLT_, int? PRDEDUCTLT2_, int? PRDEDUCTLT3_, int? SCDEDUCTLT_, int? SCDEDUCTLT2_, int? SCDEDUCTLT3_, string? MEDALERT_, int? FEESCHEDID_, int? FEESCHEDDB_, short PRMEDINSREL_, short SCMEDINSREL_, short PrInsCDADepCode_, short ScInsCDADepCode_, short ConsultFlag_, short TOAFlag_, int? DefaultClinic_, int? OperatorID_, int? OperatorDB_, string? UPLASTNAME_, string? UPFIRSTNAME_, string? UPCHART_, short ACTIVE_, short PATALERT_, string? Suffix_, string? CountyName_, string? EmpStatus_, short Race_, int? FamIncome_, string? ExternalStatus_, string? PatExtID_, string? GuarantorExtID_, string? EntrySystem_, DateTime? EntryDateTime_, string? LastUpdateMethod_, string? LastUpdateSystem_, string? VisitNumber_, int? PATIMAGEID_, int? INITPROVID_, int? INITPROVDB_, short RELIGION_, int? RVUID_, int? RVUDB_, DateTime? MedHistoryViewDate_, DateTime? DDB_LAST_MOD_, string? PatClass_, string? PatFacility_, string? PatAlias_LastName_, string? PatAlias_FirstName_, string? PatAlias_MiddleName_, string? PatAlias_Suffix_, string? PatAlias_Prefix_, string? MotherMaiden_LName_, string? MotherMaiden_FName_, string? MotherMaiden_MName_, string? MotherMaiden_Suffix_, string? MotherMaiden_Prefix_, DateTime? PatientDeathDate_, short Language_, short PovertyLevel_, short WorkerStatus_, short HomelessStatus_, short PrivacyFlags_, short PATCOPIED_, string? tempchart_, short Veteran_, string? GUIDID_, int? TertDentInsuredID_, int? TertDentInsuredDB_, int? QuatDentInsuredID_, int? QuatDentInsuredDB_, short TertInsRel_, short QuatInsRel_, short TertInsCDADepCode_, short QuatInsCDADepCode_, string? OVERRIDEUSERID_, string? PermDescript_, int? EthnicityID_, int? UDPatCatID_, string? ExtPatIDType_, string? ExtGuarIDType_, string? PatExtID2_, string? ExtPatID2Type_, string? PatType_, string? AccountStatus_, short FinancialClassID_, string? PatAccountNumber_, int? DeclinedEmail_, short CommunicationPref_, int? SmokingStatusID_, int? SmokingStatusDB_, short RxAutoRefill_, short OtherRace_, short HousingStatus_, int? FamSize_, int? SexualOrientation_, int? GenderIdentity_, int? HohIncome_, int? IncomeRecurr_, int PracticeIdInt_, DateTime? LastUpdateTimestamp_, bool? IsDeletedFromSource_, DateTime? MinProcDate_di_, DateTime? MaxProcDate_di_, DateTime? LastPerioProc_di_, DateTime? LastHygieneProc_di_, decimal? PatientValue_0to6_, decimal? PatientValue_7to12_, decimal? PatientValue_13to18_, decimal? PatientValue_19to24_, decimal? PatientValue_25to30_, decimal? PatientValue_31to36_, decimal? UnScheduledTX_, decimal? TotalTX_, DateTime? NextHygieneAppt_, DateTime? NextNonHygieneAppt_, DateTime? StatusModifiedDate_, int? HygieneInterval_di_, string? PrimaryInsurance_DI_, string? SecondaryInsurance_DI_, decimal? RemainingInsurance_DI_, DateTime? FirstPerioProc_DI_, DateTime? NextRestorativeAppointment_DI_, DateTime? NextMiscAppointment_DI_, decimal? RemainingPrimaryInsurance_DI_, decimal? RemainingSecondaryInsurance_DI_, decimal? Aging0To30_di_, decimal? Aging31To60_di_, decimal? Aging61To90_di_, decimal? AgingPlus90_di_, decimal? TotalAging_di_, decimal? EstInsuranceAging_di_, decimal? EstPatientAging_di_, string? PrimaryProvider_DI_, string? SecondaryProvider_DI_, string? ReferralSource_DI_, bool? NextHygieneApptIsOnQuickFill_DI_, bool? NextNonHygieneApptIsOnQuickFill_DI_, bool? NextRestorativeApptIsOnQuickFill_DI_, bool? NextMiscApptIsOnQuickFill_DI_, int? FamilyMembersNotScheduled_DI_, decimal? HygieneUnScheduledTX_DI_, decimal? RestorativeUnScheduledTX_DI_, decimal? AppointmentCandidateWeightingRestorative_DI_, decimal? AppointmentCandidateWeightingHygiene_DI_, DateTime? NextHygieneApptEndTime_DI_, DateTime? NextNonHygieneApptEndTime_DI_, DateTime? NextRestorativeAppointmentEndTime_DI_, DateTime? NextMiscAppointmentEndTime_DI_, bool? PatientIsOnUnscheduledQuickFill_, bool? FupHygieneRecareChanged_di_, bool? FupARChanged_di_, DateTime? LastMajorFilmProc_di_, DateTime? LastBiteWingProc_di_, DateTime? LastPanoProc_di_, DateTime? LastFmxProc_di_, decimal? UnScheduledTx0To30_DI_, decimal? UnScheduledTx31To60_DI_, decimal? UnScheduledTx61To90_DI_, decimal? UnScheduledTxPlus90_DI_, decimal? RestorativeUnScheduledTx0To30_DI_, decimal? RestorativeUnScheduledTx31To60_DI_, decimal? RestorativeUnScheduledTx61To90_DI_, decimal? RestorativeUnScheduledTxPlus90_DI_, decimal? HygieneUnScheduledTx0To30_DI_, decimal? HygieneUnScheduledTx31To60_DI_, decimal? HygieneUnScheduledTx61To90_DI_, decimal? HygieneUnScheduledTxPlus90_DI_, decimal? TreatmentLifetimeValue_di_, int? BrokenAppointmentCount_DI_, int? CompletedAppointmentCount_DI_, int? NumberPatientsReferred_DI_, DateTime? AppointmentCandidateSnoozeTime_DI_, int? AppointmentCandidateSnoozeHours_DI_, DateTime? AppointmentCandidateContactedTime_DI_, int? AppointmentCandidateContactedHours_DI_, int? AppointmentPreferredDayOfWeek_, int? AppointmentPreferredHourOfDay_, decimal? Treatment18MonthValue_DI_, int? PATEXTIDTYPEID_, int? PATEXTIDTYPEDB_, bool? CONFIDENTIAL_STATE_, string? MiddleName_, int? ConfidentialCodeID_, int? ConfidentialCodeDB_, bool? OrganDonorCode_, bool? VipCode_, bool? SensitivityFlag_, int? BirthPlaceCountryID_, int? BirthPlaceCountryDB_, bool? MultipleBirthFlag_, short MultipleBirthOrder_, bool? DNACode_, string? BloodTypeVerCode_, string? HOMEPHONE_, string? HOMEPHONEEXT_, string? WORKEMAIL_, int? OtherEthnicityId_, int? NextOfKinID_, int? NextOfKinDB_, int? EmergencyID_, int? EmergencyDB_, int? GuardianID_, int? GuardianDB_, int? SponsorID_, int? SponsorDB_, int? CreationReasonID_, bool? DoDUpdateAuth_, string? DoDUpdateAuthText_, short PrInsSubRel_, short ScInsSubRel_, short TertInsSubRel_, short QuatInsSubRel_, short PrMedInsSubRel_, short ScMedInsSubRel_, int? InmateID_, int? InmateDB_, string? FamExtID_, int? OriginalPatId_, int? OriginalPatDb_, decimal? Hygiene18MonthPerVisitAverage_di_, bool? OnPaymentPlan_di_, DateTime? PaymentCampaignDoNotSendDate_DI_, DateTime? PaymentCampaignSnoozeUntil_DI_, string? PaymentCampaignSnoozeReason_DI_, DateTime? LastPatientPaymentDate_DI_, DateTime? LastInsurancePaymentDate_DI_, DateTime? PrimaryInsuranceLastDateClaimSent_DI_, DateTime? SecondaryInsuranceLastDateClaimSent_DI_, int? PrimaryInsuranceNumOpenClaims_DI_, int? SecondaryInsuranceNumOpenClaims_DI_, string? PrimaryProviderId_di_, string? SecondaryProviderId_di_)
        {
            this.PATID = PATID_;
            this.PATDB = PATDB_;
            this.FAMILYID = FAMILYID_;
            this.GUARID = GUARID_;
            this.GUARDB = GUARDB_;
            this.PRINSUREDID = PRINSUREDID_;
            this.PRINSUREDDB = PRINSUREDDB_;
            this.SCINSUREDID = SCINSUREDID_;
            this.SCINSUREDDB = SCINSUREDDB_;
            this.ADDRESSID = ADDRESSID_;
            this.ADDRESSDB = ADDRESSDB_;
            this.EMPID = EMPID_;
            this.EMPDB = EMPDB_;
            this.CLAIMINFID = CLAIMINFID_;
            this.CLAIMINFDB = CLAIMINFDB_;
            this.PRPROVID = PRPROVID_;
            this.PRPROVDB = PRPROVDB_;
            this.SCPROVID = SCPROVID_;
            this.SCPROVDB = SCPROVDB_;
            this.REFTOID = REFTOID_;
            this.REFTODB = REFTODB_;
            this.REFBYDOCID = REFBYDOCID_;
            this.REFBYDOCDB = REFBYDOCDB_;
            this.REFBYPATID = REFBYPATID_;
            this.REFBYPATDB = REFBYPATDB_;
            this.PRMEDINSID = PRMEDINSID_;
            this.PRMEDINSDB = PRMEDINSDB_;
            this.SCMEDINSID = SCMEDINSID_;
            this.SCMEDINSDB = SCMEDINSDB_;
            this.LASTNAME = LASTNAME_;
            this.FIRSTNAME = FIRSTNAME_;
            this.MI = MI_;
            this.PREFNAME = PREFNAME_;
            this.SALUTATION = SALUTATION_;
            this.WKEXT = WKEXT_;
            this.BESTTIME = BESTTIME_;
            this.CHART = CHART_;
            this.CHARTDB = CHARTDB_;
            this.SS = SS_;
            this.SSNDB = SSNDB_;
            this.GUARFLG = GUARFLG_;
            this.INSPFLG = INSPFLG_;
            this.HEADHFLG = HEADHFLG_;
            this.GENDER = GENDER_;
            this.STATUS = STATUS_;
            this.FAMPOS = FAMPOS_;
            this.PREMED = PREMED_;
            this.BIRTHDATE = BIRTHDATE_;
            this.FIRSTVISITDATE = FIRSTVISITDATE_;
            this.LASTVISITDATE = LASTVISITDATE_;
            this.REFTODATE = REFTODATE_;
            this.CONSENTDATE = CONSENTDATE_;
            this.PRINSREL = PRINSREL_;
            this.SCINSREL = SCINSREL_;
            this.PRBENEFITS = PRBENEFITS_;
            this.SCBENEFITS = SCBENEFITS_;
            this.WKPHONE = WKPHONE_;
            this.FEESCHFLAG = FEESCHFLAG_;
            this.MISSEDAPPT = MISSEDAPPT_;
            this.LASTMISSEDAPPT = LASTMISSEDAPPT_;
            this.TITLE = TITLE_;
            this.ID2 = ID2_;
            this.TITLEFLG = TITLEFLG_;
            this.EZDWPATID = EZDWPATID_;
            this.EMAILADDRESS = EMAILADDRESS_;
            this.DRIVERSLICENSE = DRIVERSLICENSE_;
            this.FAX = FAX_;
            this.PAGER = PAGER_;
            this.OTHERPHONE = OTHERPHONE_;
            this.PRDED = PRDED_;
            this.PRDED2 = PRDED2_;
            this.PRDED3 = PRDED3_;
            this.SCDED = SCDED_;
            this.SCDED2 = SCDED2_;
            this.SCDED3 = SCDED3_;
            this.PRDEDUCTLT = PRDEDUCTLT_;
            this.PRDEDUCTLT2 = PRDEDUCTLT2_;
            this.PRDEDUCTLT3 = PRDEDUCTLT3_;
            this.SCDEDUCTLT = SCDEDUCTLT_;
            this.SCDEDUCTLT2 = SCDEDUCTLT2_;
            this.SCDEDUCTLT3 = SCDEDUCTLT3_;
            this.MEDALERT = MEDALERT_;
            this.FEESCHEDID = FEESCHEDID_;
            this.FEESCHEDDB = FEESCHEDDB_;
            this.PRMEDINSREL = PRMEDINSREL_;
            this.SCMEDINSREL = SCMEDINSREL_;
            this.PrInsCDADepCode = PrInsCDADepCode_;
            this.ScInsCDADepCode = ScInsCDADepCode_;
            this.ConsultFlag = ConsultFlag_;
            this.TOAFlag = TOAFlag_;
            this.DefaultClinic = DefaultClinic_;
            this.OperatorID = OperatorID_;
            this.OperatorDB = OperatorDB_;
            this.UPLASTNAME = UPLASTNAME_;
            this.UPFIRSTNAME = UPFIRSTNAME_;
            this.UPCHART = UPCHART_;
            this.ACTIVE = ACTIVE_;
            this.PATALERT = PATALERT_;
            this.Suffix = Suffix_;
            this.CountyName = CountyName_;
            this.EmpStatus = EmpStatus_;
            this.Race = Race_;
            this.FamIncome = FamIncome_;
            this.ExternalStatus = ExternalStatus_;
            this.PatExtID = PatExtID_;
            this.GuarantorExtID = GuarantorExtID_;
            this.EntrySystem = EntrySystem_;
            this.EntryDateTime = EntryDateTime_;
            this.LastUpdateMethod = LastUpdateMethod_;
            this.LastUpdateSystem = LastUpdateSystem_;
            this.VisitNumber = VisitNumber_;
            this.PATIMAGEID = PATIMAGEID_;
            this.INITPROVID = INITPROVID_;
            this.INITPROVDB = INITPROVDB_;
            this.RELIGION = RELIGION_;
            this.RVUID = RVUID_;
            this.RVUDB = RVUDB_;
            this.MedHistoryViewDate = MedHistoryViewDate_;
            this.DDB_LAST_MOD = DDB_LAST_MOD_;
            this.PatClass = PatClass_;
            this.PatFacility = PatFacility_;
            this.PatAlias_LastName = PatAlias_LastName_;
            this.PatAlias_FirstName = PatAlias_FirstName_;
            this.PatAlias_MiddleName = PatAlias_MiddleName_;
            this.PatAlias_Suffix = PatAlias_Suffix_;
            this.PatAlias_Prefix = PatAlias_Prefix_;
            this.MotherMaiden_LName = MotherMaiden_LName_;
            this.MotherMaiden_FName = MotherMaiden_FName_;
            this.MotherMaiden_MName = MotherMaiden_MName_;
            this.MotherMaiden_Suffix = MotherMaiden_Suffix_;
            this.MotherMaiden_Prefix = MotherMaiden_Prefix_;
            this.PatientDeathDate = PatientDeathDate_;
            this.Language = Language_;
            this.PovertyLevel = PovertyLevel_;
            this.WorkerStatus = WorkerStatus_;
            this.HomelessStatus = HomelessStatus_;
            this.PrivacyFlags = PrivacyFlags_;
            this.PATCOPIED = PATCOPIED_;
            this.tempchart = tempchart_;
            this.Veteran = Veteran_;
            this.GUIDID = GUIDID_;
            this.TertDentInsuredID = TertDentInsuredID_;
            this.TertDentInsuredDB = TertDentInsuredDB_;
            this.QuatDentInsuredID = QuatDentInsuredID_;
            this.QuatDentInsuredDB = QuatDentInsuredDB_;
            this.TertInsRel = TertInsRel_;
            this.QuatInsRel = QuatInsRel_;
            this.TertInsCDADepCode = TertInsCDADepCode_;
            this.QuatInsCDADepCode = QuatInsCDADepCode_;
            this.OVERRIDEUSERID = OVERRIDEUSERID_;
            this.PermDescript = PermDescript_;
            this.EthnicityID = EthnicityID_;
            this.UDPatCatID = UDPatCatID_;
            this.ExtPatIDType = ExtPatIDType_;
            this.ExtGuarIDType = ExtGuarIDType_;
            this.PatExtID2 = PatExtID2_;
            this.ExtPatID2Type = ExtPatID2Type_;
            this.PatType = PatType_;
            this.AccountStatus = AccountStatus_;
            this.FinancialClassID = FinancialClassID_;
            this.PatAccountNumber = PatAccountNumber_;
            this.DeclinedEmail = DeclinedEmail_;
            this.CommunicationPref = CommunicationPref_;
            this.SmokingStatusID = SmokingStatusID_;
            this.SmokingStatusDB = SmokingStatusDB_;
            this.RxAutoRefill = RxAutoRefill_;
            this.OtherRace = OtherRace_;
            this.HousingStatus = HousingStatus_;
            this.FamSize = FamSize_;
            this.SexualOrientation = SexualOrientation_;
            this.GenderIdentity = GenderIdentity_;
            this.HohIncome = HohIncome_;
            this.IncomeRecurr = IncomeRecurr_;
            this.PracticeIdInt = PracticeIdInt_;
            this.LastUpdateTimestamp = LastUpdateTimestamp_;
            this.IsDeletedFromSource = IsDeletedFromSource_;
            this.MinProcDate_di = MinProcDate_di_;
            this.MaxProcDate_di = MaxProcDate_di_;
            this.LastPerioProc_di = LastPerioProc_di_;
            this.LastHygieneProc_di = LastHygieneProc_di_;
            this.PatientValue_0to6 = PatientValue_0to6_;
            this.PatientValue_7to12 = PatientValue_7to12_;
            this.PatientValue_13to18 = PatientValue_13to18_;
            this.PatientValue_19to24 = PatientValue_19to24_;
            this.PatientValue_25to30 = PatientValue_25to30_;
            this.PatientValue_31to36 = PatientValue_31to36_;
            this.UnScheduledTX = UnScheduledTX_;
            this.TotalTX = TotalTX_;
            this.NextHygieneAppt = NextHygieneAppt_;
            this.NextNonHygieneAppt = NextNonHygieneAppt_;
            this.StatusModifiedDate = StatusModifiedDate_;
            this.HygieneInterval_di = HygieneInterval_di_;
            this.PrimaryInsurance_DI = PrimaryInsurance_DI_;
            this.SecondaryInsurance_DI = SecondaryInsurance_DI_;
            this.RemainingInsurance_DI = RemainingInsurance_DI_;
            this.FirstPerioProc_DI = FirstPerioProc_DI_;
            this.NextRestorativeAppointment_DI = NextRestorativeAppointment_DI_;
            this.NextMiscAppointment_DI = NextMiscAppointment_DI_;
            this.RemainingPrimaryInsurance_DI = RemainingPrimaryInsurance_DI_;
            this.RemainingSecondaryInsurance_DI = RemainingSecondaryInsurance_DI_;
            this.Aging0To30_di = Aging0To30_di_;
            this.Aging31To60_di = Aging31To60_di_;
            this.Aging61To90_di = Aging61To90_di_;
            this.AgingPlus90_di = AgingPlus90_di_;
            this.TotalAging_di = TotalAging_di_;
            this.EstInsuranceAging_di = EstInsuranceAging_di_;
            this.EstPatientAging_di = EstPatientAging_di_;
            this.PrimaryProvider_DI = PrimaryProvider_DI_;
            this.SecondaryProvider_DI = SecondaryProvider_DI_;
            this.ReferralSource_DI = ReferralSource_DI_;
            this.NextHygieneApptIsOnQuickFill_DI = NextHygieneApptIsOnQuickFill_DI_;
            this.NextNonHygieneApptIsOnQuickFill_DI = NextNonHygieneApptIsOnQuickFill_DI_;
            this.NextRestorativeApptIsOnQuickFill_DI = NextRestorativeApptIsOnQuickFill_DI_;
            this.NextMiscApptIsOnQuickFill_DI = NextMiscApptIsOnQuickFill_DI_;
            this.FamilyMembersNotScheduled_DI = FamilyMembersNotScheduled_DI_;
            this.HygieneUnScheduledTX_DI = HygieneUnScheduledTX_DI_;
            this.RestorativeUnScheduledTX_DI = RestorativeUnScheduledTX_DI_;
            this.AppointmentCandidateWeightingRestorative_DI = AppointmentCandidateWeightingRestorative_DI_;
            this.AppointmentCandidateWeightingHygiene_DI = AppointmentCandidateWeightingHygiene_DI_;
            this.NextHygieneApptEndTime_DI = NextHygieneApptEndTime_DI_;
            this.NextNonHygieneApptEndTime_DI = NextNonHygieneApptEndTime_DI_;
            this.NextRestorativeAppointmentEndTime_DI = NextRestorativeAppointmentEndTime_DI_;
            this.NextMiscAppointmentEndTime_DI = NextMiscAppointmentEndTime_DI_;
            this.PatientIsOnUnscheduledQuickFill = PatientIsOnUnscheduledQuickFill_;
            this.FupHygieneRecareChanged_di = FupHygieneRecareChanged_di_;
            this.FupARChanged_di = FupARChanged_di_;
            this.LastMajorFilmProc_di = LastMajorFilmProc_di_;
            this.LastBiteWingProc_di = LastBiteWingProc_di_;
            this.LastPanoProc_di = LastPanoProc_di_;
            this.LastFmxProc_di = LastFmxProc_di_;
            this.UnScheduledTx0To30_DI = UnScheduledTx0To30_DI_;
            this.UnScheduledTx31To60_DI = UnScheduledTx31To60_DI_;
            this.UnScheduledTx61To90_DI = UnScheduledTx61To90_DI_;
            this.UnScheduledTxPlus90_DI = UnScheduledTxPlus90_DI_;
            this.RestorativeUnScheduledTx0To30_DI = RestorativeUnScheduledTx0To30_DI_;
            this.RestorativeUnScheduledTx31To60_DI = RestorativeUnScheduledTx31To60_DI_;
            this.RestorativeUnScheduledTx61To90_DI = RestorativeUnScheduledTx61To90_DI_;
            this.RestorativeUnScheduledTxPlus90_DI = RestorativeUnScheduledTxPlus90_DI_;
            this.HygieneUnScheduledTx0To30_DI = HygieneUnScheduledTx0To30_DI_;
            this.HygieneUnScheduledTx31To60_DI = HygieneUnScheduledTx31To60_DI_;
            this.HygieneUnScheduledTx61To90_DI = HygieneUnScheduledTx61To90_DI_;
            this.HygieneUnScheduledTxPlus90_DI = HygieneUnScheduledTxPlus90_DI_;
            this.TreatmentLifetimeValue_di = TreatmentLifetimeValue_di_;
            this.BrokenAppointmentCount_DI = BrokenAppointmentCount_DI_;
            this.CompletedAppointmentCount_DI = CompletedAppointmentCount_DI_;
            this.NumberPatientsReferred_DI = NumberPatientsReferred_DI_;
            this.AppointmentCandidateSnoozeTime_DI = AppointmentCandidateSnoozeTime_DI_;
            this.AppointmentCandidateSnoozeHours_DI = AppointmentCandidateSnoozeHours_DI_;
            this.AppointmentCandidateContactedTime_DI = AppointmentCandidateContactedTime_DI_;
            this.AppointmentCandidateContactedHours_DI = AppointmentCandidateContactedHours_DI_;
            this.AppointmentPreferredDayOfWeek = AppointmentPreferredDayOfWeek_;
            this.AppointmentPreferredHourOfDay = AppointmentPreferredHourOfDay_;
            this.Treatment18MonthValue_DI = Treatment18MonthValue_DI_;
            this.PATEXTIDTYPEID = PATEXTIDTYPEID_;
            this.PATEXTIDTYPEDB = PATEXTIDTYPEDB_;
            this.CONFIDENTIAL_STATE = CONFIDENTIAL_STATE_;
            this.MiddleName = MiddleName_;
            this.ConfidentialCodeID = ConfidentialCodeID_;
            this.ConfidentialCodeDB = ConfidentialCodeDB_;
            this.OrganDonorCode = OrganDonorCode_;
            this.VipCode = VipCode_;
            this.SensitivityFlag = SensitivityFlag_;
            this.BirthPlaceCountryID = BirthPlaceCountryID_;
            this.BirthPlaceCountryDB = BirthPlaceCountryDB_;
            this.MultipleBirthFlag = MultipleBirthFlag_;
            this.MultipleBirthOrder = MultipleBirthOrder_;
            this.DNACode = DNACode_;
            this.BloodTypeVerCode = BloodTypeVerCode_;
            this.HOMEPHONE = HOMEPHONE_;
            this.HOMEPHONEEXT = HOMEPHONEEXT_;
            this.WORKEMAIL = WORKEMAIL_;
            this.OtherEthnicityId = OtherEthnicityId_;
            this.NextOfKinID = NextOfKinID_;
            this.NextOfKinDB = NextOfKinDB_;
            this.EmergencyID = EmergencyID_;
            this.EmergencyDB = EmergencyDB_;
            this.GuardianID = GuardianID_;
            this.GuardianDB = GuardianDB_;
            this.SponsorID = SponsorID_;
            this.SponsorDB = SponsorDB_;
            this.CreationReasonID = CreationReasonID_;
            this.DoDUpdateAuth = DoDUpdateAuth_;
            this.DoDUpdateAuthText = DoDUpdateAuthText_;
            this.PrInsSubRel = PrInsSubRel_;
            this.ScInsSubRel = ScInsSubRel_;
            this.TertInsSubRel = TertInsSubRel_;
            this.QuatInsSubRel = QuatInsSubRel_;
            this.PrMedInsSubRel = PrMedInsSubRel_;
            this.ScMedInsSubRel = ScMedInsSubRel_;
            this.InmateID = InmateID_;
            this.InmateDB = InmateDB_;
            this.FamExtID = FamExtID_;
            this.OriginalPatId = OriginalPatId_;
            this.OriginalPatDb = OriginalPatDb_;
            this.Hygiene18MonthPerVisitAverage_di = Hygiene18MonthPerVisitAverage_di_;
            this.OnPaymentPlan_di = OnPaymentPlan_di_;
            this.PaymentCampaignDoNotSendDate_DI = PaymentCampaignDoNotSendDate_DI_;
            this.PaymentCampaignSnoozeUntil_DI = PaymentCampaignSnoozeUntil_DI_;
            this.PaymentCampaignSnoozeReason_DI = PaymentCampaignSnoozeReason_DI_;
            this.LastPatientPaymentDate_DI = LastPatientPaymentDate_DI_;
            this.LastInsurancePaymentDate_DI = LastInsurancePaymentDate_DI_;
            this.PrimaryInsuranceLastDateClaimSent_DI = PrimaryInsuranceLastDateClaimSent_DI_;
            this.SecondaryInsuranceLastDateClaimSent_DI = SecondaryInsuranceLastDateClaimSent_DI_;
            this.PrimaryInsuranceNumOpenClaims_DI = PrimaryInsuranceNumOpenClaims_DI_;
            this.SecondaryInsuranceNumOpenClaims_DI = SecondaryInsuranceNumOpenClaims_DI_;
            this.PrimaryProviderId_di = PrimaryProviderId_di_;
            this.SecondaryProviderId_di = SecondaryProviderId_di_;
        }
    }
}
