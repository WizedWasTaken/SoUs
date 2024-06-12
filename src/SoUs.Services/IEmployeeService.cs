﻿using SoUs.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SoUs.Services
{
    public interface IEmployeeService
    {
        Employee Employee { get; set; }

        Task<Employee> GetEmployeeFromIdAsync(int id);
    }

    public class EmployeeService : ApiBase, IEmployeeService
    {

        // Constructors
        public EmployeeService(Uri baseUri) : base(baseUri) { }

        public EmployeeService(string baseUri) : base(baseUri) { }

        public Employee Employee { get; set; }

        /// <summary>
        /// Method to get an employee from the database by id.
        /// </summary>
        /// <param name="id">ID to get in database</param>
        /// <returns>Employee object</returns>
        /// <exception cref="ApplicationException">An unexpected error happened.</exception>
        public async Task<Employee> GetEmployeeFromIdAsync(int id)
        {
            try
            {
                Employee e = default;

                var response = await GetHttpAsync($"Employee/GetEmployeeById?id={id}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new ApplicationException($"Error: {response.StatusCode}");
                }

                e = await response.Content.ReadFromJsonAsync<Employee>();

                return e;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Der skete en uventet fejl.", ex);
            }
        }
    }
}
