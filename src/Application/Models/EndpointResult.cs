﻿using Application.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public record EndpointResult
    {
        public EndpointResultStatus Status { get; init; } = EndpointResultStatus.Success;
        public IEnumerable<string> Messages { get; init; } = new List<string>();

        public EndpointResult()
        {
        }

        public EndpointResult(EndpointResultStatus status)
        {
            Status = status;
        }

        public EndpointResult(EndpointResultStatus status, params string[] messages)
        {
            Status = status;
            Messages = messages;
        }
    }

    public record EndpointResult<TResult> : EndpointResult
    {
        public TResult? Data { get; init; }

        public EndpointResult(EndpointResultStatus status)
            : base(status)
        {
        }

        public EndpointResult(EndpointResultStatus status, params string[] messages)
            : base(status, messages)
        {
        }

        public EndpointResult(EndpointResultStatus status, TResult data, params string[] messages)
            : base(status, messages)
        {
            Data = data;
        }

        public EndpointResult(TResult data)
        {
            Data = data;
        }
    }
}
