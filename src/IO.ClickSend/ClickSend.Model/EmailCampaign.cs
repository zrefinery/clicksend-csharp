/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.ClickSend.Model
{
    /// <summary>
    /// Campaign Model for Email
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class EmailCampaign :  IEquatable<EmailCampaign>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCampaign" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailCampaign() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailCampaign" /> class.
        /// </summary>
        /// <param name="name">Your campaign name. (required).</param>
        /// <param name="subject">Your campaign subject. (required).</param>
        /// <param name="body">Your campaign message. (required).</param>
        /// <param name="fromEmailAddressId">The allowed email address id. (required).</param>
        /// <param name="fromName">Your name or business name. (required).</param>
        /// <param name="templateId">Your template id..</param>
        /// <param name="listId">Your contact list id. (required).</param>
        /// <param name="schedule">Your schedule timestamp. (default to 0).</param>
        public EmailCampaign(string name = default(string), string subject = default(string), string body = default(string), decimal? fromEmailAddressId = default(decimal?), string fromName = default(string), decimal? templateId = default(decimal?), decimal? listId = default(decimal?), int? schedule = 0)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EmailCampaign and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "subject" is required (not null)
            if (subject == null)
            {
                throw new InvalidDataException("subject is a required property for EmailCampaign and cannot be null");
            }
            else
            {
                this.Subject = subject;
            }
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new InvalidDataException("body is a required property for EmailCampaign and cannot be null");
            }
            else
            {
                this.Body = body;
            }
            // to ensure "fromEmailAddressId" is required (not null)
            if (fromEmailAddressId == null)
            {
                throw new InvalidDataException("fromEmailAddressId is a required property for EmailCampaign and cannot be null");
            }
            else
            {
                this.FromEmailAddressId = fromEmailAddressId;
            }
            // to ensure "fromName" is required (not null)
            if (fromName == null)
            {
                throw new InvalidDataException("fromName is a required property for EmailCampaign and cannot be null");
            }
            else
            {
                this.FromName = fromName;
            }
            // to ensure "listId" is required (not null)
            if (listId == null)
            {
                throw new InvalidDataException("listId is a required property for EmailCampaign and cannot be null");
            }
            else
            {
                this.ListId = listId;
            }
            this.TemplateId = templateId;
            // use default value if no "schedule" provided
            if (schedule == null)
            {
                this.Schedule = 0;
            }
            else
            {
                this.Schedule = schedule;
            }
        }
        
        /// <summary>
        /// Your campaign name.
        /// </summary>
        /// <value>Your campaign name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Your campaign subject.
        /// </summary>
        /// <value>Your campaign subject.</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }

        /// <summary>
        /// Your campaign message.
        /// </summary>
        /// <value>Your campaign message.</value>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// The allowed email address id.
        /// </summary>
        /// <value>The allowed email address id.</value>
        [DataMember(Name="from_email_address_id", EmitDefaultValue=false)]
        public decimal? FromEmailAddressId { get; set; }

        /// <summary>
        /// Your name or business name.
        /// </summary>
        /// <value>Your name or business name.</value>
        [DataMember(Name="from_name", EmitDefaultValue=false)]
        public string FromName { get; set; }

        /// <summary>
        /// Your template id.
        /// </summary>
        /// <value>Your template id.</value>
        [DataMember(Name="template_id", EmitDefaultValue=false)]
        public decimal? TemplateId { get; set; }

        /// <summary>
        /// Your contact list id.
        /// </summary>
        /// <value>Your contact list id.</value>
        [DataMember(Name="list_id", EmitDefaultValue=false)]
        public decimal? ListId { get; set; }

        /// <summary>
        /// Your schedule timestamp.
        /// </summary>
        /// <value>Your schedule timestamp.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public int? Schedule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailCampaign {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  FromEmailAddressId: ").Append(FromEmailAddressId).Append("\n");
            sb.Append("  FromName: ").Append(FromName).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmailCampaign);
        }

        /// <summary>
        /// Returns true if EmailCampaign instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailCampaign to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailCampaign input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.FromEmailAddressId == input.FromEmailAddressId ||
                    (this.FromEmailAddressId != null &&
                    this.FromEmailAddressId.Equals(input.FromEmailAddressId))
                ) && 
                (
                    this.FromName == input.FromName ||
                    (this.FromName != null &&
                    this.FromName.Equals(input.FromName))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.ListId == input.ListId ||
                    (this.ListId != null &&
                    this.ListId.Equals(input.ListId))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.FromEmailAddressId != null)
                    hashCode = hashCode * 59 + this.FromEmailAddressId.GetHashCode();
                if (this.FromName != null)
                    hashCode = hashCode * 59 + this.FromName.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.ListId != null)
                    hashCode = hashCode * 59 + this.ListId.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
