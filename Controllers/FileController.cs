using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FileController.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public ActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public FileResult DownloadFile(string firstName, string lastName, string fileName)
        {
            var fileContent = $"{firstName} {lastName}";
            var byteArray = System.Text.Encoding.UTF8.GetBytes(fileContent);
            var stream = new MemoryStream(byteArray);

            fileName = $"{fileName}.txt";

            return File(stream, "text/plain", fileName);
        }
    }

}
