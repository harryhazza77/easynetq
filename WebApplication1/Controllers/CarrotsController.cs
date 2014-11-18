using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EasyNetQ;
using Messages;
using Microsoft.Owin.Security.Provider;

namespace WebApplication1.Controllers
{
    public class CarrotsController : ApiController
    {
        // GET api/carrots
        public IEnumerable<string> Get()
        {
            string val = null;
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                while (string.IsNullOrEmpty(val))
                {
                    bus.Subscribe<TextMessage>("web", message => val = message.Text);
                }
            }

            return new [] { val };
        }

        // GET api/carrots/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/carrots
        public void Post([FromBody]string value)
        {
            using (var bus = RabbitHutch.CreateBus("host=localhost"))
            {
                bus.Publish(new TextMessage
                {
                    Text = value
                });
            }
        }

        // PUT api/carrots/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/carrots/5
        public void Delete(int id)
        {
        }
    }
}
