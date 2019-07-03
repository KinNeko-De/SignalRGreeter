using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalRGreeter.Hubs
{
	public class SignalRGreeterHub : Hub
	{
		public string SayHello(string user)
		{
			return "Hello " + user;
		}
	}
}
