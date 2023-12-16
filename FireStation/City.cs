using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireStation
{
    public class City
    {
        ObservableCollection<Building> buildings = new ObservableCollection<Building>();

        List<FireStation> fireStations = new List<FireStation>() 
        {
            new FireStation { area = Area.Center },
            new FireStation{ area = Area.Suburban }
        };


        public City()
        {
            buildings.CollectionChanged += Buildings_CollectionChanged;
        }

        public void Add(Building building)
        { 
            buildings.Add(building);
        }

        public void StartFire()
        {
            foreach (Building building in buildings)
            {
                building.OnFire();
            }
        }

        private void Buildings_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                ((Building)e.NewItems[0]).Fire += fireStations[0].OnFire;
                ((Building)e.NewItems[0]).Fire += fireStations[1].OnFire;
            }
        }

    }
}
