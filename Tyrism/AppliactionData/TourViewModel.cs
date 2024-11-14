using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrism.AppliactionData
{
    public class TourViewModel
    {
       
        private bool _showOnlyActive;

        public TourViewModel()
        {
            Tours = new ObservableCollection<Tour>(); // Примерный список туров
            FilteredTours = new ObservableCollection<Tour>(Tours);
            Types = new List<string> { "Все типы"};
        }

    
        public List<string> Types { get; }

        public decimal TotalPrice => FilteredTours.Sum(t => t.Price * t.TicketCount);

    }
}
