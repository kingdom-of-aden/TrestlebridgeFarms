using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IFacility<ISeedProducing>
    {
        private int _row = 10;
        private int _plantsPerRow =16 ;
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();


        public double Capacity
        {
            get
            {
                return _row * _plantsPerRow;
            }
        }

        public void AddResource(ISeedProducing plants)
        {
            //this code adds the plants to the list
            _plants.Add(plants);

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

            output.Append($"Natural field {shortId} has {this._plants.Count} plants\n");
            this._plants.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}