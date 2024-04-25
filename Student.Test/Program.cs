using Student.Test.Shembull;

string fullName = "Emri Mbiemri";
char gjinia = 'f';
int mosha = 20;

// asd
//Student.Test.Student student = new Student.Test.Student();
//student.FirstName = "Emri";

//Console.WriteLine(student.FirstName);

//Student.Test.Student student2 = new Student.Test.Student("Emri 2", "Mbiemri 2");

//Console.WriteLine(student2.FirstName);

var allStudents = new List<Student.Test.Student>()
{
    new Student.Test.Student()
    {
        FirstName = "Student 1"
    },
    new Student.Test.Student()
    {
        FirstName = "Student 2"
    }
};


foreach (var student in allStudents)
{
    Console.WriteLine(student.FirstName);
}

Console.ReadLine();
