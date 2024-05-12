//Assignment: Create a medical bot application
//The application can prescribe medication based on the patient's symptoms and age.


//Your task is to create a C# console application that simulates a medical bot named Bob. Bob should be able to prescribe medication based on the symptoms of a patient passed as an argument.

//You should create two classes - MedicalBot and Patient - to implement this functionality.



//Part 1: MedicalBot class
//The MedicalBot class should have a constant string variable named BotName with the value "Bob" that represents the name of the medical bot.

//It should have a static method called GetBotName() that returns value of "BotName" constant.

//The MedicalBot class should also have a method named PrescribeMedication() that takes a Patient object as an argument. The PrescribeMedication() method should determine the medication to prescribe based on the symptoms of the patient.

//void PrescribeMedication(Patient patient)

//If the patient's symptoms are a headache, prescribe ibuprofen.
//If the patient's symptoms are skin rashes, prescribe diphenhydramine.
//If the patient's symptoms are dizziness, check if the patient has a medical history of diabetes. If they do, prescribe metformin. Otherwise, prescribe dimenhydrinate.

//The PrescribeMedication() method should invoke another local function called GetDosage() to specify dosage of the specified medicine.
//string GetDosage(string medicineName)

//The GetDosage() method receives he medicine name prescribed by the PrescribeMedication() method and returns corresponding dosage as follows:

//If the medicine name is ibuprofen:
//If the patient's age is less than 18, then the dosage is 400 mg. Otherwise, the dosage is 800 mg.


//If the medicine name is diphenhydramine:
//If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 300 mg.


//If the medicine name is dimenhydrinate:
//If the patient's age is less than 18, then the dosage is 50 mg. Otherwise, the dosage is 400 mg.


//If the medicine name is metformin, then the dosage is 500 mg for all patients.

using System.Dynamic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class MedicalBot
{
    const string BotName = "Bob";

    public static string GetBotName()
    { 
        return BotName;
    }

    public void PrescribeMedication(Patient patient)
    {
        string symptom = patient.GetSymptomCode();


        string GetDosage(string medicineName)
        {
            if (medicineName == "ibuprofen")
            {
                if (patient.GetAge() < 18)
                {
                    return "400mg";
                }
                else
                {
                    return "800mg";
                }
            }

            else if (medicineName == "diphenhydramine")
            {
                if (patient.GetAge() < 18)
                {
                    return "50mg";
                }
                else
                {
                    return "300mg";
                }
            }

            else if (medicineName == "dimenhydrinate")
            {
                if (patient.GetAge() < 18)
                {
                    return "50mg";
                }
                else
                {
                    return "400mg";
                }
            }

            else if (medicineName == "metformin")
            {
                return "500mg";
            }

            else 
            {
                return "Unknown medicine name.";
            }

        }

        string message = "Your prescription based on your age, symptoms and medical history:\n ";
        if (symptom.ToLower() == "headache")
        {
            string DoseVAmount = GetDosage("ibuprofen");
            System.Console.WriteLine($"{message}\"ibuprofen\" {DoseVAmount}");
        }
        else if (symptom.ToLower() == "skin rashes")
        {
            string DoseVAmount = GetDosage("diphenhydramine");
            System.Console.WriteLine($"{message}\"diphenhydramine\" {DoseVAmount}");
        }
        else if (symptom.ToLower() == "dizziness")
        {
            if (patient.GetMedicalHistory() == "Diabetes")
            {
                string DoseVAmount = GetDosage("metformin");
                System.Console.WriteLine($"{message}\"metformin\" {DoseVAmount}");
            }
            else 
            {
                string DoseVAmount = GetDosage("dimenhydrinate");
                System.Console.WriteLine($"{message}\"dimenhydrinate\" {DoseVAmount}");
            }
        }
        else
        {
            System.Console.WriteLine($"Patient symptome is: {symptom}.");
        }
    }
}



//Part 2: Patient class
//The Patient class should have the following fields:

//name: A string representing the name of the patient.
//age: An integer representing the age of the patient.
//gender: A string representing the gender of the patient.
//medicalHistory: A string representing the medical history of the patient.
//symptomCode: A string representing the code for the symptoms of the patient.
//prescription: A string representing the medication prescribed to the patient.


//The Patient class should also have essential set / get methods for all the above fields. The Get methods returns the value of corresponding field. The Set methods should perform appropriate validation and assign the value into the field only if a valid value is supplied as argument. The Set methods should return a boolean value indicating whether the value is valid or not. If the value is valid, it should return true; otherwise false. In case of invalid value, an error message should be returned as "out" parameter. In case of valid value, an empty string should be returned as error message as "out" parameter.


class Patient
{
    private string patientName;
    private int patientAge;
    private string patientGender;
    private string patientMedicalHistory;
    internal string patientSymptomCode;
    private string patientPrescription;
    //internal bool isDiabetesHistoryExists = false;


    //GetName(): Returns the name of the patient.
    //SetName(string name, out string errorMessage): Sets the name of the patient and validates it. Returns a bool indicating whether the name is valid or not, and an error message if it's invalid. The name should not be null or empty. Patient name should contain at least two or more characters.

    string errorMessage;
    public string GetName()
    {
        return patientName;
    }
    public bool SetName(string name, out string errorMessage)
    {
        errorMessage = "";
        if (name.Length >= 2 && name != null)
        {             
            patientName = name;
            return true;
        }
        else 
        {
            errorMessage = "Invalid name: name should be not NULL and has at least two letters.";
            return false;
        }
    }


    //GetAge(): Returns the age of the patient.
    //SetAge(int age, out string errorMessage): Sets the age of the patient and validates it. Returns a bool indicating whether the age is valid or not, and an error message if it's invalid. Patient age can't be negative. Patient age can't be greater than 100.

    public int GetAge()
    {
        return patientAge;
    }
    public bool SetAge(int age, out string errorMessage)
    {
        errorMessage = "";
        if (age >= 0 && age <= 100)
        {
            patientAge = age;
            return true;
        }
        else
        {
            errorMessage = "Invalid age: age should be between 0 and 100.";
            return false;
        }
    }


    //GetGender(): Returns the gender of the patient.
    //SetGender(string gender, out string errorMessage): Sets the gender of the patient and validates it. Returns a bool indicating whether the gender is valid or not, and an error message if it's invalid. Patient gender should be either Male, Female or Other
    public string GetGender()
    {
        return patientGender;
    }
    public bool SetGender(string gender, out string errorMessage)
    {
        errorMessage = "";
        if (gender == "Male" || gender == "Female")
        {
            patientGender = gender;
            return true;
        }
        else
        {
            errorMessage = "Invalid gender: should be Male of Female.";
            return false;
        }
    }


    //GetMedicalHistory(): Returns the medical history of the patient.
    //SetMedicalHistory(string medicalHistory): Sets the medical history of the patient. No specific validations need to be checked for this value.
    public string GetMedicalHistory()
    {
        return patientMedicalHistory;
    }
    public bool SetMedicalHistory(string medicalHistory, out string errorMessage)
    {
        errorMessage = "";
        patientMedicalHistory = medicalHistory;
        return true;
    }


    //SetSymptomCode(string symptomCode, out string errorMessage): Sets the symptom code of the patient. Symptom Code should either be S1, S2, or S3.
    //GetSymptoms(): Returns the symptom description based on the current value of 'symptomCode' field.
    //S1 / s1: Headache
    //S2 / s2: Skin rashes
    //S3 / s3: Dizziness
    //Any other value: Unknown

    public bool SetSymptomCode(string symptomCode, out string errorMessage)
    {
        errorMessage = "";
        patientSymptomCode = symptomCode;
        return true;
    }
    public string GetSymptomCode()
    {
        switch (patientSymptomCode)
        {
            case "S1": return "Headache"; break;
            case "S2": return "Skin rashes"; break;
            case "S3": return "Dizziness"; break;
            default: return "Unknown"; break;
        }
    }


    //GetPrescription(): Returns the medication prescribed to the patient.
    //SetPrescription(string prescription): Sets the medication prescribed to the patient. No specific validations need to be checked for this value.
    public string GetPrescription()
    {
        return patientPrescription;
    }
    public bool SetPrescription(string prescription)
    { 
        patientPrescription = prescription;
        return true;
    }

}




//Part 3: Main() method
//This application will be used by patient users. The Main() method (entry point) should read all inputs (patient name, age, gender, medical history, symptoms etc.) from the patient and call "PrescribeMedication()" method of MedicalBot class and display the result prescription that was returned by the PrescribeMedication() method.

class Programm
{
    public static void Main()
    {
        System.Console.WriteLine("Hello, my name is Bob and I'm a medical bot to help you with medication.\nEnter your (patient) details:");
        System.Console.Write("Enter Patient Name: ");
        string name = System.Console.ReadLine();

        System.Console.Write("Enter Patient Age: ");
        int age = int.Parse(System.Console.ReadLine());

        System.Console.Write("Enter Patient Gender: ");
        string gender = System.Console.ReadLine();

        System.Console.Write("Enter Medical History. (Eg: Diabetes or Press Enter for None): ");
        string medHist = System.Console.ReadLine();


        Patient patient = new Patient();
        string errorMessage = "";
        bool nameSet = patient.SetName(name, out errorMessage);
        bool ageSet = patient.SetAge(age, out errorMessage);
        bool genderSet = patient.SetGender(gender, out errorMessage);
        bool medHistSet = patient.SetMedicalHistory(medHist, out errorMessage);

        System.Console.WriteLine($"\nWelcome, {patient.GetName()}, {patient.GetAge()}");

        System.Console.Write("Which of the following symptoms do you have:\n S1.Headache\n S2.Skin rashes\n S3. Dizziness\nEnter the symptom code from above list (S1, S2 or S3): ");
        string symptoms = System.Console.ReadLine();

        bool symptomsSet = patient.SetSymptomCode(symptoms, out errorMessage);

        MedicalBot medicalBot = new MedicalBot();
        medicalBot.PrescribeMedication(patient);

        System.Console.WriteLine($"Thank you for coming, {patient.GetName()}.");
        System.Console.ReadKey();
    }
}


//Sample Output 1:
//Hi, I'm Bob. I'm here to help you in your medication.
//Enter your (patient) details:
//Enter Patient Name: William
//Enter Patient Age: 30
//Enter Patient Gender: Male
//Enter Medical History. Eg: Diabetes.Press Enter for None: Diabetes

//Welcome, William, 30.
//Which of the following symptoms do you have:
//S1.Headache
//S2.Skin rashes
//S3. Dizziness
//Enter the symptom code from above list (S1, S2 or S3): S3

//Your prescription based on your age, symptoms and medical history:
//metformin 500 mg
//Thank you for coming.



//Sample Output 2:
//Hi, I'm Bob. I'm here to help you in your medication.
//Enter your (patient) details:
//Enter Patient Name: Alice
//Enter Patient Age: 15
//Enter Patient Gender: Female
//Enter Medical History. Eg: Diabetes.Press Enter for None:


//Welcome, Alice, 15.
//Which of the following symptoms do you have:
//S1.Headache
//S2.Skin rashes
//S3. Dizziness
//Enter the symptom code from above list (S1, S2 or S3): S2


//Your prescription based on your age, symptoms and medical history:
//diphenhydramine 50 mg
//Thank you for coming.


//Questions for this assignment
//Check your source code with Instructor's solution.

//You can download the Instructor's solution after you submit your solution.