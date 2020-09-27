using System;
using System.Collections.Generic;
using System.Linq;
using Lesson05.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lesson05.Controllers
{
    public class Exercise01Controller : Controller
    {
        private CountryRepository countryRepository;
        private List<SelectListItem> countriesDropdown = new List<SelectListItem>();

        public Exercise01Controller(CountryRepository repo)
        {
            countryRepository = repo;
        }

        public IActionResult Index(string country) {
            ViewData["Title"] = "Countries";

            ViewData["CountryCode"] = country;

            foreach (Country item in countryRepository.CountriesSorted)
            {
                // if there is a country parameter in the URL
                if (!String.IsNullOrEmpty(country))
                {
                    // if the country from the countries List we're looking at right now has that country code value given as parameter
                    if (item.CountryCode == country)
                    {
                        // mark it as selected
                        countriesDropdown.Add(new SelectListItem { Text = item.Name, Value = item.CountryCode, Selected = true });
                    }
                    else
                    {
                        // else not
                        countriesDropdown.Add(new SelectListItem { Text = item.Name, Value = item.CountryCode });
                    }
                }
                else
                {
                    // if no country parameter is givev in the URL the
                    countriesDropdown.Add(new SelectListItem { Text = item.Name, Value = item.CountryCode });
                }
            }


            //countriesDropdown.OrderBy(x => x.Text);
            countriesDropdown.OrderBy(x => x.Text);

            ViewData["Countries"] = countriesDropdown;

            return View();
        }


        [HttpPost]
        public IActionResult Index(Country newCountry)
        {
            countryRepository.AddCountry(newCountry);

            
            foreach (Country item in countryRepository.CountriesSorted)
            {
                if (item.CountryCode == newCountry.CountryCode)
                {
                    countriesDropdown.Add(new SelectListItem { Text = item.Name, Value = item.CountryCode, Selected = true });
                }
                else
                {
                    countriesDropdown.Add(new SelectListItem { Text = item.Name, Value = item.CountryCode });
                }
            }

           

            ViewData["Countries"] = countriesDropdown;

            return View(newCountry);
        }
    }
}