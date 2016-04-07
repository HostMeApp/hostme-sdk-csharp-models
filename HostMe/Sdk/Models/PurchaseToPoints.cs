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
    public partial class PurchaseToPoints :  IEquatable<PurchaseToPoints>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseToPoints" /> class.
        /// Initializes a new instance of the <see cref="PurchaseToPoints" />class.
        /// </summary>
        /// <param name="FlatPoints">FlatPoints.</param>
        /// <param name="MaxAmount">MaxAmount.</param>
        /// <param name="Method">Method.</param>
        /// <param name="MinAmount">MinAmount.</param>
        /// <param name="PointsPerCent">PointsPerCent.</param>

        public PurchaseToPoints(int? FlatPoints = null, double? MaxAmount = null, string Method = null, double? MinAmount = null, int? PointsPerCent = null)
        {
            this.FlatPoints = FlatPoints;
            this.MaxAmount = MaxAmount;
            this.Method = Method;
            this.MinAmount = MinAmount;
            this.PointsPerCent = PointsPerCent;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FlatPoints
        /// </summary>
        [DataMember(Name="flatPoints", EmitDefaultValue=false)]
        public int? FlatPoints { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxAmount
        /// </summary>
        [DataMember(Name="maxAmount", EmitDefaultValue=false)]
        public double? MaxAmount { get; set; }
    
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }
    
        /// <summary>
        /// Gets or Sets MinAmount
        /// </summary>
        [DataMember(Name="minAmount", EmitDefaultValue=false)]
        public double? MinAmount { get; set; }
    
        /// <summary>
        /// Gets or Sets PointsPerCent
        /// </summary>
        [DataMember(Name="pointsPerCent", EmitDefaultValue=false)]
        public int? PointsPerCent { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseToPoints {\n");
            sb.Append("  FlatPoints: ").Append(FlatPoints).Append("\n");
            sb.Append("  MaxAmount: ").Append(MaxAmount).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  MinAmount: ").Append(MinAmount).Append("\n");
            sb.Append("  PointsPerCent: ").Append(PointsPerCent).Append("\n");
            
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
            return this.Equals(obj as PurchaseToPoints);
        }

        /// <summary>
        /// Returns true if PurchaseToPoints instances are equal
        /// </summary>
        /// <param name="other">Instance of PurchaseToPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseToPoints other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FlatPoints == other.FlatPoints ||
                    this.FlatPoints != null &&
                    this.FlatPoints.Equals(other.FlatPoints)
                ) && 
                (
                    this.MaxAmount == other.MaxAmount ||
                    this.MaxAmount != null &&
                    this.MaxAmount.Equals(other.MaxAmount)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.MinAmount == other.MinAmount ||
                    this.MinAmount != null &&
                    this.MinAmount.Equals(other.MinAmount)
                ) && 
                (
                    this.PointsPerCent == other.PointsPerCent ||
                    this.PointsPerCent != null &&
                    this.PointsPerCent.Equals(other.PointsPerCent)
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
                
                if (this.FlatPoints != null)
                    hash = hash * 59 + this.FlatPoints.GetHashCode();
                
                if (this.MaxAmount != null)
                    hash = hash * 59 + this.MaxAmount.GetHashCode();
                
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                
                if (this.MinAmount != null)
                    hash = hash * 59 + this.MinAmount.GetHashCode();
                
                if (this.PointsPerCent != null)
                    hash = hash * 59 + this.PointsPerCent.GetHashCode();
                
                return hash;
            }
        }

    }


}
