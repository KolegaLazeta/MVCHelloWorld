using BusinessLayer;
using BusinessObjectModel;
using MvcAppHelloWorld;
using System.Web.Mvc;

namespace Controllers
{
    public class GenericController<TViewModel, TModel> : Controller where TModel : class where TViewModel :class
    {

        private IGenericAppService<TViewModel, TModel> _service;

        public GenericController(IGenericAppService<TViewModel, TModel> service)
        {
            _service = service;
        }

        
        public ActionResult Index()
        {
            var studentList = _service.GetList();
            return View("Index", studentList);
        }

        public virtual ActionResult Edit(int id)
        {
            var student = _service.GetByID(id);
            return View("Details", student);
        }

        public virtual ActionResult Details(int id)
        {
            var student = _service.GetByID(id);
            return View("Details", student);
        }

        public virtual ActionResult EditDetails(TViewModel obj)
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
        public virtual ActionResult Save (TViewModel obj)
        {
            _service.Create(obj);
            _service.Save();
            return View("Details", obj);
        }

        public ActionResult Delete(int id)
        {
                _service.Delete(id);
                _service.Save();
                return RedirectToAction("Index");
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