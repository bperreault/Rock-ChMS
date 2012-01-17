//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//

using System.ServiceModel.Web;

namespace Rock.REST.CMS
{
    public partial class UserService
    {
		/// <summary>
		/// Gets a User object
		/// </summary>
		[WebGet( UriTemplate = "Available/{username}" )]
        public bool Available( string username )
        {
            using (Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope())
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.CMS.UserService UserService = new Rock.CMS.UserService();
                Rock.CMS.User User = UserService.GetByApplicationNameAndUsername( "RockChMS", username );
                return ( User == null );
            }
        }
	
    }
}
