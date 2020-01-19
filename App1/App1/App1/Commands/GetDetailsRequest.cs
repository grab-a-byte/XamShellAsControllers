using System;
using System.Collections.Generic;
using System.Text;
using MediatR;

namespace App1.Commands
{
    public class GetDetailsRequest : IRequest<GetDetailsResponse>
    {
        public string Id { get; set; }
    }
}
