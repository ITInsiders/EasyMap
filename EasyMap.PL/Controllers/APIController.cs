using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyMap.BL.Services;
using EasyMap.BL.DTO;
using EasyMap.PL.Models;

namespace EasyMap.PL.Controllers
{
    public class APIController : Controller
    {
        public JsonResult SearchLines()
        {
            string Search = Request.Form["Search"];
            
            List<PlaceDTO> places = PlaceService.GetAll();
            List<SearchLine> blocks = new List<SearchLine>();

            blocks.AddRange(places.Where(x => x.Name.ToLower().Contains(Search.ToLower()))
                .OrderBy(x => x.Name).Select(x => new SearchLine() { Type = x.Tags, Value = x.Name }));

            blocks.AddRange(places.Where(x => x.Tags.ToLower().Contains(Search.ToLower()))
                .OrderBy(x => x.Tags).Select(x => new SearchLine() { Type = "Тег", Value = x.Tags }));

            return Json(blocks);
        }

        public JsonResult SearchBlocks()
        {
            string Search = Request.Form["Search"];

            List<PlaceDTO> places = PlaceService.GetAll()
                .Where(x => x.Name.ToLower().Contains(Search.ToLower()) || x.Tags.ToLower().Contains(Search.ToLower()))
                .OrderBy(x => x.Name).ToList();

            return Json(places);
        }
    }
}