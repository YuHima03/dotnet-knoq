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
    /// ユーザの参加状況
    /// </summary>
    [DataContract(Name = "ResponseEventDetail_attendees_inner")]
    public partial class ResponseEventDetailAttendeesInner : IValidatableObject
    {
        /// <summary>
        /// pending or absent or attendance
        /// </summary>
        /// <value>pending or absent or attendance</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScheduleEnum
        {
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 1,

            /// <summary>
            /// Enum Absent for value: absent
            /// </summary>
            [EnumMember(Value = "absent")]
            Absent = 2,

            /// <summary>
            /// Enum Attendance for value: attendance
            /// </summary>
            [EnumMember(Value = "attendance")]
            Attendance = 3
        }


        /// <summary>
        /// pending or absent or attendance
        /// </summary>
        /// <value>pending or absent or attendance</value>
        [DataMember(Name = "schedule", IsRequired = true, EmitDefaultValue = true)]
        public ScheduleEnum Schedule { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEventDetailAttendeesInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseEventDetailAttendeesInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEventDetailAttendeesInner" /> class.
        /// </summary>
        /// <param name="userId">userId (required).</param>
        /// <param name="schedule">pending or absent or attendance (required).</param>
        public ResponseEventDetailAttendeesInner(Guid userId = default(Guid), ScheduleEnum schedule = default(ScheduleEnum))
        {
            this.UserId = userId;
            this.Schedule = schedule;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseEventDetailAttendeesInner {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
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
