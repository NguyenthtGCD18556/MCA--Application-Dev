namespace GCD0705.AppDev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTaskModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Tasks", "Description", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Description", c => c.String());
            AlterColumn("dbo.Tasks", "Name", c => c.String());
        }
    }
}
