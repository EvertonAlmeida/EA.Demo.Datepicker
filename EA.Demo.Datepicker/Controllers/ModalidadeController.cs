using System.Web.Mvc;

namespace EA.Demo.Datepicker.Controllers
{
    public class ModalidadeController : Controller
    {
        // GET: Modalidade
        public ActionResult Index()
        {
            return View();
        }

        // GET: Modalidade/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Modalidade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Modalidade/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Modalidade/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Modalidade/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Modalidade/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Modalidade/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
