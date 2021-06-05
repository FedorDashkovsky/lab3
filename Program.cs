using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Student
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected int Age { get; set; }
        protected double Weight { get; set; }
        protected double Height { get; set; }
        protected string University { get; set; }
        protected string Speciality { get; set; }
        protected int Course { get; set; }
        public static string name()

        {
            string name;
            bool k = false;
            do
            {
                k = false;
                name = Console.ReadLine();
                while (name.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите имя и фамилию");
                    name = Console.ReadLine();
                }
                string name2 = name;
                for (int i = 0; i < name2.Length; i++)
                {
                    while (name2[i] < 'A' || (name2[i] > 'Z' && name2[i] < 'a') || name2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Только латиница");
                        k = true;
                        break;
                    }
                }
            } while (k);
            return name;
        }

        public static int input_int(string input_1, int return_1)
        {
            do
            {
                input_1 = Console.ReadLine();
                if (!int.TryParse(input_1, out return_1))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToInt32(input_1) < 0)
                {
                    Console.WriteLine("Такое значение не возможно");
                }
                else if (Convert.ToInt32(input_1) > 1000)
                {
                    Console.WriteLine("Такое значение не возможно");
                }
                else break;
            } while (true);
            return return_1;
        }

        public static double input_double(string input_2, double return_2)
        {
            do
            {
                input_2 = Console.ReadLine();
                if (!double.TryParse(input_2, out return_2))
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                }
                else if (Convert.ToDouble(input_2) < 0)
                {
                    Console.WriteLine("Такое значение не возможно");
                }
                else if (Convert.ToDouble(input_2) > 1000) 
                {
                    Console.WriteLine("Такое значение не возможно");
                }
                else break;
            } while (true);
            return return_2;
        }

        public static string input_string(StringBuilder string_1, string uni)
        {
            bool k = false;
            do
            {
                k = false;
                string_1 = new StringBuilder(Console.ReadLine());
                uni = string_1.ToString();
                while (uni.Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите ещё раз");
                    uni = Console.ReadLine();
                }
                for (int i = 0; i < uni.Length; i++)
                {
                    while (uni[0] == ' ')
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ещё раз");
                        uni = Console.ReadLine();
                    }
                }
                for (int i = 0; i < uni.Length; i++)
                {
                    if (uni[i] < ' ' || (uni[i] > ' ' && uni[i] < '-') || (uni[i] > '-' && uni[i] < 'A') || (uni[i] > 'Z' && uni[i] < 'a') || uni[i] > 'z')
                    {
                        Console.WriteLine("Только латиница");
                        Console.Clear();
                        k = true;
                        break;
                    }
                }
            } while (k);
            string[] String2 = uni.Split(' ');
            for (int i = 0; i < String2.Length; i++)
            {
                if (String2[i] != "")
                {
                    Console.Write(String2[i] + " ");
                }
            }
            Console.WriteLine();
            return uni;
        }

        public static int age()
        {
            string age1 = null;
            int Age1 = 0;
            input_int(age1, Age1);
            return Age1;
        }
        public static double weight()
        {
            string weight1 = null;
            double Weight1 = 0;
            input_double(weight1, Weight1);
            return Weight1;
        }
        public static double height()
        {
            string height1 = null;
            double Height1 = 0;
            input_double(height1, Height1);
            return Height1;
        }
        public static string university()
        {
            StringBuilder _University = null;
            string university = null;
            input_string(_University, university);
            return university;
        }
        public static int course()
        {
            int course = 0;
            string Course=null;
            input_int(Course, course);
            return course;
        }
        public void show()
        {
            Console.Clear();
            Console.WriteLine("Information about student.\nName: " + Name + "\nSurname: " + Surname + "\nAge: " + Age + "\nWeight: " + Weight + "\nHeight: " +
              Height + "\nUniversity: " + University + "\nCourse: " + Course + "\nSpecialty: " + Speciality + "\n");
        }
        public void rename0(ref string name1)
        {
            Console.WriteLine("Напишите новое имя");
            input_string(null, name1);
        }
        public void rename(ref string name1)
        {
            rename0(ref name1);
            Name = name1;
        }
        public void resurname()
        {
            Console.WriteLine("Введите новую фамилию");
            string name1;
            bool k = false;
            do
            {
                k = false;

                while ((name1 = Console.ReadLine()).Length == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Введите фамилию");
                    name1 = Console.ReadLine();
                }
                string name2;
                name2 = name1;
                for (int i = 0; i < name2.Length; i++)
                {
                    while (name2[i] < 'A' || (name2[i] > 'Z' && name2[i] < 'a') || name2[i] > 'z')
                    {
                        Console.Clear();
                        Console.WriteLine("Только латиница");
                        k = true;
                        break;
                    }
                }
            } while (k);
            Surname = name1;

        }

        public void Reage()
        {
            Console.WriteLine("Age:");
            string age1=null;
            int Age1=0;
            input_int(age1, Age1);
            Age = Convert.ToInt32(age1);
        }
        public void Reweight()
        {
            Console.WriteLine("Weight: ");
            string weight1=null;
            double Weight1=0;
            input_double(weight1, Weight1);
            Weight = Convert.ToDouble(weight1);
        }
        public void Reheight()
        {
            Console.WriteLine("Height: ");
            string height1=null;
            double Height1=0;
            input_double(height1, Height1);
            Height = Convert.ToDouble(height1);
        }
        public void Reuniversity()
        {
            Console.WriteLine("University: ");
            StringBuilder _University=null;
            string university=null;
            input_string(_University, university);
            Console.WriteLine();
            University = university;
        }
        public void Recourse()
        {
            Console.WriteLine("Course: ");
            int course=0;
            string Course1=null;
            input_int(Course1, course);
            Course = Convert.ToInt32(Course);
        }
        public void Respeciality()
        {
            Console.WriteLine("Speciality: ");
            StringBuilder _University = null;
            string university = null;
            input_string(_University, university);
            Console.WriteLine();
            Speciality = university;
        }
        public Student()
        {
            Console.WriteLine(" Введите имя: ");
            Name = Student.name();
            Console.WriteLine("Введиье фамилию: ");
            Surname = Student.name();
            Console.WriteLine("введите возраст: ");
            Age = Student.age();
            Console.WriteLine("введите вес: ");
            Weight = (int)Student.weight();
            Console.WriteLine("Введите рост: ");
            Height = (int)Student.height();
            Console.WriteLine("Введите название вуза: ");
            University = Student.university();
            Console.WriteLine("Введите название курса: ");
            Course = Student.course();
            Console.WriteLine("Введите свою специальность: ");
            Speciality = Student.university();
        }
    }
    class Program
    {
        public static string name1;

        static void Main(string[] args)
        {
            Student st = new Student();
            bool N = false;
            char digit;
            Console.Clear();
            while (N == false)
            {
                Console.WriteLine("\nChoose the number\n1.Show Infomation abot student.\n2.Chage name.\n3.Change Surname.\n" +
                    "4.Change age.\n5.Change weight.\n6.Change university.\n7.Chnge speciality.\n8.Change the course.\na.Change height.\n0. Exist\n");
                digit = Console.ReadKey().KeyChar;
                Console.Clear();
                switch (digit)
                {
                    case '1': st.show(); break;
                    case '2': st.rename(ref name1); break;
                    case '3': st.resurname(); break;
                    case '4': st.Reage(); break;
                    case '5': st.Reweight(); break;
                    case '6': st.Reuniversity(); break;
                    case '7': st.Respeciality(); break;
                    case '8': st.Recourse(); break;
                    case 'a': st.Reheight(); break;
                    case '0': N = true; break;
                    default: break;
                }
            }
        }
    }
}




