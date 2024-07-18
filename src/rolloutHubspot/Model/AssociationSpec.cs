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
    /// AssociationSpec
    /// </summary>
    [DataContract(Name = "AssociationSpec")]
    public partial class AssociationSpec : IValidatableObject
    {
        /// <summary>
        /// Defines AssociationCategory
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AssociationCategoryEnum
        {
            /// <summary>
            /// Enum HUBSPOTDEFINED for value: HUBSPOT_DEFINED
            /// </summary>
            [EnumMember(Value = "HUBSPOT_DEFINED")]
            HUBSPOTDEFINED = 1,

            /// <summary>
            /// Enum USERDEFINED for value: USER_DEFINED
            /// </summary>
            [EnumMember(Value = "USER_DEFINED")]
            USERDEFINED = 2,

            /// <summary>
            /// Enum INTEGRATORDEFINED for value: INTEGRATOR_DEFINED
            /// </summary>
            [EnumMember(Value = "INTEGRATOR_DEFINED")]
            INTEGRATORDEFINED = 3
        }


        /// <summary>
        /// Gets or Sets AssociationCategory
        /// </summary>
        [DataMember(Name = "associationCategory", IsRequired = true, EmitDefaultValue = true)]
        public AssociationCategoryEnum AssociationCategory { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationSpec" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssociationSpec() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssociationSpec" /> class.
        /// </summary>
        /// <param name="associationCategory">associationCategory (required).</param>
        /// <param name="associationTypeId">associationTypeId (required).</param>
        public AssociationSpec(AssociationCategoryEnum associationCategory = default(AssociationCategoryEnum), int associationTypeId = default(int))
        {
            this.AssociationCategory = associationCategory;
            this.AssociationTypeId = associationTypeId;
        }

        /// <summary>
        /// Gets or Sets AssociationTypeId
        /// </summary>
        [DataMember(Name = "associationTypeId", IsRequired = true, EmitDefaultValue = true)]
        public int AssociationTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssociationSpec {\n");
            sb.Append("  AssociationCategory: ").Append(AssociationCategory).Append("\n");
            sb.Append("  AssociationTypeId: ").Append(AssociationTypeId).Append("\n");
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
