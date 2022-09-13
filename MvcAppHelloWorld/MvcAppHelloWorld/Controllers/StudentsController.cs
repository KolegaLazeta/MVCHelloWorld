using BusinessLayer;
using System.Web.Mvc;

namespace Controllers
{
    public class StudentsController<T> : Controller where T : class {

        private IStudentsService<T> _studentsService;

        public StudentsController(IStudentsService<T> studentsService)
        {
            _studentsService = studentsService;
        }

        public ActionResult Index()
        {
            var studentList = _studentsService.GetStudentList();
            return View("Index", studentList);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.readOnly = false;
            ViewBag.disabled = "";
            var student = _studentsService.GetByID(id);
            return View("Details", student);
        }

        public ActionResult Details(int id)
        {
            ViewBag.readOnly = true;
            ViewBag.disabled = "disabled";
            var student = _studentsService.GetByID(id);
            return View("Details", student);
        }

        public ActionResult EditStudentDetails(T obj)
        {
            _studentsService.EditStudentDetails(obj);
            _studentsService.Save();
            return View("Details", obj);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudent (T obj)
        {
            _studentsService.CreateNewStudent(obj);
            _studentsService.Save();
            return View("Details", obj);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                _studentsService.DeleteStudent(id);
                _studentsService.Save();
                return RedirectToAction("");
            }
            catch
            {
                return RedirectToAction("");
            }
        }

        public ActionResult Search(string searchString)
        {
           var students = _studentsService.Search(searchString);
            return View("Index", students);
        }

        public ActionResult Export(int id)
        {
            _studentsService.Export(id);
            return RedirectToAction("Index"); //spravit nak vodi na akciju keru spravim za textdownloadnotification
        }

    }
}