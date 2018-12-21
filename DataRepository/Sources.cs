using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

    namespace DataRepository
{
        public partial class RootObject
        {
            [JsonProperty("versionFamiliesById")]
            public Dictionary<string, VersionFamiliesById> VersionFamiliesById { get; set; }

            [JsonProperty("worksById")]
            public Dictionary<string, WorksById> WorksById { get; set; }

            [JsonProperty("doisById")]
            public Dictionary<string, DoisById[]> DoisById { get; set; }

            [JsonProperty("vectorsByName")]
            public Dictionary<string, VectorsByName[]> VectorsByName { get; set; }
        }

        public partial class DoisById
        {
            [JsonProperty("openaccess")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Openaccess { get; set; }

            [JsonProperty("contenttype")]
            public Contenttype Contenttype { get; set; }

            [JsonProperty("normalized-srctitle")]
            public NormalizedSrctitle NormalizedSrctitle { get; set; }

            [JsonProperty("srctitle-sort")]
            public string SrctitleSort { get; set; }

            [JsonProperty("datesort-first")]
            public DateTimeOffset DatesortFirst { get; set; }

            [JsonProperty("srctitlenorm")]
            public NormalizedSrctitle Srctitlenorm { get; set; }

            [JsonProperty("copyright")]
            public string Copyright { get; set; }

            [JsonProperty("isbnnorm")]
            public string Isbnnorm { get; set; }

            [JsonProperty("content")]
            [JsonConverter(typeof(DecodeArrayConverter))]
            public long[] Content { get; set; }

            [JsonProperty("pg")]
            public string[] Pg { get; set; }

            [JsonProperty("isbnsnorm")]
            public string[] Isbnsnorm { get; set; }

            [JsonProperty("yearnav-facet")]
            public long[] YearnavFacet { get; set; }

            [JsonProperty("articleinfo")]
            public string Articleinfo { get; set; }

            [JsonProperty("tomb_d")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long TombD { get; set; }

            [JsonProperty("itemtransactionid")]
            public DateTimeOffset Itemtransactionid { get; set; }

            [JsonProperty("alllist")]
            [JsonConverter(typeof(DecodeArrayConverter))]
            public long[] Alllist { get; set; }

            [JsonProperty("isbn")]
            public Isbn Isbn { get; set; }

            [JsonProperty("pubdateend")]
            public DateTimeOffset Pubdateend { get; set; }

            [JsonProperty("doinorm")]
            public string Doinorm { get; set; }

            [JsonProperty("srctitle")]
            public string[] Srctitle { get; set; }

            [JsonProperty("itemstage")]
            public Itemstage Itemstage { get; set; }

            [JsonProperty("sortorder")]
            public long Sortorder { get; set; }

            [JsonProperty("openarchive")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Openarchive { get; set; }

            [JsonProperty("datesearch")]
            [JsonConverter(typeof(DecodeArrayConverter))]
            public long[] Datesearch { get; set; }

            [JsonProperty("buildid")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Buildid { get; set; }

            [JsonProperty("datesort_t")]
            public DateTimeOffset DatesortT { get; set; }

            [JsonProperty("doi")]
            public string Doi { get; set; }

            [JsonProperty("pgfirst")]
            public string Pgfirst { get; set; }

            [JsonProperty("ewtransactionid")]
            public DateTimeOffset Ewtransactionid { get; set; }

            [JsonProperty("edition", NullValueHandling = NullValueHandling.Ignore)]
            public string Edition { get; set; }

            [JsonProperty("itemweight")]
            public Itemweight Itemweight { get; set; }

            [JsonProperty("dateupdated")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Dateupdated { get; set; }

            [JsonProperty("dateloaded")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Dateloaded { get; set; }

            [JsonProperty("type")]
            public DoctypeEnum Type { get; set; }

            [JsonProperty("piinorm")]
            public string Piinorm { get; set; }

            [JsonProperty("pubyr")]
            public long[] Pubyr { get; set; }

            [JsonProperty("docvector")]
            public string[] Docvector { get; set; }

            [JsonProperty("isbns")]
            public Isbn[] Isbns { get; set; }

            [JsonProperty("docsubtype")]
            public string Docsubtype { get; set; }

            [JsonProperty("webpdfpagecount")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Webpdfpagecount { get; set; }

            [JsonProperty("cid")]
            public long Cid { get; set; }

            [JsonProperty("datesortdays")]
            public long Datesortdays { get; set; }

            [JsonProperty("pubdatestart")]
            public DateTimeOffset Pubdatestart { get; set; }

            [JsonProperty("doctype")]
            public DoctypeEnum Doctype { get; set; }

            [JsonProperty("eid")]
            public string Eid { get; set; }

            [JsonProperty("subj")]
            [JsonConverter(typeof(DecodeArrayConverter))]
            public long[] Subj { get; set; }

            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("ssids")]
            public string Ssids { get; set; }

            [JsonProperty("webpdf")]
            public string[] Webpdf { get; set; }

            [JsonProperty("yearnav")]
            public long[] Yearnav { get; set; }

            [JsonProperty("hubeid")]
            public Hubeid Hubeid { get; set; }

            [JsonProperty("cids")]
            public long[] Cids { get; set; }

            [JsonProperty("pubdatetxt")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Pubdatetxt { get; set; }

            [JsonProperty("pii")]
            public string Pii { get; set; }

            [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Topics { get; set; }

            [JsonProperty("dco")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Dco { get; set; }

            [JsonProperty("confeditor")]
            public string[] Confeditor { get; set; }

            [JsonProperty("indextype", NullValueHandling = NullValueHandling.Ignore)]
            public Indextype[] Indextype { get; set; }

            [JsonProperty("filename")]
            public string Filename { get; set; }

            [JsonProperty("articletitle")]
            public string[] Articletitle { get; set; }

            [JsonProperty("indexeddate")]
            public long Indexeddate { get; set; }

            [JsonProperty("datesort")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long Datesort { get; set; }

            [JsonProperty("srctype")]
            public Srctype Srctype { get; set; }

            [JsonProperty("articletitlenorm")]
            public string Articletitlenorm { get; set; }

            [JsonProperty("_version_")]
            public double Version { get; set; }

            [JsonProperty("solrindextime")]
            public DateTimeOffset Solrindextime { get; set; }

            [JsonProperty("vectors")]
            public string[] Vectors { get; set; }

            [JsonProperty("affiliation", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Affiliation { get; set; }

            [JsonProperty("fullname", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Fullname { get; set; }

            [JsonProperty("auth", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Auth { get; set; }

            [JsonProperty("lastname", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Lastname { get; set; }

            [JsonProperty("firstname", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Firstname { get; set; }

            [JsonProperty("pglast", NullValueHandling = NullValueHandling.Ignore)]
            public string Pglast { get; set; }

            [JsonProperty("authfull", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Authfull { get; set; }

            [JsonProperty("sauth", NullValueHandling = NullValueHandling.Ignore)]
            public string Sauth { get; set; }

            [JsonProperty("saffil", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Saffil { get; set; }

            [JsonProperty("authfirstsurnamenorm", NullValueHandling = NullValueHandling.Ignore)]
            public string Authfirstsurnamenorm { get; set; }

            [JsonProperty("authfirstinitialnorm", NullValueHandling = NullValueHandling.Ignore)]
            public string Authfirstinitialnorm { get; set; }

            [JsonProperty("authnames", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Authnames { get; set; }

            [JsonProperty("fullnamespan", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Fullnamespan { get; set; }

            [JsonProperty("sectiontitle", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Sectiontitle { get; set; }

            [JsonProperty("primabst", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Primabst { get; set; }

            [JsonProperty("crossmark", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Crossmark { get; set; }

            [JsonProperty("issnnorm", NullValueHandling = NullValueHandling.Ignore)]
            public string Issnnorm { get; set; }

            [JsonProperty("issn", NullValueHandling = NullValueHandling.Ignore)]
            public Issn? Issn { get; set; }

            [JsonProperty("volfirst", NullValueHandling = NullValueHandling.Ignore)]
            public long? Volfirst { get; set; }

            [JsonProperty("volissue", NullValueHandling = NullValueHandling.Ignore)]
            public Volissue? Volissue { get; set; }

            [JsonProperty("volumelist", NullValueHandling = NullValueHandling.Ignore)]
            public long[] Volumelist { get; set; }

            [JsonProperty("vol", NullValueHandling = NullValueHandling.Ignore)]
            public string[] Vol { get; set; }
        }

        public partial class VectorsByName
        {
            [JsonProperty("$type")]
            public TypeEnum Type { get; set; }

            [JsonProperty("value")]
            public string Value { get; set; }
        }

        public partial class VersionFamiliesById
        {
            [JsonProperty("1", NullValueHandling = NullValueHandling.Ignore)]
            public VectorsByName[] The1 { get; set; }

            [JsonProperty("vectors", NullValueHandling = NullValueHandling.Ignore)]
            public Dictionary<string, double> Vectors { get; set; }

            [JsonProperty("4", NullValueHandling = NullValueHandling.Ignore)]
            public VectorsByName[] The4 { get; set; }
        }

        public partial class WorksById
        {
            [JsonProperty("NotificationType")]
            public string NotificationType { get; set; }

            [JsonProperty("ProductIdentifier")]
            public ProductIdentifier[] ProductIdentifier { get; set; }

            [JsonProperty("Barcode")]
            public string Barcode { get; set; }

            [JsonProperty("ProductForm")]
            public ProductForm ProductForm { get; set; }

            [JsonProperty("Title")]
            public Title Title { get; set; }

            [JsonProperty("Contributor")]
            public ContributorUnion Contributor { get; set; }

            [JsonProperty("Language")]
            public Language Language { get; set; }

            [JsonProperty("AudienceCode")]
            public string AudienceCode { get; set; }

            [JsonProperty("Imprint")]
            public Imprint Imprint { get; set; }

            [JsonProperty("Publisher")]
            public Publisher Publisher { get; set; }

            [JsonProperty("CountryOfPublication")]
            public CountryOfPublication CountryOfPublication { get; set; }

            [JsonProperty("PublishingStatus")]
            public string PublishingStatus { get; set; }

            [JsonProperty("PublicationDate", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? PublicationDate { get; set; }

            [JsonProperty("SalesRights")]
            public SalesRights SalesRights { get; set; }

            [JsonProperty("SupplyDetail")]
            public SupplyDetail SupplyDetail { get; set; }

            [JsonProperty("PpmData")]
            public PpmData PpmData { get; set; }

            [JsonProperty("chapters")]
            public ChapterElement[] Chapters { get; set; }

            [JsonProperty("Series", NullValueHandling = NullValueHandling.Ignore)]
            public Series Series { get; set; }

            [JsonProperty("BASICMainSubject", NullValueHandling = NullValueHandling.Ignore)]
            public string BasicMainSubject { get; set; }

            [JsonProperty("CopyrightStatement", NullValueHandling = NullValueHandling.Ignore)]
            public CopyrightStatement CopyrightStatement { get; set; }

            [JsonProperty("RelatedProduct", NullValueHandling = NullValueHandling.Ignore)]
            public RelatedProduct RelatedProduct { get; set; }

            [JsonProperty("vectors", NullValueHandling = NullValueHandling.Ignore)]
            public Dictionary<string, double> Vectors { get; set; }

            [JsonProperty("NumberOfPages", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? NumberOfPages { get; set; }

            [JsonProperty("Subject", NullValueHandling = NullValueHandling.Ignore)]
            public Subject Subject { get; set; }

            [JsonProperty("OtherText", NullValueHandling = NullValueHandling.Ignore)]
            public OtherText OtherText { get; set; }
        }

        public partial class ContributorElement
        {
            [JsonProperty("ContributorRole")]
            public ContributorRole ContributorRole { get; set; }

            [JsonProperty("NamesBeforeKey")]
            public string NamesBeforeKey { get; set; }

            [JsonProperty("KeyNames")]
            public string KeyNames { get; set; }
        }

        public partial class PurpleContributor
        {
            [JsonProperty("ContributorRole")]
            public ContributorRole ContributorRole { get; set; }

            [JsonProperty("NamesBeforeKey", NullValueHandling = NullValueHandling.Ignore)]
            public string NamesBeforeKey { get; set; }

            [JsonProperty("KeyNames")]
            public string KeyNames { get; set; }

            [JsonProperty("LettersAfterNames", NullValueHandling = NullValueHandling.Ignore)]
            public string LettersAfterNames { get; set; }

            [JsonProperty("ProfessionalAffiliation", NullValueHandling = NullValueHandling.Ignore)]
            public ProfessionalAffiliation ProfessionalAffiliation { get; set; }
        }

        public partial class ProfessionalAffiliation
        {
            [JsonProperty("Affiliation")]
            public string Affiliation { get; set; }
        }

        public partial class CopyrightStatement
        {
            [JsonProperty("CopyrightYear")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long CopyrightYear { get; set; }

            [JsonProperty("CopyrightOwner")]
            public CopyrightOwner CopyrightOwner { get; set; }
        }

        public partial class CopyrightOwner
        {
            [JsonProperty("CopyrightOwnerIdentifier")]
            public CopyrightOwnerIdentifier CopyrightOwnerIdentifier { get; set; }
        }

        public partial class CopyrightOwnerIdentifier
        {
            [JsonProperty("CopyrightOwnerIDType")]
            public string CopyrightOwnerIdType { get; set; }

            [JsonProperty("IDValue")]
            public PublisherName IdValue { get; set; }
        }

        public partial class Imprint
        {
            [JsonProperty("NameCodeType")]
            public string NameCodeType { get; set; }

            [JsonProperty("NameCodeValue")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long NameCodeValue { get; set; }

            [JsonProperty("ImprintName")]
            public string ImprintName { get; set; }
        }

        public partial class Language
        {
            [JsonProperty("LanguageRole")]
            public string LanguageRole { get; set; }

            [JsonProperty("LanguageCode")]
            public LanguageCode LanguageCode { get; set; }
        }

        public partial class OtherText
        {
            [JsonProperty("TextTypeCode")]
            public string TextTypeCode { get; set; }

            [JsonProperty("Text")]
            public string Text { get; set; }
        }

        public partial class PpmData
        {
            [JsonProperty("PMC")]
            public string Pmc { get; set; }

            [JsonProperty("ExportToOBS")]
            public ExportToObs ExportToObs { get; set; }

            [JsonProperty("ExportToWEB")]
            public ExportToObs ExportToWeb { get; set; }

            [JsonProperty("NotAvailForSale")]
            public ExportToObs NotAvailForSale { get; set; }

            [JsonProperty("NonSalableAncillary")]
            public ExportToObs NonSalableAncillary { get; set; }

            [JsonProperty("ContractOrigin")]
            public ContractOrigin ContractOrigin { get; set; }

            [JsonProperty("Cover")]
            public Cover Cover { get; set; }

            [JsonProperty("SeriesCode", NullValueHandling = NullValueHandling.Ignore)]
            public SeriesCodeUnion? SeriesCode { get; set; }

            [JsonProperty("SeriesTitle", NullValueHandling = NullValueHandling.Ignore)]
            public string SeriesTitle { get; set; }

            [JsonProperty("TextRefTrade", NullValueHandling = NullValueHandling.Ignore)]
            public TextRefTrade? TextRefTrade { get; set; }

            [JsonProperty("ProductType", NullValueHandling = NullValueHandling.Ignore)]
            public ProductType? ProductType { get; set; }

            [JsonProperty("ProductClass", NullValueHandling = NullValueHandling.Ignore)]
            public ProductClass? ProductClass { get; set; }

            [JsonProperty("PagesArabic", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? PagesArabic { get; set; }

            [JsonProperty("DiscountUS", NullValueHandling = NullValueHandling.Ignore)]
            public DiscountUs? DiscountUs { get; set; }

            [JsonProperty("DiscountUK", NullValueHandling = NullValueHandling.Ignore)]
            public DiscountUk? DiscountUk { get; set; }

            [JsonProperty("StatusUK", NullValueHandling = NullValueHandling.Ignore)]
            public StatusU? StatusUk { get; set; }

            [JsonProperty("PROMIS", NullValueHandling = NullValueHandling.Ignore)]
            public string Promis { get; set; }

            [JsonProperty("MarketRestrictions", NullValueHandling = NullValueHandling.Ignore)]
            public string MarketRestrictions { get; set; }

            [JsonProperty("CartonQuantity", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? CartonQuantity { get; set; }

            [JsonProperty("Weight", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? Weight { get; set; }

            [JsonProperty("StatusUS", NullValueHandling = NullValueHandling.Ignore)]
            public StatusU? StatusUs { get; set; }
        }

        public partial class SeriesCodeClass
        {
        }

        public partial class ProductIdentifier
        {
            [JsonProperty("ProductIDType")]
            public string ProductIdType { get; set; }

            [JsonProperty("IDValue")]
            public string IdValue { get; set; }
        }

        public partial class Publisher
        {
            [JsonProperty("PublisherName")]
            public PublisherName PublisherName { get; set; }
        }

        public partial class RelatedProduct
        {
            [JsonProperty("RelationCode")]
            public string RelationCode { get; set; }

            [JsonProperty("ProductIdentifier")]
            public ProductIdentifier ProductIdentifier { get; set; }
        }

        public partial class SalesRights
        {
            [JsonProperty("SalesRightsType")]
            public string SalesRightsType { get; set; }

            [JsonProperty("RightsTerritory")]
            public RightsTerritory RightsTerritory { get; set; }
        }

        public partial class Series
        {
            [JsonProperty("SeriesIdentifier")]
            public SeriesIdentifier SeriesIdentifier { get; set; }

            [JsonProperty("TitleOfSeries")]
            public string TitleOfSeries { get; set; }

            [JsonProperty("NumberWithinSeries")]
            public string NumberWithinSeries { get; set; }
        }

        public partial class SeriesIdentifier
        {
            [JsonProperty("SeriesIDType")]
            public string SeriesIdType { get; set; }

            [JsonProperty("IDValue")]
            public string IdValue { get; set; }
        }

        public partial class Subject
        {
            [JsonProperty("SubjectSchemeIdentifier")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long SubjectSchemeIdentifier { get; set; }

            [JsonProperty("SubjectHeadingText")]
            public string SubjectHeadingText { get; set; }
        }

        public partial class SupplyDetail
        {
            [JsonProperty("SupplierName")]
            public PublisherName SupplierName { get; set; }

            [JsonProperty("AvailabilityCode")]
            public AvailabilityCode AvailabilityCode { get; set; }

            [JsonProperty("ProductAvailability")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long ProductAvailability { get; set; }

            [JsonProperty("ExpectedShipDate", NullValueHandling = NullValueHandling.Ignore)]
            [JsonConverter(typeof(ParseStringConverter))]
            public long? ExpectedShipDate { get; set; }

            [JsonProperty("PackQuantity")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long PackQuantity { get; set; }

            [JsonProperty("Price", NullValueHandling = NullValueHandling.Ignore)]
            public Price[] Price { get; set; }
        }

        public partial class Price
        {
            [JsonProperty("PriceTypeCode")]
            public string PriceTypeCode { get; set; }

            [JsonProperty("DiscountCoded")]
            public DiscountCoded DiscountCoded { get; set; }

            [JsonProperty("PriceAmount")]
            public string PriceAmount { get; set; }

            [JsonProperty("CurrencyCode")]
            public CurrencyCode CurrencyCode { get; set; }
        }

        public partial class DiscountCoded
        {
            [JsonProperty("DiscountCodeType")]
            public string DiscountCodeType { get; set; }

            [JsonProperty("DiscountCodeTypeName")]
            public DiscountCodeTypeName DiscountCodeTypeName { get; set; }

            [JsonProperty("DiscountCode")]
            [JsonConverter(typeof(ParseStringConverter))]
            public long DiscountCode { get; set; }
        }

        public partial class Title
        {
            [JsonProperty("TitleType")]
            public string TitleType { get; set; }

            [JsonProperty("TitleText")]
            public string TitleText { get; set; }

            [JsonProperty("Subtitle", NullValueHandling = NullValueHandling.Ignore)]
            public string Subtitle { get; set; }
        }

        public enum Contenttype { Bk, Bs };

        public enum DoctypeEnum { Article, Bibliography, FbNonChapter, Index, Introduction, SimpleArticle, SimpleChapter };

        public enum Hubeid { The1S20S0080878408X60764, The1S20S0304020808X70318, The1S20S0376736108X70293, The3S20C20130015101, The3S20C20130015113, The3S20C20130015125, The3S20C20130015137, The3S20C20130015149, The3S20C20130052176, The3S20C2013006968X };

        public enum Indextype { Appendix, GenInfo };

        public enum Isbn { The9780012752159, The9780030031298, The9780044488088, The9780044499565, The9780080011035, The9780080019727, The9780080022994, The9780080025971, The9780080027920, The9780080028644 };

        public enum Issn { The00808784, The03040208, The03767361 };

        public enum Itemstage { S350 };

        public enum Itemweight { ContentsEntryOnly, HeadAndTail };

        public enum NormalizedSrctitle { Astronomicalproblems, Developmentsinpetroleumscience, Essentialsmodernphysicsappliedstudyinfrared, Fundamentalschemistry, Highresolutionnuclearmagneticresonancespectroscopy, Northhollandmathematicsstudies, Pneumatichydrauliccontrolsystems, Roleteacherininfantnurseryschool, Semiconductorssemimetals, Silicates };

        public enum Srctype { Nonserial, Serial };

        public enum Volissue { Volume160, Volume18PartB, Volume21PartD };

        public enum TypeEnum { Ref };

        public enum ChapterEnum { Null };

        public enum ContributorRole { A01, B01, B13 };

        public enum PublisherName { ElsevierScience };
    
        public enum CountryOfPublication { Gb, Nl, Us };

        public enum LanguageCode { Eng };

        public enum ContractOrigin { Nl, Uk, Us };

        public enum Cover { BookHardback, BookPaperback, DigiOrMmOnlineFile };

        public enum DiscountUk { The08Reference, The09Serials };

        public enum DiscountUs { The60Serials, The61NonSerials };

        public enum ExportToObs { N, Y };

        public enum ProductClass { Book };

        public enum ProductType { ReferenceBook079, SerialCloth202, SeriesCloth204 };

        public enum StatusU { IprInPreparationSecret, NypNotYetPublished, OopOutOfPrint };

        public enum TextRefTrade { Reference };

        public enum ProductForm { Bb, Bc, Dh };

        public enum RightsTerritory { World };

        public enum AvailabilityCode { Ip, Ws };

        public enum CurrencyCode { Aud, Eur, Gbp, Usd };

        public enum DiscountCodeTypeName { Est };

        public partial struct ChapterElement
        {
            public ChapterEnum? Enum;
            public VectorsByName VectorsByName;

            public static implicit operator ChapterElement(ChapterEnum Enum) => new ChapterElement { Enum = Enum };
            public static implicit operator ChapterElement(VectorsByName VectorsByName) => new ChapterElement { VectorsByName = VectorsByName };
        }

        public partial struct ContributorUnion
        {
            public ContributorElement[] ContributorElementArray;
            public PurpleContributor PurpleContributor;

            public static implicit operator ContributorUnion(ContributorElement[] ContributorElementArray) => new ContributorUnion { ContributorElementArray = ContributorElementArray };
            public static implicit operator ContributorUnion(PurpleContributor PurpleContributor) => new ContributorUnion { PurpleContributor = PurpleContributor };
        }

        public partial struct SeriesCodeUnion
        {
            public SeriesCodeClass SeriesCodeClass;
            public string String;

            public static implicit operator SeriesCodeUnion(SeriesCodeClass SeriesCodeClass) => new SeriesCodeUnion { SeriesCodeClass = SeriesCodeClass };
            public static implicit operator SeriesCodeUnion(string String) => new SeriesCodeUnion { String = String };
        }

        public partial class Welcome
        {
      //      public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, Converter.Settings);
            public static RootObject FromJson(string json) => JsonConvert.DeserializeObject<RootObject>(json, Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, Converter.Settings);
        }

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                ContenttypeConverter.Singleton,
                DoctypeEnumConverter.Singleton,
                HubeidConverter.Singleton,
                IndextypeConverter.Singleton,
                IsbnConverter.Singleton,
                IssnConverter.Singleton,
                ItemstageConverter.Singleton,
                ItemweightConverter.Singleton,
                NormalizedSrctitleConverter.Singleton,
                SrctypeConverter.Singleton,
                VolissueConverter.Singleton,
                TypeEnumConverter.Singleton,
                ContributorUnionConverter.Singleton,
                ContributorRoleConverter.Singleton,
                PublisherNameConverter.Singleton,
                CountryOfPublicationConverter.Singleton,
                LanguageCodeConverter.Singleton,
                ContractOriginConverter.Singleton,
                CoverConverter.Singleton,
                DiscountUkConverter.Singleton,
                DiscountUsConverter.Singleton,
                ExportToObsConverter.Singleton,
                ProductClassConverter.Singleton,
                ProductTypeConverter.Singleton,
                SeriesCodeUnionConverter.Singleton,
                StatusUConverter.Singleton,
                TextRefTradeConverter.Singleton,
                ProductFormConverter.Singleton,
                RightsTerritoryConverter.Singleton,
                AvailabilityCodeConverter.Singleton,
                CurrencyCodeConverter.Singleton,
                DiscountCodeTypeNameConverter.Singleton,
                ChapterElementConverter.Singleton,
                ChapterEnumConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

        internal class DecodeArrayConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long[]);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                reader.Read();
                var value = new List<long>();
                while (reader.TokenType != JsonToken.EndArray)
                {
                    var converter = ParseStringConverter.Singleton;
                    var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                    value.Add(arrayItem);
                    reader.Read();
                }
                return value.ToArray();
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (long[])untypedValue;
                writer.WriteStartArray();
                foreach (var arrayItem in value)
                {
                    var converter = ParseStringConverter.Singleton;
                    converter.WriteJson(writer, arrayItem, serializer);
                }
                writer.WriteEndArray();
                return;
            }

            public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
        }

        internal class ParseStringConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                long l;
                if (Int64.TryParse(value, out l))
                {
                    return l;
                }
                throw new Exception("Cannot unmarshal type long");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (long)untypedValue;
                serializer.Serialize(writer, value.ToString());
                return;
            }

            public static readonly ParseStringConverter Singleton = new ParseStringConverter();
        }

        internal class ContenttypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Contenttype) || t == typeof(Contenttype?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "BK":
                        return Contenttype.Bk;
                    case "BS":
                        return Contenttype.Bs;
                }
                throw new Exception("Cannot unmarshal type Contenttype");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Contenttype)untypedValue;
                switch (value)
                {
                    case Contenttype.Bk:
                        serializer.Serialize(writer, "BK");
                        return;
                    case Contenttype.Bs:
                        serializer.Serialize(writer, "BS");
                        return;
                }
                throw new Exception("Cannot marshal type Contenttype");
            }

            public static readonly ContenttypeConverter Singleton = new ContenttypeConverter();
        }

        internal class DoctypeEnumConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(DoctypeEnum) || t == typeof(DoctypeEnum?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "article":
                        return DoctypeEnum.Article;
                    case "bibliography":
                        return DoctypeEnum.Bibliography;
                    case "fb-non-chapter":
                        return DoctypeEnum.FbNonChapter;
                    case "index":
                        return DoctypeEnum.Index;
                    case "introduction":
                        return DoctypeEnum.Introduction;
                    case "simple-article":
                        return DoctypeEnum.SimpleArticle;
                    case "simple-chapter":
                        return DoctypeEnum.SimpleChapter;
                }
                throw new Exception("Cannot unmarshal type DoctypeEnum");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (DoctypeEnum)untypedValue;
                switch (value)
                {
                    case DoctypeEnum.Article:
                        serializer.Serialize(writer, "article");
                        return;
                    case DoctypeEnum.Bibliography:
                        serializer.Serialize(writer, "bibliography");
                        return;
                    case DoctypeEnum.FbNonChapter:
                        serializer.Serialize(writer, "fb-non-chapter");
                        return;
                    case DoctypeEnum.Index:
                        serializer.Serialize(writer, "index");
                        return;
                    case DoctypeEnum.Introduction:
                        serializer.Serialize(writer, "introduction");
                        return;
                    case DoctypeEnum.SimpleArticle:
                        serializer.Serialize(writer, "simple-article");
                        return;
                    case DoctypeEnum.SimpleChapter:
                        serializer.Serialize(writer, "simple-chapter");
                        return;
                }
                throw new Exception("Cannot marshal type DoctypeEnum");
            }

            public static readonly DoctypeEnumConverter Singleton = new DoctypeEnumConverter();
        }

        internal class HubeidConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Hubeid) || t == typeof(Hubeid?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "1-s2.0-S0080878408X60764":
                        return Hubeid.The1S20S0080878408X60764;
                    case "1-s2.0-S0304020808X70318":
                        return Hubeid.The1S20S0304020808X70318;
                    case "1-s2.0-S0376736108X70293":
                        return Hubeid.The1S20S0376736108X70293;
                    case "3-s2.0-C20130015101":
                        return Hubeid.The3S20C20130015101;
                    case "3-s2.0-C20130015113":
                        return Hubeid.The3S20C20130015113;
                    case "3-s2.0-C20130015125":
                        return Hubeid.The3S20C20130015125;
                    case "3-s2.0-C20130015137":
                        return Hubeid.The3S20C20130015137;
                    case "3-s2.0-C20130015149":
                        return Hubeid.The3S20C20130015149;
                    case "3-s2.0-C20130052176":
                        return Hubeid.The3S20C20130052176;
                    case "3-s2.0-C2013006968X":
                        return Hubeid.The3S20C2013006968X;
                }
                throw new Exception("Cannot unmarshal type Hubeid");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Hubeid)untypedValue;
                switch (value)
                {
                    case Hubeid.The1S20S0080878408X60764:
                        serializer.Serialize(writer, "1-s2.0-S0080878408X60764");
                        return;
                    case Hubeid.The1S20S0304020808X70318:
                        serializer.Serialize(writer, "1-s2.0-S0304020808X70318");
                        return;
                    case Hubeid.The1S20S0376736108X70293:
                        serializer.Serialize(writer, "1-s2.0-S0376736108X70293");
                        return;
                    case Hubeid.The3S20C20130015101:
                        serializer.Serialize(writer, "3-s2.0-C20130015101");
                        return;
                    case Hubeid.The3S20C20130015113:
                        serializer.Serialize(writer, "3-s2.0-C20130015113");
                        return;
                    case Hubeid.The3S20C20130015125:
                        serializer.Serialize(writer, "3-s2.0-C20130015125");
                        return;
                    case Hubeid.The3S20C20130015137:
                        serializer.Serialize(writer, "3-s2.0-C20130015137");
                        return;
                    case Hubeid.The3S20C20130015149:
                        serializer.Serialize(writer, "3-s2.0-C20130015149");
                        return;
                    case Hubeid.The3S20C20130052176:
                        serializer.Serialize(writer, "3-s2.0-C20130052176");
                        return;
                    case Hubeid.The3S20C2013006968X:
                        serializer.Serialize(writer, "3-s2.0-C2013006968X");
                        return;
                }
                throw new Exception("Cannot marshal type Hubeid");
            }

            public static readonly HubeidConverter Singleton = new HubeidConverter();
        }

        internal class IndextypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Indextype) || t == typeof(Indextype?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "Appendix":
                        return Indextype.Appendix;
                    case "GenInfo":
                        return Indextype.GenInfo;
                }
                throw new Exception("Cannot unmarshal type Indextype");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Indextype)untypedValue;
                switch (value)
                {
                    case Indextype.Appendix:
                        serializer.Serialize(writer, "Appendix");
                        return;
                    case Indextype.GenInfo:
                        serializer.Serialize(writer, "GenInfo");
                        return;
                }
                throw new Exception("Cannot marshal type Indextype");
            }

            public static readonly IndextypeConverter Singleton = new IndextypeConverter();
        }

        internal class IsbnConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Isbn) || t == typeof(Isbn?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "978-0-01-275215-9":
                        return Isbn.The9780012752159;
                    case "978-0-03-003129-8":
                        return Isbn.The9780030031298;
                    case "978-0-04-448808-8":
                        return Isbn.The9780044488088;
                    case "978-0-04-449956-5":
                        return Isbn.The9780044499565;
                    case "978-0-08-001103-5":
                        return Isbn.The9780080011035;
                    case "978-0-08-001972-7":
                        return Isbn.The9780080019727;
                    case "978-0-08-002299-4":
                        return Isbn.The9780080022994;
                    case "978-0-08-002597-1":
                        return Isbn.The9780080025971;
                    case "978-0-08-002792-0":
                        return Isbn.The9780080027920;
                    case "978-0-08-002864-4":
                        return Isbn.The9780080028644;
                }
                throw new Exception("Cannot unmarshal type Isbn");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Isbn)untypedValue;
                switch (value)
                {
                    case Isbn.The9780012752159:
                        serializer.Serialize(writer, "978-0-01-275215-9");
                        return;
                    case Isbn.The9780030031298:
                        serializer.Serialize(writer, "978-0-03-003129-8");
                        return;
                    case Isbn.The9780044488088:
                        serializer.Serialize(writer, "978-0-04-448808-8");
                        return;
                    case Isbn.The9780044499565:
                        serializer.Serialize(writer, "978-0-04-449956-5");
                        return;
                    case Isbn.The9780080011035:
                        serializer.Serialize(writer, "978-0-08-001103-5");
                        return;
                    case Isbn.The9780080019727:
                        serializer.Serialize(writer, "978-0-08-001972-7");
                        return;
                    case Isbn.The9780080022994:
                        serializer.Serialize(writer, "978-0-08-002299-4");
                        return;
                    case Isbn.The9780080025971:
                        serializer.Serialize(writer, "978-0-08-002597-1");
                        return;
                    case Isbn.The9780080027920:
                        serializer.Serialize(writer, "978-0-08-002792-0");
                        return;
                    case Isbn.The9780080028644:
                        serializer.Serialize(writer, "978-0-08-002864-4");
                        return;
                }
                throw new Exception("Cannot marshal type Isbn");
            }

            public static readonly IsbnConverter Singleton = new IsbnConverter();
        }

        internal class IssnConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Issn) || t == typeof(Issn?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "0080-8784":
                        return Issn.The00808784;
                    case "0304-0208":
                        return Issn.The03040208;
                    case "0376-7361":
                        return Issn.The03767361;
                }
                throw new Exception("Cannot unmarshal type Issn");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Issn)untypedValue;
                switch (value)
                {
                    case Issn.The00808784:
                        serializer.Serialize(writer, "0080-8784");
                        return;
                    case Issn.The03040208:
                        serializer.Serialize(writer, "0304-0208");
                        return;
                    case Issn.The03767361:
                        serializer.Serialize(writer, "0376-7361");
                        return;
                }
                throw new Exception("Cannot marshal type Issn");
            }

            public static readonly IssnConverter Singleton = new IssnConverter();
        }

        internal class ItemstageConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Itemstage) || t == typeof(Itemstage?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "S350")
                {
                    return Itemstage.S350;
                }
                throw new Exception("Cannot unmarshal type Itemstage");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Itemstage)untypedValue;
                if (value == Itemstage.S350)
                {
                    serializer.Serialize(writer, "S350");
                    return;
                }
                throw new Exception("Cannot marshal type Itemstage");
            }

            public static readonly ItemstageConverter Singleton = new ItemstageConverter();
        }

        internal class ItemweightConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Itemweight) || t == typeof(Itemweight?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "CONTENTS-ENTRY-ONLY":
                        return Itemweight.ContentsEntryOnly;
                    case "HEAD-AND-TAIL":
                        return Itemweight.HeadAndTail;
                }
                throw new Exception("Cannot unmarshal type Itemweight");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Itemweight)untypedValue;
                switch (value)
                {
                    case Itemweight.ContentsEntryOnly:
                        serializer.Serialize(writer, "CONTENTS-ENTRY-ONLY");
                        return;
                    case Itemweight.HeadAndTail:
                        serializer.Serialize(writer, "HEAD-AND-TAIL");
                        return;
                }
                throw new Exception("Cannot marshal type Itemweight");
            }

            public static readonly ItemweightConverter Singleton = new ItemweightConverter();
        }

        internal class NormalizedSrctitleConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(NormalizedSrctitle) || t == typeof(NormalizedSrctitle?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "ASTRONOMICALPROBLEMS":
                        return NormalizedSrctitle.Astronomicalproblems;
                    case "DEVELOPMENTSINPETROLEUMSCIENCE":
                        return NormalizedSrctitle.Developmentsinpetroleumscience;
                    case "ESSENTIALSMODERNPHYSICSAPPLIEDSTUDYINFRARED":
                        return NormalizedSrctitle.Essentialsmodernphysicsappliedstudyinfrared;
                    case "FUNDAMENTALSCHEMISTRY":
                        return NormalizedSrctitle.Fundamentalschemistry;
                    case "HIGHRESOLUTIONNUCLEARMAGNETICRESONANCESPECTROSCOPY":
                        return NormalizedSrctitle.Highresolutionnuclearmagneticresonancespectroscopy;
                    case "NORTHHOLLANDMATHEMATICSSTUDIES":
                        return NormalizedSrctitle.Northhollandmathematicsstudies;
                    case "PNEUMATICHYDRAULICCONTROLSYSTEMS":
                        return NormalizedSrctitle.Pneumatichydrauliccontrolsystems;
                    case "ROLETEACHERININFANTNURSERYSCHOOL":
                        return NormalizedSrctitle.Roleteacherininfantnurseryschool;
                    case "SEMICONDUCTORSSEMIMETALS":
                        return NormalizedSrctitle.Semiconductorssemimetals;
                    case "SILICATES":
                        return NormalizedSrctitle.Silicates;
                }
                throw new Exception("Cannot unmarshal type NormalizedSrctitle");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (NormalizedSrctitle)untypedValue;
                switch (value)
                {
                    case NormalizedSrctitle.Astronomicalproblems:
                        serializer.Serialize(writer, "ASTRONOMICALPROBLEMS");
                        return;
                    case NormalizedSrctitle.Developmentsinpetroleumscience:
                        serializer.Serialize(writer, "DEVELOPMENTSINPETROLEUMSCIENCE");
                        return;
                    case NormalizedSrctitle.Essentialsmodernphysicsappliedstudyinfrared:
                        serializer.Serialize(writer, "ESSENTIALSMODERNPHYSICSAPPLIEDSTUDYINFRARED");
                        return;
                    case NormalizedSrctitle.Fundamentalschemistry:
                        serializer.Serialize(writer, "FUNDAMENTALSCHEMISTRY");
                        return;
                    case NormalizedSrctitle.Highresolutionnuclearmagneticresonancespectroscopy:
                        serializer.Serialize(writer, "HIGHRESOLUTIONNUCLEARMAGNETICRESONANCESPECTROSCOPY");
                        return;
                    case NormalizedSrctitle.Northhollandmathematicsstudies:
                        serializer.Serialize(writer, "NORTHHOLLANDMATHEMATICSSTUDIES");
                        return;
                    case NormalizedSrctitle.Pneumatichydrauliccontrolsystems:
                        serializer.Serialize(writer, "PNEUMATICHYDRAULICCONTROLSYSTEMS");
                        return;
                    case NormalizedSrctitle.Roleteacherininfantnurseryschool:
                        serializer.Serialize(writer, "ROLETEACHERININFANTNURSERYSCHOOL");
                        return;
                    case NormalizedSrctitle.Semiconductorssemimetals:
                        serializer.Serialize(writer, "SEMICONDUCTORSSEMIMETALS");
                        return;
                    case NormalizedSrctitle.Silicates:
                        serializer.Serialize(writer, "SILICATES");
                        return;
                }
                throw new Exception("Cannot marshal type NormalizedSrctitle");
            }

            public static readonly NormalizedSrctitleConverter Singleton = new NormalizedSrctitleConverter();
        }

        internal class SrctypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Srctype) || t == typeof(Srctype?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "nonserial":
                        return Srctype.Nonserial;
                    case "serial":
                        return Srctype.Serial;
                }
                throw new Exception("Cannot unmarshal type Srctype");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Srctype)untypedValue;
                switch (value)
                {
                    case Srctype.Nonserial:
                        serializer.Serialize(writer, "nonserial");
                        return;
                    case Srctype.Serial:
                        serializer.Serialize(writer, "serial");
                        return;
                }
                throw new Exception("Cannot marshal type Srctype");
            }

            public static readonly SrctypeConverter Singleton = new SrctypeConverter();
        }

        internal class VolissueConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Volissue) || t == typeof(Volissue?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "Volume 160":
                        return Volissue.Volume160;
                    case "Volume 18, Part B":
                        return Volissue.Volume18PartB;
                    case "Volume 21, Part D":
                        return Volissue.Volume21PartD;
                }
                throw new Exception("Cannot unmarshal type Volissue");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Volissue)untypedValue;
                switch (value)
                {
                    case Volissue.Volume160:
                        serializer.Serialize(writer, "Volume 160");
                        return;
                    case Volissue.Volume18PartB:
                        serializer.Serialize(writer, "Volume 18, Part B");
                        return;
                    case Volissue.Volume21PartD:
                        serializer.Serialize(writer, "Volume 21, Part D");
                        return;
                }
                throw new Exception("Cannot marshal type Volissue");
            }

            public static readonly VolissueConverter Singleton = new VolissueConverter();
        }

        internal class TypeEnumConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "ref")
                {
                    return TypeEnum.Ref;
                }
                throw new Exception("Cannot unmarshal type TypeEnum");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (TypeEnum)untypedValue;
                if (value == TypeEnum.Ref)
                {
                    serializer.Serialize(writer, "ref");
                    return;
                }
                throw new Exception("Cannot marshal type TypeEnum");
            }

            public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
        }

        internal class ContributorUnionConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ContributorUnion) || t == typeof(ContributorUnion?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<PurpleContributor>(reader);
                        return new ContributorUnion { PurpleContributor = objectValue };
                    case JsonToken.StartArray:
                        var arrayValue = serializer.Deserialize<ContributorElement[]>(reader);
                        return new ContributorUnion { ContributorElementArray = arrayValue };
                }
                throw new Exception("Cannot unmarshal type ContributorUnion");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (ContributorUnion)untypedValue;
                if (value.ContributorElementArray != null)
                {
                    serializer.Serialize(writer, value.ContributorElementArray);
                    return;
                }
                if (value.PurpleContributor != null)
                {
                    serializer.Serialize(writer, value.PurpleContributor);
                    return;
                }
                throw new Exception("Cannot marshal type ContributorUnion");
            }

            public static readonly ContributorUnionConverter Singleton = new ContributorUnionConverter();
        }

        internal class ContributorRoleConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ContributorRole) || t == typeof(ContributorRole?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "A01":
                        return ContributorRole.A01;
                    case "B01":
                        return ContributorRole.B01;
                    case "B13":
                        return ContributorRole.B13;
                }
                throw new Exception("Cannot unmarshal type ContributorRole");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ContributorRole)untypedValue;
                switch (value)
                {
                    case ContributorRole.A01:
                        serializer.Serialize(writer, "A01");
                        return;
                    case ContributorRole.B01:
                        serializer.Serialize(writer, "B01");
                        return;
                    case ContributorRole.B13:
                        serializer.Serialize(writer, "B13");
                        return;
                }
                throw new Exception("Cannot marshal type ContributorRole");
            }

            public static readonly ContributorRoleConverter Singleton = new ContributorRoleConverter();
        }

        internal class PublisherNameConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(PublisherName) || t == typeof(PublisherName?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Elsevier Science")
                {
                    return PublisherName.ElsevierScience;
                }
                throw new Exception("Cannot unmarshal type PublisherName");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (PublisherName)untypedValue;
                if (value == PublisherName.ElsevierScience)
                {
                    serializer.Serialize(writer, "Elsevier Science");
                    return;
                }
                throw new Exception("Cannot marshal type PublisherName");
            }

            public static readonly PublisherNameConverter Singleton = new PublisherNameConverter();
        }

        internal class CountryOfPublicationConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(CountryOfPublication) || t == typeof(CountryOfPublication?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "GB":
                        return CountryOfPublication.Gb;
                    case "NL":
                        return CountryOfPublication.Nl;
                    case "US":
                        return CountryOfPublication.Us;
                }
                throw new Exception("Cannot unmarshal type CountryOfPublication");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (CountryOfPublication)untypedValue;
                switch (value)
                {
                    case CountryOfPublication.Gb:
                        serializer.Serialize(writer, "GB");
                        return;
                    case CountryOfPublication.Nl:
                        serializer.Serialize(writer, "NL");
                        return;
                    case CountryOfPublication.Us:
                        serializer.Serialize(writer, "US");
                        return;
                }
                throw new Exception("Cannot marshal type CountryOfPublication");
            }

            public static readonly CountryOfPublicationConverter Singleton = new CountryOfPublicationConverter();
        }

        internal class LanguageCodeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(LanguageCode) || t == typeof(LanguageCode?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "eng")
                {
                    return LanguageCode.Eng;
                }
                throw new Exception("Cannot unmarshal type LanguageCode");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (LanguageCode)untypedValue;
                if (value == LanguageCode.Eng)
                {
                    serializer.Serialize(writer, "eng");
                    return;
                }
                throw new Exception("Cannot marshal type LanguageCode");
            }

            public static readonly LanguageCodeConverter Singleton = new LanguageCodeConverter();
        }

        internal class ContractOriginConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ContractOrigin) || t == typeof(ContractOrigin?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "NL":
                        return ContractOrigin.Nl;
                    case "UK":
                        return ContractOrigin.Uk;
                    case "US":
                        return ContractOrigin.Us;
                }
                throw new Exception("Cannot unmarshal type ContractOrigin");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ContractOrigin)untypedValue;
                switch (value)
                {
                    case ContractOrigin.Nl:
                        serializer.Serialize(writer, "NL");
                        return;
                    case ContractOrigin.Uk:
                        serializer.Serialize(writer, "UK");
                        return;
                    case ContractOrigin.Us:
                        serializer.Serialize(writer, "US");
                        return;
                }
                throw new Exception("Cannot marshal type ContractOrigin");
            }

            public static readonly ContractOriginConverter Singleton = new ContractOriginConverter();
        }

        internal class CoverConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(Cover) || t == typeof(Cover?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "Book/Hardback":
                        return Cover.BookHardback;
                    case "Book/Paperback":
                        return Cover.BookPaperback;
                    case "Digi or MM/Online file":
                        return Cover.DigiOrMmOnlineFile;
                }
                throw new Exception("Cannot unmarshal type Cover");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (Cover)untypedValue;
                switch (value)
                {
                    case Cover.BookHardback:
                        serializer.Serialize(writer, "Book/Hardback");
                        return;
                    case Cover.BookPaperback:
                        serializer.Serialize(writer, "Book/Paperback");
                        return;
                    case Cover.DigiOrMmOnlineFile:
                        serializer.Serialize(writer, "Digi or MM/Online file");
                        return;
                }
                throw new Exception("Cannot marshal type Cover");
            }

            public static readonly CoverConverter Singleton = new CoverConverter();
        }

        internal class DiscountUkConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(DiscountUk) || t == typeof(DiscountUk?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "08 - Reference":
                        return DiscountUk.The08Reference;
                    case "09 - Serials":
                        return DiscountUk.The09Serials;
                }
                throw new Exception("Cannot unmarshal type DiscountUk");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (DiscountUk)untypedValue;
                switch (value)
                {
                    case DiscountUk.The08Reference:
                        serializer.Serialize(writer, "08 - Reference");
                        return;
                    case DiscountUk.The09Serials:
                        serializer.Serialize(writer, "09 - Serials");
                        return;
                }
                throw new Exception("Cannot marshal type DiscountUk");
            }

            public static readonly DiscountUkConverter Singleton = new DiscountUkConverter();
        }

        internal class DiscountUsConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(DiscountUs) || t == typeof(DiscountUs?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "60 - Serials":
                        return DiscountUs.The60Serials;
                    case "61 - Non-serials":
                        return DiscountUs.The61NonSerials;
                }
                throw new Exception("Cannot unmarshal type DiscountUs");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (DiscountUs)untypedValue;
                switch (value)
                {
                    case DiscountUs.The60Serials:
                        serializer.Serialize(writer, "60 - Serials");
                        return;
                    case DiscountUs.The61NonSerials:
                        serializer.Serialize(writer, "61 - Non-serials");
                        return;
                }
                throw new Exception("Cannot marshal type DiscountUs");
            }

            public static readonly DiscountUsConverter Singleton = new DiscountUsConverter();
        }

        internal class ExportToObsConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ExportToObs) || t == typeof(ExportToObs?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "N":
                        return ExportToObs.N;
                    case "Y":
                        return ExportToObs.Y;
                }
                throw new Exception("Cannot unmarshal type ExportToObs");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ExportToObs)untypedValue;
                switch (value)
                {
                    case ExportToObs.N:
                        serializer.Serialize(writer, "N");
                        return;
                    case ExportToObs.Y:
                        serializer.Serialize(writer, "Y");
                        return;
                }
                throw new Exception("Cannot marshal type ExportToObs");
            }

            public static readonly ExportToObsConverter Singleton = new ExportToObsConverter();
        }

        internal class ProductClassConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ProductClass) || t == typeof(ProductClass?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Book")
                {
                    return ProductClass.Book;
                }
                throw new Exception("Cannot unmarshal type ProductClass");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ProductClass)untypedValue;
                if (value == ProductClass.Book)
                {
                    serializer.Serialize(writer, "Book");
                    return;
                }
                throw new Exception("Cannot marshal type ProductClass");
            }

            public static readonly ProductClassConverter Singleton = new ProductClassConverter();
        }

        internal class ProductTypeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ProductType) || t == typeof(ProductType?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "REFERENCE BOOK-079":
                        return ProductType.ReferenceBook079;
                    case "SERIAL - CLOTH-202":
                        return ProductType.SerialCloth202;
                    case "SERIES - CLOTH-204":
                        return ProductType.SeriesCloth204;
                }
                throw new Exception("Cannot unmarshal type ProductType");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ProductType)untypedValue;
                switch (value)
                {
                    case ProductType.ReferenceBook079:
                        serializer.Serialize(writer, "REFERENCE BOOK-079");
                        return;
                    case ProductType.SerialCloth202:
                        serializer.Serialize(writer, "SERIAL - CLOTH-202");
                        return;
                    case ProductType.SeriesCloth204:
                        serializer.Serialize(writer, "SERIES - CLOTH-204");
                        return;
                }
                throw new Exception("Cannot marshal type ProductType");
            }

            public static readonly ProductTypeConverter Singleton = new ProductTypeConverter();
        }

        internal class SeriesCodeUnionConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(SeriesCodeUnion) || t == typeof(SeriesCodeUnion?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.String:
                    case JsonToken.Date:
                        var stringValue = serializer.Deserialize<string>(reader);
                        return new SeriesCodeUnion { String = stringValue };
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<SeriesCodeClass>(reader);
                        return new SeriesCodeUnion { SeriesCodeClass = objectValue };
                }
                throw new Exception("Cannot unmarshal type SeriesCodeUnion");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (SeriesCodeUnion)untypedValue;
                if (value.String != null)
                {
                    serializer.Serialize(writer, value.String);
                    return;
                }
                if (value.SeriesCodeClass != null)
                {
                    serializer.Serialize(writer, value.SeriesCodeClass);
                    return;
                }
                throw new Exception("Cannot marshal type SeriesCodeUnion");
            }

            public static readonly SeriesCodeUnionConverter Singleton = new SeriesCodeUnionConverter();
        }

        internal class StatusUConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(StatusU) || t == typeof(StatusU?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "IPR - In preparation (secret)":
                        return StatusU.IprInPreparationSecret;
                    case "NYP - Not yet published":
                        return StatusU.NypNotYetPublished;
                    case "OOP - Out of print":
                        return StatusU.OopOutOfPrint;
                }
                throw new Exception("Cannot unmarshal type StatusU");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (StatusU)untypedValue;
                switch (value)
                {
                    case StatusU.IprInPreparationSecret:
                        serializer.Serialize(writer, "IPR - In preparation (secret)");
                        return;
                    case StatusU.NypNotYetPublished:
                        serializer.Serialize(writer, "NYP - Not yet published");
                        return;
                    case StatusU.OopOutOfPrint:
                        serializer.Serialize(writer, "OOP - Out of print");
                        return;
                }
                throw new Exception("Cannot marshal type StatusU");
            }

            public static readonly StatusUConverter Singleton = new StatusUConverter();
        }

        internal class TextRefTradeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(TextRefTrade) || t == typeof(TextRefTrade?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "Reference")
                {
                    return TextRefTrade.Reference;
                }
                throw new Exception("Cannot unmarshal type TextRefTrade");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (TextRefTrade)untypedValue;
                if (value == TextRefTrade.Reference)
                {
                    serializer.Serialize(writer, "Reference");
                    return;
                }
                throw new Exception("Cannot marshal type TextRefTrade");
            }

            public static readonly TextRefTradeConverter Singleton = new TextRefTradeConverter();
        }

        internal class ProductFormConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ProductForm) || t == typeof(ProductForm?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "BB":
                        return ProductForm.Bb;
                    case "BC":
                        return ProductForm.Bc;
                    case "DH":
                        return ProductForm.Dh;
                }
                throw new Exception("Cannot unmarshal type ProductForm");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ProductForm)untypedValue;
                switch (value)
                {
                    case ProductForm.Bb:
                        serializer.Serialize(writer, "BB");
                        return;
                    case ProductForm.Bc:
                        serializer.Serialize(writer, "BC");
                        return;
                    case ProductForm.Dh:
                        serializer.Serialize(writer, "DH");
                        return;
                }
                throw new Exception("Cannot marshal type ProductForm");
            }

            public static readonly ProductFormConverter Singleton = new ProductFormConverter();
        }

        internal class RightsTerritoryConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(RightsTerritory) || t == typeof(RightsTerritory?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "WORLD")
                {
                    return RightsTerritory.World;
                }
                throw new Exception("Cannot unmarshal type RightsTerritory");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (RightsTerritory)untypedValue;
                if (value == RightsTerritory.World)
                {
                    serializer.Serialize(writer, "WORLD");
                    return;
                }
                throw new Exception("Cannot marshal type RightsTerritory");
            }

            public static readonly RightsTerritoryConverter Singleton = new RightsTerritoryConverter();
        }

        internal class AvailabilityCodeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(AvailabilityCode) || t == typeof(AvailabilityCode?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "IP":
                        return AvailabilityCode.Ip;
                    case "WS":
                        return AvailabilityCode.Ws;
                }
                throw new Exception("Cannot unmarshal type AvailabilityCode");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (AvailabilityCode)untypedValue;
                switch (value)
                {
                    case AvailabilityCode.Ip:
                        serializer.Serialize(writer, "IP");
                        return;
                    case AvailabilityCode.Ws:
                        serializer.Serialize(writer, "WS");
                        return;
                }
                throw new Exception("Cannot marshal type AvailabilityCode");
            }

            public static readonly AvailabilityCodeConverter Singleton = new AvailabilityCodeConverter();
        }

        internal class CurrencyCodeConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(CurrencyCode) || t == typeof(CurrencyCode?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                switch (value)
                {
                    case "AUD":
                        return CurrencyCode.Aud;
                    case "EUR":
                        return CurrencyCode.Eur;
                    case "GBP":
                        return CurrencyCode.Gbp;
                    case "USD":
                        return CurrencyCode.Usd;
                }
                throw new Exception("Cannot unmarshal type CurrencyCode");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (CurrencyCode)untypedValue;
                switch (value)
                {
                    case CurrencyCode.Aud:
                        serializer.Serialize(writer, "AUD");
                        return;
                    case CurrencyCode.Eur:
                        serializer.Serialize(writer, "EUR");
                        return;
                    case CurrencyCode.Gbp:
                        serializer.Serialize(writer, "GBP");
                        return;
                    case CurrencyCode.Usd:
                        serializer.Serialize(writer, "USD");
                        return;
                }
                throw new Exception("Cannot marshal type CurrencyCode");
            }

            public static readonly CurrencyCodeConverter Singleton = new CurrencyCodeConverter();
        }

        internal class DiscountCodeTypeNameConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(DiscountCodeTypeName) || t == typeof(DiscountCodeTypeName?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "EST")
                {
                    return DiscountCodeTypeName.Est;
                }
                throw new Exception("Cannot unmarshal type DiscountCodeTypeName");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (DiscountCodeTypeName)untypedValue;
                if (value == DiscountCodeTypeName.Est)
                {
                    serializer.Serialize(writer, "EST");
                    return;
                }
                throw new Exception("Cannot marshal type DiscountCodeTypeName");
            }

            public static readonly DiscountCodeTypeNameConverter Singleton = new DiscountCodeTypeNameConverter();
        }

        internal class ChapterElementConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ChapterElement) || t == typeof(ChapterElement?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                switch (reader.TokenType)
                {
                    case JsonToken.String:
                    case JsonToken.Date:
                        var stringValue = serializer.Deserialize<string>(reader);
                        if (stringValue == "null")
                        {
                            return new ChapterElement { Enum = ChapterEnum.Null };
                        }
                        break;
                    case JsonToken.StartObject:
                        var objectValue = serializer.Deserialize<VectorsByName>(reader);
                        return new ChapterElement { VectorsByName = objectValue };
                }
                throw new Exception("Cannot unmarshal type ChapterElement");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                var value = (ChapterElement)untypedValue;
                if (value.Enum != null)
                {
                    if (value.Enum == ChapterEnum.Null)
                    {
                        serializer.Serialize(writer, "null");
                        return;
                    }
                }
                if (value.VectorsByName != null)
                {
                    serializer.Serialize(writer, value.VectorsByName);
                    return;
                }
                throw new Exception("Cannot marshal type ChapterElement");
            }

            public static readonly ChapterElementConverter Singleton = new ChapterElementConverter();
        }

        internal class ChapterEnumConverter : JsonConverter
        {
            public override bool CanConvert(Type t) => t == typeof(ChapterEnum) || t == typeof(ChapterEnum?);

            public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
            {
                if (reader.TokenType == JsonToken.Null) return null;
                var value = serializer.Deserialize<string>(reader);
                if (value == "null")
                {
                    return ChapterEnum.Null;
                }
                throw new Exception("Cannot unmarshal type ChapterEnum");
            }

            public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
            {
                if (untypedValue == null)
                {
                    serializer.Serialize(writer, null);
                    return;
                }
                var value = (ChapterEnum)untypedValue;
                if (value == ChapterEnum.Null)
                {
                    serializer.Serialize(writer, "null");
                    return;
                }
                throw new Exception("Cannot marshal type ChapterEnum");
            }

            public static readonly ChapterEnumConverter Singleton = new ChapterEnumConverter();
        }
    }
