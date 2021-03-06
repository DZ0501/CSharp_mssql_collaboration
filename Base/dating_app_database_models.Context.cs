//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Base
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dating_app_databaseEntities : DbContext
    {
        public dating_app_databaseEntities()
            : base("name=dating_app_databaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<alkohol> alkohols { get; set; }
        public virtual DbSet<firma> firmas { get; set; }
        public virtual DbSet<gatunek> gatuneks { get; set; }
        public virtual DbSet<kobieta> kobietas { get; set; }
        public virtual DbSet<mezczyzna> mezczyznas { get; set; }
        public virtual DbSet<papierosy> papierosies { get; set; }
        public virtual DbSet<placowka> placowkas { get; set; }
        public virtual DbSet<religia> religias { get; set; }
        public virtual DbSet<status_zwiazku> status_zwiazku { get; set; }
        public virtual DbSet<wyksztalcenie> wyksztalcenies { get; set; }
        public virtual DbSet<zainteresowanie> zainteresowanies { get; set; }
        public virtual DbSet<znak_zodiaku> znak_zodiaku { get; set; }
        public virtual DbSet<zwierzatko> zwierzatkoes { get; set; }
    
        [DbFunction("dating_app_databaseEntities", "FreeGuysFromCracow")]
        public virtual IQueryable<FreeGuysFromCracow_Result> FreeGuysFromCracow(Nullable<byte> zwiazekID, string zamieszkanieNazwa)
        {
            var zwiazekIDParameter = zwiazekID.HasValue ?
                new ObjectParameter("ZwiazekID", zwiazekID) :
                new ObjectParameter("ZwiazekID", typeof(byte));
    
            var zamieszkanieNazwaParameter = zamieszkanieNazwa != null ?
                new ObjectParameter("ZamieszkanieNazwa", zamieszkanieNazwa) :
                new ObjectParameter("ZamieszkanieNazwa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FreeGuysFromCracow_Result>("[dating_app_databaseEntities].[FreeGuysFromCracow](@ZwiazekID, @ZamieszkanieNazwa)", zwiazekIDParameter, zamieszkanieNazwaParameter);
        }
    
        [DbFunction("dating_app_databaseEntities", "ShowZodiacSignOfMen")]
        public virtual IQueryable<ShowZodiacSignOfMen_Result> ShowZodiacSignOfMen(string zodiakNazwa)
        {
            var zodiakNazwaParameter = zodiakNazwa != null ?
                new ObjectParameter("ZodiakNazwa", zodiakNazwa) :
                new ObjectParameter("ZodiakNazwa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ShowZodiacSignOfMen_Result>("[dating_app_databaseEntities].[ShowZodiacSignOfMen](@ZodiakNazwa)", zodiakNazwaParameter);
        }
    
        [DbFunction("dating_app_databaseEntities", "WomenFirstInterest")]
        public virtual IQueryable<WomenFirstInterest_Result> WomenFirstInterest(string zainteresowanieNazwa)
        {
            var zainteresowanieNazwaParameter = zainteresowanieNazwa != null ?
                new ObjectParameter("ZainteresowanieNazwa", zainteresowanieNazwa) :
                new ObjectParameter("ZainteresowanieNazwa", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<WomenFirstInterest_Result>("[dating_app_databaseEntities].[WomenFirstInterest](@ZainteresowanieNazwa)", zainteresowanieNazwaParameter);
        }
    
        public virtual int BusinessAdd(string nazwa, string nIP, string kodPocztowy, string miasto, string adres)
        {
            var nazwaParameter = nazwa != null ?
                new ObjectParameter("Nazwa", nazwa) :
                new ObjectParameter("Nazwa", typeof(string));
    
            var nIPParameter = nIP != null ?
                new ObjectParameter("NIP", nIP) :
                new ObjectParameter("NIP", typeof(string));
    
            var kodPocztowyParameter = kodPocztowy != null ?
                new ObjectParameter("KodPocztowy", kodPocztowy) :
                new ObjectParameter("KodPocztowy", typeof(string));
    
            var miastoParameter = miasto != null ?
                new ObjectParameter("Miasto", miasto) :
                new ObjectParameter("Miasto", typeof(string));
    
            var adresParameter = adres != null ?
                new ObjectParameter("Adres", adres) :
                new ObjectParameter("Adres", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BusinessAdd", nazwaParameter, nIPParameter, kodPocztowyParameter, miastoParameter, adresParameter);
        }
    
        public virtual int ManAdd(string imie, string nazwisko, Nullable<byte> wiek, string miejscowosc, Nullable<byte> zainteresowanie_1, Nullable<byte> zainteresowanie_2, Nullable<byte> zainteresowanie_3, Nullable<byte> status_zwiazku_ID, Nullable<byte> firma_ID, Nullable<byte> znak_zodiaku_ID, Nullable<byte> wyksztalcenie_ID, Nullable<byte> zwierzatko_ID, Nullable<byte> religia_ID, Nullable<byte> alkohol_ID, Nullable<byte> papierosy_ID)
        {
            var imieParameter = imie != null ?
                new ObjectParameter("Imie", imie) :
                new ObjectParameter("Imie", typeof(string));
    
            var nazwiskoParameter = nazwisko != null ?
                new ObjectParameter("Nazwisko", nazwisko) :
                new ObjectParameter("Nazwisko", typeof(string));
    
            var wiekParameter = wiek.HasValue ?
                new ObjectParameter("Wiek", wiek) :
                new ObjectParameter("Wiek", typeof(byte));
    
            var miejscowoscParameter = miejscowosc != null ?
                new ObjectParameter("Miejscowosc", miejscowosc) :
                new ObjectParameter("Miejscowosc", typeof(string));
    
            var zainteresowanie_1Parameter = zainteresowanie_1.HasValue ?
                new ObjectParameter("Zainteresowanie_1", zainteresowanie_1) :
                new ObjectParameter("Zainteresowanie_1", typeof(byte));
    
            var zainteresowanie_2Parameter = zainteresowanie_2.HasValue ?
                new ObjectParameter("Zainteresowanie_2", zainteresowanie_2) :
                new ObjectParameter("Zainteresowanie_2", typeof(byte));
    
            var zainteresowanie_3Parameter = zainteresowanie_3.HasValue ?
                new ObjectParameter("Zainteresowanie_3", zainteresowanie_3) :
                new ObjectParameter("Zainteresowanie_3", typeof(byte));
    
            var status_zwiazku_IDParameter = status_zwiazku_ID.HasValue ?
                new ObjectParameter("status_zwiazku_ID", status_zwiazku_ID) :
                new ObjectParameter("status_zwiazku_ID", typeof(byte));
    
            var firma_IDParameter = firma_ID.HasValue ?
                new ObjectParameter("firma_ID", firma_ID) :
                new ObjectParameter("firma_ID", typeof(byte));
    
            var znak_zodiaku_IDParameter = znak_zodiaku_ID.HasValue ?
                new ObjectParameter("znak_zodiaku_ID", znak_zodiaku_ID) :
                new ObjectParameter("znak_zodiaku_ID", typeof(byte));
    
            var wyksztalcenie_IDParameter = wyksztalcenie_ID.HasValue ?
                new ObjectParameter("wyksztalcenie_ID", wyksztalcenie_ID) :
                new ObjectParameter("wyksztalcenie_ID", typeof(byte));
    
            var zwierzatko_IDParameter = zwierzatko_ID.HasValue ?
                new ObjectParameter("zwierzatko_ID", zwierzatko_ID) :
                new ObjectParameter("zwierzatko_ID", typeof(byte));
    
            var religia_IDParameter = religia_ID.HasValue ?
                new ObjectParameter("religia_ID", religia_ID) :
                new ObjectParameter("religia_ID", typeof(byte));
    
            var alkohol_IDParameter = alkohol_ID.HasValue ?
                new ObjectParameter("alkohol_ID", alkohol_ID) :
                new ObjectParameter("alkohol_ID", typeof(byte));
    
            var papierosy_IDParameter = papierosy_ID.HasValue ?
                new ObjectParameter("papierosy_ID", papierosy_ID) :
                new ObjectParameter("papierosy_ID", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ManAdd", imieParameter, nazwiskoParameter, wiekParameter, miejscowoscParameter, zainteresowanie_1Parameter, zainteresowanie_2Parameter, zainteresowanie_3Parameter, status_zwiazku_IDParameter, firma_IDParameter, znak_zodiaku_IDParameter, wyksztalcenie_IDParameter, zwierzatko_IDParameter, religia_IDParameter, alkohol_IDParameter, papierosy_IDParameter);
        }
    
        public virtual ObjectResult<UserList_Result> UserList(string imie, string nazwisko, ObjectParameter liczba)
        {
            var imieParameter = imie != null ?
                new ObjectParameter("Imie", imie) :
                new ObjectParameter("Imie", typeof(string));
    
            var nazwiskoParameter = nazwisko != null ?
                new ObjectParameter("Nazwisko", nazwisko) :
                new ObjectParameter("Nazwisko", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UserList_Result>("UserList", imieParameter, nazwiskoParameter, liczba);
        }
    }
}
