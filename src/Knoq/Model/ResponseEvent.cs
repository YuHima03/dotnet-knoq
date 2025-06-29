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
    /// ResponseEvent
    /// </summary>
    [DataContract(Name = "ResponseEvent")]
    public partial class ResponseEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEvent" /> class.
        /// </summary>
        /// <param name="eventId">eventId (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="sharedRoom">部屋の共用をするか (required).</param>
        /// <param name="timeStart">timeStart (required).</param>
        /// <param name="timeEnd">timeEnd (required).</param>
        /// <param name="place">place (required).</param>
        /// <param name="roomId">roomId (required).</param>
        /// <param name="groupId">groupId (required).</param>
        /// <param name="open">グループ外のユーザーが参加予定を出来るか (required).</param>
        /// <param name="admins">編集権を持つユーザー (required).</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="attendees">attendees (required).</param>
        /// <param name="createdBy">createdBy (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public ResponseEvent(Guid eventId = default(Guid), string name = default(string), string description = default(string), bool sharedRoom = default(bool), string timeStart = default(string), string timeEnd = default(string), string place = default(string), Guid roomId = default(Guid), Guid groupId = default(Guid), bool open = default(bool), List<Guid> admins = default(List<Guid>), List<ResponseEventTagsInner> tags = default(List<ResponseEventTagsInner>), List<Guid> attendees = default(List<Guid>), Guid createdBy = default(Guid), string createdAt = default(string), string updatedAt = default(string))
        {
            this.EventId = eventId;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ResponseEvent and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ResponseEvent and cannot be null");
            }
            this.Description = description;
            this.SharedRoom = sharedRoom;
            // to ensure "timeStart" is required (not null)
            if (timeStart == null)
            {
                throw new ArgumentNullException("timeStart is a required property for ResponseEvent and cannot be null");
            }
            this.TimeStart = timeStart;
            // to ensure "timeEnd" is required (not null)
            if (timeEnd == null)
            {
                throw new ArgumentNullException("timeEnd is a required property for ResponseEvent and cannot be null");
            }
            this.TimeEnd = timeEnd;
            // to ensure "place" is required (not null)
            if (place == null)
            {
                throw new ArgumentNullException("place is a required property for ResponseEvent and cannot be null");
            }
            this.Place = place;
            this.RoomId = roomId;
            this.GroupId = groupId;
            this.Open = open;
            // to ensure "admins" is required (not null)
            if (admins == null)
            {
                throw new ArgumentNullException("admins is a required property for ResponseEvent and cannot be null");
            }
            this.Admins = admins;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for ResponseEvent and cannot be null");
            }
            this.Tags = tags;
            // to ensure "attendees" is required (not null)
            if (attendees == null)
            {
                throw new ArgumentNullException("attendees is a required property for ResponseEvent and cannot be null");
            }
            this.Attendees = attendees;
            this.CreatedBy = createdBy;
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new ArgumentNullException("createdAt is a required property for ResponseEvent and cannot be null");
            }
            this.CreatedAt = createdAt;
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new ArgumentNullException("updatedAt is a required property for ResponseEvent and cannot be null");
            }
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name = "eventId", IsRequired = true, EmitDefaultValue = true)]
        public Guid EventId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /*
        <example>第n回進捗回</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /*
        <example>第n回の進捗会です。</example>
        */
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// 部屋の共用をするか
        /// </summary>
        /// <value>部屋の共用をするか</value>
        [DataMember(Name = "sharedRoom", IsRequired = true, EmitDefaultValue = true)]
        public bool SharedRoom { get; set; }

        /// <summary>
        /// Gets or Sets TimeStart
        /// </summary>
        /*
        <example>2006-01-02T15:04:05Z</example>
        */
        [DataMember(Name = "timeStart", IsRequired = true, EmitDefaultValue = true)]
        public string TimeStart { get; set; }

        /// <summary>
        /// Gets or Sets TimeEnd
        /// </summary>
        /*
        <example>2006-01-02T15:04:05Z</example>
        */
        [DataMember(Name = "timeEnd", IsRequired = true, EmitDefaultValue = true)]
        public string TimeEnd { get; set; }

        /// <summary>
        /// Gets or Sets Place
        /// </summary>
        /*
        <example>S516</example>
        */
        [DataMember(Name = "place", IsRequired = true, EmitDefaultValue = true)]
        public string Place { get; set; }

        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [DataMember(Name = "roomId", IsRequired = true, EmitDefaultValue = true)]
        public Guid RoomId { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = true)]
        public Guid GroupId { get; set; }

        /// <summary>
        /// グループ外のユーザーが参加予定を出来るか
        /// </summary>
        /// <value>グループ外のユーザーが参加予定を出来るか</value>
        [DataMember(Name = "open", IsRequired = true, EmitDefaultValue = true)]
        public bool Open { get; set; }

        /// <summary>
        /// 編集権を持つユーザー
        /// </summary>
        /// <value>編集権を持つユーザー</value>
        [DataMember(Name = "admins", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> Admins { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<ResponseEventTagsInner> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Attendees
        /// </summary>
        [DataMember(Name = "attendees", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> Attendees { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", IsRequired = true, EmitDefaultValue = true)]
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /*
        <example>2006-01-02T15:04:05Z</example>
        */
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /*
        <example>2006-01-02T15:04:05Z</example>
        */
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseEvent {\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SharedRoom: ").Append(SharedRoom).Append("\n");
            sb.Append("  TimeStart: ").Append(TimeStart).Append("\n");
            sb.Append("  TimeEnd: ").Append(TimeEnd).Append("\n");
            sb.Append("  Place: ").Append(Place).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Admins: ").Append(Admins).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Attendees: ").Append(Attendees).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
