﻿using System.Linq;
using VoicifyAlexa.NET.APL;
using VoicifyAlexa.NET.Request.Type;

namespace VoicifyAlexa.NET.Request
{
    public class RuntimeErrorRequestHandler : IRequestTypeConverter
    {
        public bool CanConvert(string requestType)
        {
            return requestType == RuntimeErrorRequest.RequestType;
        }

        public Request.Type.Request Convert(string requestType)
        {
            return new RuntimeErrorRequest();
        }

        private static readonly object directiveadd = new object();

        public void AddToRequestConverter()
        {
            lock (directiveadd)
            {
                if (RequestConverter.RequestConverters.Where(rc => rc != null)
                    .All(rc => rc.GetType() != typeof(RuntimeErrorRequestHandler)))
                {
                    RequestConverter.RequestConverters.Add(this);
                }
            }
        }
    }
}