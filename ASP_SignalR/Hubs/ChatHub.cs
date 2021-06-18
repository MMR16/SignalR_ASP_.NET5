using ASP_SignalR.Model;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;

namespace ASP_SignalR.Models
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        CompanyContext db = new CompanyContext();

        [HubMethodName("sendMessage")]
        public void SendMessage(string name, string message)
        {
            //without database Mandatory
            //broadcast to all
            Clients.All.newMessage(name, message);
            //DBCode
            Chats mess = new Chats() { Name = name, Message = message, Date = DateTime.Now };
            db.Chats.Add(mess);
            db.SaveChanges();
        }

        [HubMethodName("joinGroup")]
        public void JoinGroup(string gname,string name)
        {
            Groups.Add(Context.ConnectionId, gname);
            string mess = $"{name} has Joind {gname}";
            Clients.OthersInGroup(gname).newMember(mess);
        }


        [HubMethodName("sendGroup")]
        public void SendGroup(string gname,string name,string message)
        {
            Clients.Group(gname).newGroupMessage(name, gname, message);
        }

        //the other events to use:
        //on connected , on disconnected , on reconnecting

        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}