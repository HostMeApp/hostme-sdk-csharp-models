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
    public partial class RewardInfo :  IEquatable<RewardInfo>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RewardInfo" /> class.
        /// Initializes a new instance of the <see cref="RewardInfo" />class.
        /// </summary>
        /// <param name="Description">Description.</param>
        /// <param name="Id">Id.</param>
        /// <param name="ImageUrl">ImageUrl.</param>
        /// <param name="PriceInPoints">PriceInPoints.</param>
        /// <param name="RedeemRequest">RedeemRequest.</param>
        /// <param name="Value">Value.</param>

        public RewardInfo(string Description = null, string Id = null, string ImageUrl = null, double? PriceInPoints = null, RedeemRequestInfo RedeemRequest = null, RewardValue Value = null)
        {
            this.Description = Description;
            this.Id = Id;
            this.ImageUrl = ImageUrl;
            this.PriceInPoints = PriceInPoints;
            this.RedeemRequest = RedeemRequest;
            this.Value = Value;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
    
        /// <summary>
        /// Gets or Sets PriceInPoints
        /// </summary>
        [DataMember(Name="priceInPoints", EmitDefaultValue=false)]
        public double? PriceInPoints { get; set; }
    
        /// <summary>
        /// Gets or Sets RedeemRequest
        /// </summary>
        [DataMember(Name="redeemRequest", EmitDefaultValue=false)]
        public RedeemRequestInfo RedeemRequest { get; set; }
    
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public RewardValue Value { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RewardInfo {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  PriceInPoints: ").Append(PriceInPoints).Append("\n");
            sb.Append("  RedeemRequest: ").Append(RedeemRequest).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            
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
            return this.Equals(obj as RewardInfo);
        }

        /// <summary>
        /// Returns true if RewardInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of RewardInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RewardInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.PriceInPoints == other.PriceInPoints ||
                    this.PriceInPoints != null &&
                    this.PriceInPoints.Equals(other.PriceInPoints)
                ) && 
                (
                    this.RedeemRequest == other.RedeemRequest ||
                    this.RedeemRequest != null &&
                    this.RedeemRequest.Equals(other.RedeemRequest)
                ) && 
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                
                if (this.PriceInPoints != null)
                    hash = hash * 59 + this.PriceInPoints.GetHashCode();
                
                if (this.RedeemRequest != null)
                    hash = hash * 59 + this.RedeemRequest.GetHashCode();
                
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                
                return hash;
            }
        }

    }


}
