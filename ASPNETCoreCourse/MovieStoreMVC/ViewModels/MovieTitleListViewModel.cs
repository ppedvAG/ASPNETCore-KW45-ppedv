using MovieStoreMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStoreMVC.ViewModels
{
    public class MovieTitleListViewModel
    {
        public MovieTitleListViewModel()
        {
            TitleList = new();
        }

        public List<MovieItem> TitleList { get; set; } //List die in ComboBox oder SelectedList angezeigt wird
        public int SelectedId { get; set; }
    }
}
