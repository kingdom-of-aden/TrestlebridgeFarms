using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<ISeedProducing>
    {

        private int _rows = 13;

        private int _plantsPerRow = 5;

        public double Capacity
        {
            get
            {
                return _rows * _plantsPerRow;
            }
        }

        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();


        public void AddResource(ISeedProducing plant)
        {
            //this code adds the animal to the list
            _plants.Add(plant);
            Thread.Sleep(3000);

            // TODO: implement this...
            // throw new NotImplementedException();
        }

        public void AddResource(List<ISeedProducing> plants)
        {

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"The plowed field {shortId} has {this._plants.Count} plants in it\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}