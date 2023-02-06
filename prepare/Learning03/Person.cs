// public class PersonX
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public string GetInformalSignature()
//     {
//         return "Thanks, " + _firstName;
//     }

//     public string GetFormalSignature()
//     {
//         return "Sincerely, " + GetFullName();
//     }

//     private string GetFullName()
//     {
//         return _title + " " + _firstName + " " + _lastName;
//     }
// }

// *********************************

// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public string GetFirstName()
//     {
//         return _firstName;
//     }

//     public void SetFirstName(string firstName)
//     {
//         _firstName = firstName;
//     }

// }

// -----------------------
// public class Person
// {
//     private string _title;
//     private string _firstName;
//     private string _lastName;

//     public Person()
//     {
//         _title = "";
//         _firstName = "Anonymous";
//         _lastName = "Unknown";
//     }

//     public Person(string first, string last)
//     {
//         _title = "";
//         _firstName = first;
//         _lastName = last;
//     }

//     public Person(string title, string first, string last)
//     {
//         _title = title;
//         _firstName = first;
//         _lastName = last;
//     }
//     ...

// }


// insert to Program.cs
// Person p1 = new Person(); // Don't pass any information to get the default values
// Person p2 = new Person("Jane", "Doe"); // pass the first and last names
// Person p3 = new Person("Mrs.", "Jane", "Doe"); // pass all three variables