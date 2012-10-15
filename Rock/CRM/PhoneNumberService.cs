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
using System.Linq;

using Rock.Data;

namespace Rock.Crm
{
    /// <summary>
    /// PhoneNumber Service class
    /// </summary>
    public partial class PhoneNumberService : Service<PhoneNumber, PhoneNumberDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberService"/> class
        /// </summary>
        public PhoneNumberService()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberService"/> class
        /// </summary>
        public PhoneNumberService(IRepository<PhoneNumber> repository) : base(repository)
        {
        }

        /// <summary>
        /// Creates a new model
        /// </summary>
        public override PhoneNumber CreateNew()
        {
            return new PhoneNumber();
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public override IQueryable<PhoneNumberDto> QueryableDto( )
        {
            return QueryableDto( this.Queryable() );
        }

        /// <summary>
        /// Query DTO objects
        /// </summary>
        /// <returns>A queryable list of DTO objects</returns>
        public IQueryable<PhoneNumberDto> QueryableDto( IQueryable<PhoneNumber> items )
        {
            return items.Select( m => new PhoneNumberDto()
                {
                    IsSystem = m.IsSystem,
                    PersonId = m.PersonId,
                    Number = m.Number,
                    Extension = m.Extension,
                    NumberTypeId = m.NumberTypeId,
                    IsMessagingEnabled = m.IsMessagingEnabled,
                    IsUnlisted = m.IsUnlisted,
                    Description = m.Description,
                    Id = m.Id,
                    Guid = m.Guid,
                });
        }
    }
}
