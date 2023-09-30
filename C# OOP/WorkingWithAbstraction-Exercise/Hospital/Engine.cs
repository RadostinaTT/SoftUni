using System;
using System.Linq;

namespace Hospital
{
    public class Engine
    {
        private Hospital hospital;

        public Engine()
        {
            this.hospital = new Hospital();
        }
        public void Run()
        {
            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] input = command.Split();
                var departament = input[0];

                var firstName = input[1];
                var lastName = input[2];

                var patientName = input[3];

                var fullName = firstName + " " + lastName;

                this.hospital.AddDoctor(firstName, lastName);
                this.hospital.AddDepartment(departament);
                this.hospital.AddPatient(departament, fullName, patientName);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "End")
            {
                string[] input = command.Split();
                if (input.Length == 1)
                {
                    var departmentName = input[0];
                    var department = this.hospital.Departments.FirstOrDefault(de => de.Name == departmentName);

                    Console.WriteLine(department);
                }
                else
                {
                    bool isRoom = int.TryParse(input[1], out int resultRoom);
                    if (isRoom)
                    {
                        var departmentName = input[0];
                        var department = this.hospital.Departments.FirstOrDefault(de => de.Name == departmentName);
                        var currentRoom = department.Rooms[resultRoom -1];

                        Console.WriteLine(currentRoom);
                    }
                    else
                    {
                        var firstName = input[0];
                        var lastName = input[1];

                        var fullName = firstName + " " + lastName;

                        var doctor = this.hospital.Doctors.FirstOrDefault(d => d.FullName == fullName);

                        Console.WriteLine(doctor);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
