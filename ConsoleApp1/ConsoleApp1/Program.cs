// See https://aka.ms/new-console-template for more information
using Bookify.Domain.Model;
using Bookify.Domain.Services;

List<User> users = new List<User>();
users.Add(new User("1", "daniel.nicu@amd.com", "1", "Daniel"));
users.Add(new User("2", "daniel.nicu@amd.com", "12", "Daniel"));
users.Add(new User("3", "daniel.nicu@amd.com", "123", "Daniel"));
users.Add(new User("4", "daniel.nicu@amd.com", "1234", "Daniel"));
users.Add(new User("5", "daniel.nicu@amd.com", "12345", "Daniel"));

var currentUser = users.ElementAt(0);

try
{
    var a = currentUser.getPreferences();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();