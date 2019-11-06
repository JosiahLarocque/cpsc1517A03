using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema; //4. allows to reference a table from step 3
using System.ComponentModel.DataAnnotations; //.6 allows to reference a key from step 5
#endregion

namespace NorthwindSystem.Data
{
    [Table("Region")]
    public class Region
    {
        //use this after key if its a non Identity field in database
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    }
}
