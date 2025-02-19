/*
 * traP knoQ
 *
 * This is a sample knoQ server. 
 *
 * The version of the OpenAPI document: 2.1.5
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
using FileParameter = Knoq.Client.FileParameter;
using OpenAPIDateConverter = Knoq.Client.OpenAPIDateConverter;

namespace Knoq.Model
{
    /// <summary>
    /// タグの配列
    /// </summary>
    [DataContract(Name = "ResponseEvent_tags_inner")]
    public partial class ResponseEventTagsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEventTagsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseEventTagsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEventTagsInner" /> class.
        /// </summary>
        /// <param name="tagId">tagId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="locked">locked.</param>
        public ResponseEventTagsInner(Guid tagId = default(Guid), string name = default(string), bool locked = default(bool))
        {
            this.TagId = tagId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ResponseEventTagsInner and cannot be null");
            }
            this.Name = name;
            this.Locked = locked;
        }

        /// <summary>
        /// Gets or Sets TagId
        /// </summary>
        [DataMember(Name = "tagId", IsRequired = true, EmitDefaultValue = true)]
        public Guid TagId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>Vue</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        public bool Locked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseEventTagsInner {\n");
            sb.Append("  TagId: ").Append(TagId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
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
