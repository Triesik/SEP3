﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.SocketClient.Model
{
    public class EmployeeEntity
    {

        public string FirstName { get; set; }
        public string Id { get; set; }

        public void SetValues(string name)
        {
            this.FirstName = name;
        }

        public void setId(string id)
        {
            this.Id = id;
        }

    }

}

