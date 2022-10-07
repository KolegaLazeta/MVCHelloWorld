﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjectModel;

namespace DataAccess
{
    public class ProfesssorRepository : GenericRepository<Professor>
    {
        private TuxContext db = null;
        private readonly TuxContext _context;

        public ProfesssorRepository(TuxContext context)
        {
            _context = context;
        }

        public override IEnumerable<Professor> Search(string searchString)
        {
            using (var db = new TuxContext())
            {
                var students = from m in db.Professor
                               select m;

                if (string.IsNullOrEmpty(searchString))
                {
                    return db.Professor.ToList();
                }
                else
                {
                    return db.Professor.ToList().Where(s => s.Name.Contains(searchString) |
                                                     s.Lastname.Contains(searchString) |
                                                     s.Email.Contains(searchString) |
                                                     s.House_Address.Contains(searchString) |
                                                     s.Birthday_date.ToString().Contains(searchString) |
                                                     s.Phone_Number.ToString().Contains(searchString) |
                                                     s.ClassSubject.Contains(searchString) |
                                                     s.Cabinet.ToString().Contains(searchString));

                }
            }
        }

        public override void Export(int id)
        {
            using (var db = new TuxContext())
            {
                var model = db.Professor.Find(id);

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string downloadArea = Path.Combine(@"C:\\Users\\apetras\\Desktop");

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, downloadArea, "Professor Details.txt")))
                {

                    try
                    {
                        var name = $"Name: {model.Name}";
                        var lastName = $"Last name: {model.Lastname}";
                        var birthday_date = $"Birthday date: {model.Birthday_date}";
                        var email = $"Email: {model.Email}";
                        var phone_number = $"Phone Number: {model.Phone_Number}";
                        var house_address = $"House Address: {model.House_Address}";
                        var cabinet = $"School Name: {model.Cabinet}";
                        var classSubject = $"Enrollment date: {model.ClassSubject}";

                        outputFile.WriteLine(name);
                        outputFile.WriteLine(lastName);
                        outputFile.WriteLine(birthday_date);
                        outputFile.WriteLine(email);
                        outputFile.WriteLine(phone_number);
                        outputFile.WriteLine(house_address);
                        outputFile.WriteLine(cabinet);
                        outputFile.WriteLine(classSubject);
                    }
                    catch
                    {

                    }
                }
            }
        }

        public override List<Professor> GetList()
        {
            return db.Professor.Include("UserRole").ToList();
        }

        public override void Create(Professor professor)
        {
            db.Users.Add(professor);
            db.UserRole.AddRange(professor.UserRole);
            db.SaveChanges();
        }
        //public override void Delete(int id)
        //{
        //    var userRoles = db.UserRole.Where(ur => ur.UserId == id);
        //    db.UserRole.RemoveRange(userRoles);
        //    db.Users.Remove(GetByID(id));
        //    db.SaveChanges();
        //}

    }
}
