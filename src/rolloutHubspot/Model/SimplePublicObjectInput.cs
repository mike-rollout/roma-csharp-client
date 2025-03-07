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
    /// SimplePublicObjectInput
    /// </summary>
    [DataContract(Name = "SimplePublicObjectInput")]
    public partial class SimplePublicObjectInput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePublicObjectInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimplePublicObjectInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimplePublicObjectInput" /> class.
        /// </summary>
        /// <param name="properties">properties (required).</param>
        public SimplePublicObjectInput(Dictionary<string, string> properties = default(Dictionary<string, string>))
        {
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new ArgumentNullException("properties is a required property for SimplePublicObjectInput and cannot be null");
            }
            this.Properties = properties;
        }

        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        /// <example>{&quot;property_date&quot;:&quot;1572480000000&quot;,&quot;property_radio&quot;:&quot;option_1&quot;,&quot;property_number&quot;:&quot;17&quot;,&quot;property_string&quot;:&quot;value&quot;,&quot;property_checkbox&quot;:&quot;false&quot;,&quot;property_dropdown&quot;:&quot;choice_b&quot;,&quot;property_multiple_checkboxes&quot;:&quot;chocolate;strawberry&quot;}</example>
        [DataMember(Name = "properties", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimplePublicObjectInput {\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
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
