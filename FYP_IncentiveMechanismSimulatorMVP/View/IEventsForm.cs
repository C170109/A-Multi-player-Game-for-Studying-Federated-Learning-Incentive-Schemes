﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FYP_IncentiveMechanismSimulatorMVP.View
{
    public interface IEventsForm
    {
        List<Model.EventsObject> eventsList{ get; set; }
    }
}
