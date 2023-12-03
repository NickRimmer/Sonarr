using FluentMigrator;
using NzbDrone.Core.Datastore.Migration.Framework;
namespace NzbDrone.Core.Datastore.Migration;

[Migration(201)]
public class AddSeriesAliases : NzbDroneMigrationBase
{
    protected override void MainDbUpgrade()
    {
        Alter.Table("Series").AddColumn("Aliases").AsString().Nullable();
    }
}
