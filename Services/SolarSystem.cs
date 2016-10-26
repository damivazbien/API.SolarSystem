using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using API.Interfaces;
using API.Models;
using API.Configuration;
using Microsoft.Extensions.Options;

namespace API.Services
{
    //this services consume a json file for get data.
    public class SolarSystem : ISolarSystem
    {
        //Url where you use the file json
        string url = @"solarsystem.json";

        //Get soloar system data
        public List<Planet> Get()
        {
          try
          {
            string Json = System.IO.File.ReadAllText(url);
            return ValidJson(JsonConvert.DeserializeObject<List<Planet>>(File.ReadAllText(url)));  
          }
          catch (System.Exception)
          {
            return new List<Planet>();
          }
        }

        public List<Planet> ValidJson(List<Planet> planets)
        {
          if(planets.Count() == 8)
            return planets;
          else
            return new List<Planet>();
        }
    }
}