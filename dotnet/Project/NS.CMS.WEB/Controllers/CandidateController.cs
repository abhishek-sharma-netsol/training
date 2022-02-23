using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NS.CMS.Model;
using NS.CMS.Buisness;

namespace NS.CMS.WEB.Controllers;

public class CandidateController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ICandidateBuisness _ICandidateBuisness;

    public CandidateController(ILogger<HomeController> logger, ICandidateBuisness ICandidateBuisness)
    {
        _logger = logger;
        _ICandidateBuisness = ICandidateBuisness;
    }

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

    [HttpGet]
    public IActionResult Create() {
      return View();
    }

    [HttpPost]
    public IActionResult Create(CandidateModel candidateModel)
    {
      var res = _ICandidateBuisness.AddCandidate(candidateModel);
      var result = _ICandidateBuisness.GetAllCandidates();
      return View("Index", result);
    }
    
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
