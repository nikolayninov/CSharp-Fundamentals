using System;
using System.Collections.Generic;
using System.Linq;

namespace Google {
    public class Pokemon {
        private string name;
        private string type;
        public Pokemon(string name, string type) {
            this.name = name;
            this.type = type;
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Type {
            get { return this.type; }
            set { this.type = value; }
        }
        public override string ToString() {
            return $"{this.name} {this.type}";
        }
    }
}