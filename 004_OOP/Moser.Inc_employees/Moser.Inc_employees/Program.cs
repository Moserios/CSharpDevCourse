class Company
{
    static void Main()
    {
        //loal constants
        const string OrganizationName = "Moser Inc.";

        //creating objects
        Employee sergey_m = new Employee();
        Employee yury_k = new Employee();
        Employee eduard_l = new Employee();
        Employee andrey_i = new Employee();
        Employee tatiana_r = new Employee(); 
        Employee svetlana_s = new Employee();
        Employee bogdan_v = new Employee();
        Employee nadezhda_m = new Employee();
        Employee sergey_s = new Employee();
        Employee milosh_t = new Employee();

        //initialize fields
        sergey_m.EmpID = 1;
        sergey_m.name = "Sergey";
        sergey_m.surename = "M";
        sergey_m.sex = "M";
        sergey_m.address = "Serbia";
        sergey_m.position = "QA";
        sergey_m.NoOfWorkingHours = 176;
        sergey_m.SalaryPerHour = 20;

        yury_k.EmpID = 2;
        yury_k.name = "Yury";
        yury_k.surename = "K";
        yury_k.sex = "M";
        yury_k.address = "Armenia";
        yury_k.position = "Fullstack developer";
        yury_k.NoOfWorkingHours = 176;
        yury_k.SalaryPerHour = 25;

        eduard_l.EmpID = 3;
        eduard_l.name = "Eduard";
        eduard_l.surename = "L";
        eduard_l.sex = "M";
        eduard_l.address = "Serbia";
        eduard_l.position = "Delivery Manager";
        eduard_l.NoOfWorkingHours = 176;
        eduard_l.SalaryPerHour = 25;

        andrey_i.EmpID = 4;
        andrey_i.name = "Andrey";
        andrey_i.surename = "I";
        andrey_i.sex = "M";
        andrey_i.address = "Serbia";
        andrey_i.position = "Fullstack developer";
        andrey_i.NoOfWorkingHours = 176;
        andrey_i.SalaryPerHour = 25;

        tatiana_r.EmpID = 5;
        tatiana_r.name = "Tatiana";
        tatiana_r.surename = "R";
        tatiana_r.sex = "W";
        tatiana_r.address = "Serbia";
        tatiana_r.position = "Delivery Manager";
        tatiana_r.NoOfWorkingHours = 176;
        tatiana_r.SalaryPerHour = 30;

        svetlana_s.EmpID = 6;
        svetlana_s.name = "Svetlana";
        svetlana_s.surename = "S";
        svetlana_s.sex = "W";
        svetlana_s.address = "Serbia";
        svetlana_s.position = "PM";
        svetlana_s.NoOfWorkingHours = 176;
        svetlana_s.SalaryPerHour = 25;

        bogdan_v.EmpID = 7;
        bogdan_v.name = "Bogdan";
        bogdan_v.surename = "V";
        bogdan_v.sex = "M";
        bogdan_v.address = "Argentina";
        bogdan_v.position = "Fullstack develper";
        bogdan_v.NoOfWorkingHours = 176;
        bogdan_v.SalaryPerHour = 30;

        nadezhda_m.EmpID = 8;
        nadezhda_m.name = "Nadezhda";
        nadezhda_m.surename = "M";
        nadezhda_m.sex = "W";
        nadezhda_m.address = "Armenia";
        nadezhda_m.position = "HR";
        nadezhda_m.NoOfWorkingHours = 176;
        nadezhda_m.SalaryPerHour = 30;

        sergey_s.EmpID = 9;
        sergey_s.name = "Sergey";
        sergey_s.surename = "S";
        sergey_s.sex = "M";
        sergey_s.address = "Russia";
        sergey_s.position = "Admin";
        sergey_s.NoOfWorkingHours = 176;
        sergey_s.SalaryPerHour = 30;

        milosh_t.EmpID = 10;
        milosh_t.name = "Milosh";
        milosh_t.surename = "T";
        milosh_t.sex = "M";
        milosh_t.address = "Serbia";
        milosh_t.position = ".NET Developer";
        milosh_t.NoOfWorkingHours = 176;
        milosh_t.SalaryPerHour = 25;

        //adding objects to the array
        object[] users  = new object[] { sergey_m, yury_k, eduard_l, andrey_i, tatiana_r, svetlana_s, bogdan_v, nadezhda_m, sergey_s, milosh_t };

        //printing
        System.Console.WriteLine($"Company name: {OrganizationName}.");
        System.Console.WriteLine($"Employees total number: {Employee.employeesNumber}.");

        //looping the elements of the array
        for (int i = 0; i < users.Length; i++)
        {
            Employee emp = users[i] as Employee;
            System.Console.WriteLine($"\nEmployees id: {emp.EmpID}.");
            System.Console.WriteLine($"Employees name: {emp.name}.");
            System.Console.WriteLine($"Employees surename: {emp.surename}.");
            System.Console.WriteLine($"Employees sex: {emp.sex}.");
            System.Console.WriteLine($"Employees address: {emp.address}.");
            System.Console.WriteLine($"Employees position: {emp.position}.");
            System.Console.WriteLine($"Employees type: {Employee.TypeOfEmployee}.");
            System.Console.WriteLine($"Employees department: {emp.DepartmentName}.");
            System.Console.WriteLine($"Employees work hours per month: {emp.NoOfWorkingHours}.");
            System.Console.WriteLine($"Employees salary per hour: {emp.SalaryPerHour}.");
            System.Console.WriteLine($"Net Salary: {emp.SalaryPerHour * emp.NoOfWorkingHours}.");

            System.Console.WriteLine($"\nShow next employee (Y/N)");
            string userResponse = System.Console.ReadLine();
            if (userResponse == "Y" || userResponse == "y")
            {
                continue;
            }
            else 
            {
                break; 
            }
        }
    }
}