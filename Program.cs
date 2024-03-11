using System;
using System.Collections.Generic;

class ClubMembers
{
    private List<string> Members = new List<string>();
    public string ClubType { get; set; }
    public string ClubLocation { get; set; }
    public string MeetingDate { get; set; }

    // Default constructor
    public ClubMembers()
    {
        // Initialize properties
        ClubType = "";
        ClubLocation = "";
        MeetingDate = "";
    }

    // Indexer get and set methods
    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < Members.Count)
                return Members[index];
            else
                throw new IndexOutOfRangeException();
        }
        set
        {
            if (index >= 0 && index < Members.Count)
                Members[index] = value;
            else
                throw new IndexOutOfRangeException();
        }
    }

    // Add a method to get the number of members
    public int NumberOfMembers()
    {
        return Members.Count;
    }

    // Add a method to add a member
    public void AddMember(string member)
    {
        Members.Add(member);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a new ClubMembers object
        ClubMembers club = new ClubMembers();

        // Prompt user to input club information
        Console.WriteLine("Enter club information:");
        Console.Write("Club Type: ");
        club.ClubType = Console.ReadLine();

        Console.Write("Club Location: ");
        club.ClubLocation = Console.ReadLine();

        Console.Write("Meeting Date: ");
        club.MeetingDate = Console.ReadLine();

        // Prompt user to input club members
        Console.WriteLine("Enter club members (type 'done' when finished):");
        string memberName;
        do
        {
            Console.Write("Member Name: ");
            memberName = Console.ReadLine();
            if (memberName.ToLower() != "done")
                club.AddMember(memberName);
        } while (memberName.ToLower() != "done");

        // Display the club information
        Console.WriteLine("\nClub Information:");
        Console.WriteLine($"Club Type: {club.ClubType}");
        Console.WriteLine($"Club Location: {club.ClubLocation}");
        Console.WriteLine($"Meeting Date: {club.MeetingDate}");
        Console.WriteLine($"Number of Members: {club.NumberOfMembers()}");
        Console.WriteLine("Club Members:");
        for (int i = 0; i < club.NumberOfMembers(); i++)
        {
            Console.WriteLine($"Member {i + 1}: {club[i]}");
        }

        // Wait for user input to close the console window
        Console.ReadLine();
    }
}
