﻿using MediatR;
using Sfa.Das.Sas.ApplicationServices.Responses;

namespace Sfa.Das.Sas.ApplicationServices.Queries
{
    public class GetFrameworkQuery : IRequest<GetFrameworkResponse>
    {
        public int Id { get; set; }

        public string Keywords { get; set; }
    }
}
