using System;
using SQLite;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Envelope_Internal.Indigent.Models
{

    public class Rating
    {
    }

    public class FoodDetail
    {
        public Rating rating { get; set; }
    }

    public class Rating2
    {
    }

    public class ClothingDetail
    {
        public Rating2 rating { get; set; }
    }

    public class Rating3
    {
    }

    public class MedicalDetail
    {
        public Rating3 rating { get; set; }
    }

    public class Rating4
    {
    }

    public class ShelterDetail
    {
        public Rating4 rating { get; set; }
    }

    public class ConditionsDetail
    {
        public FoodDetail foodDetail { get; set; }
        public ClothingDetail clothingDetail { get; set; }
        public MedicalDetail medicalDetail { get; set; }
        public ShelterDetail shelterDetail { get; set; }
    }

    public class PersonDetail
    {
        public string gender { get; set; }
        public string surname { get; set; }
        public string initials { get; set; }
        public string genderDisplay { get; set; }
        public string personID { get; set; }
        public string firstNames { get; set; }
        public string title { get; set; }
        public string relationship { get; set; }
        public string titleDisplay { get; set; }
        public string idNo { get; set; }
        public string birthDate { get; set; }
    }

    public class BudgetDetail
    {
        public string otherIncome { get; set; }
        public string totalPersonIncome { get; set; }
        public string accountHolder { get; set; }
        public string propertyRenting { get; set; }
        public string uif { get; set; }
        public string previousWorkPension { get; set; }
        public string homeBusiness { get; set; }
        public string oldAgePension { get; set; }
        public string disabilityPension { get; set; }
    }

    public class IncomeDetail
    {
        public string amount { get; set; }
        public BudgetDetail budgetDetail { get; set; }
    }

    public class SkillDetail
    {
    }

    public class SkillCurrentDetail
    {
        public SkillDetail skillDetail { get; set; }
    }

    public class EmploymentDetail
    {
    }

    public class SkillDetail2
    {
    }

    public class SkillDesiredDetail
    {
        public SkillDetail2 skillDetail { get; set; }
    }

    public class WorkSituationDetail
    {
        public SkillCurrentDetail skillCurrentDetail { get; set; }
        public EmploymentDetail employmentDetail { get; set; }
        public SkillDesiredDetail skillDesiredDetail { get; set; }
        public string workDuration { get; set; }
    }

    public class HealthDetail
    {
        public string mentalDefect { get; set; }
        public string disability { get; set; }
        public string poorHealthDetails { get; set; }
    }

    public class HouseholdDetail
    {
        public string currentApplicationRefNo { get; set; }
        public PersonDetail personDetail { get; set; }
        public IncomeDetail incomeDetail { get; set; }
        public WorkSituationDetail workSituationDetail { get; set; }
        public HealthDetail healthDetail { get; set; }
    }

    public class FinanceDetail
    {
    }

    public class AssessmentCommiteeDecision
    {
        public string healthIndigentClerk { get; set; }
        public string financeClerk { get; set; }
        public string wardCouncillor { get; set; }
    }

    public class AppActivity
    {
        public AssessmentCommiteeDecision assessmentCommiteeDecision { get; set; }
    }

    public class IndigentApplicationHeader
    {
        public string debtorKind { get; set; }
        public FinanceDetail financeDetail { get; set; }
        public string applicationType { get; set; }
        public string applicationState { get; set; }
        public string applicationRefNo { get; set; }
        public string emmAccountNo { get; set; }
        public AppActivity appActivity { get; set; }
        public string applicationStatus { get; set; }
        public string applicantKind { get; set; }
        public string applicationCCC { get; set; }
        public string applicationCCA { get; set; }
        public string personID { get; set; }
        public string erfNo { get; set; }
        public string applicationDate { get; set; }
    }

    public class HouseholdExpenditureDetail
    {
        public string medical { get; set; }
        public string other { get; set; }
        public string education { get; set; }
        public string bondPayment { get; set; }
        public string electricity { get; set; }
        public string transport { get; set; }
        public string water { get; set; }
        public string food { get; set; }
        public string rental { get; set; }
    }

    public class PersonDetail2
    {
        public string gender { get; set; }
        public string surname { get; set; }
        public string initials { get; set; }
        public string personID { get; set; }
        public string firstNames { get; set; }
        public string title { get; set; }
        public string idNo { get; set; }
        public string birthDate { get; set; }
        public string maritalStatus { get; set; }
    }

    public class ContactDetail
    {
        public string preferredEmail { get; set; }
        public string preferredSMS { get; set; }
        public string preferredPost { get; set; }
    }

    public class PostalAddress
    {
        public string wardNo { get; set; }
        public string town { get; set; }
        public string postalCode { get; set; }
        public string addressLine1 { get; set; }
        public string suburb { get; set; }
        public string addressLine2 { get; set; }
        public string addressID { get; set; }
    }

    public class ResidentialAddress
    {
        public string wardNo { get; set; }
        public string addressLine1 { get; set; }
        public string suburb { get; set; }
        public string addressLine2 { get; set; }
        public string addressID { get; set; }
    }

    public class ElectricityAppliances
    {
        public string WashingMachine { get; set; }
        public string Heaters { get; set; }
        public string TV { get; set; }
        public string Cooking { get; set; }
        public string Vaccuming { get; set; }
        public string Lights { get; set; }
        public string Geyser { get; set; }
        public string Radio { get; set; }
    }

    public class ServicesKind
    {
        public ElectricityAppliances electricityAppliances { get; set; }
    }

    public class ResidentialDetail
    {
        public string outerSpace { get; set; }
        public string ownership { get; set; }
        public string innerSpace { get; set; }
        public string propertyKind { get; set; }
        public ServicesKind servicesKind { get; set; }
    }

    public class OriginalApplicantDetail
    {
        public PersonDetail2 personDetail { get; set; }
        public ContactDetail contactDetail { get; set; }
        public PostalAddress postalAddress { get; set; }
        public ResidentialAddress residentialAddress { get; set; }
        public ResidentialDetail residentialDetail { get; set; }
    }

    public class IndigentApplicationDetails
    {
        public ConditionsDetail conditionsDetail { get; set; }
        public List<HouseholdDetail> householdDetail { get; set; }
        public List<string> pdfImageNameList { get; set; }
        public List<List<object>> imageListBytes { get; set; }
        public IndigentApplicationHeader indigentApplicationHeader { get; set; }
        public HouseholdExpenditureDetail householdExpenditureDetail { get; set; }
        public string indigentOffice { get; set; }
        public OriginalApplicantDetail originalApplicantDetail { get; set; }
        public string fieldWorkerArea { get; set; }
        public string fieldWorkerWardNo { get; set; }
        public List<string> pdfImageList { get; set; }
    }

    public class Indigents
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string _id { get; set; }
        public IndigentApplicationDetails indigentApplicationDetails { get; set; }
        public string fieldWorkerID { get; set; }
        public string status { get; set; }

    }
}
