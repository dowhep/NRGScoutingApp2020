﻿using NRGScoutingApp2020.Pages.EventPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NRGScoutingApp2020.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MatchEvent : TabbedPage
    {
        public MatchEvent()
        {
            InitializeComponent();

            ContentPage MatchPage = new Matches();
            MatchPage.Title = "Matches";
            Children.Add(MatchPage);

            ContentPage RankingPage = new EventRanking();
            RankingPage.Title = "Rankings";
            Children.Add(RankingPage);

        }
    }
}