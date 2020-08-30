/* File Name: DatabaseSettings.cs
 * Purpose: To provide a data model and interface
 *          for the database settings for the webapp
 * Rev History:
 *     Created Aug 2020 by Tim Nigh
 */


namespace PizzaOrders.Models
{
    public interface IDatabaseSettings
    {
        string ConnectionString{get;set;}
        string DatabaseName{get;set;}
    }
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString{get;set;}
        public string DatabaseName{get;set;}
    }
}