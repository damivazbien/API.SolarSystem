using System;
using System.Collections.Generic;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Interfaces
{
    public interface ISolarSystem
    {
        //get planets the solar system. 
        List<Planet> Get();
    }
}