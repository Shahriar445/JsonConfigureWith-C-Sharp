using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonConfigure
{
    public class Employee
    {
      //  [JsonInclude] // add this key to json file 
        public string Email = "shahriarhaque445@gmail.com";
         //  [JsonIgnore]    --  for ignore the id to add in json file 
        public int Id { get; set; }
        [JsonPropertyName("Full Name")] // for changing the key name
        public string Name { get; set; }
        public string Description { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string Street { get; set; }
            public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

    }
}
