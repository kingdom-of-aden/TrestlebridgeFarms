using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Duck : IResource, IFeed {

        private Guid _id = Guid.NewGuid();

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        public double FeedPerDay { get; set; } = 0.8;
        public string Type { get; } = "Duck";

        // Methods
        public void Feed () {
            Console.WriteLine($"Duck {this._shortId} just ate {this.FeedPerDay}kg of feed");
        }

        public override string ToString () {
            return $"Duck {this._shortId}. QUACK!";
        }
    }
}