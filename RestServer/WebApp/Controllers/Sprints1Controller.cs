﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Client;
using WebApp.SocketClient.Model;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SprintController : ControllerBase
    {

        private readonly SprintContext _context;

        public SprintController(SprintContext context)
        {
            _context = context;
        }


        // POST: api/Sprints1/
        [HttpPost("PostSprint")]
        public void PostSprint(String name, String contributor, String Id)
        {

            Client.SocketRouter cl = new Client.SocketRouter();
            cl.CheckPassword("1", "xd");

        }


        [HttpPost("PostEmployee")]
        public void PostEmployee(String name, string password)
        {
            Client.SocketRouter cl = new Client.SocketRouter();


        }

        // DELETE: api/Sprints1/5
        [HttpDelete("DeleteSprint{id}")]
        public void DeleteSprint(int id)
        {

            Client.SocketRouter cl = new Client.SocketRouter();


        }

        [HttpPost("AddEmployee")]
        public void AddEmployee(String name, string password)
        {



        }
        [HttpDelete("RemoveSprintById{id}")]
        public void RemoveSprint(int id)
        {

        }
        [HttpGet("GetSprintbyID{id}")]
        public void GetSprint(string id)
        {

        }
        [HttpPost("AssignToTeam")]
        public void AssignToTeam(string id, string AssignedToTeam)
        {

        }
        [HttpPost("AssignToPerson")]
        public void AssignToPerson(string id, string AssignedToTeam)
        {

        }


        [HttpDelete("RemoveEmployee{id}")]
        public void RemoveEmployee(string id)
        {

        }

        [HttpGet("CreateBacklog")]
        public void CreateBacklog(List<BacklogItemEntity> items)
        {

        }

    }
}
