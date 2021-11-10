using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.Controllers
{
    public class PictureController : Controller
    {
        public IActionResult UploadFile()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UploadFile(IFormFile datei)
        {
            FileInfo fileInfo = new FileInfo(datei.FileName);

            var speicherePfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\" + fileInfo.Name;

            using (var fs = new FileStream(speicherePfad, FileMode.Create))
            {
                datei.CopyTo(fs);
            }

            return RedirectToAction(nameof(UploadFile));
        }


        public IActionResult Gallery1()
        {
            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            string[] bilder = Directory.GetFiles(pfad);

            return View(bilder);
        }

        public IActionResult Gallery2()
        {
            var pfad = AppDomain.CurrentDomain.GetData("BildVerzeichnis") + @"\images\";

            string[] bilder = Directory.GetFiles(pfad);

            return View(bilder);
        }
    }
}
