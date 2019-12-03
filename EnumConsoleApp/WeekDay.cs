using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumConsoleApp
{
    public enum WeekDay
    {
        [Description("禮拜天")]
        Sun=7,
        [Description("禮拜一")]
        Mon=1,
        [Description("禮拜二")]
        Tue=2,
        [Description("禮拜三")]
        Wed=3,
        [Description("禮拜四")]
        Thu=4,
        [Description("禮拜五")]
        Fri=5,
        [Description("禮拜六")]
        Sat=6
    }
}
