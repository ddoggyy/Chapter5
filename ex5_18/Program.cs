namespace ex5_18
{
    internal class Program
    {   
        class Student
        {
            public string name;
            public int grade;
        }

        static void Main(string[] args)
        {
            List<Student> list1 = new List<Student>(); // <generic>
            list1.Add(new Student { name = "윤인성", grade = 1 });
            list1.Add(new Student { name = "연하진", grade = 2 });
            list1.Add(new Student { name = "윤아린", grade = 3 });
            list1.Add(new Student { name = "윤명월", grade = 4 });
            list1.Add(new Student { name = "구지연", grade = 1 });
            list1.Add(new Student { name = "김연화", grade = 2 });

            foreach(var item in list1)
            {
                Console.WriteLine($"{item.name} : {item.grade}");
            }

            List<Student> list2 = new List<Student>()
            {
            new Student { name = "윤인성", grade = 1 },
            new Student { name = "연하진", grade = 2 },
            new Student { name = "윤아린", grade = 3 },
            new Student { name = "윤명월", grade = 4 },
            new Student { name = "구지연", grade = 1 },
            new Student { name = "김연화", grade = 2 }
            };

            foreach (var item in list2)
            {
                Console.WriteLine($"{item.name} : {item.grade}");
            }

            
            for (int i = list1.Count - 1; i >= 0; i--) // 1학년 이외의 학생 삭제
            {
                if (list1[i].grade > 1) list1.RemoveAt(i);
            }

            foreach (var item in list1)
            {
                Console.WriteLine($"{item.name} : {item.grade}");
            }
        }
    }
}
