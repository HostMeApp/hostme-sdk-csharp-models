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
    public partial class RewardValue :  IEquatable<RewardValue>
    { 
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "Discount")]
            Discount,
            
            [EnumMember(Value = "FreeMeal")]
            Freemeal,
            
            [EnumMember(Value = "MoneyOff")]
            Moneyoff
        }

    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RewardValue" /> class.
        /// Initializes a new instance of the <see cref="RewardValue" />class.
        /// </summary>
        /// <param name="Amount">Amount.</param>
        /// <param name="Description">Description.</param>
        /// <param name="Discount">Discount.</param>
        /// <param name="FreeMeal">FreeMeal.</param>
        /// <param name="ImageUrl">ImageUrl.</param>
        /// <param name="Type">Type.</param>

        public RewardValue(double? Amount = null, string Description = null, double? Discount = null, string FreeMeal = null, string ImageUrl = null, TypeEnum? Type = null)
        {
            this.Amount = Amount;
            this.Description = Description;
            this.Discount = Discount;
            this.FreeMeal = FreeMeal;
            this.ImageUrl = ImageUrl;
            this.Type = Type;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }
    
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or Sets Discount
        /// </summary>
        [DataMember(Name="discount", EmitDefaultValue=false)]
        public double? Discount { get; set; }
    
        /// <summary>
        /// Gets or Sets FreeMeal
        /// </summary>
        [DataMember(Name="freeMeal", EmitDefaultValue=false)]
        public string FreeMeal { get; set; }
    
        /// <summary>
        /// Gets or Sets ImageUrl
        /// </summary>
        [DataMember(Name="imageUrl", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RewardValue {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  FreeMeal: ").Append(FreeMeal).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            
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
            return this.Equals(obj as RewardValue);
        }

        /// <summary>
        /// Returns true if RewardValue instances are equal
        /// </summary>
        /// <param name="other">Instance of RewardValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RewardValue other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.Discount == other.Discount ||
                    this.Discount != null &&
                    this.Discount.Equals(other.Discount)
                ) && 
                (
                    this.FreeMeal == other.FreeMeal ||
                    this.FreeMeal != null &&
                    this.FreeMeal.Equals(other.FreeMeal)
                ) && 
                (
                    this.ImageUrl == other.ImageUrl ||
                    this.ImageUrl != null &&
                    this.ImageUrl.Equals(other.ImageUrl)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Discount != null)
                    hash = hash * 59 + this.Discount.GetHashCode();
                
                if (this.FreeMeal != null)
                    hash = hash * 59 + this.FreeMeal.GetHashCode();
                
                if (this.ImageUrl != null)
                    hash = hash * 59 + this.ImageUrl.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                return hash;
            }
        }

    }


}
