using AppBootstrap.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace AppBootstrap.Controllers

{
    public class ClienteController : Controller
    {   
        //SE LE DEJA AL ADMINISTRADOR QUE SOLO VEA LA BD PARA MAYOR SEGURIDAD 
        [Authorize]
        public IActionResult Index(int? page)
        {
            var db = new netsenaContext();
            var pageNumber = page ?? 1;
            int pageS1ze = 6;
            var cliente = db.Clientes.ToPagedList(pageNumber, pageS1ze);
            return View(cliente);
        }
        [Authorize(Roles = "admin")]
        public IActionResult Crear()
        {
            return View();
        }

        [Authorize(Roles = "admin")]
        [Authorize]
        [HttpPost]
        public IActionResult Crear(Cliente mycliente)
        {
            var db = new netsenaContext();
            var existe = db.Clientes.Find(mycliente.Codigo);
            if (existe == null)
            {
                db.Clientes.Add(mycliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["msj"] = $"El Codigo {mycliente.Codigo} Ya existe";
                return View();
            }
        }

        [Authorize(Roles = "Coordinador")]
        [HttpGet]
        public IActionResult Editar(uint id)
        {
            var db = new netsenaContext();
            var mycliente = db.Clientes.Find(id);
            return View(mycliente);
        }
        [Authorize(Roles = "Coordinador")]
        [HttpPost]
        public IActionResult Editar(Cliente objCliente)
        {
            var db = new netsenaContext();
            var mycliente = db.Clientes.Find(objCliente.Codigo);
            mycliente.Nombre = objCliente.Nombre;
            mycliente.Correo = objCliente.Correo;

            db.SaveChanges();
            return RedirectToAction("Index");




        }

        [Authorize]
        public IActionResult Detalle(uint id)
        {
            var db = new netsenaContext();
            var mycliente = db.Clientes.Find(id);
            return View(mycliente);

        }
        [Authorize(Roles = "Coordinador")]
        [HttpGet]
        public IActionResult Borrar(uint id)
        {
            var db = new netsenaContext();
            var mycliente = db.Clientes.Find(id);
            return View(mycliente);

        }
        [Authorize(Roles = "Coordinador")]
        [HttpPost, ActionName("Borrar")]
        public IActionResult ConfirmarBorrar(uint id)
        {
            var db = new netsenaContext();
            var mycliente = db.Clientes.Find(id);
            db.Remove(mycliente);
            db.SaveChanges();
            return RedirectToAction("Index");

        }




    }
}
