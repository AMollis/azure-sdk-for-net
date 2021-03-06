// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Fabric.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Representation of a volume resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Volume : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        public Volume()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Volume class.
        /// </summary>
        /// <param name="id">URI of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of resource.</param>
        /// <param name="location">The region where the resource is
        /// located.</param>
        /// <param name="tags">List of key-value pairs.</param>
        /// <param name="fileSystem">Filesystem type.</param>
        /// <param name="remainingSizeGB">Amount of free space in GB.</param>
        /// <param name="sizeGB">Total amount of space in GB.</param>
        /// <param name="volumeLabel">Volume label.</param>
        public Volume(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string fileSystem = default(string), int? remainingSizeGB = default(int?), int? sizeGB = default(int?), string volumeLabel = default(string))
            : base(id, name, type, location, tags)
        {
            FileSystem = fileSystem;
            RemainingSizeGB = remainingSizeGB;
            SizeGB = sizeGB;
            VolumeLabel = volumeLabel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fileSystem")]
        public string FileSystem { get; set; }

        /// <summary>
        /// Gets or sets amount of free space in GB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.remainingSizeGB")]
        public int? RemainingSizeGB { get; set; }

        /// <summary>
        /// Gets or sets total amount of space in GB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sizeGB")]
        public int? SizeGB { get; set; }

        /// <summary>
        /// Gets or sets volume label.
        /// </summary>
        [JsonProperty(PropertyName = "properties.volumeLabel")]
        public string VolumeLabel { get; set; }

    }
}
