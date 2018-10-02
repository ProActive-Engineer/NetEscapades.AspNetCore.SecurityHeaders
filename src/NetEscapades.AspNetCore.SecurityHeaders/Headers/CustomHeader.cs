namespace NetEscapades.AspNetCore.SecurityHeaders.Infrastructure
{
    /// <summary>
    /// An arbitrary custom header class for applying header values
    /// </summary>
    public class CustomHeader : HeaderPolicyBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomHeader"/> class.
        /// </summary>
        /// <param name="header">The string value of the header</param>
        /// <param name="value">The value to apply for the header</param>
        public CustomHeader(string header, string value) : base(value)
        {
            Header = header;
        }

        /// <inheritdoc />
        public override string Header { get; }
    }
}