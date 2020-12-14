using System;
using System.Collections.Generic;

namespace PrizesService.Models.DBModels
{
    public partial class UsersNationalities
    {
        public int? UserId { get; set; }
        public int? NationalityId { get; set; }

        public virtual Nationalities Nationality { get; set; }
        public virtual Users User { get; set; }
    }
}
