using Microsoft.AspNetCore.Mvc;
using JobsList.Models;
using System.Collections.Generic;

namespace JobsList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }
    [HttpGet("/list")]
    public ActionResult List()
    {
      List<JobVariables> allJobs = JobVariables.GetAll();
      return View("List", allJobs);
    }
    [HttpGet("/create")]
    public ActionResult Create()
    {
      return View("Form");
    }
    [HttpPost("/add")]
    public ActionResult Add()
    {
      var Name = (Request.Form["name"]);
      var Date = (Request.Form["date"]);
      var Keyword = (Request.Form["keyword"]);
      var Other = (Request.Query["other"]);
      JobVariables newJob = new JobVariables(Name, Date, Keyword, Other);
      newJob.Save();
      List<JobVariables> allJobs = JobVariables.GetAll();
      return View("List", allJobs);
    }
    [HttpGet("/delete")]
    public ActionResult Delete()
    {
      List<JobVariables> allJobs = JobVariables.GetAll();
      int jobId = int.Parse(Request.Query["id"]);
      allJobs.RemoveAt(jobId);
      return View("DeleteConfirm", allJobs);
    }
  }
}
