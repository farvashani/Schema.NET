namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A sequential publication of comic stories under a
    ///     unifying title, for example "The Amazing Spider-Man" or "Groo the
    ///     Wanderer".
    /// </summary>
    [DataContract]
    public class ComicSeries : Periodical
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ComicSeries";
    }
}