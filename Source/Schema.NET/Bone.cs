namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Rigid connective tissue that comprises up the skeletal structure of the human body.
    /// </summary>
    [DataContract]
    public class Bone : AnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Bone";
    }
}