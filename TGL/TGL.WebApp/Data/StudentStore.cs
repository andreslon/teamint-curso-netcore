﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class StudentStore
    {
        private List<Student> Students { get; set; } = new List<Student>();

        public StudentStore()
        {
            Students.Add(new Student
            {
                Age=17,
                Name="Juan",
                LastName="Perez",
                Nit="3134243321"
            });
            Students.Add(new Student
            {
                Age = 17,
                Name = "Juan",
                LastName = "Perez",
                Nit = "3134243321"
            });
            Students.Add(new Student
            {
                Age = 17,
                Name = "Juan",
                LastName = "Perez",
                Nit = "3134243321"
            });
        }

        internal void EditStudent(Student student)
        {
            Student currentStudent = GetStudentById(student.Id);
            currentStudent.Name = student.Name;
            currentStudent.LastName = student.LastName;
            currentStudent.Nit = student.Nit;
            currentStudent.Age = student.Age;
        }

        internal Student GetStudentById(Guid id)
        {
            return Students.FirstOrDefault(x => x.Id == id);
        }

        internal void AddStudent(Student student)
        {
            Students.Add(student);
        }

        internal void DeleteStudent(Guid id)
        {
            var student = Students.FirstOrDefault(x => x.Id == id);
            Students.Remove(student);
        }

        public List<Student> GetStudents() {
            return this.Students;
        }
    }
}
