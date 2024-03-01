using DXE_Utils.Interfaces;
using DXE_Utils.Models;
using System.Data.SqlClient;

namespace DXE_Utils.Servicces
{
    public class PatientSeervice : IPatientSeervice
    {
        private readonly string connectionString;



        public void InsertarDDBPatBase(DDBPatBaseData obj)
        {
            // Consulta SQL para la inserción
            string query = @"INSERT INTO DDB_PAT_BASE 
                        (PATID, PATDB, FAMILYID, GUARID, GUARDB, PRINSUREDID, PRINSUREDDB, SCINSUREDID, SCINSUREDDB, ADDRESSID,
                         ADDRESSDB, EMPID, EMPDB, CLAIMINFID, CLAIMINFDB, PRPROVID, PRPROVDB, SCPROVID, SCPROVDB, REFTOID, REFTODB,
                         REFBYDOCID, REFBYDOCDB, REFBYPATID, REFBYPATDB, PRMEDINSID, PRMEDINSDB, SCMEDINSID, SCMEDINSDB, LASTNAME,
                         FIRSTNAME, MI, PREFNAME, SALUTATION, WKEXT, BESTTIME, CHART, CHARTDB, SS, SSNDB, GUARFLG, INSPFLG, HEADHFLG,
                         GENDER, STATUS, FAMPOS, PREMED, BIRTHDATE, FIRSTVISITDATE, LASTVISITDATE, REFTODATE, CONSENTDATE, PRINSREL,
                         SCINSREL, PRBENEFITS, SCBENEFITS, WKPHONE, FEESCHFLAG, MISSEDAPPT, LASTMISSEDAPPT, TITLE, ID2, TITLEFLG,
                         EZDWPATID, EMAILADDRESS, DRIVERSLICENSE, FAX, PAGER, OTHERPHONE, PRDED, PRDED2, PRDED3, SCDED, SCDED2, SCDED3,
                         PRDEDUCTLT, PRDEDUCTLT2, PRDEDUCTLT3, SCDEDUCTLT, SCDEDUCTLT2, SCDEDUCTLT3, MEDALERT, FEESCHEDID, FEESCHEDDB,
                         PRMEDINSREL, SCMEDINSREL, PrInsCDADepCode, ScInsCDADepCode, ConsultFlag, TOAFlag, DefaultClinic, OperatorID,
                         OperatorDB, UPLASTNAME, UPFIRSTNAME, UPCHART, ACTIVE, PATALERT, Suffix, CountyName, EmpStatus, Race, FamIncome,
                         ExternalStatus, PatExtID, GuarantorExtID, EntrySystem, EntryDateTime, LastUpdateMethod, LastUpdateSystem, VisitNumber,
                         PATIMAGEID, INITPROVID, INITPROVDB, RELIGION, RVUID, RVUDB, MedHistoryViewDate, DDB_LAST_MOD, PatClass, PatFacility,
                         PatAlias_LastName, PatAlias_FirstName, PatAlias_MiddleName, PatAlias_Suffix, PatAlias_Prefix, MotherMaiden_LName,
                         MotherMaiden_FName, MotherMaiden_MName, MotherMaiden_Suffix, MotherMaiden_Prefix, PatientDeathDate, Language,
                         PovertyLevel, WorkerStatus, HomelessStatus, PrivacyFlags, PATCOPIED, tempchart, Veteran, GUIDID, TertDentInsuredID,
                         TertDentInsuredDB, QuatDentInsuredID, QuatDentInsuredDB, TertInsRel, QuatInsRel, TertInsCDADepCode, QuatInsCDADepCode,
                         OVERRIDEUSERID, PermDescript, EthnicityID, UDPatCatID, ExtPatIDType, ExtGuarIDType, PatExtID2, ExtPatID2Type,
                         PatType, AccountStatus, FinancialClassID, PatAccountNumber, DeclinedEmail, CommunicationPref, SmokingStatusID,
                         SmokingStatusDB, RxAutoRefill, OtherRace, HousingStatus, FamSize, SexualOrientation, GenderIdentity, HohIncome,
                         IncomeRecurr, PracticeIdInt, LastUpdateTimestamp, IsDeletedFromSource, MinProcDate_di, MaxProcDate_di,
                         LastPerioProc_di, LastHygieneProc_di, PatientValue_0to6, PatientValue_7to12, PatientValue_13to18, PatientValue_19to24,
                         PatientValue_25to30, PatientValue_31to36, UnScheduledTX, TotalTX, NextHygieneAppt, NextNonHygieneAppt,
                         StatusModifiedDate, HygieneInterval_di, PrimaryInsurance_DI, SecondaryInsurance_DI, RemainingInsurance_DI,
                         FirstPerioProc_DI, NextRestorativeAppointment_DI, NextMiscAppointment_DI, RemainingPrimaryInsurance_DI,
                         RemainingSecondaryInsurance_DI, Aging0To30_di, Aging31To60_di, Aging61To90_di, AgingPlus90_di, TotalAging_di,
                         EstInsuranceAging_di, EstPatientAging_di, PrimaryProvider_DI, SecondaryProvider_DI, ReferralSource_DI,
                         NextHygieneApptIsOnQuickFill_DI, NextNonHygieneApptIsOnQuickFill_DI, NextRestorativeApptIsOnQuickFill_DI,
                         NextMiscApptIsOnQuickFill_DI, FamilyMembersNotScheduled_DI, HygieneUnScheduledTX_DI, RestorativeUnScheduledTX_DI,
                         AppointmentCandidateWeightingRestorative_DI, AppointmentCandidateWeightingHygiene_DI, NextHygieneApptEndTime_DI,
                         NextNonHygieneApptEndTime_DI, NextRestorativeAppointmentEndTime_DI, NextMiscAppointmentEndTime_DI,
                         PatientIsOnUnscheduledQuickFill, FupHygieneRecareChanged_di, FupARChanged_di, LastMajorFilmProc_di,
                         LastBiteWingProc_di, LastPanoProc_di, LastFmxProc_di, UnScheduledTx0To30_DI, UnScheduledTx31To60_DI,
                         UnScheduledTx61To90_DI, UnScheduledTxPlus90_DI, RestorativeUnScheduledTx0To30_DI, RestorativeUnScheduledTx31To60_DI,
                         RestorativeUnScheduledTx61To90_DI, RestorativeUnScheduledTxPlus90_DI, HygieneUnScheduledTx0To30_DI,
                         HygieneUnScheduledTx31To60_DI, HygieneUnScheduledTx61To90_DI, HygieneUnScheduledTxPlus90_DI, TreatmentLifetimeValue_di,
                         BrokenAppointmentCount_DI, CompletedAppointmentCount_DI, NumberPatientsReferred_DI, AppointmentCandidateSnoozeTime_DI,
                         AppointmentCandidateSnoozeHours_DI, AppointmentCandidateContactedTime_DI, AppointmentCandidateContactedHours_DI,
                         AppointmentPreferredDayOfWeek, AppointmentPreferredHourOfDay, Treatment18MonthValue_DI, PATEXTIDTYPEID, PATEXTIDTYPEDB,
                         CONFIDENTIAL_STATE, MiddleName, ConfidentialCodeID, ConfidentialCodeDB, OrganDonorCode, VipCode, SensitivityFlag,
                         BirthPlaceCountryID, BirthPlaceCountryDB, MultipleBirthFlag, MultipleBirthOrder, DNACode, BloodTypeVerCode, HOMEPHONE,
                         HOMEPHONEEXT, WORKEMAIL, OtherEthnicityId, NextOfKinID, NextOfKinDB, EmergencyID, EmergencyDB, GuardianID, GuardianDB,
                         SponsorID, SponsorDB, CreationReasonID, DoDUpdateAuth, DoDUpdateAuthText, PrInsSubRel, ScInsSubRel, TertInsSubRel,
                         QuatInsSubRel, PrMedInsSubRel, ScMedInsSubRel, InmateID, InmateDB, FamExtID, OriginalPatId, OriginalPatDb,
                         Hygiene18MonthPerVisitAverage_di, OnPaymentPlan_di, PaymentCampaignDoNotSendDate_DI, PaymentCampaignSnoozeUntil_DI,
                         PaymentCampaignSnoozeReason_DI, LastPatientPaymentDate_DI, LastInsurancePaymentDate_DI, PrimaryInsuranceLastDateClaimSent_DI,
                         SecondaryInsuranceLastDateClaimSent_DI, PrimaryInsuranceNumOpenClaims_DI, SecondaryInsuranceNumOpenClaims_DI,
                         PrimaryProviderId_di, SecondaryProviderId_di)
                        VALUES 
                        (@PATID, @PATDB, @FAMILYID, @GUARID, @GUARDB, @PRINSUREDID, @PRINSUREDDB, @SCINSUREDID, @SCINSUREDDB, @ADDRESSID,
                         @ADDRESSDB, @EMPID, @EMPDB, @CLAIMINFID, @CLAIMINFDB, @PRPROVID, @PRPROVDB, @SCPROVID, @SCPROVDB, @REFTOID, @REFTODB,
                         @REFBYDOCID, @REFBYDOCDB, @REFBYPATID, @REFBYPATDB, @PRMEDINSID, @PRMEDINSDB, @SCMEDINSID, @SCMEDINSDB, @LASTNAME,
                         @FIRSTNAME, @MI, @PREFNAME, @SALUTATION, @WKEXT, @BESTTIME, @CHART, @CHARTDB, @SS, @SSNDB, @GUARFLG, @INSPFLG, @HEADHFLG,
                         @GENDER, @STATUS, @FAMPOS, @PREMED, @BIRTHDATE, @FIRSTVISITDATE, @LASTVISITDATE, @REFTODATE, @CONSENTDATE, @PRINSREL,
                         @SCINSREL, @PRBENEFITS, @SCBENEFITS, @WKPHONE, @FEESCHFLAG, @MISSEDAPPT, @LASTMISSEDAPPT, @TITLE, @ID2, @TITLEFLG,
                         @EZDWPATID, @EMAILADDRESS, @DRIVERSLICENSE, @FAX, @PAGER, @OTHERPHONE, @PRDED, @PRDED2, @PRDED3, @SCDED, @SCDED2, @SCDED3,
                         @PRDEDUCTLT, @PRDEDUCTLT2, @PRDEDUCTLT3, @SCDEDUCTLT, @SCDEDUCTLT2, @SCDEDUCTLT3, @MEDALERT, @FEESCHEDID, @FEESCHEDDB,
                         @PRMEDINSREL, @SCMEDINSREL, @PrInsCDADepCode, @ScInsCDADepCode, @ConsultFlag, @TOAFlag, @DefaultClinic, @OperatorID,
                         @OperatorDB, @UPLASTNAME, @UPFIRSTNAME, @UPCHART, @ACTIVE, @PATALERT, @Suffix, @CountyName, @EmpStatus, @Race, @FamIncome,
                         @ExternalStatus, @PatExtID, @GuarantorExtID, @EntrySystem, @EntryDateTime, @LastUpdateMethod, @LastUpdateSystem, @VisitNumber,
                         @PATIMAGEID, @INITPROVID, @INITPROVDB, @RELIGION, @RVUID, @RVUDB, @MedHistoryViewDate, @DDB_LAST_MOD, @PatClass, @PatFacility,
                         @PatAlias_LastName, @PatAlias_FirstName, @PatAlias_MiddleName, @PatAlias_Suffix, @PatAlias_Prefix, @MotherMaiden_LName,
                         @MotherMaiden_FName, @MotherMaiden_MName, @MotherMaiden_Suffix, @MotherMaiden_Prefix, @PatientDeathDate, @Language,
                         @PovertyLevel, @WorkerStatus, @HomelessStatus, @PrivacyFlags, @PATCOPIED, @tempchart, @Veteran, @GUIDID, @TertDentInsuredID,
                         @TertDentInsuredDB, @QuatDentInsuredID, @QuatDentInsuredDB, @TertInsRel, @QuatInsRel, @TertInsCDADepCode, @QuatInsCDADepCode,
                         @OVERRIDEUSERID, @PermDescript, @EthnicityID, @UDPatCatID, @ExtPatIDType, @ExtGuarIDType, @PatExtID2, @ExtPatID2Type,
                         @PatType, @AccountStatus, @FinancialClassID, @PatAccountNumber, @DeclinedEmail, @CommunicationPref, @SmokingStatusID,
                         @SmokingStatusDB, @RxAutoRefill, @OtherRace, @HousingStatus, @FamSize, @SexualOrientation, @GenderIdentity, @HohIncome,
                         @IncomeRecurr, @PracticeIdInt, @LastUpdateTimestamp, @IsDeletedFromSource, @MinProcDate_di, @MaxProcDate_di,
                         @LastPerioProc_di, @LastHygieneProc_di, @PatientValue_0to6, @PatientValue_7to12, @PatientValue_13to18, @PatientValue_19to24,
                         @PatientValue_25to30, @PatientValue_31to36, @UnScheduledTX, @TotalTX, @NextHygieneAppt, @NextNonHygieneAppt,
                         @StatusModifiedDate, @HygieneInterval_di, @PrimaryInsurance_DI, @SecondaryInsurance_DI, @RemainingInsurance_DI,
                         @FirstPerioProc_DI, @NextRestorativeAppointment_DI, @NextMiscAppointment_DI, @RemainingPrimaryInsurance_DI,
                         @RemainingSecondaryInsurance_DI, @Aging0To30_di, @Aging31To60_di, @Aging61To90_di, @AgingPlus90_di, @TotalAging_di,
                         @EstInsuranceAging_di, @EstPatientAging_di, @PrimaryProvider_DI, @SecondaryProvider_DI, @ReferralSource_DI,
                         @NextHygieneApptIsOnQuickFill_DI, @NextNonHygieneApptIsOnQuickFill_DI, @NextRestorativeApptIsOnQuickFill_DI,
                         @NextMiscApptIsOnQuickFill_DI, @FamilyMembersNotScheduled_DI, @HygieneUnScheduledTX_DI, @RestorativeUnScheduledTX_DI,
                         @AppointmentCandidateWeightingRestorative_DI, @AppointmentCandidateWeightingHygiene_DI, @NextHygieneApptEndTime_DI,
                         @NextNonHygieneApptEndTime_DI, @NextRestorativeAppointmentEndTime_DI, @NextMiscAppointmentEndTime_DI,
                         @PatientIsOnUnscheduledQuickFill, @FupHygieneRecareChanged_di, @FupARChanged_di, @LastMajorFilmProc_di, @LastBiteWingProc_di,
                         @LastPanoProc_di, @LastFmxProc_di, @UnScheduledTx0To30_DI, @UnScheduledTx31To60_DI, @UnScheduledTx61To90_DI,
                         @UnScheduledTxPlus90_DI, @RestorativeUnScheduledTx0To30_DI, @RestorativeUnScheduledTx31To60_DI,
                         @RestorativeUnScheduledTx61To90_DI, @RestorativeUnScheduledTxPlus90_DI, @HygieneUnScheduledTx0To30_DI,
                         @HygieneUnScheduledTx31To60_DI, @HygieneUnScheduledTx61To90_DI, @HygieneUnScheduledTxPlus90_DI, @TreatmentLifetimeValue_di,
                         @BrokenAppointmentCount_DI, @CompletedAppointmentCount_DI, @NumberPatientsReferred_DI, @AppointmentCandidateSnoozeTime_DI,
                         @AppointmentCandidateSnoozeHours_DI, @AppointmentCandidateContactedTime_DI, @AppointmentCandidateContactedHours_DI,
                         @AppointmentPreferredDayOfWeek, @AppointmentPreferredHourOfDay, @Treatment18MonthValue_DI, @PATEXTIDTYPEID, @PATEXTIDTYPEDB,
                         @CONFIDENTIAL_STATE, @MiddleName, @ConfidentialCodeID, @ConfidentialCodeDB, @OrganDonorCode, @VipCode, @SensitivityFlag,
                         @BirthPlaceCountryID, @BirthPlaceCountryDB, @MultipleBirthFlag, @MultipleBirthOrder, @DNACode, @BloodTypeVerCode,
                         @HOMEPHONE, @HOMEPHONEEXT, @WORKEMAIL, @OtherEthnicityId, @NextOfKinID, @NextOfKinDB, @EmergencyID, @EmergencyDB, @GuardianID,
                         @GuardianDB, @SponsorID, @SponsorDB, @CreationReasonID, @DoDUpdateAuth, @DoDUpdateAuthText, @PrInsSubRel, @ScInsSubRel,
                         @TertInsSubRel, @QuatInsSubRel, @PrMedInsSubRel, @ScMedInsSubRel, @InmateID, @InmateDB, @FamExtID, @OriginalPatId,
                         @OriginalPatDb, @Hygiene18MonthPerVisitAverage_di, @OnPaymentPlan_di, @PaymentCampaignDoNotSendDate_DI,
                         @PaymentCampaignSnoozeUntil_DI, @PaymentCampaignSnoozeReason_DI, @LastPatientPaymentDate_DI, @LastInsurancePaymentDate_DI,
                         @PrimaryInsuranceLastDateClaimSent_DI, @SecondaryInsuranceLastDateClaimSent_DI, @PrimaryInsuranceNumOpenClaims_DI,
                         @SecondaryInsuranceNumOpenClaims_DI, @PrimaryProviderId_di, @SecondaryProviderId_di);

                    SELECT SCOPE_IDENTITY();";

            using SqlConnection conn = new(connectionString);
            conn.Open();
            SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@PATID", obj.PatId);
            cmd.Parameters.AddWithValue("@PATDB", obj.PatDb);
            cmd.Parameters.AddWithValue("@FAMILYID", obj.FamilyId);
            cmd.Parameters.AddWithValue("@GUARID", obj.GuarId);
            cmd.Parameters.AddWithValue("@GUARDB", obj.GuarDb);
            cmd.Parameters.AddWithValue("@PRINSUREDID", obj.PrInsuredId);
            cmd.Parameters.AddWithValue("@PRINSUREDDB", obj.PrInsuredDb);
            cmd.Parameters.AddWithValue("@SCINSUREDID", obj.ScInsuredId);
            cmd.Parameters.AddWithValue("@SCINSUREDDB", obj.ScInsuredDb);
            cmd.Parameters.AddWithValue("@ADDRESSID", obj.AddressId);
            cmd.Parameters.AddWithValue("@ADDRESSDB", obj.AddressDb);
            cmd.Parameters.AddWithValue("@EMPID", obj.EmpId);
            cmd.Parameters.AddWithValue("@EMPDB", obj.EmpDb);
            cmd.Parameters.AddWithValue("@CLAIMINFID", obj.ClaimInfId);
            cmd.Parameters.AddWithValue("@CLAIMINFDB", obj.ClaimInfDb);
            cmd.Parameters.AddWithValue("@PRPROVID", obj.PrProvId);
            cmd.Parameters.AddWithValue("@PRPROVDB", obj.PrProvDb);
            cmd.Parameters.AddWithValue("@SCPROVID", obj.ScProvId);
            cmd.Parameters.AddWithValue("@SCPROVDB", obj.ScProvDb);
            cmd.Parameters.AddWithValue("@REFTOID", obj.RefToId);
            cmd.Parameters.AddWithValue("@REFTODB", obj.RefToDb);
            cmd.Parameters.AddWithValue("@REFBYDOCID", obj.RefByDocId);
            cmd.Parameters.AddWithValue("@REFBYDOCDB", obj.RefByDocDb);
            cmd.Parameters.AddWithValue("@REFBYPATID", obj.RefByPatId);
            cmd.Parameters.AddWithValue("@REFBYPATDB", obj.RefByPatDb);
            cmd.Parameters.AddWithValue("@PRMEDINSID", obj.PrMedInsId);
            cmd.Parameters.AddWithValue("@PRMEDINSDB", obj.PrMedInsDb);
            cmd.Parameters.AddWithValue("@SCMEDINSID", obj.ScMedInsId);
            cmd.Parameters.AddWithValue("@SCMEDINSDB", obj.ScMedInsDb);
            cmd.Parameters.AddWithValue("@LASTNAME", obj.LastName);
            cmd.Parameters.AddWithValue("@FIRSTNAME", obj.FirstName);
            cmd.Parameters.AddWithValue("@MI", obj.Mi);
            cmd.Parameters.AddWithValue("@PREFNAME", obj.PrefName);
            cmd.Parameters.AddWithValue("@SALUTATION", obj.Salutation);
            cmd.Parameters.AddWithValue("@WKEXT", obj.WkExt);
            cmd.Parameters.AddWithValue("@BESTTIME", obj.BestTime);
            cmd.Parameters.AddWithValue("@CHART", obj.Chart);
            cmd.Parameters.AddWithValue("@CHARTDB", obj.ChartDb);
            cmd.Parameters.AddWithValue("@SS", obj.Ss);
            cmd.Parameters.AddWithValue("@SSNDB", obj.SsnDb);
            cmd.Parameters.AddWithValue("@GUARFLG", obj.GuarFlg);
            cmd.Parameters.AddWithValue("@INSPFLG", obj.InspFlg);
            cmd.Parameters.AddWithValue("@HEADHFLG", obj.HeadHFlg);
            cmd.Parameters.AddWithValue("@GENDER", obj.Gender);
            cmd.Parameters.AddWithValue("@STATUS", obj.Status);
            cmd.Parameters.AddWithValue("@FAMPOS", obj.FamPos);
            cmd.Parameters.AddWithValue("@PREMED", obj.PreMed);
            cmd.Parameters.AddWithValue("@BIRTHDATE", obj.BirthDate);
            cmd.Parameters.AddWithValue("@FIRSTVISITDATE", obj.FirstVisitDate);
            cmd.Parameters.AddWithValue("@LASTVISITDATE", obj.LastVisitDate);
            cmd.Parameters.AddWithValue("@REFTODATE", obj.RefToDate);
            cmd.Parameters.AddWithValue("@CONSENTDATE", obj.ConsentDate);
            cmd.Parameters.AddWithValue("@PRINSREL", obj.PrInsRel);
            cmd.Parameters.AddWithValue("@SCINSREL", obj.ScInsRel);
            cmd.Parameters.AddWithValue("@PRBENEFITS", obj.PrBenefits);
            cmd.Parameters.AddWithValue("@SCBENEFITS", obj.ScBenefits);
            cmd.Parameters.AddWithValue("@WKPHONE", obj.WkPhone);
            cmd.Parameters.AddWithValue("@FEESCHFLAG", obj.FeeschFlag);
            cmd.Parameters.AddWithValue("@MISSEDAPPT", obj.MissedAppt);
            cmd.Parameters.AddWithValue("@LASTMISSEDAPPT", obj.LastMissedAppt);
            cmd.Parameters.AddWithValue("@TITLE", obj.Title);
            cmd.Parameters.AddWithValue("@ID2", obj.Id2);
            cmd.Parameters.AddWithValue("@TITLEFLG", obj.TitleFlg);
            cmd.Parameters.AddWithValue("@EZDWPATID", obj.EzdwpAtid);
            cmd.Parameters.AddWithValue("@EMAILADDRESS", obj.EmailAddress);
            cmd.Parameters.AddWithValue("@DRIVERSLICENSE", obj.DriversLicense);
            cmd.Parameters.AddWithValue("@FAX", obj.Fax);
            cmd.Parameters.AddWithValue("@PAGER", obj.Pager);
            cmd.Parameters.AddWithValue("@OTHERPHONE", obj.OtherPhone);
            cmd.Parameters.AddWithValue("@PRDED", obj.PrDed);
            cmd.Parameters.AddWithValue("@PRDED2", obj.PrDed2);
            cmd.Parameters.AddWithValue("@PRDED3", obj.PrDed3);
            cmd.Parameters.AddWithValue("@SCDED", obj.ScDed);
            cmd.Parameters.AddWithValue("@SCDED2", obj.ScDed2);
            cmd.Parameters.AddWithValue("@SCDED3", obj.ScDed3);
            cmd.Parameters.AddWithValue("@PRDEDUCTLT", obj.PrDeductLt);
            cmd.Parameters.AddWithValue("@PRDEDUCTLT2", obj.PrDeductLt2);
            cmd.Parameters.AddWithValue("@PRDEDUCTLT3", obj.PrDeductLt3);
            cmd.Parameters.AddWithValue("@SCDEDUCTLT", obj.ScDeductLt);
            cmd.Parameters.AddWithValue("@SCDEDUCTLT2", obj.ScDeductLt2);
            cmd.Parameters.AddWithValue("@SCDEDUCTLT3", obj.ScDeductLt3);
            cmd.Parameters.AddWithValue("@MEDALERT", obj.MedAlert);
            cmd.Parameters.AddWithValue("@FEESCHEDID", obj.FeeschId);
            cmd.Parameters.AddWithValue("@FEESCHEDDB", obj.FeeschDb);
            cmd.Parameters.AddWithValue("@PRMEDINSREL", obj.PrMedInsRel);
            cmd.Parameters.AddWithValue("@SCMEDINSREL", obj.ScMedInsRel);
            cmd.Parameters.AddWithValue("@PrInsCDADepCode", obj.PrInsCdaDepCode);
            cmd.Parameters.AddWithValue("@ScInsCDADepCode", obj.ScInsCdaDepCode);
            cmd.Parameters.AddWithValue("@ConsultFlag", obj.ConsultFlag);
            cmd.Parameters.AddWithValue("@TOAFlag", obj.ToaFlag);
            cmd.Parameters.AddWithValue("@DefaultClinic", obj.DefaultClinic);
            cmd.Parameters.AddWithValue("@OperatorID", obj.OperatorId);
            cmd.Parameters.AddWithValue("@OperatorDB", obj.OperatorDb);
            cmd.Parameters.AddWithValue("@UPLASTNAME", obj.UpLastName);
            cmd.Parameters.AddWithValue("@UPFIRSTNAME", obj.UpFirstName);
            cmd.Parameters.AddWithValue("@UPCHART", obj.UpChart);
            cmd.Parameters.AddWithValue("@ACTIVE", obj.Active);
            cmd.Parameters.AddWithValue("@PATALERT", obj.PatAlert);
            cmd.Parameters.AddWithValue("@Suffix", obj.Suffix);
            cmd.Parameters.AddWithValue("@CountyName", obj.CountyName);
            cmd.Parameters.AddWithValue("@EmpStatus", obj.EmpStatus);
            cmd.Parameters.AddWithValue("@Race", obj.Race);
            cmd.Parameters.AddWithValue("@FamIncome", obj.FamIncome);
            cmd.Parameters.AddWithValue("@ExternalStatus", obj.ExternalStatus);
            cmd.Parameters.AddWithValue("@PatExtID", obj.PatExtId);
            cmd.Parameters.AddWithValue("@GuarantorExtID", obj.GuarantorExtId);
            cmd.Parameters.AddWithValue("@EntrySystem", obj.EntrySystem);
            cmd.Parameters.AddWithValue("@EntryDateTime", obj.EntryDateTime);
            cmd.Parameters.AddWithValue("@LastUpdateMethod", obj.LastUpdateMethod);
            cmd.Parameters.AddWithValue("@LastUpdateSystem", obj.LastUpdateSystem);
            cmd.Parameters.AddWithValue("@VisitNumber", obj.VisitNumber);
            cmd.Parameters.AddWithValue("@PATIMAGEID", obj.PatImageId);
            cmd.Parameters.AddWithValue("@INITPROVID", obj.InitProvId);
            cmd.Parameters.AddWithValue("@INITPROVDB", obj.InitProvDb);
            cmd.Parameters.AddWithValue("@RELIGION", obj.Religion);
            cmd.Parameters.AddWithValue("@RVUID", obj.RvUid);
            cmd.Parameters.AddWithValue("@RVUDB", obj.RvUdb);
            cmd.Parameters.AddWithValue("@MedHistoryViewDate", obj.MedHistoryViewDate);
            cmd.Parameters.AddWithValue("@DDB_LAST_MOD", obj.DdbLastMod);
            cmd.Parameters.AddWithValue("@PatClass", obj.PatClass);
            cmd.Parameters.AddWithValue("@PatFacility", obj.PatFacility);
            cmd.Parameters.AddWithValue("@PatAlias_LastName", obj.PatAliasLastName);
            cmd.Parameters.AddWithValue("@PatAlias_FirstName", obj.PatAliasFirstName);
            cmd.Parameters.AddWithValue("@PatAlias_MiddleName", obj.PatAliasMiddleName);
            cmd.Parameters.AddWithValue("@PatAlias_Suffix", obj.PatAliasSuffix);
            cmd.Parameters.AddWithValue("@PatAlias_Prefix", obj.PatAliasPrefix);
            cmd.Parameters.AddWithValue("@MotherMaiden_LName", obj.MotherMaidenLName);
            cmd.Parameters.AddWithValue("@MotherMaiden_FName", obj.MotherMaidenFName);
            cmd.Parameters.AddWithValue("@MotherMaiden_MName", obj.MotherMaidenMName);
            cmd.Parameters.AddWithValue("@MotherMaiden_Suffix", obj.MotherMaidenSuffix);
            cmd.Parameters.AddWithValue("@MotherMaiden_Prefix", obj.MotherMaidenPrefix);
            cmd.Parameters.AddWithValue("@PatientDeathDate", obj.PatientDeathDate);
            cmd.Parameters.AddWithValue("@Language", obj.Language);
            cmd.Parameters.AddWithValue("@PovertyLevel", obj.PovertyLevel);
            cmd.Parameters.AddWithValue("@WorkerStatus", obj.WorkerStatus);
            cmd.Parameters.AddWithValue("@HomelessStatus", obj.HomelessStatus);
            cmd.Parameters.AddWithValue("@PrivacyFlags", obj.PrivacyFlags);
            cmd.Parameters.AddWithValue("@PATCOPIED", obj.PatCopied);
            cmd.Parameters.AddWithValue("@tempchart", obj.TempChart);
            cmd.Parameters.AddWithValue("@Veteran", obj.Veteran);
            cmd.Parameters.AddWithValue("@GUIDID", obj.GuidId);
            cmd.Parameters.AddWithValue("@TertDentInsuredID", obj.TertDentInsuredId);
            cmd.Parameters.AddWithValue("@TertDentInsuredDB", obj.TertDentInsuredDb);
            cmd.Parameters.AddWithValue("@QuatDentInsuredID", obj.QuatDentInsuredId);
            cmd.Parameters.AddWithValue("@QuatDentInsuredDB", obj.QuatDentInsuredDb);
            cmd.Parameters.AddWithValue("@TertInsRel", obj.TertInsRel);
            cmd.Parameters.AddWithValue("@QuatInsRel", obj.QuatInsRel);
            cmd.Parameters.AddWithValue("@TertInsCDADepCode", obj.TertInsCdaDepCode);
            cmd.Parameters.AddWithValue("@QuatInsCDADepCode", obj.QuatInsCdaDepCode);
            cmd.Parameters.AddWithValue("@OVERRIDEUSERID", obj.OverrideUserId);
            cmd.Parameters.AddWithValue("@PermDescript", obj.PermDescript);
            cmd.Parameters.AddWithValue("@EthnicityID", obj.EthnicityId);
            cmd.Parameters.AddWithValue("@UDPatCatID", obj.UdPatCatId);
            cmd.Parameters.AddWithValue("@ExtPatIDType", obj.ExtPatIdType);
            cmd.Parameters.AddWithValue("@ExtGuarIDType", obj.ExtGuarIdType);
            cmd.Parameters.AddWithValue("@PatExtID2", obj.PatExtId2);
            cmd.Parameters.AddWithValue("@ExtPatID2Type", obj.ExtPatId2Type);
            cmd.Parameters.AddWithValue("@PatType", obj.PatType);
            cmd.Parameters.AddWithValue("@AccountStatus", obj.AccountStatus);
            cmd.Parameters.AddWithValue("@FinancialClassID", obj.FinancialClassId);
            cmd.Parameters.AddWithValue("@PatAccountNumber", obj.PatAccountNumber);
            cmd.Parameters.AddWithValue("@DeclinedEmail", obj.DeclinedEmail);
            cmd.Parameters.AddWithValue("@CommunicationPref", obj.CommunicationPref);
            cmd.Parameters.AddWithValue("@SmokingStatusID", obj.SmokingStatusId);
            cmd.Parameters.AddWithValue("@SmokingStatusDB", obj.SmokingStatusDb);
            cmd.Parameters.AddWithValue("@RxAutoRefill", obj.RxAutoRefill);
            cmd.Parameters.AddWithValue("@OtherRace", obj.OtherRace);
            cmd.Parameters.AddWithValue("@HousingStatus", obj.HousingStatus);
            cmd.Parameters.AddWithValue("@FamSize", obj.FamSize);
            cmd.Parameters.AddWithValue("@SexualOrientation", obj.SexualOrientation);
            cmd.Parameters.AddWithValue("@GenderIdentity", obj.GenderIdentity);
            cmd.Parameters.AddWithValue("@HohIncome", obj.HohIncome);
            cmd.Parameters.AddWithValue("@IncomeRecurr", obj.IncomeRecurr);
            cmd.Parameters.AddWithValue("@PracticeIdInt", obj.PracticeIdInt);
            cmd.Parameters.AddWithValue("@LastUpdateTimestamp", obj.LastUpdateTimestamp);
            cmd.Parameters.AddWithValue("@IsDeletedFromSource", obj.IsDeletedFromSource);
            cmd.Parameters.AddWithValue("@MinProcDate_di", obj.MinProcDateDi);
            cmd.Parameters.AddWithValue("@MaxProcDate_di", obj.MaxProcDateDi);
            cmd.Parameters.AddWithValue("@LastPerioProc_di", obj.LastPerioProcDi);
            cmd.Parameters.AddWithValue("@LastHygieneProc_di", obj.LastHygieneProcDi);
            cmd.Parameters.AddWithValue("@PatientValue_0to6", obj.PatientValue0To6);
            cmd.Parameters.AddWithValue("@PatientValue_7to12", obj.PatientValue7To12);
            cmd.Parameters.AddWithValue("@PatientValue_13to18", obj.PatientValue13To18);
            cmd.Parameters.AddWithValue("@PatientValue_19to24", obj.PatientValue19To24);
            cmd.Parameters.AddWithValue("@PatientValue_25to30", obj.PatientValue25To30);
            cmd.Parameters.AddWithValue("@PatientValue_31to36", obj.PatientValue31To36);
            cmd.Parameters.AddWithValue("@UnScheduledTX", obj.UnScheduledTx);
            cmd.Parameters.AddWithValue("@TotalTX", obj.TotalTx);
            cmd.Parameters.AddWithValue("@NextHygieneAppt", obj.NextHygieneAppt);
            cmd.Parameters.AddWithValue("@NextNonHygieneAppt", obj.NextNonHygieneAppt);
            cmd.Parameters.AddWithValue("@StatusModifiedDate", obj.StatusModifiedDate);
            cmd.Parameters.AddWithValue("@HygieneInterval_di", obj.HygieneIntervalDi);
            cmd.Parameters.AddWithValue("@PrimaryInsurance_DI", obj.PrimaryInsuranceDi);
            cmd.Parameters.AddWithValue("@SecondaryInsurance_DI", obj.SecondaryInsuranceDi);
            cmd.Parameters.AddWithValue("@RemainingInsurance_DI", obj.RemainingInsuranceDi);
            cmd.Parameters.AddWithValue("@FirstPerioProc_DI", obj.FirstPerioProcDi);
            cmd.Parameters.AddWithValue("@NextRestorativeAppointment_DI", obj.NextRestorativeAppointmentDi);
            cmd.Parameters.AddWithValue("@NextMiscAppointment_DI", obj.NextMiscAppointmentDi);
            cmd.Parameters.AddWithValue("@RemainingPrimaryInsurance_DI", obj.RemainingPrimaryInsuranceDi);
            cmd.Parameters.AddWithValue("@RemainingSecondaryInsurance_DI", obj.RemainingSecondaryInsuranceDi);
            cmd.Parameters.AddWithValue("@Aging0To30_di", obj.Aging0To30Di);
            cmd.Parameters.AddWithValue("@Aging31To60_di", obj.Aging31To60Di);
            cmd.Parameters.AddWithValue("@Aging61To90_di", obj.Aging61To90Di);
            cmd.Parameters.AddWithValue("@AgingPlus90_di", obj.AgingPlus90Di);
            cmd.Parameters.AddWithValue("@TotalAging_di", obj.TotalAgingDi);
            cmd.Parameters.AddWithValue("@EstInsuranceAging_di", obj.EstInsuranceAgingDi);
            cmd.Parameters.AddWithValue("@EstPatientAging_di", obj.EstPatientAgingDi);
            cmd.Parameters.AddWithValue("@PrimaryProvider_DI", obj.PrimaryProviderDi);
            cmd.Parameters.AddWithValue("@SecondaryProvider_DI", obj.SecondaryProviderDi);
            cmd.Parameters.AddWithValue("@ReferralSource_DI", obj.ReferralSourceDi);
            cmd.Parameters.AddWithValue("@NextHygieneApptIsOnQuickFill_DI", obj.NextHygieneApptIsOnQuickFillDi);
            cmd.Parameters.AddWithValue("@NextNonHygieneApptIsOnQuickFill_DI", obj.NextNonHygieneApptIsOnQuickFillDi);
            cmd.Parameters.AddWithValue("@NextRestorativeApptIsOnQuickFill_DI", obj.NextRestorativeApptIsOnQuickFillDi);
            cmd.Parameters.AddWithValue("@NextMiscApptIsOnQuickFill_DI", obj.NextMiscApptIsOnQuickFillDi);
            cmd.Parameters.AddWithValue("@FamilyMembersNotScheduled_DI", obj.FamilyMembersNotScheduledDi);
            cmd.Parameters.AddWithValue("@HygieneUnScheduledTX_DI", obj.HygieneUnScheduledTxDi);
            cmd.Parameters.AddWithValue("@RestorativeUnScheduledTX_DI", obj.RestorativeUnScheduledTxDi);
            cmd.Parameters.AddWithValue("@AppointmentCandidateWeightingRestorative_DI", obj.AppointmentCandidateWeightingRestorativeDi);
            cmd.Parameters.AddWithValue("@AppointmentCandidateWeightingHygiene_DI", obj.AppointmentCandidateWeightingHygieneDi);
            cmd.Parameters.AddWithValue("@NextHygieneApptEndTime_DI", obj.NextHygieneApptEndTimeDi);
            cmd.Parameters.AddWithValue("@NextNonHygieneApptEndTime_DI", obj.NextNonHygieneApptEndTimeDi);
            cmd.Parameters.AddWithValue("@NextRestorativeAppointmentEndTime_DI", obj.NextRestorativeAppointmentEndTimeDi);
            cmd.Parameters.AddWithValue("@NextMiscAppointmentEndTime_DI", obj.NextMiscAppointmentEndTimeDi);
            cmd.Parameters.AddWithValue("@PatientIsOnUnscheduledQuickFill", obj.PatientIsOnUnscheduledQuickFill);
            cmd.Parameters.AddWithValue("@FupHygieneRecareChanged_di", obj.FupHygieneRecareChangedDi);
            cmd.Parameters.AddWithValue("@FupARChanged_di", obj.FupArChangedDi);
            cmd.Parameters.AddWithValue("@LastMajorFilmProc_di", obj.LastMajorFilmProcDi);
            cmd.Parameters.AddWithValue("@LastBiteWingProc_di", obj.LastBiteWingProcDi);
            cmd.Parameters.AddWithValue("@LastPanoProc_di", obj.LastPanoProcDi);
            cmd.Parameters.AddWithValue("@LastFmxProc_di", obj.LastFmxProcDi);
            cmd.Parameters.AddWithValue("@UnScheduledTx0To30_DI", obj.UnScheduledTx0To30Di);
            cmd.Parameters.AddWithValue("@UnScheduledTx31To60_DI", obj.UnScheduledTx31To60Di);
            cmd.Parameters.AddWithValue("@UnScheduledTx61To90_DI", obj.UnScheduledTx61To90Di);
            cmd.Parameters.AddWithValue("@UnScheduledTxPlus90_DI", obj.UnScheduledTxPlus90Di);
            cmd.Parameters.AddWithValue("@RestorativeUnScheduledTx0To30_DI", obj.RestorativeUnScheduledTx0To30Di);
            cmd.Parameters.AddWithValue("@RestorativeUnScheduledTx31To60_DI", obj.RestorativeUnScheduledTx31To60Di);
            cmd.Parameters.AddWithValue("@RestorativeUnScheduledTx61To90_DI", obj.RestorativeUnScheduledTx61To90Di);
            cmd.Parameters.AddWithValue("@RestorativeUnScheduledTxPlus90_DI", obj.RestorativeUnScheduledTxPlus90Di);
            cmd.Parameters.AddWithValue("@HygieneUnScheduledTx0To30_DI", obj.HygieneUnScheduledTx0To30Di);
            cmd.Parameters.AddWithValue("@HygieneUnScheduledTx31To60_DI", obj.HygieneUnScheduledTx31To60Di);
            cmd.Parameters.AddWithValue("@HygieneUnScheduledTx61To90_DI", obj.HygieneUnScheduledTx61To90Di);
            cmd.Parameters.AddWithValue("@HygieneUnScheduledTxPlus90_DI", obj.HygieneUnScheduledTxPlus90Di);
            cmd.Parameters.AddWithValue("@TreatmentLifetimeValue_di", obj.TreatmentLifetimeValueDi);
            cmd.Parameters.AddWithValue("@BrokenAppointmentCount_DI", obj.BrokenAppointmentCountDi);
            cmd.Parameters.AddWithValue("@CompletedAppointmentCount_DI", obj.CompletedAppointmentCountDi);
            cmd.Parameters.AddWithValue("@NumberPatientsReferred_DI", obj.NumberPatientsReferredDi);
            cmd.Parameters.AddWithValue("@AppointmentCandidateSnoozeTime_DI", obj.AppointmentCandidateSnoozeTimeDi);
            cmd.Parameters.AddWithValue("@AppointmentCandidateSnoozeHours_DI", obj.AppointmentCandidateSnoozeHoursDi);
            cmd.Parameters.AddWithValue("@AppointmentCandidateContactedTime_DI", obj.AppointmentCandidateContactedTimeDi);
            cmd.Parameters.AddWithValue("@AppointmentCandidateContactedHours_DI", obj.AppointmentCandidateContactedHoursDi);
            cmd.Parameters.AddWithValue("@AppointmentPreferredDayOfWeek", obj.AppointmentPreferredDayOfWeek);
            cmd.Parameters.AddWithValue("@AppointmentPreferredHourOfDay", obj.AppointmentPreferredHourOfDay);
            cmd.Parameters.AddWithValue("@Treatment18MonthValue_DI", obj.Treatment18MonthValueDi);
            cmd.Parameters.AddWithValue("@PATEXTIDTYPEID", obj.PatextidTypeId);
            cmd.Parameters.AddWithValue("@PATEXTIDTYPEDB", obj.PatextidTypeDb);
            cmd.Parameters.AddWithValue("@CONFIDENTIAL_STATE", obj.ConfidentialState);
            cmd.Parameters.AddWithValue("@MiddleName", obj.MiddleName);
            cmd.Parameters.AddWithValue("@ConfidentialCodeID", obj.ConfidentialCodeId);
            cmd.Parameters.AddWithValue("@ConfidentialCodeDB", obj.ConfidentialCodeDb);
            cmd.Parameters.AddWithValue("@OrganDonorCode", obj.OrganDonorCode);
            cmd.Parameters.AddWithValue("@VipCode", obj.VipCode);
            cmd.Parameters.AddWithValue("@SensitivityFlag", obj.SensitivityFlag);
            cmd.Parameters.AddWithValue("@BirthPlaceCountryID", obj.BirthPlaceCountryId);
            cmd.Parameters.AddWithValue("@BirthPlaceCountryDB", obj.BirthPlaceCountryDb);
            cmd.Parameters.AddWithValue("@MultipleBirthFlag", obj.MultipleBirthFlag);
            cmd.Parameters.AddWithValue("@MultipleBirthOrder", obj.MultipleBirthOrder);
            cmd.Parameters.AddWithValue("@DNACode", obj.DnaCode);
            cmd.Parameters.AddWithValue("@BloodTypeVerCode", obj.BloodTypeVerCode);
            cmd.Parameters.AddWithValue("@HOMEPHONE", obj.Homephone);
            cmd.Parameters.AddWithValue("@HOMEPHONEEXT", obj.Homephoneext);
            cmd.Parameters.AddWithValue("@WORKEMAIL", obj.Workemail);
            cmd.Parameters.AddWithValue("@OtherEthnicityId", obj.OtherEthnicityId);
            cmd.Parameters.AddWithValue("@NextOfKinID", obj.NextOfKinId);
            cmd.Parameters.AddWithValue("@NextOfKinDB", obj.NextOfKinDb);
            cmd.Parameters.AddWithValue("@EmergencyID", obj.EmergencyId);
            cmd.Parameters.AddWithValue("@EmergencyDB", obj.EmergencyDb);
            cmd.Parameters.AddWithValue("@GuardianID", obj.GuardianId);
            cmd.Parameters.AddWithValue("@GuardianDB", obj.GuardianDb);
            cmd.Parameters.AddWithValue("@SponsorID", obj.SponsorId);
            cmd.Parameters.AddWithValue("@SponsorDB", obj.SponsorDb);
            cmd.Parameters.AddWithValue("@CreationReasonID", obj.CreationReasonId);
            cmd.Parameters.AddWithValue("@DoDUpdateAuth", obj.DoDUpdateAuth);
            cmd.Parameters.AddWithValue("@DoDUpdateAuthText", obj.DoDUpdateAuthText);
            cmd.Parameters.AddWithValue("@PrInsSubRel", obj.PrInsSubRel);
            cmd.Parameters.AddWithValue("@ScInsSubRel", obj.ScInsSubRel);
            cmd.Parameters.AddWithValue("@TertInsSubRel", obj.TertInsSubRel);
            cmd.Parameters.AddWithValue("@QuatInsSubRel", obj.QuatInsSubRel);
            cmd.Parameters.AddWithValue("@PrMedInsSubRel", obj.PrMedInsSubRel);
            cmd.Parameters.AddWithValue("@ScMedInsSubRel", obj.ScMedInsSubRel);
            cmd.Parameters.AddWithValue("@InmateID", obj.InmateId);
            cmd.Parameters.AddWithValue("@InmateDB", obj.InmateDb);
            cmd.Parameters.AddWithValue("@FamExtID", obj.FamExtId);
            cmd.Parameters.AddWithValue("@OriginalPatId", obj.OriginalPatId);
            cmd.Parameters.AddWithValue("@OriginalPatDb", obj.OriginalPatDb);
            cmd.Parameters.AddWithValue("@Hygiene18MonthPerVisitAverage_di", obj.Hygiene18MonthPerVisitAverageDi);
            cmd.Parameters.AddWithValue("@OnPaymentPlan_di", obj.OnPaymentPlanDi);
            cmd.Parameters.AddWithValue("@PaymentCampaignDoNotSendDate_DI", obj.PaymentCampaignDoNotSendDateDi);
            cmd.Parameters.AddWithValue("@PaymentCampaignSnoozeUntil_DI", obj.PaymentCampaignSnoozeUntilDi);
            cmd.Parameters.AddWithValue("@PaymentCampaignSnoozeReason_DI", obj.PaymentCampaignSnoozeReasonDi);
            cmd.Parameters.AddWithValue("@LastPatientPaymentDate_DI", obj.LastPatientPaymentDateDi);
            cmd.Parameters.AddWithValue("@LastInsurancePaymentDate_DI", obj.LastInsurancePaymentDateDi);
            cmd.Parameters.AddWithValue("@PrimaryInsuranceLastDateClaimSent_DI", obj.PrimaryInsuranceLastDateClaimSentDi);
            cmd.Parameters.AddWithValue("@SecondaryInsuranceLastDateClaimSent_DI", obj.SecondaryInsuranceLastDateClaimSentDi);
            cmd.Parameters.AddWithValue("@PrimaryInsuranceNumOpenClaims_DI", obj.PrimaryInsuranceNumOpenClaimsDi);
            cmd.Parameters.AddWithValue("@SecondaryInsuranceNumOpenClaims_DI", obj.SecondaryInsuranceNumOpenClaimsDi);
            cmd.Parameters.AddWithValue("@PrimaryProviderId_di", obj.PrimaryProviderIdDi);
            cmd.Parameters.AddWithValue("@SecondaryProviderId_di", obj.SecondaryProviderIdDi);
            cmd.ExecuteNonQuery();
        }
            catch (Exception ex)
            {
                throw new Exception("Patient not inserted successfully. Error: " + ex.Message);
    }
}
    }
}
