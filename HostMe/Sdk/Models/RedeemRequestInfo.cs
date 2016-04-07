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
    public partial class RedeemRequestInfo :  IEquatable<RedeemRequestInfo>
    { 
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum {
            
            [EnumMember(Value = "Submited")]
            Submited,
            
            [EnumMember(Value = "Approved")]
            Approved,
            
            [EnumMember(Value = "Rejected")]
            Rejected
        }

    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RedeemRequestInfo" /> class.
        /// Initializes a new instance of the <see cref="RedeemRequestInfo" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StatusComment">StatusComment.</param>
        /// <param name="TableNumber">TableNumber.</param>

        public RedeemRequestInfo(string Id = null, StatusEnum? Status = null, string StatusComment = null, string TableNumber = null)
        {
            this.Id = Id;
            this.Status = Status;
            this.StatusComment = StatusComment;
            this.TableNumber = TableNumber;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets StatusComment
        /// </summary>
        [DataMember(Name="statusComment", EmitDefaultValue=false)]
        public string StatusComment { get; set; }
    
        /// <summary>
        /// Gets or Sets TableNumber
        /// </summary>
        [DataMember(Name="tableNumber", EmitDefaultValue=false)]
        public string TableNumber { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedeemRequestInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusComment: ").Append(StatusComment).Append("\n");
            sb.Append("  TableNumber: ").Append(TableNumber).Append("\n");
            
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
            return this.Equals(obj as RedeemRequestInfo);
        }

        /// <summary>
        /// Returns true if RedeemRequestInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RedeemRequestInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedeemRequestInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusComment == other.StatusComment ||
                    this.StatusComment != null &&
                    this.StatusComment.Equals(other.StatusComment)
                ) && 
                (
                    this.TableNumber == other.TableNumber ||
                    this.TableNumber != null &&
                    this.TableNumber.Equals(other.TableNumber)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                
                if (this.StatusComment != null)
                    hash = hash * 59 + this.StatusComment.GetHashCode();
                
                if (this.TableNumber != null)
                    hash = hash * 59 + this.TableNumber.GetHashCode();
                
                return hash;
            }
        }

    }


}
