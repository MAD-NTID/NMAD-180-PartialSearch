// create three parallel arrays to store UUID, major, and GPA
string[] uuids = { "0011356", "0621356", "0021351", "0044526", "0044588" };
string[] majors = { "Computer Science", "Mathematics", "Biology", "Physics", "Engineering" };

double[] gpas = { 3.5, 3.2, 3.9, 3.7, 3.8 };

//show the headings
Console.WriteLine("{0,-12}{1,-17}{2,12}", "UUID", "MAJOR", "GPA");
Console.WriteLine("{0,-12}{1,-17}{2,12}", "====", "=====", "===");

// print the arrays to the console
for (int i = 0; i < uuids.Length; i++)
{
    
    Console.WriteLine("{0,-12}{1,-17}{2,12}", uuids[i], majors[i], gpas[i]);
    //Console.WriteLine("UUID: {0:-17} | Major: {1:17} | GPA: {2:30}", uuids[i], majors[i], gpas[i]);
}

/***
* 1. Ask the user to input a UUID to search for.
* 2. Loop through the uuids array and check if any of the UUIDs contain the input string. 
      You can use the Contains(), indexOf, or other string theories method of the string class for this.
  3. If a match is found, print out the UUID, major, and GPA of all students whose UUIDs contain the input string. To do this, you can use a loop to iterate over the uuids array, and then use the index to access the corresponding values in the majors and gpas arrays.
  4. If no match is found, print out "No match found".

  YOU DO NOT NEED TO DO ANY VALIDATIONS
**/

Console.WriteLine();

//PROMPT THE USER FOR THE UUID THAT THEY WANT TO SEARCH FOR HERE


//ADD HEADING HERE


//SEARCH THE ARRAY HERE
