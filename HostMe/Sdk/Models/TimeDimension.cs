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
    public partial class TimeDimension :  IEquatable<TimeDimension>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeDimension" /> class.
        /// Initializes a new instance of the <see cref="TimeDimension" />class.
        /// </summary>
        /// <param name="Hour">Hour.</param>
        /// <param name="WeekDay">WeekDay.</param>
        /// <param name="WeekDayNumber">WeekDayNumber.</param>
        /// <param name="Month">Month.</param>
        /// <param name="MonthNumber">MonthNumber.</param>
        /// <param name="Year">Year.</param>
        /// <param name="WeekNumber">WeekNumber.</param>
        /// <param name="TypeOfMeal">TypeOfMeal.</param>

        public TimeDimension(int? Hour = null, string WeekDay = null, int? WeekDayNumber = null, string Month = null, int? MonthNumber = null, int? Year = null, int? WeekNumber = null, string TypeOfMeal = null)
        {
            this.Hour = Hour;
            this.WeekDay = WeekDay;
            this.WeekDayNumber = WeekDayNumber;
            this.Month = Month;
            this.MonthNumber = MonthNumber;
            this.Year = Year;
            this.WeekNumber = WeekNumber;
            this.TypeOfMeal = TypeOfMeal;
            
        }
        
    
        /// <summary>
        /// Gets or Sets Hour
        /// </summary>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }
    
        /// <summary>
        /// Gets or Sets WeekDay
        /// </summary>
        [DataMember(Name="weekDay", EmitDefaultValue=false)]
        public string WeekDay { get; set; }
    
        /// <summary>
        /// Gets or Sets WeekDayNumber
        /// </summary>
        [DataMember(Name="weekDayNumber", EmitDefaultValue=false)]
        public int? WeekDayNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public string Month { get; set; }
    
        /// <summary>
        /// Gets or Sets MonthNumber
        /// </summary>
        [DataMember(Name="monthNumber", EmitDefaultValue=false)]
        public int? MonthNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }
    
        /// <summary>
        /// Gets or Sets WeekNumber
        /// </summary>
        [DataMember(Name="weekNumber", EmitDefaultValue=false)]
        public int? WeekNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets TypeOfMeal
        /// </summary>
        [DataMember(Name="typeOfMeal", EmitDefaultValue=false)]
        public string TypeOfMeal { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeDimension {\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  WeekDay: ").Append(WeekDay).Append("\n");
            sb.Append("  WeekDayNumber: ").Append(WeekDayNumber).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  MonthNumber: ").Append(MonthNumber).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  WeekNumber: ").Append(WeekNumber).Append("\n");
            sb.Append("  TypeOfMeal: ").Append(TypeOfMeal).Append("\n");
            
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
            return this.Equals(obj as TimeDimension);
        }

        /// <summary>
        /// Returns true if TimeDimension instances are equal
        /// </summary>
        /// <param name="other">Instance of TimeDimension to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeDimension other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Hour == other.Hour ||
                    this.Hour != null &&
                    this.Hour.Equals(other.Hour)
                ) && 
                (
                    this.WeekDay == other.WeekDay ||
                    this.WeekDay != null &&
                    this.WeekDay.Equals(other.WeekDay)
                ) && 
                (
                    this.WeekDayNumber == other.WeekDayNumber ||
                    this.WeekDayNumber != null &&
                    this.WeekDayNumber.Equals(other.WeekDayNumber)
                ) && 
                (
                    this.Month == other.Month ||
                    this.Month != null &&
                    this.Month.Equals(other.Month)
                ) && 
                (
                    this.MonthNumber == other.MonthNumber ||
                    this.MonthNumber != null &&
                    this.MonthNumber.Equals(other.MonthNumber)
                ) && 
                (
                    this.Year == other.Year ||
                    this.Year != null &&
                    this.Year.Equals(other.Year)
                ) && 
                (
                    this.WeekNumber == other.WeekNumber ||
                    this.WeekNumber != null &&
                    this.WeekNumber.Equals(other.WeekNumber)
                ) && 
                (
                    this.TypeOfMeal == other.TypeOfMeal ||
                    this.TypeOfMeal != null &&
                    this.TypeOfMeal.Equals(other.TypeOfMeal)
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
                
                if (this.Hour != null)
                    hash = hash * 59 + this.Hour.GetHashCode();
                
                if (this.WeekDay != null)
                    hash = hash * 59 + this.WeekDay.GetHashCode();
                
                if (this.WeekDayNumber != null)
                    hash = hash * 59 + this.WeekDayNumber.GetHashCode();
                
                if (this.Month != null)
                    hash = hash * 59 + this.Month.GetHashCode();
                
                if (this.MonthNumber != null)
                    hash = hash * 59 + this.MonthNumber.GetHashCode();
                
                if (this.Year != null)
                    hash = hash * 59 + this.Year.GetHashCode();
                
                if (this.WeekNumber != null)
                    hash = hash * 59 + this.WeekNumber.GetHashCode();
                
                if (this.TypeOfMeal != null)
                    hash = hash * 59 + this.TypeOfMeal.GetHashCode();
                
                return hash;
            }
        }

    }


}
