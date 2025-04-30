using System;
using System.Collections.Generic;

class Medication
{
    public string Name { get; set; }
    public string Time { get; set; }
    public string Dose { get; set; }
}

class Appointment
{
    public string Date { get; set; }
    public string Time { get; set; }
}

class Symptom
{
    public string Description { get; set; }
    public string Time { get; set; }
}

class Program
{
    static List<Medication> medicationLogs = new List<Medication>();
    static List<Appointment> appointments = new List<Appointment>();
    static List<Symptom> symptoms = new List<Symptom>();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Olivia's Health Tracker!");
        Console.WriteLine("----- Log Medication Intake -----");

        Console.Write("Enter Medication Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Time Taken (e.g. 08:00 AM): ");
        string time = Console.ReadLine();

        Console.Write("Enter Dose (e.g. 5 mg): ");
        string dose = Console.ReadLine();

        medicationLogs.Add(new Medication
        {
            Name = name,
            Time = time,
            Dose = dose
        });

        Console.WriteLine("\u2705 Medication logged successfully!");
        Console.WriteLine("Summary");
        Console.WriteLine($"name: {name}, Time: {time}, Dose: {dose}");


        // ----- Doctor Appointment Logging -----
        Console.WriteLine("\n----- Log Doctor Appointment -----");

        Console.Write("Enter Appointment Date (e.g. 04/25/2025): ");
        string apptDate = Console.ReadLine();

        Console.Write("Enter Appointment Time (e.g. 3:00 PM): ");
        string apptTime = Console.ReadLine();

        appointments.Add(new Appointment
        {
            Date = apptDate,
            Time = apptTime
        });

        Console.WriteLine("\u2705 Appointment logged successfully!");
        Console.WriteLine("Appointment Summary");
        Console.WriteLine($"Date: {apptDate}, Time: {apptTime}");


        // ----- Track Symptoms -----
        Console.WriteLine("\n----- Track Symptoms -----");

        Console.Write("Enter Symptom description (e.g. Headache): ");
        string symptomDesc = Console.ReadLine();

        Console.Write("Enter Time of Symptom (e.g. 3:00 PM): ");
        string sympTime = Console.ReadLine();

        symptoms.Add(new Symptom
        {
            Description = symptomDesc,
            Time = sympTime
        });

        Console.WriteLine("\u2705 Symptom logged successfully!");
        Console.WriteLine("Symptom Summary");
        Console.WriteLine($"Description: {symptomDesc}, Time: {sympTime}");


        // ===== Dashboard =====
        Console.WriteLine("\n===== DASHBOARD =====");

        Console.WriteLine("\nMedications:");
        foreach (var med in medicationLogs)
        {
            Console.WriteLine($"- {med.Name}, Time: {med.Time}, Dose: {med.Dose}");
        }

        Console.WriteLine("\nAppointments:");
        foreach (var appt in appointments)
        {
            Console.WriteLine($"- Date: {appt.Date}, Time: {appt.Time}");
        }
        
        Console.WriteLine("\nSymptoms:");
        foreach (var symp in symptoms)
        {
            Console.WriteLine($"- {symp.Description}, Time: {symp.Time}");
        }

    }
}