using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class DuckHouse : IFacility<IFeed>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IFeed> _animals = new List<IFeed>();


        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IFeed animal)
        {
            //this code adds the animal to the list
            _animals.Add(animal);
            // TODO: implement this...
            // throw new NotImplementedException();
        }

        public void AddResource(List<IFeed> animals)
        {

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Duck House {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}