using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ViewModel.General;
using System.Data.SqlClient;

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
                var result = "EXEC SP_IMAGESBYID "+ id;
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

        public int PostPlanDetailCreate(int id,int acomodation, string price, string included, string notincluded, string traveler, string policies, string conditions, DateTime creation, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_PLANDETAILCRE @PLA_ID, @ACOMODATION, @PRICE, @INCLUDED, @NOTINCLUDED, "+
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
                        "EXEC SP_PLANDETAILUPD @ID, @PLA_ID, @ACOMODATION, @PRICE, @INCLUDED, @NOTINCLUDED, @TRAVELERINFO,"+ 
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
    }
}
