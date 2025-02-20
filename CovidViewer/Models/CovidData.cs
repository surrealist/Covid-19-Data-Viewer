﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidViewer.Models
{
public class CovidData
{
    public string updated { get; set; }
    public string country { get; set; }
    public int cases { get; set; }
    public int todayCases { get; set; }
    public int deaths { get; set; }
    public int todayDeaths { get; set; }
    public int recovered { get; set; }
    public int todayRecovered { get; set; }
    public int active { get; set; }
    public int critical { get; set; }
    public double casesPerOneMillion { get; set; }
    public double deathsPerOneMillion { get; set; }
    public int tests { get; set; }
    public double testsPerOneMillion { get; set; }
    public int population { get; set; }
    public string continent { get; set; }
    public double oneCasePerPeople { get; set; }
    public double oneDeathPerPeople { get; set; }
    public double oneTestPerPeople { get; set; }
    public double activePerOneMillion { get; set; }
    public double recoveredPerOneMillion { get; set; }
    public double criticalPerOneMillion { get; set; }
}
}
