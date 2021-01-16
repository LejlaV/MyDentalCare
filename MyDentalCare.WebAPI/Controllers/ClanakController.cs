﻿using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using MyDentalCare.WebAPI.Database;
using MyDentalCare.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.Model.Requests;
using AutoMapper;
using MyDentalCare.Model;

namespace MyDentalCare.WebAPI.Controllers
{
    public class ClanakController : BaseCRUDController<Model.Clanak, ClanakSearchRequest, ClanakUpsertRequest, ClanakUpsertRequest>
    {
        public ClanakController(ICRUDService<Model.Clanak, ClanakSearchRequest, ClanakUpsertRequest, ClanakUpsertRequest> service) : base(service)
        {
        }
    }
}