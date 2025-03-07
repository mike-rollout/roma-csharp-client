/*
 * Contacts
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = rolloutHubspot.Client.OpenAPIDateConverter;

namespace rolloutHubspot.Model
{
    /// <summary>
    /// ValueWithTimestamp
    /// </summary>
    [DataContract(Name = "ValueWithTimestamp")]
    public partial class ValueWithTimestamp : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueWithTimestamp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValueWithTimestamp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueWithTimestamp" /> class.
        /// </summary>
        /// <param name="sourceId">sourceId.</param>
        /// <param name="sourceType">sourceType (required).</param>
        /// <param name="sourceLabel">sourceLabel.</param>
        /// <param name="updatedByUserId">updatedByUserId.</param>
        /// <param name="value">value (required).</param>
        /// <param name="timestamp">timestamp (required).</param>
        public ValueWithTimestamp(string sourceId = default(string), string sourceType = default(string), string sourceLabel = default(string), int updatedByUserId = default(int), string value = default(string), DateTime timestamp = default(DateTime))
        {
            // to ensure "sourceType" is required (not null)
            if (sourceType == null)
            {
                throw new ArgumentNullException("sourceType is a required property for ValueWithTimestamp and cannot be null");
            }
            this.SourceType = sourceType;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for ValueWithTimestamp and cannot be null");
            }
            this.Value = value;
            this.Timestamp = timestamp;
            this.SourceId = sourceId;
            this.SourceLabel = sourceLabel;
            this.UpdatedByUserId = updatedByUserId;
        }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name = "sourceId", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        /// <summary>
        /// Gets or Sets SourceType
        /// </summary>
        [DataMember(Name = "sourceType", IsRequired = true, EmitDefaultValue = true)]
        public string SourceType { get; set; }

        /// <summary>
        /// Gets or Sets SourceLabel
        /// </summary>
        [DataMember(Name = "sourceLabel", EmitDefaultValue = false)]
        public string SourceLabel { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedByUserId
        /// </summary>
        [DataMember(Name = "updatedByUserId", EmitDefaultValue = false)]
        public int UpdatedByUserId { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValueWithTimestamp {\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  SourceLabel: ").Append(SourceLabel).Append("\n");
            sb.Append("  UpdatedByUserId: ").Append(UpdatedByUserId).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
