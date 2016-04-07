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
    public partial class WaitingSettings :  IEquatable<WaitingSettings>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitingSettings" /> class.
        /// Initializes a new instance of the <see cref="WaitingSettings" />class.
        /// </summary>
        /// <param name="AcceptRemoteRegistration">AcceptRemoteRegistration.</param>
        /// <param name="EnableManualHold">EnableManualHold.</param>
        /// <param name="MaximumHoldTime">MaximumHoldTime.</param>
        /// <param name="PositionMessages">PositionMessages.</param>
        /// <param name="StatusMessages">StatusMessages.</param>

        public WaitingSettings(bool? AcceptRemoteRegistration = null, bool? EnableManualHold = null, int? MaximumHoldTime = null, List<PositionMessage> PositionMessages = null, List<StatusMessage> StatusMessages = null)
        {
            this.AcceptRemoteRegistration = AcceptRemoteRegistration;
            this.EnableManualHold = EnableManualHold;
            this.MaximumHoldTime = MaximumHoldTime;
            this.PositionMessages = PositionMessages;
            this.StatusMessages = StatusMessages;
            
        }
        
    
        /// <summary>
        /// Gets or Sets AcceptRemoteRegistration
        /// </summary>
        [DataMember(Name="acceptRemoteRegistration", EmitDefaultValue=false)]
        public bool? AcceptRemoteRegistration { get; set; }
    
        /// <summary>
        /// Gets or Sets EnableManualHold
        /// </summary>
        [DataMember(Name="enableManualHold", EmitDefaultValue=false)]
        public bool? EnableManualHold { get; set; }
    
        /// <summary>
        /// Gets or Sets MaximumHoldTime
        /// </summary>
        [DataMember(Name="maximumHoldTime", EmitDefaultValue=false)]
        public int? MaximumHoldTime { get; set; }
    
        /// <summary>
        /// Gets or Sets PositionMessages
        /// </summary>
        [DataMember(Name="positionMessages", EmitDefaultValue=false)]
        public List<PositionMessage> PositionMessages { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusMessages
        /// </summary>
        [DataMember(Name="statusMessages", EmitDefaultValue=false)]
        public List<StatusMessage> StatusMessages { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitingSettings {\n");
            sb.Append("  AcceptRemoteRegistration: ").Append(AcceptRemoteRegistration).Append("\n");
            sb.Append("  EnableManualHold: ").Append(EnableManualHold).Append("\n");
            sb.Append("  MaximumHoldTime: ").Append(MaximumHoldTime).Append("\n");
            sb.Append("  PositionMessages: ").Append(PositionMessages).Append("\n");
            sb.Append("  StatusMessages: ").Append(StatusMessages).Append("\n");
            
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
            return this.Equals(obj as WaitingSettings);
        }

        /// <summary>
        /// Returns true if WaitingSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of WaitingSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitingSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AcceptRemoteRegistration == other.AcceptRemoteRegistration ||
                    this.AcceptRemoteRegistration != null &&
                    this.AcceptRemoteRegistration.Equals(other.AcceptRemoteRegistration)
                ) && 
                (
                    this.EnableManualHold == other.EnableManualHold ||
                    this.EnableManualHold != null &&
                    this.EnableManualHold.Equals(other.EnableManualHold)
                ) && 
                (
                    this.MaximumHoldTime == other.MaximumHoldTime ||
                    this.MaximumHoldTime != null &&
                    this.MaximumHoldTime.Equals(other.MaximumHoldTime)
                ) && 
                (
                    this.PositionMessages == other.PositionMessages ||
                    this.PositionMessages != null &&
                    this.PositionMessages.SequenceEqual(other.PositionMessages)
                ) && 
                (
                    this.StatusMessages == other.StatusMessages ||
                    this.StatusMessages != null &&
                    this.StatusMessages.SequenceEqual(other.StatusMessages)
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
                
                if (this.AcceptRemoteRegistration != null)
                    hash = hash * 59 + this.AcceptRemoteRegistration.GetHashCode();
                
                if (this.EnableManualHold != null)
                    hash = hash * 59 + this.EnableManualHold.GetHashCode();
                
                if (this.MaximumHoldTime != null)
                    hash = hash * 59 + this.MaximumHoldTime.GetHashCode();
                
                if (this.PositionMessages != null)
                    hash = hash * 59 + this.PositionMessages.GetHashCode();
                
                if (this.StatusMessages != null)
                    hash = hash * 59 + this.StatusMessages.GetHashCode();
                
                return hash;
            }
        }

    }


}
