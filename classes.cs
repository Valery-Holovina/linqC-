using System;
using System.Collections.Generic;

namespace All
{
    public class Region
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public override string ToString() => $"id: {Id}, name: {Name}";
    }

    public class Country
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Region? Region { get; set; }
        public override string ToString() => $"id: {Id}, name: {Name}, region: {Region?.Name}";
    }

    public class Location
    {
        public int Id { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? PostalCode { get; set; }
        public string? StateProvince { get; set; }
        public Country? Country { get; set; }

        public override string ToString() =>
            $"id: {Id}, address: {Address}, city: {City}, postalCode: {PostalCode}, stateProvince: {StateProvince}, country: {Country?.Name}";
    }

    public class Department
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ManagerId { get; set; }
        public Location? Location { get; set; }

        public override string ToString() =>
            $"id: {Id}, name: {Name}, managerId: {ManagerId}, location: {Location?.City}";
    }

    public class Job
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double SalaryMin { get; set; }
        public double SalaryMax { get; set; }

        public override string ToString() =>
            $"id: {Id}, title: {Title}, salaryMin: {SalaryMin}, salaryMax: {SalaryMax}";
    }

    public class JobHistory
    {
        public int Id { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public Job? Job { get; set; }
        public Department? Department { get; set; }

        public override string ToString() =>
            $"id: {Id}, start: {StartDate}, end: {EndDate}, job: {Job?.Title}, department: {Department?.Name}";
    }

    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? HireDate { get; set; }
        public Job? Job { get; set; }
        public double Salary { get; set; }
        public string? Commission { get; set; }
        public int ManagerId { get; set; }
        public Department? Department { get; set; }

        public override string ToString() =>
            $"id: {Id}, name: {Name} {LastName}, job: {Job?.Title}, department: {Department?.Name}";
    }
}