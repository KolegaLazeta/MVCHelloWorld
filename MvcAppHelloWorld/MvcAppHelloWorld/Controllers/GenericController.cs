using BusinessLayer;
using System.Web.Mvc;

namespace Controllers
{
    public class GenericController<T> : Controller where T : class {

        private IGenericService<T> _service;

        public GenericController(IGenericService<T> service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var studentList = _service.GetList();
            return View("Index", studentList);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.readOnly = false;
            ViewBag.disabled = "";
            var student = _service.GetByID(id);
            return View("Details", student);
        }

        public ActionResult Details(int id)
        {
            ViewBag.readOnly = true;
            ViewBag.disabled = "disabled";
            var student = _service.GetByID(id);
            return View("Details", student);
        }

        public ActionResult EditDetails(T obj)
        {
            _service.EditDetails(obj);
            _service.Save();
            return View("Details", obj);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public virtual ActionResult Save (T obj)
        {
            _service.Create(obj);
            _service.Save();
            return View("Details", obj);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);
                _service.Save();
                return RedirectToAction("");
            }
            catch
            {
                return RedirectToAction("");
            }
        }

        public ActionResult Search(string searchString)
        {
           var students = _service.Search(searchString);
            return View("Index", students);
        }

        public ActionResult Export(int id)
        {
            _service.Export(id);
            return RedirectToAction("Index"); //spravit nak vodi na akciju keru spravim za textdownloadnotification
        }

    }
}