﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApp.SocketClient.Model;

namespace WebApp.SocketClient.Requests
{
    public class AddEmployeeRequest
    {
        public EmployeeEntity Employee = new EmployeeEntity();

    }
}


