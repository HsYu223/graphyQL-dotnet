namespace graphyQL.GraphyType
{
    public class CustomType : ComboKindType
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomType"/> class.
        /// </summary>
        public CustomType() : base()
        {
            this.Name = "Custom";
            this.Description = "自訂ComboKind";
        }
    }
}
