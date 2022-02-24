using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NS.CMS.Model;
using NS.CMS.Buisness;

namespace NS.CMS.WEB.Controllers;

public class CandidateController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICandidateBuisness _ICandidateBuisness;
    private readonly IWebHostEnvironment _hostEnvironment;

    public CandidateController(ILogger<HomeController> logger, ICandidateBuisness ICandidateBuisness, IWebHostEnvironment hostEnvironment)
    {
        _logger = logger;
        _ICandidateBuisness = ICandidateBuisness;
        this._hostEnvironment = hostEnvironment;
    }

    // Index
    public IActionResult Index()
    {
      var res = _ICandidateBuisness.GetAllCandidates();
      return View(res);
    }
    
    public IActionResult Details(int id)
    {
      var res = _ICandidateBuisness.GetCandidateById(id);
      return View(res);
    }


    // Add New Candidate
    [HttpGet]
    public IActionResult Create() {
      return View();
    }

    [HttpPost]
    public IActionResult Create(CandidateModel candidateModel)
    {
      string currentPath = Environment.CurrentDirectory;
      var res = _ICandidateBuisness.AddCandidate(candidateModel,currentPath);
      var result = _ICandidateBuisness.GetAllCandidates();
      return View("Index", result);
    }
   

    // Edit A Candidate
    [HttpGet]
    public IActionResult Edit() {
      return View();
    }

    [HttpPost]
    public IActionResult Edit(int id, CandidateModel candidateModel)
    { 
      var res = _ICandidateBuisness.Edit(id,candidateModel);
      var result = _ICandidateBuisness.GetAllCandidates();
      return View("Index", result); 
    }


    // Delete A Candidate
    public IActionResult Delete(int id, CandidateModel candidateModel)
    {
      var res = _ICandidateBuisness.Delete(id, candidateModel);
      var result = _ICandidateBuisness.GetAllCandidates();
      return View("Index", result); 
    }


    public IActionResult Privacy()
    {
        return View();
    }

}
