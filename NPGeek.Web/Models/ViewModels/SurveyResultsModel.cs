﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPGeek.Web.Models.ViewModels
{
    public class SurveyResultsModel : BaseViewModel
    {
        public List<ParkSurveyCount> ParkSurveyList { get; set; }
    }
}