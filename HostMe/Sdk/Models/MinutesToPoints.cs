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
    public partial class MinutesToPoints :  IEquatable<MinutesToPoints>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MinutesToPoints" /> class.
        /// Initializes a new instance of the <see cref="MinutesToPoints" />class.
        /// </summary>
        /// <param name="FlatPoints">FlatPoints.</param>
        /// <param name="MaxMinutes">MaxMinutes.</param>
        /// <param name="Method">Method.</param>
        /// <param name="MinMinutes">MinMinutes.</param>
        /// <param name="PointsPerMinutes">PointsPerMinutes.</param>

        public MinutesToPoints(int? FlatPoints = null, int? MaxMinutes = null, string Method = null, int? MinMinutes = null, int? PointsPerMinutes = null)
        {
            this.FlatPoints = FlatPoints;
            this.MaxMinutes = MaxMinutes;
            this.Method = Method;
            this.MinMinutes = MinMinutes;
            this.PointsPerMinutes = PointsPerMinutes;
            
        }
        
    
        /// <summary>
        /// Gets or Sets FlatPoints
        /// </summary>
        [DataMember(Name="flatPoints", EmitDefaultValue=false)]
        public int? FlatPoints { get; set; }
    
        /// <summary>
        /// Gets or Sets MaxMinutes
        /// </summary>
        [DataMember(Name="maxMinutes", EmitDefaultValue=false)]
        public int? MaxMinutes { get; set; }
    
        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public string Method { get; set; }
    
        /// <summary>
        /// Gets or Sets MinMinutes
        /// </summary>
        [DataMember(Name="minMinutes", EmitDefaultValue=false)]
        public int? MinMinutes { get; set; }
    
        /// <summary>
        /// Gets or Sets PointsPerMinutes
        /// </summary>
        [DataMember(Name="pointsPerMinutes", EmitDefaultValue=false)]
        public int? PointsPerMinutes { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MinutesToPoints {\n");
            sb.Append("  FlatPoints: ").Append(FlatPoints).Append("\n");
            sb.Append("  MaxMinutes: ").Append(MaxMinutes).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  MinMinutes: ").Append(MinMinutes).Append("\n");
            sb.Append("  PointsPerMinutes: ").Append(PointsPerMinutes).Append("\n");
            
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
            return this.Equals(obj as MinutesToPoints);
        }

        /// <summary>
        /// Returns true if MinutesToPoints instances are equal
        /// </summary>
        /// <param name="other">Instance of MinutesToPoints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MinutesToPoints other)
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
                    this.MaxMinutes == other.MaxMinutes ||
                    this.MaxMinutes != null &&
                    this.MaxMinutes.Equals(other.MaxMinutes)
                ) && 
                (
                    this.Method == other.Method ||
                    this.Method != null &&
                    this.Method.Equals(other.Method)
                ) && 
                (
                    this.MinMinutes == other.MinMinutes ||
                    this.MinMinutes != null &&
                    this.MinMinutes.Equals(other.MinMinutes)
                ) && 
                (
                    this.PointsPerMinutes == other.PointsPerMinutes ||
                    this.PointsPerMinutes != null &&
                    this.PointsPerMinutes.Equals(other.PointsPerMinutes)
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
                
                if (this.MaxMinutes != null)
                    hash = hash * 59 + this.MaxMinutes.GetHashCode();
                
                if (this.Method != null)
                    hash = hash * 59 + this.Method.GetHashCode();
                
                if (this.MinMinutes != null)
                    hash = hash * 59 + this.MinMinutes.GetHashCode();
                
                if (this.PointsPerMinutes != null)
                    hash = hash * 59 + this.PointsPerMinutes.GetHashCode();
                
                return hash;
            }
        }

    }


}
