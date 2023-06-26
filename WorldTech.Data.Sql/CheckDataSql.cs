using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldTech.DI;

namespace WorldTech.Data.Sql
{
    public class CheckDataSql : ICheckData<ICheck>
    {
        public void AddCheck(ICheck check)
        {
            using (var database = new WorldTechContext())
            {
                var currentCheck = new CheckEntity(check);
                database.Checks.Add(currentCheck);
                database.SaveChanges();
            }
        }

        public ICheck FindCheck(ICheck check)
        {
            using (var database = new WorldTechContext())
            {
                var currentCheck = database.Checks.SingleOrDefault(unknownCheck => unknownCheck.Cart.Equals(check.Cart)
                && unknownCheck.Shop.Equals(check.Shop) && unknownCheck.DateTime.Equals(check.DateTime));
                return currentCheck;
            }
        }

        public IEnumerable<ICheck> ReadAllChecks()
        {
            using (var database = new WorldTechContext())
            {
                return database.Checks.ToList();
            }
        }

        public void RemoveCheck(ICheck check)
        {
            using (var database = new WorldTechContext())
            {
                var checkToRemove = database.Checks.SingleOrDefault(unknownCheck => unknownCheck.Cart.Equals(check.Cart)
                && unknownCheck.Shop.Equals(check.Shop) && unknownCheck.DateTime.Equals(check.DateTime));
                database.Checks.Remove(checkToRemove);
                database.SaveChanges();
            }
        }
    }
}
