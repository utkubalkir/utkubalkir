using Berut.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berut.Entities.Concrete
{
    public class OTOutput:IEntity
    {
        public int Id { get; set; }
        public string Plate { get; set; }
        public string Driver { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string AuthorizedName { get; set; }
        public int EntryWeight { get; set; }
        public int ReleaseWeight { get; set; }
        public int ProductWeight { get; set; }

    }
}
