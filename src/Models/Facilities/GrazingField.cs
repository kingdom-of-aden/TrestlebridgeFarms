using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 50;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();


        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(IGrazing animal)
        {
            if(animal is IGrazing){
            //this code adds the animal to the list
            _animals.Add(animal);
            } else {
                Console.WriteLine("This animal is no grazer. Try again.");
                Thread.Sleep(3000);

            }
            // TODO: implement this...
            // throw new NotImplementedException();
        }

        public void AddResource(List<IGrazing> animals)
        {

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Grazing field {shortId} has {this._animals.Count} animals\n");
            this._animals.ForEach(a => output.Append($"   {a}\n"));

            return output.ToString();
        }
    }
}