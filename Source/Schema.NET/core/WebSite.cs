namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// </summary>
    [DataContract]
    public partial class WebSite : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebSite";

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Issn { get; set; }
    }
}
