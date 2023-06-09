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
    /// ScheduleDto
    /// </summary>
    [DataContract(Name = "ScheduleDto")]
    public partial class ScheduleDto : IEquatable<ScheduleDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDto" /> class.
        /// </summary>
        /// <param name="schoolId">schoolId.</param>
        /// <param name="availability">availability.</param>
        public ScheduleDto(string schoolId = default(string), List<ScheduleItemDto> availability = default(List<ScheduleItemDto>))
        {
            this.SchoolId = schoolId;
            this.Availability = availability;
        }

        /// <summary>
        /// Gets or Sets SchoolId
        /// </summary>
        [DataMember(Name = "schoolId", EmitDefaultValue = true)]
        public string SchoolId { get; set; }

        /// <summary>
        /// Gets or Sets Availability
        /// </summary>
        [DataMember(Name = "availability", EmitDefaultValue = true)]
        public List<ScheduleItemDto> Availability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduleDto {\n");
            sb.Append("  SchoolId: ").Append(SchoolId).Append("\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
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
            return this.Equals(input as ScheduleDto);
        }

        /// <summary>
        /// Returns true if ScheduleDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchoolId == input.SchoolId ||
                    (this.SchoolId != null &&
                    this.SchoolId.Equals(input.SchoolId))
                ) && 
                (
                    this.Availability == input.Availability ||
                    this.Availability != null &&
                    input.Availability != null &&
                    this.Availability.SequenceEqual(input.Availability)
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
                if (this.SchoolId != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolId.GetHashCode();
                }
                if (this.Availability != null)
                {
                    hashCode = (hashCode * 59) + this.Availability.GetHashCode();
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
