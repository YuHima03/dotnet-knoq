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
    /// RequestEventInstantTagsInner
    /// </summary>
    [DataContract(Name = "RequestEventInstant_tags_inner")]
    public partial class RequestEventInstantTagsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestEventInstantTagsInner" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="locked">locked.</param>
        public RequestEventInstantTagsInner(string name = default(string), bool locked = default(bool))
        {
            this.Name = name;
            this.Locked = locked;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>Vue</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
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
            sb.Append("class RequestEventInstantTagsInner {\n");
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
