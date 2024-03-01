using DXE_Utils.Interfaces;
using DXE_Utils.Models;
using Obj.Hydrator;
using Obj.Hydrator.Interfaces;
using System.Data.SqlClient;

namespace DXE_Utils.Servicces
{
    public class PatientSeervice(string connectionString) : IPatientSeervice
    {
        private readonly string connectionString = connectionString;

        public async Task InsertOnePatient()
        {
            try
            {
                DXEpatientgenerator dXEpatientgenerator = new();

                Hydrator<DDB_PAT_BASE> _customerHydrator = new Hydrator<DDB_PAT_BASE>()
                        .With(x => x, ((IGenerator<DDB_PAT_BASE>)dXEpatientgenerator).Generate());

                DDB_PAT_BASE customer = _customerHydrator.GetSingle();
                await InsertarDDBPatBase(customer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task InsertPatients(int Cuantity)
        {
            try
            {
                DXEpatientgenerator dXEpatientgenerator = new();

                Hydrator<DDB_PAT_BASE> _customerHydrator = new Hydrator<DDB_PAT_BASE>()
                        .With(x => x, ((IGenerator<DDB_PAT_BASE>)dXEpatientgenerator).Generate());

                List<DDB_PAT_BASE> customers = (List<DDB_PAT_BASE>)_customerHydrator.GetList(Cuantity);
                foreach (var customer in customers)
                    await InsertarDDBPatBase(customer);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async Task InsertarDDBPatBase(DDB_PAT_BASE obj)
        {
            try
            {
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
                await conn.OpenAsync();
                SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@PATID ", obj.PATID);
                cmd.Parameters.AddWithValue("@PATDB ", obj.PATDB);
                cmd.Parameters.AddWithValue("@FAMILYID ", obj.FAMILYID);
                cmd.Parameters.AddWithValue("@GUARID ", obj.GUARID);
                cmd.Parameters.AddWithValue("@GUARDB ", obj.GUARDB);
                cmd.Parameters.AddWithValue("@PRINSUREDID ", obj.PRINSUREDID);
                cmd.Parameters.AddWithValue("@PRINSUREDDB ", obj.PRINSUREDDB);
                cmd.Parameters.AddWithValue("@SCINSUREDID ", obj.SCINSUREDID);
                cmd.Parameters.AddWithValue("@SCINSUREDDB ", obj.SCINSUREDDB);
                cmd.Parameters.AddWithValue("@ADDRESSID ", obj.ADDRESSID);
                cmd.Parameters.AddWithValue("@ADDRESSDB ", obj.ADDRESSDB);
                cmd.Parameters.AddWithValue("@EMPID ", obj.EMPID);
                cmd.Parameters.AddWithValue("@EMPDB ", obj.EMPDB);
                cmd.Parameters.AddWithValue("@CLAIMINFID ", obj.CLAIMINFID);
                cmd.Parameters.AddWithValue("@CLAIMINFDB ", obj.CLAIMINFDB);
                cmd.Parameters.AddWithValue("@PRPROVID ", obj.PRPROVID);
                cmd.Parameters.AddWithValue("@PRPROVDB ", obj.PRPROVDB);
                cmd.Parameters.AddWithValue("@SCPROVID ", obj.SCPROVID);
                cmd.Parameters.AddWithValue("@SCPROVDB ", obj.SCPROVDB);
                cmd.Parameters.AddWithValue("@REFTOID ", obj.REFTOID);
                cmd.Parameters.AddWithValue("@REFTODB ", obj.REFTODB);
                cmd.Parameters.AddWithValue("@REFBYDOCID ", obj.REFBYDOCID);
                cmd.Parameters.AddWithValue("@REFBYDOCDB ", obj.REFBYDOCDB);
                cmd.Parameters.AddWithValue("@REFBYPATID ", obj.REFBYPATID);
                cmd.Parameters.AddWithValue("@REFBYPATDB ", obj.REFBYPATDB);
                cmd.Parameters.AddWithValue("@PRMEDINSID ", obj.PRMEDINSID);
                cmd.Parameters.AddWithValue("@PRMEDINSDB ", obj.PRMEDINSDB);
                cmd.Parameters.AddWithValue("@SCMEDINSID ", obj.SCMEDINSID);
                cmd.Parameters.AddWithValue("@SCMEDINSDB ", obj.SCMEDINSDB);
                cmd.Parameters.AddWithValue("@LASTNAME ", obj.LASTNAME);
                cmd.Parameters.AddWithValue("@FIRSTNAME ", obj.FIRSTNAME);
                cmd.Parameters.AddWithValue("@MI ", obj.MI);
                cmd.Parameters.AddWithValue("@PREFNAME ", obj.PREFNAME);
                cmd.Parameters.AddWithValue("@SALUTATION ", obj.SALUTATION);
                cmd.Parameters.AddWithValue("@WKEXT ", obj.WKEXT);
                cmd.Parameters.AddWithValue("@BESTTIME ", obj.BESTTIME);
                cmd.Parameters.AddWithValue("@CHART ", obj.CHART);
                cmd.Parameters.AddWithValue("@CHARTDB ", obj.CHARTDB);
                cmd.Parameters.AddWithValue("@SS ", obj.SS);
                cmd.Parameters.AddWithValue("@SSNDB ", obj.SSNDB);
                cmd.Parameters.AddWithValue("@GUARFLG ", obj.GUARFLG);
                cmd.Parameters.AddWithValue("@INSPFLG ", obj.INSPFLG);
                cmd.Parameters.AddWithValue("@HEADHFLG ", obj.HEADHFLG);
                cmd.Parameters.AddWithValue("@GENDER ", obj.GENDER);
                cmd.Parameters.AddWithValue("@STATUS ", obj.STATUS);
                cmd.Parameters.AddWithValue("@FAMPOS ", obj.FAMPOS);
                cmd.Parameters.AddWithValue("@PREMED ", obj.PREMED);
                cmd.Parameters.AddWithValue("@BIRTHDATE ", obj.BIRTHDATE);
                cmd.Parameters.AddWithValue("@FIRSTVISITDATE ", obj.FIRSTVISITDATE);
                cmd.Parameters.AddWithValue("@LASTVISITDATE ", obj.LASTVISITDATE);
                cmd.Parameters.AddWithValue("@REFTODATE ", obj.REFTODATE);
                cmd.Parameters.AddWithValue("@CONSENTDATE ", obj.CONSENTDATE);
                cmd.Parameters.AddWithValue("@PRINSREL ", obj.PRINSREL);
                cmd.Parameters.AddWithValue("@SCINSREL ", obj.SCINSREL);
                cmd.Parameters.AddWithValue("@PRBENEFITS ", obj.PRBENEFITS);
                cmd.Parameters.AddWithValue("@SCBENEFITS ", obj.SCBENEFITS);
                cmd.Parameters.AddWithValue("@WKPHONE ", obj.WKPHONE);
                cmd.Parameters.AddWithValue("@FEESCHFLAG ", obj.FEESCHFLAG);
                cmd.Parameters.AddWithValue("@MISSEDAPPT ", obj.MISSEDAPPT);
                cmd.Parameters.AddWithValue("@LASTMISSEDAPPT ", obj.LASTMISSEDAPPT);
                cmd.Parameters.AddWithValue("@TITLE ", obj.TITLE);
                cmd.Parameters.AddWithValue("@ID2 ", obj.ID2);
                cmd.Parameters.AddWithValue("@TITLEFLG ", obj.TITLEFLG);
                cmd.Parameters.AddWithValue("@EZDWPATID ", obj.EZDWPATID);
                cmd.Parameters.AddWithValue("@EMAILADDRESS ", obj.EMAILADDRESS);
                cmd.Parameters.AddWithValue("@DRIVERSLICENSE ", obj.DRIVERSLICENSE);
                cmd.Parameters.AddWithValue("@FAX ", obj.FAX);
                cmd.Parameters.AddWithValue("@PAGER ", obj.PAGER);
                cmd.Parameters.AddWithValue("@OTHERPHONE ", obj.OTHERPHONE);
                cmd.Parameters.AddWithValue("@PRDED ", obj.PRDED);
                cmd.Parameters.AddWithValue("@PRDED2 ", obj.PRDED2);
                cmd.Parameters.AddWithValue("@PRDED3 ", obj.PRDED3);
                cmd.Parameters.AddWithValue("@SCDED ", obj.SCDED);
                cmd.Parameters.AddWithValue("@SCDED2 ", obj.SCDED2);
                cmd.Parameters.AddWithValue("@SCDED3 ", obj.SCDED3);
                cmd.Parameters.AddWithValue("@PRDEDUCTLT ", obj.PRDEDUCTLT);
                cmd.Parameters.AddWithValue("@PRDEDUCTLT2 ", obj.PRDEDUCTLT2);
                cmd.Parameters.AddWithValue("@PRDEDUCTLT3 ", obj.PRDEDUCTLT3);
                cmd.Parameters.AddWithValue("@SCDEDUCTLT ", obj.SCDEDUCTLT);
                cmd.Parameters.AddWithValue("@SCDEDUCTLT2 ", obj.SCDEDUCTLT2);
                cmd.Parameters.AddWithValue("@SCDEDUCTLT3 ", obj.SCDEDUCTLT3);
                cmd.Parameters.AddWithValue("@MEDALERT ", obj.MEDALERT);
                cmd.Parameters.AddWithValue("@FEESCHEDID ", obj.FEESCHEDID);
                cmd.Parameters.AddWithValue("@FEESCHEDDB ", obj.FEESCHEDDB);
                cmd.Parameters.AddWithValue("@PRMEDINSREL ", obj.PRMEDINSREL);
                cmd.Parameters.AddWithValue("@SCMEDINSREL ", obj.SCMEDINSREL);
                cmd.Parameters.AddWithValue("@PrInsCDADepCode ", obj.PrInsCDADepCode);
                cmd.Parameters.AddWithValue("@ScInsCDADepCode ", obj.ScInsCDADepCode);
                cmd.Parameters.AddWithValue("@ConsultFlag ", obj.ConsultFlag);
                cmd.Parameters.AddWithValue("@TOAFlag ", obj.TOAFlag);
                cmd.Parameters.AddWithValue("@DefaultClinic ", obj.DefaultClinic);
                cmd.Parameters.AddWithValue("@OperatorID ", obj.OperatorID);
                cmd.Parameters.AddWithValue("@OperatorDB ", obj.OperatorDB);
                cmd.Parameters.AddWithValue("@UPLASTNAME ", obj.UPLASTNAME);
                cmd.Parameters.AddWithValue("@UPFIRSTNAME ", obj.UPFIRSTNAME);
                cmd.Parameters.AddWithValue("@UPCHART ", obj.UPCHART);
                cmd.Parameters.AddWithValue("@ACTIVE ", obj.ACTIVE);
                cmd.Parameters.AddWithValue("@PATALERT ", obj.PATALERT);
                cmd.Parameters.AddWithValue("@Suffix ", obj.Suffix);
                cmd.Parameters.AddWithValue("@CountyName ", obj.CountyName);
                cmd.Parameters.AddWithValue("@EmpStatus ", obj.EmpStatus);
                cmd.Parameters.AddWithValue("@Race ", obj.Race);
                cmd.Parameters.AddWithValue("@FamIncome ", obj.FamIncome);
                cmd.Parameters.AddWithValue("@ExternalStatus ", obj.ExternalStatus);
                cmd.Parameters.AddWithValue("@PatExtID ", obj.PatExtID);
                cmd.Parameters.AddWithValue("@GuarantorExtID ", obj.GuarantorExtID);
                cmd.Parameters.AddWithValue("@EntrySystem ", obj.EntrySystem);
                cmd.Parameters.AddWithValue("@EntryDateTime ", obj.EntryDateTime);
                cmd.Parameters.AddWithValue("@LastUpdateMethod ", obj.LastUpdateMethod);
                cmd.Parameters.AddWithValue("@LastUpdateSystem ", obj.LastUpdateSystem);
                cmd.Parameters.AddWithValue("@VisitNumber ", obj.VisitNumber);
                cmd.Parameters.AddWithValue("@PATIMAGEID ", obj.PATIMAGEID);
                cmd.Parameters.AddWithValue("@INITPROVID ", obj.INITPROVID);
                cmd.Parameters.AddWithValue("@INITPROVDB ", obj.INITPROVDB);
                cmd.Parameters.AddWithValue("@RELIGION ", obj.RELIGION);
                cmd.Parameters.AddWithValue("@RVUID ", obj.RVUID);
                cmd.Parameters.AddWithValue("@RVUDB ", obj.RVUDB);
                cmd.Parameters.AddWithValue("@MedHistoryViewDate ", obj.MedHistoryViewDate);
                cmd.Parameters.AddWithValue("@DDB_LAST_MOD ", obj.DDB_LAST_MOD);
                cmd.Parameters.AddWithValue("@PatClass ", obj.PatClass);
                cmd.Parameters.AddWithValue("@PatFacility ", obj.PatFacility);
                cmd.Parameters.AddWithValue("@PatAlias_LastName ", obj.PatAlias_LastName);
                cmd.Parameters.AddWithValue("@PatAlias_FirstName ", obj.PatAlias_FirstName);
                cmd.Parameters.AddWithValue("@PatAlias_MiddleName ", obj.PatAlias_MiddleName);
                cmd.Parameters.AddWithValue("@PatAlias_Suffix ", obj.PatAlias_Suffix);
                cmd.Parameters.AddWithValue("@PatAlias_Prefix ", obj.PatAlias_Prefix);
                cmd.Parameters.AddWithValue("@MotherMaiden_LName ", obj.MotherMaiden_LName);
                cmd.Parameters.AddWithValue("@MotherMaiden_FName ", obj.MotherMaiden_FName);
                cmd.Parameters.AddWithValue("@MotherMaiden_MName ", obj.MotherMaiden_MName);
                cmd.Parameters.AddWithValue("@MotherMaiden_Suffix ", obj.MotherMaiden_Suffix);
                cmd.Parameters.AddWithValue("@MotherMaiden_Prefix ", obj.MotherMaiden_Prefix);
                cmd.Parameters.AddWithValue("@PatientDeathDate ", obj.PatientDeathDate);
                cmd.Parameters.AddWithValue("@Language ", obj.Language);
                cmd.Parameters.AddWithValue("@PovertyLevel ", obj.PovertyLevel);
                cmd.Parameters.AddWithValue("@WorkerStatus ", obj.WorkerStatus);
                cmd.Parameters.AddWithValue("@HomelessStatus ", obj.HomelessStatus);
                cmd.Parameters.AddWithValue("@PrivacyFlags ", obj.PrivacyFlags);
                cmd.Parameters.AddWithValue("@PATCOPIED ", obj.PATCOPIED);
                cmd.Parameters.AddWithValue("@tempchart ", obj.tempchart);
                cmd.Parameters.AddWithValue("@Veteran ", obj.Veteran);
                cmd.Parameters.AddWithValue("@GUIDID ", obj.GUIDID);
                cmd.Parameters.AddWithValue("@TertDentInsuredID ", obj.TertDentInsuredID);
                cmd.Parameters.AddWithValue("@TertDentInsuredDB ", obj.TertDentInsuredDB);
                cmd.Parameters.AddWithValue("@QuatDentInsuredID ", obj.QuatDentInsuredID);
                cmd.Parameters.AddWithValue("@QuatDentInsuredDB ", obj.QuatDentInsuredDB);
                cmd.Parameters.AddWithValue("@TertInsRel ", obj.TertInsRel);
                cmd.Parameters.AddWithValue("@QuatInsRel ", obj.QuatInsRel);
                cmd.Parameters.AddWithValue("@TertInsCDADepCode ", obj.TertInsCDADepCode);
                cmd.Parameters.AddWithValue("@QuatInsCDADepCode ", obj.QuatInsCDADepCode);
                cmd.Parameters.AddWithValue("@OVERRIDEUSERID ", obj.OVERRIDEUSERID);
                cmd.Parameters.AddWithValue("@PermDescript ", obj.PermDescript);
                cmd.Parameters.AddWithValue("@EthnicityID ", obj.EthnicityID);
                cmd.Parameters.AddWithValue("@UDPatCatID ", obj.UDPatCatID);
                cmd.Parameters.AddWithValue("@ExtPatIDType ", obj.ExtPatIDType);
                cmd.Parameters.AddWithValue("@ExtGuarIDType ", obj.ExtGuarIDType);
                cmd.Parameters.AddWithValue("@PatExtID2 ", obj.PatExtID2);
                cmd.Parameters.AddWithValue("@ExtPatID2Type ", obj.ExtPatID2Type);
                cmd.Parameters.AddWithValue("@PatType ", obj.PatType);
                cmd.Parameters.AddWithValue("@AccountStatus ", obj.AccountStatus);
                cmd.Parameters.AddWithValue("@FinancialClassID ", obj.FinancialClassID);
                cmd.Parameters.AddWithValue("@PatAccountNumber ", obj.PatAccountNumber);
                cmd.Parameters.AddWithValue("@DeclinedEmail ", obj.DeclinedEmail);
                cmd.Parameters.AddWithValue("@CommunicationPref ", obj.CommunicationPref);
                cmd.Parameters.AddWithValue("@SmokingStatusID ", obj.SmokingStatusID);
                cmd.Parameters.AddWithValue("@SmokingStatusDB ", obj.SmokingStatusDB);
                cmd.Parameters.AddWithValue("@RxAutoRefill ", obj.RxAutoRefill);
                cmd.Parameters.AddWithValue("@OtherRace ", obj.OtherRace);
                cmd.Parameters.AddWithValue("@HousingStatus ", obj.HousingStatus);
                cmd.Parameters.AddWithValue("@FamSize ", obj.FamSize);
                cmd.Parameters.AddWithValue("@SexualOrientation ", obj.SexualOrientation);
                cmd.Parameters.AddWithValue("@GenderIdentity ", obj.GenderIdentity);
                cmd.Parameters.AddWithValue("@HohIncome ", obj.HohIncome);
                cmd.Parameters.AddWithValue("@IncomeRecurr ", obj.IncomeRecurr);
                cmd.Parameters.AddWithValue("@PracticeIdInt ", obj.PracticeIdInt);
                cmd.Parameters.AddWithValue("@LastUpdateTimestamp ", obj.LastUpdateTimestamp);
                cmd.Parameters.AddWithValue("@IsDeletedFromSource ", obj.IsDeletedFromSource);
                cmd.Parameters.AddWithValue("@MinProcDate_di ", obj.MinProcDate_di);
                cmd.Parameters.AddWithValue("@MaxProcDate_di ", obj.MaxProcDate_di);
                cmd.Parameters.AddWithValue("@LastPerioProc_di ", obj.LastPerioProc_di);
                cmd.Parameters.AddWithValue("@LastHygieneProc_di ", obj.LastHygieneProc_di);
                cmd.Parameters.AddWithValue("@PatientValue_0to6 ", obj.PatientValue_0to6);
                cmd.Parameters.AddWithValue("@PatientValue_7to12 ", obj.PatientValue_7to12);
                cmd.Parameters.AddWithValue("@PatientValue_13to18 ", obj.PatientValue_13to18);
                cmd.Parameters.AddWithValue("@PatientValue_19to24 ", obj.PatientValue_19to24);
                cmd.Parameters.AddWithValue("@PatientValue_25to30 ", obj.PatientValue_25to30);
                cmd.Parameters.AddWithValue("@PatientValue_31to36 ", obj.PatientValue_31to36);
                cmd.Parameters.AddWithValue("@UnScheduledTX ", obj.UnScheduledTX);
                cmd.Parameters.AddWithValue("@TotalTX ", obj.TotalTX);
                cmd.Parameters.AddWithValue("@NextHygieneAppt ", obj.NextHygieneAppt);
                cmd.Parameters.AddWithValue("@NextNonHygieneAppt ", obj.NextNonHygieneAppt);
                cmd.Parameters.AddWithValue("@StatusModifiedDate ", obj.StatusModifiedDate);
                cmd.Parameters.AddWithValue("@HygieneInterval_di ", obj.HygieneInterval_di);
                cmd.Parameters.AddWithValue("@PrimaryInsurance_DI ", obj.PrimaryInsurance_DI);
                cmd.Parameters.AddWithValue("@SecondaryInsurance_DI ", obj.SecondaryInsurance_DI);
                cmd.Parameters.AddWithValue("@RemainingInsurance_DI ", obj.RemainingInsurance_DI);
                cmd.Parameters.AddWithValue("@FirstPerioProc_DI ", obj.FirstPerioProc_DI);
                cmd.Parameters.AddWithValue("@NextRestorativeAppointment_DI ", obj.NextRestorativeAppointment_DI);
                cmd.Parameters.AddWithValue("@NextMiscAppointment_DI ", obj.NextMiscAppointment_DI);
                cmd.Parameters.AddWithValue("@RemainingPrimaryInsurance_DI ", obj.RemainingPrimaryInsurance_DI);
                cmd.Parameters.AddWithValue("@RemainingSecondaryInsurance_DI ", obj.RemainingSecondaryInsurance_DI);
                cmd.Parameters.AddWithValue("@Aging0To30_di ", obj.Aging0To30_di);
                cmd.Parameters.AddWithValue("@Aging31To60_di ", obj.Aging31To60_di);
                cmd.Parameters.AddWithValue("@Aging61To90_di ", obj.Aging61To90_di);
                cmd.Parameters.AddWithValue("@AgingPlus90_di ", obj.AgingPlus90_di);
                cmd.Parameters.AddWithValue("@TotalAging_di ", obj.TotalAging_di);
                cmd.Parameters.AddWithValue("@EstInsuranceAging_di ", obj.EstInsuranceAging_di);
                cmd.Parameters.AddWithValue("@EstPatientAging_di ", obj.EstPatientAging_di);
                cmd.Parameters.AddWithValue("@PrimaryProvider_DI ", obj.PrimaryProvider_DI);
                cmd.Parameters.AddWithValue("@SecondaryProvider_DI ", obj.SecondaryProvider_DI);
                cmd.Parameters.AddWithValue("@ReferralSource_DI ", obj.ReferralSource_DI);
                cmd.Parameters.AddWithValue("@NextHygieneApptIsOnQuickFill_DI ", obj.NextHygieneApptIsOnQuickFill_DI);
                cmd.Parameters.AddWithValue("@NextNonHygieneApptIsOnQuickFill_DI ", obj.NextNonHygieneApptIsOnQuickFill_DI);
                cmd.Parameters.AddWithValue("@NextRestorativeApptIsOnQuickFill_DI ", obj.NextRestorativeApptIsOnQuickFill_DI);
                cmd.Parameters.AddWithValue("@NextMiscApptIsOnQuickFill_DI ", obj.NextMiscApptIsOnQuickFill_DI);
                cmd.Parameters.AddWithValue("@FamilyMembersNotScheduled_DI ", obj.FamilyMembersNotScheduled_DI);
                cmd.Parameters.AddWithValue("@HygieneUnScheduledTX_DI ", obj.HygieneUnScheduledTX_DI);
                cmd.Parameters.AddWithValue("@RestorativeUnScheduledTX_DI ", obj.RestorativeUnScheduledTX_DI);
                cmd.Parameters.AddWithValue("@AppointmentCandidateWeightingRestorative_DI ", obj.AppointmentCandidateWeightingRestorative_DI);
                cmd.Parameters.AddWithValue("@AppointmentCandidateWeightingHygiene_DI ", obj.AppointmentCandidateWeightingHygiene_DI);
                cmd.Parameters.AddWithValue("@NextHygieneApptEndTime_DI ", obj.NextHygieneApptEndTime_DI);
                cmd.Parameters.AddWithValue("@NextNonHygieneApptEndTime_DI ", obj.NextNonHygieneApptEndTime_DI);
                cmd.Parameters.AddWithValue("@NextRestorativeAppointmentEndTime_DI ", obj.NextRestorativeAppointmentEndTime_DI);
                cmd.Parameters.AddWithValue("@NextMiscAppointmentEndTime_DI ", obj.NextMiscAppointmentEndTime_DI);
                cmd.Parameters.AddWithValue("@PatientIsOnUnscheduledQuickFill ", obj.PatientIsOnUnscheduledQuickFill);
                cmd.Parameters.AddWithValue("@FupHygieneRecareChanged_di ", obj.FupHygieneRecareChanged_di);
                cmd.Parameters.AddWithValue("@FupARChanged_di ", obj.FupARChanged_di);
                cmd.Parameters.AddWithValue("@LastMajorFilmProc_di ", obj.LastMajorFilmProc_di);
                cmd.Parameters.AddWithValue("@LastBiteWingProc_di ", obj.LastBiteWingProc_di);
                cmd.Parameters.AddWithValue("@LastPanoProc_di ", obj.LastPanoProc_di);
                cmd.Parameters.AddWithValue("@LastFmxProc_di ", obj.LastFmxProc_di);
                cmd.Parameters.AddWithValue("@UnScheduledTx0To30_DI ", obj.UnScheduledTx0To30_DI);
                cmd.Parameters.AddWithValue("@UnScheduledTx31To60_DI ", obj.UnScheduledTx31To60_DI);
                cmd.Parameters.AddWithValue("@UnScheduledTx61To90_DI ", obj.UnScheduledTx61To90_DI);
                cmd.Parameters.AddWithValue("@UnScheduledTxPlus90_DI ", obj.UnScheduledTxPlus90_DI);
                cmd.Parameters.AddWithValue("@RestorativeUnScheduledTx0To30_DI ", obj.RestorativeUnScheduledTx0To30_DI);
                cmd.Parameters.AddWithValue("@RestorativeUnScheduledTx31To60_DI ", obj.RestorativeUnScheduledTx31To60_DI);
                cmd.Parameters.AddWithValue("@RestorativeUnScheduledTx61To90_DI ", obj.RestorativeUnScheduledTx61To90_DI);
                cmd.Parameters.AddWithValue("@RestorativeUnScheduledTxPlus90_DI ", obj.RestorativeUnScheduledTxPlus90_DI);
                cmd.Parameters.AddWithValue("@HygieneUnScheduledTx0To30_DI ", obj.HygieneUnScheduledTx0To30_DI);
                cmd.Parameters.AddWithValue("@HygieneUnScheduledTx31To60_DI ", obj.HygieneUnScheduledTx31To60_DI);
                cmd.Parameters.AddWithValue("@HygieneUnScheduledTx61To90_DI ", obj.HygieneUnScheduledTx61To90_DI);
                cmd.Parameters.AddWithValue("@HygieneUnScheduledTxPlus90_DI ", obj.HygieneUnScheduledTxPlus90_DI);
                cmd.Parameters.AddWithValue("@TreatmentLifetimeValue_di ", obj.TreatmentLifetimeValue_di);
                cmd.Parameters.AddWithValue("@BrokenAppointmentCount_DI ", obj.BrokenAppointmentCount_DI);
                cmd.Parameters.AddWithValue("@CompletedAppointmentCount_DI ", obj.CompletedAppointmentCount_DI);
                cmd.Parameters.AddWithValue("@NumberPatientsReferred_DI ", obj.NumberPatientsReferred_DI);
                cmd.Parameters.AddWithValue("@AppointmentCandidateSnoozeTime_DI ", obj.AppointmentCandidateSnoozeTime_DI);
                cmd.Parameters.AddWithValue("@AppointmentCandidateSnoozeHours_DI ", obj.AppointmentCandidateSnoozeHours_DI);
                cmd.Parameters.AddWithValue("@AppointmentCandidateContactedTime_DI ", obj.AppointmentCandidateContactedTime_DI);
                cmd.Parameters.AddWithValue("@AppointmentCandidateContactedHours_DI ", obj.AppointmentCandidateContactedHours_DI);
                cmd.Parameters.AddWithValue("@AppointmentPreferredDayOfWeek ", obj.AppointmentPreferredDayOfWeek);
                cmd.Parameters.AddWithValue("@AppointmentPreferredHourOfDay ", obj.AppointmentPreferredHourOfDay);
                cmd.Parameters.AddWithValue("@Treatment18MonthValue_DI ", obj.Treatment18MonthValue_DI);
                cmd.Parameters.AddWithValue("@PATEXTIDTYPEID ", obj.PATEXTIDTYPEID);
                cmd.Parameters.AddWithValue("@PATEXTIDTYPEDB ", obj.PATEXTIDTYPEDB);
                cmd.Parameters.AddWithValue("@CONFIDENTIAL_STATE ", obj.CONFIDENTIAL_STATE);
                cmd.Parameters.AddWithValue("@MiddleName ", obj.MiddleName);
                cmd.Parameters.AddWithValue("@ConfidentialCodeID ", obj.ConfidentialCodeID);
                cmd.Parameters.AddWithValue("@ConfidentialCodeDB ", obj.ConfidentialCodeDB);
                cmd.Parameters.AddWithValue("@OrganDonorCode ", obj.OrganDonorCode);
                cmd.Parameters.AddWithValue("@VipCode ", obj.VipCode);
                cmd.Parameters.AddWithValue("@SensitivityFlag ", obj.SensitivityFlag);
                cmd.Parameters.AddWithValue("@BirthPlaceCountryID ", obj.BirthPlaceCountryID);
                cmd.Parameters.AddWithValue("@BirthPlaceCountryDB ", obj.BirthPlaceCountryDB);
                cmd.Parameters.AddWithValue("@MultipleBirthFlag ", obj.MultipleBirthFlag);
                cmd.Parameters.AddWithValue("@MultipleBirthOrder ", obj.MultipleBirthOrder);
                cmd.Parameters.AddWithValue("@DNACode ", obj.DNACode);
                cmd.Parameters.AddWithValue("@BloodTypeVerCode ", obj.BloodTypeVerCode);
                cmd.Parameters.AddWithValue("@HOMEPHONE ", obj.HOMEPHONE);
                cmd.Parameters.AddWithValue("@HOMEPHONEEXT ", obj.HOMEPHONEEXT);
                cmd.Parameters.AddWithValue("@WORKEMAIL ", obj.WORKEMAIL);
                cmd.Parameters.AddWithValue("@OtherEthnicityId ", obj.OtherEthnicityId);
                cmd.Parameters.AddWithValue("@NextOfKinID ", obj.NextOfKinID);
                cmd.Parameters.AddWithValue("@NextOfKinDB ", obj.NextOfKinDB);
                cmd.Parameters.AddWithValue("@EmergencyID ", obj.EmergencyID);
                cmd.Parameters.AddWithValue("@EmergencyDB ", obj.EmergencyDB);
                cmd.Parameters.AddWithValue("@GuardianID ", obj.GuardianID);
                cmd.Parameters.AddWithValue("@GuardianDB ", obj.GuardianDB);
                cmd.Parameters.AddWithValue("@SponsorID ", obj.SponsorID);
                cmd.Parameters.AddWithValue("@SponsorDB ", obj.SponsorDB);
                cmd.Parameters.AddWithValue("@CreationReasonID ", obj.CreationReasonID);
                cmd.Parameters.AddWithValue("@DoDUpdateAuth ", obj.DoDUpdateAuth);
                cmd.Parameters.AddWithValue("@DoDUpdateAuthText ", obj.DoDUpdateAuthText);
                cmd.Parameters.AddWithValue("@PrInsSubRel ", obj.PrInsSubRel);
                cmd.Parameters.AddWithValue("@ScInsSubRel ", obj.ScInsSubRel);
                cmd.Parameters.AddWithValue("@TertInsSubRel ", obj.TertInsSubRel);
                cmd.Parameters.AddWithValue("@QuatInsSubRel ", obj.QuatInsSubRel);
                cmd.Parameters.AddWithValue("@PrMedInsSubRel ", obj.PrMedInsSubRel);
                cmd.Parameters.AddWithValue("@ScMedInsSubRel ", obj.ScMedInsSubRel);
                cmd.Parameters.AddWithValue("@InmateID ", obj.InmateID);
                cmd.Parameters.AddWithValue("@InmateDB ", obj.InmateDB);
                cmd.Parameters.AddWithValue("@FamExtID ", obj.FamExtID);
                cmd.Parameters.AddWithValue("@OriginalPatId ", obj.OriginalPatId);
                cmd.Parameters.AddWithValue("@OriginalPatDb ", obj.OriginalPatDb);
                cmd.Parameters.AddWithValue("@Hygiene18MonthPerVisitAverage_di ", obj.Hygiene18MonthPerVisitAverage_di);
                cmd.Parameters.AddWithValue("@OnPaymentPlan_di ", obj.OnPaymentPlan_di);
                cmd.Parameters.AddWithValue("@PaymentCampaignDoNotSendDate_DI ", obj.PaymentCampaignDoNotSendDate_DI);
                cmd.Parameters.AddWithValue("@PaymentCampaignSnoozeUntil_DI ", obj.PaymentCampaignSnoozeUntil_DI);
                cmd.Parameters.AddWithValue("@PaymentCampaignSnoozeReason_DI ", obj.PaymentCampaignSnoozeReason_DI);
                cmd.Parameters.AddWithValue("@LastPatientPaymentDate_DI ", obj.LastPatientPaymentDate_DI);
                cmd.Parameters.AddWithValue("@LastInsurancePaymentDate_DI ", obj.LastInsurancePaymentDate_DI);
                cmd.Parameters.AddWithValue("@PrimaryInsuranceLastDateClaimSent_DI ", obj.PrimaryInsuranceLastDateClaimSent_DI);
                cmd.Parameters.AddWithValue("@SecondaryInsuranceLastDateClaimSent_DI ", obj.SecondaryInsuranceLastDateClaimSent_DI);
                cmd.Parameters.AddWithValue("@PrimaryInsuranceNumOpenClaims_DI ", obj.PrimaryInsuranceNumOpenClaims_DI);
                cmd.Parameters.AddWithValue("@SecondaryInsuranceNumOpenClaims_DI ", obj.SecondaryInsuranceNumOpenClaims_DI);
                cmd.Parameters.AddWithValue("@PrimaryProviderId_di ", obj.PrimaryProviderId_di);
                cmd.Parameters.AddWithValue("@SecondaryProviderId_di ", obj.SecondaryProviderId_di);

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
