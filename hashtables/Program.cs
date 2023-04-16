using System.Collections;



internal partial class Program
{
    private static void Main(string[] args)
    {
        Student[] students = new Student[5];

        students[0] = new Student(1, "Jerry", 88);
        students[1] = new Student(2, "Elaine", 75);
        students[2] = new Student(3, "Kramer", 91);
        students[3] = new Student(1, "George", 45);
        students[4] = new Student(4, "Newman", 89);

       
        Hashtable studTable = new Hashtable();

        foreach (Student s in students)
        {
            if(!studTable.ContainsKey(s.id))
            {
                studTable.Add(s.id, s);
            }

        }

        
        foreach (DictionaryEntry entry in studTable)
        {
            Student temp = (Student)entry.Value;
            System.Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", temp.id, temp.Name, temp.GPA);
        }





        // Student stud1 = new Student(1, "Jerry Seinfeld", 3.65f);
        // Student stud2 = new Student(2, "Elaine Beness", 3.21f);
        // Student stud3 = new Student(3, "Cosmo Kramer", 1.75f);
        // Student stud4 = new Student(4, "George Costanza", 2.83f);

        // studentsTable.Add(stud1.id, stud1);
        // studentsTable.Add(stud2.id, stud2);
        // studentsTable.Add(stud3.id, stud3);
        // studentsTable.Add(stud4.id, stud4);

        //retrieve one value in table
        // Student storedStudent1 = (Student)studentsTable[stud1.id];

        //retrieve all values
        // foreach (DictionaryEntry entry in studentsTable)
        // {
        //     Student temp = (Student)entry.Value;
        //     System.Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", temp.id, temp.Name, temp.GPA);
        // }

        // System.Console.WriteLine("Student ID: {0}, Name: {1}, GPA: {2}", storedStudent1.id, storedStudent1.Name, storedStudent1.GPA);
       
    }
}

 class Student
        {
            public int id { get; set;}

            public string Name {get; set;}

            public float GPA {get; set;}

            public Student(int id, string name, float GPA)
            {
                this.id = id;
                this.Name = name;
                this.GPA = GPA;
            }


        }