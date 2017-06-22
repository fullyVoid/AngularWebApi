﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular2webapp.Controllers
{
    public class ClientController : ApiController
    {
        // GET: api/Client
        public IEnumerable<ClientData> GetAll()
        {
            return Enumerable.Range(1, 6).Select(index => new ClientData
            {
                id = DateTime.Now.Second * DateTime.Now.Minute,
                nr = index,
                shortName = "C_"+DateTime.Now.Second,
                longName = DateTime.Now.AddDays(index).ToString("d")
            });
        }

        public class ClientData
        {
            public int id { get; set; }
            public int nr { get; set; }
            public string shortName { get; set; }
            public string longName { get; set; }

        }

    }
}
