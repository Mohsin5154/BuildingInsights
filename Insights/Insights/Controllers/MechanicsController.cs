﻿using Insights.Repository;
using System.Collections.Generic;
using System.Web.Http;
using Insights.ViewModels;
using Insights.Models;

namespace Insights.Controllers
{

    public class MechanicsController : ApiController
    {
        private MechanicsRepository _mechanicsRepository;
        public MechanicsController()
        {
            _mechanicsRepository = new MechanicsRepository();
        }

        // Updating the Failure Charts 
        [ActionName("InsertUpdateMechanicsFailure")]
        [HttpPost]
        public List<MechanicsFailureView> InsertUpdateMechanicsFailure(Mechanics mechanics)
        {
            return _mechanicsRepository.InsertUpdateMechanicsFailureByType(mechanics);
        }

        // Updating the Cost Charts  
        [ActionName("InsertUpdateMechanicsCost")]
        [HttpPost]
        public List<MechanicsCostView> InsertUpdateMechanicsCost(Mechanics mechanics)
        {
            return _mechanicsRepository.InsertUpdateMechanicsCostByType(mechanics);
        }
    }
}