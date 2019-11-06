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
    //syntax [Table("mytablename"[,schema="the sqlschemaname"])]
    //a schema is a group of tables in a database
    [Table("Products")]  //3. annotation that will point this class to the appropriate sql table
    public class Product //1. create class  2. Add "public" to class
    {
        //all sql attributes will have a corresponding class property

        //IF you use the attribute name as your property name
        //   the physical order of the properties do not need to match 
        //   your sql attr. order

        //you need a [Key] annotation for your primary key field
        //[Key] used on an identity PK field:

        //Default: [Key,DataGenerated(DataGeneratedOption.Identity)]

        //[Key, Column[Order=n]] - used for compound PK's where
        //      n represents the physical order of the components,
        //      n starts a 1 (natural number)
        //[Key,DataGenerated(DataGeneratedOption.None)] - used for 
        //      PK's no compound or user supplied (NOT Identity)

        [Key] //.5 All below: 
        //instantiate a field - mapping your sql table to your program
              //The creation of this class is called mapping. this is how to supply the
              //definition of the sql table to your application
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        //There is a foreign key annotation [ForeignKey] BUT it is optionally
        //specifying the annotation is ONLY NEEDED IF your foreign key
        //      sql field name is not the same as the associated primary key
        //      field name or if you use a different name in your mapping

        public int? SupplierID { get; set; } //int? (question mark) after means field is nullable
        public int? CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal? UnitPrice { get; set; }

        public Int16? UnitsInStock { get; set; } 
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }

        public bool Discontinued { get; set; }

        //optionally you can add your default and/or greedy constructors

        //other annotation examples
        //lets assume you would like to concatenate some fields
        //      together within your application on several occasions
        //      such as creating a full name out of two attributes FirstName and LastName

        //these are readonly non mapped fields.
        //these properties do NOT expect data to be given to them
        //EntityFramework will NOT expect data to be placed into these
        //      properties to be passed on to the database

        [NotMapped] //6.
        public string ProductAndID //7.
        {
            get
            {
                return ProductName + "(" + ProductID.ToString() + ")";
            }
        }
    }
}
