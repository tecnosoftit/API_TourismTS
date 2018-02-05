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

        public int SetImages(string name, string description, bool active, DateTime creation, DateTime modification)
        {
            try
            {
                var result =
                    _db.Database.ExecuteSqlCommand(
                        "EXEC SP_INSERTAR_USER @NAME, @DESCRIPTION, @ACTIVE, @CREATION, @MODIFICATION", 
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
              

        public List<ClasificationType> GetClasificationType()
        {
            try
            {
                var query = "EXEC SP_CLASIFICATIONTYPEGEN";
                var rtn = _db.Database.SqlQuery<ClasificationType>(query).ToList();
                return rtn;
            }
            catch (Exception e)
            {
                return new List<ClasificationType>();
            }
        }
    }
}
