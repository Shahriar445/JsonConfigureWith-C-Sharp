
using JsonConfigure;
using System.Text.Json;

/* For Serialization 
var employee = new Employee()
{
    Id = 1,
    Name = "sha",
    Description = "sdfasdf",
    Address = new Address()
    {
        State = "123 st",
        City = "Dhaka",
        Street = "moui",
        PostalCode = "343"
    }
};

// Serialization -- convert c# json file 
// Serialize - process is converting c# object to json
var options = new JsonSerializerOptions();
options.WriteIndented = true;
var json = JsonSerializer.Serialize(employee,options);

File.WriteAllText("C:\\Users\\Hameem\\Desktop\\Intern - Shahriar Haque (Shipon)\\C# Console\\JsonConfigure\\JsonConfigure\\employee.json", json); // Save all the file to json file 
Console.WriteLine(json);

*/


var employee = File.ReadAllText("C:\\\\Users\\\\Hameem\\\\Desktop\\\\Intern - Shahriar Haque (Shipon)\\\\C# Console\\\\JsonConfigure\\\\JsonConfigure\\\\employee.json");

Employee ob = JsonSerializer.Deserialize<Employee>(employee);

Console.WriteLine(ob.Name);


