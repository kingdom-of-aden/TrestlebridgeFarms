using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {

        // Lists for facilities

        //This list needs to have a set in order to be able to add new grazing fields
        public List<GrazingField> GrazingFields { get;} = new List<GrazingField>();

        public List<ChickenCoop> ChickenCoops { get; } = new List<ChickenCoop>();


        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        public void PurchaseResource<T> (IResource resource, int index)
        {
            Console.WriteLine(typeof(T).ToString());
            switch (typeof(T).ToString())
            {
                case "Cow":
                    GrazingFields[index].AddResource((IGrazing)resource);
                    break;
                default:
                    break;
            }
        }

        public void AddGrazingField (GrazingField field)
        {
            GrazingFields.Add(field);
        }

        public void AddChickenCoop (ChickenCoop coop)
        {
            ChickenCoops.Add(coop);
        }


        public override string ToString()
        {
            StringBuilder report = new StringBuilder();

            GrazingFields.ForEach(gf => report.Append(gf));
            ChickenCoops.ForEach(cc => report.Append(cc));

            return report.ToString();
        }
    }
}