using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetworkConfigurator.DataManager;
using NetworkConfigurator.Model;
using Newtonsoft.Json;
using System.IO; 

namespace NetworkConfigurator.Controllers
{
    public class SavedController : Controller
    {
        PeopleContext context;
       // SavedDataManager savedData;
        public SavedController(PeopleContext _context)
        {
            this.context = _context;
           // savedData = new SavedDataManager(this.context);
        }





        // /saved or /saved/index
        public IActionResult Index()
        {
            IList<SavedViewModel> networks = SavedDataManager.GetAllNetworks(context);

            return View(networks);
        }


        SavedViewModel network;
        public async Task<IActionResult> Detail(int id)
        {
            network  = SavedDataManager.GetNetwork(context, id);

            return View("Detail", network);
        }



    }
}