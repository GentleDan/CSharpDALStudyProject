using ReinforcedConcreteFactoryListImplement.Models;
using System.Collections.Generic;

namespace ReinforcedConcreteFactoryListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Material> Materials { get; set; }
        public List<Order> Orders { get; set; }
        public List<Reinforced> Reinforceds { get; set; }
        public List<StoreHouse> StoreHouses { get; set; }
        public List<Client> Clients { get; set; }
        private DataListSingleton()
        {
            Materials = new List<Material>();
            Orders = new List<Order>();
            Reinforceds = new List<Reinforced>();
            StoreHouses = new List<StoreHouse>();
            Clients = new List<Client>();
        }
        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
