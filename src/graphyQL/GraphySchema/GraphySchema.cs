using System;
using GraphQL.Types;
using GraphQL.Utilities;

namespace graphyQL.GraphySchema
{
    public class GraphySchema : Schema
    {
        public GraphySchema(IServiceProvider provider) : base(provider)
        {
            this.Query = provider.GetRequiredService<GraphyQuery.GraphyQuery>();
        }
    }
}
