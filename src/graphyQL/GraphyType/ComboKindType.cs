using GraphQL.Types;
using Repositories.DataModel;

namespace graphyQL.GraphyType
{
    public class ComboKindType : ObjectGraphType<CombokindDataModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SellRentType" /> class.
        /// </summary>
        public ComboKindType()
        {
            this.Field(d => d.CodeFilter, nullable: true).Description("所屬代號");
            this.Field(d => d.ComboCode, nullable: true).Description("總類代號A,B,C...");
            this.Field(d => d.ComboKind, nullable: true).Description("分類類別:01,02...");
            this.Field(d => d.ComboName, nullable: true).Description("名稱");
            this.Field(d => d.ComboSeq, nullable: true).Description("排序");
            this.Field(d => d.KName, nullable: true).Description("分類說明");
            this.Field(d => d.Seq).Description("排序");
        }
    }
}
