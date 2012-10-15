//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Rock.CodeGeneration project
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;

using Rock.Data;

namespace Rock.Cms
{
    /// <summary>
    /// Data Transfer Object for HtmlContent object
    /// </summary>
    public partial class HtmlContentDto : IDto
    {

#pragma warning disable 1591
        public int BlockId { get; set; }
        public string EntityValue { get; set; }
        public int Version { get; set; }
        public string Content { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedByPersonId { get; set; }
        public DateTime? ApprovedDateTime { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? ExpireDateTime { get; set; }
        public int Id { get; set; }
        public Guid Guid { get; set; }
#pragma warning restore 1591

        /// <summary>
        /// Instantiates a new DTO object
        /// </summary>
        public HtmlContentDto ()
        {
        }

        /// <summary>
        /// Instantiates a new DTO object from the entity
        /// </summary>
        /// <param name="htmlContent"></param>
        public HtmlContentDto ( HtmlContent htmlContent )
        {
            CopyFromModel( htmlContent );
        }

        /// <summary>
        /// Copies the model property values to the DTO properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyFromModel( IEntity model )
        {
            if ( model is HtmlContent )
            {
                var htmlContent = (HtmlContent)model;
                this.BlockId = htmlContent.BlockId;
                this.EntityValue = htmlContent.EntityValue;
                this.Version = htmlContent.Version;
                this.Content = htmlContent.Content;
                this.IsApproved = htmlContent.IsApproved;
                this.ApprovedByPersonId = htmlContent.ApprovedByPersonId;
                this.ApprovedDateTime = htmlContent.ApprovedDateTime;
                this.StartDateTime = htmlContent.StartDateTime;
                this.ExpireDateTime = htmlContent.ExpireDateTime;
                this.Id = htmlContent.Id;
                this.Guid = htmlContent.Guid;
            }
        }

        /// <summary>
        /// Copies the DTO property values to the entity properties
        /// </summary>
        /// <param name="model">The model.</param>
        public void CopyToModel ( IEntity model )
        {
            if ( model is HtmlContent )
            {
                var htmlContent = (HtmlContent)model;
                htmlContent.BlockId = this.BlockId;
                htmlContent.EntityValue = this.EntityValue;
                htmlContent.Version = this.Version;
                htmlContent.Content = this.Content;
                htmlContent.IsApproved = this.IsApproved;
                htmlContent.ApprovedByPersonId = this.ApprovedByPersonId;
                htmlContent.ApprovedDateTime = this.ApprovedDateTime;
                htmlContent.StartDateTime = this.StartDateTime;
                htmlContent.ExpireDateTime = this.ExpireDateTime;
                htmlContent.Id = this.Id;
                htmlContent.Guid = this.Guid;
            }
        }
    }
}
