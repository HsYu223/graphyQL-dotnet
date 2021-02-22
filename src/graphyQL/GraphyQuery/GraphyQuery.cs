using GraphQL;
using GraphQL.Types;
using graphyQL.GraphyType;
using Repositories.Interface;

namespace graphyQL.GraphyQuery
{
    public class GraphyQuery : ObjectGraphType<object>
    {
        public ICombokindRepository _combokindRepository;

        public GraphyQuery(ICombokindRepository combokindRepository)
        {
            this._combokindRepository = combokindRepository;

            this.Name = "Query";

            this.FieldAsync<ListGraphType<CustomType>>(
                "custom",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "combokind", Description = "id of the combokind" }
                    ),
                resolve: async context => await this._combokindRepository.GetCombokindDataAsync(context.GetArgument<string>("combokind")));
        }
    }
}
