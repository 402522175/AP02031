

using s16;
using System;
using System.ComponentModel;
public class program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("*********    Welcome to the University_system    *********");
        var boss = new Teacher(3000, "Dr.Mansour", "Anbia", 1970);
        var university = new University("Iran University of science and Technology", "Islamic Republic of Iran", boss);
        bool succes = true;
        while (succes)
        {

            Console.WriteLine($"Please choose one of these options to enter.");
            Console.WriteLine($"{1} : university_parts");
            Console.WriteLine($"{2} : Departments");
            Console.WriteLine($"{3} : exit");
            int axx = int.Parse(Console.ReadLine());
            switch (axx)
            {
                case 1:
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine($"{1}: Add _department");
                    Console.WriteLine($"{2}: Show_departments");
                    Console.WriteLine($"{3}: Remove_departments");
                    Console.WriteLine("Please choose a number to enter the university_parts");
                    int ax = int.Parse(Console.ReadLine());
                    switch (ax)
                    {
                        case 1:
                            Console.WriteLine("please enter a new department: ");
                            Console.WriteLine("Please enter the first_name of the boss of new department: ");
                            string a = Console.ReadLine();
                            Console.WriteLine("Please enter the last_name of the boss of new department: ");
                            string b = Console.ReadLine();
                            Console.WriteLine("Please enter the Birth_Year of the boss of new department: ");

                            int c = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter the salary of the boss of the new department: ");
                            double d = double.Parse(Console.ReadLine());
                            var Boss = new Teacher(d, a, b, c);
                            Console.WriteLine("Department Name : ");
                            string x = Console.ReadLine();
                            var new_department = new Department(x, Boss);
                            new_department.Add_Teacher(Boss);
                            university.Add_Department(new_department);


                            Console.WriteLine("The department added successfully.");
                            break;
                        case 2:
                            if (university.departments.Count == 0)
                            {
                                Console.WriteLine("There is no departments here . please go to the add_departments option and create a new department.");
                            }
                            else
                            {
                                foreach (Department department in university.departments)
                                {
                                    Console.WriteLine(department.Name);
                                }
                            }
                            break;
                    }
                    break;
                    case 2:
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine($"{1} : add_teacher");
                    Console.WriteLine($"{2} : remove_teacher");
                    Console.WriteLine($"{3} : add_student");
                    Console.WriteLine($"{4} : show_informations");
                    Console.WriteLine($"{5} : Remove Student");
                    Console.WriteLine($"{6} : student_groups");
                    Console.WriteLine($"{7} : Calculate_salaries");
                    int ae = int.Parse(Console.ReadLine());
                    switch (ae)
                    {
                        case 1:
                            Console.WriteLine("please enter the Department you want :");
                            string sa = Console.ReadLine();
                            foreach (Department department in university.departments)
                            {
                                Console.WriteLine(department.Name);
                            }
                            foreach (Department dep in university.departments)
                            {
                                if (dep.Name == sa)
                                {
                                    Console.WriteLine("Enter the first name of new professor :");
                                    string si = Console.ReadLine();
                                    Console.WriteLine("Enter the last name of new professor: ");
                                    string al = Console.ReadLine();
                                    Console.WriteLine("Enter the salary of the new professor: ");
                                    double ah = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the Birth year of the new professor: ");
                                    int bir = int.Parse(Console.ReadLine());
                                    var teach = new Teacher(ah, si, al, bir);
                                    dep.Add_Teacher(teach);
                                }
                                else
                                {
                                    Console.WriteLine("The Department was not found");
                                }
                            }
                            break;
                        case 2:
                            Console.WriteLine("Please choose one of these options to be deleted.");
                            string ab = Console.ReadLine();
                            foreach (Department dep in university.departments)
                            {
                                for (int i = 0; i < dep.Teachers.Count; i++)
                                {
                                    if (dep.Teachers[i].f_Name == ab)
                                    {
                                        dep.Remove_Teacher(dep.Teachers[i]);
                                    }
                                }
                            }
                            break;
                        case 3:
                            
                            Console.WriteLine("Please Enter the first_name of the student you want : ");
                            string s = Console.ReadLine();
                            Console.WriteLine("Please Enter the last_name of the student you want : ");
                            string l_name = Console.ReadLine();
                            Console.WriteLine("Please Enter the the year that the student is born: ");
                            int year = int.Parse(Console.ReadLine());
                            var st = new Student(s,l_name,year);
                            Console.WriteLine("Please Enter the name of the department you want to add the student :");
                            string a = Console.ReadLine();  
                            foreach(Department de in university.departments)
                            {
                                if (de.Name == a)
                                {
                                    de.Add_Student(st);
                                }
                            }
                            
                            break;
                        case 4:
                            Console.WriteLine("Please Enter the name of the department you want to see the informations :");
                            string ss = Console.ReadLine();
                            foreach(Department di in university.departments)
                            {
                                if (di.Name == ss)
                                {
                                    if ((di.students== null) && (di.Teachers ==null)&&(di.studentGroups ==null)&& (di.employees == null))
                                    {
                                        Console.WriteLine("The department has no members");
                                    }
                                    else
                                    {
                                        di.show_features();
                                    }
                                }
                            }
                            break;
                        case 5:
                            foreach (Department d in university.departments)
                            {
                                Console.WriteLine($"{d.Name} {d.students}");
                            }
                            Console.WriteLine("Enter the department you want to remove the student.");
                            string aa = Console.ReadLine();
                            Console.WriteLine("Enter the first name of the Student you want to remove :");
                            string ac = Console.ReadLine();
                            Console.WriteLine("Enter the last name of the student you want to remove : ");
                            string ad = Console.ReadLine();
                            foreach(Department de in university.departments  )
                            {
                                if (de.Name == aa)
                                {
                                    for(int i = 0; i < de.students.Count; i++)
                                    {
                                        if ((ac == de.students[i].f_Name)&&(ad == de.students[i].L_name))
                                        {
                                            de.Remove_Student(de.students[i]);
                                        }
                                    }
                                }
                            }
                            break;
                        case 6:
                            Console.WriteLine("____________________________________________________________");
                            Console.WriteLine();
                            Console.WriteLine($"{1} : add_student Groups");
                            Console.WriteLine($"{2} : remove_student Groups");
                            Console.WriteLine($"{3} : add_member");
                            Console.WriteLine($"{4} : remove_member");
                            int af = int.Parse( Console.ReadLine() );
                            switch (af)
                            {
                                case 1:
                                    Console.WriteLine("Enter the name of the Department you want to add the student Group : ");
                                    string ag = Console.ReadLine();
                                    Console.WriteLine("Enter the name of the Student group you want to add : ");
                                    string ah = Console.ReadLine();
                                    Console.WriteLine("Enter the id   of the head of Student groups :");
                                    int ak = int.Parse( Console.ReadLine() );
                                    string ai = Console.ReadLine();
                                    
                                    foreach(Department depa in university.departments)
                                    {
                                        
                                        if (depa.Name == ag)
                                        {
                                            foreach(Student stud in depa.students)
                                            {
                                                if ((stud.Std_id == ak))
                                                {
                                                    var group = new StudentGroups(ah, stud);
                                                    depa.Add_Groups(group);
                                                }
                                            }
                                            
                                        }
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("-----------------------------------------------------------");
                                    Console.WriteLine();
                                    Console.WriteLine("Enter the name of the student group you want to remove : ");
                                    string al = Console.ReadLine();
                                    foreach(Department depat in university.departments)
                                    {
                                        foreach(StudentGroups stg in depat.studentGroups)
                                        {
                                            if(stg.sG_name == al)
                                            {
                                                depat.Remove_Groups(stg);
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Please enter the name of the student_group you want to add student");
                                    string sx = Console.ReadLine();
                                    Console.WriteLine("enter the first name of member you want to add to the student_group");
                                    string sy = Console.ReadLine(); 
                                    foreach(Department dep in university.departments)
                                    {
                                        foreach(Student student in dep.students)
                                        {
                                            foreach (StudentGroups std in dep.studentGroups)
                                            {
                                                if(std.sG_name == sx)
                                                {
                                                    if(student.f_Name == sy)
                                                    {
                                                        std.Add_member(student);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the name of the department you want to remove the student");
                                    string sz = Console.ReadLine();
                                    Console.WriteLine("Enter the first name of the student you want to remove ");
                                    string su = Console.ReadLine();
                                    foreach(Department de in university.departments)
                                    {
                                        foreach(Student stud in de.students)
                                        {
                                            foreach(StudentGroups stg in de.studentGroups)
                                            {
                                                if (stg.sG_name.Equals(sz))
                                                {
                                                    if (stud.f_Name.Equals(su))
                                                    {
                                                        stg.Remove_members(stud);
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("The student was not found or the name of student is incorrect.");
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("The student group " + stg.sG_name + " was not found.");
                                                }
                                            }
                                        }
                                    }
                                    break;
                            }
                            break;
                        case 7:
                            Console.WriteLine("Enter the name of the Department you want to Calculate the salaries");
                            string am = Console.ReadLine();
                            foreach(Department d in  university.departments)
                            {
                                if (d.Name == am)
                                {
                                    d.Calculate_salaries();
                                }
                            }
                            break;
                    }
                    break;
                     case 3:
                        succes = false;
                        
                        break;
                    
                    


                    //case 3:
                    //    Console.WriteLine($"{1} : add_teacher");
                    //    Console.WriteLine($"{2} : remove_teacher");
                    //    int ae = int.Parse(Console.ReadLine());
                    //    switch (ae)
                    //    {
                    //        case 1:
                    //            Console.WriteLine("please enter the Department you want :");
                    //            string sa = Console.ReadLine();
                    //            foreach (Department department in university.departments)
                    //            {
                    //                Console.WriteLine(department.Name);
                    //            }
                    //            foreach (Department dep in university.departments)
                    //            {
                    //                if (dep.Name == sa)
                    //                {
                    //                    Console.WriteLine("Enter the first name of new professor :");
                    //                    string s = Console.ReadLine();
                    //                    Console.WriteLine("Enter the last name of new professor: ");
                    //                    string al = Console.ReadLine();
                    //                    Console.WriteLine("Enter the salary of the new professor: ");
                    //                    double ah = double.Parse(Console.ReadLine());
                    //                    Console.WriteLine("Enter the Birth year of the new professor: ");
                    //                    int bir = int.Parse(Console.ReadLine());
                    //                    var teach = new Teacher(ah, s, al, bir);
                    //                    dep.Add_Teacher(teach);
                    //                }
                    //                else
                    //                {
                    //                    Console.WriteLine("The Department was not found");
                    //                }
                    //            }
                    //            break;
                    //        case 2:
                    //            Console.WriteLine("Please choose one of these options to be deleted.");
                    //            string ab = Console.ReadLine();
                    //            foreach (Department dep in university.departments)
                    //            {
                    //                for (int i = 0; i < dep.Teachers.Count; i++)
                    //                {
                    //                    if (dep.Teachers[i].f_Name == ab)
                    //                    {
                    //                        dep.Remove_Teacher(dep.Teachers[i]);
                    //                    }
                    //                }
                    //            }
                    //            break;
                    //    }
                    //    break;


            }
            
                
                
            }
        }
    }





