﻿using ProgressoExpert.Common.Enums;
using ProgressoExpert.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressoExpert.Controls.Utils
{
    public static class DateUtils
    {
        public static Dictionary<string, decimal> ConvertToQuarter(Dictionary<string, decimal> data, MainModel mainModel)
        {
            if (!mainModel.IsItQuarter && (mainModel.EndDate - mainModel.StartDate).Days < 365)
            {
                return data;
            }
            var result = new Dictionary<string, decimal>();

            for (int i = 0; i < data.Count; i=i+3)
            {
                var quarter = string.Format("{0}, {1}", mainModel.StartDate.Month + i > 12
                    ? ((QuarterEnum)mainModel.StartDate.Month + i - 12)
                    : ((QuarterEnum)mainModel.StartDate.Month + i),
                    mainModel.StartDate.Year + ((i + 3) / 12));
                result.Add(quarter, data.Skip(i).Take((data.Count - i) < 3 ? data.Count - i : 3).Sum(j => j.Value));
            }

            return result;
        }
    }
}