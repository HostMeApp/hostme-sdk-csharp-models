using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;



namespace HostMe.Sdk.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class StatusMessage :  IEquatable<StatusMessage>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StatusMessage" /> class.
        /// Initializes a new instance of the <see cref="StatusMessage" />class.
        /// </summary>
        /// <param name="FromStatus">FromStatus (required).</param>
        /// <param name="ToStatus">ToStatus (required).</param>
        /// <param name="MessageTemplate">MessageTemplate.</param>

        public StatusMessage(string FromStatus = null, string ToStatus = null, string MessageTemplate = null)
        {
            // to ensure "FromStatus" is required (not null)
            if (FromStatus == null)
            {
                throw new InvalidDataException("FromStatus is a required property for StatusMessage and cannot be null");
            }
            else
            {
                this.FromStatus = FromStatus;
            }
            // to ensure "ToStatus" is required (not null)
            if (ToStatus == null)
            {
                throw new InvalidDataException("ToStatus is a required property for StatusMessage and cannot be null");
            }
            else
            {
                this.ToStatus = ToStatus;
            }
            this.MessageTemplate = MessageTemplate;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FromStatus
        /// </summary>
        [DataMember(Name="fromStatus", EmitDefaultValue=false)]
        public string FromStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets ToStatus
        /// </summary>
        [DataMember(Name="toStatus", EmitDefaultValue=false)]
        public string ToStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets MessageTemplate
        /// </summary>
        [DataMember(Name="messageTemplate", EmitDefaultValue=false)]
        public string MessageTemplate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusMessage {\n");
            sb.Append("  FromStatus: ").Append(FromStatus).Append("\n");
            sb.Append("  ToStatus: ").Append(ToStatus).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as StatusMessage);
        }

        /// <summary>
        /// Returns true if StatusMessage instances are equal
        /// </summary>
        /// <param name="other">Instance of StatusMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatusMessage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FromStatus == other.FromStatus ||
                    this.FromStatus != null &&
                    this.FromStatus.Equals(other.FromStatus)
                ) && 
                (
                    this.ToStatus == other.ToStatus ||
                    this.ToStatus != null &&
                    this.ToStatus.Equals(other.ToStatus)
                ) && 
                (
                    this.MessageTemplate == other.MessageTemplate ||
                    this.MessageTemplate != null &&
                    this.MessageTemplate.Equals(other.MessageTemplate)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.FromStatus != null)
                    hash = hash * 59 + this.FromStatus.GetHashCode();
                
                if (this.ToStatus != null)
                    hash = hash * 59 + this.ToStatus.GetHashCode();
                
                if (this.MessageTemplate != null)
                    hash = hash * 59 + this.MessageTemplate.GetHashCode();
                
                return hash;
            }
        }

    }


}
