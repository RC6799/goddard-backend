/*
 * Goddard.ToursWebApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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
using OpenAPIDateConverter = FranchiseePortal.ToursWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.ToursWebApiClient.Model
{
    /// <summary>
    /// ScheduleItemDto
    /// </summary>
    [DataContract(Name = "ScheduleItemDto")]
    public partial class ScheduleItemDto : IEquatable<ScheduleItemDto>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TourType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleItemDto" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="startLocalDateTime">startLocalDateTime.</param>
        /// <param name="endLocalDateTime">endLocalDateTime.</param>
        public ScheduleItemDto(TourType? type = default(TourType?), DateTime startLocalDateTime = default(DateTime), DateTime endLocalDateTime = default(DateTime))
        {
            this.Type = type;
            this.StartLocalDateTime = startLocalDateTime;
            this.EndLocalDateTime = endLocalDateTime;
        }

        /// <summary>
        /// Gets or Sets StartLocalDateTime
        /// </summary>
        [DataMember(Name = "startLocalDateTime", EmitDefaultValue = false)]
        public DateTime StartLocalDateTime { get; set; }

        /// <summary>
        /// Gets or Sets EndLocalDateTime
        /// </summary>
        [DataMember(Name = "endLocalDateTime", EmitDefaultValue = false)]
        public DateTime EndLocalDateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleItemDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartLocalDateTime: ").Append(StartLocalDateTime).Append("\n");
            sb.Append("  EndLocalDateTime: ").Append(EndLocalDateTime).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleItemDto);
        }

        /// <summary>
        /// Returns true if ScheduleItemDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleItemDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleItemDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.StartLocalDateTime == input.StartLocalDateTime ||
                    (this.StartLocalDateTime != null &&
                    this.StartLocalDateTime.Equals(input.StartLocalDateTime))
                ) && 
                (
                    this.EndLocalDateTime == input.EndLocalDateTime ||
                    (this.EndLocalDateTime != null &&
                    this.EndLocalDateTime.Equals(input.EndLocalDateTime))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.StartLocalDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartLocalDateTime.GetHashCode();
                }
                if (this.EndLocalDateTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndLocalDateTime.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
