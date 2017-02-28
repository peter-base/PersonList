using PersonList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonList.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(List<Person> personList)
        {
            //add new person
            personList.Add(new Person());
            //set indexes
            for (int i = 0; i < personList.Count; i++)
            {
                personList[i].Index = i;
            }
            return PartialView("_PersonList", personList);
        }

        [HttpPost]
        public ActionResult RemovePerson(List<Person> personList, int remove_person_index)
        {
            //remove person
            var person = personList.FirstOrDefault(i => i.Index == remove_person_index);
            if (person != null)
            {
                personList.Remove(person);
            }
            //set indexes
            for (int i = 0; i < personList.Count; i++)
            {
                personList[i].Index = i;
            }

            return PartialView("_PersonList", personList);
        }
    }
}