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
    /// CollectionResponseWithTotalSimplePublicObjectForwardPaging
    /// </summary>
    [DataContract(Name = "CollectionResponseWithTotalSimplePublicObjectForwardPaging")]
    public partial class CollectionResponseWithTotalSimplePublicObjectForwardPaging : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseWithTotalSimplePublicObjectForwardPaging" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CollectionResponseWithTotalSimplePublicObjectForwardPaging() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionResponseWithTotalSimplePublicObjectForwardPaging" /> class.
        /// </summary>
        /// <param name="total">total (required).</param>
        /// <param name="paging">paging.</param>
        /// <param name="results">results (required).</param>
        public CollectionResponseWithTotalSimplePublicObjectForwardPaging(int total = default(int), ForwardPaging paging = default(ForwardPaging), List<SimplePublicObject> results = default(List<SimplePublicObject>))
        {
            this.Total = total;
            // to ensure "results" is required (not null)
            if (results == null)
            {
                throw new ArgumentNullException("results is a required property for CollectionResponseWithTotalSimplePublicObjectForwardPaging and cannot be null");
            }
            this.Results = results;
            this.Paging = paging;
        }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public int Total { get; set; }

        /// <summary>
        /// Gets or Sets Paging
        /// </summary>
        [DataMember(Name = "paging", EmitDefaultValue = false)]
        public ForwardPaging Paging { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name = "results", IsRequired = true, EmitDefaultValue = true)]
        public List<SimplePublicObject> Results { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CollectionResponseWithTotalSimplePublicObjectForwardPaging {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Paging: ").Append(Paging).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
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
