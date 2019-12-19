﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viaven.Requests;
using Newtonsoft.Json;
using System.Net;
using System.Net.Sockets;


namespace Viaven.Controllers
{
    class RequestHandler



    {
        EmployeeController empController = new EmployeeController();
        SprintController sprController = new SprintController();
        BacklogController blController = new BacklogController();

        public void ForwardRequest(string json, Socket handler) 
        {
            var request = JsonConvert.DeserializeObject<JsonPackage>(json);

            switch (request.ForwardTo)
            {
                case ("EmployeeController"):
                    empController.HandleRequests(json, handler);
                    break;
                case ("SprintController"):
                    sprController.HandleRequest(json, handler);
                    break;
                case ("BacklogController"):
                    blController.HandleRequest(json, handler);
                    break;
            }
        }

    }
}
