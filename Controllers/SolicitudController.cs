using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pc03.Models;
using pc03.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace pc03.Controllers
{
    public class SolicitudController: Controller
    {
        private readonly ApplicactionDbContext _context;
        public SolicitudController(ApplicactionDbContext context)
        {
            _context = context;
        }
        public IActionResult Registrar(){
            var categorias = _context.DataCategoria.ToList();
            List<SelectListItem> items = categorias.ConvertAll(d =>{
                return new SelectListItem(){
                    Text = d.nombre,
                    Value = d.id.ToString(),
                    Selected = false
                };
            });
            ViewBag.items = items;
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Solicitud solicitud, int datos){
            if(ModelState.IsValid){
                var categoria = _context.DataCategoria.Find(datos);
                solicitud.categoria = categoria;
                _context.Add(solicitud);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }
            return View(solicitud);
        }

        public IActionResult Listar(){
            
            var fecha = DateTime.Now;
            var dia = fecha.Day - 5;
            var mes = fecha.Month;
            var año = fecha.Year;
            var solicitudes = _context.DataContactos.Include(s => s.categoria).Where(b => b.fecha.Day >= dia && b.fecha.Month == mes && b.fecha.Year == año).ToList();


            return View(solicitudes);

        }
    }
}