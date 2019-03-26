/* 
 * Library API
 *
 * Through this API you can access authors and their books.
 *
 * OpenAPI spec version: 1.0
 * Contact: kevin.dockx@gmail.com
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
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Book
    /// </summary>
    [DataContract]
        public partial class Book :  IEquatable<Book>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Book" /> class.
        /// </summary>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        /// <param name="">.</param>
        public Book(Guid?  = default(Guid?), string  = default(string), string  = default(string), string  = default(string), string  = default(string))
        {
            this.Id = ;
            this.AuthorFirstName = ;
            this.AuthorLastName = ;
            this.Title = ;
            this.Description = ;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets AuthorFirstName
        /// </summary>
        [DataMember(Name="authorFirstName", EmitDefaultValue=false)]
        public string AuthorFirstName { get; set; }

        /// <summary>
        /// Gets or Sets AuthorLastName
        /// </summary>
        [DataMember(Name="authorLastName", EmitDefaultValue=false)]
        public string AuthorLastName { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Book {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AuthorFirstName: ").Append(AuthorFirstName).Append("\n");
            sb.Append("  AuthorLastName: ").Append(AuthorLastName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as Book);
        }

        /// <summary>
        /// Returns true if Book instances are equal
        /// </summary>
        /// <param name="input">Instance of Book to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Book input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AuthorFirstName == input.AuthorFirstName ||
                    (this.AuthorFirstName != null &&
                    this.AuthorFirstName.Equals(input.AuthorFirstName))
                ) && 
                (
                    this.AuthorLastName == input.AuthorLastName ||
                    (this.AuthorLastName != null &&
                    this.AuthorLastName.Equals(input.AuthorLastName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AuthorFirstName != null)
                    hashCode = hashCode * 59 + this.AuthorFirstName.GetHashCode();
                if (this.AuthorLastName != null)
                    hashCode = hashCode * 59 + this.AuthorLastName.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
            yield break;
        }
    }
}
