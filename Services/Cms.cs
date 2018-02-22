using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel.General;
using System.Data.SqlClient;
using System.Dynamic;
using System.Reflection;

namespace Services
{
    public class Cms
    {
        private readonly TecnoTourismEntities _db = new TecnoTourismEntities();

        //CRUD Images
        public List<Images> GetImages()
        {
            try
            {
                var query = "EXEC SP_IMAGESGEN";
                var rtn = _db.Database.SqlQuery<Images>(query).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Images>();
            }
        }

        public List<Images> GetImagesById(int id)
        {
            try
            {
                var result = "EXEC SP_IMAGESBYID " + id;
                var rtn = _db.Database.SqlQuery<Images>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Images>();
            }
        }


        public List<Images> GetImagesByName(string name)
        {
            try
            {
                var result = "EXEC SP_IMAGESBYNAME " + name;
                var rtn = _db.Database.SqlQuery<Images>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Images>();
            }
        }

        public int PostImagesCreate(string name, string description, bool active, DateTime creation, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_IMAGESCRE @NAME, @DESCRIPTION, @ACTIVE, @CREATION, @MODIFICATION",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@CREATION", creation),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutImagesUpdate(int id, string name, string description, bool active, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_IMAGESUPD @ID, @NAME, @DESCRIPTION, @ACTIVE, @MODIFICATION",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD ImagesPerPlan

        public List<ImagesPerPlan> GetImagePerPlan()
        {
            try
            {
                var query = "EXEC SP_IMAGEPERPLANGEN";
                var rtn = _db.Database.SqlQuery<ImagesPerPlan>(query).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<ImagesPerPlan>();
            }
        }

        public List<ImagesPerPlan> GetImagePerPlanByIma(int image)
        {
            try
            {
                var result = "EXEC SP_IMAGEPERPLANBYIMA " + image;
                var rtn = _db.Database.SqlQuery<ImagesPerPlan>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<ImagesPerPlan>();
            }
        }


        public List<ImagesPerPlan> GetImagePerPlanByName(string name)
        {
            try
            {
                var result = "EXEC SP_IMAGEPERPLANBYNAME " + name;
                var rtn = _db.Database.SqlQuery<ImagesPerPlan>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<ImagesPerPlan>();
            }
        }

        public List<ImagesPerPlan> GetImagePerPlanByPla(int plan)
        {
            try
            {
                var result = "EXEC SP_IMAGEPERPLANBYPLA " + plan;
                var rtn = _db.Database.SqlQuery<ImagesPerPlan>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<ImagesPerPlan>();
            }
        }

        public int PostImagePerPlanCreate(int image, int plan)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_IMAGEPERPLANCRE @IMA_ID, @PLA_ID",
                        new SqlParameter("@IMA_ID", image),
                        new SqlParameter("@PLA_ID", plan));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD ClasificationType

        public List<ClasificationType> GetClasificationType()
        {
            try
            {
                var result = "EXEC SP_CLASIFICATIONTYPEGEN";
                var rtn = _db.Database.SqlQuery<ClasificationType>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<ClasificationType>();
            }
        }

        public List<ClasificationType> GetClasificationTypeById(int id)
        {
            try
            {
                var result = "EXEC SP_CLASIFICATIONTYPEBYID " + id;
                var rtn = _db.Database.SqlQuery<ClasificationType>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<ClasificationType>();
            }
        }

        public List<ClasificationType> GetClasificationTypeByName(string name)
        {
            try
            {
                var result = "EXEC SP_CLASIFICATIONTYPEBYNAME " + name;
                var rtn = _db.Database.SqlQuery<ClasificationType>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<ClasificationType>();
            }
        }

        public int PostClasificationTypeCreate(string name, string description, bool active, DateTime creation, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_CLASIFICATIONTYPECRE @NAME, @DESCRIPTION, @ACTIVE, @CREATION, @MODIFICATION",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@CREATION", creation),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutClasificationTypeUpdate(int id, string name, string description, bool active, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_CLASIFICATIONTYPEUPD @ID, @NAME, @DESCRIPTION, @ACTIVE, @MODIFICATION",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD PlanDetail

        public List<PlanDetail> GetPlanDetail()
        {
            try
            {
                var result = "EXEC SP_PLANDETAILGEN";
                var rtn = _db.Database.SqlQuery<PlanDetail>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<PlanDetail>();
            }
        }

        public List<PlanDetail> GetPlanDetailById(int id)
        {
            try
            {
                var result = "EXEC SP_PLANDETAILBYID " + id;
                var rtn = _db.Database.SqlQuery<PlanDetail>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<PlanDetail>();
            }
        }

        public List<PlanDetail> GetPlanDetailByAco(int aco)
        {
            try
            {
                var result = "EXEC SP_PLANDETAILBYACO " + aco;
                var rtn = _db.Database.SqlQuery<PlanDetail>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<PlanDetail>();
            }
        }

        public int PostPlanDetailCreate(int id, int acomodation, string price, string included, string notincluded, string traveler, string policies, string conditions, DateTime creation, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PLANDETAILCRE @PLA_ID, @ACOMODATION, @PRICE, @INCLUDED, @NOTINCLUDED, " +
                        "@TRAVELERINFO, @POLICIES, @CONDITIONS, @CREATION, @MODIFICATION",
                        new SqlParameter("@PLA_ID", id),
                        new SqlParameter("@ACOMODATION", acomodation),
                        new SqlParameter("@PRICE", price),
                        new SqlParameter("@INCLUDED", included),
                        new SqlParameter("@NOTINCLUDED", notincluded),
                        new SqlParameter("@TRAVELERINFO", traveler),
                        new SqlParameter("@POLICIES", policies),
                        new SqlParameter("@CONDITIONS", conditions),
                        new SqlParameter("@CREATION", creation),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutPlanDetailUpdate(int id, int plaiid, int acomodation, string price, string included, string notincluded, string traveler, string policies, string conditions, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PLANDETAILUPD @ID, @PLA_ID, @ACOMODATION, @PRICE, @INCLUDED, @NOTINCLUDED, @TRAVELERINFO," +
                        "@POLICIES, @CONDITIONS, @MODIFICATION",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@PLA_ID", plaiid),
                        new SqlParameter("@ACOMODATION", acomodation),
                        new SqlParameter("@PRICE", price),
                        new SqlParameter("@INCLUDED", included),
                        new SqlParameter("@NOTINCLUDED", notincluded),
                        new SqlParameter("@TRAVELERINFO", traveler),
                        new SqlParameter("@POLICIES", policies),
                        new SqlParameter("@CONDITIONS", conditions),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD Plans

        public List<Plans> GetPlan()
        {
            try
            {
                var result = "EXEC SP_PLANGEN";
                var rtn = _db.Database.SqlQuery<Plans>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Plans>();
            }
        }

        public List<Plans> GetPlanById(int id)
        {
            try
            {
                var result = "EXEC SP_PLANBYID " + id;
                var rtn = _db.Database.SqlQuery<Plans>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Plans>();
            }
        }

        public List<Plans> GetPlanByName(string name)
        {
            try
            {
                var result = "EXEC SP_PLANBYNAME " + name;
                var rtn = _db.Database.SqlQuery<Plans>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Plans>();
            }
        }

        public int PostPlanCreate(string name, string description, bool active, int type, DateTime creation, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PLANCRE @NAME, @DESCRIPTION, @ACTIVE, @TYPE_ID, @CREATION, @MODIFICATION",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@TYPE_ID", type),
                        new SqlParameter("@CREATION", creation),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutPlanUpdate(int id, string name, string description, bool active, int type, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PLANUPD @ID, @NAME, @DESCRIPTION, @ACTIVE, @TYPE_ID, @MODIFICATION",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@TYPE_ID", type),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD Types

        public List<Types> GetTypes()
        {
            try
            {
                var result = "EXEC SP_TYPEGEN";
                var rtn = _db.Database.SqlQuery<Types>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Types>();
            }
        }

        public List<Types> GetTypeById(int id)
        {
            try
            {
                var result = "EXEC SP_TYPEBYID " + id;
                var rtn = _db.Database.SqlQuery<Types>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Types>();
            }
        }

        public List<Types> GetTypeByName(string name)
        {
            try
            {
                var result = "EXEC SP_TYPEBYNAME " + name;
                var rtn = _db.Database.SqlQuery<Types>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Types>();
            }
        }

        public int PostTypeCreate(string name, string description, string url, int claid, bool active, DateTime creation, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_TYPECRE @NAME, @DESCRIPTION, @URL, @CLA_ID, @ACTIVE, @CREATION, @MODIFICATION",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@URL", url),
                        new SqlParameter("@CLA_ID", claid),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@CREATION", creation),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutTypeUpdate(int id, string name, string description, string url, int claid, bool active, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_TYPEUPD @ID, @NAME, @DESCRIPTION, @URL, @CLA_ID, @ACTIVE, @MODIFICATION",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@URL", url),
                        new SqlParameter("@CLA_ID", claid),
                        new SqlParameter("@ACTIVE", active),
                        new SqlParameter("@MODIFICATION", modification));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD CitesxPlan

        public List<CitesxPlan> GetCitesxPlan()
        {
            try
            {
                var result = "EXEC SP_CITESXPLANGEN";
                var rtn = _db.Database.SqlQuery<CitesxPlan>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<CitesxPlan>();
            }
        }

        public List<CitesxPlan> GetCitesxPlanById(int id)
        {
            try
            {
                var result = "EXEC SP_CITESXPLANBYID " + id;
                var rtn = _db.Database.SqlQuery<CitesxPlan>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<CitesxPlan>();
            }
        }

        public List<CitesxPlan> GetCitesxPlanByName(string name)
        {
            try
            {
                var result = "EXEC SP_CITESXPLANBYNAME " + name;
                var rtn = _db.Database.SqlQuery<CitesxPlan>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<CitesxPlan>();
            }
        }

        public List<CitesxPlan> GetCitesxPlanByPla(string plan)
        {

            try
            {
                var rtn = _db.Database.SqlQuery<CitesxPlan>("SP_CITESXPLANBYPLA @PLA", new SqlParameter("PLA", plan)).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<CitesxPlan>();
            }
        }

        public List<CitesxPlan> GetCitesxPlanByCit(int id)
        {
            try
            {
                var result = "EXEC SP_CITESXPLANBYCIT " + id;
                var rtn = _db.Database.SqlQuery<CitesxPlan>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<CitesxPlan>();
            }
        }

        public int PostCitesxPlanCreate(int city, string plan)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_CITESXPLANCRE @CTY_ID, @PLA_ID",
                        new SqlParameter("@CTY_ID", city),
                        new SqlParameter("@PLA_ID", plan));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutCitesxPlanUpdate(int id, int city, string plan)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_CITESXPLANUPD @ID, @CTY_ID, @PLA_ID",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@CTY_ID", city),
                        new SqlParameter("@PLA_ID", plan));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD City

        public List<City> GetCity()
        {
            try
            {
                var result = "EXEC SP_CITYGEN";
                var rtn = _db.Database.SqlQuery<City>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<City>();
            }
        }

        public List<City> GetCityById(int id)
        {
            try
            {
                var result = "EXEC SP_CITYBYID " + id;
                var rtn = _db.Database.SqlQuery<City>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<City>();
            }
        }

        public List<City> GetCityByName(string name)
        {
            try
            {
                var result = "EXEC SP_CITYBYNAME " + name;
                var rtn = _db.Database.SqlQuery<City>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<City>();
            }
        }

        public List<City> GetCityBySta(int state)
        {

            try
            {
                var result = "EXEC SP_CITYBYSTA " + state;
                var rtn = _db.Database.SqlQuery<City>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<City>();
            }
        }

        public int PostCityCreate(string name, string localited, string latituded, int state)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_CITYCRE @NAME, @LOCALITED, @LATITUDED, @STA_ID",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@LOCALITED", localited),
                        new SqlParameter("@LATITUDED", latituded),
                        new SqlParameter("@STA_ID", state));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutCityUpdate(int id, string name, string localited, string latituded, int state)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_CITYUPD @ID, @NAME, @LOCALITED, @LATITUDED, @STA_ID",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@LOCALITED", localited),
                        new SqlParameter("@LATITUDED", latituded),
                        new SqlParameter("@STA_ID", state));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD Company

        public List<Company> GetCompany()
        {
            try
            {
                var result = "EXEC SP_COMPANYGEN";
                var rtn = _db.Database.SqlQuery<Company>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Company>();
            }
        }

        public List<Company> GetCompanyById(string id)
        {
            try
            {
                var rtn = _db.Database.SqlQuery<Company>("SP_COMPANYBYID @ID", new SqlParameter("ID", id)).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Company>();
            }
        }

        public List<Company> GetCompanyByName(string name)
        {
            try
            {
                var result = "EXEC SP_COMPANYBYNAME " + name;
                var rtn = _db.Database.SqlQuery<Company>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Company>();
            }
        }

        public List<Company> GetCompanyByNit(string nit)
        {
            try
            {
                var result = "EXEC SP_COMPANYBYNIT " + nit;
                var rtn = _db.Database.SqlQuery<Company>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Company>();
            }
        }

        public int PostCompanyCreate(string name, string description, string nit)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_COMPANYCRE @NAME, @DESCRIPTION, @NIT",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@NIT", nit));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutCompanyUpdate(string id, string name, string description, string nit)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_COMPANYUPD @ID, @NAME, @DESCRIPTION, @NIT",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@DESCRIPTION", description),
                        new SqlParameter("@NIT", nit));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD CompanyProperties

        public List<CompanyProperties> GetCompanyProperties()
        {
            try
            {
                var result = "EXEC SP_COMPANYPROPERTIESGEN";
                var rtn = _db.Database.SqlQuery<CompanyProperties>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<CompanyProperties>();
            }
        }

        public List<CompanyProperties> GetCompanyPropertiesById(int id)
        {
            try
            {
                var result = "EXEC SP_COMPANYPROPERTIESBYID " + id;
                var rtn = _db.Database.SqlQuery<CompanyProperties>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<CompanyProperties>();
            }
        }

        public List<CompanyProperties> GetCompanyPropertiesByKey(string key)
        {
            try
            {
                var result = "EXEC SP_COMPANYPROPERTIESBYKEY " + key;
                var rtn = _db.Database.SqlQuery<CompanyProperties>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<CompanyProperties>();
            }
        }

        public List<CompanyProperties> GetCompanyPropertiesByCom(string com)
        {
            try
            {
                var rtn = _db.Database.SqlQuery<CompanyProperties>("SP_COMPANYPROPERTIESBYCOM @COM_ID", new SqlParameter("COM_ID", com)).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<CompanyProperties>();
            }
        }

        public int PostCompanyPropertiesCreate(string key, string value, string company)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_COMPANYPROPERTIESCRE @KEY, @VALUE, @COM_ID",
                        new SqlParameter("@KEY", key),
                        new SqlParameter("@VALUE", value),
                        new SqlParameter("@COM_ID", company));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutCompanyPropertiesUpdate(int id, string key, string value, string company)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_COMPANYPROPERTIESUPD @ID, @KEY, @VALUE, @COM_ID",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@KEY", key),
                        new SqlParameter("@VALUE", value),
                        new SqlParameter("@COM_ID", company));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD Country

        public List<Country> GetCountry()
        {
            try
            {
                var result = "EXEC SP_COUNTRYGEN";
                var rtn = _db.Database.SqlQuery<Country>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Country>();
            }
        }

        public List<Country> GetCountryById(int id)
        {
            try
            {
                var result = "EXEC SP_COUNTRYBYID " + id;
                var rtn = _db.Database.SqlQuery<Country>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Country>();
            }
        }

        public List<Country> GetCountryByName(string name)
        {
            try
            {
                var result = "EXEC SP_COUNTRYBYNAME " + name;
                var rtn = _db.Database.SqlQuery<Country>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<Country>();
            }
        }

        public int PostCountryCreate(string name)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_COUNTRYCRE @NAME",
                        new SqlParameter("@NAME", name));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutCountryUpdate(int id, string name)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_COUNTRYUPD @ID, @NAME",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD PlansxCompany

        public List<PlansxCompany> GetPlansxCompany()
        {
            try
            {
                var result = "EXEC SP_PLANSXCOMPANYGEN";
                var rtn = _db.Database.SqlQuery<PlansxCompany>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<PlansxCompany>();
            }
        }

        public List<PlansxCompany> GetPlansxCompanyById(int id)
        {
            try
            {
                var result = "EXEC SP_PLANSXCOMPANYBYID " + id;
                var rtn = _db.Database.SqlQuery<PlansxCompany>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<PlansxCompany>();
            }
        }

        public List<PlansxCompany> GetPlansxCompanyByName(string name)
        {
            try
            {
                var result = "EXEC SP_PLANSXCOMPANYBYNAME " + name;
                var rtn = _db.Database.SqlQuery<PlansxCompany>(result).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<PlansxCompany>();
            }
        }

        public List<PlansxCompany> GetPlansxCompanyByPlan(string plan)
        {
            try
            {
                var rtn = _db.Database.SqlQuery<PlansxCompany>("SP_PLANSXCOMPANYBYPLAN @PLA_ID", new SqlParameter("PLA_ID", plan)).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<PlansxCompany>();
            }
        }

        public List<PlansxCompany> GetPlansxCompanyByCom(string com)
        {
            try
            {
                var rtn = _db.Database.SqlQuery<PlansxCompany>("SP_PLANSXCOMPANYBYCOM @COM_ID", new SqlParameter("COM_ID", com)).ToList();
                return rtn;
            }
            catch (Exception)
            {
                return new List<PlansxCompany>();
            }
        }
        public int PostPlansxCompanyCreate(string plan, string company, int parent)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PLANSXCOMPANYCRE @PLA_ID, @COM_ID, @PARENTID",
                        new SqlParameter("@PLA_ID", plan),
                        new SqlParameter("@COM_ID", company),
                        new SqlParameter("@PARENTID", parent));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutPlansxCompanyUpdate(int id, string plan, string company, int parent)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PLANSXCOMPANYUPD @ID, @PLA_ID, @COM_ID, @PARENTID",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@PLA_ID", plan),
                        new SqlParameter("@COM_ID", company),
                        new SqlParameter("@PARENTID", parent));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD PropertiesxUser

        public List<PropertiesxUser> GetPropertiesxUser()
        {
            try
            {
                var result = "EXEC SP_PROPERTIESXUSERGEN";
                var rtn = _db.Database.SqlQuery<PropertiesxUser>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<PropertiesxUser>();
            }
        }

        public List<PropertiesxUser> GetPropertiesxUserByUser(string user)
        {
            try
            {
                var result = "EXEC SP_PROPERTIESXUSERBYUSER " + user;
                var rtn = _db.Database.SqlQuery<PropertiesxUser>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<PropertiesxUser>();
            }
        }

        public List<PropertiesxUser> GetPropertiesxUserByEmail(string email)
        {
            try
            {
                var result = "EXEC SP_PROPERTIESXUSERBYEMAIL " + email;
                var rtn = _db.Database.SqlQuery<PropertiesxUser>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<PropertiesxUser>();
            }
        }

        public int PostPropertiesxUserCreate(string user, string company, string email, string password)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PROPERTIESXUSERCRE @USE_ID, @COM_ID, @USE_EMAIL, @USE_PASSWORD",
                        new SqlParameter("@USE_ID", user),
                        new SqlParameter("@COM_ID", company),
                        new SqlParameter("@USE_EMAIL", email),
                        new SqlParameter("@USE_PASSWORD", password));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutPropertiesxUserUpdate(int id, string user, string company, string email, string password)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PROPERTIESXUSERUPD @ID, @USE_ID, @COM_ID, @USE_EMAIL, @USE_PASSWORD",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@USE_ID", user),
                        new SqlParameter("@COM_ID", company),
                        new SqlParameter("@USE_EMAIL", email),
                        new SqlParameter("@USE_PASSWORD", password));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD Role

        public List<Role> GetRole()
        {
            try
            {
                var result = "EXEC SP_ROLEGEN";
                var rtn = _db.Database.SqlQuery<Role>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Role>();
            }
        }

        public List<Role> GetRoleById(int id)
        {
            try
            {
                var rtn = _db.Database.SqlQuery<Role>("SP_ROLEBYID @ID", new SqlParameter("ID", id)).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Role>();
            }
        }

        public List<Role> GetRoleByName(string name)
        {
            try
            {
                var result = "EXEC SP_ROLEBYNAME " + name;
                var rtn = _db.Database.SqlQuery<Role>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Role>();
            }
        }

        public int PostRoleCreate(string name, bool active)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_ROLECRE @NOMBRE, @ACTIVE",
                        new SqlParameter("@NOMBRE", name),
                        new SqlParameter("@ACTIVE", active));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutRoleUpdate(int id, string name, bool active)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_ROLEUPD @ID, @NOMBRE, @ACTIVE",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NOMBRE", name),
                        new SqlParameter("@ACTIVE", active));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD State

        public List<State> GetState()
        {
            try
            {
                var result = "EXEC SP_STATEGEN";
                var rtn = _db.Database.SqlQuery<State>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<State>();
            }
        }

        public List<State> GetStateByName(string name)
        {
            try
            {
                var result = "EXEC SP_STATEBYNAME " + name;
                var rtn = _db.Database.SqlQuery<State>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<State>();
            }
        }

        public List<State> GetStateByCou(int country)
        {
            try
            {
                var result = "EXEC SP_STATEBYCOU " + country;
                var rtn = _db.Database.SqlQuery<State>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<State>();
            }
        }

        public int PostStateCreate(string name, int country)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_STATECRE @NAME, @COU_ID",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@COU_ID", country));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutStateUpdate(int id, string name, int country)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_STATEUPD @ID, @NAME, @COU_ID",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@COU_ID", country));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CRUD Users

        public List<Users> GetUsers()
        {
            try
            {
                var result = "EXEC SP_USERSGEN";
                var rtn = _db.Database.SqlQuery<Users>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Users>();
            }
        }

        public List<Users> GetUsersByName(string name)
        {
            try
            {
                var result = "EXEC SP_USERSBYNAME " + name;
                var rtn = _db.Database.SqlQuery<Users>(result).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<Users>();
            }
        }

        public int PostUsersCreate(string name, string surname, string phone, DateTime birthday, bool active)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_USERSCRE @NAME, @SURNAME, @PHONE, @BIRTHDAY, @ACTIVE",
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@SURNAME", surname),
                        new SqlParameter("@PHONE", phone),
                        new SqlParameter("@BIRTHDAY", birthday),
                        new SqlParameter("@ACTIVE", active));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int PutUsersUpdate(string id, string name, string surname, string phone, DateTime birthday, bool active)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_USERSUPD @ID, @NAME, @SURNAME, @PHONE, @BIRTHDAY, @ACTIVE",
                        new SqlParameter("@ID", id),
                        new SqlParameter("@NAME", name),
                        new SqlParameter("@SURNAME", surname),
                        new SqlParameter("@PHONE", phone),
                        new SqlParameter("@BIRTHDAY", birthday),
                        new SqlParameter("@ACTIVE", active));
                return result;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //CompanyProperties

        public IDictionary<string, string> GetCompanyInformation(string url)
        {
            try
            {
                var rtn = new Dictionary<string, string>();
                var query = "EXEC SP_GETCOMPANYINFORMATION '" + url + "'";
                using (var connection = new SqlConnection(_db.Database.Connection.ConnectionString))
                {
                    var command = new SqlCommand(query, connection); try
                    {
                        connection.Open();
                        var reader = command.ExecuteReader();
                        while (reader.Read()) for (var i = 0; i <= reader.FieldCount; i++) rtn.Add(reader.GetName(i), reader[i].ToString());
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }
                return rtn;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
