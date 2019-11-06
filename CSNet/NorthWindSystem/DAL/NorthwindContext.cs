using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using System.Data.Entity; //1. 
//using NorthWindSystem.Data; //2. points to the data definition
#endregion
namespace NorthWindSystem.DAL
{
    //security enhancement using access privaledge: internal
    //restrict the access to this class to calls from within this project 

    //this class needs to tie into EntityFramework
    //this will be done by inheriting the class DbContext
    internal class NorthwindContext:DbContext //3.
    {
        //this class needs to supply DbContext with the application's
        //  connection string name
        //this name is supplied to DbContext using the constructor of this class

        public NorthwindContext():base("NWDB") //4. (create webconfig file if not existing )  also add the connectionstring in web.config and add context tag
        {

        }


        //we need properties in this class that will be used by
        //  EntityFramework to transport the data into your application
        //each entity will have their own "transportation set"


        //the coding standard for this course will be plural for the DbSet<T>
        //  Property names
        public DbSet<Product> Products { get; set; } //5.
        public DbSet<Region> Regions { get; set; }//6. do this for each entity

    }
}
