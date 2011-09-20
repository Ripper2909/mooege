﻿using D3Sharp.Net;
using D3Sharp.Utils;

namespace D3Sharp.Core.Services
{
    [Service(serviceID: 0x0f, serviceName: "bnet.protocol.chat.ChatService")]
    public class ChatService : bnet.protocol.chat.ChatService, IServerService
    {
        protected static readonly Logger Logger = LogManager.CreateLogger();
        public IClient Client { get; set; }

        public override void CreateChannel(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.CreateChannelRequest request, System.Action<bnet.protocol.channel.CreateChannelResponse> done)
        {
			Logger.Trace("CreateChannel()");
            throw new System.NotImplementedException();
        }

        public override void FindChannel(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.FindChannelRequest request, System.Action<bnet.protocol.channel.FindChannelResponse> done)
        {
			Logger.Trace("FindChannel()");
            throw new System.NotImplementedException();
        }

        public override void JoinChannel(Google.ProtocolBuffers.IRpcController controller, bnet.protocol.channel.JoinChannelRequest request, System.Action<bnet.protocol.channel.JoinChannelResponse> done)
        {
			Logger.Trace("JoinChannel()");
            throw new System.NotImplementedException();
        }
    }
}