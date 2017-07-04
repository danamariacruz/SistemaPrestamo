using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CalculadoraIntereses.Models;

namespace CalculadoraIntereses.Controllers
{
    public class PrestamosController : Controller
    {

        //obteniendo listado desde el modelo, usando Json
        [HttpPost]
        public JsonResult PrestamoList()
        {
            using (var db = new ClienteDb())
            {
                try
                {
                    var result = db.Prestamos.ToList();
                    return Json(new { Result = "Ok", Records = result });
                }
                catch (System.Exception ex)
                {
                    return Json(new { Result = "Error", Records = ex.Message });
                }
            }

            
        }


        //metedo en donde se crearan nuevos prestamos 
        [HttpPost]
        public JsonResult Create(Prestamos Prestamos)
        {
            using (var db = new ClienteDb())

                try
            {
                if (!ModelState.IsValid)
                {
                    return Json(new
                    {
                        Result = "ERROR",
                        Message = "Form is not valid! " +
                      "Please correct it and try again."
                    });
                }

                var addPres = db.Prestamos.Add(Prestamos);
                return Json(new { Result = "OK", Record = addPres });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        //metodo para modificar los prestamos 
        [HttpPost]
        public JsonResult Update(Prestamos Prestamos)
        {
            using (var db = new ClienteDb())

                try
            {
                if (!ModelState.IsValid)
                {
                    return Json(new
                    {
                        Result = "ERROR",
                        Message = "Form is not valid! " +
                        "Please correct it and try again."
                    });
                }

                db.Entry(Prestamos).State = EntityState.Modified;
                return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        //metodo utilizado para eliminar prestamos 
        [HttpPost]
        public JsonResult Delete(int PrestamosID)
        {
            using (var db = new ClienteDb())

                try
            {
                    var result = db.Prestamos.Find(PrestamosID);
                    db.Prestamos.Remove(result);
                    return Json(new { Result = "OK" });
            }
            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message });
            }
        }

        


    }
}
