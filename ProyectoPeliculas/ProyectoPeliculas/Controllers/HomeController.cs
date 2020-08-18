using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoPeliculas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            if(Session["USUARIO"] != null)
            {
                ViewBag.Mensaje = "Bienvenido, ";
            }

            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        //GET: Login
        public ActionResult Login()
        {
            return View();
        }

        //POST: Login
        [HttpPost]
        public ActionResult Login(String usuario, String password)
        {

            if(usuario == "dani" && password == "dani")
            {
                //Almacenamos el usuario en la sesión (En verdad tendríamos una clase con los datos del usuario y guardaríamos eso)
                Session["USUARIO"] = usuario;
                ViewBag.Mensaje = "Bienvenido, " + usuario;
                
                return View();
            }
            else
            {
                ViewBag.Mensaje = "Usuario incorrecto";
                return View();
            }
            
        }
    }
}