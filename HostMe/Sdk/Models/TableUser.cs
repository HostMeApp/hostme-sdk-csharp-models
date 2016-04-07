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
    public partial class TableUser :  IEquatable<TableUser>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TableUser" /> class.
        /// Initializes a new instance of the <see cref="TableUser" />class.
        /// </summary>
        /// <param name="Table">Table.</param>
        /// <param name="User">User.</param>
        /// <param name="RegistrationTime">RegistrationTime.</param>
        /// <param name="EstimatedReleaseTime">EstimatedReleaseTime.</param>

        public TableUser(TableInfo Table = null, UserProfile User = null, DateTimeOffset? RegistrationTime = null, DateTimeOffset? EstimatedReleaseTime = null)
        {
            this.Table = Table;
            this.User = User;
            this.RegistrationTime = RegistrationTime;
            this.EstimatedReleaseTime = EstimatedReleaseTime;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Table
        /// </summary>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public TableInfo Table { get; set; }
    
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UserProfile User { get; set; }
    
        /// <summary>
        /// Gets or Sets RegistrationTime
        /// </summary>
        [DataMember(Name="registrationTime", EmitDefaultValue=false)]
        public DateTimeOffset? RegistrationTime { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedReleaseTime
        /// </summary>
        [DataMember(Name="estimatedReleaseTime", EmitDefaultValue=false)]
        public DateTimeOffset? EstimatedReleaseTime { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TableUser {\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  RegistrationTime: ").Append(RegistrationTime).Append("\n");
            sb.Append("  EstimatedReleaseTime: ").Append(EstimatedReleaseTime).Append("\n");
            
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
            return this.Equals(obj as TableUser);
        }

        /// <summary>
        /// Returns true if TableUser instances are equal
        /// </summary>
        /// <param name="other">Instance of TableUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TableUser other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Table == other.Table ||
                    this.Table != null &&
                    this.Table.Equals(other.Table)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.RegistrationTime == other.RegistrationTime ||
                    this.RegistrationTime != null &&
                    this.RegistrationTime.Equals(other.RegistrationTime)
                ) && 
                (
                    this.EstimatedReleaseTime == other.EstimatedReleaseTime ||
                    this.EstimatedReleaseTime != null &&
                    this.EstimatedReleaseTime.Equals(other.EstimatedReleaseTime)
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
                
                if (this.Table != null)
                    hash = hash * 59 + this.Table.GetHashCode();
                
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                
                if (this.RegistrationTime != null)
                    hash = hash * 59 + this.RegistrationTime.GetHashCode();
                
                if (this.EstimatedReleaseTime != null)
                    hash = hash * 59 + this.EstimatedReleaseTime.GetHashCode();
                
                return hash;
            }
        }

    }


}
