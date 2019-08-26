using System;
using System.Collections.Generic;
using MVC5.Handlers;

namespace MVC5.Repository
{
    public interface IRouteRepository : IDisposable
    {
        IEnumerable<RouteData> Find(string url);
    }
}