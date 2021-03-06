namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    [DataContract]
    public partial class Dataset : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Dataset";

        /// <summary>
        /// A downloadable form of this dataset, at a specific location, in a specific format.
        /// </summary>
        [DataMember(Name = "distribution", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DataDownload>? Distribution { get; set; }

        /// <summary>
        /// A data catalog which contains this dataset.
        /// </summary>
        [DataMember(Name = "includedInDataCatalog", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DataCatalog>? IncludedInDataCatalog { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Issn { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="http://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="http://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;/p&gt;
        /// &lt;p&gt;For example, if &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;/p&gt;
        /// &lt;p&gt;If the &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;/p&gt;
        /// &lt;p&gt;If there are several &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? MeasurementTechnique { get; set; }

        /// <summary>
        /// The variableMeasured property can indicate (repeated as necessary) the  variables that are measured in some dataset, either described as text or as pairs of identifier and description using PropertyValue.
        /// </summary>
        [DataMember(Name = "variableMeasured", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PropertyValue, string>? VariableMeasured { get; set; }
    }
}
