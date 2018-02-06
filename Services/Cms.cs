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
    }
}
